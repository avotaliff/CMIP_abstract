using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;


namespace PersonalInfoStorage
{
    public partial class FormRegistPass : Form
    {
        public FormRegistInfo _fri;
        public string _userInfo;
        public string _userLogin;
        PasswordAnalysis pa = new PasswordAnalysis();

        public FormRegistPass()
        {
            InitializeComponent();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fri.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void ChangeLabelsEnabled(bool len, bool upp, bool low, bool num, bool sym)
        {
            Color lightText = SystemColors.ControlDark;
            Color darkText = SystemColors.ControlText;
            LabelUpper.ForeColor = upp ? darkText : lightText;
            LabelLower.ForeColor = low ? darkText : lightText;
            LabelSpecSym.ForeColor = sym ? darkText : lightText;
        }

        private void ButtonGeneric_Click(object sender, EventArgs e)
        {
            if (pa.CorrectPass(TextBoxPass.Text, TextBoxPassPruf.Text, TrackBar.Value, TrackBarHor.Value))
            {
                var rSA = new RSACryptoServiceProvider();
                string xmlKey = rSA.ToXmlString(true);
                string textToEncrypt = _userInfo + xmlKey;
                string password = TextBoxPass.Text;
                AesExample aesE = new AesExample(password, _userLogin);
                aesE.CreateEncrypFile(textToEncrypt);
                _fri._usersList.Add(_userLogin);
                MessageBox.Show(
                     "Закрытый ключ и персональные данные его владельца зашифрованы!",
                     "Сообщение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                Close();
            }    
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            LabelBar.Text = String.Format("Текущее значение: {0}", TrackBar.Value);
        }

        private void TrackBarHor_Scroll(object sender, EventArgs e)
        {
            if (TrackBarHor.Value == 1)
                ChangeLabelsEnabled(true, false, false, true, false);
            if (TrackBarHor.Value == 2)
                ChangeLabelsEnabled(true, true, true, true, false);            
            if (TrackBarHor.Value == 3)
                ChangeLabelsEnabled(true, true, true, true, true); 
        }
    }
}
