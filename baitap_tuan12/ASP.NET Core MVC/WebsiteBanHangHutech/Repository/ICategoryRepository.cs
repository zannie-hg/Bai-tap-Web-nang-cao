using WebsiteBanHangHutech.Models;

namespace WebsiteBanHangHutech.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }

}
