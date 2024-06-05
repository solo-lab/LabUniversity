namespace lb_03;

public class Content
{
    private string content;
    
    public Content(string content)
    {
        this.content = content;
    }
    
    public string ContentText
    {
        get { return content; }
        set { content = value; }
    }
    
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(content);
        Console.ResetColor();
    }
}