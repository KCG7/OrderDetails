namespace OrderDetails
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gvOrderDetails = new System.Windows.Forms.DataGridView();
            this.pnlOrderDetails = new System.Windows.Forms.Panel();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetails)).BeginInit();
            this.pnlOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvOrderDetails
            // 
            this.gvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderDetails.Location = new System.Drawing.Point(-1, 111);
            this.gvOrderDetails.Name = "gvOrderDetails";
            this.gvOrderDetails.RowHeadersWidth = 62;
            this.gvOrderDetails.RowTemplate.Height = 28;
            this.gvOrderDetails.Size = new System.Drawing.Size(801, 342);
            this.gvOrderDetails.TabIndex = 0;
            // 
            // pnlOrderDetails
            // 
            this.pnlOrderDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOrderDetails.BackgroundImage")));
            this.pnlOrderDetails.Controls.Add(this.lblOrderDetails);
            this.pnlOrderDetails.Location = new System.Drawing.Point(-1, 0);
            this.pnlOrderDetails.Name = "pnlOrderDetails";
            this.pnlOrderDetails.Size = new System.Drawing.Size(801, 114);
            this.pnlOrderDetails.TabIndex = 1;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(75, 31);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(443, 40);
            this.lblOrderDetails.TabIndex = 0;
            this.lblOrderDetails.Text = "Order Details Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrderDetails);
            this.Controls.Add(this.gvOrderDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetails)).EndInit();
            this.pnlOrderDetails.ResumeLayout(false);
            this.pnlOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrderDetails;
        private System.Windows.Forms.Panel pnlOrderDetails;
        private System.Windows.Forms.Label lblOrderDetails;
    }
}

