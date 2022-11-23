namespace FarmersMarketAPI.Data.UnitOfWork
{
    using FarmersMarketAPI.Data.Repositories;
    using FarmersMarketAPI.Models.EntityModels;

    public interface IFarmersMarketData
    {
        IRepository<User> Users { get; }

        IRepository<Category> Categories { get; }

        IRepository<Farm> Farms { get; }

        IRepository<Product> Products { get; }

        IRepository<ShoppingCart> ShoppingCarts { get; }

        IRepository<ShoppingCartProduct> ShoppingCartProducts { get; }

        int SaveChanges();
    }
}
