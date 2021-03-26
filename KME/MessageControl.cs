using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace KME
{
    class MessageControl
    {
        static public MessageControl msContr;
        static public void SetControl() { msContr = new MessageControl(); }
        public List<Message> messages = new List<Message>();
        public Panel ListStrings;
        public string Address = "C://ABCGames/Dnevnik.abcplr";
        
        public void sTextTest() {
            TextBody[] ss = {new TextBody("111"), new CheckBody("33",true)};
            messages.Add(new Message("YRA", true, new DateTime(2000, 12, 3, 23, 56, 23), ss));
            TextBody[] dd = { new TextBody("222"), new CheckBody("44", false), new CheckBody("77", false), new CheckBody("24334", false) };
            messages.Add(new Message("QWERYYY", false, new DateTime(2001, 10, 23, 4, 34, 22), dd));
            SpawnAllMessages();
            SaveFile();
        }

        public void SpawnAllMessages() {
            ListStrings.Controls.Clear();
            foreach (Message ms in this.messages) {
                MessageView ms_V = new MessageView(this.messages.IndexOf(ms));
                ms_V.Dock = DockStyle.Top;
                ListStrings.Controls.Add(ms_V);
            }
        }
        public void FilterToDate(DateTime filter) {
            foreach (MessageView ms in ListStrings.Controls) {
                ms.Visible = (ms.thisDateTime.Year == filter.Year && ms.thisDateTime.Month == filter.Month && ms.thisDateTime.Day == filter.Day);
            }
        }
        public void ShowAllMessage() {
            foreach (MessageView ms in ListStrings.Controls) {
                ms.Visible = true;
            }
        }
        public void ResizeAllText() {
            bool lastV;
            foreach (MessageView ms in ListStrings.Controls) {
                lastV = ms.Visible;
                ms.Visible = true;
                ms.SetText(ListStrings.Controls.IndexOf(ms));
                ms.Visible = lastV;
            }
        }
        public void AdddMessade(Message mess) {
            this.messages.Add(mess);
            MessageView ms_V = new MessageView(this.messages.IndexOf(mess));
            ms_V.Dock = DockStyle.Top;
            ListStrings.Controls.Add(ms_V);
        }
        public void RedactMessage(Message ind, int oldID) {
            SpawnAllMessages(); ResizeAllText();
        }

        XElement plr, dan, tva;
        List<XAttribute> Attributs = new List<XAttribute>(), Textse = new List<XAttribute>();
        List<XElement> messagesxml, textxml;
        List<TextBody> txb = new List<TextBody>();
        DateTime vremya;

        public void OpenFile() {
            if(File.Exists(this.Address)){
                dan = XDocument.Parse(File.ReadAllText(Address)).Element("Player");
                messagesxml = dan.Elements("message").ToList();
                foreach (XElement e in messagesxml)
                {
                    txb.Clear();
                    textxml = e.Elements("texts").ToList();
                    foreach (XElement t in textxml) {
                        if (t.Attribute("checket").Value.ToString() == "-1")
                        {
                            txb.Add(new TextBody(t.Attribute("TextBody").Value.ToString()));
                        }
                        else
                        {
                            txb.Add(new CheckBody(t.Attribute("TextBody").Value.ToString(), (t.Attribute("checket").Value.ToString() == "1")));
                        }
                    }
                    vremya = new DateTime(int.Parse(e.Attribute("DaTi").Value.ToString().Split('|')[0]),
                        int.Parse(e.Attribute("DaTi").Value.ToString().Split('|')[1]),
                        int.Parse(e.Attribute("DaTi").Value.ToString().Split('|')[2]),
                        int.Parse(e.Attribute("DaTi").Value.ToString().Split('|')[3]),
                        int.Parse(e.Attribute("DaTi").Value.ToString().Split('|')[4]),
                        int.Parse(e.Attribute("DaTi").Value.ToString().Split('|')[5]));
                    this.messages.Add(new Message( e.Attribute("Zagalovok").Value.ToString(), (e.Attribute("Vajnoe").Value.ToString()=="1"), vremya, txb.ToArray() ));
                }
            }
            txb.Clear();
            SpawnAllMessages();
        }
        public void SaveFile() {
            plr = new XElement("Player");
            if (!Directory.Exists("C://ABCGames")) { Directory.CreateDirectory("C://ABCGames"); }
            foreach (Message ms in this.messages) {
                Attributs.Add(new XAttribute("Zagalovok", ms.TittleName));
                Attributs.Add(new XAttribute("Vajnoe", (ms.MainMessage)?"1":"0"));
                Attributs.Add(new XAttribute("DaTi", ms.TimeDate.Year + "|" + ms.TimeDate.Month + "|" + ms.TimeDate.Day + "|" + ms.TimeDate.Hour + "|" + ms.TimeDate.Minute + "|" + ms.TimeDate.Second));
                dan = new XElement("message", Attributs); 
                foreach (TextBody tb in ms.Textes) {
                    if (tb.GetType().ToString() == "KME.TextBody") {
                        Textse.Add(new XAttribute("checket", "-1"));
                    } else {
                        Textse.Add(new XAttribute("checket", (((CheckBody)tb).bCheckBody) ? "1" : "0"));
                    }
                    Textse.Add(new XAttribute("TextBody", tb.sTextBody));
                    tva = new XElement("texts", "--", Textse);
                    dan.Add(tva); Textse.Clear();
                }
                plr.Add(dan); Attributs.Clear();
            }
            File.WriteAllText(this.Address, plr.ToString());
        }
    }
}
