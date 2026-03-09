
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Base timestamp used to calculate expiration. Currently fixed to `created_at`.<br/>
    /// Default Value: created_at
    /// </summary>
    public enum ExpiresAfterParamAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpiresAfterParamAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpiresAfterParamAnchor value)
        {
            return value switch
            {
                ExpiresAfterParamAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpiresAfterParamAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ExpiresAfterParamAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}