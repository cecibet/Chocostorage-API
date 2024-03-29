﻿using ChocoStorageAPI.Enums;
using System.Text.Json.Serialization;

namespace ChocoStorageAPI.Models

{
    public class SellDto
    {
        public int SellId { get; set; }

        public DateTime Date { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public float TotalCost { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ShippingTypes ShippingType { get; set; } = ShippingTypes.Retiro;

    }
}
