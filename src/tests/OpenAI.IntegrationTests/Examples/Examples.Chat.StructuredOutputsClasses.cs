namespace OpenAI.IntegrationTests.Examples;

// # START EXAMPLE #

public class MathReasoning
{
    public MathReasoningStep[] Steps { get; set; } = [];
    public string FinalAnswer { get; set; } = string.Empty;
}

public class MathReasoningStep
{
    public string Explanation { get; set; } = string.Empty;
    public string Output { get; set; } = string.Empty;
}