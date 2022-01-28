namespace Kurs
{
    partial class Enter
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
            this.EnterLog = new System.Windows.Forms.Button();
            this.NameLogin = new System.Windows.Forms.Label();
            this.NamePassword = new System.Windows.Forms.Label();
            this.LostLogPass = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.MaskedTextBox();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // EnterLog
            // 
            this.EnterLog.Location = new System.Drawing.Point(79, 184);
            this.EnterLog.Name = "EnterLog";
            this.EnterLog.Size = new System.Drawing.Size(94, 28);
            this.EnterLog.TabIndex = 0;
            this.EnterLog.Text = "Вход";
            this.EnterLog.UseVisualStyleBackColor = true;
            this.EnterLog.Click += new System.EventHandler(this.EnterLog_Click);
            // 
            // NameLogin
            // 
            this.NameLogin.AutoSize = true;
            this.NameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLogin.Location = new System.Drawing.Point(33, 50);
            this.NameLogin.Name = "NameLogin";
            this.NameLogin.Size = new System.Drawing.Size(63, 20);
            this.NameLogin.TabIndex = 3;
            this.NameLogin.Text = "Логин :";
            this.NameLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // NamePassword
            // 
            this.NamePassword.AutoSize = true;
            this.NamePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePassword.Location = new System.Drawing.Point(33, 112);
            this.NamePassword.Name = "NamePassword";
            this.NamePassword.Size = new System.Drawing.Size(75, 20);
            this.NamePassword.TabIndex = 4;
            this.NamePassword.Text = "Пароль :";
            // 
            // LostLogPass
            // 
            this.LostLogPass.Location = new System.Drawing.Point(12, 12);
            this.LostLogPass.Name = "LostLogPass";
            this.LostLogPass.Size = new System.Drawing.Size(61, 23);
            this.LostLogPass.TabIndex = 5;
            this.LostLogPass.Text = "Помощь";
            this.LostLogPass.UseVisualStyleBackColor = true;
            this.LostLogPass.Click += new System.EventHandler(this.LostLogPass_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(37, 73);
            this.Login.Name = "Login";
            this.Login.PasswordChar = '⁕';
            this.Login.Size = new System.Drawing.Size(174, 20);
            this.Login.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(37, 135);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '⁕';
            this.Password.Size = new System.Drawing.Size(174, 20);
            this.Password.TabIndex = 7;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(246, 269);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LostLogPass);
            this.Controls.Add(this.NamePassword);
            this.Controls.Add(this.NameLogin);
            this.Controls.Add(this.EnterLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Enter";
            this.Text = "Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterLog;
        private System.Windows.Forms.Label NameLogin;
        private System.Windows.Forms.Label NamePassword;
        private System.Windows.Forms.Button LostLogPass;
        private System.Windows.Forms.MaskedTextBox Login;
        private System.Windows.Forms.MaskedTextBox Password;
    }
}

