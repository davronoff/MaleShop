using MaleShop.Domains;

namespace MaleShop.AdminDashboard.ViewModels
{
    public class EditCategoryViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public static explicit operator EditCategoryViewModel(Category m)
        {
            return new EditCategoryViewModel()
            {
                Id = m.Id,
                Name = m.Name
            };
        }
        public static explicit operator Category(EditCategoryViewModel v)
        {
            return new Category()
            {
                Id = v.Id,
                Name = v.Name
            };
        }
    }
}
