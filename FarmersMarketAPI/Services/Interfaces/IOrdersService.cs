namespace FarmersMarketAPI.Services.Interfaces
{
    using FarmersMarketAPI.Models.EntityModels;
    using FarmersMarketAPI.Models.ViewModels;

    public interface IOrdersService
    {
        IEnumerable<OrderViewModel> GetAllOrders();
        void DeliverOrder(int id);
        IEnumerable<OrderViewModel> GetOrdersByStatus(string status);
        IEnumerable<ShoppingCartProduct> GetOrderProducts(int id);
        UserViewModel? GetOrderOwner(int id);
    }
}
