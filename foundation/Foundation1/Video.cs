using System.Runtime.InteropServices.Marshalling;

public class Video
{
    private string _title;
    private string _author;
    private int _lengh;

    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengh)
    {
        _title = title;
        _author = author;
        _lengh = lengh;
    }

    public int GetCommentsQty()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string DisplayVideo()
    {
        return $"{_title}, by {_author}. Duration: {_lengh}seg.";
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
    }
}