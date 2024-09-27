using RepositoryContracts;

namespace CLI.UI;

public class CliApp
{
    private readonly IcommentRepository iCommentRepository;
    private readonly ILikeRepository iLikeRepository;
    private readonly IpostRepository ipostRepository;
    private readonly IUserRepository iUserRepository;

    public CliApp(IUserRepository iUserRepository,
        IcommentRepository iCommentRepository, IpostRepository ipostRepository,
        ILikeRepository iLikeRepository)
    {
        this.iLikeRepository = iLikeRepository;
        this.iCommentRepository = iCommentRepository;
        this.ipostRepository = ipostRepository;
        this.iUserRepository = iUserRepository;
    }

    public async Task StartAsync()
    {
        throw new NotImplementedException();
    }
}