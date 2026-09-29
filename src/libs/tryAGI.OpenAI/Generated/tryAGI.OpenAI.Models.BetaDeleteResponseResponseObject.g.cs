
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: response.deleted
    /// </summary>
    public enum BetaDeleteResponseResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        ResponseDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDeleteResponseResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDeleteResponseResponseObject value)
        {
            return value switch
            {
                BetaDeleteResponseResponseObject.ResponseDeleted => "response.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDeleteResponseResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "response.deleted" => BetaDeleteResponseResponseObject.ResponseDeleted,
                _ => null,
            };
        }
    }
}