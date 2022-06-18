using AutoMapper;
using GoodsGator.Models.DbEntities;
using GoodsGator.Models.DTOs;

namespace GoodsGator.Helpers;

public class ProductUrlResolver: IValueResolver<Product, ProductDTO, string>
{
    private readonly IConfiguration _config;

    public ProductUrlResolver(IConfiguration config)
    {
        _config = config;
    }

    public string Resolve(Product source, ProductDTO destination, string destMember, ResolutionContext context)
    {
        if (!string.IsNullOrEmpty(source.ImageUrl))
            return _config["ApiUrl"] + source.ImageUrl;

        return null;
    }
}
