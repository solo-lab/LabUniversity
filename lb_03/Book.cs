namespace lb_03;

public class Book
{
    private Title title;
    private Author author;
    private Content content;
    
    public Book(string title)
    {
        this.title = new Title(title);
        this.author = null;
        this.content = null;
    }
    
    public Author Author
    {
        get { return author; }
        set { author = value; }
    }
    
    public Content Content
    {
        get { return content; }
        set { content = value; }
    }
    
    public void Show()
    {
        title.Show();
        if (author != null)
        {
            author.Show();
        }
        if (content != null)
        {
            content.Show();
        }
    }
}