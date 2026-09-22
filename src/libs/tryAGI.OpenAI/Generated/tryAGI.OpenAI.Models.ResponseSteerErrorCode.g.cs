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
    public readonly partial struct ResponseSteerErrorCode : global::System.IEquatable<ResponseSteerErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? Enum { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponseSteerErrorCodeVariant2 { get; init; }
#else
        public string? ResponseSteerErrorCodeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteerErrorCodeVariant2))]
#endif
        public bool IsResponseSteerErrorCodeVariant2 => ResponseSteerErrorCodeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteerErrorCodeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ResponseSteerErrorCodeVariant2;
            return IsResponseSteerErrorCodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickResponseSteerErrorCodeVariant2() => IsResponseSteerErrorCodeVariant2
            ? ResponseSteerErrorCodeVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteerErrorCodeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerErrorCode(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum value) => new ResponseSteerErrorCode((global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?(ResponseSteerErrorCode @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerErrorCode(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerErrorCode FromEnum(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? value) => new ResponseSteerErrorCode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerErrorCode(string value) => new ResponseSteerErrorCode((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ResponseSteerErrorCode @this) => @this.ResponseSteerErrorCodeVariant2;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerErrorCode(string? value)
        {
            ResponseSteerErrorCodeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerErrorCode FromResponseSteerErrorCodeVariant2(string? value) => new ResponseSteerErrorCode(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerErrorCode(
            global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum? @enum,
            string? responseSteerErrorCodeVariant2
            )
        {
            Enum = @enum;
            ResponseSteerErrorCodeVariant2 = responseSteerErrorCodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseSteerErrorCodeVariant2 as object ??
            Enum as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            ResponseSteerErrorCodeVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnum || IsResponseSteerErrorCodeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?, TResult>? @enum = null,
            global::System.Func<string, TResult>? responseSteerErrorCodeVariant2 = null,
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
            else if (IsResponseSteerErrorCodeVariant2 && responseSteerErrorCodeVariant2 != null)
            {
                return responseSteerErrorCodeVariant2(ResponseSteerErrorCodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?>? @enum = null,

            global::System.Action<string>? responseSteerErrorCodeVariant2 = null,
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
            else if (IsResponseSteerErrorCodeVariant2)
            {
                responseSteerErrorCodeVariant2?.Invoke(ResponseSteerErrorCodeVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?>? @enum = null,
            global::System.Action<string>? responseSteerErrorCodeVariant2 = null,
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
            else if (IsResponseSteerErrorCodeVariant2)
            {
                responseSteerErrorCodeVariant2?.Invoke(ResponseSteerErrorCodeVariant2!);
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
                typeof(global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum),
                ResponseSteerErrorCodeVariant2,
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
        public bool Equals(ResponseSteerErrorCode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerErrorCodeEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponseSteerErrorCodeVariant2, other.ResponseSteerErrorCodeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseSteerErrorCode obj1, ResponseSteerErrorCode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseSteerErrorCode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseSteerErrorCode obj1, ResponseSteerErrorCode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseSteerErrorCode o && Equals(o);
        }
    }
}
