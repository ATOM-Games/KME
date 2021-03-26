using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KME
{
    public partial class ContextMenu : Form
    {
        Panel wie; Button but; AddRedact adRe;
        public ContextMenu(Button btn, Panel workses, AddRedact s)
        {
            InitializeComponent();
            this.Location = new Point((Cursor.Position.X), (Cursor.Position.Y));
            this.adRe = s;
            this.Tool_.SetToolTip(this.StringButton, "Создать обычную строку");
            this.Tool_.SetToolTip(this.CheckButtom, "Создать галочку");
            this.wie = workses;
            this.but = btn;
            but.Enabled = false;
        }

        private void StringButton_Click(object sender, EventArgs e)
        {
            adRe.AddText_Click(sender, e);
            but.Enabled = true;
            this.Close();
        }
        private void CheckButtom_Click(object sender, EventArgs e)
        {
            adRe.AddChek_Click(sender, e);
            but.Enabled = true;
            this.Close();
        }

    }
}
