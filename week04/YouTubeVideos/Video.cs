using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author,int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name,text);
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public void ShowVideo()
    {
        Console.WriteLine($"""
        __________________________________________
        Title : {_title}
        Author : {_author}
        Length : {_length} seconds

        {NumberOfComments()} COMMENTS :
        """);
        foreach(Comment comment in comments)
        {
            comment.ShowComment();
        }
        Console.WriteLine("__________________________________________");

    }
}