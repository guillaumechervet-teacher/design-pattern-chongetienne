using System;
using System.Collections.Generic;
using Basket.Domain;
    
namespace Basket.Domain
{
    public class Basket
    {
        private IList<BasketLineArticle> basketLineArticles;
        public Basket(IList<BasketLineArticle> articles)
        {
            basketLineArticles = articles;
        }
    }
}