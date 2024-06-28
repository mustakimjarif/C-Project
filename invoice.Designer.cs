namespace Parlor
{
    partial class invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.textqty = new System.Windows.Forms.TextBox();
            this.conAppointBtn = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textqty
            // 
            this.textqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textqty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textqty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textqty.Location = new System.Drawing.Point(296, 380);
            this.textqty.Name = "textqty";
            this.textqty.Size = new System.Drawing.Size(223, 22);
            this.textqty.TabIndex = 1;
            // 
            // conAppointBtn
            // 
            this.conAppointBtn.BackColor = System.Drawing.Color.Transparent;
            this.conAppointBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conAppointBtn.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conAppointBtn.Location = new System.Drawing.Point(867, 438);
            this.conAppointBtn.Name = "conAppointBtn";
            this.conAppointBtn.Size = new System.Drawing.Size(135, 32);
            this.conAppointBtn.TabIndex = 2;
            this.conAppointBtn.Text = "Confirm Appointment";
            this.conAppointBtn.UseVisualStyleBackColor = false;
            this.conAppointBtn.Click += new System.EventHandler(this.conAppointBtn_Click);
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.Location = new System.Drawing.Point(296, 330);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(223, 22);
            this.textPrice.TabIndex = 1;
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(296, 448);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(223, 22);
            this.textTotal.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.Location = new System.Drawing.Point(12, 567);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(55, 50);
            this.backBtn.TabIndex = 8;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hair Service",
            "Nail Service",
            "Skin Care Service",
            "Makeup Service",
            "Eyebrow & Eyelash Service",
            "Specialized Treatments",
            "Bridal & Special Event Packages",
            "Consultation service"});
            this.comboBox1.Location = new System.Drawing.Point(296, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1172, 629);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.conAppointBtn);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textqty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textqty;
        private System.Windows.Forms.Button conAppointBtn;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}