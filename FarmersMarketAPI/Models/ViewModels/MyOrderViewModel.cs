namespace FarmersMarketAPI.Models.ViewModels
{
    using FarmersMarketAPI.Models.EntityModels;
    using FarmersMarketAPI.Models.Enums;
    using FarmersMarketAPI.Models.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class MyOrderViewModel : IMapFrom<ShoppingCart>
    {
        public MyOrderViewModel()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 99999.99, ErrorMessage = "Price should be between {1} and {2}.")]
        public decimal TotalPrice { get; set; }

        public DateTime? DateOfOrder { get; set; }

        public DateTime? DateOfDelivery { get; set; }

        public OrderStatus Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
