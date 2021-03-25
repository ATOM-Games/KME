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
    public partial class MessageView : UserControl
    {
        public DateTime thisDateTime;
        public MessageView() { InitializeComponent(); }
        int ID_text;
        Message sss;
        public MessageView(int mess)
        {
            InitializeComponent();
            this.ID_text = mess;
            this.sss = MessageControl.msContr.messages[mess];
            SetText(mess);
        }

        public void SetText(int mess) {
            this.thisDateTime = MessageControl.msContr.messages[mess].TimeDate;
            this.Zagalovok.Text = MessageControl.msContr.messages[mess].Zagalovok;
            this.Vremya.Text = "[" + this.thisDateTime.Hour + " : " + this.thisDateTime.Minute + " : " + this.thisDateTime.Second + "]";
            TImeMeess.SetToolTip(this.Vremya, "[ " + this.thisDateTime.Day + " " + Months.Monthes[this.thisDateTime.Month, 1] + " " + this.thisDateTime.Year + " года " + this.thisDateTime.Hour + " : " + this.thisDateTime.Minute + " : " + this.thisDateTime.Second + " ]");
            if (MessageControl.msContr.messages[mess].Vajnoe) { this.Zagalovok.BackColor = Color.Red; }

            this.ContentMessage.Controls.Clear();
            if (this.Width > 500) {
                this.AutoSize = true;
                this.ContentMessage.AutoSize = true;
                if (MessageControl.msContr.messages[ID_text].Textes.Length > 0) {
                    foreach (TextBody tb in MessageControl.msContr.messages[ID_text].Textes) {
                        if (tb.GetType().ToString() == "KME.CheckBody") {
                            CheckBox cb = new CheckBox();
                            cb.Dock = DockStyle.Bottom;
                            cb.Checked = ((CheckBody)tb).bCheckBody;
                            cb.CheckedChanged += new EventHandler(delegate(object s, EventArgs e) { ((CheckBody)tb).bCheckBody = ((CheckBox)s).Checked; });
                            cb.Text = tb.sTextBody;
                            this.ContentMessage.Controls.Add(cb);
                        } else {
                            Label lb = new Label();
                            lb.Dock = DockStyle.Bottom;
                            lb.AutoSize = true;
                            lb.Text = tb.sTextBody;
                            this.ContentMessage.Controls.Add(lb);
                        }
                    }
                }
            } else {
                this.AutoSize = false;
                if (MessageControl.msContr.messages[ID_text].Textes.Length > 0) {
                    Label lb = new Label();
                    lb.Dock = DockStyle.Fill;
                    lb.Text = MessageControl.msContr.messages[ID_text].Textes[0].sTextBody;
                    this.ContentMessage.Controls.Add(lb);
                } else {
                    //this.MiniLabel.Text = "";
                }
            }
        }

        private void Redact_Click(object sender, EventArgs e)
        {
            AddRedact woks = new AddRedact(ID_text);
            woks.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            //df.Show();
            this.Delete.Enabled = false;
            df.FormClosed += new FormClosedEventHandler(delegate { this.Delete.Enabled = true; });
            if (df.ShowDialog() == DialogResult.OK)
            {
                df.Close();
                MessageControl.msContr.Spisok.Controls.Remove(this);
                MessageControl.msContr.messages.Remove(sss);
            }
        }
    }
}
