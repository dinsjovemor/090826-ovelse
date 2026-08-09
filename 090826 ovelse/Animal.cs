using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Animal
    {
        public string NameAnimal;
        public string AnimalGroup;
        public int SafetyRequirement;
        public string FeedingRequirement;
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
