using System;
using System.Reflection.Emit;

namespace Basket.OrientedObject.Domain
{
    public class Article
    {
        public Article(int id, string label, string categorie, int price, int stock)
        {
            this.Id = id;
            this.Label = label;
            this.Categorie = categorie;
            this.Price = price;
            this.Stock = stock;
        }

        private int Id { get; set; }
        private string Label { get; set; }
        private string Categorie { get; set; }
        private int Price { get; set; }
        private int Stock { get; set; }
    }
}