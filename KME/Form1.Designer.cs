using System.Windows.Forms;
namespace KME
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            //this.PushUvedoml = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.IConBox = new System.Windows.Forms.PictureBox();
            this.ExitButPan = new System.Windows.Forms.Panel();
            this.Svn_button = new System.Windows.Forms.Button();
            this.Rzs_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.PanelOfMonth = new System.Windows.Forms.Panel();
            this._monthes_ = new System.Windows.Forms.Button[12];
            this.PanelOfYearh = new System.Windows.Forms.Panel();
            this.YearhButton = new System.Windows.Forms.Button();
            this.NumericYearh = new System.Windows.Forms.NumericUpDown();
            this.PanelOfYearh2 = new System.Windows.Forms.Panel();
            this.Local_timer = new System.Windows.Forms.Timer();
            this._yeahrs_ = new System.Windows.Forms.Button[201];
            this.MessList = new MessageList();
            this.LocalMonth = new KME.Months(this);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IConBox)).BeginInit();
            this.ExitButPan.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.IConBox);
            this.MainPanel.Controls.Add(this.ExitButPan);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 20);
            this.MainPanel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(20, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(720, 20);
            this.Title.TabIndex = 4;
            this.Title.Text = "Календарь - \"Мой Ежедневник\"";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zagolovok_down);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TittleName_Click);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Zagolovok_up);
            // 
            // IConBox
            // 
            this.IConBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IConBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("IConBox.ErrorImage")));
            this.IConBox.Image = ((System.Drawing.Image)(resources.GetObject("IConBox.Image")));
            this.IConBox.Location = new System.Drawing.Point(0, 0);
            this.IConBox.Name = "IConBox";
            this.IConBox.Size = new System.Drawing.Size(20, 20);
            this.IConBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IConBox.TabIndex = 5;
            this.IConBox.TabStop = false;
            // 
            // ExitButPan
            // 
            this.ExitButPan.Controls.Add(this.Svn_button);
            this.ExitButPan.Controls.Add(this.Rzs_button);
            this.ExitButPan.Controls.Add(this.Exit_button);
            this.ExitButPan.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButPan.Location = new System.Drawing.Point(740, 0);
            this.ExitButPan.Name = "ExitButPan";
            this.ExitButPan.Size = new System.Drawing.Size(60, 20);
            this.ExitButPan.TabIndex = 3;
            // 
            // Svern_button
            // 
            this.Svn_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Svn_button.Location = new System.Drawing.Point(0, 0);
            this.Svn_button.Name = "Svern_button";
            this.Svn_button.Size = new System.Drawing.Size(20, 20);
            this.Svn_button.TabIndex = 2;
            this.Svn_button.Text = "-";
            this.Svn_button.UseVisualStyleBackColor = true;
            this.Svn_button.Click += new System.EventHandler(this.Svern_button_Click);
            // 
            // Razs_button
            // 
            for (int i = 0; i < 12; i++)
            {
                this._monthes_[i] = new System.Windows.Forms.Button();
                this._monthes_[i].Location = new System.Drawing.Point(5, 4 + i * 25);
                this._monthes_[i].Name = "_monthes_";
                this._monthes_[i].Size = new System.Drawing.Size(151, 23);
                this._monthes_[i].TabIndex = i + 1;
                this._monthes_[i].Text = Months.Monthes[i + 1, 0];
                this._monthes_[i].UseVisualStyleBackColor = true;
                this._monthes_[i].Click += new System.EventHandler(this._monthes__Click);
                this.PanelOfMonth.Controls.Add(this._monthes_[i]);
            }
            this.NumericYearh.Location = new System.Drawing.Point(5, 4);
            this.NumericYearh.Name = "NumericYearh";
            this.NumericYearh.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumericYearh.Size = new System.Drawing.Size(151, 23);
            this.NumericYearh.TabIndex = 1;
            this.NumericYearh.Minimum = 1950;
            this.NumericYearh.Maximum = 2150;
            this.NumericYearh.Value = System.DateTime.Now.Year;
            this.NumericYearh.ValueChanged += new System.EventHandler(NumericYearh_ChangeUICues);
            this.NumericYearh.RegionChanged += new System.EventHandler(NumericYearh_ChangeUICues);
            

            this.Rzs_button.Location = new System.Drawing.Point(20, 0);
            this.Rzs_button.Name = "Razs_button";
            this.Rzs_button.Size = new System.Drawing.Size(20, 20);
            this.Rzs_button.TabIndex = 1;
            this.Rzs_button.Text = "=";
            this.Rzs_button.UseVisualStyleBackColor = true;
            this.Rzs_button.Click += new System.EventHandler(this.Razs_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_button.Location = new System.Drawing.Point(40, 0);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(20, 20);
            this.Exit_button.TabIndex = 0;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.PanelOfMonth);
            this.LeftPanel.Controls.Add(this.PanelOfYearh);
            this.LeftPanel.Controls.Add(this.YearhButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 20);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(3);
            this.LeftPanel.Size = new System.Drawing.Size(171, 458);
            this.LeftPanel.TabIndex = 2;
            // 
            // PanelOfMonth
            // 
            this.PanelOfMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelOfMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOfMonth.Location = new System.Drawing.Point(3, 34);
            this.PanelOfMonth.Name = "PanelOfMonth";
            this.PanelOfMonth.Size = new System.Drawing.Size(165, 421);
            this.PanelOfMonth.TabIndex = 1;


            this.PanelOfYearh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelOfYearh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOfYearh.Location = new System.Drawing.Point(3, 34);
            this.PanelOfYearh.Name = "PanelOfYearh";
            this.PanelOfYearh.Size = new System.Drawing.Size(165, 421);
            this.PanelOfYearh.TabIndex = 1;
            this.PanelOfYearh.Visible = false;


            this.PanelOfYearh2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelOfYearh2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOfYearh2.Location = new System.Drawing.Point(3, 34);
            this.PanelOfYearh2.Name = "PanelOfYearh2";
            this.PanelOfYearh2.TabIndex = 1;
            this.PanelOfYearh2.AutoScroll = true;
            this.PanelOfYearh.Controls.Add(this.PanelOfYearh2);
            this.PanelOfYearh.Controls.Add(this.NumericYearh);

            for (int y = 0, ry=(int)this.NumericYearh.Minimum; y <= 200; ry++, y++) {
                this._yeahrs_[y] = new System.Windows.Forms.Button();
                this._yeahrs_[y].Location = new System.Drawing.Point(5, 4 + y * 25);
                this._yeahrs_[y].Name = "_yeahrs_";
                this._yeahrs_[y].Size = new System.Drawing.Size(135, 23);
                this._yeahrs_[y].TabIndex = ry;
                this._yeahrs_[y].Text = ry+"";
                this._yeahrs_[y].UseVisualStyleBackColor = true;
                this._yeahrs_[y].Click += new System.EventHandler(this._yeahrs__Click);
                this.PanelOfYearh2.Controls.Add(this._yeahrs_[y]);
            }

                // 
                // YearhButton
                // 
                this.YearhButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearhButton.Location = new System.Drawing.Point(3, 3);
            this.YearhButton.Name = "YearhButton";
            this.YearhButton.Size = new System.Drawing.Size(165, 31);
            this.YearhButton.TabIndex = 0;
            this.YearhButton.Text = "<<<              Года";
            this.YearhButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YearhButton.UseVisualStyleBackColor = true;
            this.YearhButton.Click += new System.EventHandler(this.YearhButton_Click);


            this.Local_timer.Interval = 1000;
            this.Local_timer.Tick += new System.EventHandler(Local_timer_Tick);
            // 
            // ss
            // 
            this.LocalMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalMonth.Location = new System.Drawing.Point(179, 26);
            this.LocalMonth.Name = "ss";
            this.LocalMonth.Size = new System.Drawing.Size(350, 390);
            this.LocalMonth.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            //this.PushUvedoml.Icon = ((System.Drawing.Icon)(resources.GetObject("PushUvedoml.Icon")));
            //this.PushUvedoml.Text = "KME";

            this.MessList.Dock = System.Windows.Forms.DockStyle.Right;
            this.MessList.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MessList);
            this.Controls.Add(this.LocalMonth);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Календарь - \"Мой Ежедневник\"";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IConBox)).EndInit();
            this.ExitButPan.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Rzs_button;
        private System.Windows.Forms.Button Svn_button;
        private System.Windows.Forms.Panel ExitButPan;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox IConBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Months LocalMonth;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button YearhButton;
        private System.Windows.Forms.Panel PanelOfMonth;
        private System.Windows.Forms.Panel PanelOfYearh;
        private System.Windows.Forms.Panel PanelOfYearh2;
        private System.Windows.Forms.Button[] _monthes_;
        private System.Windows.Forms.Button[] _yeahrs_;
        private System.Windows.Forms.NumericUpDown NumericYearh;
        private MessageList MessList;
        private System.Windows.Forms.Timer Local_timer;
        //public NotifyIcon PushUvedoml;
    }
}

