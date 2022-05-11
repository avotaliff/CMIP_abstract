using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace PersonalInfoStorage
{
    public partial class FormMain : Form
    {
        DateTime _dt = DateTime.Now.AddYears(-18);
        List<TextBox> _textBoxList = new List<TextBox>();
        public List<string> _usersList = new List<string>();

        public FormMain()
        {
            InitializeComponent();
            DateTimePicker.MaxDate = _dt;
            _textBoxList.Add(TextBoxName);
            _textBoxList.Add(TextBoxSurname);
            _textBoxList.Add(TextBoxLogin);
            CreateUserList();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(); 
            aboutBox.ShowDialog();
        }

        private void CreateUserList()
        {
            string myPath = Directory.GetCurrentDirectory();
            Array.ForEach(Directory.GetFiles(myPath, "*.txt"), f => _usersList.Add(Path.GetFileNameWithoutExtension(Path.GetFileName(f))));           
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
                    FormPassword fp = new FormPassword();
                    fp._userLogin = TextBoxLogin.Text;
                    fp._userInfo = GetUserInfo();
                    fp._fm = this;
                    fp.Show();
                }
            }
        }
    }
}
