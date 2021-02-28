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
            Console.WriteLine(head.ToString());
            Console.WriteLine(head.Keys.ToString());
            Console.WriteLine(HttpRequestHeader.AcceptEncoding.ToString());
            string output = "<HTML><BODY>\n";

            output += "<H1>The request was received.</H1>\n";

            output += "The connexionType is: "  + head.Get(HttpRequestHeader.Connection.ToString()) + "<br>\n";
            output += "The host is: " + head.Get(HttpRequestHeader.Host.ToString()) + "<br>\n";

            /* Should use these line but postmann send User-Agent and not UserAgent as it is in the HttpRequestHeader same for Accept-Encoding and AcceptEncoding
            output += "The application used is: " + head.Get(HttpRequestHeader.UserAgent.ToString()) + "<br>\n";
            output += "It accept these kind of encoding: " + head.Get(HttpRequestHeader.AcceptEncoding.ToString()) + "<br>\n"; */
            
            output += "It accept these kind of encoding: " + head.Get("Accept-Encoding") + "<br>\n";
            output += "The application used is: " + head.Get("User-Agent") + "<br>\n";
            
            output += "</BODY></HTML>";
            return output;
        }
    }
}
