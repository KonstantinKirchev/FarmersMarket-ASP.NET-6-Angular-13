namespace FarmersMarketAPI.Services.Interfaces
{
    using FarmersMarketAPI.Models.BindingModels;
    using FarmersMarketAPI.Models.ViewModels;

    public interface IFarmsService
    {
        IEnumerable<FarmViewModel> GetAllFarms();
        void CreateNewFarm(FarmBindingModel model);
        FarmViewModel? GetEditFarm(int id);
        void EditFarm(FarmBindingModel model);
        FarmViewModel? GetDeleteFarm(int? id);
        void DeleteFarm(int id);
    }
}
