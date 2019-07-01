namespace SharpUpdate
{
    partial class SharpUpdateInfoForm
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
            this.lblVersions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVersions
            // 
            this.lblVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersions.Location = new System.Drawing.Point(87, 74);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(100, 23);
            this.lblVersions.TabIndex = 0;
            this.lblVersions.Text = "label1";
            this.lblVersions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SharpUpdateInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 251);
            this.Controls.Add(this.lblVersions);
            this.Name = "SharpUpdateInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SharpUpdateInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVersions;
    }
}