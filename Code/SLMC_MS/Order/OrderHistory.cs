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
    public partial class OrderHistory : Form
    {
        user myUser;
        public OrderHistory(user myUser)
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

            String positionID = Users.GetPositionID(myUser);
            if (!positionID.Equals("DLR"))
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            dgv_completeOrder.Rows.Clear();
            dgv_incompleteOrder.Rows.Clear();

            staff myStaff = Users.GetStaff(myUser);
            var incompleteOrderList = Orders.GetIncompletedOrders(myStaff);
            foreach (order List in incompleteOrderList)
            {
                DateTime order_date = List.orderDate;
                DateTime rec_date = List.expDeliverTime;
                String oID = List.orderID.ToString();
                double amt = Orders.GetOrderTotal(List.orderID);
                String oStatus = Orders.GetOrderStatus(List.orderID);
                dgv_incompleteOrder.Rows.Add(false, order_date, rec_date, oID, "¥" + amt, oStatus, "Modify", "Cancel");
            }


            var completedOrderList = Orders.GetCompletedOrders(myStaff);
            foreach (order O in completedOrderList)
            {
                DateTime order_date = O.orderDate;
                DateTime rec_date = O.expDeliverTime;
                String oID = O.orderID.ToString();
                double amt = Orders.GetOrderTotal(O.orderID);
                String oStatus = Orders.GetOrderStatus(O.orderID);

                dgv_completeOrder.Rows.Add(order_date, rec_date, oID, "¥" + amt, oStatus);
            }

            foreach (DataGridViewRow rows in dgv_incompleteOrder.Rows)
            {
                String oStatus = Convert.ToString(rows.Cells[5].Value);
                if (!oStatus.Equals("Delivering"))
                    rows.Cells[0].ReadOnly = true;
            }

            dgv_incompleteOrder.Sort(dgv_incompleteOrder.Columns[2], ListSortDirection.Descending);
            dgv_completeOrder.Sort(dgv_completeOrder.Columns[0], ListSortDirection.Descending);
        }

        private void dgv_incompleteOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                ClickModify(e.RowIndex);
            } if (e.ColumnIndex == 7)
            {
                ClickCancel(e.RowIndex);
            }
            else
                return;
        }

        private void ClickModify(int rowIndex)
        {
            String oID = Convert.ToString(dgv_incompleteOrder.Rows[rowIndex].Cells[3].Value);
            ModifyOrder mo = new ModifyOrder(myUser, oID);

            try
            {
                mo.Show();
            }
            catch(System.ObjectDisposedException exp) {
                this.Hide();
            }
            catch(ConstraintException exp) { }
        }

        private void ClickCancel(int rowIndex)
        {
            String oStatus = Convert.ToString(dgv_incompleteOrder.Rows[rowIndex].Cells[5].Value);
            if (oStatus != "Processing")
            {
                MessageBox.Show("Unable to Cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ans = MessageBox.Show("Are you sure to cancel this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.No)
                return;

            int oID = Convert.ToInt32(dgv_incompleteOrder.Rows[rowIndex].Cells[3].Value);
            order O = Orders.GetOrder(oID);
            Orders.Cancel(O);
            LoadOrder();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            bool emptySelection = true;
            for (int n = 0; n < dgv_incompleteOrder.RowCount; n++)
            {
                if (Convert.ToBoolean(dgv_incompleteOrder.Rows[n].Cells[0].Value)) 
                {
                    emptySelection = false;

                    int oID = Convert.ToInt32(dgv_incompleteOrder.Rows[n].Cells[3].Value);
                    order O = Orders.GetOrder(oID);
                    Orders.Complete(O);
                }
            }
            if (emptySelection)
                MessageBox.Show("Please select the received order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                LoadOrder();
        }

        private void OrderHistory_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
                LoadOrder();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void ViewOrderDetails(String orderID)
        {
            ViewOrder v = new ViewOrder(orderID);
            v.Show();
            this.Hide();
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

        private void dgv_completeOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_incompleteOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
