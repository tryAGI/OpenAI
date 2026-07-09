#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct BetaItem : global::System.IEquatable<BetaItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A message input to the model with a role indicating instruction following<br/>
        /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
        /// precedence over instructions given with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputMessage? Message1 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputMessage? Message1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message1))]
#endif
        public bool IsMessage1 => Message1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputMessage? value)
        {
            value = Message1;
            return IsMessage1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage PickMessage1() => IsMessage1
            ? Message1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message1' but the value was {ToString()}.");

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaOutputMessage? Message2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaOutputMessage? Message2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message2))]
#endif
        public bool IsMessage2 => Message2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessage2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaOutputMessage? value)
        {
            value = Message2;
            return IsMessage2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessage PickMessage2() => IsMessage2
            ? Message2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message2' but the value was {ToString()}.");

        /// <summary>
        /// The results of a file search tool call. See the<br/>
        /// [file search guide](/docs/guides/tools-file-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? FileSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFileSearchToolCall? FileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFileSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFileSearchToolCall? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchToolCall PickFileSearchCall() => IsFileSearchCall
            ? FileSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// A tool call to a computer use tool. See the<br/>
        /// [computer use guide](/docs/guides/tools-computer-use) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerToolCall? ComputerCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerToolCall? ComputerCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCall))]
#endif
        public bool IsComputerCall => ComputerCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerToolCall? value)
        {
            value = ComputerCall;
            return IsComputerCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCall PickComputerCall() => IsComputerCall
            ? ComputerCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? ComputerCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? ComputerCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutput))]
#endif
        public bool IsComputerCallOutput => ComputerCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputerCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? value)
        {
            value = ComputerCallOutput;
            return IsComputerCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerCallOutputItemParam PickComputerCallOutput() => IsComputerCallOutput
            ? ComputerCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// The results of a web search tool call. See the<br/>
        /// [web search guide](/docs/guides/tools-web-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? WebSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWebSearchToolCall? WebSearchCall { get; }
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
            out global::tryAGI.OpenAI.BetaWebSearchToolCall? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchToolCall PickWebSearchCall() => IsWebSearchCall
            ? WebSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolCall? FunctionCall { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionToolCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCall PickFunctionCall() => IsFunctionCall
            ? FunctionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A message routed between agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? AgentMessage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam? AgentMessage { get; }
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
            out global::tryAGI.OpenAI.BetaAgentMessageItemParam? value)
        {
            value = AgentMessage;
            return IsAgentMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParam PickAgentMessage() => IsAgentMessage
            ? AgentMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessage' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? MultiAgentCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? MultiAgentCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MultiAgentCall))]
#endif
        public bool IsMultiAgentCall => MultiAgentCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMultiAgentCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? value)
        {
            value = MultiAgentCall;
            return IsMultiAgentCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallItemParam PickMultiAgentCall() => IsMultiAgentCall
            ? MultiAgentCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MultiAgentCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? MultiAgentCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? MultiAgentCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MultiAgentCallOutput))]
#endif
        public bool IsMultiAgentCallOutput => MultiAgentCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMultiAgentCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? value)
        {
            value = MultiAgentCallOutput;
            return IsMultiAgentCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam PickMultiAgentCallOutput() => IsMultiAgentCallOutput
            ? MultiAgentCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MultiAgentCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? ToolSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam? ToolSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchCall))]
#endif
        public bool IsToolSearchCall => ToolSearchCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolSearchCallItemParam? value)
        {
            value = ToolSearchCall;
            return IsToolSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCallItemParam PickToolSearchCall() => IsToolSearchCall
            ? ToolSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? ToolSearchOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? ToolSearchOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchOutput))]
#endif
        public bool IsToolSearchOutput => ToolSearchOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolSearchOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? value)
        {
            value = ToolSearchOutput;
            return IsToolSearchOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutputItemParam PickToolSearchOutput() => IsToolSearchOutput
            ? ToolSearchOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? AdditionalTools { get; init; }
#else
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? AdditionalTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdditionalTools))]
#endif
        public bool IsAdditionalTools => AdditionalTools != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdditionalTools(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? value)
        {
            value = AdditionalTools;
            return IsAdditionalTools;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalToolsItemParam PickAdditionalTools() => IsAdditionalTools
            ? AdditionalTools!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdditionalTools' but the value was {ToString()}.");

        /// <summary>
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response. Be sure to include these items in your `input` to the Responses API<br/>
        /// for subsequent turns of a conversation if you are manually<br/>
        /// [managing context](/docs/guides/conversation-state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaReasoningItem? Reasoning { get; init; }
#else
        public global::tryAGI.OpenAI.BetaReasoningItem? Reasoning { get; }
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
            out global::tryAGI.OpenAI.BetaReasoningItem? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningItem PickReasoning() => IsReasoning
            ? Reasoning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// A compaction item generated by the [`v1/responses/compact` API](/docs/api-reference/responses/compact).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Compaction { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionSummaryItemParam PickCompaction() => IsCompaction
            ? Compaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

        /// <summary>
        /// An image generation request made by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaImageGenToolCall? ImageGenerationCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaImageGenToolCall? ImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGenerationCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaImageGenToolCall? value)
        {
            value = ImageGenerationCall;
            return IsImageGenerationCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenToolCall PickImageGenerationCall() => IsImageGenerationCall
            ? ImageGenerationCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationCall' but the value was {ToString()}.");

        /// <summary>
        /// A tool call to run code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? CodeInterpreterCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? CodeInterpreterCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCall))]
#endif
        public bool IsCodeInterpreterCall => CodeInterpreterCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeInterpreterCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? value)
        {
            value = CodeInterpreterCall;
            return IsCodeInterpreterCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterToolCall PickCodeInterpreterCall() => IsCodeInterpreterCall
            ? CodeInterpreterCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCall' but the value was {ToString()}.");

        /// <summary>
        /// A tool call to run a command on the local shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? LocalShellCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaLocalShellToolCall? LocalShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCall))]
#endif
        public bool IsLocalShellCall => LocalShellCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLocalShellCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaLocalShellToolCall? value)
        {
            value = LocalShellCall;
            return IsLocalShellCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCall PickLocalShellCall() => IsLocalShellCall
            ? LocalShellCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LocalShellCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a local shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? LocalShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? LocalShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCallOutput))]
#endif
        public bool IsLocalShellCallOutput => LocalShellCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLocalShellCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? value)
        {
            value = LocalShellCallOutput;
            return IsLocalShellCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolCallOutput PickLocalShellCallOutput() => IsLocalShellCallOutput
            ? LocalShellCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LocalShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A tool representing a request to execute one or more shell commands.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? ShellCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? ShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCall))]
#endif
        public bool IsShellCall => ShellCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickShellCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? value)
        {
            value = ShellCall;
            return IsShellCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParam PickShellCall() => IsShellCall
            ? ShellCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCall' but the value was {ToString()}.");

        /// <summary>
        /// The streamed output items emitted by a shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? ShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? ShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickShellCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? value)
        {
            value = ShellCallOutput;
            return IsShellCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam PickShellCallOutput() => IsShellCallOutput
            ? ShellCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A tool call representing a request to create, delete, or update files using diff patches.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? ApplyPatchCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? ApplyPatchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? value)
        {
            value = ApplyPatchCall;
            return IsApplyPatchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam PickApplyPatchCall() => IsApplyPatchCall
            ? ApplyPatchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCall' but the value was {ToString()}.");

        /// <summary>
        /// The streamed output emitted by an apply patch tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? ApplyPatchCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? ApplyPatchCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutput))]
#endif
        public bool IsApplyPatchCallOutput => ApplyPatchCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? value)
        {
            value = ApplyPatchCallOutput;
            return IsApplyPatchCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam PickApplyPatchCallOutput() => IsApplyPatchCallOutput
            ? ApplyPatchCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A list of tools available on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPListTools? McpListTools { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPListTools? McpListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListTools))]
#endif
        public bool IsMcpListTools => McpListTools != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpListTools(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMCPListTools? value)
        {
            value = McpListTools;
            return IsMcpListTools;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPListTools PickMcpListTools() => IsMcpListTools
            ? McpListTools!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListTools' but the value was {ToString()}.");

        /// <summary>
        /// A request for human approval of a tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? McpApprovalRequest { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest? McpApprovalRequest { get; }
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
        public bool TryPickMcpApprovalRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMCPApprovalRequest? value)
        {
            value = McpApprovalRequest;
            return IsMcpApprovalRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalRequest PickMcpApprovalRequest() => IsMcpApprovalRequest
            ? McpApprovalRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalRequest' but the value was {ToString()}.");

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse? McpApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpApprovalResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMCPApprovalResponse? value)
        {
            value = McpApprovalResponse;
            return IsMcpApprovalResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponse PickMcpApprovalResponse() => IsMcpApprovalResponse
            ? McpApprovalResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalResponse' but the value was {ToString()}.");

        /// <summary>
        /// An invocation of a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPToolCall? McpCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPToolCall? McpCall { get; }
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
            out global::tryAGI.OpenAI.BetaMCPToolCall? value)
        {
            value = McpCall;
            return IsMcpCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPToolCall PickMcpCall() => IsMcpCall
            ? McpCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a custom tool call from your code, being sent back to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? CustomToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutput))]
#endif
        public bool IsCustomToolCallOutput => CustomToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolCallOutput? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput PickCustomToolCallOutput() => IsCustomToolCallOutput
            ? CustomToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolCall? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolCall? CustomToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolCall? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCall PickCustomToolCall() => IsCustomToolCall
            ? CustomToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaInputMessage value) => new BetaItem((global::tryAGI.OpenAI.BetaInputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputMessage?(BetaItem @this) => @this.Message1;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaInputMessage? value)
        {
            Message1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMessage1(global::tryAGI.OpenAI.BetaInputMessage? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaOutputMessage value) => new BetaItem((global::tryAGI.OpenAI.BetaOutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaOutputMessage?(BetaItem @this) => @this.Message2;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaOutputMessage? value)
        {
            Message2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMessage2(global::tryAGI.OpenAI.BetaOutputMessage? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaFileSearchToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaFileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFileSearchToolCall?(BetaItem @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaFileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromFileSearchCall(global::tryAGI.OpenAI.BetaFileSearchToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaComputerToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerToolCall?(BetaItem @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromComputerCall(global::tryAGI.OpenAI.BetaComputerToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaComputerCallOutputItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaComputerCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerCallOutputItemParam?(BetaItem @this) => @this.ComputerCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? value)
        {
            ComputerCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromComputerCallOutput(global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaWebSearchToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaWebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchToolCall?(BetaItem @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaWebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromWebSearchCall(global::tryAGI.OpenAI.BetaWebSearchToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaFunctionToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaFunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCall?(BetaItem @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaFunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromFunctionCall(global::tryAGI.OpenAI.BetaFunctionToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam?(BetaItem @this) => @this.FunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromFunctionCallOutput(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaAgentMessageItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaAgentMessageItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaAgentMessageItemParam?(BetaItem @this) => @this.AgentMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaAgentMessageItemParam? value)
        {
            AgentMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromAgentMessage(global::tryAGI.OpenAI.BetaAgentMessageItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaMultiAgentCallItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaMultiAgentCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMultiAgentCallItemParam?(BetaItem @this) => @this.MultiAgentCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? value)
        {
            MultiAgentCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMultiAgentCall(global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam?(BetaItem @this) => @this.MultiAgentCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? value)
        {
            MultiAgentCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMultiAgentCallOutput(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaToolSearchCallItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaToolSearchCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolSearchCallItemParam?(BetaItem @this) => @this.ToolSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaToolSearchCallItemParam? value)
        {
            ToolSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromToolSearchCall(global::tryAGI.OpenAI.BetaToolSearchCallItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaToolSearchOutputItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaToolSearchOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolSearchOutputItemParam?(BetaItem @this) => @this.ToolSearchOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromToolSearchOutput(global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaAdditionalToolsItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaAdditionalToolsItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaAdditionalToolsItemParam?(BetaItem @this) => @this.AdditionalTools;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? value)
        {
            AdditionalTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromAdditionalTools(global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaReasoningItem value) => new BetaItem((global::tryAGI.OpenAI.BetaReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaReasoningItem?(BetaItem @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromReasoning(global::tryAGI.OpenAI.BetaReasoningItem? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaCompactionSummaryItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaCompactionSummaryItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCompactionSummaryItemParam?(BetaItem @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromCompaction(global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaImageGenToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaImageGenToolCall?(BetaItem @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromImageGenerationCall(global::tryAGI.OpenAI.BetaImageGenToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaCodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCodeInterpreterToolCall?(BetaItem @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromCodeInterpreterCall(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaLocalShellToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaLocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalShellToolCall?(BetaItem @this) => @this.LocalShellCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaLocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromLocalShellCall(global::tryAGI.OpenAI.BetaLocalShellToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput value) => new BetaItem((global::tryAGI.OpenAI.BetaLocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalShellToolCallOutput?(BetaItem @this) => @this.LocalShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? value)
        {
            LocalShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromLocalShellCallOutput(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaFunctionShellCallItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaFunctionShellCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellCallItemParam?(BetaItem @this) => @this.ShellCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? value)
        {
            ShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromShellCall(global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam?(BetaItem @this) => @this.ShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromShellCallOutput(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam?(BetaItem @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromApplyPatchCall(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam value) => new BetaItem((global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam?(BetaItem @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromApplyPatchCallOutput(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaMCPListTools value) => new BetaItem((global::tryAGI.OpenAI.BetaMCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPListTools?(BetaItem @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaMCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMcpListTools(global::tryAGI.OpenAI.BetaMCPListTools? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaMCPApprovalRequest value) => new BetaItem((global::tryAGI.OpenAI.BetaMCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPApprovalRequest?(BetaItem @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaMCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMcpApprovalRequest(global::tryAGI.OpenAI.BetaMCPApprovalRequest? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaMCPApprovalResponse value) => new BetaItem((global::tryAGI.OpenAI.BetaMCPApprovalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPApprovalResponse?(BetaItem @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaMCPApprovalResponse? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMcpApprovalResponse(global::tryAGI.OpenAI.BetaMCPApprovalResponse? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaMCPToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaMCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPToolCall?(BetaItem @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaMCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromMcpCall(global::tryAGI.OpenAI.BetaMCPToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaCustomToolCallOutput value) => new BetaItem((global::tryAGI.OpenAI.BetaCustomToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCallOutput?(BetaItem @this) => @this.CustomToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaCustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromCustomToolCallOutput(global::tryAGI.OpenAI.BetaCustomToolCallOutput? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaItem(global::tryAGI.OpenAI.BetaCustomToolCall value) => new BetaItem((global::tryAGI.OpenAI.BetaCustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCall?(BetaItem @this) => @this.CustomToolCall;

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(global::tryAGI.OpenAI.BetaCustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaItem FromCustomToolCall(global::tryAGI.OpenAI.BetaCustomToolCall? value) => new BetaItem(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaItem(
            global::tryAGI.OpenAI.BetaItemDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaInputMessage? message1,
            global::tryAGI.OpenAI.BetaOutputMessage? message2,
            global::tryAGI.OpenAI.BetaFileSearchToolCall? fileSearchCall,
            global::tryAGI.OpenAI.BetaComputerToolCall? computerCall,
            global::tryAGI.OpenAI.BetaComputerCallOutputItemParam? computerCallOutput,
            global::tryAGI.OpenAI.BetaWebSearchToolCall? webSearchCall,
            global::tryAGI.OpenAI.BetaFunctionToolCall? functionCall,
            global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam? functionCallOutput,
            global::tryAGI.OpenAI.BetaAgentMessageItemParam? agentMessage,
            global::tryAGI.OpenAI.BetaMultiAgentCallItemParam? multiAgentCall,
            global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam? multiAgentCallOutput,
            global::tryAGI.OpenAI.BetaToolSearchCallItemParam? toolSearchCall,
            global::tryAGI.OpenAI.BetaToolSearchOutputItemParam? toolSearchOutput,
            global::tryAGI.OpenAI.BetaAdditionalToolsItemParam? additionalTools,
            global::tryAGI.OpenAI.BetaReasoningItem? reasoning,
            global::tryAGI.OpenAI.BetaCompactionSummaryItemParam? compaction,
            global::tryAGI.OpenAI.BetaImageGenToolCall? imageGenerationCall,
            global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? codeInterpreterCall,
            global::tryAGI.OpenAI.BetaLocalShellToolCall? localShellCall,
            global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? localShellCallOutput,
            global::tryAGI.OpenAI.BetaFunctionShellCallItemParam? shellCall,
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam? shellCallOutput,
            global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam? applyPatchCall,
            global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam? applyPatchCallOutput,
            global::tryAGI.OpenAI.BetaMCPListTools? mcpListTools,
            global::tryAGI.OpenAI.BetaMCPApprovalRequest? mcpApprovalRequest,
            global::tryAGI.OpenAI.BetaMCPApprovalResponse? mcpApprovalResponse,
            global::tryAGI.OpenAI.BetaMCPToolCall? mcpCall,
            global::tryAGI.OpenAI.BetaCustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.BetaCustomToolCall? customToolCall
            )
        {
            Type = type;

            Message1 = message1;
            Message2 = message2;
            FileSearchCall = fileSearchCall;
            ComputerCall = computerCall;
            ComputerCallOutput = computerCallOutput;
            WebSearchCall = webSearchCall;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            AgentMessage = agentMessage;
            MultiAgentCall = multiAgentCall;
            MultiAgentCallOutput = multiAgentCallOutput;
            ToolSearchCall = toolSearchCall;
            ToolSearchOutput = toolSearchOutput;
            AdditionalTools = additionalTools;
            Reasoning = reasoning;
            Compaction = compaction;
            ImageGenerationCall = imageGenerationCall;
            CodeInterpreterCall = codeInterpreterCall;
            LocalShellCall = localShellCall;
            LocalShellCallOutput = localShellCallOutput;
            ShellCall = shellCall;
            ShellCallOutput = shellCallOutput;
            ApplyPatchCall = applyPatchCall;
            ApplyPatchCallOutput = applyPatchCallOutput;
            McpListTools = mcpListTools;
            McpApprovalRequest = mcpApprovalRequest;
            McpApprovalResponse = mcpApprovalResponse;
            McpCall = mcpCall;
            CustomToolCallOutput = customToolCallOutput;
            CustomToolCall = customToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCall as object ??
            CustomToolCallOutput as object ??
            McpCall as object ??
            McpApprovalResponse as object ??
            McpApprovalRequest as object ??
            McpListTools as object ??
            ApplyPatchCallOutput as object ??
            ApplyPatchCall as object ??
            ShellCallOutput as object ??
            ShellCall as object ??
            LocalShellCallOutput as object ??
            LocalShellCall as object ??
            CodeInterpreterCall as object ??
            ImageGenerationCall as object ??
            Compaction as object ??
            Reasoning as object ??
            AdditionalTools as object ??
            ToolSearchOutput as object ??
            ToolSearchCall as object ??
            MultiAgentCallOutput as object ??
            MultiAgentCall as object ??
            AgentMessage as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            WebSearchCall as object ??
            ComputerCallOutput as object ??
            ComputerCall as object ??
            FileSearchCall as object ??
            Message2 as object ??
            Message1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message1?.ToString() ??
            Message2?.ToString() ??
            FileSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerCallOutput?.ToString() ??
            WebSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            AgentMessage?.ToString() ??
            MultiAgentCall?.ToString() ??
            MultiAgentCallOutput?.ToString() ??
            ToolSearchCall?.ToString() ??
            ToolSearchOutput?.ToString() ??
            AdditionalTools?.ToString() ??
            Reasoning?.ToString() ??
            Compaction?.ToString() ??
            ImageGenerationCall?.ToString() ??
            CodeInterpreterCall?.ToString() ??
            LocalShellCall?.ToString() ??
            LocalShellCallOutput?.ToString() ??
            ShellCall?.ToString() ??
            ShellCallOutput?.ToString() ??
            ApplyPatchCall?.ToString() ??
            ApplyPatchCallOutput?.ToString() ??
            McpListTools?.ToString() ??
            McpApprovalRequest?.ToString() ??
            McpApprovalResponse?.ToString() ??
            McpCall?.ToString() ??
            CustomToolCallOutput?.ToString() ??
            CustomToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsAgentMessage && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && IsCustomToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaInputMessage, TResult>? message1 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaOutputMessage, TResult>? message2 = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFileSearchToolCall, TResult>? fileSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerToolCall, TResult>? computerCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerCallOutputItemParam, TResult>? computerCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchToolCall, TResult>? webSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCall, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaAgentMessageItemParam, TResult>? agentMessage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMultiAgentCallItemParam, TResult>? multiAgentCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam, TResult>? multiAgentCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolSearchCallItemParam, TResult>? toolSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolSearchOutputItemParam, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaAdditionalToolsItemParam, TResult>? additionalTools = null,
            global::System.Func<global::tryAGI.OpenAI.BetaReasoningItem, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCompactionSummaryItemParam, TResult>? compaction = null,
            global::System.Func<global::tryAGI.OpenAI.BetaImageGenToolCall, TResult>? imageGenerationCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall, TResult>? codeInterpreterCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaLocalShellToolCall, TResult>? localShellCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput, TResult>? localShellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellCallItemParam, TResult>? shellCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam, TResult>? applyPatchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPListTools, TResult>? mcpListTools = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPApprovalRequest, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPApprovalResponse, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPToolCall, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCallOutput, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCall, TResult>? customToolCall = null,
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
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerCallOutput && computerCallOutput != null)
            {
                return computerCallOutput(ComputerCallOutput!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
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
            else if (IsMultiAgentCall && multiAgentCall != null)
            {
                return multiAgentCall(MultiAgentCall!);
            }
            else if (IsMultiAgentCallOutput && multiAgentCallOutput != null)
            {
                return multiAgentCallOutput(MultiAgentCallOutput!);
            }
            else if (IsToolSearchCall && toolSearchCall != null)
            {
                return toolSearchCall(ToolSearchCall!);
            }
            else if (IsToolSearchOutput && toolSearchOutput != null)
            {
                return toolSearchOutput(ToolSearchOutput!);
            }
            else if (IsAdditionalTools && additionalTools != null)
            {
                return additionalTools(AdditionalTools!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }
            else if (IsImageGenerationCall && imageGenerationCall != null)
            {
                return imageGenerationCall(ImageGenerationCall!);
            }
            else if (IsCodeInterpreterCall && codeInterpreterCall != null)
            {
                return codeInterpreterCall(CodeInterpreterCall!);
            }
            else if (IsLocalShellCall && localShellCall != null)
            {
                return localShellCall(LocalShellCall!);
            }
            else if (IsLocalShellCallOutput && localShellCallOutput != null)
            {
                return localShellCallOutput(LocalShellCallOutput!);
            }
            else if (IsShellCall && shellCall != null)
            {
                return shellCall(ShellCall!);
            }
            else if (IsShellCallOutput && shellCallOutput != null)
            {
                return shellCallOutput(ShellCallOutput!);
            }
            else if (IsApplyPatchCall && applyPatchCall != null)
            {
                return applyPatchCall(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput && applyPatchCallOutput != null)
            {
                return applyPatchCallOutput(ApplyPatchCallOutput!);
            }
            else if (IsMcpListTools && mcpListTools != null)
            {
                return mcpListTools(McpListTools!);
            }
            else if (IsMcpApprovalRequest && mcpApprovalRequest != null)
            {
                return mcpApprovalRequest(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(McpApprovalResponse!);
            }
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
            }
            else if (IsCustomToolCallOutput && customToolCallOutput != null)
            {
                return customToolCallOutput(CustomToolCallOutput!);
            }
            else if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaInputMessage>? message1 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaOutputMessage>? message2 = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFileSearchToolCall>? fileSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCall>? computerCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerCallOutputItemParam>? computerCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchToolCall>? webSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCall>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaAgentMessageItemParam>? agentMessage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCallItemParam>? multiAgentCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam>? multiAgentCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchCallItemParam>? toolSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchOutputItemParam>? toolSearchOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaAdditionalToolsItemParam>? additionalTools = null,

            global::System.Action<global::tryAGI.OpenAI.BetaReasoningItem>? reasoning = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCompactionSummaryItemParam>? compaction = null,

            global::System.Action<global::tryAGI.OpenAI.BetaImageGenToolCall>? imageGenerationCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall>? codeInterpreterCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCall>? localShellCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput>? localShellCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallItemParam>? shellCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam>? shellCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam>? applyPatchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam>? applyPatchCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPListTools>? mcpListTools = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalRequest>? mcpApprovalRequest = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalResponse>? mcpApprovalResponse = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPToolCall>? mcpCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutput>? customToolCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCall>? customToolCall = null,
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
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
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
            else if (IsMultiAgentCall)
            {
                multiAgentCall?.Invoke(MultiAgentCall!);
            }
            else if (IsMultiAgentCallOutput)
            {
                multiAgentCallOutput?.Invoke(MultiAgentCallOutput!);
            }
            else if (IsToolSearchCall)
            {
                toolSearchCall?.Invoke(ToolSearchCall!);
            }
            else if (IsToolSearchOutput)
            {
                toolSearchOutput?.Invoke(ToolSearchOutput!);
            }
            else if (IsAdditionalTools)
            {
                additionalTools?.Invoke(AdditionalTools!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsCodeInterpreterCall)
            {
                codeInterpreterCall?.Invoke(CodeInterpreterCall!);
            }
            else if (IsLocalShellCall)
            {
                localShellCall?.Invoke(LocalShellCall!);
            }
            else if (IsLocalShellCallOutput)
            {
                localShellCallOutput?.Invoke(LocalShellCallOutput!);
            }
            else if (IsShellCall)
            {
                shellCall?.Invoke(ShellCall!);
            }
            else if (IsShellCallOutput)
            {
                shellCallOutput?.Invoke(ShellCallOutput!);
            }
            else if (IsApplyPatchCall)
            {
                applyPatchCall?.Invoke(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput)
            {
                applyPatchCallOutput?.Invoke(ApplyPatchCallOutput!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaInputMessage>? message1 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaOutputMessage>? message2 = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFileSearchToolCall>? fileSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCall>? computerCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerCallOutputItemParam>? computerCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchToolCall>? webSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCall>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaAgentMessageItemParam>? agentMessage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCallItemParam>? multiAgentCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam>? multiAgentCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchCallItemParam>? toolSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchOutputItemParam>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaAdditionalToolsItemParam>? additionalTools = null,
            global::System.Action<global::tryAGI.OpenAI.BetaReasoningItem>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCompactionSummaryItemParam>? compaction = null,
            global::System.Action<global::tryAGI.OpenAI.BetaImageGenToolCall>? imageGenerationCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall>? codeInterpreterCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCall>? localShellCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput>? localShellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallItemParam>? shellCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam>? applyPatchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPListTools>? mcpListTools = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalRequest>? mcpApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalResponse>? mcpApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPToolCall>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutput>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCall>? customToolCall = null,
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
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
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
            else if (IsMultiAgentCall)
            {
                multiAgentCall?.Invoke(MultiAgentCall!);
            }
            else if (IsMultiAgentCallOutput)
            {
                multiAgentCallOutput?.Invoke(MultiAgentCallOutput!);
            }
            else if (IsToolSearchCall)
            {
                toolSearchCall?.Invoke(ToolSearchCall!);
            }
            else if (IsToolSearchOutput)
            {
                toolSearchOutput?.Invoke(ToolSearchOutput!);
            }
            else if (IsAdditionalTools)
            {
                additionalTools?.Invoke(AdditionalTools!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsCodeInterpreterCall)
            {
                codeInterpreterCall?.Invoke(CodeInterpreterCall!);
            }
            else if (IsLocalShellCall)
            {
                localShellCall?.Invoke(LocalShellCall!);
            }
            else if (IsLocalShellCallOutput)
            {
                localShellCallOutput?.Invoke(LocalShellCallOutput!);
            }
            else if (IsShellCall)
            {
                shellCall?.Invoke(ShellCall!);
            }
            else if (IsShellCallOutput)
            {
                shellCallOutput?.Invoke(ShellCallOutput!);
            }
            else if (IsApplyPatchCall)
            {
                applyPatchCall?.Invoke(ApplyPatchCall!);
            }
            else if (IsApplyPatchCallOutput)
            {
                applyPatchCallOutput?.Invoke(ApplyPatchCallOutput!);
            }
            else if (IsMcpListTools)
            {
                mcpListTools?.Invoke(McpListTools!);
            }
            else if (IsMcpApprovalRequest)
            {
                mcpApprovalRequest?.Invoke(McpApprovalRequest!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
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
                typeof(global::tryAGI.OpenAI.BetaInputMessage),
                Message2,
                typeof(global::tryAGI.OpenAI.BetaOutputMessage),
                FileSearchCall,
                typeof(global::tryAGI.OpenAI.BetaFileSearchToolCall),
                ComputerCall,
                typeof(global::tryAGI.OpenAI.BetaComputerToolCall),
                ComputerCallOutput,
                typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParam),
                WebSearchCall,
                typeof(global::tryAGI.OpenAI.BetaWebSearchToolCall),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCall),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam),
                AgentMessage,
                typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParam),
                MultiAgentCall,
                typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParam),
                MultiAgentCallOutput,
                typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam),
                ToolSearchCall,
                typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParam),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParam),
                AdditionalTools,
                typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParam),
                Reasoning,
                typeof(global::tryAGI.OpenAI.BetaReasoningItem),
                Compaction,
                typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParam),
                ImageGenerationCall,
                typeof(global::tryAGI.OpenAI.BetaImageGenToolCall),
                CodeInterpreterCall,
                typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall),
                LocalShellCall,
                typeof(global::tryAGI.OpenAI.BetaLocalShellToolCall),
                LocalShellCallOutput,
                typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput),
                ShellCall,
                typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParam),
                ShellCallOutput,
                typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam),
                ApplyPatchCall,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam),
                ApplyPatchCallOutput,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam),
                McpListTools,
                typeof(global::tryAGI.OpenAI.BetaMCPListTools),
                McpApprovalRequest,
                typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequest),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponse),
                McpCall,
                typeof(global::tryAGI.OpenAI.BetaMCPToolCall),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutput),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCall),
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
        public bool Equals(BetaItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputMessage?>.Default.Equals(Message1, other.Message1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaOutputMessage?>.Default.Equals(Message2, other.Message2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerCallOutputItemParam?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaAgentMessageItemParam?>.Default.Equals(AgentMessage, other.AgentMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMultiAgentCallItemParam?>.Default.Equals(MultiAgentCall, other.MultiAgentCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam?>.Default.Equals(MultiAgentCallOutput, other.MultiAgentCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolSearchCallItemParam?>.Default.Equals(ToolSearchCall, other.ToolSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolSearchOutputItemParam?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaAdditionalToolsItemParam?>.Default.Equals(AdditionalTools, other.AdditionalTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCompactionSummaryItemParam?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput?>.Default.Equals(LocalShellCallOutput, other.LocalShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellCallItemParam?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPApprovalResponse?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaItem obj1, BetaItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaItem obj1, BetaItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaItem o && Equals(o);
        }
    }
}
