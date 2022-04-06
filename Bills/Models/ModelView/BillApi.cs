using System;
using System.Collections.Generic;

namespace Bills.Models.ModelView
{
    public class BillApi
    {
     
        public int id { get; set; }
        public DateTime billDate { get; set; }

        public int clintId { get; set; }
        public int billsTotal { get; set; }
        public int PercentageDiscount { get; set; }

        public int ValueDiscount { get; set; }
        public int TheNet { get; set; }
        public int PaidUp { get; set; }

        public int TheRest { get; set; }

        public Dictionary<int, int> ItemsQuantity { get; set; }

        public dynamic listItemView { get; set; }


        //ItemsQuantity: any;
    }
}
