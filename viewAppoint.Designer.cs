namespace Parlor
{
    partial class viewAppoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAppoint));
            this.servicetxt = new System.Windows.Forms.TextBox();
            this.appointmentDate = new System.Windows.Forms.TextBox();
            this.appointmentTime = new System.Windows.Forms.TextBox();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.comboConfirm = new System.Windows.Forms.ComboBox();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servicetxt
            // 
            this.servicetxt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.servicetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicetxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicetxt.ForeColor = System.Drawing.Color.Black;
            this.servicetxt.Location = new System.Drawing.Point(164, 285);
            this.servicetxt.Multiline = true;
            this.servicetxt.Name = "servicetxt";
            this.servicetxt.Size = new System.Drawing.Size(280, 32);
            this.servicetxt.TabIndex = 0;
            // 
            // appointmentDate
            // 
            this.appointmentDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.appointmentDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDate.ForeColor = System.Drawing.Color.Black;
            this.appointmentDate.Location = new System.Drawing.Point(450, 285);
            this.appointmentDate.Multiline = true;
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(158, 32);
            this.appointmentDate.TabIndex = 1;
            // 
            // appointmentTime
            // 
            this.appointmentTime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.appointmentTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTime.ForeColor = System.Drawing.Color.Black;
            this.appointmentTime.Location = new System.Drawing.Point(614, 286);
            this.appointmentTime.Multiline = true;
            this.appointmentTime.Name = "appointmentTime";
            this.appointmentTime.Size = new System.Drawing.Size(153, 29);
            this.appointmentTime.TabIndex = 2;
            // 
            // statusCombo
            // 
            this.statusCombo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "Accept",
            "Pending"});
            this.statusCombo.Location = new System.Drawing.Point(773, 288);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(130, 27);
            this.statusCombo.TabIndex = 5;
            // 
            // comboConfirm
            // 
            this.comboConfirm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboConfirm.FormattingEnabled = true;
            this.comboConfirm.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboConfirm.Location = new System.Drawing.Point(909, 288);
            this.comboConfirm.Name = "comboConfirm";
            this.comboConfirm.Size = new System.Drawing.Size(151, 27);
            this.comboConfirm.TabIndex = 5;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(853, 528);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(180, 47);
            this.checkoutBtn.TabIndex = 6;
            this.checkoutBtn.Text = "Checkout With Us !!";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.Location = new System.Drawing.Point(39, 535);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(55, 50);
            this.backBtn.TabIndex = 7;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // viewAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1172, 629);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.comboConfirm);
            this.Controls.Add(this.statusCombo);
            this.Controls.Add(this.appointmentTime);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.servicetxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewAppoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox servicetxt;
        private System.Windows.Forms.TextBox appointmentDate;
        private System.Windows.Forms.TextBox appointmentTime;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.ComboBox comboConfirm;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Button backBtn;
    }
}