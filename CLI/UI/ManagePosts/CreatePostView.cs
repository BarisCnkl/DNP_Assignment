using RepositoryContracts;

namespace CLI.UI.ManagePosts;

public class CreatePostView
{
    private readonly IpostRepository postRepository;

    public CreatePostView(IpostRepository postRepository)
    {
        this.postRepository = postRepository;
    }
}
