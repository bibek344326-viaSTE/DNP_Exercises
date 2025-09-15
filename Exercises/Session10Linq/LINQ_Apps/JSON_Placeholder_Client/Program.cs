using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using JSON_Placeholder_Client.Entities;

class Program
{
    private static readonly HttpClient Client = new();
    static async Task Main(string[] args)
    {
     Console.WriteLine("JSON Placeholder Client - API Interaction");
        Console.WriteLine("1. Get Todos");
        Console.WriteLine("2. Get Users");
        Console.WriteLine("3. Create Post");
        Console.WriteLine("4. Update Post");
        Console.WriteLine("5. Delete Post");
        Console.WriteLine("6. Get Post");
        Console.WriteLine("Choose an option:");
        var choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                GetTodosAsync().Wait();
                break;
            case "2":
                GetUsersAsync().Wait();
                break;
            case "3":
                CreatePostAsync().Wait();
                break;
            case "4":
                UpdatePostAsync().Wait();
                break;
            case "5":
                DeletePostAsync().Wait();
                break;
            case "6":
                GetPostAsync().Wait();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
    // Get Todos
    static async Task GetTodosAsync()
    {
        var todos = await Client.GetFromJsonAsync<Todo[]>("https://jsonplaceholder.typicode.com/todos");
        foreach (var todo in todos)
        {
            Console.WriteLine($"ID: {todo.Id}, Title: {todo.Title}, Completed: {todo.Completed}");
        }
    }
    
    // Get Users
    static async Task GetUsersAsync()
    {
        var users = await Client.GetFromJsonAsync<User[]>("https://jsonplaceholder.typicode.com/users");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
    }
    
    // Create Post
    static async Task CreatePostAsync()
    {
        Console.Write("Enter User ID: ");
        int userId = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter Title: ");
        string title = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter Body: ");
        string body = Console.ReadLine() ?? string.Empty;

        var newPost = new Post
        {
            UserId = userId,
            Title = title,
            Body = body
        };

        var response = await Client.PostAsJsonAsync("https://jsonplaceholder.typicode.com/posts", newPost);
        Console.WriteLine($"Status: {response.StatusCode}");

        var createdPost = await response.Content.ReadFromJsonAsync<Post>();
        if (createdPost != null)
        {
            Console.WriteLine($"Successfully created post with ID: {createdPost.Id}");
        }
        else
        {
            Console.WriteLine("Failed to create post.");
        }
    }
    
    // Update Post
    static async Task UpdatePostAsync()
    {
        Console.Write("Enter Post ID to Update: ");
        int postId = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter User ID: ");
        int userId = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter New Title: ");
        string title = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter New Body: ");
        string body = Console.ReadLine() ?? string.Empty;

        var updatedPost = new Post
        {
            Id = postId,
            UserId = userId,
            Title = title,
            Body = body
        };

        var response = await Client.PutAsJsonAsync($"https://jsonplaceholder.typicode.com/posts/{postId}", updatedPost);
        Console.WriteLine($"Status: {response.StatusCode}");

        var post = await response.Content.ReadFromJsonAsync<Post>();
        if (post != null)
        {
            Console.WriteLine($"Successfully updated post with Title: {post.Title}");
        }
        else
        {
            Console.WriteLine("Failed to update post.");
        }
    }
    
    // Get Post
    static async Task GetPostAsync()
    {
        var post = await Client.GetFromJsonAsync<Post>("https://jsonplaceholder.typicode.com/posts/1");
        Console.WriteLine($"ID: {post.Id}, Title: {post.Title}, Body: {post.Body}");
    }
    
    // Delete Post
    static async Task DeletePostAsync()
    {
        var response = await Client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1");
        response.EnsureSuccessStatusCode();
        Console.WriteLine("Post deleted successfully");
    }
}