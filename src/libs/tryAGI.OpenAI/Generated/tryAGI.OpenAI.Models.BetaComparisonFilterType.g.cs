
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
    public enum BetaComparisonFilterType
    {
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Eq,
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
        In,
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
        Ne,
        /// <summary>
        /// `eq`, `ne`, `gt`, `gte`, `lt`, `lte`, `in`, `nin`.
        /// </summary>
        Nin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComparisonFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComparisonFilterType value)
        {
            return value switch
            {
                BetaComparisonFilterType.Eq => "eq",
                BetaComparisonFilterType.Gt => "gt",
                BetaComparisonFilterType.Gte => "gte",
                BetaComparisonFilterType.In => "in",
                BetaComparisonFilterType.Lt => "lt",
                BetaComparisonFilterType.Lte => "lte",
                BetaComparisonFilterType.Ne => "ne",
                BetaComparisonFilterType.Nin => "nin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComparisonFilterType? ToEnum(string value)
        {
            return value switch
            {
                "eq" => BetaComparisonFilterType.Eq,
                "gt" => BetaComparisonFilterType.Gt,
                "gte" => BetaComparisonFilterType.Gte,
                "in" => BetaComparisonFilterType.In,
                "lt" => BetaComparisonFilterType.Lt,
                "lte" => BetaComparisonFilterType.Lte,
                "ne" => BetaComparisonFilterType.Ne,
                "nin" => BetaComparisonFilterType.Nin,
                _ => null,
            };
        }
    }
}