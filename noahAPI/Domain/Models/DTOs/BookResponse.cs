﻿namespace noahAPI.Domain.Models.DTOs
{
    public class BookResponse
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
