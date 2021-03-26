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
    public partial class Form1 : Form
    {
        bool IsMaximized = false;
        Point OldLocation = new Point(0, 0);
        Size OldSize = new Size(800, 500);
        //---

        bool thisdvig = false;
        //---
        static public int _MONTH = 5, _YEARH = 2020, _DAY=-1;
        //---
        public Form1()
        {
            InitializeComponent();
            Form1._MONTH = DateTime.Now.Month;
            Form1._YEARH = DateTime.Now.Year;
            Form1._DAY = DateTime.Now.Day;
            MessageControl.msContr.ListStrings = this.MessList.FieldList;
            this.MessList.Application = this;
            MessageControl.msContr.OpenFile();//.TextTest();
            //MessageControl.msContr.sTextTest();
            this.LocalMonth.This_at = this;
            this.LocalMonth.SetMonthAndYearh(Form1._YEARH, Form1._MONTH);
            this.MessList.SetZagalovok(Form1._YEARH, Form1._MONTH, DateTime.Now.Day);
            
            //---
            this.Local_timer.Start();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            MessageControl.msContr.SaveFile();
            Application.Exit();
        }

        private void Razs_button_Click(object sender, EventArgs e)
        {
            this.ControlBox = !this.ControlBox;
            if (!IsMaximized)
            {
                OldLocation = new Point(Location.X, Location.Y);
                var rectangle = Screen.FromControl(this).Bounds;
                ClientSize = Screen.PrimaryScreen.WorkingArea.Size;
                Location = new Point(0, 0);
            }
            else
            {
                ClientSize = OldSize;
                Location = OldLocation;
            }
            this.MessList.Width = this.Width - 550;
            this.MessList.Rezise();
            IsMaximized = !IsMaximized;
        }

        private void Svern_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.TopMost = false;
        }

        private void TittleName_Click(object sender, EventArgs e)
        {
            if (thisdvig == true) this.Location = new Point((Cursor.Position.X - this.Size.Width / 2), (Cursor.Position.Y - 10));
        }
        private void Zagolovok_down(object sender, MouseEventArgs e) { thisdvig = (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left); }
        private void Zagolovok_up(object sender, MouseEventArgs e) { thisdvig = false; }

        private void _monthes__Click(object sender, EventArgs e)
        {
            Form1._MONTH = ((Button)sender).TabIndex;
            this.LocalMonth.SetMonthAndYearh(_YEARH, _MONTH);
        }

        private void _yeahrs__Click(object sender, EventArgs e)
        {
            Form1._YEARH = ((Button)sender).TabIndex;
            this.LocalMonth.SetMonthAndYearh(_YEARH, _MONTH);
        }

        private void YearhButton_Click(object sender, EventArgs e)
        {
            if (this.YearhButton.Text == "<<<              Года") {
                this.YearhButton.Text = "Месяцы              >>>";
                this.YearhButton.TextAlign = ContentAlignment.MiddleRight;
                this.PanelOfMonth.Visible = false;
                this.PanelOfYearh.Visible = true;
            } else {
                this.YearhButton.Text = "<<<              Года";
                this.YearhButton.TextAlign = ContentAlignment.MiddleLeft;
                this.PanelOfMonth.Visible = true;
                this.PanelOfYearh.Visible = false;
                this.LocalMonth.SetMonthAndYearh(_YEARH, _MONTH);
            }
        }
        private void NumericYearh_ChangeUICues(object sender, EventArgs e) {
            Form1._YEARH = (int)this.NumericYearh.Value;
            this.LocalMonth.SetMonthAndYearh((int)this.NumericYearh.Value, _MONTH);
        }

        public void SelectDay(int _YEARH, int _MONTH, int _DAY) {
            this.MessList.SetZagalovok(_YEARH, _MONTH, _DAY);
        }

        public void Local_timer_Tick(object sender, EventArgs e) {
            this.LocalMonth.Update();
            //----forYearh
            for (int y = 0; y < 200; y++) {
                this._yeahrs_[y].BackColor = LibraryClass.GetColorYear((int)(y + this.NumericYearh.Minimum));
            }
            for (int m = 0; m < 12; m++) {
                this._monthes_[m].BackColor = LibraryClass.GetColorMonth(m);
            }
            for (int y = 0; y < 6; y++) {
                for (int x = 0; x < 7; x++) {
                    this.LocalMonth.LocalDay[y, x].BackColor = LibraryClass.GetColorDay(this.LocalMonth.LocalDay[y, x].Texts.Text);
                }
            }
            //----уведомления
            foreach (Message mess in MessageControl.msContr.messages) {
                if (mess.MainMessage) {
                    if (TwoDay(mess.TimeDate))
                    {
                        this.MessList.PushActives.Visible = true;
                        this.MessList.PushActives.ShowBalloonTip(5000, "КME осталось 48 часов",
                            "До события \""+mess.TittleName+"\" осталось 48 часов",
                            ToolTipIcon.Warning);
                        this.MessList.PushActives.BalloonTipTitle = "КME осталось 48 часов";
                    }
                    if (OneDay(mess.TimeDate))
                    {
                        this.MessList.PushActives.Visible = true;
                        this.MessList.PushActives.ShowBalloonTip(5000, "КME осталось 24 часа",
                            "До события \"" + mess.TittleName + "\" осталось 24 часа",
                            ToolTipIcon.Warning);
                        this.MessList.PushActives.BalloonTipTitle = "КME осталось 24 часа";
                    }
                    if (OneHourh(mess.TimeDate))
                    {
                        //MessageBox.Show("s");
                        this.MessList.PushActives.Visible = true;
                        this.MessList.PushActives.ShowBalloonTip(5000, "КME остался 1 час",
                            "До события \"" + mess.TittleName + "\" остался 1 час",
                            ToolTipIcon.Warning);
                        this.MessList.PushActives.BalloonTipTitle = "КME остался 1 час";
                    }
                }
            }
        }


        public bool TwoDay(DateTime dt) {
            return (dt.Year == DateTime.Now.Year && dt.Month == DateTime.Now.Month && dt.Day - DateTime.Now.Day <= 2
                && dt.Hour == DateTime.Now.Hour && dt.Minute == DateTime.Now.Minute  && dt.Second == DateTime.Now.Second);
        }
        public bool OneDay(DateTime dt) {
            return (dt.Year == DateTime.Now.Year && dt.Month == DateTime.Now.Month && dt.Day - DateTime.Now.Day <= 1
                && dt.Hour == DateTime.Now.Hour && dt.Minute == DateTime.Now.Minute  && dt.Second == DateTime.Now.Second);
        }
        public bool OneHourh(DateTime dt) {
            return (dt.Year == DateTime.Now.Year && dt.Month == DateTime.Now.Month && dt.Day == DateTime.Now.Day
                && dt.Hour - DateTime.Now.Hour <= 1 && dt.Minute == DateTime.Now.Minute && dt.Second == DateTime.Now.Second);
        }
        public bool EqualsNow(DateTime dt) {
            return (dt.Year == DateTime.Now.Year && dt.Month == DateTime.Now.Month && dt.Day == DateTime.Now.Day
                && dt.Hour == DateTime.Now.Hour && dt.Minute == DateTime.Now.Minute && dt.Second == DateTime.Now.Second);
        }


    }
}
