using System;
using System.Collections.Generic;
using Basket.Domain;

namespace Basket.Infrastructure
{
    public class BasketService
    {
        public Domain.Basket GetBasket(IList<BasketLineArticle> basketLineArticles)
        {
            var basket = new Basket.Domain.Basket(basketLineArticles);
            return basket;
        }
    }
}