#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Model ID used to generate the response, like `gpt-6-astra`. OpenAI offers a wide range of models with different capabilities, performance characteristics, and price points. Refer to the [model guide](https://developers.openai.com/api/docs/models) to browse and compare available models.
    /// </summary>
    public readonly partial struct BetaModelIdsCompaction : global::System.IEquatable<BetaModelIdsCompaction>
    {
        /// <summary>
        /// Example: gpt-6-astra
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Responses { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Responses { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Responses))]
#endif
        public bool IsResponses => Responses != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaModelIdsResponses? value)
        {
            value = Responses;
            return IsResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponses PickResponses() => Responses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Responses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaModelIdsCompactionVariant2 { get; init; }
#else
        public string? BetaModelIdsCompactionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaModelIdsCompactionVariant2))]
#endif
        public bool IsBetaModelIdsCompactionVariant2 => BetaModelIdsCompactionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaModelIdsCompactionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaModelIdsCompactionVariant2;
            return IsBetaModelIdsCompactionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaModelIdsCompactionVariant2() => BetaModelIdsCompactionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaModelIdsCompactionVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaModelIdsCompaction(global::tryAGI.OpenAI.BetaModelIdsResponses value) => new BetaModelIdsCompaction((global::tryAGI.OpenAI.BetaModelIdsResponses?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModelIdsResponses?(BetaModelIdsCompaction @this) => @this.Responses;

        /// <summary>
        ///
        /// </summary>
        public BetaModelIdsCompaction(global::tryAGI.OpenAI.BetaModelIdsResponses? value)
        {
            Responses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaModelIdsCompaction FromResponses(global::tryAGI.OpenAI.BetaModelIdsResponses? value) => new BetaModelIdsCompaction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaModelIdsCompaction(string value) => new BetaModelIdsCompaction((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaModelIdsCompaction @this) => @this.BetaModelIdsCompactionVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaModelIdsCompaction(string? value)
        {
            BetaModelIdsCompactionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaModelIdsCompaction FromBetaModelIdsCompactionVariant2(string? value) => new BetaModelIdsCompaction(value);

        /// <summary>
        ///
        /// </summary>
        public BetaModelIdsCompaction(
            global::tryAGI.OpenAI.BetaModelIdsResponses? responses,
            string? betaModelIdsCompactionVariant2
            )
        {
            Responses = responses;
            BetaModelIdsCompactionVariant2 = betaModelIdsCompactionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaModelIdsCompactionVariant2 as object ??
            Responses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Responses?.ToString() ??
            BetaModelIdsCompactionVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponses || IsBetaModelIdsCompactionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaModelIdsResponses?, TResult>? responses = null,
            global::System.Func<string, TResult>? betaModelIdsCompactionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Responses is { } __value0 && responses != null)
            {
                return responses(__value0);
            }
            else if (BetaModelIdsCompactionVariant2 is { } __value1 && betaModelIdsCompactionVariant2 != null)
            {
                return betaModelIdsCompactionVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsResponses?>? responses = null,

            global::System.Action<string>? betaModelIdsCompactionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Responses is { } __value0)
            {
                responses?.Invoke(__value0);
            }
            else if (BetaModelIdsCompactionVariant2 is { } __value1)
            {
                betaModelIdsCompactionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsResponses?>? responses = null,
            global::System.Action<string>? betaModelIdsCompactionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Responses is { } __value0)
            {
                responses?.Invoke(__value0);
            }
            else if (BetaModelIdsCompactionVariant2 is { } __value1)
            {
                betaModelIdsCompactionVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Responses,
                typeof(global::tryAGI.OpenAI.BetaModelIdsResponses),
                BetaModelIdsCompactionVariant2,
                typeof(string),
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
        public bool Equals(BetaModelIdsCompaction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModelIdsResponses?>.Default.Equals(Responses, other.Responses) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaModelIdsCompactionVariant2, other.BetaModelIdsCompactionVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaModelIdsCompaction obj1, BetaModelIdsCompaction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaModelIdsCompaction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaModelIdsCompaction obj1, BetaModelIdsCompaction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaModelIdsCompaction o && Equals(o);
        }
    }
}
