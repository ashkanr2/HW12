using System;
using System.Globalization;
using System.Xml.Linq;
using _10.Models;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace _10.Data_Access
{
    public class ProductRippo
    {
            public static List<Product> Products = new List<Product>
            {new Product
        {Id = 1,Name = "گلکسی",Number=3,Number2=1,Price=1000},
        new Product
        {Id = 2,Name = "ایفون14",Number=15,Price=1000},
        new Product
        {Id = 3,Name = "لپ تاپ لنو",Number=11,Number2=1,Price=1200},
        new Product
        {Id = 4,Name = "نوکیا1100",Number=35,Price=100},
        new Product
        {Id = 5,Name = "چیپس",Number=4,Price=2},
        new Product
        {Id = 6,Name = "شکلات",Number=3,Price=1},
        new Product
        {Id = 7,Name = "لامپ",Number=5, Price=5},
        new Product
        {Id = 8,Name = "اسباب بازی",Number=12,Number2 = 12, Price=10},
         new Product
        {Id = 9,Name = "چاقو",Number=3, Price=10},
          new Product
        {Id =10,Name = "تفنگ",Number=12, Price=400},

        };
        public List<Product> GetList()
        {
            return Products;
        }
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public void Delete(int id)
        {
            var entity = Products.FirstOrDefault(x => x.Id == id);
            Products.Remove(entity);
        }
        public Product Get(int id)
        {
            var entity = Products.FirstOrDefault(x => x.Id == id);
            return entity;
        }
        public void Edite(int id, string name, int number,decimal price)
        {
            var entity = Get(id);
            entity.Name = name;
            entity.Number = number;
            entity.Price = price;
        }
        public void Edite2( string name, int number, decimal price)
        {

            //var entity = Get(id);
            var result = Products;
            foreach (var p in result)
             if(p.Name == name)
                {
                 p.Number = number;
                 p.Price = price;

                }
        }

    }
}
