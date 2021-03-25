namespace KME
{
    partial class Day
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Texts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texts
            // 
            this.Texts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Texts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Texts.Location = new System.Drawing.Point(0, 0);
            this.Texts.Name = "Texts";
            this.Texts.Size = new System.Drawing.Size(50, 50);
            this.Texts.TabIndex = 0;
            this.Texts.Text = "1";
            this.Texts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Texts.Click += new System.EventHandler(this.Texts_Click);
            this.Texts.MouseEnter += new System.EventHandler(this.Text_Enter);
            this.Texts.MouseLeave += new System.EventHandler(this.Text_Exit);
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Texts);
            this.Name = "Day";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Texts;


        public System.EventHandler Day_MouseLeave { get; set; }

        public System.EventHandler Day_MouseHover { get; set; }
    }
}
