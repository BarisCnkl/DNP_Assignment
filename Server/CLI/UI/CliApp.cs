using CLI.UI.ManagePosts;
using CLI.UI.ManageUsers;
using RepositoryContracts;

namespace CLI.UI;

public class CliApp
{
     private readonly IUserRepository _userRepository;
            private readonly IpostRepository _postRepository;
            private readonly IcommentRepository _commentRepository;
    
            public CliApp(IUserRepository userRepository, IpostRepository postRepository, IcommentRepository commentRepository)
            {
                _userRepository = userRepository;
                _postRepository = postRepository;
                _commentRepository = commentRepository;
            }
    
            public async Task RunAsync()
            {
                bool isRunning = true;
                while (isRunning)
                {
                    Console.Clear();
                    Console.WriteLine("=== Forum CLI ===");
                    Console.WriteLine("1. Manage Users");
                    Console.WriteLine("2. Manage Posts");
                    Console.WriteLine("3. Manage Comments");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();
    
                    switch (choice)
                    {
                        case "1":
                            ManageUsersView manageUser = new ManageUsersView(_userRepository);
                            await manageUser.ShowMenuAsync();
                            break;
                        case "2":
                            ManagePostsView managePost = new ManagePostsView(_postRepository, _userRepository);
                            await managePost.ShowMenuAsync();
                            break;
                        case "3":
                            ManageCommentView manageComment = new ManageCommentView(_commentRepository, _postRepository, _userRepository);
                            await manageComment.ShowMenuAsync();
                            break;
                        case "0":
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("wrong option try again");
                            break;
                    }
                }
            }
}