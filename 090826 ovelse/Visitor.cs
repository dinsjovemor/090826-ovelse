using System;
using System.Collections.Generic;
using System.Text;

namespace _090826_ovelse
{
    public class Visitor
    {
        public int VisitorNumber;
        public string NameVisitor;
        public int AmountOfMoney;
        /// <summary>
        /// Constructor for Visitor
        /// </summary>
        /// <param name="visitorNumber"></param>
        /// <param name="nameVisitor"></param>
        /// <param name="amountOfMoney"></param>
        public Visitor(int visitorNumber, string nameVisitor, int amountOfMoney)
        {

            VisitorNumber = visitorNumber;
            NameVisitor = nameVisitor;
            AmountOfMoney = amountOfMoney;
        }

    }
}
