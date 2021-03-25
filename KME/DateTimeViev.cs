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
    public partial class DateTimeViev : Form
    {
        public AddRedact Adr;
        public DateTimeViev()
        {
            InitializeComponent();
        }

        private void ResetButtom_Click(object sender, EventArgs e)
        {
            Adr.DateTimeButtom.Enabled = true;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.Calendar.SelectionRange.Start != null)
            {
                Adr.ThisMeessageDateTime = new DateTime(this.Calendar.SelectionRange.Start.Year, this.Calendar.SelectionRange.Start.Month, this.Calendar.SelectionRange.Start.Day, (int)this.NumHourh.Value, (int)this.NumMinute.Value, (int)this.NumSecunde.Value);
                Adr.SetTextButtonDateTime();
            }
            Adr.DateTimeButtom.Enabled = true;
            this.Close();
        }
    }
}
