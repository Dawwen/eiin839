using System;

namespace ExecutableCGI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine("<HTML><BODY>Using CGI: Hello " + args[0] + " et " + args[1] + "</BODY></HTML>");
            else
                Console.WriteLine("<HTML><BODY>Using CGI: Not enough or too much argument.</BODY></HTML>");
        }
    }
}
