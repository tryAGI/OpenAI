
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAutomationParamsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Once,
        /// <summary>
        ///
        /// </summary>
        Periodic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAutomationParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAutomationParamsDiscriminatorType value)
        {
            return value switch
            {
                CreateAutomationParamsDiscriminatorType.Once => "once",
                CreateAutomationParamsDiscriminatorType.Periodic => "periodic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAutomationParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "once" => CreateAutomationParamsDiscriminatorType.Once,
                "periodic" => CreateAutomationParamsDiscriminatorType.Periodic,
                _ => null,
            };
        }
    }
}