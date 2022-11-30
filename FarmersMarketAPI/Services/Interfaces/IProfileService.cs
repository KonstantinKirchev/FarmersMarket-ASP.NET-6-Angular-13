namespace FarmersMarketAPI.Services.Interfaces
{
    using FarmersMarketAPI.Models.BindingModels;
    using FarmersMarketAPI.Models.EntityModels;
    using FarmersMarketAPI.Models.ViewModels;

    public interface IProfileService
    {
        UserViewModel GetProfile();
        IEnumerable<MyOrderViewModel> GetMyOrders();
        IEnumerable<MyOrderViewModel> GetOrdersByStatus(string status);
        void EditUser(UserBindingModel model);
        Task<User> GetCurrentUser();
    }
}
