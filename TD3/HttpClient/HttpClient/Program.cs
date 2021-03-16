using System;
using System.Net.Http;
using HttpClientJson.CalculatorWebService;
namespace HttpClientJson
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestManager manager = new RequestManager();
            Console.WriteLine(args.Length);
            
            switch (args.Length)
            {
                case 0:
                    manager.RequestFindContract();
                    break;
                case 1:
                    manager.RequestFindStationByContract(args[0]);
                    break;
                default:
                    break;
            }
        }
    }
}
