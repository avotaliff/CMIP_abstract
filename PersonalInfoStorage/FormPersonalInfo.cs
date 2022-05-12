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
    public partial class FormPersonalInfo : Form
    {
        public FormLogin _fs;
        public string _info;

        public FormPersonalInfo()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPersonalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fs.Show();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void FormPersonalInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
