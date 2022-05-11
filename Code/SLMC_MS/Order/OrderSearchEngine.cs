using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SLMC_MS.model;


namespace SLMC_MS
{
    public partial class OrderSearchEngine : Form
    {
        user myUser;
        List<order> orderList;
        
        public OrderSearchEngine(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();

            // Setup orderList
            staff myStaff = Users.GetStaff(myUser);
            if (myStaff != null && Staffs.isDealer(myStaff))
            {
                orderList = Orders.GetOrders(myStaff);
                lbl_dealerID.Hide();
                txt_dealerID.Hide();
                lbl_dealerName.Hide();
                txt_dealerName.Hide();
                lbl_amount.Location = new Point(28, 103);
                txt_minAmount.Location = new Point(124, 98);
                label1.Location = new Point(195, 103);
                txt_maxAmount.Location = new Point(212, 98);
            }
            else if (myStaff != null && Staffs.isAreaManager(myStaff))
            {
                team t = Teams.GetTeamByManagerID(myStaff.staffID);
                orderList = Orders.GetOrders(t);
            }
            else
                orderList = Orders.GetOrders();
        }

        private void OrderSearchEngine_Load(object sender, EventArgs e)
        {
            cbbox_province.Items.Clear();
            List<province> provinces = Provinces.GetProvinces();
            foreach(province p in provinces)
            {
                cbbox_province.Items.Add(p.province1);
            }
            date_from.Value = DateTime.Today.AddYears(-1);
        }

        private void OrderSearchEngine_Shown(object sender, EventArgs e)
        {
            DisplayOrders(orderList);
        }

        private void DisplayOrders(List<order> orders)
        {
            dgv_orderSearchList.Rows.Clear();

            orders = orders.OrderByDescending(i => i.orderID).ToList();
            int maxRowNumer = 100;
            int rowNum = 0;
            foreach(order o in orders)
            {
                if (rowNum >= maxRowNumer)
                    break;

                dgv_orderSearchList.Rows.Add(Cities.GetCity(o.cityID).city1, o.orderDate, o.orderID, Orders.GetOrderTotal(o.orderID),
                                             Orders.GetOrderStatus(o.orderID), o.dealerID, Staffs.GetStaff(o.dealerID).name);
                rowNum++;
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            List<order> searchList = orderList;

            String orderID = txt_orderID.Text;
            String dealerID = txt_dealerID.Text;
            String dealerName = txt_dealerName.Text;
            double min = txt_minAmount.Text.Equals("") ? 0 : Convert.ToDouble(txt_minAmount.Text);
            double max = txt_maxAmount.Text.Equals("") ? 9999999 : Convert.ToDouble(txt_maxAmount.Text);
            province province = Provinces.GetProvince(cbbox_province.Text);
            city city = Cities.GetCityByName(cbbox_city.Text);
            DateTime earliest = date_from.Value;
            DateTime latest = date_to.Value;

            // Filter by orderID
            if (!orderID.Equals(""))
                searchList = searchList.Where(i => i.orderID.ToString().Contains(orderID)).Select(i => i).ToList();

            // Filter by dealerID
            if (!dealerID.Equals(""))
                searchList = searchList.Where(i => i.dealerID.Contains(dealerID)).Select(i => i).ToList();

            // Filter by dealer name
            if (!dealerName.Equals("")) 
                searchList = searchList.Where(i => Staffs.GetStaffName(i.dealerID).Contains(dealerName)).Select(i => i).ToList();

            // Filter by amount
            if (!txt_minAmount.Text.Equals(""))
                searchList = searchList.Where(i => Orders.GetOrderTotal(i.orderID) >= min).Select(i => i).ToList();
            if (!txt_maxAmount.Text.Equals(""))
                searchList = searchList.Where(i => Orders.GetOrderTotal(i.orderID) <= max).Select(i => i).ToList();

            // Filter by order status
            if (!ckBox_processing.Checked)
                searchList = searchList.Where(i => !i.statusID.Equals(OrderStatus.Processing.statusID)).Select(i => i).ToList();
            if (!ckBox_assembled.Checked)
                searchList = searchList.Where(i => !i.statusID.Equals(OrderStatus.Assembled.statusID)).Select(i => i).ToList();
            if(!ckBox_packing.Checked)
                searchList = searchList.Where(i => !i.statusID.Equals(OrderStatus.Packing.statusID)).Select(i => i).ToList();
            if(!ckBox_delivering.Checked)
                searchList = searchList.Where(i => !i.statusID.Equals(OrderStatus.Delivering.statusID)).Select(i => i).ToList();
            if (!ckBox_complete.Checked)
                searchList = searchList.Where(i => !i.statusID.Equals(OrderStatus.Complete.statusID)).Select(i => i).ToList();
            if (!ckBox_cancel.Checked)
                searchList = searchList.Where(i => !i.statusID.Equals(OrderStatus.Cancel.statusID)).Select(i => i).ToList();

            // Filter by city
            if (city != null) 
                searchList = searchList.Where(i => i.cityID.Equals(city.cityID)).Select(i => i).ToList();

            // Filter by province
            if (province != null && city == null) 
            {
                List<order> provinceOrder = new List<order>();
                List<city> cities = Cities.GetCities(province);
                foreach(city c in cities)
                {
                    List<order> myOrders = searchList.Where(i => i.cityID.Equals(c.cityID)).Select(i => i).ToList();
                    provinceOrder.AddRange(myOrders);
                }
                provinceOrder = provinceOrder.OrderBy(i => i.orderID).Select(i => i).ToList();
                searchList = provinceOrder;
            }

            // Filter by date
            searchList = searchList.Where(i => i.orderDate >= earliest && i.orderDate <= latest).Select(i => i).ToList();

            DisplayOrders(searchList);
        }

        private void cbbox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbox_city.Text = "";
            cbbox_city.Items.Clear();

            if(!cbbox_province.Text.Equals(""))
            {
                province p = Provinces.GetProvince(cbbox_province.Text);
                var cityList = Cities.GetCities(p);
                foreach(city c in cityList)
                {
                    cbbox_city.Items.Add(c.city1);
                }
            }
        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            if (date_to.Value < date_from.Value)
                date_to.Value = date_from.Value;
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            if (date_to.Value < date_from.Value)
                date_to.Value = date_from.Value;
        }

        private void dgv_orderSearchList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            String orderID = dgv_orderSearchList.Rows[e.RowIndex].Cells[2].Value.ToString();
            ViewOrder p = new ViewOrder(orderID);
            p.Show();
            this.Hide();
        }

        private void txt_minAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_minAmount.Text, @"^\d*$"))
                txt_minAmount.Text = "";
        }

        private void txt_maxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_maxAmount.Text, @"^\d*$"))
                txt_maxAmount.Text = "";
        }

        private void picBox_return_Click(object sender, EventArgs e)
        {
            CloseThisPage();
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

    }

}

