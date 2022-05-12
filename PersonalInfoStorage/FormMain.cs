using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoStorage
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            FormRegistInfo fri = new FormRegistInfo();
            fri._fm = this;
            Hide();
            fri.Show();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl._fm = this;
            Hide();
            fl.Show();
        }
    }
}
