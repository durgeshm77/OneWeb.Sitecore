using Glass.Mapper.Sc.Web.Mvc;
using OneWeb.Feature.Interface;
using OneWeb.Feature.Promo.Models;
using OneWeb.Feature.Promo.Models.Interface;
using OneWeb.Foundation.DependencyInjection;
using Sitecore.Mvc.Presentation;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace OneWeb.Feature.Promo.Repositories
{
    [Service(Lifetime = Lifetime.Transient, ServiceType = typeof(IPromoRepository))]
    public class PromoRepository : VariantsRepository, IPromoRepository
    {
        private readonly IMvcContext _mvcContext;
        public PromoRepository(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

        private HorizontalPromo GetHorizontalPromo()
        {
            var model = _mvcContext.GetDataSourceItem<HorizontalPromo>();
            FillBaseProperties(model);
            return model;
        }

        public object GetPromoModel()
        {
            if (_mvcContext.DataSourceItem.Template.ID.ToString().Equals(Template.OneWebPromoTemplate))
            {
                return this.GetPromos();
            }
            if (_mvcContext.DataSourceItem.Template.ID.ToString().Equals(Template.HorizontalPromoTemplate))
            {
                return this.GetHorizontalPromo(); ;
            }
            return null;
        }

        private PromoModel GetPromos()
        {
            var model = _mvcContext.GetDataSourceItem<PromoModel>();
            FillBaseProperties(model);
            return model;
        }
        //public override IRenderingModelBase GetModel()
        //{
        //    //if(_mvcContext.DataSourceItem.Template.ID.Equals(Template.OneWebPromoTemplate))
        //    //{
        //    //    PromoModel model = _mvcContext.GetDataSourceItem<PromoModel>();
        //    //    return model;
        //    //}
        //    return null;
        //}

    }

}