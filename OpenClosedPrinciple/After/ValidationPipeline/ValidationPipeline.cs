namespace OpenClosedPrinciple.After.ValidationPipeline;

internal class ValidationPipeline<T>
{
    private readonly IEnumerable<IValidationPipelineStep<T>> _steps;

    public ValidationPipeline(IEnumerable<IValidationPipelineStep<T>> steps)
    {
        _steps = steps;
    }

    public (bool, string) Execute(T input)
    {
        foreach (var step in _steps)
        {
            var result = step.Execute(input);
            if (!result.isValid)
            {
                return result;
            }
        }
        return (true, string.Empty);
    }
}
