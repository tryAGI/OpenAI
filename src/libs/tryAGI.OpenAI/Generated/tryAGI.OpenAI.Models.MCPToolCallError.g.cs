#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MCPToolCallError : global::System.IEquatable<MCPToolCallError>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPProtocolError? McpProtocolError { get; init; }
#else
        public global::tryAGI.OpenAI.MCPProtocolError? McpProtocolError { get; }
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
            out global::tryAGI.OpenAI.MCPProtocolError? value)
        {
            value = McpProtocolError;
            return IsMcpProtocolError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPProtocolError PickMcpProtocolError() => IsMcpProtocolError
            ? McpProtocolError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpProtocolError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPToolExecutionError? McpToolExecutionError { get; init; }
#else
        public global::tryAGI.OpenAI.MCPToolExecutionError? McpToolExecutionError { get; }
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
            out global::tryAGI.OpenAI.MCPToolExecutionError? value)
        {
            value = McpToolExecutionError;
            return IsMcpToolExecutionError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MCPToolExecutionError PickMcpToolExecutionError() => IsMcpToolExecutionError
            ? McpToolExecutionError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolExecutionError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HTTPError? HttpError { get; init; }
#else
        public global::tryAGI.OpenAI.HTTPError? HttpError { get; }
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
            out global::tryAGI.OpenAI.HTTPError? value)
        {
            value = HttpError;
            return IsHttpError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HTTPError PickHttpError() => IsHttpError
            ? HttpError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HttpError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MCPToolCallError(global::tryAGI.OpenAI.MCPProtocolError value) => new MCPToolCallError((global::tryAGI.OpenAI.MCPProtocolError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPProtocolError?(MCPToolCallError @this) => @this.McpProtocolError;

        /// <summary>
        ///
        /// </summary>
        public MCPToolCallError(global::tryAGI.OpenAI.MCPProtocolError? value)
        {
            McpProtocolError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MCPToolCallError FromMcpProtocolError(global::tryAGI.OpenAI.MCPProtocolError? value) => new MCPToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MCPToolCallError(global::tryAGI.OpenAI.MCPToolExecutionError value) => new MCPToolCallError((global::tryAGI.OpenAI.MCPToolExecutionError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolExecutionError?(MCPToolCallError @this) => @this.McpToolExecutionError;

        /// <summary>
        ///
        /// </summary>
        public MCPToolCallError(global::tryAGI.OpenAI.MCPToolExecutionError? value)
        {
            McpToolExecutionError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MCPToolCallError FromMcpToolExecutionError(global::tryAGI.OpenAI.MCPToolExecutionError? value) => new MCPToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MCPToolCallError(global::tryAGI.OpenAI.HTTPError value) => new MCPToolCallError((global::tryAGI.OpenAI.HTTPError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HTTPError?(MCPToolCallError @this) => @this.HttpError;

        /// <summary>
        ///
        /// </summary>
        public MCPToolCallError(global::tryAGI.OpenAI.HTTPError? value)
        {
            HttpError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MCPToolCallError FromHttpError(global::tryAGI.OpenAI.HTTPError? value) => new MCPToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public MCPToolCallError(
            global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType? type,
            global::tryAGI.OpenAI.MCPProtocolError? mcpProtocolError,
            global::tryAGI.OpenAI.MCPToolExecutionError? mcpToolExecutionError,
            global::tryAGI.OpenAI.HTTPError? httpError
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
            global::System.Func<global::tryAGI.OpenAI.MCPProtocolError, TResult>? mcpProtocolError = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolExecutionError, TResult>? mcpToolExecutionError = null,
            global::System.Func<global::tryAGI.OpenAI.HTTPError, TResult>? httpError = null,
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
            global::System.Action<global::tryAGI.OpenAI.MCPProtocolError>? mcpProtocolError = null,

            global::System.Action<global::tryAGI.OpenAI.MCPToolExecutionError>? mcpToolExecutionError = null,

            global::System.Action<global::tryAGI.OpenAI.HTTPError>? httpError = null,
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
            global::System.Action<global::tryAGI.OpenAI.MCPProtocolError>? mcpProtocolError = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolExecutionError>? mcpToolExecutionError = null,
            global::System.Action<global::tryAGI.OpenAI.HTTPError>? httpError = null,
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
                typeof(global::tryAGI.OpenAI.MCPProtocolError),
                McpToolExecutionError,
                typeof(global::tryAGI.OpenAI.MCPToolExecutionError),
                HttpError,
                typeof(global::tryAGI.OpenAI.HTTPError),
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
        public bool Equals(MCPToolCallError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPProtocolError?>.Default.Equals(McpProtocolError, other.McpProtocolError) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolExecutionError?>.Default.Equals(McpToolExecutionError, other.McpToolExecutionError) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HTTPError?>.Default.Equals(HttpError, other.HttpError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MCPToolCallError obj1, MCPToolCallError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MCPToolCallError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MCPToolCallError obj1, MCPToolCallError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MCPToolCallError o && Equals(o);
        }
    }
}
