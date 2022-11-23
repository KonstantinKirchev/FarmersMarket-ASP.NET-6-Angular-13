namespace FarmersMarketAPI.Models.ViewModels
{
    using FarmersMarketAPI.Models.EntityModels;
    using FarmersMarketAPI.Models.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;
    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ModelsConstants.RequiredValidationMessage)]
        [StringLength(100, ErrorMessage = ModelsConstants.StringLengthValidationMessage)]
        public string? Name { get; set; }
    }
}
