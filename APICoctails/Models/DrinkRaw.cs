//Intermediate class that receives the data in json from the TheCocktailDB API response
using System.Text.Json.Serialization;
using System.Collections.Generic;

//Class that receive the resoponse and storage them in a List
public class DrinkResponse{
    [JsonPropertyName("drinks")]
    public List<DrinkRaw> Drinks{get; set;}
}

public class DrinkRaw{
        [JsonPropertyName("strDrink")]
    public string Name { get; set; }
    [JsonPropertyName("strCategory")]
    public string Category { get; set; }
    [JsonPropertyName("strInstructions")]
    public string InstructionsEng { get; set; }
    [JsonPropertyName("strInstructionsES")]
    public string InstructionsEsp { get; set; }
    [JsonPropertyName("strIngredient1")]
    public string Ingredient1 { get; set; }
    [JsonPropertyName("strIngredient2")]
    public string Ingredient2 { get; set; }
    [JsonPropertyName("strIngredient3")]
    public string Ingredient3 { get; set; }
    [JsonPropertyName("strIngredient4")]
    public string Ingredient4 { get; set; }
    [JsonPropertyName("strIngredient5")]
    public string Ingredient5 { get; set; }
    [JsonPropertyName("strIngredient6")]
    public string Ingredient6 { get; set; }
    [JsonPropertyName("strIngredient7")]
    public string Ingredient7 { get; set; }
    [JsonPropertyName("strIngredient8")]
    public string Ingredient8 { get; set; }
    [JsonPropertyName("strIngredient9")]
    public string Ingredient9 { get; set; }
    [JsonPropertyName("strIngredient10")]
    public string Ingredient10 { get; set; }
    [JsonPropertyName("strIngredient11")]
    public string Ingredient11 { get; set; }
    [JsonPropertyName("strIngredient12")]
    public string Ingredient12 { get; set; }
    [JsonPropertyName("strIngredient13")]
    public string Ingredient13 { get; set; }
    [JsonPropertyName("strIngredient14")]
    public string Ingredient14 { get; set; }
    [JsonPropertyName("strIngredient15")]
    public string Ingredient15 { get; set; }
}


