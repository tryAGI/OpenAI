#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SpendLimitEnforcementStatus : global::System.IEquatable<SpendLimitEnforcementStatus>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SpendLimitEnforcementStatusVariant1 { get; init; }
#else
        public string? SpendLimitEnforcementStatusVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpendLimitEnforcementStatusVariant1))]
#endif
        public bool IsSpendLimitEnforcementStatusVariant1 => SpendLimitEnforcementStatusVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpendLimitEnforcementStatusVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = SpendLimitEnforcementStatusVariant1;
            return IsSpendLimitEnforcementStatusVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickSpendLimitEnforcementStatusVariant1() => IsSpendLimitEnforcementStatusVariant1
            ? SpendLimitEnforcementStatusVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpendLimitEnforcementStatusVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpendLimitEnforcementStatus(string value) => new SpendLimitEnforcementStatus((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(SpendLimitEnforcementStatus @this) => @this.SpendLimitEnforcementStatusVariant1;

        /// <summary>
        ///
        /// </summary>
        public SpendLimitEnforcementStatus(string? value)
        {
            SpendLimitEnforcementStatusVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpendLimitEnforcementStatus FromSpendLimitEnforcementStatusVariant1(string? value) => new SpendLimitEnforcementStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpendLimitEnforcementStatus(global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum value) => new SpendLimitEnforcementStatus((global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum?(SpendLimitEnforcementStatus @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public SpendLimitEnforcementStatus(global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpendLimitEnforcementStatus FromEnum(global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? value) => new SpendLimitEnforcementStatus(value);

        /// <summary>
        ///
        /// </summary>
        public SpendLimitEnforcementStatus(
            string? spendLimitEnforcementStatusVariant1,
            global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum? @enum
            )
        {
            SpendLimitEnforcementStatusVariant1 = spendLimitEnforcementStatusVariant1;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            SpendLimitEnforcementStatusVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SpendLimitEnforcementStatusVariant1?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSpendLimitEnforcementStatusVariant1 || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? spendLimitEnforcementStatusVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitEnforcementStatusVariant1 && spendLimitEnforcementStatusVariant1 != null)
            {
                return spendLimitEnforcementStatusVariant1(SpendLimitEnforcementStatusVariant1!);
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
            global::System.Action<string>? spendLimitEnforcementStatusVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitEnforcementStatusVariant1)
            {
                spendLimitEnforcementStatusVariant1?.Invoke(SpendLimitEnforcementStatusVariant1!);
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
            global::System.Action<string>? spendLimitEnforcementStatusVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitEnforcementStatusVariant1)
            {
                spendLimitEnforcementStatusVariant1?.Invoke(SpendLimitEnforcementStatusVariant1!);
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
                SpendLimitEnforcementStatusVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum),
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
        public bool Equals(SpendLimitEnforcementStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SpendLimitEnforcementStatusVariant1, other.SpendLimitEnforcementStatusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpendLimitEnforcementStatusEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpendLimitEnforcementStatus obj1, SpendLimitEnforcementStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpendLimitEnforcementStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpendLimitEnforcementStatus obj1, SpendLimitEnforcementStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpendLimitEnforcementStatus o && Equals(o);
        }
    }
}
