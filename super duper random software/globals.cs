using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace super_duper_random_software
{
    public class globals
    {
        //==============================================================================================
        //main thingies
        //==============================================================================================
        public static String[] TOPICS = { "Architecture", "Character", "Landscape", "Funny", "Action", "Anything" };
        public static String CHOSENTOPIC = "Chosen Topic\nArchitecture";
        public static menu m = new menu();
        //==============================================================================================
        //all the lists
        //==============================================================================================
        //characters
        public static string[] character = { "Darth Vader", "lightning McQueen", " Batman", " Albert Einstein", "Kungfu po", "Harry Potter", " sherlock holmes", " James Bond", " Jack sparrow", " Iron Man", " Captain America", " Shrek" };
        public static string[] clothes = { "Bohemian Chic", "Business Casual", "Athleisure", "Vintage Glam", "Streetwear Cool", "Classic Preppy", "Boho Festival", "Urban Minimalist", "Rock and Roll Edge", "Casual Denim", "Romantic Florals", "Eclectic Mix", "Sporty Spice", "Nautical Elegance", "Gothic Glam" };
        public static string[] descriptor = { "Medieval Knight", " Ice Skating", " Astronaut", "BeeKeeper", " Pirate", " RaceCar", " Swimming", " As monkey", " Architect", "Working out", " As a soldier", " As a model" };
        public static string[] action = { "Working out", "Fishing", "Cooking", "Hiking", "Escape Rooom", "Sports", "Art", "Kareoke", "Board Games", "Dance", "Volunteering", "Reading", "Fighting", "Jousting", "Casting spells", "Karate", "Bar Fight", "Kickboxing", "Sparing", "War", "Weapons training" };
        //places
        public static string[] scene = { "Castle", "Lake", "Desert", "In Space", "Farm", "Boat", "Racetrack", "Pool", "Beach", "Zoo", "Office", "Gym", "Battleground", "Stage" };
        public static string[] Aestetics = { "Modern", "Minimalist", "Maximalist", "Open Struct", "Federal", "PostModern" };
        public static string[] building = { "Coffee Shop", "office", "School", "Library", "Bank", "Bar" };
        public static string[] unique = { "Sunset", "Downtown", "Grassland", "Beach", "Stilt", "One-Story", "Tower", "MonoChrome", "Colorful" };
        public static string[] emotion = { "Power", "Relaxed", "Dreary", "Creativity", "Cozy", "Grand", "Luxury" };
        public static string[] POI = { "Waterfall", "Beach", "Castle", "Farm", "Cemetary", "Cottage", "City", "Forest", "Cliff", "Canyon", "Fields", "Island", "Ruins", "Sunrise", "Sunset", "WildLife", "Reflections", "Vineyard", "Hot air balloons" };
        public static string[] biome = { "Tundra", "Taiga", "Grasslans", "PLains", "Prarie", "RainForest", "Tropics", "Alpine", "Mountains", "Coral Reef", "Ice Berg", "Plains", "Prarie", "Grasslands" };
        //big ole list
        //public static string[][] listedLists = { character, clothes, descriptor, action, scene, Aestetics, building, unique, emotion, POI, biome };
        public static string[] anything = { "Darth Vader", "lightning McQueen", " Batman", " Albert Einstein", "Kungfu po", "Harry Potter", " sherlock holmes", " James Bond", " Jack sparrow", " Iron Man", " Captain America", " Shrek","Bohemian Chic", "Business Casual", "Athleisure", "Vintage Glam", "Streetwear Cool", "Classic Preppy", "Boho Festival", "Urban Minimalist", "Rock and Roll Edge",
            "Casual Denim", "Romantic Florals", "Eclectic Mix", "Sporty Spice", "Nautical Elegance", "Gothic Glam", "Medieval Knight", " Ice Skating", " Astronaut", "BeeKeeper", " Pirate", " RaceCar", " Swimming", " As monkey", " Architect", "Working out", " As a soldier", " As a model", "Working out", "Fishing", "Cooking", "Hiking", "Escape Rooom", "Sports", "Art", "Kareoke", "Board Games",
            "Dance", "Volunteering", "Reading", "Fighting", "Jousting", "Casting spells", "Karate", "Bar Fight", "Kickboxing", "Sparing", "War", "Weapons training", "Power", "Relaxed", "Dreary", "Creativity", "Cozy", "Grand", "Luxury","Waterfall", "Beach", "Castle", "Farm", "Cemetary", "Cottage", "City", "Forest", "Cliff", "Canyon", "Fields", "Island", "Ruins", "Sunrise", "Sunset", "WildLife",
            "Castle", "Lake", "Desert", "In Space", "Farm", "Boat", "Racetrack", "Pool", "Beach", "Zoo", "Office", "Gym", "Battleground", "Stage","Modern", "Minimalist", "Maximalist", "Open Struct", "Federal", "PostModern","Coffee Shop", "office", "School", "Library", "Bank", "Bar","Sunset", "Downtown", "Grassland", "Beach", "Stilt", "One-Story", "Tower", "MonoChrome", "Colorful",
            "Tundra", "Taiga", "Grasslans", "PLains", "Prarie", "RainForest", "Tropics", "Alpine", "Mountains", "Coral Reef", "Ice Berg", "Plains", "Prarie", "Grasslands", "Reflections", "Vineyard", "Hot air balloons",};
    }
}