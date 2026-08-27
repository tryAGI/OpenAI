#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client event for creating a response over a persistent WebSocket connection.<br/>
    /// This payload uses the same top-level fields as `POST /v1/responses`.<br/>
    /// Notes:<br/>
    /// - `stream` is implicit over WebSocket and should not be sent.<br/>
    /// - `background` is not supported over WebSocket.
    /// </summary>
    public readonly partial struct BetaResponsesClientEventResponseCreate : global::System.IEquatable<BetaResponsesClientEventResponseCreate>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? BetaResponsesClientEventResponseCreateVariant1 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? BetaResponsesClientEventResponseCreateVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponsesClientEventResponseCreateVariant1))]
#endif
        public bool IsBetaResponsesClientEventResponseCreateVariant1 => BetaResponsesClientEventResponseCreateVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponsesClientEventResponseCreateVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? value)
        {
            value = BetaResponsesClientEventResponseCreateVariant1;
            return IsBetaResponsesClientEventResponseCreateVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1 PickBetaResponsesClientEventResponseCreateVariant1() => IsBetaResponsesClientEventResponseCreateVariant1
            ? BetaResponsesClientEventResponseCreateVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponsesClientEventResponseCreateVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCreateResponse? BetaCreateResponse { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCreateResponse? BetaCreateResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaCreateResponse))]
#endif
        public bool IsBetaCreateResponse => BetaCreateResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaCreateResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCreateResponse? value)
        {
            value = BetaCreateResponse;
            return IsBetaCreateResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponse PickBetaCreateResponse() => IsBetaCreateResponse
            ? BetaCreateResponse!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaCreateResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesClientEventResponseCreate(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1 value) => new BetaResponsesClientEventResponseCreate((global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1?(BetaResponsesClientEventResponseCreate @this) => @this.BetaResponsesClientEventResponseCreateVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesClientEventResponseCreate(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? value)
        {
            BetaResponsesClientEventResponseCreateVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesClientEventResponseCreate FromBetaResponsesClientEventResponseCreateVariant1(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? value) => new BetaResponsesClientEventResponseCreate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesClientEventResponseCreate(global::tryAGI.OpenAI.BetaCreateResponse value) => new BetaResponsesClientEventResponseCreate((global::tryAGI.OpenAI.BetaCreateResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCreateResponse?(BetaResponsesClientEventResponseCreate @this) => @this.BetaCreateResponse;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesClientEventResponseCreate(global::tryAGI.OpenAI.BetaCreateResponse? value)
        {
            BetaCreateResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesClientEventResponseCreate FromBetaCreateResponse(global::tryAGI.OpenAI.BetaCreateResponse? value) => new BetaResponsesClientEventResponseCreate(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesClientEventResponseCreate(
            global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1? betaResponsesClientEventResponseCreateVariant1,
            global::tryAGI.OpenAI.BetaCreateResponse? betaCreateResponse
            )
        {
            BetaResponsesClientEventResponseCreateVariant1 = betaResponsesClientEventResponseCreateVariant1;
            BetaCreateResponse = betaCreateResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaCreateResponse as object ??
            BetaResponsesClientEventResponseCreateVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaResponsesClientEventResponseCreateVariant1?.ToString() ??
            BetaCreateResponse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaResponsesClientEventResponseCreateVariant1 && IsBetaCreateResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1, TResult>? betaResponsesClientEventResponseCreateVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCreateResponse?, TResult>? betaCreateResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaResponsesClientEventResponseCreateVariant1 && betaResponsesClientEventResponseCreateVariant1 != null)
            {
                return betaResponsesClientEventResponseCreateVariant1(BetaResponsesClientEventResponseCreateVariant1!);
            }
            else if (IsBetaCreateResponse && betaCreateResponse != null)
            {
                return betaCreateResponse(BetaCreateResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1>? betaResponsesClientEventResponseCreateVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCreateResponse?>? betaCreateResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaResponsesClientEventResponseCreateVariant1)
            {
                betaResponsesClientEventResponseCreateVariant1?.Invoke(BetaResponsesClientEventResponseCreateVariant1!);
            }
            else if (IsBetaCreateResponse)
            {
                betaCreateResponse?.Invoke(BetaCreateResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1>? betaResponsesClientEventResponseCreateVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCreateResponse?>? betaCreateResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaResponsesClientEventResponseCreateVariant1)
            {
                betaResponsesClientEventResponseCreateVariant1?.Invoke(BetaResponsesClientEventResponseCreateVariant1!);
            }
            else if (IsBetaCreateResponse)
            {
                betaCreateResponse?.Invoke(BetaCreateResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaResponsesClientEventResponseCreateVariant1,
                typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1),
                BetaCreateResponse,
                typeof(global::tryAGI.OpenAI.BetaCreateResponse),
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
        public bool Equals(BetaResponsesClientEventResponseCreate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreateVariant1?>.Default.Equals(BetaResponsesClientEventResponseCreateVariant1, other.BetaResponsesClientEventResponseCreateVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCreateResponse?>.Default.Equals(BetaCreateResponse, other.BetaCreateResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponsesClientEventResponseCreate obj1, BetaResponsesClientEventResponseCreate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponsesClientEventResponseCreate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponsesClientEventResponseCreate obj1, BetaResponsesClientEventResponseCreate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponsesClientEventResponseCreate o && Equals(o);
        }
    }
}
