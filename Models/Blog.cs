public class Blog
{
    public int BlodId { get; set; }
    public string URL { get; set; }

    public List<Post> Posts { get; } = new();
}