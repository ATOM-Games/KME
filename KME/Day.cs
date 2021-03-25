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
    public partial class Day : UserControl
    {
        public Form1 localForm;
        int _YEARH, _MOTHN, _DAY;
        public Day(Form1 fm1)
        {
            InitializeComponent();
            this.localForm = fm1;
        }
        public void SetDay(int yearh, int month, int day) {
            /*if (DateTime.Now.Year == yearh && DateTime.Now.Month == month && DateTime.Now.Day == day) {
                this.BackColor = Color.Azure;
            } else {
                this.BackColor = Color.SkyBlue;
            }*/
            this.Texts.Text = day+"";
            this._YEARH = yearh; this._MOTHN = month; this._DAY = day;
            this.Texts.ForeColor = Color.Black;
            //this.Enabled = true;
        }

        public void SetDay(string str) {
            //this.BackColor = Color.SkyBlue;
            this.Texts.Text = str;
            this.Texts.ForeColor = Color.Gray;
            //this.Enabled = false;
        }

        private void Text_Exit(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Text_Enter(object sender, EventArgs e)
        {
            if (this.Texts.ForeColor == Color.Black) this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void Texts_Click(object sender, EventArgs e)
        {
            if (this.Texts.ForeColor == Color.Black)
            {
                Form1._DAY = this._DAY;
                localForm.SelectDay(_YEARH, _MOTHN, _DAY);
            }
        }
    }
}
