namespace Kurs
{
    partial class InfoP
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
            this.FIOI = new System.Windows.Forms.Label();
            this.FIOinp = new System.Windows.Forms.Label();
            this.KOLV = new System.Windows.Forms.Label();
            this.KOLinp = new System.Windows.Forms.Label();
            this.Prim = new System.Windows.Forms.Label();
            this.Priminp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FIOI
            // 
            this.FIOI.AutoSize = true;
            this.FIOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOI.Location = new System.Drawing.Point(13, 13);
            this.FIOI.Name = "FIOI";
            this.FIOI.Size = new System.Drawing.Size(151, 24);
            this.FIOI.TabIndex = 0;
            this.FIOI.Text = "ФИО Заказчика";
            // 
            // FIOinp
            // 
            this.FIOinp.AutoSize = true;
            this.FIOinp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOinp.Location = new System.Drawing.Point(13, 47);
            this.FIOinp.Name = "FIOinp";
            this.FIOinp.Size = new System.Drawing.Size(0, 24);
            this.FIOinp.TabIndex = 1;
            // 
            // KOLV
            // 
            this.KOLV.AutoSize = true;
            this.KOLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KOLV.Location = new System.Drawing.Point(13, 85);
            this.KOLV.Name = "KOLV";
            this.KOLV.Size = new System.Drawing.Size(180, 24);
            this.KOLV.TabIndex = 2;
            this.KOLV.Text = "Количество людей";
            // 
            // KOLinp
            // 
            this.KOLinp.AutoSize = true;
            this.KOLinp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KOLinp.Location = new System.Drawing.Point(13, 120);
            this.KOLinp.Name = "KOLinp";
            this.KOLinp.Size = new System.Drawing.Size(0, 24);
            this.KOLinp.TabIndex = 3;
            // 
            // Prim
            // 
            this.Prim.AutoSize = true;
            this.Prim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prim.Location = new System.Drawing.Point(13, 151);
            this.Prim.Name = "Prim";
            this.Prim.Size = new System.Drawing.Size(199, 24);
            this.Prim.TabIndex = 4;
            this.Prim.Text = "Примечание клиента";
            // 
            // Priminp
            // 
            this.Priminp.AutoSize = true;
            this.Priminp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Priminp.Location = new System.Drawing.Point(13, 187);
            this.Priminp.Name = "Priminp";
            this.Priminp.Size = new System.Drawing.Size(0, 24);
            this.Priminp.TabIndex = 5;
            // 
            // InfoP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(355, 373);
            this.Controls.Add(this.Priminp);
            this.Controls.Add(this.Prim);
            this.Controls.Add(this.KOLinp);
            this.Controls.Add(this.KOLV);
            this.Controls.Add(this.FIOinp);
            this.Controls.Add(this.FIOI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoP";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIOI;
        private System.Windows.Forms.Label FIOinp;
        private System.Windows.Forms.Label KOLV;
        private System.Windows.Forms.Label KOLinp;
        private System.Windows.Forms.Label Prim;
        private System.Windows.Forms.Label Priminp;
    }
}