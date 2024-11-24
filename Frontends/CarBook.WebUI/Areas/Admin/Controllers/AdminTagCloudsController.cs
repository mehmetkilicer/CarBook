//using CarBook.Dto.TagCloudsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    //[Area("Admin")]
    //[Route("Admin/AdminTagClouds")]
    //public class AdminTagCloudsController : Controller
    //{
    //    private readonly IHttpClientFactory _httpClientFactory;
    //    public AdminTagCloudsController(IHttpClientFactory httpClientFactory)
    //    {
    //        _httpClientFactory = httpClientFactory;
    //    }

    //    [Route("Index")]
    //    public async Task<IActionResult> Index()
    //    {
    //        var client = _httpClientFactory.CreateClient();
    //        var responseMessage = await client.GetAsync("https://localhost:7054/api/TagCloudss");
    //        if (responseMessage.IsSuccessStatusCode)
    //        {
    //            var jsonData = await responseMessage.Content.ReadAsStringAsync();
    //            var values = JsonConvert.DeserializeObject<List<ResultTagCloudsDto>>(jsonData);
    //            return View(values);
    //        }
    //        return View();
    //    }

    //    [HttpGet]
    //    [Route("CreateTagClouds")]
    //    public IActionResult CreateTagClouds()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    [Route("CreateTagClouds")]
    //    public async Task<IActionResult> CreateTagClouds(CreateTagCloudsDto createTagCloudsDto)
    //    {
    //        var client = _httpClientFactory.CreateClient();
    //        var jsonData = JsonConvert.SerializeObject(createTagCloudsDto);
    //        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
    //        var responseMessage = await client.PostAsync("https://localhost:7054/api/TagCloudss", stringContent);
    //        if (responseMessage.IsSuccessStatusCode)
    //        {
    //            return RedirectToAction("Index", "AdminTagClouds", new { area = "Admin" });
    //        }
    //        return View();
    //    }

    //    [Route("RemoveTagClouds/{id}")]
    //    public async Task<IActionResult> RemoveTagClouds(int id)
    //    {
    //        var client = _httpClientFactory.CreateClient();
    //        var responseMessage = await client.DeleteAsync("https://localhost:7054/api/TagCloudss?id=" + id);
    //        if (responseMessage.IsSuccessStatusCode)
    //        {
    //            return RedirectToAction("Index", "AdminTagClouds", new { area = "Admin" });
    //        }
    //        return View();
    //    }

    //    [HttpGet]
    //    [Route("UpdateTagClouds/{id}")]
    //    public async Task<IActionResult> UpdateTagClouds(int id)
    //    {
    //        var client = _httpClientFactory.CreateClient();
    //        var resposenMessage = await client.GetAsync($"https://localhost:7054/api/TagCloudss/{id}");
    //        if (resposenMessage.IsSuccessStatusCode)
    //        {
    //            var jsonData = await resposenMessage.Content.ReadAsStringAsync();
    //            var values = JsonConvert.DeserializeObject<UpdateTagCloudsDto>(jsonData);
    //            return View(values);
    //        }
    //        return View();
    //    }

    //    [HttpPost]
    //    [Route("UpdateTagClouds/{id}")]
    //    public async Task<IActionResult> UpdateTagClouds(UpdateTagCloudsDto updateTagCloudsDto)
    //    {
    //        var client = _httpClientFactory.CreateClient();
    //        var jsonData = JsonConvert.SerializeObject(updateTagCloudsDto);
    //        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
    //        var responseMessage = await client.PutAsync("https://localhost:7054/api/TagCloudss/", stringContent);
    //        if (responseMessage.IsSuccessStatusCode)
    //        {
    //            return RedirectToAction("Index", "AdminTagClouds", new { area = "Admin" });
    //        }
    //        return View();
    //    }
    //}
}
