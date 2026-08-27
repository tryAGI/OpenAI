#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaCreateModelResponseProperties : global::System.IEquatable<BetaCreateModelResponseProperties>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModelResponseProperties? BetaModelResponseProperties { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModelResponseProperties? BetaModelResponseProperties { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaModelResponseProperties))]
#endif
        public bool IsBetaModelResponseProperties => BetaModelResponseProperties != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaModelResponseProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaModelResponseProperties? value)
        {
            value = BetaModelResponseProperties;
            return IsBetaModelResponseProperties;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties PickBetaModelResponseProperties() => IsBetaModelResponseProperties
            ? BetaModelResponseProperties!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaModelResponseProperties' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? BetaCreateModelResponsePropertiesVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? BetaCreateModelResponsePropertiesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaCreateModelResponsePropertiesVariant2))]
#endif
        public bool IsBetaCreateModelResponsePropertiesVariant2 => BetaCreateModelResponsePropertiesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaCreateModelResponsePropertiesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? value)
        {
            value = BetaCreateModelResponsePropertiesVariant2;
            return IsBetaCreateModelResponsePropertiesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2 PickBetaCreateModelResponsePropertiesVariant2() => IsBetaCreateModelResponsePropertiesVariant2
            ? BetaCreateModelResponsePropertiesVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaCreateModelResponsePropertiesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaCreateModelResponseProperties(global::tryAGI.OpenAI.BetaModelResponseProperties value) => new BetaCreateModelResponseProperties((global::tryAGI.OpenAI.BetaModelResponseProperties?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModelResponseProperties?(BetaCreateModelResponseProperties @this) => @this.BetaModelResponseProperties;

        /// <summary>
        ///
        /// </summary>
        public BetaCreateModelResponseProperties(global::tryAGI.OpenAI.BetaModelResponseProperties? value)
        {
            BetaModelResponseProperties = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaCreateModelResponseProperties FromBetaModelResponseProperties(global::tryAGI.OpenAI.BetaModelResponseProperties? value) => new BetaCreateModelResponseProperties(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaCreateModelResponseProperties(global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2 value) => new BetaCreateModelResponseProperties((global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2?(BetaCreateModelResponseProperties @this) => @this.BetaCreateModelResponsePropertiesVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaCreateModelResponseProperties(global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? value)
        {
            BetaCreateModelResponsePropertiesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaCreateModelResponseProperties FromBetaCreateModelResponsePropertiesVariant2(global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? value) => new BetaCreateModelResponseProperties(value);

        /// <summary>
        ///
        /// </summary>
        public BetaCreateModelResponseProperties(
            global::tryAGI.OpenAI.BetaModelResponseProperties? betaModelResponseProperties,
            global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2? betaCreateModelResponsePropertiesVariant2
            )
        {
            BetaModelResponseProperties = betaModelResponseProperties;
            BetaCreateModelResponsePropertiesVariant2 = betaCreateModelResponsePropertiesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaCreateModelResponsePropertiesVariant2 as object ??
            BetaModelResponseProperties as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaModelResponseProperties?.ToString() ??
            BetaCreateModelResponsePropertiesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaModelResponseProperties && IsBetaCreateModelResponsePropertiesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaModelResponseProperties, TResult>? betaModelResponseProperties = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2, TResult>? betaCreateModelResponsePropertiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaModelResponseProperties && betaModelResponseProperties != null)
            {
                return betaModelResponseProperties(BetaModelResponseProperties!);
            }
            else if (IsBetaCreateModelResponsePropertiesVariant2 && betaCreateModelResponsePropertiesVariant2 != null)
            {
                return betaCreateModelResponsePropertiesVariant2(BetaCreateModelResponsePropertiesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaModelResponseProperties>? betaModelResponseProperties = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2>? betaCreateModelResponsePropertiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaModelResponseProperties)
            {
                betaModelResponseProperties?.Invoke(BetaModelResponseProperties!);
            }
            else if (IsBetaCreateModelResponsePropertiesVariant2)
            {
                betaCreateModelResponsePropertiesVariant2?.Invoke(BetaCreateModelResponsePropertiesVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaModelResponseProperties>? betaModelResponseProperties = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2>? betaCreateModelResponsePropertiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaModelResponseProperties)
            {
                betaModelResponseProperties?.Invoke(BetaModelResponseProperties!);
            }
            else if (IsBetaCreateModelResponsePropertiesVariant2)
            {
                betaCreateModelResponsePropertiesVariant2?.Invoke(BetaCreateModelResponsePropertiesVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaModelResponseProperties,
                typeof(global::tryAGI.OpenAI.BetaModelResponseProperties),
                BetaCreateModelResponsePropertiesVariant2,
                typeof(global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2),
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
        public bool Equals(BetaCreateModelResponseProperties other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModelResponseProperties?>.Default.Equals(BetaModelResponseProperties, other.BetaModelResponseProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2?>.Default.Equals(BetaCreateModelResponsePropertiesVariant2, other.BetaCreateModelResponsePropertiesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaCreateModelResponseProperties obj1, BetaCreateModelResponseProperties obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaCreateModelResponseProperties>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaCreateModelResponseProperties obj1, BetaCreateModelResponseProperties obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaCreateModelResponseProperties o && Equals(o);
        }
    }
}
