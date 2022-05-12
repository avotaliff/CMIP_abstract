using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PersonalInfoStorage
{
    public partial class FormLogin : Form
    {
        public FormMain _fm;
        private List<string> _usersList = new List<string>();

        public FormLogin()
        {
            InitializeComponent();
            _usersList = UsersAccounts.CreateUserList();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorMessage()
        {
            MessageBox.Show(
                    "Неверный логин или пароль!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            string password = TextBoxPassword.Text;
            string login = TextBoxLogin.Text;
            if (login == "" || password == "")
            {
                LabelError.Visible = true;
            }
            else
            {
                LabelError.Visible = false;
                if (_usersList.Contains(login))
                {
                    KeyManager km = new KeyManager(login + ".txt");
                    if (km.CheckKey(password))
                    {
                        FormPersonalInfo fpi = new FormPersonalInfo();
                        AesExample aesE = new AesExample(password, login);
                        fpi._info = aesE.CreateDecrypText();
                        fpi._fs = this;
                        Hide();
                        TextBoxPassword.Text = "";
                        fpi.Show();
                    }
                    else
                        ErrorMessage();
                }
                else
                    ErrorMessage();
            }
        }

        private void FormSignin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fm.Show();
        }
    }
}
