namespace KME
{
    partial class DateTimeViev
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.LabelLocal = new System.Windows.Forms.Label();
            this.NumHourh = new System.Windows.Forms.NumericUpDown();
            this.NumMinute = new System.Windows.Forms.NumericUpDown();
            this.NumSecunde = new System.Windows.Forms.NumericUpDown();
            this.ResetButtom = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumHourh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecunde)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(0, 0);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            // 
            // labla
            // 
            this.LabelLocal.AutoSize = true;
            this.LabelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLocal.Location = new System.Drawing.Point(176, 39);
            this.LabelLocal.Name = "labla";
            this.LabelLocal.Size = new System.Drawing.Size(104, 72);
            this.LabelLocal.TabIndex = 1;
            this.LabelLocal.Text = "Час :\r\nМинута :\r\nСекунда :\r\n";
            this.LabelLocal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NumHourh
            // 
            this.NumHourh.Location = new System.Drawing.Point(286, 41);
            this.NumHourh.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumHourh.Name = "NumHourh";
            this.NumHourh.Size = new System.Drawing.Size(120, 20);
            this.NumHourh.TabIndex = 2;
            // 
            // NumMinute
            // 
            this.NumMinute.Location = new System.Drawing.Point(286, 67);
            this.NumMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumMinute.Name = "NumMinute";
            this.NumMinute.Size = new System.Drawing.Size(120, 20);
            this.NumMinute.TabIndex = 3;
            // 
            // NumSecunde
            // 
            this.NumSecunde.Location = new System.Drawing.Point(286, 93);
            this.NumSecunde.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumSecunde.Name = "NumSecunde";
            this.NumSecunde.Size = new System.Drawing.Size(120, 20);
            this.NumSecunde.TabIndex = 4;
            // 
            // ResetButtom
            // 
            this.ResetButtom.Location = new System.Drawing.Point(176, 127);
            this.ResetButtom.Name = "ResetButtom";
            this.ResetButtom.Size = new System.Drawing.Size(75, 23);
            this.ResetButtom.TabIndex = 5;
            this.ResetButtom.Text = "Отмена";
            this.ResetButtom.UseVisualStyleBackColor = true;
            this.ResetButtom.Click += new System.EventHandler(this.ResetButtom_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(339, 127);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DateTimeViev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 162);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ResetButtom);
            this.Controls.Add(this.NumSecunde);
            this.Controls.Add(this.NumMinute);
            this.Controls.Add(this.NumHourh);
            this.Controls.Add(this.LabelLocal);
            this.Controls.Add(this.Calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateTimeViev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimeViev";
            ((System.ComponentModel.ISupportInitialize)(this.NumHourh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLocal;
        private System.Windows.Forms.Button ResetButtom;
        private System.Windows.Forms.Button OkButton;
        public System.Windows.Forms.NumericUpDown NumHourh;
        public System.Windows.Forms.NumericUpDown NumMinute;
        public System.Windows.Forms.NumericUpDown NumSecunde;
        public System.Windows.Forms.MonthCalendar Calendar;
    }
}