using DevopsDemo.Models;

namespace DevopsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {

            var posts = new List<PostViewModel> {
            new PostViewModel(){PostId=1,Title="Devops Demo Title 1",Description="DevOps emo Description 1", Author="Anandharaj 1" },
            new PostViewModel(){PostId=2,Title="Devops Demo Title 2",Description="DevOps emo Description 2", Author="Anandharaj 2" },
            new PostViewModel(){PostId=3,Title="Devops Demo Title 3",Description="DevOps emo Description 3", Author="Anandharaj 3" },
            new PostViewModel(){PostId=4,Title="Devops Demo Title 4",Description="DevOps emo Description 4", Author="Anandharaj 4" },
            };


            return posts;
        }

    }
}
