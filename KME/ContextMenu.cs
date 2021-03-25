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
        Panel wie; Button sss; AddRedact sa;
        public ContextMenu(Button btn, Panel workses, AddRedact s)
        {
            InitializeComponent();
            this.Location = new Point((Cursor.Position.X), (Cursor.Position.Y));
            this.sa = s;
            this.Tooleann.SetToolTip(this.StringButton, "Создать обычную строку");
            this.Tooleann.SetToolTip(this.CheckButtom, "Создать галочку");
            this.wie = workses;
            this.sss = btn;
            sss.Enabled = false;
        }

        private void StringButton_Click(object sender, EventArgs e)
        {
            sa.AddText_Click(sender, e);
            sss.Enabled = true;
            this.Close();
        }
        private void CheckButtom_Click(object sender, EventArgs e)
        {
            sa.AddChek_Click(sender, e);
            sss.Enabled = true;
            this.Close();
        }

    }
}
