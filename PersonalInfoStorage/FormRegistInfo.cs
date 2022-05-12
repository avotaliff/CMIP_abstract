using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace PersonalInfoStorage
{
    public partial class FormRegistInfo : Form
    {
        private DateTime _dt = DateTime.Now.AddYears(-18);
        private List<TextBox> _textBoxList = new List<TextBox>();

        public List<string> _usersList = new List<string>();
        public FormMain _fm;

        public FormRegistInfo()
        {
            InitializeComponent();
            DateTimePicker.MaxDate = _dt;
            _textBoxList.Add(TextBoxName);
            _textBoxList.Add(TextBoxSurname);
            _textBoxList.Add(TextBoxLogin);
            _usersList = UsersAccounts.CreateUserList();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(); 
            aboutBox.ShowDialog();
        }

        private string GetUserInfo()
        {
            return "Имя: " + TextBoxName.Text + "\n"
                + "Фамилия: " + TextBoxSurname.Text + "\n"
                + "Дата рождения: " + DateTimePicker.Text + "\n"
                + "Логин: " + TextBoxLogin.Text + "\n";
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            bool f = false;
            int i = 0;
            while (f == false && i < _textBoxList.Count) //Есть ли хотя бы один пустой
            {
                if (_textBoxList[i].Text == "")
                { 
                    f = true;
                    _textBoxList[i].BackColor = Color.MistyRose;
                    LabelError.Visible = true;
                }
                i++;
            }
            if (f == true)
            {
                for (; i < _textBoxList.Count; i++)
                    if (_textBoxList[i].Text == "")
                        _textBoxList[i].BackColor = Color.MistyRose;
            }
            else
            {
                if (_usersList.Contains(TextBoxLogin.Text))
                {
                    MessageBox.Show(
                    "Пользователь с данным логином уже существует!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
                else
                {
                    LabelError.Visible = false;
                    foreach (TextBox tb in _textBoxList)
                        tb.BackColor = SystemColors.Window;
                    this.Hide();
                    FormRegistPass frp = new FormRegistPass();
                    frp._userLogin = TextBoxLogin.Text;
                    frp._userInfo = GetUserInfo();
                    frp._fri = this;
                    frp.Show();
                }
            }
        }
    }
}
