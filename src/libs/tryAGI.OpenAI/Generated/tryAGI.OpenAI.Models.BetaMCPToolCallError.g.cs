#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaMCPToolCallError : global::System.IEquatable<BetaMCPToolCallError>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPProtocolError? McpProtocolError { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPProtocolError? McpProtocolError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpProtocolError))]
#endif
        public bool IsMcpProtocolError => McpProtocolError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpProtocolError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMCPProtocolError? value)
        {
            value = McpProtocolError;
            return IsMcpProtocolError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPProtocolError PickMcpProtocolError() => IsMcpProtocolError
            ? McpProtocolError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpProtocolError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? McpToolExecutionError { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError? McpToolExecutionError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolExecutionError))]
#endif
        public bool IsMcpToolExecutionError => McpToolExecutionError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpToolExecutionError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMCPToolExecutionError? value)
        {
            value = McpToolExecutionError;
            return IsMcpToolExecutionError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolExecutionError PickMcpToolExecutionError() => IsMcpToolExecutionError
            ? McpToolExecutionError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolExecutionError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaHTTPError? HttpError { get; init; }
#else
        public global::tryAGI.OpenAI.BetaHTTPError? HttpError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HttpError))]
#endif
        public bool IsHttpError => HttpError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHttpError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaHTTPError? value)
        {
            value = HttpError;
            return IsHttpError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaHTTPError PickHttpError() => IsHttpError
            ? HttpError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HttpError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaMCPToolCallError(global::tryAGI.OpenAI.BetaMCPProtocolError value) => new BetaMCPToolCallError((global::tryAGI.OpenAI.BetaMCPProtocolError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPProtocolError?(BetaMCPToolCallError @this) => @this.McpProtocolError;

        /// <summary>
        ///
        /// </summary>
        public BetaMCPToolCallError(global::tryAGI.OpenAI.BetaMCPProtocolError? value)
        {
            McpProtocolError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaMCPToolCallError FromMcpProtocolError(global::tryAGI.OpenAI.BetaMCPProtocolError? value) => new BetaMCPToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaMCPToolCallError(global::tryAGI.OpenAI.BetaMCPToolExecutionError value) => new BetaMCPToolCallError((global::tryAGI.OpenAI.BetaMCPToolExecutionError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPToolExecutionError?(BetaMCPToolCallError @this) => @this.McpToolExecutionError;

        /// <summary>
        ///
        /// </summary>
        public BetaMCPToolCallError(global::tryAGI.OpenAI.BetaMCPToolExecutionError? value)
        {
            McpToolExecutionError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaMCPToolCallError FromMcpToolExecutionError(global::tryAGI.OpenAI.BetaMCPToolExecutionError? value) => new BetaMCPToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaMCPToolCallError(global::tryAGI.OpenAI.BetaHTTPError value) => new BetaMCPToolCallError((global::tryAGI.OpenAI.BetaHTTPError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaHTTPError?(BetaMCPToolCallError @this) => @this.HttpError;

        /// <summary>
        ///
        /// </summary>
        public BetaMCPToolCallError(global::tryAGI.OpenAI.BetaHTTPError? value)
        {
            HttpError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaMCPToolCallError FromHttpError(global::tryAGI.OpenAI.BetaHTTPError? value) => new BetaMCPToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public BetaMCPToolCallError(
            global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaMCPProtocolError? mcpProtocolError,
            global::tryAGI.OpenAI.BetaMCPToolExecutionError? mcpToolExecutionError,
            global::tryAGI.OpenAI.BetaHTTPError? httpError
            )
        {
            Type = type;

            McpProtocolError = mcpProtocolError;
            McpToolExecutionError = mcpToolExecutionError;
            HttpError = httpError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            HttpError as object ??
            McpToolExecutionError as object ??
            McpProtocolError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            McpProtocolError?.ToString() ??
            McpToolExecutionError?.ToString() ??
            HttpError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMcpProtocolError && !IsMcpToolExecutionError && !IsHttpError || !IsMcpProtocolError && IsMcpToolExecutionError && !IsHttpError || !IsMcpProtocolError && !IsMcpToolExecutionError && IsHttpError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaMCPProtocolError, TResult>? mcpProtocolError = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPToolExecutionError, TResult>? mcpToolExecutionError = null,
            global::System.Func<global::tryAGI.OpenAI.BetaHTTPError, TResult>? httpError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpProtocolError && mcpProtocolError != null)
            {
                return mcpProtocolError(McpProtocolError!);
            }
            else if (IsMcpToolExecutionError && mcpToolExecutionError != null)
            {
                return mcpToolExecutionError(McpToolExecutionError!);
            }
            else if (IsHttpError && httpError != null)
            {
                return httpError(HttpError!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaMCPProtocolError>? mcpProtocolError = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPToolExecutionError>? mcpToolExecutionError = null,

            global::System.Action<global::tryAGI.OpenAI.BetaHTTPError>? httpError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpProtocolError)
            {
                mcpProtocolError?.Invoke(McpProtocolError!);
            }
            else if (IsMcpToolExecutionError)
            {
                mcpToolExecutionError?.Invoke(McpToolExecutionError!);
            }
            else if (IsHttpError)
            {
                httpError?.Invoke(HttpError!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaMCPProtocolError>? mcpProtocolError = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPToolExecutionError>? mcpToolExecutionError = null,
            global::System.Action<global::tryAGI.OpenAI.BetaHTTPError>? httpError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpProtocolError)
            {
                mcpProtocolError?.Invoke(McpProtocolError!);
            }
            else if (IsMcpToolExecutionError)
            {
                mcpToolExecutionError?.Invoke(McpToolExecutionError!);
            }
            else if (IsHttpError)
            {
                httpError?.Invoke(HttpError!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpProtocolError,
                typeof(global::tryAGI.OpenAI.BetaMCPProtocolError),
                McpToolExecutionError,
                typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionError),
                HttpError,
                typeof(global::tryAGI.OpenAI.BetaHTTPError),
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
        public bool Equals(BetaMCPToolCallError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPProtocolError?>.Default.Equals(McpProtocolError, other.McpProtocolError) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPToolExecutionError?>.Default.Equals(McpToolExecutionError, other.McpToolExecutionError) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaHTTPError?>.Default.Equals(HttpError, other.HttpError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaMCPToolCallError obj1, BetaMCPToolCallError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaMCPToolCallError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaMCPToolCallError obj1, BetaMCPToolCallError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaMCPToolCallError o && Equals(o);
        }
    }
}
