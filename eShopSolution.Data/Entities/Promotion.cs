using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyForAll { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public string ProductIds { set; get; }
        public string ProductCategoryIds { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }
    }
}
