using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMC_MS.model;

namespace SLMC_MS
{
    public partial class ProcessOrder : Form
    {
        user myUser;
        public ProcessOrder(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();
            try
            {
                PermissionCheck();
            }
            catch (PermissionDeniedException exc)
            {
                throw exc;
            }
        }

        private void PermissionCheck()
        {
            if (myUser.staffID == null)
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }

            staff myStaff = Users.GetStaff(myUser);
            if (!Staffs.isSalesOrderOfficer(myStaff))
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void CloseThisPage()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is HomePage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Close();
        }

        private void MyProcess_Load(object sender, EventArgs e)
        {
            var provList = Provinces.GetProvinces();
            foreach (province prov in provList)
            {
                cbBox_province.Items.Add(prov.province1);
            }
        }

        private void cbBox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckList_city.Items.Clear();
            dataGridView_order.Rows.Clear();
            lbl_weightValue.Text = "0.00";

            province prov = Provinces.GetProvince(cbBox_province.Text);
            var cityList = Cities.GetCities(prov);
            foreach (city myCity in cityList.ToList())
            {
                var orderList = Orders.GetOrders(myCity, OrderStatus.Processing);
                int orderCount = orderList.Count();

                ckList_city.Items.Add("(" + orderCount + ") " + myCity.city1);
            }
        }
        

        private void CalculateTotalWeight()
        {

            double tweight = 0;
            foreach (DataGridViewRow row in dataGridView_order.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {

                    tweight += Convert.ToDouble(row.Cells[4].Value);
                }
            }
            lbl_weightValue.Text = tweight.ToString("0.00");
        }

        private void bt_despatch_Click(object sender, EventArgs e)
        {
            if (dataGridView_order.RowCount == 0)
            {
                MessageBox.Show("Please select orders for assembly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(lbl_weightValue.Text) > 1500) 
            {
                MessageBox.Show("The total weight should not over 1500kg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int x = 0; x < dataGridView_order.RowCount; x++)
            {
                if ((bool)dataGridView_order.Rows[x].Cells[0].Value)
                {
                    CreateDespatchNote();
                    MessageBox.Show("Orders are assembled.", "Success");
                    OrderListResetRows();
                    //RemoveRow();
                    CalculateTotalWeight();
                    return;
                }
            }

            MessageBox.Show("Please select orders for assembly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateDespatchNote()
        {
            province p = Provinces.GetProvince(cbBox_province.Text);
            despatchnote DN = new despatchnote { provinceID = p.provinceID, packed = "N" };
            DespatchNotes.Add(DN);

            foreach (DataGridViewRow rows in dataGridView_order.Rows)
            {
                if ((Boolean)rows.Cells[0].Value)
                {
                    int myOrderID = Convert.ToInt32(rows.Cells[2].Value);
                    order myOrder = Orders.GetOrder(myOrderID);
                    Orders.AddToDespatchNote(DN, myOrder);
                }
            }
            DespatchNotes.UpdateDeliveryDate(DN);
        }

        private void ReloadOrder()
        {
            ckList_city.Items.Clear();
            dataGridView_order.Rows.Clear();
            lbl_weightValue.Text = "0.00";

            province prov = Provinces.GetProvince(cbBox_province.Text);
            var cityList = Cities.GetCities(prov);
            foreach (city myCity in cityList)
            {
                var orderList = Orders.GetOrders(myCity, OrderStatus.Processing);
                int orderCount = orderList.Count();

                ckList_city.Items.Add("(" + orderCount + ") " + myCity.city1);
            }
        }

        private void ckList_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderListResetRows();
        }

        private void OrderListResetRows()
        {
            dataGridView_order.Rows.Clear();
            lbl_weightValue.Text = "0.00";
            for (int n = 0; n < ckList_city.CheckedItems.Count; n++)
            {
                var cityText = ckList_city.CheckedItems[n].ToString().Split(')');
                String cityName = cityText[1].Remove(0, 1);

                String myCityID = Cities.GetCityID(cityName);
                var orderList = Orders.GetOrders(myCityID, OrderStatus.Processing);
                foreach (order orders in orderList.ToList())
                {
                    dataGridView_order.Rows.Add(false, Cities.GetCity(orders.cityID).city1, orders.orderID, orders.expDeliverTime, orders.weight);
                }
            }

            for (int n = 0; n < dataGridView_order.Rows.Count; n++)
            {
                if (Convert.ToDateTime(dataGridView_order.Rows[n].Cells[3].Value) < DateTime.Today)
                {
                    dataGridView_order.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
                    dataGridView_order.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView_order.Rows[n].DefaultCellStyle.Font = new Font(dataGridView_order.Rows[n].DataGridView.Font, FontStyle.Bold);
                }
            }
            dataGridView_order.Sort(dataGridView_order.Columns[3], ListSortDirection.Ascending);
        }

        private void dataGridView_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (!(bool)dataGridView_order.Rows[e.RowIndex].Cells[0].Value)
            {
                dataGridView_order.Rows[e.RowIndex].Cells[0].Value = true;
            }
            else
            {
                dataGridView_order.Rows[e.RowIndex].Cells[0].Value = false;
            }
            CalculateTotalWeight();
        }

        private void dataGridView_order_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void RemoveRow()
        {
            dataGridView_order.Rows.Clear();
            //foreach (DataGridViewRow rows in dataGridView_order.Rows)
            //{
            //    if (rows == dataGridView_order.SelectedRows[0])
            //    {
            //        if (!(bool)rows.Cells[0].Value)
            //        {
            //            rows.Cells[0].Value = true;
            //        }
            //        else
            //        {
            //            rows.Cells[0].Value = false;
            //        }
            //    }


            //    if ((Boolean)rows.Cells[0].Value)
            //    {
            //        dataGridView_order.Rows.Remove(rows);
            //    }
            //}
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        // Allow form move
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void picBox_return_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void dataGridView_order_Validated(object sender, EventArgs e)
        {

        }
    }
}
