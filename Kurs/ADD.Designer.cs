namespace Kurs
{
    partial class ADD
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
            this.PrimT = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.Label();
            this.Kol = new System.Windows.Forms.Label();
            this.Prim = new System.Windows.Forms.Label();
            this.Add1 = new System.Windows.Forms.Button();
            this.FIOT = new System.Windows.Forms.TextBox();
            this.KolT = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // PrimT
            // 
            this.PrimT.Location = new System.Drawing.Point(12, 103);
            this.PrimT.Name = "PrimT";
            this.PrimT.Size = new System.Drawing.Size(196, 20);
            this.PrimT.TabIndex = 2;
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(12, 9);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(38, 13);
            this.FIO.TabIndex = 3;
            this.FIO.Text = "ФИО*";
            // 
            // Kol
            // 
            this.Kol.AutoSize = true;
            this.Kol.Location = new System.Drawing.Point(9, 48);
            this.Kol.Name = "Kol";
            this.Kol.Size = new System.Drawing.Size(105, 13);
            this.Kol.TabIndex = 4;
            this.Kol.Text = "Количество людей*";
            // 
            // Prim
            // 
            this.Prim.AutoSize = true;
            this.Prim.Location = new System.Drawing.Point(12, 87);
            this.Prim.Name = "Prim";
            this.Prim.Size = new System.Drawing.Size(70, 13);
            this.Prim.TabIndex = 5;
            this.Prim.Text = "Примечание";
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(59, 129);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(98, 29);
            this.Add1.TabIndex = 6;
            this.Add1.Text = "Добавить";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // FIOT
            // 
            this.FIOT.Location = new System.Drawing.Point(12, 25);
            this.FIOT.Name = "FIOT";
            this.FIOT.Size = new System.Drawing.Size(196, 20);
            this.FIOT.TabIndex = 7;
            // 
            // KolT
            // 
            this.KolT.Location = new System.Drawing.Point(12, 64);
            this.KolT.Mask = "000";
            this.KolT.Name = "KolT";
            this.KolT.Size = new System.Drawing.Size(193, 20);
            this.KolT.TabIndex = 8;
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(220, 170);
            this.Controls.Add(this.KolT);
            this.Controls.Add(this.FIOT);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.Prim);
            this.Controls.Add(this.Kol);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.PrimT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ADD";
            this.Text = "ADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label Kol;
        private System.Windows.Forms.Label Prim;
        private System.Windows.Forms.Button Add1;
        public System.Windows.Forms.TextBox PrimT;
        public System.Windows.Forms.TextBox FIOT;
        private System.Windows.Forms.MaskedTextBox KolT;
    }
}