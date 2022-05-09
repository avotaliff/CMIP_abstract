using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace PersonalInfoStorage
{
    public partial class FormMain : Form
    {
        DateTime _dt = DateTime.Now.AddYears(-18);
        List<TextBox> _textBoxList = new List<TextBox>();

        public FormMain()
        {
            InitializeComponent();
            DateTimePicker.MaxDate = _dt;
            _textBoxList.Add(TextBoxName);
            _textBoxList.Add(TextBoxSurname);
            _textBoxList.Add(TextBoxLogin);
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

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            bool f = false;
            foreach (TextBox textBox in _textBoxList)
            {
                if (textBox.Text == "")
                { 
                    f = true;
                    textBox.BackColor = Color.MistyRose;
                }
            }
        }
    }
}
