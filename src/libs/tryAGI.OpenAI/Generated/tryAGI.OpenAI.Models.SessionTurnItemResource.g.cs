#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An item associated with a session turn.
    /// </summary>
    public readonly partial struct SessionTurnItemResource : global::System.IEquatable<SessionTurnItemResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A user or assistant message recorded in a session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageItemResource? Message { get; init; }
#else
        public global::tryAGI.OpenAI.MessageItemResource? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.MessageItemResource? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageItemResource PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// A reasoning item produced by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ReasoningItemResource? Reasoning { get; init; }
#else
        public global::tryAGI.OpenAI.ReasoningItemResource? Reasoning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ReasoningItemResource? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningItemResource PickReasoning() => IsReasoning
            ? Reasoning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// A function call produced by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionCallItemResource? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionCallItemResource? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.FunctionCallItemResource? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallItemResource PickFunctionCall() => IsFunctionCall
            ? FunctionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// The result supplied for a function call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource? FunctionCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.FunctionCallOutputItemResource? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionCallOutputItemResource PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A message exchanged between agent threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentMessageItemResource? AgentMessage { get; init; }
#else
        public global::tryAGI.OpenAI.AgentMessageItemResource? AgentMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessage))]
#endif
        public bool IsAgentMessage => AgentMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AgentMessageItemResource? value)
        {
            value = AgentMessage;
            return IsAgentMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentMessageItemResource PickAgentMessage() => IsAgentMessage
            ? AgentMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessage' but the value was {ToString()}.");

        /// <summary>
        /// A call to a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpCallItemResource? McpCall { get; init; }
#else
        public global::tryAGI.OpenAI.McpCallItemResource? McpCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCall))]
#endif
        public bool IsMcpCall => McpCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.McpCallItemResource? value)
        {
            value = McpCall;
            return IsMcpCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpCallItemResource PickMcpCall() => IsMcpCall
            ? McpCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpCall' but the value was {ToString()}.");

        /// <summary>
        /// A web search call produced by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchCallItemResource? WebSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchCallItemResource? WebSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebSearchCallItemResource? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchCallItemResource PickWebSearchCall() => IsWebSearchCall
            ? WebSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// A command execution produced by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CommandExecutionItemResource? CommandExecution { get; init; }
#else
        public global::tryAGI.OpenAI.CommandExecutionItemResource? CommandExecution { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommandExecution))]
#endif
        public bool IsCommandExecution => CommandExecution != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommandExecution(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CommandExecutionItemResource? value)
        {
            value = CommandExecution;
            return IsCommandExecution;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CommandExecutionItemResource PickCommandExecution() => IsCommandExecution
            ? CommandExecution!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommandExecution' but the value was {ToString()}.");

        /// <summary>
        /// A request to spawn a subagent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? CreateSubagentCall { get; init; }
#else
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource? CreateSubagentCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSubagentCall))]
#endif
        public bool IsCreateSubagentCall => CreateSubagentCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSubagentCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CreateSubagentCallItemResource? value)
        {
            value = CreateSubagentCall;
            return IsCreateSubagentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateSubagentCallItemResource PickCreateSubagentCall() => IsCreateSubagentCall
            ? CreateSubagentCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSubagentCall' but the value was {ToString()}.");

        /// <summary>
        /// A request to send input to another agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? SendSubagentInputCall { get; init; }
#else
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource? SendSubagentInputCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SendSubagentInputCall))]
#endif
        public bool IsSendSubagentInputCall => SendSubagentInputCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSendSubagentInputCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SendSubagentInputCallItemResource? value)
        {
            value = SendSubagentInputCall;
            return IsSendSubagentInputCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SendSubagentInputCallItemResource PickSendSubagentInputCall() => IsSendSubagentInputCall
            ? SendSubagentInputCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SendSubagentInputCall' but the value was {ToString()}.");

        /// <summary>
        /// A request to resume a subagent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? ResumeSubagentCall { get; init; }
#else
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource? ResumeSubagentCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResumeSubagentCall))]
#endif
        public bool IsResumeSubagentCall => ResumeSubagentCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResumeSubagentCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResumeSubagentCallItemResource? value)
        {
            value = ResumeSubagentCall;
            return IsResumeSubagentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResumeSubagentCallItemResource PickResumeSubagentCall() => IsResumeSubagentCall
            ? ResumeSubagentCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResumeSubagentCall' but the value was {ToString()}.");

        /// <summary>
        /// A request to wait for one or more subagents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? WaitForSubagentsCall { get; init; }
#else
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? WaitForSubagentsCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WaitForSubagentsCall))]
#endif
        public bool IsWaitForSubagentsCall => WaitForSubagentsCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWaitForSubagentsCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? value)
        {
            value = WaitForSubagentsCall;
            return IsWaitForSubagentsCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WaitForSubagentsCallItemResource PickWaitForSubagentsCall() => IsWaitForSubagentsCall
            ? WaitForSubagentsCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WaitForSubagentsCall' but the value was {ToString()}.");

        /// <summary>
        /// A request to interrupt a subagent's current turn. The subagent remains available.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? InterruptSubagentCall { get; init; }
#else
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource? InterruptSubagentCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InterruptSubagentCall))]
#endif
        public bool IsInterruptSubagentCall => InterruptSubagentCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInterruptSubagentCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InterruptSubagentCallItemResource? value)
        {
            value = InterruptSubagentCall;
            return IsInterruptSubagentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InterruptSubagentCallItemResource PickInterruptSubagentCall() => IsInterruptSubagentCall
            ? InterruptSubagentCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InterruptSubagentCall' but the value was {ToString()}.");

        /// <summary>
        /// A request to close a subagent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? CloseSubagentCall { get; init; }
#else
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource? CloseSubagentCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CloseSubagentCall))]
#endif
        public bool IsCloseSubagentCall => CloseSubagentCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCloseSubagentCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CloseSubagentCallItemResource? value)
        {
            value = CloseSubagentCall;
            return IsCloseSubagentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CloseSubagentCallItemResource PickCloseSubagentCall() => IsCloseSubagentCall
            ? CloseSubagentCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CloseSubagentCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.MessageItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.MessageItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageItemResource?(SessionTurnItemResource @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.MessageItemResource? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromMessage(global::tryAGI.OpenAI.MessageItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.ReasoningItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.ReasoningItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningItemResource?(SessionTurnItemResource @this) => @this.Reasoning;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.ReasoningItemResource? value)
        {
            Reasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromReasoning(global::tryAGI.OpenAI.ReasoningItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.FunctionCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.FunctionCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionCallItemResource?(SessionTurnItemResource @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.FunctionCallItemResource? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromFunctionCall(global::tryAGI.OpenAI.FunctionCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.FunctionCallOutputItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.FunctionCallOutputItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionCallOutputItemResource?(SessionTurnItemResource @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.FunctionCallOutputItemResource? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromFunctionCallOutput(global::tryAGI.OpenAI.FunctionCallOutputItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.AgentMessageItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.AgentMessageItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentMessageItemResource?(SessionTurnItemResource @this) => @this.AgentMessage;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.AgentMessageItemResource? value)
        {
            AgentMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromAgentMessage(global::tryAGI.OpenAI.AgentMessageItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.McpCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.McpCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpCallItemResource?(SessionTurnItemResource @this) => @this.McpCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.McpCallItemResource? value)
        {
            McpCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromMcpCall(global::tryAGI.OpenAI.McpCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.WebSearchCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.WebSearchCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchCallItemResource?(SessionTurnItemResource @this) => @this.WebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.WebSearchCallItemResource? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromWebSearchCall(global::tryAGI.OpenAI.WebSearchCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.CommandExecutionItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.CommandExecutionItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CommandExecutionItemResource?(SessionTurnItemResource @this) => @this.CommandExecution;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.CommandExecutionItemResource? value)
        {
            CommandExecution = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromCommandExecution(global::tryAGI.OpenAI.CommandExecutionItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.CreateSubagentCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.CreateSubagentCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateSubagentCallItemResource?(SessionTurnItemResource @this) => @this.CreateSubagentCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.CreateSubagentCallItemResource? value)
        {
            CreateSubagentCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromCreateSubagentCall(global::tryAGI.OpenAI.CreateSubagentCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.SendSubagentInputCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.SendSubagentInputCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SendSubagentInputCallItemResource?(SessionTurnItemResource @this) => @this.SendSubagentInputCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.SendSubagentInputCallItemResource? value)
        {
            SendSubagentInputCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromSendSubagentInputCall(global::tryAGI.OpenAI.SendSubagentInputCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.ResumeSubagentCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.ResumeSubagentCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResumeSubagentCallItemResource?(SessionTurnItemResource @this) => @this.ResumeSubagentCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.ResumeSubagentCallItemResource? value)
        {
            ResumeSubagentCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromResumeSubagentCall(global::tryAGI.OpenAI.ResumeSubagentCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.WaitForSubagentsCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WaitForSubagentsCallItemResource?(SessionTurnItemResource @this) => @this.WaitForSubagentsCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? value)
        {
            WaitForSubagentsCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromWaitForSubagentsCall(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.InterruptSubagentCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.InterruptSubagentCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InterruptSubagentCallItemResource?(SessionTurnItemResource @this) => @this.InterruptSubagentCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.InterruptSubagentCallItemResource? value)
        {
            InterruptSubagentCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromInterruptSubagentCall(global::tryAGI.OpenAI.InterruptSubagentCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionTurnItemResource(global::tryAGI.OpenAI.CloseSubagentCallItemResource value) => new SessionTurnItemResource((global::tryAGI.OpenAI.CloseSubagentCallItemResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CloseSubagentCallItemResource?(SessionTurnItemResource @this) => @this.CloseSubagentCall;

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(global::tryAGI.OpenAI.CloseSubagentCallItemResource? value)
        {
            CloseSubagentCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionTurnItemResource FromCloseSubagentCall(global::tryAGI.OpenAI.CloseSubagentCallItemResource? value) => new SessionTurnItemResource(value);

        /// <summary>
        ///
        /// </summary>
        public SessionTurnItemResource(
            global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.MessageItemResource? message,
            global::tryAGI.OpenAI.ReasoningItemResource? reasoning,
            global::tryAGI.OpenAI.FunctionCallItemResource? functionCall,
            global::tryAGI.OpenAI.FunctionCallOutputItemResource? functionCallOutput,
            global::tryAGI.OpenAI.AgentMessageItemResource? agentMessage,
            global::tryAGI.OpenAI.McpCallItemResource? mcpCall,
            global::tryAGI.OpenAI.WebSearchCallItemResource? webSearchCall,
            global::tryAGI.OpenAI.CommandExecutionItemResource? commandExecution,
            global::tryAGI.OpenAI.CreateSubagentCallItemResource? createSubagentCall,
            global::tryAGI.OpenAI.SendSubagentInputCallItemResource? sendSubagentInputCall,
            global::tryAGI.OpenAI.ResumeSubagentCallItemResource? resumeSubagentCall,
            global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? waitForSubagentsCall,
            global::tryAGI.OpenAI.InterruptSubagentCallItemResource? interruptSubagentCall,
            global::tryAGI.OpenAI.CloseSubagentCallItemResource? closeSubagentCall
            )
        {
            Type = type;

            Message = message;
            Reasoning = reasoning;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            AgentMessage = agentMessage;
            McpCall = mcpCall;
            WebSearchCall = webSearchCall;
            CommandExecution = commandExecution;
            CreateSubagentCall = createSubagentCall;
            SendSubagentInputCall = sendSubagentInputCall;
            ResumeSubagentCall = resumeSubagentCall;
            WaitForSubagentsCall = waitForSubagentsCall;
            InterruptSubagentCall = interruptSubagentCall;
            CloseSubagentCall = closeSubagentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CloseSubagentCall as object ??
            InterruptSubagentCall as object ??
            WaitForSubagentsCall as object ??
            ResumeSubagentCall as object ??
            SendSubagentInputCall as object ??
            CreateSubagentCall as object ??
            CommandExecution as object ??
            WebSearchCall as object ??
            McpCall as object ??
            AgentMessage as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            Reasoning as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Reasoning?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            AgentMessage?.ToString() ??
            McpCall?.ToString() ??
            WebSearchCall?.ToString() ??
            CommandExecution?.ToString() ??
            CreateSubagentCall?.ToString() ??
            SendSubagentInputCall?.ToString() ??
            ResumeSubagentCall?.ToString() ??
            WaitForSubagentsCall?.ToString() ??
            InterruptSubagentCall?.ToString() ??
            CloseSubagentCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && IsWaitForSubagentsCall && !IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && IsInterruptSubagentCall && !IsCloseSubagentCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMcpCall && !IsWebSearchCall && !IsCommandExecution && !IsCreateSubagentCall && !IsSendSubagentInputCall && !IsResumeSubagentCall && !IsWaitForSubagentsCall && !IsInterruptSubagentCall && IsCloseSubagentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.MessageItemResource, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItemResource, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionCallItemResource, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionCallOutputItemResource, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.AgentMessageItemResource, TResult>? agentMessage = null,
            global::System.Func<global::tryAGI.OpenAI.McpCallItemResource, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchCallItemResource, TResult>? webSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.CommandExecutionItemResource, TResult>? commandExecution = null,
            global::System.Func<global::tryAGI.OpenAI.CreateSubagentCallItemResource, TResult>? createSubagentCall = null,
            global::System.Func<global::tryAGI.OpenAI.SendSubagentInputCallItemResource, TResult>? sendSubagentInputCall = null,
            global::System.Func<global::tryAGI.OpenAI.ResumeSubagentCallItemResource, TResult>? resumeSubagentCall = null,
            global::System.Func<global::tryAGI.OpenAI.WaitForSubagentsCallItemResource, TResult>? waitForSubagentsCall = null,
            global::System.Func<global::tryAGI.OpenAI.InterruptSubagentCallItemResource, TResult>? interruptSubagentCall = null,
            global::System.Func<global::tryAGI.OpenAI.CloseSubagentCallItemResource, TResult>? closeSubagentCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsAgentMessage && agentMessage != null)
            {
                return agentMessage(AgentMessage!);
            }
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsCommandExecution && commandExecution != null)
            {
                return commandExecution(CommandExecution!);
            }
            else if (IsCreateSubagentCall && createSubagentCall != null)
            {
                return createSubagentCall(CreateSubagentCall!);
            }
            else if (IsSendSubagentInputCall && sendSubagentInputCall != null)
            {
                return sendSubagentInputCall(SendSubagentInputCall!);
            }
            else if (IsResumeSubagentCall && resumeSubagentCall != null)
            {
                return resumeSubagentCall(ResumeSubagentCall!);
            }
            else if (IsWaitForSubagentsCall && waitForSubagentsCall != null)
            {
                return waitForSubagentsCall(WaitForSubagentsCall!);
            }
            else if (IsInterruptSubagentCall && interruptSubagentCall != null)
            {
                return interruptSubagentCall(InterruptSubagentCall!);
            }
            else if (IsCloseSubagentCall && closeSubagentCall != null)
            {
                return closeSubagentCall(CloseSubagentCall!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.MessageItemResource>? message = null,

            global::System.Action<global::tryAGI.OpenAI.ReasoningItemResource>? reasoning = null,

            global::System.Action<global::tryAGI.OpenAI.FunctionCallItemResource>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.FunctionCallOutputItemResource>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.AgentMessageItemResource>? agentMessage = null,

            global::System.Action<global::tryAGI.OpenAI.McpCallItemResource>? mcpCall = null,

            global::System.Action<global::tryAGI.OpenAI.WebSearchCallItemResource>? webSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.CommandExecutionItemResource>? commandExecution = null,

            global::System.Action<global::tryAGI.OpenAI.CreateSubagentCallItemResource>? createSubagentCall = null,

            global::System.Action<global::tryAGI.OpenAI.SendSubagentInputCallItemResource>? sendSubagentInputCall = null,

            global::System.Action<global::tryAGI.OpenAI.ResumeSubagentCallItemResource>? resumeSubagentCall = null,

            global::System.Action<global::tryAGI.OpenAI.WaitForSubagentsCallItemResource>? waitForSubagentsCall = null,

            global::System.Action<global::tryAGI.OpenAI.InterruptSubagentCallItemResource>? interruptSubagentCall = null,

            global::System.Action<global::tryAGI.OpenAI.CloseSubagentCallItemResource>? closeSubagentCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsCommandExecution)
            {
                commandExecution?.Invoke(CommandExecution!);
            }
            else if (IsCreateSubagentCall)
            {
                createSubagentCall?.Invoke(CreateSubagentCall!);
            }
            else if (IsSendSubagentInputCall)
            {
                sendSubagentInputCall?.Invoke(SendSubagentInputCall!);
            }
            else if (IsResumeSubagentCall)
            {
                resumeSubagentCall?.Invoke(ResumeSubagentCall!);
            }
            else if (IsWaitForSubagentsCall)
            {
                waitForSubagentsCall?.Invoke(WaitForSubagentsCall!);
            }
            else if (IsInterruptSubagentCall)
            {
                interruptSubagentCall?.Invoke(InterruptSubagentCall!);
            }
            else if (IsCloseSubagentCall)
            {
                closeSubagentCall?.Invoke(CloseSubagentCall!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.MessageItemResource>? message = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItemResource>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionCallItemResource>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionCallOutputItemResource>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.AgentMessageItemResource>? agentMessage = null,
            global::System.Action<global::tryAGI.OpenAI.McpCallItemResource>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchCallItemResource>? webSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.CommandExecutionItemResource>? commandExecution = null,
            global::System.Action<global::tryAGI.OpenAI.CreateSubagentCallItemResource>? createSubagentCall = null,
            global::System.Action<global::tryAGI.OpenAI.SendSubagentInputCallItemResource>? sendSubagentInputCall = null,
            global::System.Action<global::tryAGI.OpenAI.ResumeSubagentCallItemResource>? resumeSubagentCall = null,
            global::System.Action<global::tryAGI.OpenAI.WaitForSubagentsCallItemResource>? waitForSubagentsCall = null,
            global::System.Action<global::tryAGI.OpenAI.InterruptSubagentCallItemResource>? interruptSubagentCall = null,
            global::System.Action<global::tryAGI.OpenAI.CloseSubagentCallItemResource>? closeSubagentCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsCommandExecution)
            {
                commandExecution?.Invoke(CommandExecution!);
            }
            else if (IsCreateSubagentCall)
            {
                createSubagentCall?.Invoke(CreateSubagentCall!);
            }
            else if (IsSendSubagentInputCall)
            {
                sendSubagentInputCall?.Invoke(SendSubagentInputCall!);
            }
            else if (IsResumeSubagentCall)
            {
                resumeSubagentCall?.Invoke(ResumeSubagentCall!);
            }
            else if (IsWaitForSubagentsCall)
            {
                waitForSubagentsCall?.Invoke(WaitForSubagentsCall!);
            }
            else if (IsInterruptSubagentCall)
            {
                interruptSubagentCall?.Invoke(InterruptSubagentCall!);
            }
            else if (IsCloseSubagentCall)
            {
                closeSubagentCall?.Invoke(CloseSubagentCall!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::tryAGI.OpenAI.MessageItemResource),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItemResource),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.FunctionCallItemResource),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResource),
                AgentMessage,
                typeof(global::tryAGI.OpenAI.AgentMessageItemResource),
                McpCall,
                typeof(global::tryAGI.OpenAI.McpCallItemResource),
                WebSearchCall,
                typeof(global::tryAGI.OpenAI.WebSearchCallItemResource),
                CommandExecution,
                typeof(global::tryAGI.OpenAI.CommandExecutionItemResource),
                CreateSubagentCall,
                typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResource),
                SendSubagentInputCall,
                typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource),
                ResumeSubagentCall,
                typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource),
                WaitForSubagentsCall,
                typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource),
                InterruptSubagentCall,
                typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource),
                CloseSubagentCall,
                typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResource),
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
        public bool Equals(SessionTurnItemResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageItemResource?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItemResource?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionCallItemResource?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionCallOutputItemResource?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentMessageItemResource?>.Default.Equals(AgentMessage, other.AgentMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpCallItemResource?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchCallItemResource?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CommandExecutionItemResource?>.Default.Equals(CommandExecution, other.CommandExecution) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateSubagentCallItemResource?>.Default.Equals(CreateSubagentCall, other.CreateSubagentCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SendSubagentInputCallItemResource?>.Default.Equals(SendSubagentInputCall, other.SendSubagentInputCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResumeSubagentCallItemResource?>.Default.Equals(ResumeSubagentCall, other.ResumeSubagentCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WaitForSubagentsCallItemResource?>.Default.Equals(WaitForSubagentsCall, other.WaitForSubagentsCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InterruptSubagentCallItemResource?>.Default.Equals(InterruptSubagentCall, other.InterruptSubagentCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CloseSubagentCallItemResource?>.Default.Equals(CloseSubagentCall, other.CloseSubagentCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SessionTurnItemResource obj1, SessionTurnItemResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionTurnItemResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SessionTurnItemResource obj1, SessionTurnItemResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionTurnItemResource o && Equals(o);
        }
    }
}
