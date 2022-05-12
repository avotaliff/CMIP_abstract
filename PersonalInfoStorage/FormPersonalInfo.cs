using System;
using System.Windows.Forms;

namespace PersonalInfoStorage
{
    public partial class FormPersonalInfo : Form
    {
        public FormLogin _fs;
        public string _info;
        private string[] _infoWords;

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
            Close();    
        }

        private void FormPersonalInfo_Load(object sender, EventArgs e)
        {
            _infoWords = InfoParser.Parse(_info);
            TextBoxName.Text = _infoWords[0];
            TextBoxSurname.Text = _infoWords[1];

            DateTime dateTime;
            DateTime.TryParse(_infoWords[2], out dateTime);
            DateTimePicker.Value = dateTime;

            TextBoxLogin.Text = _infoWords[3];
            TextBoxPrivateKey.Text = _infoWords[4];
        }
    }
}
