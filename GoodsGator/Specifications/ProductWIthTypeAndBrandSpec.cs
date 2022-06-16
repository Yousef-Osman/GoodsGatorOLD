using GoodsGator.Models.DbEntities;
using System.Linq.Expressions;

namespace GoodsGator.Specifications;

public class ProductWIthTypeAndBrandSpec : BaseSpecification<Product>
{
    public ProductWIthTypeAndBrandSpec()
    {
        AddInclude(x => x.Brand);
        AddInclude(x => x.ProductType);
    }

    public ProductWIthTypeAndBrandSpec(string id) : base(x => x.Id == id && x.IsDeleted == false)
    {
        AddInclude(x => x.Brand);
        AddInclude(x => x.ProductType);
    }
}
