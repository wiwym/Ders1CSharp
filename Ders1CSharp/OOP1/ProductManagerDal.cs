﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManagerDal

    {
        
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " " + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " " + "güncellendi.");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }

    }
}
