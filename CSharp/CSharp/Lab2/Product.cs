﻿using System;
using System.Collections.Generic;

namespace CSharp.Product
{
    public class Product
    {
        private int id;
        private string name;
        private float price;
        private int qty;
        private string image;
        private string desc;
        private List<string> gallery;

        public Product(int id, string name, float price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public Product()
        {
            Console.WriteLine("ban vua tao ra mot doi tuong product");
        }

        public string GetInformation()
        {
            return "ID : " + id+
                   "\nName: "+name+
                   "\nPrice: "+price+
                   "\nQty: "+qty+
                   "\nimage: "+image+
                   "\ndesc: "+desc
                ;
        }

        public void Status()
        {
            if (qty > 0)
            {
                Console.WriteLine("Con hang");
            }
            else
            {
                Console.WriteLine("het hang");
            }
        }

        public void GalleryAdd(String url)
        {
            if (gallery.Count < 2)
            {
                gallery.Add(url);
            }
            else
            {
                for (var i = 0; i < 2; i++)
                {
                    Console.WriteLine(gallery[i]);
                }
                Console.WriteLine("chon file ban muon xoa");
                int number;
                number = Convert.ToInt32(Console.ReadLine());
                gallery.Remove(gallery[number]);
                gallery.Add(url);




            }
        }
        
        
        
    }
}