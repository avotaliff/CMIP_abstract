namespace PersonalInfoStorage
{
    partial class FormPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonGeneric = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxPassPruf = new System.Windows.Forms.TextBox();
            this.LabelLow = new System.Windows.Forms.Label();
            this.LabelMedium = new System.Windows.Forms.Label();
            this.LabelHigh = new System.Windows.Forms.Label();
            this.TrackBarHor = new System.Windows.Forms.TrackBar();
            this.LabelLen = new System.Windows.Forms.Label();
            this.LabelUpper = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelLower = new System.Windows.Forms.Label();
            this.LabelSpecSym = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarHor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимальная длина:";
            // 
            // LabelBar
            // 
            this.LabelBar.AutoSize = true;
            this.LabelBar.Location = new System.Drawing.Point(164, 80);
            this.LabelBar.Name = "LabelBar";
            this.LabelBar.Size = new System.Drawing.Size(122, 13);
            this.LabelBar.TabIndex = 1;
            this.LabelBar.Text = "Текущее значение: 30";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Придумайте пароль с заданными";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "длиной и сложностью";
            // 
            // TrackBar
            // 
            this.TrackBar.Location = new System.Drawing.Point(12, 96);
            this.TrackBar.Maximum = 30;
            this.TrackBar.Minimum = 8;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(274, 45);
            this.TrackBar.TabIndex = 6;
            this.TrackBar.Value = 30;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сложность:";
            // 
            // ButtonGeneric
            // 
            this.ButtonGeneric.Location = new System.Drawing.Point(157, 352);
            this.ButtonGeneric.Name = "ButtonGeneric";
            this.ButtonGeneric.Size = new System.Drawing.Size(75, 23);
            this.ButtonGeneric.TabIndex = 11;
            this.ButtonGeneric.Text = "Сохранить";
            this.ButtonGeneric.UseVisualStyleBackColor = true;
            this.ButtonGeneric.Click += new System.EventHandler(this.ButtonGeneric_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(62, 352);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrev.TabIndex = 12;
            this.ButtonPrev.Text = "Вернуться";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Повторите пароль:";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(135, 281);
            this.TextBoxPass.MaxLength = 30;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(147, 22);
            this.TextBoxPass.TabIndex = 15;
            this.TextBoxPass.UseSystemPasswordChar = true;
            // 
            // TextBoxPassPruf
            // 
            this.TextBoxPassPruf.Location = new System.Drawing.Point(135, 316);
            this.TextBoxPassPruf.MaxLength = 30;
            this.TextBoxPassPruf.Name = "TextBoxPassPruf";
            this.TextBoxPassPruf.Size = new System.Drawing.Size(147, 22);
            this.TextBoxPassPruf.TabIndex = 16;
            this.TextBoxPassPruf.UseSystemPasswordChar = true;
            // 
            // LabelLow
            // 
            this.LabelLow.AutoSize = true;
            this.LabelLow.ForeColor = System.Drawing.Color.Red;
            this.LabelLow.Location = new System.Drawing.Point(57, 228);
            this.LabelLow.Name = "LabelLow";
            this.LabelLow.Size = new System.Drawing.Size(45, 13);
            this.LabelLow.TabIndex = 17;
            this.LabelLow.Text = "Низкая";
            // 
            // LabelMedium
            // 
            this.LabelMedium.AutoSize = true;
            this.LabelMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelMedium.Location = new System.Drawing.Point(57, 200);
            this.LabelMedium.Name = "LabelMedium";
            this.LabelMedium.Size = new System.Drawing.Size(52, 13);
            this.LabelMedium.TabIndex = 18;
            this.LabelMedium.Text = "Средняя";
            // 
            // LabelHigh
            // 
            this.LabelHigh.AutoSize = true;
            this.LabelHigh.ForeColor = System.Drawing.Color.Green;
            this.LabelHigh.Location = new System.Drawing.Point(57, 175);
            this.LabelHigh.Name = "LabelHigh";
            this.LabelHigh.Size = new System.Drawing.Size(52, 13);
            this.LabelHigh.TabIndex = 19;
            this.LabelHigh.Text = "Высокая";
            // 
            // TrackBarHor
            // 
            this.TrackBarHor.Location = new System.Drawing.Point(14, 166);
            this.TrackBarHor.Maximum = 3;
            this.TrackBarHor.Minimum = 1;
            this.TrackBarHor.Name = "TrackBarHor";
            this.TrackBarHor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarHor.Size = new System.Drawing.Size(45, 80);
            this.TrackBarHor.TabIndex = 20;
            this.TrackBarHor.Value = 1;
            this.TrackBarHor.Scroll += new System.EventHandler(this.TrackBarHor_Scroll);
            // 
            // LabelLen
            // 
            this.LabelLen.AutoSize = true;
            this.LabelLen.BackColor = System.Drawing.SystemColors.Control;
            this.LabelLen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelLen.Location = new System.Drawing.Point(129, 165);
            this.LabelLen.Name = "LabelLen";
            this.LabelLen.Size = new System.Drawing.Size(133, 13);
            this.LabelLen.TabIndex = 21;
            this.LabelLen.Text = "✓ Не менее 8 символов";
            // 
            // LabelUpper
            // 
            this.LabelUpper.AutoSize = true;
            this.LabelUpper.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelUpper.Location = new System.Drawing.Point(129, 187);
            this.LabelUpper.Name = "LabelUpper";
            this.LabelUpper.Size = new System.Drawing.Size(135, 13);
            this.LabelUpper.TabIndex = 22;
            this.LabelUpper.Text = "✓ Содержать заглавные";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelNumber.Location = new System.Drawing.Point(129, 231);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(118, 13);
            this.LabelNumber.TabIndex = 24;
            this.LabelNumber.Text = "✓ Содержать цифры";
            // 
            // LabelLower
            // 
            this.LabelLower.AutoSize = true;
            this.LabelLower.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelLower.Location = new System.Drawing.Point(129, 209);
            this.LabelLower.Name = "LabelLower";
            this.LabelLower.Size = new System.Drawing.Size(132, 13);
            this.LabelLower.TabIndex = 23;
            this.LabelLower.Text = "✓ Содержать строчные";
            // 
            // LabelSpecSym
            // 
            this.LabelSpecSym.AutoSize = true;
            this.LabelSpecSym.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelSpecSym.Location = new System.Drawing.Point(129, 253);
            this.LabelSpecSym.Name = "LabelSpecSym";
            this.LabelSpecSym.Size = new System.Drawing.Size(156, 13);
            this.LabelSpecSym.TabIndex = 25;
            this.LabelSpecSym.Text = "✓ Содержать спец символы";
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 387);
            this.Controls.Add(this.LabelSpecSym);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelLower);
            this.Controls.Add(this.LabelUpper);
            this.Controls.Add(this.LabelLen);
            this.Controls.Add(this.TrackBarHor);
            this.Controls.Add(this.LabelHigh);
            this.Controls.Add(this.LabelMedium);
            this.Controls.Add(this.LabelLow);
            this.Controls.Add(this.TextBoxPassPruf);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonGeneric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPassword_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarHor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonGeneric;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxPassPruf;
        private System.Windows.Forms.Label LabelLow;
        private System.Windows.Forms.Label LabelMedium;
        private System.Windows.Forms.Label LabelHigh;
        private System.Windows.Forms.TrackBar TrackBarHor;
        private System.Windows.Forms.Label LabelLen;
        private System.Windows.Forms.Label LabelUpper;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelLower;
        private System.Windows.Forms.Label LabelSpecSym;
    }
}