namespace KME
{
    partial class MessageView
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
            this.Panel_TittleName = new System.Windows.Forms.Panel();
            this.TittleName = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Redact = new System.Windows.Forms.Button();
            this.TimeLocal = new System.Windows.Forms.Label();
            this.TImeMeess = new System.Windows.Forms.ToolTip(this.components);
            this.ContentMessage = new System.Windows.Forms.Panel();
            this.Panel_TittleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanZagalovok
            // 
            this.Panel_TittleName.Controls.Add(this.TittleName);
            this.Panel_TittleName.Controls.Add(this.Delete);
            this.Panel_TittleName.Controls.Add(this.Redact);
            this.Panel_TittleName.Controls.Add(this.TimeLocal);
            this.Panel_TittleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TittleName.Location = new System.Drawing.Point(2, 2);
            this.Panel_TittleName.Name = "PanZagalovok";
            this.Panel_TittleName.Size = new System.Drawing.Size(346, 20);
            this.Panel_TittleName.TabIndex = 2;
            // 
            // Zagalovok
            // 
            this.TittleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TittleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TittleName.Location = new System.Drawing.Point(40, 0);
            this.TittleName.Name = "Zagalovok";
            this.TittleName.Size = new System.Drawing.Size(206, 20);
            this.TittleName.TabIndex = 0;
            this.TittleName.Text = "Загаловок";
            this.TittleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.Delete.Location = new System.Drawing.Point(20, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(20, 20);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "X";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Redact
            // 
            this.Redact.Dock = System.Windows.Forms.DockStyle.Left;
            this.Redact.Location = new System.Drawing.Point(0, 0);
            this.Redact.Name = "Redact";
            this.Redact.Size = new System.Drawing.Size(20, 20);
            this.Redact.TabIndex = 2;
            this.Redact.Text = "/";
            this.Redact.UseVisualStyleBackColor = true;
            this.Redact.Click += new System.EventHandler(this.Redact_Click);
            // 
            // Vremya
            // 
            this.TimeLocal.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLocal.Location = new System.Drawing.Point(246, 0);
            this.TimeLocal.Name = "Vremya";
            this.TimeLocal.Size = new System.Drawing.Size(100, 20);
            this.TimeLocal.TabIndex = 1;
            this.TimeLocal.Text = "Время";
            this.TimeLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TImeMeess
            // 
            this.TImeMeess.Tag = "";
            // 
            // ContentMessage
            // 
            this.ContentMessage.BackColor = System.Drawing.Color.White;
            this.ContentMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContentMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentMessage.Location = new System.Drawing.Point(2, 22);
            this.ContentMessage.Name = "ContentMessage";
            this.ContentMessage.Size = new System.Drawing.Size(346, 46);
            this.ContentMessage.TabIndex = 3;
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ContentMessage);
            this.Controls.Add(this.Panel_TittleName);
            this.Name = "MessageView";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(350, 70);
            this.Panel_TittleName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_TittleName;
        private System.Windows.Forms.Label TimeLocal;
        private System.Windows.Forms.ToolTip TImeMeess;
        private System.Windows.Forms.Panel ContentMessage;
        private System.Windows.Forms.Button Redact;
        private System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label TittleName;
    }
}
