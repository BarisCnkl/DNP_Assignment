using RepositoryContracts;

namespace CLI.UI;

public class CliApp
{
    private IUserRepository iUserRepository{get;set;}
    private IcommentRepository iCommentRepository{get;set;}
    private IpostRepository iPostRepository{get;set;}

    public CliApp(IUserRepository iUserRepository, IcommentRepository iCommentRepository,
        IpostRepository iPostRepository)
    {
        this.iUserRepository = iUserRepository;
        this.iCommentRepository = iCommentRepository;
        this.iPostRepository = iPostRepository;
    }

    public async Task StartAsync()
    {
        Console.Write("starting cliAPP");
    }
}