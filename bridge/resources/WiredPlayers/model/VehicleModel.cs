﻿using GTANetworkAPI;
using System;

namespace WiredPlayers.model
{
    public class VehicleModel
    {
        public int id { get; set; }
        public String model { get; set; }
        public String owner { get; set; }
        public String plate { get; set; }
        public Vector3 position { get; set; }
        public Vector3 rotation { get; set; }
        public int colorType { get; set; }
        public String firstColor { get; set; }
        public String secondColor { get; set; }
        public int pearlescent { get; set; }
        public uint dimension { get; set; }
        public int faction { get; set; }
        public int engine { get; set; }
        public int locked { get; set; }
        public int price { get; set; }
        public int parking { get; set; }
        public int parked { get; set; }
        public float gas { get; set; }
        public float kms { get; set; }
    }
}
