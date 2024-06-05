namespace lb_03;

public class Title
{
    private string title;
    
    public Title(string title)
    {
        this.title = title;
    }
    
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(title);
        Console.ResetColor();
    }
}