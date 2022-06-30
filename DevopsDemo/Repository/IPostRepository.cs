using DevopsDemo.Models;

namespace DevopsDemo.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();

    }
}
