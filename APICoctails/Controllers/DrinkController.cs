using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace APICoctails.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController: ControllerBase{
        private readonly HttpClient _httpClient;

        //constructor of controler recives an argument _HttpClient
        public DrinkController(HttpClient httpClient){
            _httpClient= httpClient;
        }

        //get method for obtain data of a cocktail 
        [HttpGet("{coktailName}")]
        public async Task<IActionResult> GetCoctailByName(string cocktailName){
            //petition to the TheCoctailApi 
            var response= await _httpClient.GetStringAsync($"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={cocktailName}");
            //translate and save the response in json format in a C# object
            var cocktail= JsonConvert.DeserializeObject<dynamic>(response);
        }
    }
}