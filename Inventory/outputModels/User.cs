using System;
using System.Collections.Generic;

namespace Inventory.outputModels
{
    public partial class User
    {
        public int Id { get; set; }
        public sbyte IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Login { get; set; } = null!;
    }
}
