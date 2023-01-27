namespace OpenClosedPrinciple.After.ValidationPipeline;

internal interface IValidationPipelineStep<T>
{
    (bool isValid,string msg) Execute(T input);
}
