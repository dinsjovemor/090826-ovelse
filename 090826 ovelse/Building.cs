using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Building
    {
        public string NameBuilding;
        public int BuildingNumber;
        public string Description;
        public string LocationCity;
        public string FunctionOfBuilding;
        public int EmployeesCapacity;
        public int VisitorCapacity;
        /// <summary>
        /// Constructor for Building
        /// </summary>
        /// <param name="nameBuilding"></param>
        /// <param name="buildingNumber"></param>
        /// <param name="description"></param>
        /// <param name="locationCity"></param>
        /// <param name="functionOfBuilding"></param>
        /// <param name="employeeCapacity"></param>
        /// <param name="visitorCapacity"></param>
        public Building(string nameBuilding, int buildingNumber, string description, string locationCity, string functionOfBuilding, int employeeCapacity, int visitorCapacity)
        {
            NameBuilding = nameBuilding;
            BuildingNumber = buildingNumber;
            Description = description;
            LocationCity = locationCity;
            FunctionOfBuilding = functionOfBuilding;
            EmployeesCapacity = employeeCapacity;
            VisitorCapacity = visitorCapacity;

        }

    }
}
