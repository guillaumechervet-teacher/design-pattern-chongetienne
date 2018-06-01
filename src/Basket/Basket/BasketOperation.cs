using System.Collections.Generic;

namespace Basket
{
    public class BasketOperation
    {
        private readonly Basket.OrientedObject.Infrastructure.BasketService _basketService;
        public BasketOperation(Basket.OrientedObject.Infrastructure.BasketService basketService)
        {
            _basketService = basketService;
        }
        public int CalculateAmout(IList<BasketLineArticle> basketLineArticles)
        {
            Basket.OrientedObject.Domain.Basket basket = _basketService.GetBasket(basketLineArticles);
            return basket.CalculateAmount();
        }
    }
}