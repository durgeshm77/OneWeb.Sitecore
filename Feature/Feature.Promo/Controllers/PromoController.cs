using Glass.Mapper.Sc.Web.Mvc;
using OneWeb.Feature.Interface;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace OneWeb.Feature.Promo.Controllers
{
    public class PromoController : StandardController
    {
        private readonly IPromoRepository _promo;
        public PromoController(IPromoRepository promo)
        {
            _promo = promo;
        }
        protected override object GetModel()
        {
            return _promo.GetPromoModel();
        }
    }
}