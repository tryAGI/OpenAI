
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.usage.decisions.result
    /// </summary>
    public enum DecisionsUsageResultObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationUsageDecisionsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsUsageResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsUsageResultObject value)
        {
            return value switch
            {
                DecisionsUsageResultObject.OrganizationUsageDecisionsResult => "organization.usage.decisions.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsUsageResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.decisions.result" => DecisionsUsageResultObject.OrganizationUsageDecisionsResult,
                _ => null,
            };
        }
    }
}