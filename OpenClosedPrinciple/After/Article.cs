using OpenClosedPrinciple.After.ValidationPipeline;

namespace OpenClosedPrinciple.After;

internal sealed class Article
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Body { get; set; }
    public DateTime PublishedDate { get; set; }

    public Article(string title, string author, string body, DateTime publishedDate)
    {
        Title = title;
        Author = author;
        Body = body;
        PublishedDate = publishedDate;

        var (IsValid, msg) = new ArticleValidator().ValidateInput(this);
        this.IsValid = IsValid;
        this.msg = msg;
        
    }
    public readonly bool IsValid;
    public readonly string? msg;

}
