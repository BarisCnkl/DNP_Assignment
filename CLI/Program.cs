using CLI.UI;
using FileRepositories;
using RepositoryContracts;

Console.WriteLine("Starting CLI app...");
IUserRepository userRepository = new UserFileRepository(); // old: UserInMemoryRepository();
IcommentRepository commentRepository = new CommentFileRepository(); // old: CommentInMemoryRepository();
IpostRepository postRepository = new PostFileRepository(); // old: PostInMemoryRepository();
ILikeRepository likeRepository = new LikeFileRepository();

CliApp cliApp = new CliApp(userRepository, commentRepository, postRepository, likeRepository);
await cliApp.StartAsync();
