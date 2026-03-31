using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TheVeryLastDayBeforeBreak
{
    public class ServerConnection
    {
        private HttpClient client = new HttpClient();
        public ServerConnection()
        {
            client.BaseAddress = new Uri("http://127.0.0.1:3000");
        }
        public ServerConnection(Uri url)
        {
            client.BaseAddress = url;
        }
        public ServerConnection(string url)
        {
            client.BaseAddress = new Uri(url);
        }

        public async Task<ServerResponse> PostWeatherType(string name,double intensity,string description)
        {                                                  
            try                                           
            {
                WeatherType jsondata = new(name,intensity,description);
                string jsonstring = JsonSerializer.Serialize(jsondata);
                StringContent ToSend = new(jsonstring,Encoding.UTF8,"Application/JSON");
                HttpResponseMessage response = await client.PostAsync("/weather",ToSend);
                response.EnsureSuccessStatusCode();
                string result = await response.Content.ReadAsStringAsync();
                ServerResponse data = JsonSerializer.Deserialize<ServerResponse>(result);
                return data;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<ServerResponse> PostFish(string typeoffish, double weight)
        {                                                  
            try                                           
            {
                Fish jsondata = new Fish() { typeOfFish = typeoffish, weight = weight};
                string jsonstring = JsonSerializer.Serialize(jsondata);
                StringContent ToSend = new(jsonstring,Encoding.UTF8,"Application/JSON");
                HttpResponseMessage response = await client.PostAsync("/fish",ToSend);
                response.EnsureSuccessStatusCode();
                string result = await response.Content.ReadAsStringAsync();
                ServerResponse data = JsonSerializer.Deserialize<ServerResponse>(result);
                return data;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<bool> DeleteFish(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("/fish/" + id);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<List<Fish>> GetFishes()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/fish");
                response.EnsureSuccessStatusCode();
                string dataString = await response.Content.ReadAsStringAsync();
                List<Fish> list = JsonSerializer.Deserialize<List<Fish>>(dataString);
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
