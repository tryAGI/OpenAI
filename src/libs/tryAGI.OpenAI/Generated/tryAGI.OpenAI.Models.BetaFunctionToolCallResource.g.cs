#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaFunctionToolCallResource : global::System.IEquatable<BetaFunctionToolCallResource>
    {
        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolCall? FunctionToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolCall? FunctionToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionToolCall? value)
        {
            value = FunctionToolCall;
            return IsFunctionToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall PickFunctionToolCall() => IsFunctionToolCall
            ? FunctionToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionToolCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? BetaFunctionToolCallResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? BetaFunctionToolCallResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaFunctionToolCallResourceVariant2))]
#endif
        public bool IsBetaFunctionToolCallResourceVariant2 => BetaFunctionToolCallResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaFunctionToolCallResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? value)
        {
            value = BetaFunctionToolCallResourceVariant2;
            return IsBetaFunctionToolCallResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2 PickBetaFunctionToolCallResourceVariant2() => IsBetaFunctionToolCallResourceVariant2
            ? BetaFunctionToolCallResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaFunctionToolCallResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaFunctionToolCallResource(global::tryAGI.OpenAI.BetaFunctionToolCall value) => new BetaFunctionToolCallResource((global::tryAGI.OpenAI.BetaFunctionToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCall?(BetaFunctionToolCallResource @this) => @this.FunctionToolCall;

        /// <summary>
        ///
        /// </summary>
        public BetaFunctionToolCallResource(global::tryAGI.OpenAI.BetaFunctionToolCall? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaFunctionToolCallResource FromFunctionToolCall(global::tryAGI.OpenAI.BetaFunctionToolCall? value) => new BetaFunctionToolCallResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaFunctionToolCallResource(global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2 value) => new BetaFunctionToolCallResource((global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2?(BetaFunctionToolCallResource @this) => @this.BetaFunctionToolCallResourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaFunctionToolCallResource(global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? value)
        {
            BetaFunctionToolCallResourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaFunctionToolCallResource FromBetaFunctionToolCallResourceVariant2(global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? value) => new BetaFunctionToolCallResource(value);

        /// <summary>
        ///
        /// </summary>
        public BetaFunctionToolCallResource(
            global::tryAGI.OpenAI.BetaFunctionToolCall? functionToolCall,
            global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2? betaFunctionToolCallResourceVariant2
            )
        {
            FunctionToolCall = functionToolCall;
            BetaFunctionToolCallResourceVariant2 = betaFunctionToolCallResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaFunctionToolCallResourceVariant2 as object ??
            FunctionToolCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FunctionToolCall?.ToString() ??
            BetaFunctionToolCallResourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunctionToolCall && IsBetaFunctionToolCallResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCall, TResult>? functionToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2, TResult>? betaFunctionToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsBetaFunctionToolCallResourceVariant2 && betaFunctionToolCallResourceVariant2 != null)
            {
                return betaFunctionToolCallResourceVariant2(BetaFunctionToolCallResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCall>? functionToolCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2>? betaFunctionToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsBetaFunctionToolCallResourceVariant2)
            {
                betaFunctionToolCallResourceVariant2?.Invoke(BetaFunctionToolCallResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCall>? functionToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2>? betaFunctionToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsBetaFunctionToolCallResourceVariant2)
            {
                betaFunctionToolCallResourceVariant2?.Invoke(BetaFunctionToolCallResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionToolCall,
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCall),
                BetaFunctionToolCallResourceVariant2,
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2),
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
        public bool Equals(BetaFunctionToolCallResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2?>.Default.Equals(BetaFunctionToolCallResourceVariant2, other.BetaFunctionToolCallResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaFunctionToolCallResource obj1, BetaFunctionToolCallResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaFunctionToolCallResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaFunctionToolCallResource obj1, BetaFunctionToolCallResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaFunctionToolCallResource o && Equals(o);
        }
    }
}
