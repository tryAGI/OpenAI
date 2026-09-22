#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An extensible enum describing why accepted steering input is still queued.<br/>
    /// Clients should handle unknown values because additional reasons may be<br/>
    /// introduced. Known values include:<br/>
    /// - `waiting_for_required_input`: The response is waiting for the tool results or approval decisions identified by `required_input`.
    /// </summary>
    public readonly partial struct BetaResponseSteerPendingReason : global::System.IEquatable<BetaResponseSteerPendingReason>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaResponseSteerPendingReasonVariant2 { get; init; }
#else
        public string? BetaResponseSteerPendingReasonVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseSteerPendingReasonVariant2))]
#endif
        public bool IsBetaResponseSteerPendingReasonVariant2 => BetaResponseSteerPendingReasonVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseSteerPendingReasonVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaResponseSteerPendingReasonVariant2;
            return IsBetaResponseSteerPendingReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaResponseSteerPendingReasonVariant2() => IsBetaResponseSteerPendingReasonVariant2
            ? BetaResponseSteerPendingReasonVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseSteerPendingReasonVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerPendingReason(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum value) => new BetaResponseSteerPendingReason((global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?(BetaResponseSteerPendingReason @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerPendingReason(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerPendingReason FromEnum(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? value) => new BetaResponseSteerPendingReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerPendingReason(string value) => new BetaResponseSteerPendingReason((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaResponseSteerPendingReason @this) => @this.BetaResponseSteerPendingReasonVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerPendingReason(string? value)
        {
            BetaResponseSteerPendingReasonVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerPendingReason FromBetaResponseSteerPendingReasonVariant2(string? value) => new BetaResponseSteerPendingReason(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerPendingReason(
            global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum? @enum,
            string? betaResponseSteerPendingReasonVariant2
            )
        {
            Enum = @enum;
            BetaResponseSteerPendingReasonVariant2 = betaResponseSteerPendingReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaResponseSteerPendingReasonVariant2 as object ??
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            BetaResponseSteerPendingReasonVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum || IsBetaResponseSteerPendingReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? betaResponseSteerPendingReasonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsBetaResponseSteerPendingReasonVariant2 && betaResponseSteerPendingReasonVariant2 != null)
            {
                return betaResponseSteerPendingReasonVariant2(BetaResponseSteerPendingReasonVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?>? @enum = null,

            global::System.Action<string>? betaResponseSteerPendingReasonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsBetaResponseSteerPendingReasonVariant2)
            {
                betaResponseSteerPendingReasonVariant2?.Invoke(BetaResponseSteerPendingReasonVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?>? @enum = null,
            global::System.Action<string>? betaResponseSteerPendingReasonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsBetaResponseSteerPendingReasonVariant2)
            {
                betaResponseSteerPendingReasonVariant2?.Invoke(BetaResponseSteerPendingReasonVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum),
                BetaResponseSteerPendingReasonVariant2,
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
        public bool Equals(BetaResponseSteerPendingReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerPendingReasonEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaResponseSteerPendingReasonVariant2, other.BetaResponseSteerPendingReasonVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseSteerPendingReason obj1, BetaResponseSteerPendingReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseSteerPendingReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseSteerPendingReason obj1, BetaResponseSteerPendingReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseSteerPendingReason o && Equals(o);
        }
    }
}
