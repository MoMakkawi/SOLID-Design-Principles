using OpenClosedPrinciple.After.ValidationPipeline.ArticleSteps;

namespace OpenClosedPrinciple.After.ValidationPipeline;

internal class ArticleValidator
{
    private readonly ValidationPipeline<Article> _validationPipeline;

    public ArticleValidator()
    {
        var steps = new IValidationPipelineStep<Article>[]
        {
            new AuthorValidator(),
            new TitleValidator(),
            new BodyValidator(),
            new PublishedDateValidator()
        };

        _validationPipeline =  new ValidationPipeline<Article>(steps);


    }

    public (bool IsValid, string msg) ValidateInput(Article input) 
        => _validationPipeline.Execute(input);
}
