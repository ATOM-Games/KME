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
    public partial class MessageList : UserControl
    {
        public MessageList()
        {
            InitializeComponent();
            //Rezise();
        }
        public int _selectYearh, _selectMonth, _selectDay;
        public void SetZagalovok(int _yer, int _mont, int _day) {
            this.TittleName.Text = _day + " " + Months.Monthes[_mont, 1] + " " + _yer + " года";
            this._selectYearh = _yer; this._selectMonth = _mont; this._selectDay = _day;
            MessageControl.msContr.FilterToDate(new DateTime(_selectYearh, _selectMonth, _selectDay));
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (this.findTextBox.Text.Length > 0)
            {
                foreach (MessageView messages in MessageControl.msContr.ListStrings.Controls)
                {
                    messages.Visible = (messages.TittleName.Text.Contains(this.findTextBox.Text));
                }
            }
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            foreach(MessageView messages in MessageControl.msContr.ListStrings.Controls){
                messages.Visible = (messages.TittleName.BackColor == Color.Red && messages.thisDateTime < DateTime.Now);
            }
        }

        public void Rezise() {
            if (this.Width > 333) {
                this.MainMenuPanel.Height = 30;
                this.ArchiveButton.Location = new Point(245, 3);
                this.AllMessages.Location = new Point(326, 3);
                this.AddNotMe.Location = new Point(427, 3);
            } else {
                this.MainMenuPanel.Height = 50;
                this.ArchiveButton.Location = new Point(3,25);
                this.AllMessages.Location = new Point(84, 25);
                this.AddNotMe.Location = new Point(185, 25);
            }
            MessageControl.msContr.ResizeAllText();
        }

        public void Update() {
            
        }

        private void AllMessages_Click(object sender, EventArgs e) {
            MessageControl.msContr.ShowAllMessage();
        }

        public void PoleLista_MouseDoubleClick(object sender, EventArgs ee) {
            AddRedact woks = new AddRedact();
            woks.Show();
        }

        private void AdNeMe_Click(object sender, EventArgs e)
        {
            AddRedact woks = new AddRedact();
            woks.Show();
        }
    }
}
