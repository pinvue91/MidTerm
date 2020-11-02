using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class ItemOrder
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double OrderTotal { get; }

        public ItemOrder(string ItemName, int Quantity, double ItemPrice) 
        {
            this.ItemName = ItemName;
            this.Quantity = Quantity;
            this.ItemPrice = ItemPrice;
            this.OrderTotal = ItemPrice * Quantity;
        }

        public string GetOrderInfo()
        {
            return $"{ItemName} {ItemPrice} x {Quantity} = {OrderTotal}";
        }
    }
}
