#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaPersonalityEnum : global::System.IEquatable<BetaPersonalityEnum>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaPersonalityEnumVariant1 { get; init; }
#else
        public string? BetaPersonalityEnumVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaPersonalityEnumVariant1))]
#endif
        public bool IsBetaPersonalityEnumVariant1 => BetaPersonalityEnumVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaPersonalityEnumVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaPersonalityEnumVariant1;
            return IsBetaPersonalityEnumVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaPersonalityEnumVariant1() => IsBetaPersonalityEnumVariant1
            ? BetaPersonalityEnumVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaPersonalityEnumVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? BetaPersonalityEnumEnum { get; init; }
#else
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum? BetaPersonalityEnumEnum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaPersonalityEnumEnum))]
#endif
        public bool IsBetaPersonalityEnumEnum => BetaPersonalityEnumEnum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaPersonalityEnumEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaPersonalityEnumEnum? value)
        {
            value = BetaPersonalityEnumEnum;
            return IsBetaPersonalityEnumEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPersonalityEnumEnum PickBetaPersonalityEnumEnum() => IsBetaPersonalityEnumEnum
            ? BetaPersonalityEnumEnum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaPersonalityEnumEnum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaPersonalityEnum(string value) => new BetaPersonalityEnum((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaPersonalityEnum @this) => @this.BetaPersonalityEnumVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaPersonalityEnum(string? value)
        {
            BetaPersonalityEnumVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaPersonalityEnum FromBetaPersonalityEnumVariant1(string? value) => new BetaPersonalityEnum(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaPersonalityEnum(global::tryAGI.OpenAI.BetaPersonalityEnumEnum value) => new BetaPersonalityEnum((global::tryAGI.OpenAI.BetaPersonalityEnumEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaPersonalityEnumEnum?(BetaPersonalityEnum @this) => @this.BetaPersonalityEnumEnum;

        /// <summary>
        ///
        /// </summary>
        public BetaPersonalityEnum(global::tryAGI.OpenAI.BetaPersonalityEnumEnum? value)
        {
            BetaPersonalityEnumEnum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaPersonalityEnum FromBetaPersonalityEnumEnum(global::tryAGI.OpenAI.BetaPersonalityEnumEnum? value) => new BetaPersonalityEnum(value);

        /// <summary>
        ///
        /// </summary>
        public BetaPersonalityEnum(
            string? betaPersonalityEnumVariant1,
            global::tryAGI.OpenAI.BetaPersonalityEnumEnum? betaPersonalityEnumEnum
            )
        {
            BetaPersonalityEnumVariant1 = betaPersonalityEnumVariant1;
            BetaPersonalityEnumEnum = betaPersonalityEnumEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaPersonalityEnumEnum as object ??
            BetaPersonalityEnumVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaPersonalityEnumVariant1?.ToString() ??
            BetaPersonalityEnumEnum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaPersonalityEnumVariant1 || IsBetaPersonalityEnumEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaPersonalityEnumVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaPersonalityEnumEnum?, TResult>? betaPersonalityEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaPersonalityEnumVariant1 && betaPersonalityEnumVariant1 != null)
            {
                return betaPersonalityEnumVariant1(BetaPersonalityEnumVariant1!);
            }
            else if (IsBetaPersonalityEnumEnum && betaPersonalityEnumEnum != null)
            {
                return betaPersonalityEnumEnum(BetaPersonalityEnumEnum!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaPersonalityEnumVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaPersonalityEnumEnum?>? betaPersonalityEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaPersonalityEnumVariant1)
            {
                betaPersonalityEnumVariant1?.Invoke(BetaPersonalityEnumVariant1!);
            }
            else if (IsBetaPersonalityEnumEnum)
            {
                betaPersonalityEnumEnum?.Invoke(BetaPersonalityEnumEnum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaPersonalityEnumVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaPersonalityEnumEnum?>? betaPersonalityEnumEnum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaPersonalityEnumVariant1)
            {
                betaPersonalityEnumVariant1?.Invoke(BetaPersonalityEnumVariant1!);
            }
            else if (IsBetaPersonalityEnumEnum)
            {
                betaPersonalityEnumEnum?.Invoke(BetaPersonalityEnumEnum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaPersonalityEnumVariant1,
                typeof(string),
                BetaPersonalityEnumEnum,
                typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum),
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
        public bool Equals(BetaPersonalityEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaPersonalityEnumVariant1, other.BetaPersonalityEnumVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaPersonalityEnumEnum?>.Default.Equals(BetaPersonalityEnumEnum, other.BetaPersonalityEnumEnum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaPersonalityEnum obj1, BetaPersonalityEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaPersonalityEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaPersonalityEnum obj1, BetaPersonalityEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaPersonalityEnum o && Equals(o);
        }
    }
}
