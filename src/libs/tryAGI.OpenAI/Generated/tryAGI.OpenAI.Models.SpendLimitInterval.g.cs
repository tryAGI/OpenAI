#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SpendLimitInterval : global::System.IEquatable<SpendLimitInterval>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SpendLimitIntervalVariant1 { get; init; }
#else
        public string? SpendLimitIntervalVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpendLimitIntervalVariant1))]
#endif
        public bool IsSpendLimitIntervalVariant1 => SpendLimitIntervalVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpendLimitIntervalVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = SpendLimitIntervalVariant1;
            return IsSpendLimitIntervalVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickSpendLimitIntervalVariant1() => IsSpendLimitIntervalVariant1
            ? SpendLimitIntervalVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpendLimitIntervalVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum? Enum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SpendLimitIntervalEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitIntervalEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpendLimitInterval(string value) => new SpendLimitInterval((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(SpendLimitInterval @this) => @this.SpendLimitIntervalVariant1;

        /// <summary>
        ///
        /// </summary>
        public SpendLimitInterval(string? value)
        {
            SpendLimitIntervalVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpendLimitInterval FromSpendLimitIntervalVariant1(string? value) => new SpendLimitInterval(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpendLimitInterval(global::tryAGI.OpenAI.SpendLimitIntervalEnum value) => new SpendLimitInterval((global::tryAGI.OpenAI.SpendLimitIntervalEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpendLimitIntervalEnum?(SpendLimitInterval @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public SpendLimitInterval(global::tryAGI.OpenAI.SpendLimitIntervalEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpendLimitInterval FromEnum(global::tryAGI.OpenAI.SpendLimitIntervalEnum? value) => new SpendLimitInterval(value);

        /// <summary>
        ///
        /// </summary>
        public SpendLimitInterval(
            string? spendLimitIntervalVariant1,
            global::tryAGI.OpenAI.SpendLimitIntervalEnum? @enum
            )
        {
            SpendLimitIntervalVariant1 = spendLimitIntervalVariant1;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            SpendLimitIntervalVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SpendLimitIntervalVariant1?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSpendLimitIntervalVariant1 || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? spendLimitIntervalVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.SpendLimitIntervalEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitIntervalVariant1 && spendLimitIntervalVariant1 != null)
            {
                return spendLimitIntervalVariant1(SpendLimitIntervalVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? spendLimitIntervalVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.SpendLimitIntervalEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitIntervalVariant1)
            {
                spendLimitIntervalVariant1?.Invoke(SpendLimitIntervalVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? spendLimitIntervalVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.SpendLimitIntervalEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitIntervalVariant1)
            {
                spendLimitIntervalVariant1?.Invoke(SpendLimitIntervalVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpendLimitIntervalVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.SpendLimitIntervalEnum),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SpendLimitInterval other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SpendLimitIntervalVariant1, other.SpendLimitIntervalVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpendLimitIntervalEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpendLimitInterval obj1, SpendLimitInterval obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpendLimitInterval>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpendLimitInterval obj1, SpendLimitInterval obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpendLimitInterval o && Equals(o);
        }
    }
}
