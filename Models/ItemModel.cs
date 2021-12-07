using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class ItemModel
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public int ItemQuantity { get; set; }
        public int Unit { get; set; }
        public double NetAmount { get; set; }
        public double GrossAmount { get; set; }
        public string Tax { get; set; }
        public string Discount { get; set; }
        public string Description { get; set; }
    }
}
