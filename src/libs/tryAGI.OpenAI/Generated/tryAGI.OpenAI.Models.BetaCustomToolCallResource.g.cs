#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaCustomToolCallResource : global::System.IEquatable<BetaCustomToolCallResource>
    {
        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolCall? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolCall? CustomToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolCall? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall PickCustomToolCall() => IsCustomToolCall
            ? CustomToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? BetaCustomToolCallResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? BetaCustomToolCallResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaCustomToolCallResourceVariant2))]
#endif
        public bool IsBetaCustomToolCallResourceVariant2 => BetaCustomToolCallResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaCustomToolCallResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? value)
        {
            value = BetaCustomToolCallResourceVariant2;
            return IsBetaCustomToolCallResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2 PickBetaCustomToolCallResourceVariant2() => IsBetaCustomToolCallResourceVariant2
            ? BetaCustomToolCallResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaCustomToolCallResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaCustomToolCallResource(global::tryAGI.OpenAI.BetaCustomToolCall value) => new BetaCustomToolCallResource((global::tryAGI.OpenAI.BetaCustomToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCall?(BetaCustomToolCallResource @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public BetaCustomToolCallResource(global::tryAGI.OpenAI.BetaCustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaCustomToolCallResource FromCustomToolCall(global::tryAGI.OpenAI.BetaCustomToolCall? value) => new BetaCustomToolCallResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaCustomToolCallResource(global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2 value) => new BetaCustomToolCallResource((global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2?(BetaCustomToolCallResource @this) => @this.BetaCustomToolCallResourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaCustomToolCallResource(global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? value)
        {
            BetaCustomToolCallResourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaCustomToolCallResource FromBetaCustomToolCallResourceVariant2(global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? value) => new BetaCustomToolCallResource(value);

        /// <summary>
        ///
        /// </summary>
        public BetaCustomToolCallResource(
            global::tryAGI.OpenAI.BetaCustomToolCall? customToolCall,
            global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2? betaCustomToolCallResourceVariant2
            )
        {
            CustomToolCall = customToolCall;
            BetaCustomToolCallResourceVariant2 = betaCustomToolCallResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaCustomToolCallResourceVariant2 as object ??
            CustomToolCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CustomToolCall?.ToString() ??
            BetaCustomToolCallResourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolCall && IsBetaCustomToolCallResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCall, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2, TResult>? betaCustomToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsBetaCustomToolCallResourceVariant2 && betaCustomToolCallResourceVariant2 != null)
            {
                return betaCustomToolCallResourceVariant2(BetaCustomToolCallResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCall>? customToolCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2>? betaCustomToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsBetaCustomToolCallResourceVariant2)
            {
                betaCustomToolCallResourceVariant2?.Invoke(BetaCustomToolCallResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCall>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2>? betaCustomToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsBetaCustomToolCallResourceVariant2)
            {
                betaCustomToolCallResourceVariant2?.Invoke(BetaCustomToolCallResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCall),
                BetaCustomToolCallResourceVariant2,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2),
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
        public bool Equals(BetaCustomToolCallResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2?>.Default.Equals(BetaCustomToolCallResourceVariant2, other.BetaCustomToolCallResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaCustomToolCallResource obj1, BetaCustomToolCallResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaCustomToolCallResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaCustomToolCallResource obj1, BetaCustomToolCallResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaCustomToolCallResource o && Equals(o);
        }
    }
}
