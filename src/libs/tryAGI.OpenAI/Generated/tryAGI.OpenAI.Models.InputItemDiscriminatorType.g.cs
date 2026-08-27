
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum InputItemDiscriminatorType
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
    public static class InputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputItemDiscriminatorType value)
        {
            return value switch
            {
                InputItemDiscriminatorType.CompactionTrigger => "compaction_trigger",
                InputItemDiscriminatorType.Message => "message",
                InputItemDiscriminatorType.Program => "program",
                InputItemDiscriminatorType.ProgramOutput => "program_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_trigger" => InputItemDiscriminatorType.CompactionTrigger,
                "message" => InputItemDiscriminatorType.Message,
                "program" => InputItemDiscriminatorType.Program,
                "program_output" => InputItemDiscriminatorType.ProgramOutput,
                _ => null,
            };
        }
    }
}