#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SpendLimitCurrency : global::System.IEquatable<SpendLimitCurrency>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SpendLimitCurrencyVariant1 { get; init; }
#else
        public string? SpendLimitCurrencyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpendLimitCurrencyVariant1))]
#endif
        public bool IsSpendLimitCurrencyVariant1 => SpendLimitCurrencyVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpendLimitCurrencyVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = SpendLimitCurrencyVariant1;
            return IsSpendLimitCurrencyVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickSpendLimitCurrencyVariant1() => IsSpendLimitCurrencyVariant1
            ? SpendLimitCurrencyVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpendLimitCurrencyVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.SpendLimitCurrencyEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.SpendLimitCurrencyEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpendLimitCurrency(string value) => new SpendLimitCurrency((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(SpendLimitCurrency @this) => @this.SpendLimitCurrencyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SpendLimitCurrency(string? value)
        {
            SpendLimitCurrencyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpendLimitCurrency FromSpendLimitCurrencyVariant1(string? value) => new SpendLimitCurrency(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpendLimitCurrency(global::tryAGI.OpenAI.SpendLimitCurrencyEnum value) => new SpendLimitCurrency((global::tryAGI.OpenAI.SpendLimitCurrencyEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpendLimitCurrencyEnum?(SpendLimitCurrency @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public SpendLimitCurrency(global::tryAGI.OpenAI.SpendLimitCurrencyEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SpendLimitCurrency FromEnum(global::tryAGI.OpenAI.SpendLimitCurrencyEnum? value) => new SpendLimitCurrency(value);

        /// <summary>
        /// 
        /// </summary>
        public SpendLimitCurrency(
            string? spendLimitCurrencyVariant1,
            global::tryAGI.OpenAI.SpendLimitCurrencyEnum? @enum
            )
        {
            SpendLimitCurrencyVariant1 = spendLimitCurrencyVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            SpendLimitCurrencyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpendLimitCurrencyVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpendLimitCurrencyVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? spendLimitCurrencyVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.SpendLimitCurrencyEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitCurrencyVariant1 && spendLimitCurrencyVariant1 != null)
            {
                return spendLimitCurrencyVariant1(SpendLimitCurrencyVariant1!);
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
            global::System.Action<string>? spendLimitCurrencyVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.SpendLimitCurrencyEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitCurrencyVariant1)
            {
                spendLimitCurrencyVariant1?.Invoke(SpendLimitCurrencyVariant1!);
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
            global::System.Action<string>? spendLimitCurrencyVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.SpendLimitCurrencyEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpendLimitCurrencyVariant1)
            {
                spendLimitCurrencyVariant1?.Invoke(SpendLimitCurrencyVariant1!);
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
                SpendLimitCurrencyVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.SpendLimitCurrencyEnum),
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
        public bool Equals(SpendLimitCurrency other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SpendLimitCurrencyVariant1, other.SpendLimitCurrencyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpendLimitCurrencyEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SpendLimitCurrency obj1, SpendLimitCurrency obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpendLimitCurrency>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SpendLimitCurrency obj1, SpendLimitCurrency obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpendLimitCurrency o && Equals(o);
        }
    }
}
