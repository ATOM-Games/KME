using System.Windows.Forms;
namespace KME
{
    partial class Text_kusock
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelLocale = new System.Windows.Forms.Label();
            this.DeletButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Name = "textBox1";
            this.textBox1.TabIndex = 0;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.TextChanged += new System.EventHandler(delegate { this.LabelLocale.Text = this.textBox1.Text; });

            this.LabelLocale.AutoSize = true;
            this.LabelLocale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLocale.Padding = new System.Windows.Forms.Padding(5);
            this.LabelLocale.Name = "label1";
            this.LabelLocale.Size = new System.Drawing.Size(0, 13);
            this.LabelLocale.Text = "";
            this.LabelLocale.ForeColor = System.Drawing.Color.Transparent;
            this.LabelLocale.Resize += new System.EventHandler(delegate { this.Height = this.LabelLocale.Height; });


            this.DeletButton.Size = new System.Drawing.Size(20,20);
            this.DeletButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.DeletButton.Location = new System.Drawing.Point(125, 3);
            this.DeletButton.Text = "X";
            this.DeletButton.Visible = false;
            this.DeletButton.Click += new System.EventHandler(DeletButton_Click);

            // 
            // Text_kusock
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.textBox1.MouseEnter += new System.EventHandler(Component_MouseHover);
            this.textBox1.MouseLeave += new System.EventHandler(Component_MouseLeave);
            this.textBox1.MouseDown += new MouseEventHandler(textBox1_MouseClick);
            this.Padding = new Padding(2);
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.DeletButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelLocale);
            this.Name = "Text_kusock";
            this.MinimumSize = new System.Drawing.Size(100, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                this.DeletButton.Visible = !this.DeletButton.Visible;
            }
        }

        

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label LabelLocale;
        public System.Windows.Forms.Button DeletButton;
    }
}
