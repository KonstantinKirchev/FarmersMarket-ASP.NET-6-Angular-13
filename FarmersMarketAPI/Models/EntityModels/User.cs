namespace FarmersMarketAPI.Models.EntityModels
{
    using FarmersMarketAPI.Models.Enums;
    using Microsoft.AspNetCore.Identity;
    public class User : IdentityUser
    {
        public User()
        {
            this.ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? ImageUrl { get; set; }

        public SocialMedia? HowDoYouKnowAboutUs { get; set; }

        public int? FarmId { get; set; }

        public virtual Farm Farm { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
