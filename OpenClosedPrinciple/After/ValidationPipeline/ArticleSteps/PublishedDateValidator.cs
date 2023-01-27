namespace OpenClosedPrinciple.After.ValidationPipeline.ArticleSteps;

internal class PublishedDateValidator : IValidationPipelineStep<Article>
{
    public (bool, string) Execute(Article article)
    {
        if (article.PublishedDate.Year < DateTime.UtcNow.Year - 1)
            return new(false, $"Article published from more than year");

        return (true, string.Empty);
    }
}
