﻿using ProductQueryMicroService.Entities.Abstracts;

namespace ProductQueryMicroService.Entities.Concretes
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
