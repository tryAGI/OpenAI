#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Information for presenting an MCP approval.
    /// </summary>
    public readonly partial struct McpApprovalRequestResource : global::System.IEquatable<McpApprovalRequestResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? McpToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? McpToolCall { get; }
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
            out global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? value)
        {
            value = McpToolCall;
            return IsMcpToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall PickMcpToolCall() => McpToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpApprovalRequestResource(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall value) => new McpApprovalRequestResource((global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall?(McpApprovalRequestResource @this) => @this.McpToolCall;

        /// <summary>
        ///
        /// </summary>
        public McpApprovalRequestResource(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? value)
        {
            McpToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpApprovalRequestResource FromMcpToolCall(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? value) => new McpApprovalRequestResource(value);

        /// <summary>
        ///
        /// </summary>
        public McpApprovalRequestResource(
            global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? mcpToolCall
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
            global::System.Func<global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall, TResult>? mcpToolCall = null,
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
            global::System.Action<global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall>? mcpToolCall = null,
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
            global::System.Action<global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall>? mcpToolCall = null,
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
                typeof(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall),
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
        public bool Equals(McpApprovalRequestResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall?>.Default.Equals(McpToolCall, other.McpToolCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(McpApprovalRequestResource obj1, McpApprovalRequestResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpApprovalRequestResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpApprovalRequestResource obj1, McpApprovalRequestResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpApprovalRequestResource o && Equals(o);
        }
    }
}
