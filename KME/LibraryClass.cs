using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace KME
{
    class LibraryClass
    {
        static Color yerhcolor, monthcolor, daycolor;
        public static Color GetColorYear(int yearh) {
            yerhcolor = Color.SkyBlue;
            foreach (Message ms in MessageControl.msContr.messages) {
                if (ms.TimeDate.Year == yearh) {
                    if (ms.Vajnoe) {
                        if (yerhcolor != Color.Red) { yerhcolor = Color.Red; }
                    } else {
                        if (yerhcolor != Color.Red) { yerhcolor = Color.Blue; }
                    }
                }
            }
            return yerhcolor;
        }

        public static Color GetColorMonth(int month) {
            monthcolor = Color.SkyBlue;
            foreach (Message ms in MessageControl.msContr.messages) {
                if (ms.TimeDate.Year == Form1._YEARH && ms.TimeDate.Month == month+1) {
                    if (ms.Vajnoe) {
                        if (monthcolor != Color.Red) { monthcolor = Color.Red; }
                    } else {
                        if (monthcolor != Color.Red) { monthcolor = Color.Blue; }
                    }
                }
            }
            return monthcolor;
        }

        public static Color GetColorDay(string day) {
            daycolor = Color.SkyBlue;
            if (day.ToCharArray()[0] != ' ') {
                if (Form1._YEARH == DateTime.Now.Year && Form1._MONTH == DateTime.Now.Month && int.Parse(day) == DateTime.Now.Day) {
                    daycolor = Color.Azure;
                } else {
                    foreach (Message ms in MessageControl.msContr.messages) {
                        if (Form1._YEARH == ms.TimeDate.Year && Form1._MONTH == ms.TimeDate.Month && int.Parse(day) == ms.TimeDate.Day) {
                            if (ms.Vajnoe) {
                                if (daycolor != Color.Red) { daycolor = Color.Red; }
                            } else {
                                if (daycolor != Color.Red) { daycolor = Color.Blue; }
                            }
                        }
                    }
                }
            }
            return daycolor;
        }
    }
}
