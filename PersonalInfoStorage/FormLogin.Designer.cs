namespace PersonalInfoStorage
{
    partial class FormLogin
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
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(83, 130);
            this.ButtonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(100, 28);
            this.ButtonPrev.TabIndex = 19;
            this.ButtonPrev.Text = "Вернуться";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(213, 130);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(100, 28);
            this.ButtonNext.TabIndex = 18;
            this.ButtonNext.Text = "Вход";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(139, 26);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLogin.MaxLength = 50;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(192, 22);
            this.TextBoxLogin.TabIndex = 17;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(139, 66);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.MaxLength = 50;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(192, 22);
            this.TextBoxPassword.TabIndex = 16;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(64, 26);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(49, 16);
            this.LabelLogin.TabIndex = 15;
            this.LabelLogin.Text = "Логин:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(64, 69);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(59, 16);
            this.LabelPassword.TabIndex = 14;
            this.LabelPassword.Text = "Пароль:";
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.BackColor = System.Drawing.SystemColors.Control;
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(126, 106);
            this.LabelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(142, 16);
            this.LabelError.TabIndex = 20;
            this.LabelError.Text = "Заполните все поля!";
            this.LabelError.Visible = false;
            // 
            // FormSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 182);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelPassword);
            this.Name = "FormSignin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в учетную запись";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSignin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelError;
    }
}