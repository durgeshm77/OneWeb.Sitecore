using OneWeb.Feature.Promo.Models;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace OneWeb.Feature.Interface
{
    public interface IPromoRepository : IVariantsRepository
    {
        object GetPromoModel();
    }
}
