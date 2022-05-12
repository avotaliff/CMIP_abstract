namespace PersonalInfoStorage
{
    partial class FormRegistInfo
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(404, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите данные пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Логин:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxName.Location = new System.Drawing.Point(173, 74);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxName.MaxLength = 30;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(192, 22);
            this.TextBoxName.TabIndex = 6;
            this.TextBoxName.Text = "rite";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(173, 112);
            this.TextBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSurname.MaxLength = 50;
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(192, 22);
            this.TextBoxSurname.TabIndex = 7;
            this.TextBoxSurname.Text = "pobrito";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(173, 192);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLogin.MaxLength = 50;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(192, 22);
            this.TextBoxLogin.TabIndex = 9;
            this.TextBoxLogin.Text = "loh";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(223, 266);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(100, 28);
            this.ButtonNext.TabIndex = 10;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(173, 151);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(192, 22);
            this.DateTimePicker.TabIndex = 11;
            this.DateTimePicker.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.SystemColors.Control;
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(123, 236);
            this.LabelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(142, 16);
            this.LabelError.TabIndex = 12;
            this.LabelError.Text = "Заполните все поля!";
            this.LabelError.Visible = false;
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(82, 266);
            this.ButtonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(100, 28);
            this.ButtonPrev.TabIndex = 13;
            this.ButtonPrev.Text = "Вернуться";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 318);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персональные данные";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Button ButtonPrev;
    }
}

