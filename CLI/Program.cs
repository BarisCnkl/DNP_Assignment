using CLI.UI;
using InMemoryRepository;
using RepositoryContracts;

Console.WriteLine("Starting CLI app...");
IUserRepository userRepository = new UserInMemoryRepository();
IcommentRepository commentRepository = new CommentInMemoryRepository();
IpostRepository postRepository = new PostInMemoryRepository();
ILikeRepository likeRepository = new LikeInMemoryRepository();

CliApp cliApp = new CliApp(userRepository, commentRepository, postRepository, likeRepository);
await cliApp.StartAsync();

Console.WriteLine("CLI started");
