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
    public partial class ItemSalesFigure : Form
    {
        List<item> items;
        String[] month_str = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        Point PanelMouseDownLocation;

        public ItemSalesFigure()
        {
            InitializeComponent();
            items = Items.GetItems();
        }

        private void ItemSalesFigure_Load(object sender, EventArgs e)
        {
            for (int year = 2017; year <= DateTime.Today.Year; year++)
            {
                cbBox_year.Items.Add(year);
            }

            cbBox_year.SelectedItem = DateTime.Today.Year;
            cbBox_month.SelectedIndex = DateTime.Today.Month - 1;
        }

        private void cbBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_year.Text.Equals("") || cbBox_month.Text.Equals(""))
                return;

            int month = cbBox_month.SelectedIndex + 1;
            int year = Convert.ToInt32(cbBox_year.Text);

            UpdateRanking(month, year);
        }

        private void cbBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_year.Text.Equals("") || cbBox_month.Text.Equals(""))
                return;

            int month = cbBox_month.SelectedIndex + 1;
            int year = Convert.ToInt32(cbBox_year.Text);

            UpdateRanking(month, year);
        }

        private void UpdateRanking(int month, int year)
        {
            if (month <= 0)
                return;

            dgv_ranking.Rows.Clear();

            foreach(item item in items)
            {
                dgv_ranking.Rows.Add("", item.itemID, item.name, Items.salesNum(item.itemID, month, year));
            }

            dgv_ranking.Sort(dgv_ranking.Columns[3], ListSortDirection.Descending);
            int ranking = 1;
            foreach (DataGridViewRow row in dgv_ranking.Rows)
            {
                row.Cells[0].Value = ranking++;
            }
        }

        private void dgv_ranking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            String itemID = dgv_ranking.Rows[e.RowIndex].Cells[1].Value.ToString();
            loadChart(itemID);
        }

        private void loadChart(String itemID)
        {
            panel1.Visible = true;

            chart1.Titles.Clear();
            chart1.Series["Sold Number"].Points.Clear();

            chart1.Titles.Add("Sales Figure of item " + itemID);
            DateTime from = DateTime.Today.AddMonths(-6);
            DateTime to = DateTime.Today;
            while (from <= to)
            {
                chart1.Series["Sold Number"].Points.AddXY(month_str[from.Month - 1] + from.Year, Items.salesNum(itemID, from.Month, from.Year));
                from = from.AddMonths(1);
            }
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
