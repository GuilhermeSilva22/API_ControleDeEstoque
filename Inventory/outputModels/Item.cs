using System;
using System.Collections.Generic;

namespace Inventory.outputModels
{
    public partial class Item
    {
        public int Id { get; set; }
        public sbyte IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public int Code { get; set; }
        public int TheAmount { get; set; }
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Provider { get; set; } = null!;
    }
}
