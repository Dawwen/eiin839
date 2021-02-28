using System;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace WebServer
{
    class MyMethods
    {
        // Usual C# method
        public static string mymethod(string param1, string param2)
        {
            return ("<HTML><BODY>Using method: Hello " + param1 + " et " + param2 + "</BODY></HTML>");
        }

        // CGI calling another executable
        public static string mymethodCGI(string arg1, string arg2) {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\smx20\Documents\GitHub\MySOC\TD2\WebDynamic\WebServer\ExecutableCGI\bin\Debug\netcoreapp3.1\ExecutableCGI.exe"; // Specify exe name.
            start.Arguments = arg1 + " " + arg2;// "Argument1 Argument2"; // Specify arguments.
            start.UseShellExecute = false; 
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        // Using reflection
        public static string mymethodReflection(string methodName, string arg1, string arg2)
        {
            methodName = methodName.Remove(methodName.Length - 1, 1);
            Console.WriteLine(methodName);
            Type type = typeof(ReflectionClass);
            MethodInfo method = type.GetMethod(methodName);
            ReflectionClass c = new ReflectionClass();
            string[] list = { arg1, arg2 };
            string result = (string)method.Invoke(c, list);
            return result;
        }
    }
}
