using GoodsGator.Models.DbEntities;
using System.Text.Json;

namespace GoodsGator.Data;

public static class ApplicationContextSeed
{
    public static IHost SeedData(this IHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            using (var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                try
                {
                    SeedBrands(context);
                    SeedProductTypes(context);
                    SeedProducts(context);
                }
                catch (Exception)
                {

                }
            }
        }

        return host;
    }


    private static void SeedBrands(ApplicationDbContext context)
    {
        if (!context.Brands.Any())
        {
            var brandsData = File.ReadAllText("./Data/SeedData/Brands.json");
            var brands = JsonSerializer.Deserialize<List<Brand>>(brandsData);
            context.Brands.AddRange(brands);
            context.SaveChanges();
        }
    }

    private static void SeedProductTypes(ApplicationDbContext context)
    {
        if (!context.ProductTypes.Any())
        {
            var productTypesData = File.ReadAllText("./Data/SeedData/ProductTypes.json");
            var productTypes = JsonSerializer.Deserialize<List<ProductType>>(productTypesData);
            context.ProductTypes.AddRange(productTypes);
            context.SaveChanges();
        }
    }

    private static void SeedProducts(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            var productsData = File.ReadAllText("./Data/SeedData/Products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }

    //public static async Task SeedAsync(ApplicationDbContext context, ILoggerFactory loggerFactory)
    //{
    //    try
    //    {
    //        if (!context.Brands.Any())
    //        {
    //            var brandsData = File.ReadAllText("./Data/SeedData/Brands.json");
    //            var brands = JsonSerializer.Deserialize<List<Brand>>(brandsData);

    //            foreach (var brand in brands)
    //            {
    //                context.Brands.Add(brand);
    //            }

    //            await context.SaveChangesAsync();
    //        }

    //        if (!context.ProductTypes.Any())
    //        {
    //            var productTypesData = File.ReadAllText("./Data/SeedData/ProductTypes.json");
    //            var productTypes = JsonSerializer.Deserialize<List<ProductType>>(productTypesData);

    //            foreach (var productType in productTypes)
    //            {
    //                context.ProductTypes.Add(productType);
    //            }

    //            await context.SaveChangesAsync();
    //        }

    //        if (!context.Products.Any())
    //        {
    //            var productsData = File.ReadAllText("./Data/SeedData/Products.json");
    //            var products = JsonSerializer.Deserialize<List<Product>>(productsData);

    //            foreach (var product in products)
    //            {
    //                context.Products.Add(product);
    //            }

    //            await context.SaveChangesAsync();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        var logger = loggerFactory.CreateLogger<ApplicationContextSeed>();
    //        logger.LogError(ex.Message);
    //    }
    //}
}
