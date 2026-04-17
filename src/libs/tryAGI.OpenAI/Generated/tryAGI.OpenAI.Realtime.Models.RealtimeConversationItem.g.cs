#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// A single item within a Realtime conversation.
    /// </summary>
    public readonly partial struct RealtimeConversationItem : global::System.IEquatable<RealtimeConversationItem>
    {
        /// <summary>
        /// A system message in a Realtime conversation can be used to provide additional context or instructions to the model. This is similar but distinct from the instruction prompt provided at the start of a conversation, as system messages can be added at any point in the conversation. For major changes to the conversation's behavior, use instructions, but for smaller updates (e.g. "the user is now asking about a different topic"), use system messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem? Message1 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem? Message1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message1))]
#endif
        public bool IsMessage1 => Message1 != null;

        /// <summary>
        /// A user message item in a Realtime conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser? Message2 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser? Message2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message2))]
#endif
        public bool IsMessage2 => Message2 != null;

        /// <summary>
        /// An assistant message item in a Realtime conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant? Message3 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant? Message3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message3))]
#endif
        public bool IsMessage3 => Message3 != null;

        /// <summary>
        /// A function call item in a Realtime conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall? FunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        /// A function call output item in a Realtime conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput? FunctionCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        /// A Realtime item responding to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse? McpApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        /// A Realtime item listing tools available on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools? McpListTools { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools? McpListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListTools))]
#endif
        public bool IsMcpListTools => McpListTools != null;

        /// <summary>
        /// A Realtime item representing an invocation of a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall? McpCall { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall? McpCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCall))]
#endif
        public bool IsMcpCall => McpCall != null;

        /// <summary>
        /// A Realtime item requesting human approval of a tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest? McpApprovalRequest { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest? McpApprovalRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalRequest))]
#endif
        public bool IsMcpApprovalRequest => McpApprovalRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem?(RealtimeConversationItem @this) => @this.Message1;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem? value)
        {
            Message1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser?(RealtimeConversationItem @this) => @this.Message2;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser? value)
        {
            Message2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant?(RealtimeConversationItem @this) => @this.Message3;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant? value)
        {
            Message3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall?(RealtimeConversationItem @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput?(RealtimeConversationItem @this) => @this.FunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse?(RealtimeConversationItem @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools?(RealtimeConversationItem @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall?(RealtimeConversationItem @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest value) => new RealtimeConversationItem((global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest?(RealtimeConversationItem @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeConversationItem(
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem? message1,
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser? message2,
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant? message3,
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall? functionCall,
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse? mcpApprovalResponse,
            global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools? mcpListTools,
            global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall? mcpCall,
            global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest? mcpApprovalRequest
            )
        {
            Message1 = message1;
            Message2 = message2;
            Message3 = message3;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            McpApprovalResponse = mcpApprovalResponse;
            McpListTools = mcpListTools;
            McpCall = mcpCall;
            McpApprovalRequest = mcpApprovalRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpApprovalRequest as object ??
            McpCall as object ??
            McpListTools as object ??
            McpApprovalResponse as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            Message3 as object ??
            Message2 as object ??
            Message1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message1?.ToString() ??
            Message2?.ToString() ??
            Message3?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            McpApprovalResponse?.ToString() ??
            McpListTools?.ToString() ??
            McpCall?.ToString() ??
            McpApprovalRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage1 || IsMessage2 || IsMessage3 || IsFunctionCall || IsFunctionCallOutput || IsMcpApprovalResponse || IsMcpListTools || IsMcpCall || IsMcpApprovalRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem?, TResult>? message1 = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser?, TResult>? message2 = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant?, TResult>? message3 = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall?, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput?, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools?, TResult>? mcpListTools = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall?, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest?, TResult>? mcpApprovalRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1 && message1 != null)
            {
                return message1(Message1!);
            }
            else if (IsMessage2 && message2 != null)
            {
                return message2(Message2!);
            }
            else if (IsMessage3 && message3 != null)
            {
                return message3(Message3!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsMcpApprovalResponse && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(McpApprovalResponse!);
            }
            else if (IsMcpListTools && mcpListTools != null)
            {
                return mcpListTools(McpListTools!);
            }
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }
            else if (IsMcpApprovalRequest && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(McpApprovalRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem?>? message1 = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser?>? message2 = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant?>? message3 = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall?>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput?>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse?>? mcpApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools?>? mcpListTools = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall?>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest?>? mcpApprovalRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage1)
            {
                message1?.Invoke(Message1!);
            }
            else if (IsMessage2)
            {
                message2?.Invoke(Message2!);
            }
            else if (IsMessage3)
            {
                message3?.Invoke(Message3!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message1,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem),
                Message2,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser),
                Message3,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse),
                McpListTools,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools),
                McpCall,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall),
                McpApprovalRequest,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest),
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
        public bool Equals(RealtimeConversationItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageSystem?>.Default.Equals(Message1, other.Message1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUser?>.Default.Equals(Message2, other.Message2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageAssistant?>.Default.Equals(Message3, other.Message3) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeConversationItemFunctionCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalResponse?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeMCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeMCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeMCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeConversationItem obj1, RealtimeConversationItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeConversationItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeConversationItem obj1, RealtimeConversationItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeConversationItem o && Equals(o);
        }
    }
}
