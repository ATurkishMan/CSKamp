﻿using System;

namespace OOP1
{
    class Program
    {   
        static void Main(string[] args) 
        { 
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {
                Id = 2,
                UnitsInStock = 5, 
                ProductName = "Kalem",
                UnitPrice = 50, 
                CategoryId = 3
            };

            ProductMenager productMenager = new ProductMenager();
            productMenager.Add(product1);
        }
    }
}