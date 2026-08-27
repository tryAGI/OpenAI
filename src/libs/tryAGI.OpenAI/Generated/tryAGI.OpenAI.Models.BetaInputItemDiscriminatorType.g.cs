
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CompactionTrigger,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Program,
        /// <summary>
        ///
        /// </summary>
        ProgramOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputItemDiscriminatorType value)
        {
            return value switch
            {
                BetaInputItemDiscriminatorType.CompactionTrigger => "compaction_trigger",
                BetaInputItemDiscriminatorType.Message => "message",
                BetaInputItemDiscriminatorType.Program => "program",
                BetaInputItemDiscriminatorType.ProgramOutput => "program_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_trigger" => BetaInputItemDiscriminatorType.CompactionTrigger,
                "message" => BetaInputItemDiscriminatorType.Message,
                "program" => BetaInputItemDiscriminatorType.Program,
                "program_output" => BetaInputItemDiscriminatorType.ProgramOutput,
                _ => null,
            };
        }
    }
}