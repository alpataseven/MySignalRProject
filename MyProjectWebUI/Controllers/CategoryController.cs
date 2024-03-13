using Microsoft.AspNetCore.Mvc;
using MyProjectWebUI.Dtos.CategoryDtos;
using Newtonsoft.Json;

namespace MyProjectWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

		public CategoryController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //istemci oluşturduk
            var responseMessage = await client.GetAsync("https://localhost:7275/api/Category"); //api adresini yazdığımız kod
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
