using System.Text;

namespace Course.Entities;
class Post
{
    public DateTime Moment {get; private set;}
    public string? Title {get; private set;}
    public string? Content {get; private set;}
    public int Likes {get; private set;}
    public List<Comment> Comments;

    public Post(string title, string content, int likes, DateTime date)
    {
        Title = title;
        Content = content;
        Likes = likes;
        Moment = date;
        Comments = new List<Comment>();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(Title);
        sb.AppendLine($"{Likes} Likes - {Moment}");
        sb.AppendLine(Content);

        foreach (var comment in Comments)
            sb.AppendLine(comment.Text);

        return sb.ToString();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        Comments.Remove(comment);
    }
}