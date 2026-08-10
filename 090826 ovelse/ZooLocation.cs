using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{

    public class ZooLocation
    {
        public string NameZoo;
        public string City;
        public int ShopCapacity;
        public int VisitorCapacity;
        public int BuildingCapacity;
        public int EmployeeCapacity;
        public int EnclosureMaxLevelSecurity;
        /// <summary>
        /// Constructor for ZooLocation
        /// </summary>
        /// <param name="nameZoo"></param>
        /// <param name="city"></param>
        /// <param name="shopCapacity"></param>
        /// <param name="visitorCapacity"></param>
        /// <param name="buildingCapacity"></param>
        /// <param name="employeeCapacity"></param>
        /// <param name="enclosureMaxLevelSecurity"></param>
        public ZooLocation(string nameZoo, string city, int shopCapacity, int visitorCapacity, int buildingCapacity, int employeeCapacity, int enclosureMaxLevelSecurity)
        {
            NameZoo = nameZoo;
            City = city;
            ShopCapacity = shopCapacity;
            VisitorCapacity = visitorCapacity;
            BuildingCapacity = buildingCapacity;
            EmployeeCapacity = employeeCapacity;
            EnclosureMaxLevelSecurity = enclosureMaxLevelSecurity;
        }




    }
}
