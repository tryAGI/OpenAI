
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the session snapshot. Always `active`, including the final snapshot in session.closed; use the event type to determine that the session has closed.<br/>
    /// Default Value: active
    /// </summary>
    public enum LiveSessionResourceParamStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionResourceParamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionResourceParamStatus value)
        {
            return value switch
            {
                LiveSessionResourceParamStatus.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionResourceParamStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => LiveSessionResourceParamStatus.Active,
                _ => null,
            };
        }
    }
}