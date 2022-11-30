namespace FarmersMarketAPI.Services.Interfaces
{
    using FarmersMarketAPI.Models.EntityModels;
    using FarmersMarketAPI.Models.ViewModels;

    public interface IUsersService
    {
        IEnumerable<UserViewModel> GetAllUsers();
        Task AddUserToRoleManager(string id);
        Task RemoveUserFromRoleManager(string id);
        void AssignManagerToFarm(string UserId, int FarmId);
        string GetCurrentUserId();
        Task<User> GetCurrentUser();
    }
}
