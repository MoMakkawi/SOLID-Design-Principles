
namespace OpenClosedPrinciple.After.ValidationPipeline.ArticleSteps;

internal class BodyValidator : IValidationPipelineStep<Article>
{
    public (bool, string) Execute(Article article)
    {
        if (article.Body is null)
            return (false, $"{nameof(article.Body)} null ...");
        if (!article.Body.Any())
            return (false, $"{nameof(article.Body)} empty ...");
        if (article.Body.Length < 20)
            return (false, $"{nameof(article.Body)} Length less than 20 ...");

        return (true, string.Empty);
    }
}
