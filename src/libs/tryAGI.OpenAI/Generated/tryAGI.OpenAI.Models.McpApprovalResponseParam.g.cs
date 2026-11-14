#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The user's decision for a pending MCP tool call.
    /// </summary>
    public readonly partial struct McpApprovalResponseParam : global::System.IEquatable<McpApprovalResponseParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? McpToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? McpToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolCall))]
#endif
        public bool IsMcpToolCall => McpToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? value)
        {
            value = McpToolCall;
            return IsMcpToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall PickMcpToolCall() => McpToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpApprovalResponseParam(global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall value) => new McpApprovalResponseParam((global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall?(McpApprovalResponseParam @this) => @this.McpToolCall;

        /// <summary>
        ///
        /// </summary>
        public McpApprovalResponseParam(global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? value)
        {
            McpToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpApprovalResponseParam FromMcpToolCall(global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? value) => new McpApprovalResponseParam(value);

        /// <summary>
        ///
        /// </summary>
        public McpApprovalResponseParam(
            global::tryAGI.OpenAI.McpApprovalResponseParamDiscriminatorType? type,
            global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall? mcpToolCall
            )
        {
            Type = type;

            McpToolCall = mcpToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            McpToolCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            McpToolCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMcpToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall, TResult>? mcpToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpToolCall is { } __value0 && mcpToolCall != null)
            {
                return mcpToolCall(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall>? mcpToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpToolCall is { } __value0)
            {
                mcpToolCall?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall>? mcpToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpToolCall is { } __value0)
            {
                mcpToolCall?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpToolCall,
                typeof(global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall),
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
        public bool Equals(McpApprovalResponseParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpApprovalResponseParamMcpToolCall?>.Default.Equals(McpToolCall, other.McpToolCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(McpApprovalResponseParam obj1, McpApprovalResponseParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpApprovalResponseParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpApprovalResponseParam obj1, McpApprovalResponseParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpApprovalResponseParam o && Equals(o);
        }
    }
}
