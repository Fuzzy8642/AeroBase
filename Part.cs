using System;
using System.Collections.Generic;
using System.Text;

namespace AeroBase
{
    internal class Part
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string category { get; set; } = "";

        public int Quantity { get; set; }
        public string StorageLocation { get; set; } = "";
    }
}
