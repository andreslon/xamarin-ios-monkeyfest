using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MonkeyFest
{
    public class FirebaseRepository
    {

        public HttpClient client = new HttpClient();
        public FirebaseRepository()
        {
        }

        async public Task<List<Car>> GetCarsAsync()
        {
            List<Car> cars = null;
            var path = "https://monkeyfest-7dbe6.firebaseio.com/cars.json?auth=rLwK8p6FcPq6eHXDfbwguhGniM2NjB6PF832kIhW";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync(); 
                var dic = JsonConvert.DeserializeObject<Dictionary<string, Car>>(json);
                cars = dic.Select(x => x.Value).ToList();
            }
            return cars;
        }
    }

    public class Car
    {
        public string brand { get; set; }
        public bool isLimitedEdition { get; set; }
        public string model { get; set; }
        public int year { get; set; }
    }
}
