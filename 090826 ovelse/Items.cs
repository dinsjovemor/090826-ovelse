using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Items
    {
        public string NameItem;
        public string Description;
        public string CategoryOfItem;
        public int PriceOfItem;
        public int AmountInStock;
        public int ArrivedDateOfMonth;
        public int SpoiledDateOfMonth;
        /// <summary>
        /// Constructor for Items
        /// </summary>
        /// <param name="nameItem"></param>
        /// <param name="description"></param>
        /// <param name="categoryOfItem"></param>
        /// <param name="priceOfItem"></param>
        /// <param name="amountInStock"></param>
        /// <param name="arrivedDateOfMonth"></param>
        /// <param name="spoiledDateOfMonth"></param>
        public Items(string nameItem, string description, string categoryOfItem, int priceOfItem, int amountInStock, int arrivedDateOfMonth, int spoiledDateOfMonth)
        {
            NameItem = nameItem;
            Description = description;
            CategoryOfItem = categoryOfItem;
            PriceOfItem = priceOfItem;
            AmountInStock = amountInStock;
            ArrivedDateOfMonth = arrivedDateOfMonth;
            SpoiledDateOfMonth = spoiledDateOfMonth;
            
        }        
    }
}
