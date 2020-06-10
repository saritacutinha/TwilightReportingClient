using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwilightReportingClient.Models;

namespace TwilightReportingClient
{
    public class SunriseSunsetApplicationService
    {
        public async Task<SunriseSunsetModel> GetData(decimal latitude, decimal longitude)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string uri = "https://api.sunrise-sunset.org/json?" + "lat=" + latitude + "&lng=" +longitude+"&date=today";
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        SunriseSunsetApiResultModel result = await response.Content.ReadAsAsync<SunriseSunsetApiResultModel>();
                        return result.Results;
                    }
                    throw new Exception(response.ReasonPhrase);
                }


            }
        }

       
    }
}
      
           


           