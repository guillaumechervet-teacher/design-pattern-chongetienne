
namespace Basket.OrientedObject.Domain
{
    public class LineArticle
    {
        public LineArticle(Article article, int quantity)
        {
            this.Article = article;
            this.Quantity = quantity;
        }

        private Article Article { get; set; }
        private int Quantity { get; set; }
    }
}