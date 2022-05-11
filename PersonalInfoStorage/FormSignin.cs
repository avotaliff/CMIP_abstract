using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PersonalInfoStorage
{
    public partial class FormSignin : Form
    {
        public FormMain _fm;
        private List<string> _usersList = new List<string>();

        public FormSignin()
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
            if (TextBoxLogin.Text == "" || TextBoxPassword.Text == "")
            {
                LabelError.Visible = true;
            }
            else
            {
                LabelError.Visible = false;
                if (_usersList.Contains(TextBoxLogin.Text))
                {
                    KeyManager km = new KeyManager(TextBoxLogin.Text + ".txt");
                    if (km.CheckKey(TextBoxPassword.Text))
                    {
                        FormPersonalInfo fpi = new FormPersonalInfo();
                        fpi._fs = this;
                        this.Hide();
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
