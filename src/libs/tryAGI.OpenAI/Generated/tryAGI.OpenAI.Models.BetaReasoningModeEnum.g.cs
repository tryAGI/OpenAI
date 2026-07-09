#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaReasoningModeEnum : global::System.IEquatable<BetaReasoningModeEnum>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaReasoningModeEnumVariant1 { get; init; }
#else
        public string? BetaReasoningModeEnumVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaReasoningModeEnumVariant1))]
#endif
        public bool IsBetaReasoningModeEnumVariant1 => BetaReasoningModeEnumVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaReasoningModeEnumVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaReasoningModeEnumVariant1;
            return IsBetaReasoningModeEnumVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickBetaReasoningModeEnumVariant1() => IsBetaReasoningModeEnumVariant1
            ? BetaReasoningModeEnumVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaReasoningModeEnumVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? BetaReasoningModeEnumEnum { get; init; }
#else
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? BetaReasoningModeEnumEnum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaReasoningModeEnumEnum))]
#endif
        public bool IsBetaReasoningModeEnumEnum => BetaReasoningModeEnumEnum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaReasoningModeEnumEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? value)
        {
            value = BetaReasoningModeEnumEnum;
            return IsBetaReasoningModeEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningModeEnumEnum PickBetaReasoningModeEnumEnum() => IsBetaReasoningModeEnumEnum
            ? BetaReasoningModeEnumEnum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaReasoningModeEnumEnum' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaReasoningModeEnum(string value) => new BetaReasoningModeEnum((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BetaReasoningModeEnum @this) => @this.BetaReasoningModeEnumVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BetaReasoningModeEnum(string? value)
        {
            BetaReasoningModeEnumVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaReasoningModeEnum FromBetaReasoningModeEnumVariant1(string? value) => new BetaReasoningModeEnum(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaReasoningModeEnum(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum value) => new BetaReasoningModeEnum((global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?(BetaReasoningModeEnum @this) => @this.BetaReasoningModeEnumEnum;

        /// <summary>
        /// 
        /// </summary>
        public BetaReasoningModeEnum(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? value)
        {
            BetaReasoningModeEnumEnum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaReasoningModeEnum FromBetaReasoningModeEnumEnum(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? value) => new BetaReasoningModeEnum(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaReasoningModeEnum(
            string? betaReasoningModeEnumVariant1,
            global::tryAGI.OpenAI.BetaReasoningModeEnumEnum? betaReasoningModeEnumEnum
            )
        {
            BetaReasoningModeEnumVariant1 = betaReasoningModeEnumVariant1;
            BetaReasoningModeEnumEnum = betaReasoningModeEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaReasoningModeEnumEnum as object ??
            BetaReasoningModeEnumVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BetaReasoningModeEnumVariant1?.ToString() ??
            BetaReasoningModeEnumEnum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBetaReasoningModeEnumVariant1 || IsBetaReasoningModeEnumEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaReasoningModeEnumVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?, TResult>? betaReasoningModeEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaReasoningModeEnumVariant1 && betaReasoningModeEnumVariant1 != null)
            {
                return betaReasoningModeEnumVariant1(BetaReasoningModeEnumVariant1!);
            }
            else if (IsBetaReasoningModeEnumEnum && betaReasoningModeEnumEnum != null)
            {
                return betaReasoningModeEnumEnum(BetaReasoningModeEnumEnum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? betaReasoningModeEnumVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?>? betaReasoningModeEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaReasoningModeEnumVariant1)
            {
                betaReasoningModeEnumVariant1?.Invoke(BetaReasoningModeEnumVariant1!);
            }
            else if (IsBetaReasoningModeEnumEnum)
            {
                betaReasoningModeEnumEnum?.Invoke(BetaReasoningModeEnumEnum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaReasoningModeEnumVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?>? betaReasoningModeEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaReasoningModeEnumVariant1)
            {
                betaReasoningModeEnumVariant1?.Invoke(BetaReasoningModeEnumVariant1!);
            }
            else if (IsBetaReasoningModeEnumEnum)
            {
                betaReasoningModeEnumEnum?.Invoke(BetaReasoningModeEnumEnum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaReasoningModeEnumVariant1,
                typeof(string),
                BetaReasoningModeEnumEnum,
                typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum),
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
        public bool Equals(BetaReasoningModeEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaReasoningModeEnumVariant1, other.BetaReasoningModeEnumVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?>.Default.Equals(BetaReasoningModeEnumEnum, other.BetaReasoningModeEnumEnum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaReasoningModeEnum obj1, BetaReasoningModeEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaReasoningModeEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaReasoningModeEnum obj1, BetaReasoningModeEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaReasoningModeEnum o && Equals(o);
        }
    }
}
