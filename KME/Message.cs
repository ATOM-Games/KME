using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KME
{
    class Message
    {
        public string TittleName;
        public bool MainMessage;
        public DateTime TimeDate;
        public TextBody[] Textes;

        public Message(string TtlName, bool MainMess, DateTime dt, TextBody[] tes) {
            this.TittleName = TtlName;
            this.MainMessage = MainMess;
            this.TimeDate = dt;
            this.Textes = tes;
        }
        public void SetNewMessage(string TtlName, bool MainMess, DateTime dt, TextBody[] tes)
        {
            this.TittleName = TtlName;
            this.MainMessage = MainMess;
            this.TimeDate = dt;
            this.Textes = tes;
        }
    }
}
