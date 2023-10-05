﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HelloBlazor.Shared
{
    public class ShoppingItem
    {
        public int Id { get; set; } = -1;

        public string Name { get; set; } = "";

        public decimal Price { get; set; } = 0;

        public int Amount { get; set; } = 1;

        public string Description { get; set; } = "";

        public bool Done { get; set; } = false;
    }
}

