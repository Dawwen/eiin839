using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BasicHTTPlistener
{
    class Header
    {
        System.Collections.Specialized.NameValueCollection head;
        public Header(System.Collections.Specialized.NameValueCollection headers)
        {
            head = headers;
        }

        public string getHeader()
        {
            return head.ToString();
        }
    }
}
