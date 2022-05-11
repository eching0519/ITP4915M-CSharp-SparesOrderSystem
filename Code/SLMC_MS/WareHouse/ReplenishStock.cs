using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SLMC_MS.model;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SLMC_MS
{
    public partial class ReplenishStock : Form
    {
        List<item> items;
        List<supplier> suppliers;

        List<reserveditem> reorderItems_reserved;

        Point PanelMouseDownLocation;
        public ReplenishStock()
        {
            InitializeComponent();
            items = Items.GetItems();
            suppliers = Suppliers.GetSuppliers();
            reorderItems_reserved = new List<reserveditem>();
        }

        private void RepenishStock_Load(object sender, EventArgs e)
        {
            showHistory();

            foreach (item item in items)
            {
                if (Items.GetAvailableAmount(item.itemID) <= item.dangerLevel)
                {
                    supplier s = suppliers.FirstOrDefault(i => i.supplierID.Equals(item.supplierID));
                    dgv_ReorderList.Rows.Add(s.supplierID, s.name, item.itemID, item.name, "Danger", 100, "Delete");
                }
                else if (Items.GetAvailableAmount(item.itemID) <= item.reorderLevel)
                {
                    supplier s = suppliers.FirstOrDefault(i => i.supplierID.Equals(item.supplierID));
                    dgv_ReorderList.Rows.Add(s.supplierID, s.name, item.itemID, item.name, "Re-order", 100, "Delete");
                }
            }

            using (slmc db = new slmc())
            {
                reorderItems_reserved.AddRange(db.reserveditem.Where(i => i.availible.Equals("N")).ToList());
                var reservedItems = db.reserveditem.Where(i => i.availible.Equals("N")).GroupBy(n => new { nitemID = n.itemID }).Select(g => new { itemID = g.Key.nitemID, amt = g.Sum(n => n.reservedAmt) });
                foreach (var reserveditem in reservedItems.ToList())
                {
                    String itemID = reserveditem.itemID;
                    int totalAmt = reserveditem.amt;

                    item item = Items.GetItem(itemID);
                    supplier s = suppliers.FirstOrDefault(i => i.supplierID.Equals(item.supplierID));

                    dgv_ReorderList.Rows.Add(s.supplierID, s.name, item.itemID, item.name, "Reserved", totalAmt, "Delete");
                }
            }
            
            bt_addItem.Enabled = false;
        }

        private void showHistory()
        {
            dgv_replenishHistory.Rows.Clear();
            using (slmc db = new slmc())
            {
                List<replenishment> history = db.replenishment.ToList();
                foreach (replenishment record in history)
                {
                    dgv_replenishHistory.Rows.Add(record.replenishmentID, record.orderDate.ToShortDateString());
                }
            }
        }

        private void dgv_ReorderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 6)
                return;

            if(dgv_ReorderList.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Reserved"))
            {
                MessageBox.Show("Not able to remove \"Reserved\" items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult result = MessageBox.Show("Would you like to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes.Equals(result))
                dgv_ReorderList.Rows.RemoveAt(e.RowIndex);
        }

        private void txt_itemID_TextChanged(object sender, EventArgs e)
        {
            item item = items.FirstOrDefault(i => i.itemID.Equals(txt_itemID.Text));
            if(item!=null)
            {
                txt_item.Text = item.name;
                lbl_availableQty.Text = Items.GetAvailableAmount(item.itemID) + "";
                if(txt_qty.Text.Equals(""))
                    bt_addItem.Enabled = false;
                else
                    bt_addItem.Enabled = true;
            } else
            {
                txt_item.Text = "";
                lbl_availableQty.Text = "";
                txt_qty.Text = "";
                bt_addItem.Enabled = false;
            }
        }

        private void bt_addItem_Click(object sender, EventArgs e)
        {
            item item = items.FirstOrDefault(i => i.itemID.Equals(txt_itemID.Text));
            supplier s = suppliers.FirstOrDefault(i => i.supplierID.Equals(i.supplierID));
            int qty = Convert.ToInt32(txt_qty.Text);
            if (Items.GetAvailableAmount(item.itemID) <= item.dangerLevel)
            {
                dgv_ReorderList.Rows.Add(s.supplierID, s.name, item.itemID, item.name, "Danger", qty, "Delete");
            }
            else if (Items.GetAvailableAmount(item.itemID) <= item.reorderLevel)
            {
                dgv_ReorderList.Rows.Add(s.supplierID, s.name, item.itemID, item.name, "Re-order", qty, "Delete");
            }
            else
            {
                dgv_ReorderList.Rows.Add(s.supplierID, s.name, item.itemID, item.name, "Normal", qty, "Delete");
            }
            txt_itemID.Text = "";
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            item item = items.FirstOrDefault(i => i.itemID.Equals(txt_itemID.Text));
            if (item != null)
            {
                if (txt_qty.Text.Equals(""))
                    bt_addItem.Enabled = false;
                else
                    bt_addItem.Enabled = true;
            }
            else
            {
                bt_addItem.Enabled = false;
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            using (slmc db = new slmc())
            {
                replenishment r = new replenishment
                {
                    orderDate = DateTime.Today,
                };
                db.replenishment.Add(r);
                db.SaveChanges();

                foreach (DataGridViewRow row in dgv_ReorderList.Rows)
                {
                    String itemID = row.Cells[2].Value.ToString();
                    String status = row.Cells[4].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells[5].Value);

                    replenishitem ri = new replenishitem
                    {
                        itemID = itemID,
                        status = status,
                        qty = qty
                    };
                    r.replenishitem.Add(ri);
                    db.SaveChanges();
                }

                foreach(reserveditem ri in reorderItems_reserved)
                {
                    db.reserveditem.FirstOrDefault(i => i.reserveID == ri.reserveID).availible = "P";
                    db.SaveChanges();
                }
                createPDF(r.replenishmentID);
            }
            
            showHistory();
            panel1.Visible = false;
        }

        private void createPDF(int replenishmentID)
        {
            string downloadsPath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";

            List<String> data = new List<string>();
            String orderDate = "";
            using (slmc db = new slmc())
            {
                var r = db.replenishment.FirstOrDefault(i => i.replenishmentID == replenishmentID);
                orderDate = r.orderDate.ToShortDateString();

                var ritems = db.replenishitem.Where(i => i.replenishmentID == replenishmentID).ToList();
                foreach(replenishitem ri in ritems)
                {
                    item item = db.item.FirstOrDefault(i => i.itemID.Equals(ri.itemID));
                    supplier s = db.supplier.FirstOrDefault(i => i.supplierID.Equals(item.supplierID));
                    data.Add(s.supplierID);
                    data.Add(s.name);
                    data.Add(item.itemID);
                    data.Add(item.name);
                    data.Add(ri.status);
                    data.Add(ri.qty.ToString());
                }
            }

            Document doc = new Document(iTextSharp.text.PageSize.A4, 50, 20, 50, 20);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(downloadsPath+"\\ReplenishStock"+replenishmentID+".pdf", FileMode.Create));
            doc.Open();

            doc.AddTitle("Replenish Stock List");
            iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 24);
            iTextSharp.text.Font textFont = FontFactory.GetFont("Arial", 14);

            Paragraph title;
            title = new Paragraph("Replenish Stock List", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            Paragraph paragraph = new Paragraph("Order Date: " + orderDate + "\n", textFont);
            paragraph.Alignment = Element.ALIGN_CENTER;

            iTextSharp.text.Font tableHeader = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

            PdfPTable basicTable = new PdfPTable(6);
            PdfPCell cell = new PdfPCell(new Phrase("Supplier ID", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Supplier", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Item ID", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Item Name", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Status", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("QTY", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            basicTable.AddCell(cell);

            foreach(String record in data)
            {
                cell = new PdfPCell(new Phrase(record));
                basicTable.AddCell(cell);
            }

            paragraph.Add(basicTable);
            paragraph.Add("\n");

            doc.Add(paragraph);

            doc.Close();

            // open pdf
            System.Diagnostics.Process.Start(downloadsPath + "\\ReplenishStock" + replenishmentID + ".pdf");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel1.Left += e.X - PanelMouseDownLocation.X;

                panel1.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void dgv_replenishHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            createPDF(Convert.ToInt32(dgv_replenishHistory.Rows[e.RowIndex].Cells[0].Value));
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
