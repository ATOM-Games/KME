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
            this.TittleName.Text = MessageControl.msContr.messages[indes].TittleName;
            this.MainText.Checked = MessageControl.msContr.messages[indes].MainMessage;
            this.ThisMeessageDateTime = MessageControl.msContr.messages[indes].TimeDate;
            foreach (TextBody txtbd in MessageControl.msContr.messages[indes].Textes)
            {
                if (txtbd.GetType().ToString() == "KME.TextBody")
                {
                    Text_kusock txt = new Text_kusock(this);
                    txt.Dock = DockStyle.Bottom;
                    txt.Margin = new System.Windows.Forms.Padding(5);
                    txt.AutoSize = true;
                    txt.textBox1.Text = txtbd.sTextBody;
                    txt.LabelLocale.MaximumSize = new Size(this.Size.Width, 10000);
                    this.Resize += new EventHandler(delegate { txt.LabelLocale.MaximumSize = new Size(txt.Size.Width, 10000); });
                    this.inWorkPage.Controls.Add(txt);
                }
                if (txtbd.GetType().ToString() == "KME.CheckBody")
                {
                    check_kusock ch_txt = new check_kusock(this);
                    ch_txt.Dock = DockStyle.Bottom;
                    ch_txt.Margin = new System.Windows.Forms.Padding(5);
                    ch_txt.AutoSize = true;
                    ch_txt.textBox1.Text = ((CheckBody)txtbd).sTextBody;
                    ch_txt.check_.Checked = ((CheckBody)txtbd).bCheckBody;
                    ch_txt.LabelLocal.MaximumSize = new Size(this.Size.Width - 15, 10000);
                    this.Resize += new EventHandler(delegate { ch_txt.LabelLocal.MaximumSize = new Size(ch_txt.Size.Width - 15, 10000); });
                    this.inWorkPage.Controls.Add(ch_txt);
                }
            }
            SetTextButtonDateTime();
        }

        public void SetTextButtonDateTime() {
            this.DateTimeButtom.Text = "[ " + this.ThisMeessageDateTime.Day + " " + Months.Monthes[this.ThisMeessageDateTime.Month, 1] + " " + this.ThisMeessageDateTime.Year + " года " + this.ThisMeessageDateTime.Hour + ":" + this.ThisMeessageDateTime.Minute + ":" + this.ThisMeessageDateTime.Second + " ]";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            TextBody[] bd_txt = new TextBody[this.inWorkPage.Controls.Count];
            int t = 0;
            foreach (Control cntr in this.inWorkPage.Controls)
            {
                if (cntr.GetType().ToString() == "KME.check_kusock")
                {
                    bd_txt[t] = new CheckBody(((check_kusock)cntr).textBox1.Text, ((check_kusock)cntr).check_.Checked);
                    t++;
                }
                if (cntr.GetType().ToString() == "KME.Text_kusock")
                {
                    bd_txt[t] = new TextBody(((Text_kusock)cntr).textBox1.Text);
                    t++;
                }
            }
            if (localMessage!=null)
            {
                localMessage.SetNewMessage(this.TittleName.Text, this.MainText.Checked, this.ThisMeessageDateTime, bd_txt);
                MessageControl.msContr.RedactMessage(localMessage, oldID);
            }
            else
            {
                localMessage = new Message(this.TittleName.Text, this.MainText.Checked, this.ThisMeessageDateTime, bd_txt);
                MessageControl.msContr.AdddMessade(localMessage);
            }
            this.Close();
        }

        public void AddChek_Click(object sender, EventArgs e)
        {
            check_kusock ch_txt = new check_kusock(this);
            ch_txt.Dock = DockStyle.Bottom;
            ch_txt.Margin = new System.Windows.Forms.Padding(5);
            ch_txt.AutoSize = true;
            ch_txt.LabelLocal.MaximumSize = new Size(this.Size.Width - 15, 10000);
            this.Resize += new EventHandler(delegate { ch_txt.LabelLocal.MaximumSize = new Size(ch_txt.Size.Width - 15, 10000); });
            this.inWorkPage.Controls.Add(ch_txt);
        }
        public void AddText_Click(object sender, EventArgs e)
        {
            Text_kusock txt = new Text_kusock(this);
            txt.Dock = DockStyle.Bottom;
            txt.Margin = new System.Windows.Forms.Padding(5);
            txt.AutoSize = true;
            txt.LabelLocale.MaximumSize = new Size(this.Size.Width, 10000);
            this.Resize += new EventHandler(delegate { txt.LabelLocale.MaximumSize = new Size(txt.Size.Width, 10000); });
            this.inWorkPage.Controls.Add(txt);
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
