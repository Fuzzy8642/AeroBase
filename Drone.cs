using System;
using System.Collections.Generic;
using System.Text;

namespace AeroBase
{
    internal class Drone
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Model { get; set; } = "";

        public string Type { get; set; } = "";
        public string InventoryNumber { get; set; } = "";
        public string Status { get; set; } = "";

    }
}
