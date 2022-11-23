namespace FarmersMarketAPI.Models.ViewModels
{
    using FarmersMarketAPI.Models.EntityModels;
    using FarmersMarketAPI.Models.Infrastructure.Mapping;

    public class ShoppingCartProductViewModel : IMapFrom<ShoppingCartProduct>
    {
        public int ShoppingCartId { get; set; }

        public int ProductId { get; set; }

        public ShoppingCart? ShoppingCart { get; set; }

        public Product? Product { get; set; }

        public int Units { get; set; }
    }
}
