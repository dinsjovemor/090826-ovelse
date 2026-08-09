using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Habitat
    {
        public string NameHabitat;
        public string TypeOfEnclosure;
        public int SafetyLevel;
        public int VisitorCapacity;
        public int EmployeeCapacity;
        public int CaretakerCapacity;
        /// <summary>
        /// Constructor for Habitat
        /// </summary>
        /// <param name="nameHabitat"></param>
        /// <param name="typeOfEnclosure"></param>
        /// <param name="safetyLevel"></param>
        /// <param name="visitorCapacity"></param>
        /// <param name="employeeCapacity"></param>
        /// <param name="caretakerCapacity"></param>
        public Habitat(string nameHabitat, string typeOfEnclosure, int safetyLevel, int visitorCapacity, int employeeCapacity, int caretakerCapacity)
        {
            NameHabitat = nameHabitat;
            TypeOfEnclosure = typeOfEnclosure;
            SafetyLevel = safetyLevel;
            VisitorCapacity = visitorCapacity;
            EmployeeCapacity = employeeCapacity;
            CaretakerCapacity = caretakerCapacity;

        }


    }
}
