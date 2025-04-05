public class Video{
    public string _title;
    public string _author;
    public int _lenght;
    public List<Comment> comments;

    public Video(string author, string title, int lenght){
        _author = author;
        _title = title;
        _lenght = lenght;
        comments = new List<Comment>();
    }

    public int TotalComments(){
        return comments.Count;
    }
    public void AddComment(string name, string text){
        Comment comment = new Comment(name,text);
        comments.Add(comment);
    }
    public void DisplayVideoDetails(){
        Console.WriteLine($"Title:{_title}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"Duration:{_lenght} seconds");
        Console.WriteLine($"comments({TotalComments()}):");
        
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }

    }
}