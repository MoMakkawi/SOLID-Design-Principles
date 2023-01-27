namespace OpenClosedPrinciple.After.ValidationPipeline.ArticleSteps;

internal class AuthorValidator : IValidationPipelineStep<Article>
{
    public (bool, string) Execute(Article article)
    {
        if (article.Author is null)
            return (false, $"{nameof(article.Author)} null ...");
        if (!article.Author.Any())
            return (false, $"{nameof(article.Author)} empty ...");
        if (article.Title.Length < 3)
            return (false, $"{nameof(article.Author)} Length less than 3 ...");

        return (true, string.Empty);
    }
}
