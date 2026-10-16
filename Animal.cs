using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
