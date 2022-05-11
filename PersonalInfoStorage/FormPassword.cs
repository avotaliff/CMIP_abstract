using System;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;


namespace PersonalInfoStorage
{
    public partial class FormPassword : Form
    {
        public FormMain _fm;
        public string _userInfo;
        PasswordAnalysis pa = new PasswordAnalysis();

        public FormPassword()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            this.Hide();
            _fm.Show();
        }

        private void FormPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChangeLabelsEnabled(bool len, bool upp, bool low, bool num, bool sym)
        {
            LabelUpper.ForeColor = upp ? SystemColors.ControlText : SystemColors.ControlDark;
            LabelLower.ForeColor = low ? SystemColors.ControlText : SystemColors.ControlDark;           
            LabelSpecSym.ForeColor = sym ? SystemColors.ControlText : SystemColors.ControlDark;
        }

        private bool CorrectPass()
        {
            if (TextBoxPass.Text == "" || TextBoxPassPruf.Text == "")
            {
                MessageBox.Show(
                    "Поля паролей не должны быть пусты!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
            if (TextBoxPass.Text != TextBoxPassPruf.Text)
            {
                MessageBox.Show(
                    "Пароли не совпадают!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
            if (pa.CheckPassword(TrackBarHor.Value, TextBoxPass.Text) == false)
            {
                MessageBox.Show(
                     "Пароль не соответствует выбранным минимальным настройкам сложности!",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return false;
            }
            if (TextBoxPass.Text.Length < TrackBar.Value)
            {
                MessageBox.Show(
                     "Длина пароля меньше минимально допустимой!",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return false;
            }
            return true;
        }

        private void ButtonGeneric_Click(object sender, EventArgs e)
        {
            if (CorrectPass())
            {
                RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
                string xmlKey = "----BEGIN----" + "\n"
                                  + rSA.ToXmlString(true) + "\n"
                                  + "----END----";
                string textToEncrypt = _userInfo + xmlKey;
                AesExample aesE = new AesExample(textToEncrypt, TextBoxPass.Text);
                aesE.CreateEncrypFile();
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
