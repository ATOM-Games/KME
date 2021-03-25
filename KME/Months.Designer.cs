namespace KME
{
    partial class Months
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
        private void InitializeComponent(Form1 fm1)
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Yearh_and_month = new System.Windows.Forms.Label();
            this.PN = new System.Windows.Forms.Label();
            this.VT = new System.Windows.Forms.Label();
            this.SR = new System.Windows.Forms.Label();
            this.CTCT = new System.Windows.Forms.Label();
            this.PT = new System.Windows.Forms.Label();
            this.CB = new System.Windows.Forms.Label();
            this.VS = new System.Windows.Forms.Label();
            this.LocalDay = new KME.Day[6,7];
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Yearh_and_month);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 35);
            this.panel1.TabIndex = 0;
            // 
            // Yearh_and_month
            // 
            this.Yearh_and_month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Yearh_and_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yearh_and_month.Location = new System.Drawing.Point(0, 0);
            this.Yearh_and_month.Name = "Yearh_and_month";
            this.Yearh_and_month.Size = new System.Drawing.Size(350, 35);
            this.Yearh_and_month.TabIndex = 0;
            this.Yearh_and_month.Text = "Май 1995";
            this.Yearh_and_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Yearh_and_month.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // PN
            // 
            this.PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PN.Location = new System.Drawing.Point(0, 35);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(50, 40);
            this.PN.TabIndex = 1;
            this.PN.Text = "Пн";
            this.PN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PN.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // VT
            // 
            this.VT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VT.Location = new System.Drawing.Point(50, 35);
            this.VT.Name = "VT";
            this.VT.Size = new System.Drawing.Size(50, 40);
            this.VT.TabIndex = 2;
            this.VT.Text = "Вт";
            this.VT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VT.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // SR
            // 
            this.SR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SR.Location = new System.Drawing.Point(100, 35);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(50, 40);
            this.SR.TabIndex = 3;
            this.SR.Text = "Ср";
            this.SR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SR.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // CTCT
            // 
            this.CTCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTCT.Location = new System.Drawing.Point(150, 35);
            this.CTCT.Name = "CTCT";
            this.CTCT.Size = new System.Drawing.Size(50, 40);
            this.CTCT.TabIndex = 4;
            this.CTCT.Text = "Чт";
            this.CTCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CTCT.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // PT
            // 
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    LocalDay[y, x] = new Day(fm1);
                    LocalDay[y, x].Location = new System.Drawing.Point(x * 50, 85 + y * 50);
                    this.Controls.Add(this.LocalDay[y, x]);
                }
            }
            this.PT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PT.Location = new System.Drawing.Point(200, 35);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(50, 40);
            this.PT.TabIndex = 5;
            this.PT.Text = "Пт";
            this.PT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PT.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // CB
            // 



            this.CB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB.Location = new System.Drawing.Point(250, 35);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(50, 40);
            this.CB.TabIndex = 6;
            this.CB.Text = "Сб";
            this.CB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // VS
            // 
            this.VS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VS.Location = new System.Drawing.Point(300, 35);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(50, 40);
            this.VS.TabIndex = 7;
            this.VS.Text = "Вс";
            this.VS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VS.BackColor = System.Drawing.Color.FromArgb(255, 255, 230);
            // 
            // Months
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.Controls.Add(this.VS);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.CTCT);
            this.Controls.Add(this.SR);
            this.Controls.Add(this.VT);
            this.Controls.Add(this.PN);
            this.Controls.Add(this.panel1);
            this.Name = "Months";
            this.Size = new System.Drawing.Size(350, 420);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Yearh_and_month;
        private System.Windows.Forms.Label PN;
        private System.Windows.Forms.Label VT;
        private System.Windows.Forms.Label SR;
        private System.Windows.Forms.Label CTCT;
        private System.Windows.Forms.Label PT;
        private System.Windows.Forms.Label CB;
        private System.Windows.Forms.Label VS;
        public Day[,] LocalDay;
    }
}
