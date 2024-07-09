namespace Course.Entities;
class Comment
{
    public string? Text {get; private set;}

    public Comment(string text)
    {
        Text = text;
    }
}