using AkademiPlusApiProject.RapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AkademiPlusApiProject.RapidApi.Controllers
{
    public class RapidApiImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
			List<RapidApiImdbViewModel> rapidApiImdbViewModels = new List<RapidApiImdbViewModel>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "630ce9cc86msh271c60cffe62d5ep1b514djsn0fe292593744" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				rapidApiImdbViewModels = JsonConvert.DeserializeObject<List<RapidApiImdbViewModel>>(body);
				return View(rapidApiImdbViewModels);
			}
        }
    }
}
