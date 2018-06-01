using System;
using System.Collections.Generic;


namespace Basket
{
    public class ImperativeProgramming
    {
        public int CalculateBasketAmount(IList<BasketLineArticle> basketLineArticles)
        {
            var amountTotal = 0;
            foreach (var basketLineArticle in basketLineArticles) { // Retrive article from database
                #if DEBUG
                    var article = GetArticleDatabaseMock(basketLineArticle.Id);
                #else
                    var article = GetArticleDatabase(basketLineArticle.Id);
                #endif
                var amount = 0;
                switch (article.Category) {
                    case "food":
                        amount += article.Price * 100 + article.Price * 12;
                        break;
                    case "electronic":
                        amount += article.Price * 100 + article.Price * 20 + 4;
                        break;
                    case "desktop":
                        amount += article.Price * 100 + article.Price * 20;
                        break;
                }

                amountTotal += amount * basketLineArticle.Number;
            }

            return amountTotal;
        }
        public ArticleDatabase GetArticleDatabaseMock(string id)
        {
            switch (id)
            {
                case "1":
                    return new ArticleDatabase {Id = "1", Price = 1, Stock =
                        35, Label = "Banana", Category = "food"};
                case "2":
                    return new ArticleDatabase
                    {
                        Id = "2",
                        Price = 500,
                        Stock = 20,
                        Label = "Fridge electrolux",
                        Category = "electronic"
                    };
                case "3":
                    return new ArticleDatabase {Id = "3", Price = 49, Stock =
                        68, Label = "Chair", Category = "desktop"};
                default:
                    throw new NotImplementedException();
            }
        }
    }
}