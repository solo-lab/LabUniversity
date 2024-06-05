namespace lb_03;

public class Author
{
    private string author;
    
    public Author(string author)
    {
        this.author = author;
    }
    
    public string AuthorName
    {
        get { return author; }
        set { author = value; }
    }
    
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(author);
        Console.ResetColor();
    }
}