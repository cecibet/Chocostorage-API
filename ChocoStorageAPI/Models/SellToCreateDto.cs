﻿using ChocoStorageAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ChocoStorageAPI.Models
{
    public class SellToCreateDto
    {
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public float TotalCost { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ShippingTypes ShippingType { get; set; } = ShippingTypes.Retiro;
    }
}