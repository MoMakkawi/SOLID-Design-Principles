namespace OpenClosedPrinciple.Before;

internal sealed class Article
{
    private string? _title;

    public string? Title
    {
        get { return _title; }
        set 
        {
            if(value.Length < 3)
                throw new ArgumentException($"{nameof(Title)} length less than 3");
            if(value.Length > 100)
                throw new ArgumentException($"{nameof(Title)} length greter than 100");

            _title = value;
        }
    }

    private string? _author;

    public string? Author
    {
        get { return _author; }
        set 
        {
            if(value is null)
                throw new ArgumentNullException($"{nameof(Author)} null");
            if(!value.Any())
                throw new ArgumentException($"{nameof(Author)} empty");
            if(value.Length < 3)
                throw new ArgumentException($"{nameof(Author)} length less than 3");

            _author = value; 
        }
    }

    private string? body;

    public string? Body
    {
        get { return body; }
        set 
        {
            if (value is null)
                throw new ArgumentNullException($"{nameof(Body)} null");
            if (!value.Any())
                throw new ArgumentException($"{nameof(Body)} empty");
            if (value.Length < 20)
                throw new ArgumentException($"{nameof(Body)} length less than 20");

            body = value; 
        }
    }

    private DateTime publishedDate;

    public DateTime PublishedDate
    {
        get { return publishedDate; }
        set 
        {
            if (value.Year < DateTime.Now.Year -1 )
                throw new ArgumentException($"{Title} article puplished from more than year");

            publishedDate = value; 
        }
    }



    public Article(string title, string author, string body, DateTime publishedDate)
    {
        Title = title;
        Author = author;
        Body = body;
        PublishedDate = publishedDate;
    }
}
