using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMC_MS.model;

namespace SLMC_MS
{
    public partial class AreaRevenue : Form
    {
        String[] month_str = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        Point PanelMouseDownLocation;

        public AreaRevenue()
        {
            InitializeComponent();
        }

        private void AreaRevenue_Load(object sender, EventArgs e)
        {
            for(int year = 2017; year <= DateTime.Today.Year; year++)
            {
                cbBox_year.Items.Add(year);
            }

            cbBox_year.SelectedItem = DateTime.Today.Year;
            cbBox_month.SelectedIndex = DateTime.Today.Month-1;

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
            if (cbBox_year.Text.Equals("")|| cbBox_month.Text.Equals(""))
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

            var cities = Cities.GetCities();
            foreach(city c in cities)
            {
                double revenue = Cities.GetRevenue(c.cityID, month, year);

                if (revenue > 0) 
                {
                    dgv_ranking.Rows.Add(0, c.city1, Cities.GetProvince(c).province1, revenue);
                }
            }
            //using (slmc db = new slmc())
            //{
            //    DateTime min = new DateTime(year, month, 1);
            //    DateTime max = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            //    var cities = db.city.ToList();
            //    foreach (city c in cities)
            //    {
            //        var orders = db.order.Where(i => i.cityID.Equals(c.cityID) && i.orderDate >= min && i.orderDate <= max && i.statusID.Equals("copl"));
            //        if (orders != null)
            //        {
            //            double revenue = 0;
            //            foreach (order o in orders)
            //            {
            //                revenue += Orders.GetOrderTotal(o.orderID);
            //            }

            //            if (revenue > 0)
            //            {
            //                dgv_ranking.Rows.Add(0, c.city1, Cities.GetProvince(c).province1, revenue);
            //            }
                            
            //        }
            //    }
            //}
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

            String city = dgv_ranking.Rows[e.RowIndex].Cells[1].Value.ToString();
            city c = Cities.GetCityByName(city);
            loadChart(c);
        }

        private void loadChart(city city)
        {
            panel1.Visible = true;

            chart1.Titles.Clear();
            chart1.Series["Revenue"].Points.Clear();

            chart1.Titles.Add("Revenue of " + city.city1);
            DateTime from = DateTime.Today.AddMonths(-6);
            DateTime to = DateTime.Today;
            while (from <= to)
            {
                chart1.Series["Revenue"].Points.AddXY(month_str[from.Month - 1] + from.Year, Cities.GetRevenue(city.cityID, from.Month, from.Year));
                from = from.AddMonths(1);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
