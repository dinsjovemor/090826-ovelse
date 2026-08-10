using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Animal
    {
        public string NameAnimal { get; set; }
        public string AnimalGroup { get; set; }
        public int SafetyRequirement { get; set; }
        public string FeedingRequirement { get; set; }
        /// <summary>
        /// Constructor for Animal
        /// </summary>
        /// <param name="nameAnimal"></param>
        /// <param name="animalGroup"></param>
        /// <param name="safetyRequirement"></param>
        /// <param name="feedingRequirement"></param>
        public Animal(string nameAnimal, string animalGroup, int safetyRequirement, string feedingRequirement)
        {
            NameAnimal = nameAnimal;
            AnimalGroup = animalGroup;
            SafetyRequirement = safetyRequirement;
            FeedingRequirement = feedingRequirement;
        }
    }
}
