using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;


namespace PersonalInfoStorage
{
    public partial class FormPassword : Form
    {
        public FormLogin _fl;
        public string _userInfo;
        public string _userLogin;
        PasswordAnalysis pa = new PasswordAnalysis();

        public FormPassword()
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
            _fl.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void ChangeLabelsEnabled(bool len, bool upp, bool low, bool num, bool sym)
        {
            LabelUpper.ForeColor = upp ? SystemColors.ControlText : SystemColors.ControlDark;
            LabelLower.ForeColor = low ? SystemColors.ControlText : SystemColors.ControlDark;           
            LabelSpecSym.ForeColor = sym ? SystemColors.ControlText : SystemColors.ControlDark;
        }

        private void ButtonGeneric_Click(object sender, EventArgs e)
        {
            if (pa.CorrectPass(TextBoxPass.Text, TextBoxPassPruf.Text, TrackBar.Value, TrackBarHor.Value))
            {
                RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
                string xmlKey = "----BEGIN----" + "\n"
                              + rSA.ToXmlString(true) + "\n"
                              + "----END----";
                string textToEncrypt = _userInfo + xmlKey;
                AesExample aesE = new AesExample(TextBoxPass.Text, _userLogin);
                aesE.CreateEncrypFile(textToEncrypt);
                _fl._usersList.Add(_userLogin);
                MessageBox.Show(
                     "Закрытый ключ и персональные данные его владельца зашифрованы!",
                     "Сообщение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
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
