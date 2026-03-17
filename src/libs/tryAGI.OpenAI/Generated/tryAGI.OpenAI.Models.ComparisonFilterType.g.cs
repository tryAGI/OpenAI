
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the comparison operator: `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.<br/>
    /// - `eq`: equals<br/>
    /// - `ne`: not equal<br/>
    /// - `gt`: greater than<br/>
    /// - `gte`: greater than or equal<br/>
    /// - `lt`: less than<br/>
    /// - `lte`: less than or equal<br/>
    /// - `in`: in<br/>
    /// - `nin`: not in<br/>
    /// Default Value: eq
    /// </summary>
    public enum ComparisonFilterType
    {
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Eq,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Ne,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Gt,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Gte,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Lt,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Lte,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        In,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Nin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComparisonFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComparisonFilterType value)
        {
            return value switch
            {
                ComparisonFilterType.Eq => "eq",
                ComparisonFilterType.Ne => "ne",
                ComparisonFilterType.Gt => "gt",
                ComparisonFilterType.Gte => "gte",
                ComparisonFilterType.Lt => "lt",
                ComparisonFilterType.Lte => "lte",
                ComparisonFilterType.In => "in",
                ComparisonFilterType.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComparisonFilterType? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ComparisonFilterType.Eq,
                "ne" => ComparisonFilterType.Ne,
                "gt" => ComparisonFilterType.Gt,
                "gte" => ComparisonFilterType.Gte,
                "lt" => ComparisonFilterType.Lt,
                "lte" => ComparisonFilterType.Lte,
                "in" => ComparisonFilterType.In,
                "nin" => ComparisonFilterType.Nin,
                _ => null,
            };
        }
    }
}