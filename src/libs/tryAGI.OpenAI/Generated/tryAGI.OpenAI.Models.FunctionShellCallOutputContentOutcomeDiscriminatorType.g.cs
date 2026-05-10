
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellCallOutputContentOutcomeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputContentOutcomeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputContentOutcomeDiscriminatorType value)
        {
            return value switch
            {
                FunctionShellCallOutputContentOutcomeDiscriminatorType.Exit => "exit",
                FunctionShellCallOutputContentOutcomeDiscriminatorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputContentOutcomeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exit" => FunctionShellCallOutputContentOutcomeDiscriminatorType.Exit,
                "timeout" => FunctionShellCallOutputContentOutcomeDiscriminatorType.Timeout,
                _ => null,
            };
        }
    }
}