
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls whether OpenAI automatically creates an implicit cache breakpoint. Defaults to `implicit`. With `implicit`, OpenAI creates one implicit breakpoint and writes up to the latest three explicit breakpoints in the request. With `explicit`, OpenAI does not create an implicit breakpoint and writes up to the latest four explicit breakpoints. If there are no explicit breakpoints, the request does not use prompt caching.
    /// </summary>
    public enum DecisionRequestPromptCacheOptionsMode
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        Implicit,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionRequestPromptCacheOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionRequestPromptCacheOptionsMode value)
        {
            return value switch
            {
                DecisionRequestPromptCacheOptionsMode.Explicit => "explicit",
                DecisionRequestPromptCacheOptionsMode.Implicit => "implicit",
                DecisionRequestPromptCacheOptionsMode.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionRequestPromptCacheOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => DecisionRequestPromptCacheOptionsMode.Explicit,
                "implicit" => DecisionRequestPromptCacheOptionsMode.Implicit,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => DecisionRequestPromptCacheOptionsMode.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}