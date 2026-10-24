
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `periodic`.<br/>
    /// Default Value: periodic
    /// </summary>
    public enum CreateAutomationParamsPeriodicType
    {
        /// <summary>
        ///
        /// </summary>
        Periodic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAutomationParamsPeriodicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAutomationParamsPeriodicType value)
        {
            return value switch
            {
                CreateAutomationParamsPeriodicType.Periodic => "periodic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAutomationParamsPeriodicType? ToEnum(string value)
        {
            return value switch
            {
                "periodic" => CreateAutomationParamsPeriodicType.Periodic,
                _ => null,
            };
        }
    }
}