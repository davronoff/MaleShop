using MaleShop.Domains;

namespace MaleShop.AdminDashboard.ViewModels
{
    public class EditBrandViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public static explicit operator EditBrandViewModel(Brand m)
        {
            return new EditBrandViewModel()
            {
                Id = m.Id,
                Name = m.Name
            };
        }
        public static explicit operator Brand(EditBrandViewModel v)
        {
            return new Brand()
            {
                Id = v.Id,
                Name = v.Name
            };
        }
    }
}
