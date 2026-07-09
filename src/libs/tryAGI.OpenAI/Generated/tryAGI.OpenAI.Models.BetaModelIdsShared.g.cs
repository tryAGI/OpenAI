#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: gpt-5.4
    /// </summary>
    public readonly partial struct BetaModelIdsShared : global::System.IEquatable<BetaModelIdsShared>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaModelIdsSharedVariant1 { get; init; }
#else
        public string? BetaModelIdsSharedVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaModelIdsSharedVariant1))]
#endif
        public bool IsBetaModelIdsSharedVariant1 => BetaModelIdsSharedVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaModelIdsSharedVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaModelIdsSharedVariant1;
            return IsBetaModelIdsSharedVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickBetaModelIdsSharedVariant1() => IsBetaModelIdsSharedVariant1
            ? BetaModelIdsSharedVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaModelIdsSharedVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.BetaModelIdsSharedEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsSharedEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaModelIdsShared(string value) => new BetaModelIdsShared((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BetaModelIdsShared @this) => @this.BetaModelIdsSharedVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BetaModelIdsShared(string? value)
        {
            BetaModelIdsSharedVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaModelIdsShared FromBetaModelIdsSharedVariant1(string? value) => new BetaModelIdsShared(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaModelIdsShared(global::tryAGI.OpenAI.BetaModelIdsSharedEnum value) => new BetaModelIdsShared((global::tryAGI.OpenAI.BetaModelIdsSharedEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModelIdsSharedEnum?(BetaModelIdsShared @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public BetaModelIdsShared(global::tryAGI.OpenAI.BetaModelIdsSharedEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaModelIdsShared FromEnum(global::tryAGI.OpenAI.BetaModelIdsSharedEnum? value) => new BetaModelIdsShared(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaModelIdsShared(
            string? betaModelIdsSharedVariant1,
            global::tryAGI.OpenAI.BetaModelIdsSharedEnum? @enum
            )
        {
            BetaModelIdsSharedVariant1 = betaModelIdsSharedVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            BetaModelIdsSharedVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BetaModelIdsSharedVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBetaModelIdsSharedVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaModelIdsSharedVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaModelIdsSharedEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaModelIdsSharedVariant1 && betaModelIdsSharedVariant1 != null)
            {
                return betaModelIdsSharedVariant1(BetaModelIdsSharedVariant1!);
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
            global::System.Action<string>? betaModelIdsSharedVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsSharedEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaModelIdsSharedVariant1)
            {
                betaModelIdsSharedVariant1?.Invoke(BetaModelIdsSharedVariant1!);
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
            global::System.Action<string>? betaModelIdsSharedVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsSharedEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaModelIdsSharedVariant1)
            {
                betaModelIdsSharedVariant1?.Invoke(BetaModelIdsSharedVariant1!);
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
                BetaModelIdsSharedVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum),
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
        public bool Equals(BetaModelIdsShared other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaModelIdsSharedVariant1, other.BetaModelIdsSharedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModelIdsSharedEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaModelIdsShared obj1, BetaModelIdsShared obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaModelIdsShared>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaModelIdsShared obj1, BetaModelIdsShared obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaModelIdsShared o && Equals(o);
        }
    }
}
