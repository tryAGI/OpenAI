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
    public readonly partial struct ResponseSteerPendingReason : global::System.IEquatable<ResponseSteerPendingReason>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponseSteerPendingReasonVariant2 { get; init; }
#else
        public string? ResponseSteerPendingReasonVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteerPendingReasonVariant2))]
#endif
        public bool IsResponseSteerPendingReasonVariant2 => ResponseSteerPendingReasonVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteerPendingReasonVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ResponseSteerPendingReasonVariant2;
            return IsResponseSteerPendingReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickResponseSteerPendingReasonVariant2() => IsResponseSteerPendingReasonVariant2
            ? ResponseSteerPendingReasonVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerPendingReasonVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerPendingReason(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum value) => new ResponseSteerPendingReason((global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?(ResponseSteerPendingReason @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerPendingReason(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerPendingReason FromEnum(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? value) => new ResponseSteerPendingReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerPendingReason(string value) => new ResponseSteerPendingReason((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ResponseSteerPendingReason @this) => @this.ResponseSteerPendingReasonVariant2;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerPendingReason(string? value)
        {
            ResponseSteerPendingReasonVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerPendingReason FromResponseSteerPendingReasonVariant2(string? value) => new ResponseSteerPendingReason(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerPendingReason(
            global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum? @enum,
            string? responseSteerPendingReasonVariant2
            )
        {
            Enum = @enum;
            ResponseSteerPendingReasonVariant2 = responseSteerPendingReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseSteerPendingReasonVariant2 as object ??
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            ResponseSteerPendingReasonVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum || IsResponseSteerPendingReasonVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? responseSteerPendingReasonVariant2 = null,
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
            else if (IsResponseSteerPendingReasonVariant2 && responseSteerPendingReasonVariant2 != null)
            {
                return responseSteerPendingReasonVariant2(ResponseSteerPendingReasonVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?>? @enum = null,

            global::System.Action<string>? responseSteerPendingReasonVariant2 = null,
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
            else if (IsResponseSteerPendingReasonVariant2)
            {
                responseSteerPendingReasonVariant2?.Invoke(ResponseSteerPendingReasonVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?>? @enum = null,
            global::System.Action<string>? responseSteerPendingReasonVariant2 = null,
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
            else if (IsResponseSteerPendingReasonVariant2)
            {
                responseSteerPendingReasonVariant2?.Invoke(ResponseSteerPendingReasonVariant2!);
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
                typeof(global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum),
                ResponseSteerPendingReasonVariant2,
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
        public bool Equals(ResponseSteerPendingReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerPendingReasonEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponseSteerPendingReasonVariant2, other.ResponseSteerPendingReasonVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseSteerPendingReason obj1, ResponseSteerPendingReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseSteerPendingReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseSteerPendingReason obj1, ResponseSteerPendingReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseSteerPendingReason o && Equals(o);
        }
    }
}
