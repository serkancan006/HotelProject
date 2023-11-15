using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class ResultInstagramFollowerDto
    {
        public int followers { get; set; }
        public int following { get; set; }
    }

    public class ResultTwitterFollowersDto
    {
        public Data data { get; set; }

        public class Data
        {
            public User_Info user_info { get; set; }
        }

        public class User_Info
        {
            public int followers_count { get; set; }
            public int friends_count { get; set; }
        }
    }

    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/murattycedag"),
                Headers =
                {
                    { "X-RapidAPI-Key", "accdf7df09msh7df05ef71c3902bp1ceb4fjsn9bd170c07610" },
                    { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                var body = await response.Content.ReadAsStringAsync();

                ResultInstagramFollowerDto resultInstagramFollowerDto = JsonConvert.DeserializeObject<ResultInstagramFollowerDto>(body);
                ViewBag.v1 = resultInstagramFollowerDto;
            }
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "accdf7df09msh7df05ef71c3902bp1ceb4fjsn9bd170c07610" },
                        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
                    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                var body2 = await response2.Content.ReadAsStringAsync();

                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v2 = resultTwitterFollowersDto.data.user_info;
            }

            return View();
        }
    }
}
