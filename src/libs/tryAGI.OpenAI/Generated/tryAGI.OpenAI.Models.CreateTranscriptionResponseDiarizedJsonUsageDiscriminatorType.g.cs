
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType value)
        {
            return value switch
            {
                CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType.Duration => "duration",
                CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "duration" => CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType.Duration,
                "tokens" => CreateTranscriptionResponseDiarizedJsonUsageDiscriminatorType.Tokens,
                _ => null,
            };
        }
    }
}