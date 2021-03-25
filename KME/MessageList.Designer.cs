using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
namespace KME
{
    partial class MessageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageList));
            this.Zagalovok = new System.Windows.Forms.Label();
            this.PoleLista = new System.Windows.Forms.Panel();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.AdNeMe = new System.Windows.Forms.Button();
            this.AllMessages = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.PushUvedoml = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zagalovok
            // 
            this.Zagalovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.Zagalovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zagalovok.Location = new System.Drawing.Point(3, 3);
            this.Zagalovok.Name = "Zagalovok";
            this.Zagalovok.Size = new System.Drawing.Size(327, 25);
            this.Zagalovok.TabIndex = 0;
            this.Zagalovok.Text = "label1";
            this.Zagalovok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Zagalovok.BackColor = Color.FromArgb(255, 255, 230);
            // 
            // PoleLista
            // 
            this.PoleLista.AutoScroll = true;
            this.PoleLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PoleLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoleLista.Location = new System.Drawing.Point(3, 78);
            this.PoleLista.Name = "PoleLista";
            this.PoleLista.Size = new System.Drawing.Size(327, 299);
            this.PoleLista.TabIndex = 1;
            this.PoleLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PoleLista_MouseDoubleClick);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuPanel.Controls.Add(this.AdNeMe);
            this.MainMenuPanel.Controls.Add(this.AllMessages);
            this.MainMenuPanel.Controls.Add(this.ArchiveButton);
            this.MainMenuPanel.Controls.Add(this.FindButton);
            this.MainMenuPanel.Controls.Add(this.findTextBox);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuPanel.Location = new System.Drawing.Point(3, 28);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(327, 50);
            this.MainMenuPanel.TabIndex = 2;
            // 
            // AdNeMe
            // 
            this.AdNeMe.Location = new System.Drawing.Point(185, 25);
            this.AdNeMe.Name = "AdNeMe";
            this.AdNeMe.Size = new System.Drawing.Size(54, 20);
            this.AdNeMe.TabIndex = 4;
            this.AdNeMe.Text = "+";
            this.AdNeMe.UseVisualStyleBackColor = true;
            this.AdNeMe.Click += new System.EventHandler(this.AdNeMe_Click);
            // 
            // AllMessages
            // 
            this.AllMessages.Location = new System.Drawing.Point(84, 25);
            this.AllMessages.Name = "AllMessages";
            this.AllMessages.Size = new System.Drawing.Size(99, 20);
            this.AllMessages.TabIndex = 3;
            this.AllMessages.Text = "Все сообщения";
            this.AllMessages.UseVisualStyleBackColor = true;
            this.AllMessages.Click += new System.EventHandler(this.AllMessages_Click);
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Location = new System.Drawing.Point(3, 25);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(75, 20);
            this.ArchiveButton.TabIndex = 2;
            this.ArchiveButton.Text = "архив";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(185, 3);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(54, 20);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "искать";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(3, 3);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(180, 20);
            this.findTextBox.TabIndex = 0;
            // 
            // PushUvedoml
            // 
            this.PushUvedoml.Icon = ((System.Drawing.Icon)(resources.GetObject("PushUvedoml.Icon")));
            this.PushUvedoml.Text = "KME";
            this.PushUvedoml.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PushUvedoml_MouseDoubleClick);
            // 
            // MessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PoleLista);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.Zagalovok);
            this.Name = "MessageList";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(333, 380);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        void PushUvedoml_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.Application != null)
            {
                this.Application.WindowState = System.Windows.Forms.FormWindowState.Normal;
                if (this.PushUvedoml.BalloonTipTitle == "КME осталось 48 часов")
                {
                    this.Application.SelectDay(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 2);
                }
                if (this.PushUvedoml.BalloonTipTitle == "КME осталось 24 часа")
                {
                    this.Application.SelectDay(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                }
                if (this.PushUvedoml.BalloonTipTitle == "КME остался 1 час")
                {
                    this.Application.SelectDay(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                }
            }
        }

        #endregion

        private System.Windows.Forms.Label Zagalovok;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button ArchiveButton;
        public System.Windows.Forms.Panel PoleLista;
        private System.Windows.Forms.Button AllMessages;
        public System.Windows.Forms.NotifyIcon PushUvedoml;
        private System.Windows.Forms.Button AdNeMe;
        public Form1 Application;
    }
}
