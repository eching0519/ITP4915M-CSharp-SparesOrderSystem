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
using System.Text.RegularExpressions;

namespace SLMC_MS
{
    public partial class ReserveItems : Form
    {
        user myUser;
        List<reserveditem> reserveditemsList;

        public ReserveItems(user myUser)
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
            reserveditemsList = Items.GetReservedItems(Users.GetStaff(myUser));
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

        private void ReserveItems_Load(object sender, EventArgs e)
        {
            DisplayReservedRecord(reserveditemsList);
        }

        private void DisplayReservedRecord(List<reserveditem> reserveditems)
        {
            dgv_inProgress.Rows.Clear();
            dgv_available.Rows.Clear();
            foreach (reserveditem reserveditem in reserveditems)
            {
                String status = "";
                String itemName = "";
                if (!reserveditem.availible.Equals("Y"))
                {
                    status = reserveditem.availible.Equals("N") ? "Processing" : "Replenishing";
                    itemName = Items.GetItem(reserveditem.itemID).name;
                    dgv_inProgress.Rows.Add(reserveditem.reserveID, reserveditem.itemID, itemName, reserveditem.reservedAmt, status, "Cancel");
                }
                else
                {
                    status = "Available";
                    itemName = Items.GetItem(reserveditem.itemID).name;
                    int day = DateTime.Today.CompareTo(reserveditem.completedDate);
                    dgv_available.Rows.Add(reserveditem.reserveID, reserveditem.itemID, itemName, reserveditem.reservedAmt, day, "Cancel");
                }
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_ItemID.Clear();
            txt_qty.Clear();
        }

        private void txt_ItemID_TextChanged(object sender, EventArgs e)
        {
            String itemID = txt_ItemID.Text;
            item item = Items.GetItem(itemID);
            if(item!=null)
            {
                txt_name.Text = item.name;
                txt_name_ch.Text = item.name_ch;
                txt_description.Text = item.description;
                txt_available.Text = Items.GetAvailableAmount(itemID).ToString();
            }
            else
            {
                txt_name.Clear();
                txt_name_ch.Clear();
                txt_description.Clear();
                txt_available.Clear();
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (ValidItemID() && ValidQty())
            {
                String itemID = txt_ItemID.Text;
                int qty = Convert.ToInt32(txt_qty.Text);

                reserveditem processingReserve = reserveditemsList.FirstOrDefault(i => i.itemID.Equals(itemID) && i.availible.Equals("N"));
                reserveditem sameDay_AvailableReserve = reserveditemsList.FirstOrDefault(i => i.itemID.Equals(itemID) && i.availible.Equals("Y") &&
                                                                                              i.completedDate.Equals(DateTime.Today));

                if (Items.GetAvailableAmount(itemID) >= qty && sameDay_AvailableReserve != null) 
                {
                    Items.ModifyReservation(sameDay_AvailableReserve.reserveID, sameDay_AvailableReserve.reservedAmt + qty);
                }
                else if (Items.GetAvailableAmount(itemID) >= qty)
                {
                    staff dealer = Users.GetStaff(myUser);
                    reserveditem newReserve = new reserveditem
                    {
                        dealerID = dealer.staffID,
                        itemID = itemID,
                        reservedAmt = qty,
                        availible = "Y",
                        completedDate = DateTime.Today
                    };
                    Items.NewReservation(newReserve);
                }
                else if (processingReserve != null) 
                {
                    Items.ModifyReservation(processingReserve.reserveID, processingReserve.reservedAmt + qty);
                }
                else 
                {
                    staff dealer = Users.GetStaff(myUser);
                    reserveditem newReserve = new reserveditem
                    {
                        dealerID = dealer.staffID,
                        itemID = itemID,
                        reservedAmt = qty,
                        availible = "N"
                    };
                    Items.NewReservation(newReserve);
                }
                MessageBox.Show("Item is reserved.", "Success");
                ClearForm();
                reserveditemsList = Items.GetReservedItems(Users.GetStaff(myUser));
                DisplayReservedRecord(reserveditemsList);
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidItemID()
        {
            if(!txt_name.Text.Equals(""))
            {
                errorProvider.SetError(txt_ItemID, "");
                return true;
            }
            else
            {
                errorProvider.SetError(txt_ItemID, "Invalid item ID.");
                return false;
            }
        }

        private bool ValidQty()
        {
            if (Regex.IsMatch(txt_qty.Text,@"^\d+$"))
            {
                errorProvider.SetError(txt_qty, "");
                return true;
            }
            else
            {
                errorProvider.SetError(txt_qty, "Invalid quantity.");
                return false;
            }
        }

        private void dgv_inProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex != 5)
                return;

            DialogResult result = MessageBox.Show("Do you want to remove this record permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.No))
                return;

            int reservedID = Convert.ToInt32(dgv_inProgress.Rows[e.RowIndex].Cells[0].Value);
            Items.CancelReservation(reservedID);
            reserveditemsList = Items.GetReservedItems(Users.GetStaff(myUser));
            DisplayReservedRecord(reserveditemsList);
        }

        private void dgv_available_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex != 5)
                return;

            DialogResult result = MessageBox.Show("Do you want to remove this record permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.No))
                return;

            int reservedID = Convert.ToInt32(dgv_available.Rows[e.RowIndex].Cells[0].Value);
            Items.CancelReservation(reservedID);
            reserveditemsList = Items.GetReservedItems(Users.GetStaff(myUser));
            DisplayReservedRecord(reserveditemsList);
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
