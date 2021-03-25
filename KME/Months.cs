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
    public partial class Months : UserControl
    {
        static public int[] startX = { 300, 0, 50, 100, 150, 200, 250 };
        static public int[] startId = { 6, 0, 1, 2, 3, 4, 5 };
        static public string[,] Monthes = { {"Сделано командой самых лучших!", "..."},
                                      {"Январь", "Января"},
                                      {"Февраль", "Февраля"},
                                      {"Март", "Марта"},
                                      {"Апрель", "Апреля"},
                                      {"Май", "Мая"},
                                      {"Июнь", "Июня"},
                                      {"Июль", "Июля"},
                                      {"Август", "Августа"},
                                      {"Сентябрь", "Сентября"},
                                      {"Октябрь", "Октября"},
                                      {"Ноябрь", "Ноября"},
                                      {"Декабрь", "Декабря"} };
        public int _MONTH = -1, _YEARH = -1;
        DateTime dt;
        public Form1 Thisa;
        public Months(Form1 fm1)
        {
            InitializeComponent(fm1);
        }
        int Xs=0, day=-1, tl=0;
        public void SetMonthAndYearh(int yearh, int month)
        {
            this._MONTH = month; this._YEARH = yearh;
            this.Yearh_and_month.Text = Months.Monthes[month,0] + " " + yearh;
            dt = new DateTime(_YEARH, _MONTH, 1);
            this.Xs = Months.startId[(int)dt.DayOfWeek];
            tl = 1;
            for (int y = 0; y < 6; y++) {
                for (int x = 0; x < 7; x++) {
                    if (y == 0) {
                        if(x < this.Xs){
                            LocalDay[y, x].SetDay(" " + (DateTime.DaysInMonth( ((_MONTH != 1) ? _YEARH : _YEARH-1), ((_MONTH != 1) ? _MONTH - 1: 12) ) - this.Xs + tl) + "");
                            tl++;
                        }else{
                            if(day<0) day=1;
                            LocalDay[y, x].SetDay(_YEARH, _MONTH, day);
                            day++;
                            tl = 1;
                        }
                    } else {
                        if(day > 0){
                            LocalDay[y, x].SetDay(_YEARH, _MONTH, day);
                            day++;
                            tl = 1;
                            if(day > DateTime.DaysInMonth(_YEARH, _MONTH)) day=-1;
                        }else{
                            LocalDay[y, x].SetDay(" "+tl);
                            tl++;
                        }
                    }
                    
                }
            }
        }
    }
}
