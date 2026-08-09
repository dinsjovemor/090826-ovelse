using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Shops
    {
        public string ShopName;
        public string TypeOfShop;
        public int NumberOfEmployees;
        public int VisitorCapacity;
        public string ItemSold;
        public int StockCapacity;
  /// <summary>
  /// Constructor for Shops
  /// </summary>
  /// <param name="shopName"></param>
  /// <param name="typeOfShop"></param>
  /// <param name="numberOfEmployees"></param>
  /// <param name="visitorCapacity"></param>
  /// <param name="itemSold"></param>
  /// <param name="stockCapacity"></param>
        Shops(string shopName, string typeOfShop, int numberOfEmployees, int visitorCapacity, string itemSold, int stockCapacity)
        {
            ShopName = shopName;
            TypeOfShop = typeOfShop;
            NumberOfEmployees = numberOfEmployees;
            VisitorCapacity = visitorCapacity;
            ItemSold = itemSold;
            StockCapacity = stockCapacity;
        }
    }
}
