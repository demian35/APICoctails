
using System.Collections.Generic;
//class that modelating a Drink from de TheCocktailDB to the proyect
public class Drink{
    public string Name{get; set;} //name of the coctail
    public string Category{get; set;} //category of the drink
    public string InstructionsEng{get; set;}//intructions for the preparation of the drink
    public string InstructionsEsp{get; set;}//instruccions for the preparations of the drink in spanish
    public List<string> Ingredients{get; set;} //The ingredients of the drink will storage in a list of strings

}