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
    public partial class AddRedact : Form
    {

        Message localMessage = null; int oldID = -1;
        public DateTime ThisMeessageDateTime;
        public AddRedact()
        {
            InitializeComponent();
            //MessageBox.Show(Form1._YEARH+" "+Form1._MONTH+" "+Form1._DAY);
            this.ThisMeessageDateTime = new DateTime(Form1._YEARH, Form1._MONTH, Form1._DAY);
            SetTextButtonDateTime();
        }
        public AddRedact(int indes)
        {
            InitializeComponent();
            this.localMessage = MessageControl.msContr.messages[indes];
            oldID = indes;
            this.Zagalovok.Text = MessageControl.msContr.messages[indes].Zagalovok;
            this.Glavnaya.Checked = MessageControl.msContr.messages[indes].Vajnoe;
            this.ThisMeessageDateTime = MessageControl.msContr.messages[indes].TimeDate;
            foreach (TextBody txtbd in MessageControl.msContr.messages[indes].Textes)
            {
                if (txtbd.GetType().ToString() == "KME.TextBody")
                {
                    Text_kusock txtk = new Text_kusock(this);
                    txtk.Dock = DockStyle.Bottom;
                    txtk.Margin = new System.Windows.Forms.Padding(5);
                    txtk.AutoSize = true;
                    txtk.textBox1.Text = txtbd.sTextBody;
                    txtk.lasee.MaximumSize = new Size(this.Size.Width, 10000);
                    this.Resize += new EventHandler(delegate { txtk.lasee.MaximumSize = new Size(txtk.Size.Width, 10000); });
                    this.inWorkPage.Controls.Add(txtk);
                }
                if (txtbd.GetType().ToString() == "KME.CheckBody")
                {
                    check_kusock txtk = new check_kusock(this);
                    txtk.Dock = DockStyle.Bottom;
                    txtk.Margin = new System.Windows.Forms.Padding(5);
                    txtk.AutoSize = true;
                    txtk.textBox1.Text = ((CheckBody)txtbd).sTextBody;
                    txtk.chchchcl.Checked = ((CheckBody)txtbd).bCheckBody;
                    txtk.lasee.MaximumSize = new Size(this.Size.Width - 15, 10000);
                    this.Resize += new EventHandler(delegate { txtk.lasee.MaximumSize = new Size(txtk.Size.Width - 15, 10000); });
                    this.inWorkPage.Controls.Add(txtk);
                }
            }
            SetTextButtonDateTime();
        }

        public void SetTextButtonDateTime() {
            this.DateTimeButtom.Text = "[ " + this.ThisMeessageDateTime.Day + " " + Months.Monthes[this.ThisMeessageDateTime.Month, 1] + " " + this.ThisMeessageDateTime.Year + " года " + this.ThisMeessageDateTime.Hour + ":" + this.ThisMeessageDateTime.Minute + ":" + this.ThisMeessageDateTime.Second + " ]";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            TextBody[] txtxttx = new TextBody[this.inWorkPage.Controls.Count];
            int t = 0;
            foreach (Control cntr in this.inWorkPage.Controls)
            {
                if (cntr.GetType().ToString() == "KME.check_kusock")
                {
                    txtxttx[t] = new CheckBody(((check_kusock)cntr).textBox1.Text, ((check_kusock)cntr).chchchcl.Checked);
                    t++;
                }
                if (cntr.GetType().ToString() == "KME.Text_kusock")
                {
                    txtxttx[t] = new TextBody(((Text_kusock)cntr).textBox1.Text);
                    t++;
                }
            }
            if (localMessage!=null)
            {
                localMessage.SetNewMessage(this.Zagalovok.Text, this.Glavnaya.Checked, this.ThisMeessageDateTime, txtxttx);
                MessageControl.msContr.RedactMessage(localMessage, oldID);
            }
            else
            {
                localMessage = new Message(this.Zagalovok.Text, this.Glavnaya.Checked, this.ThisMeessageDateTime, txtxttx);
                MessageControl.msContr.AdddMessade(localMessage);
            }
            this.Close();
        }

        public void AddChek_Click(object sender, EventArgs e)
        {
            check_kusock txtk = new check_kusock(this);
            txtk.Dock = DockStyle.Bottom;
            txtk.Margin = new System.Windows.Forms.Padding(5);
            txtk.AutoSize = true;
            txtk.lasee.MaximumSize = new Size(this.Size.Width - 15, 10000);
            this.Resize += new EventHandler(delegate { txtk.lasee.MaximumSize = new Size(txtk.Size.Width - 15, 10000); });
            this.inWorkPage.Controls.Add(txtk);
        }
        public void AddText_Click(object sender, EventArgs e)
        {
            Text_kusock txtk = new Text_kusock(this);
            txtk.Dock = DockStyle.Bottom;
            txtk.Margin = new System.Windows.Forms.Padding(5);
            txtk.AutoSize = true;
            txtk.lasee.MaximumSize = new Size(this.Size.Width, 10000);
            this.Resize += new EventHandler(delegate { txtk.lasee.MaximumSize = new Size(txtk.Size.Width, 10000); });
            this.inWorkPage.Controls.Add(txtk);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            ContextMenu ctx = new ContextMenu((Button)sender, this.inWorkPage, this);
            ctx.Show();
            this.FormClosed += new FormClosedEventHandler(delegate { ctx.Close(); });
        }

        private void DateTimeButtom_Click(object sender, EventArgs e)
        {
            DateTimeViev dtv = new DateTimeViev();
            dtv.Adr = this;
            dtv.NumHourh.Value = this.ThisMeessageDateTime.Hour;
            dtv.NumMinute.Value = this.ThisMeessageDateTime.Minute;
            dtv.NumSecunde.Value = this.ThisMeessageDateTime.Second;
            dtv.Calendar.TodayDate = new DateTime(Form1._YEARH, Form1._MONTH, Form1._DAY);
            dtv.Calendar.SelectionStart = dtv.Calendar.TodayDate;
            dtv.Calendar.SelectionEnd = dtv.Calendar.TodayDate;
            this.DateTimeButtom.Enabled = false;
            dtv.Show();
        }
    }
}
