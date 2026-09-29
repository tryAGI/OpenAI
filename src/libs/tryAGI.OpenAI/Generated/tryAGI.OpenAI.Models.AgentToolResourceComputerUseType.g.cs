
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `computer_use`.<br/>
    /// Default Value: computer_use
    /// </summary>
    public enum AgentToolResourceComputerUseType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResourceComputerUseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResourceComputerUseType value)
        {
            return value switch
            {
                AgentToolResourceComputerUseType.ComputerUse => "computer_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResourceComputerUseType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use" => AgentToolResourceComputerUseType.ComputerUse,
                _ => null,
            };
        }
    }
}