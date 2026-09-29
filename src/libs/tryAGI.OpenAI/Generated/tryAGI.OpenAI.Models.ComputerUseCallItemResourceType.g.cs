
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `computer_use_call`.<br/>
    /// Default Value: computer_use_call
    /// </summary>
    public enum ComputerUseCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerUseCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseCallItemResourceType value)
        {
            return value switch
            {
                ComputerUseCallItemResourceType.ComputerUseCall => "computer_use_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_call" => ComputerUseCallItemResourceType.ComputerUseCall,
                _ => null,
            };
        }
    }
}