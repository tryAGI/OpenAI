#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A machine-readable steering error code. Clients should handle unknown<br/>
    /// values because additional codes may be introduced. Known values include:<br/>
    /// - `response_not_found`: The target response is not available on this connection.<br/>
    /// - `invalid_input`: The event or input failed validation.<br/>
    /// - `steering_not_supported`: The model or response execution mode does not support steering.<br/>
    /// - `too_many_pending_steers`: Too much steering input is pending for the response.<br/>
    /// - `response_already_completed`: The response completed and is no longer accepting steering input.<br/>
    /// - `response_not_active`: The response is no longer accepting steering input.<br/>
    /// - `successor_creation_failed`: The successor response could not be created.
    /// </summary>
    public readonly partial struct BetaResponseSteerErrorCode : global::System.IEquatable<BetaResponseSteerErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaResponseSteerErrorCodeVariant2 { get; init; }
#else
        public string? BetaResponseSteerErrorCodeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseSteerErrorCodeVariant2))]
#endif
        public bool IsBetaResponseSteerErrorCodeVariant2 => BetaResponseSteerErrorCodeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaResponseSteerErrorCodeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaResponseSteerErrorCodeVariant2;
            return IsBetaResponseSteerErrorCodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaResponseSteerErrorCodeVariant2() => IsBetaResponseSteerErrorCodeVariant2
            ? BetaResponseSteerErrorCodeVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseSteerErrorCodeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerErrorCode(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum value) => new BetaResponseSteerErrorCode((global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?(BetaResponseSteerErrorCode @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerErrorCode(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerErrorCode FromEnum(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? value) => new BetaResponseSteerErrorCode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerErrorCode(string value) => new BetaResponseSteerErrorCode((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaResponseSteerErrorCode @this) => @this.BetaResponseSteerErrorCodeVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerErrorCode(string? value)
        {
            BetaResponseSteerErrorCodeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerErrorCode FromBetaResponseSteerErrorCodeVariant2(string? value) => new BetaResponseSteerErrorCode(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerErrorCode(
            global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum? @enum,
            string? betaResponseSteerErrorCodeVariant2
            )
        {
            Enum = @enum;
            BetaResponseSteerErrorCodeVariant2 = betaResponseSteerErrorCodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaResponseSteerErrorCodeVariant2 as object ??
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            BetaResponseSteerErrorCodeVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum || IsBetaResponseSteerErrorCodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? betaResponseSteerErrorCodeVariant2 = null,
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
            else if (IsBetaResponseSteerErrorCodeVariant2 && betaResponseSteerErrorCodeVariant2 != null)
            {
                return betaResponseSteerErrorCodeVariant2(BetaResponseSteerErrorCodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?>? @enum = null,

            global::System.Action<string>? betaResponseSteerErrorCodeVariant2 = null,
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
            else if (IsBetaResponseSteerErrorCodeVariant2)
            {
                betaResponseSteerErrorCodeVariant2?.Invoke(BetaResponseSteerErrorCodeVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?>? @enum = null,
            global::System.Action<string>? betaResponseSteerErrorCodeVariant2 = null,
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
            else if (IsBetaResponseSteerErrorCodeVariant2)
            {
                betaResponseSteerErrorCodeVariant2?.Invoke(BetaResponseSteerErrorCodeVariant2!);
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
                typeof(global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum),
                BetaResponseSteerErrorCodeVariant2,
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
        public bool Equals(BetaResponseSteerErrorCode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerErrorCodeEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaResponseSteerErrorCodeVariant2, other.BetaResponseSteerErrorCodeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseSteerErrorCode obj1, BetaResponseSteerErrorCode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseSteerErrorCode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseSteerErrorCode obj1, BetaResponseSteerErrorCode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseSteerErrorCode o && Equals(o);
        }
    }
}
