namespace KME
{
    partial class AddRedact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRedact));
            this.MainMenu = new System.Windows.Forms.Panel();
            this.DateTimeButtom = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.AddChek = new System.Windows.Forms.Button();
            this.AddText = new System.Windows.Forms.Button();
            this.Glavnaya = new System.Windows.Forms.CheckBox();
            this.Zagalovok = new System.Windows.Forms.TextBox();
            this.WorkPage = new System.Windows.Forms.Panel();
            this.inWorkPage = new System.Windows.Forms.Panel();
            this.Plus = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.WorkPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenu.Controls.Add(this.DateTimeButtom);
            this.MainMenu.Controls.Add(this.OK_button);
            this.MainMenu.Controls.Add(this.AddChek);
            this.MainMenu.Controls.Add(this.AddText);
            this.MainMenu.Controls.Add(this.Glavnaya);
            this.MainMenu.Controls.Add(this.Zagalovok);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5);
            this.MainMenu.Size = new System.Drawing.Size(640, 63);
            this.MainMenu.TabIndex = 1;
            // 
            // DateTimeButtom
            // 
            this.DateTimeButtom.Location = new System.Drawing.Point(218, 36);
            this.DateTimeButtom.Name = "DateTimeButtom";
            this.DateTimeButtom.Size = new System.Drawing.Size(247, 20);
            this.DateTimeButtom.TabIndex = 5;
            this.DateTimeButtom.Text = "Лучшая команда в жизни!";
            this.DateTimeButtom.UseVisualStyleBackColor = true;
            this.DateTimeButtom.Click += new System.EventHandler(this.DateTimeButtom_Click);
            // 
            // OK_button
            // 
            this.OK_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OK_button.Location = new System.Drawing.Point(471, 39);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(64, 20);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddChek
            // 
            this.AddChek.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddChek.Location = new System.Drawing.Point(105, 36);
            this.AddChek.Name = "AddChek";
            this.AddChek.Size = new System.Drawing.Size(107, 20);
            this.AddChek.TabIndex = 3;
            this.AddChek.Text = "Добавить галочку";
            this.AddChek.UseVisualStyleBackColor = true;
            this.AddChek.Click += new System.EventHandler(this.AddChek_Click);
            // 
            // AddText
            // 
            this.AddText.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddText.Location = new System.Drawing.Point(5, 36);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(100, 20);
            this.AddText.TabIndex = 2;
            this.AddText.Text = "Добавить тект";
            this.AddText.UseVisualStyleBackColor = true;
            this.AddText.Click += new System.EventHandler(this.AddText_Click);
            // 
            // Glavnaya
            // 
            this.Glavnaya.AutoSize = true;
            this.Glavnaya.Dock = System.Windows.Forms.DockStyle.Right;
            this.Glavnaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Glavnaya.FlatAppearance.BorderSize = 4;
            this.Glavnaya.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.Glavnaya.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Glavnaya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Glavnaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Glavnaya.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Glavnaya.Location = new System.Drawing.Point(541, 36);
            this.Glavnaya.Name = "Glavnaya";
            this.Glavnaya.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Glavnaya.Size = new System.Drawing.Size(92, 20);
            this.Glavnaya.TabIndex = 1;
            this.Glavnaya.Text = "Важное";
            this.Glavnaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Glavnaya.UseVisualStyleBackColor = true;
            this.Glavnaya.CheckedChanged += new System.EventHandler(this.Glavnaya_CheckedChanged);
            // 
            // Zagalovok
            // 
            this.Zagalovok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.Zagalovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.Zagalovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zagalovok.Location = new System.Drawing.Point(5, 5);
            this.Zagalovok.Name = "Zagalovok";
            this.Zagalovok.Size = new System.Drawing.Size(628, 31);
            this.Zagalovok.TabIndex = 0;
            // 
            // WorkPage
            // 
            this.WorkPage.AutoScroll = true;
            this.WorkPage.BackColor = System.Drawing.Color.White;
            this.WorkPage.Controls.Add(this.inWorkPage);
            this.WorkPage.Controls.Add(this.Plus);
            this.WorkPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPage.Location = new System.Drawing.Point(0, 63);
            this.WorkPage.Name = "WorkPage";
            this.WorkPage.Size = new System.Drawing.Size(640, 306);
            this.WorkPage.TabIndex = 2;
            // 
            // inWorkPage
            // 
            this.inWorkPage.AutoSize = true;
            this.inWorkPage.BackColor = System.Drawing.Color.White;
            this.inWorkPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.inWorkPage.Location = new System.Drawing.Point(0, 33);
            this.inWorkPage.Name = "inWorkPage";
            this.inWorkPage.Size = new System.Drawing.Size(640, 0);
            this.inWorkPage.TabIndex = 2;
            this.inWorkPage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AddText_Click);
            // 
            // Plus
            // 
            this.Plus.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plus.Location = new System.Drawing.Point(0, 0);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(640, 33);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // AddRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 369);
            this.Controls.Add(this.WorkPage);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRedact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AddText_Click);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.WorkPage.ResumeLayout(false);
            this.WorkPage.PerformLayout();
            this.ResumeLayout(false);

        }

        void Glavnaya_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Zagalovok.ForeColor = (this.Glavnaya.Checked) ? System.Drawing.Color.Red : System.Drawing.Color.Black;
            this.Zagalovok.BackColor = (this.Glavnaya.Checked) ? System.Drawing.Color.FromArgb(255, 255, 230, 230) : System.Drawing.Color.FromArgb(255, 230, 230, 255);
        }

        

        

        #endregion

        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.TextBox Zagalovok;
        private System.Windows.Forms.CheckBox Glavnaya;
        private System.Windows.Forms.Button AddText;
        private System.Windows.Forms.Button AddChek;
        private System.Windows.Forms.Button Plus;
        public System.Windows.Forms.Panel WorkPage;
        public System.Windows.Forms.Panel inWorkPage;
        private System.Windows.Forms.Button OK_button;
        public System.Windows.Forms.Button DateTimeButtom;
    }
}