namespace ADAOS
{
    partial class DineInOrTakeOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DineInOrTakeOut));
            this.lblDineInOrTakeOut = new System.Windows.Forms.Label();
            this.btnDineIn = new System.Windows.Forms.Button();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblDineInOrTakeOut
            // 
            this.lblDineInOrTakeOut.AutoSize = true;
            this.lblDineInOrTakeOut.Font = new System.Drawing.Font("Courier New", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDineInOrTakeOut.Location = new System.Drawing.Point(124, 283);
            this.lblDineInOrTakeOut.Name = "lblDineInOrTakeOut";
            this.lblDineInOrTakeOut.Size = new System.Drawing.Size(1397, 134);
            this.lblDineInOrTakeOut.TabIndex = 0;
            this.lblDineInOrTakeOut.Text = "Would you like to dine in or take out \r\nyour order today?\r\n";
            this.lblDineInOrTakeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDineIn
            // 
            this.btnDineIn.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDineIn.Location = new System.Drawing.Point(399, 507);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(354, 179);
            this.btnDineIn.TabIndex = 1;
            this.btnDineIn.Text = "Dine-in";
            this.btnDineIn.UseVisualStyleBackColor = true;
            this.btnDineIn.Click += new System.EventHandler(this.btnDineIn_Click);
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakeOut.Location = new System.Drawing.Point(837, 507);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(354, 179);
            this.btnTakeOut.TabIndex = 2;
            this.btnTakeOut.Text = "Take-Out";
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(-3, 855);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1619, 11);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // DineInOrTakeOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnDineIn);
            this.Controls.Add(this.lblDineInOrTakeOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DineInOrTakeOut";
            this.Text = "DineInOrTakeOut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDineInOrTakeOut;
        private Button btnDineIn;
        private Button btnTakeOut;
        private ProgressBar progressBar1;
    }
}