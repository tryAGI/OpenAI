
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `multi`.<br/>
    /// Default Value: multi
    /// </summary>
    public enum GraderMultiType
    {
        /// <summary>
        /// 
        /// </summary>
        Multi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderMultiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderMultiType value)
        {
            return value switch
            {
                GraderMultiType.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderMultiType? ToEnum(string value)
        {
            return value switch
            {
                "multi" => GraderMultiType.Multi,
                _ => null,
            };
        }
    }
}