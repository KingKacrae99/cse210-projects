public class Comment{
    public string _userName;
    public string _text;

    public Comment(string name, string text){
        _userName = name;
        _text = text;
    }

    public void DisplayComment(){
        Console.WriteLine($"{_userName}: '{_text}'");
    }
}