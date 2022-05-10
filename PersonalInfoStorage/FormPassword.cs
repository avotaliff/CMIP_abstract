using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Collections.Generic;

namespace PersonalInfoStorage
{
    public partial class FormPassword : Form
    {
        public FormMain _fm;

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

        private bool ThereIsUpperCase()
        {
            int i = 0;
            bool f = false;
            while (f == false && i < TextBoxPass.Text.Length)
            {
                if (Char.IsUpper(TextBoxPass.Text[i]))
                    f = true;
                i++;
            }
            return f;
        }
        private bool ThereIsLowerCase()
        {
            int i = 0;
            bool f = false;
            while (f == false && i < TextBoxPass.Text.Length)
            {
                if (Char.IsLower(TextBoxPass.Text[i]))
                    f = true;
                i++;
            }
            return f;
        }

        private bool ThereIsNumber()
        {
            int i = 0;
            bool f = false;
            while (f == false && i < TextBoxPass.Text.Length)
            {
                if (Char.IsNumber(TextBoxPass.Text[i]))
                    f = true;
                i++;
            }
            return f;
        }

        private bool ThereIsSpecSymb()
        {
            const string Pattern = @"[`~!@#№""$;%^&*():?_\-+=\.,><}\]{[/|]+";
            Regex r = new Regex(pattern: Pattern, RegexOptions.Compiled);
            Match match = r.Match(TextBoxPass.Text);  
            return match.Success;
        }

        private void ChangeLabelsEnabled(bool len, bool upp, bool low, bool num, bool sym)
        {
            LabelUpper.ForeColor = upp ? SystemColors.ControlText : SystemColors.ControlDark;
            LabelLower.ForeColor = low ? SystemColors.ControlText : SystemColors.ControlDark;           
            LabelSpecSym.ForeColor = sym ? SystemColors.ControlText : SystemColors.ControlDark;
        }

        private bool CheckPassword()
        {
            if (TrackBarHor.Value == 1 && TextBoxPass.Text.Length >= 8 
                && ThereIsNumber()) 
                return true;

            if (TrackBarHor.Value == 2 && TextBoxPass.Text.Length >= 8
                && ThereIsNumber() && ThereIsUpperCase() && ThereIsLowerCase())
                return true;

            if (TrackBarHor.Value == 3 && TextBoxPass.Text.Length >= 8
                && ThereIsNumber() && ThereIsUpperCase() && ThereIsLowerCase()
                && ThereIsSpecSymb())
                return true;

            return false;
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
            if (CheckPassword() == false)
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
