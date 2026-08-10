using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Building
    {
        public string NameBuilding { get; set; }
        public int BuildingNumber { get; set; }
        public string Description { get; set; }
        public string LocationCity { get; set; }
        public string FunctionOfBuilding { get; set; }
        public int EmployeesCapacity { get; set; }
        public int VisitorCapacity { get; set; }
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
