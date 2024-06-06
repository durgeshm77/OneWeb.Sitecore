using Sitecore.XA.Foundation.Variants.Abstractions.Models;
using System;

namespace OneWeb.Feature.Promo.Models
{
    public class PromoModel : VariantsRenderingModel
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid Id { get; set; }
    }




}