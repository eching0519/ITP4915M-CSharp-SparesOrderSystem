using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS
{
    class LoginController
    {
        private Login l;

        public LoginController()
        {
            l = new Login();
        }

        public void ShowForm()
        {
            l.Show();
        }

        public void HideForm()
        {
            l.Hide();
        }
    }
}
