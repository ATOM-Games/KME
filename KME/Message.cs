using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KME
{
    class Message
    {
        public string Zagalovok;
        public bool Vajnoe;
        public DateTime TimeDate;
        public TextBody[] Textes;

        public Message(string zag, bool vajn, DateTime dt, TextBody[] tes) {
            this.Zagalovok = zag;
            this.Vajnoe = vajn;
            this.TimeDate = dt;
            this.Textes = tes;
        }
        public void SetNewMessage(string zag, bool vajn, DateTime dt, TextBody[] tes)
        {
            this.Zagalovok = zag;
            this.Vajnoe = vajn;
            this.TimeDate = dt;
            this.Textes = tes;
        }
    }
}
