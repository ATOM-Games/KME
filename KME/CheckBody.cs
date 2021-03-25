using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KME
{
    class CheckBody : TextBody
    {
        public bool bCheckBody;
        public CheckBody(string txt, bool vk)
        {
            sTextBody = txt;
            this.bCheckBody = vk;
        }
    }
}
