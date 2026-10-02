
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CostsResultApiSource
    {
        /// <summary>
        ///
        /// </summary>
        AgentsApi,
        /// <summary>
        ///
        /// </summary>
        Unlabeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CostsResultApiSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CostsResultApiSource value)
        {
            return value switch
            {
                CostsResultApiSource.AgentsApi => "agents_api",
                CostsResultApiSource.Unlabeled => "unlabeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CostsResultApiSource? ToEnum(string value)
        {
            return value switch
            {
                "agents_api" => CostsResultApiSource.AgentsApi,
                "unlabeled" => CostsResultApiSource.Unlabeled,
                _ => null,
            };
        }
    }
}