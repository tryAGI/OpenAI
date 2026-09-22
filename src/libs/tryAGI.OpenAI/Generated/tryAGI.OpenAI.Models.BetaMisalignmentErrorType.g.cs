#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaMisalignmentErrorType : global::System.IEquatable<BetaMisalignmentErrorType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaMisalignmentErrorTypeVariant1 { get; init; }
#else
        public string? BetaMisalignmentErrorTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaMisalignmentErrorTypeVariant1))]
#endif
        public bool IsBetaMisalignmentErrorTypeVariant1 => BetaMisalignmentErrorTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaMisalignmentErrorTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaMisalignmentErrorTypeVariant1;
            return IsBetaMisalignmentErrorTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaMisalignmentErrorTypeVariant1() => IsBetaMisalignmentErrorTypeVariant1
            ? BetaMisalignmentErrorTypeVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaMisalignmentErrorTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaMisalignmentErrorType(string value) => new BetaMisalignmentErrorType((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaMisalignmentErrorType @this) => @this.BetaMisalignmentErrorTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaMisalignmentErrorType(string? value)
        {
            BetaMisalignmentErrorTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaMisalignmentErrorType FromBetaMisalignmentErrorTypeVariant1(string? value) => new BetaMisalignmentErrorType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaMisalignmentErrorType(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum value) => new BetaMisalignmentErrorType((global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?(BetaMisalignmentErrorType @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public BetaMisalignmentErrorType(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaMisalignmentErrorType FromEnum(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? value) => new BetaMisalignmentErrorType(value);

        /// <summary>
        ///
        /// </summary>
        public BetaMisalignmentErrorType(
            string? betaMisalignmentErrorTypeVariant1,
            global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum? @enum
            )
        {
            BetaMisalignmentErrorTypeVariant1 = betaMisalignmentErrorTypeVariant1;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            BetaMisalignmentErrorTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaMisalignmentErrorTypeVariant1?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaMisalignmentErrorTypeVariant1 || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaMisalignmentErrorTypeVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaMisalignmentErrorTypeVariant1 && betaMisalignmentErrorTypeVariant1 != null)
            {
                return betaMisalignmentErrorTypeVariant1(BetaMisalignmentErrorTypeVariant1!);
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
            global::System.Action<string>? betaMisalignmentErrorTypeVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaMisalignmentErrorTypeVariant1)
            {
                betaMisalignmentErrorTypeVariant1?.Invoke(BetaMisalignmentErrorTypeVariant1!);
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
            global::System.Action<string>? betaMisalignmentErrorTypeVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaMisalignmentErrorTypeVariant1)
            {
                betaMisalignmentErrorTypeVariant1?.Invoke(BetaMisalignmentErrorTypeVariant1!);
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
                BetaMisalignmentErrorTypeVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum),
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
        public bool Equals(BetaMisalignmentErrorType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaMisalignmentErrorTypeVariant1, other.BetaMisalignmentErrorTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaMisalignmentErrorType obj1, BetaMisalignmentErrorType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaMisalignmentErrorType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaMisalignmentErrorType obj1, BetaMisalignmentErrorType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaMisalignmentErrorType o && Equals(o);
        }
    }
}
