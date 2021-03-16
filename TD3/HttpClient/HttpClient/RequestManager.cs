using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HttpClientJson
{
    class RequestManager
    {
        private HttpClient client;
        public RequestManager()
        {
            client = new HttpClient();

        }
        public void RequestFindContract()
        {
            var request = client.GetStringAsync("https://api.jcdecaux.com/vls/v3/contracts?apiKey=7136a48f462e21620c41d9aa2db665ea3bf47fb5");
            request.Wait();
            Contract[] contracts = System.Text.Json.JsonSerializer.Deserialize<Contract[]>(request.Result);

            foreach (Contract item in contracts)
            {
                Console.WriteLine(item);
            }
        }
        public LinkedList<Station> RequestFindStationByContract(string name)
        {
            var request = client.GetStringAsync("https://api.jcdecaux.com/vls/v1/stations?&apiKey=7136a48f462e21620c41d9aa2db665ea3bf47fb5");
            request.Wait();
            //Console.WriteLine(request.Result);
            Station[] stations = System.Text.Json.JsonSerializer.Deserialize<Station[]>(request.Result);
            LinkedList<Station> result = new LinkedList<Station>();

            foreach (var item in stations)
            {
                if (name == null)
                    result.AddLast(item);
                else if (name.Equals(item.name))
                    result.AddLast(item);
            }
            return result;
        }
    }
}
