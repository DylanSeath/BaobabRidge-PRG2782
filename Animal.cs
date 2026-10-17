using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BaobaRidge
{
    public class Animal   //this is the animal class used throughout, one animal represents an instance this class
    {
        public string Id { get; set; } = string.Empty; //animal's ID
        public string Name { get; set; } = string.Empty;  //animal's name
        public string Species { get; set; } = string.Empty;  //species name
        public int Age { get; set; }  //the age, there is an acceptable range in years
        public int Score { get; set; }  //the value of the score
        public string Status { get; set; } = string.Empty;   //a condition label thats determined from score, not typed
        public string HousingUnit { get; set; } = string.Empty; //housing unit holds text and is determined from score, not typed


        //Takes the 7 vales and saves them in one line, when program saves an animal, this text gets written to the file
        public string ToFileLine()
        {
            return $"{Id}|{Name}|{Species}|{Age}|{Score}|{Status}|{HousingUnit}";
        }

        //takes a line from the file and turn it to an 'Animal'
        public static bool TryParse(string line, out Animal? animal)  
        {
            animal = null;   //makes it so we start with 'blank animal'
            string[] parts = line.Split('|');   

            if (parts.Length != 7) return false;

            string id = parts[0].Trim().ToUpper();  //make a string for the Id so we can trim and uppcase it

            if (!Regex.IsMatch(id, @"^WR-\d{4}$")) return false;  //if it doesn't match then quit

            if (!int.TryParse(parts[3], out int age)) return false; //this one is for age
            if (!int.TryParse(parts[4], out int score)) return false; //this one if for score

            animal = new Animal { Id = id, Name = parts[1].Trim(), Species = parts[2].Trim(), Age = age, Score = score, Status = parts[5].Trim(), HousingUnit = parts[6].Trim()};

            return true;
        }
    }
}
