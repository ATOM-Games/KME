using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KME
{
    public partial class check_kusock : UserControl
    {

        AddRedact addred;

        public check_kusock(AddRedact ss)
        {
            InitializeComponent();
            this.addred = ss;

        }

        private void DeletButton_Click(object sender, System.EventArgs e)
        {
            addred.inWorkPage.Controls.Remove(this);
        }
        void Text_kusock_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.PointToClient(Cursor.Position).X > this.Location.X && this.PointToClient(Cursor.Position).X < this.Location.X + this.Size.Width &&
                this.PointToClient(Cursor.Position).Y > this.Location.Y && this.PointToClient(Cursor.Position).Y < this.Location.Y + this.Size.Height)
            {
                this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.BackColor = System.Drawing.Color.FromArgb(255, 220, 220, 220);
                this.DeletButton.Visible = true;
            }
            else
            {
                this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.BackColor = System.Drawing.Color.White;
                this.DeletButton.Visible = false;
            }
            
            
        }


        private void Component_MouseHover(object sender, EventArgs ee) { 
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackColor = Color.Blue;
            //this.DeletButton.Visible = true;
        }
        private void Component_MouseLeave(object sender, EventArgs ee) {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackColor = Color.Aqua;
            //this.DeletButton.Visible = false;
        }
    }
}
