using System.Runtime.CompilerServices;

namespace tryAGI.OpenAI.IntegrationTests;

public sealed class TestMethodAttribute : Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute
{
    public TestMethodAttribute(
        [CallerFilePath] string? declaringFilePath = null,
        [CallerLineNumber] int declaringLineNumber = 0)
        : base(declaringFilePath, declaringLineNumber)
    {
    }

    public override async Task<TestResult[]> ExecuteAsync(ITestMethod testMethod)
    {
        var results = await base.ExecuteAsync(testMethod).ConfigureAwait(false);

        foreach (var result in results)
        {
            if (result.Outcome != UnitTestOutcome.Failed ||
                result.TestFailureException is not { } exception ||
                !IsOpenAiAvailabilityIssue(exception))
            {
                continue;
            }

            result.Outcome = UnitTestOutcome.Inconclusive;
            result.TestFailureException = new AssertInconclusiveException(
                "OpenAI account quota, billing, or rate-limit availability blocked this live integration test.",
                exception);
        }

        return results;
    }

    private static bool IsOpenAiAvailabilityIssue(Exception exception)
    {
        foreach (var current in Flatten(exception))
        {
            if (current is not ApiException apiException)
            {
                continue;
            }

            var responseText = apiException.ResponseBody ?? apiException.Message;
            if (apiException.StatusCode == System.Net.HttpStatusCode.TooManyRequests ||
                responseText.Contains("insufficient_quota", StringComparison.OrdinalIgnoreCase) ||
                responseText.Contains("billing_hard_limit_reached", StringComparison.OrdinalIgnoreCase) ||
                responseText.Contains("billing hard limit", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    private static IEnumerable<Exception> Flatten(Exception exception)
    {
        yield return exception;

        if (exception is AggregateException aggregateException)
        {
            foreach (var innerException in aggregateException.InnerExceptions)
            {
                foreach (var flattenedException in Flatten(innerException))
                {
                    yield return flattenedException;
                }
            }
        }
        else if (exception.InnerException is { } innerException)
        {
            foreach (var flattenedException in Flatten(innerException))
            {
                yield return flattenedException;
            }
        }
    }
}
