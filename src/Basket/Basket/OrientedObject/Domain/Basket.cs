using System;
using System.Collections.Generic;
    
namespace Basket.OrientedObject.Domain
{
    public class Basket
    {
        public Basket(IList<LineArticle> lineArticle)
        {
            this.ListLineArticle = lineArticle;
        }

        private IList<LineArticle> ListLineArticle { get; set; }
    }
}