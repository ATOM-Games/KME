namespace KME
{
    partial class ContextMenu
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
        /// 
        System.Drawing.Color tr = System.Drawing.Color.Transparent;
        private void InitializeComponent()
        {
            this.StringButton = new System.Windows.Forms.PictureBox();
            this.CheckButtom = new System.Windows.Forms.PictureBox();
            this.Tooleann = new System.Windows.Forms.ToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.StringButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckButtom)).BeginInit();
            this.SuspendLayout();
            // 
            // StringButton
            // 
            this.StringButton.BackgroundImage = global::KME.Properties.Resources.str;
            this.StringButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StringButton.Location = new System.Drawing.Point(1, 1);
            this.StringButton.Name = "StringButton";
            this.StringButton.Size = new System.Drawing.Size(198, 48);
            this.StringButton.TabIndex = 0;
            this.StringButton.TabStop = false;
            this.StringButton.Click += new System.EventHandler(this.StringButton_Click);
            this.StringButton.MouseEnter += new System.EventHandler(delegate { this.StringButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; });
            this.StringButton.MouseLeave += new System.EventHandler(delegate { this.StringButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; });
            // 
            // CheckButtom
            // 
            this.CheckButtom.BackgroundImage = global::KME.Properties.Resources.chech;
            this.CheckButtom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckButtom.Location = new System.Drawing.Point(1, 51);
            this.CheckButtom.Name = "CheckButtom";
            this.CheckButtom.Size = new System.Drawing.Size(198, 48);
            this.CheckButtom.TabIndex = 1;
            this.CheckButtom.TabStop = false;
            this.CheckButtom.Click += new System.EventHandler(this.CheckButtom_Click);
            this.CheckButtom.MouseEnter += new System.EventHandler(delegate { this.CheckButtom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; });
            this.CheckButtom.MouseLeave += new System.EventHandler(delegate { this.CheckButtom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; });
            // 
            // ContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.CheckButtom);
            this.Controls.Add(this.StringButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContextMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ContextMenu";
            ((System.ComponentModel.ISupportInitialize)(this.StringButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckButtom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip Tooleann;
        private System.Windows.Forms.PictureBox StringButton;
        private System.Windows.Forms.PictureBox CheckButtom;
    }
}