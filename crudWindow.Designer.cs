namespace Parlor
{
    partial class crudWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crudWindow));
            this.label7 = new System.Windows.Forms.Label();
            this.crudBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(959, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Beauty Parlor Management ";
            // 
            // crudBtn
            // 
            this.crudBtn.BackColor = System.Drawing.Color.Transparent;
            this.crudBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crudBtn.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crudBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crudBtn.Location = new System.Drawing.Point(539, 425);
            this.crudBtn.Name = "crudBtn";
            this.crudBtn.Size = new System.Drawing.Size(110, 55);
            this.crudBtn.TabIndex = 13;
            this.crudBtn.Text = "CRUD";
            this.crudBtn.UseVisualStyleBackColor = false;
            this.crudBtn.Click += new System.EventHandler(this.crudBtn_Click);
            // 
            // crudWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 669);
            this.Controls.Add(this.crudBtn);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "crudWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crudWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button crudBtn;
    }
}