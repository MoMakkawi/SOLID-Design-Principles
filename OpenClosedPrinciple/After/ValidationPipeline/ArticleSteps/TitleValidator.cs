namespace OpenClosedPrinciple.After.ValidationPipeline.ArticleSteps;

internal class TitleValidator : IValidationPipelineStep<Article>
{
    public (bool, string) Execute(Article article)
    {
        if (article.Title is null)
            return (false, $"{nameof(article.Title)} null ...");
        if (article.Title.Length < 3)
            return (false, $"{nameof(article.Title)} Length less than 3 ...");
        if (article.Title.Length > 100)
            return (false, $"{nameof(article.Title)} bigger than 100 ...");

        return(true,string.Empty);
    }
}
