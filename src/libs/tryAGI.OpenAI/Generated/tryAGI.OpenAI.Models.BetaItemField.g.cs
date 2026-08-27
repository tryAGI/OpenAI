#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An item representing a message, tool call, tool output, reasoning, or other response element.
    /// </summary>
    public readonly partial struct BetaItemField : global::System.IEquatable<BetaItemField>
    {
        /// <summary>
        /// A message to or from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMessage? Message { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMessage? Message { get; }
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
            out global::tryAGI.OpenAI.BetaMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMessage PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaProgram? Program { get; init; }
#else
        public global::tryAGI.OpenAI.BetaProgram? Program { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Program))]
#endif
        public bool IsProgram => Program != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProgram(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaProgram? value)
        {
            value = Program;
            return IsProgram;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgram PickProgram() => IsProgram
            ? Program!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Program' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaProgramOutput? ProgramOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaProgramOutput? ProgramOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProgramOutput))]
#endif
        public bool IsProgramOutput => ProgramOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProgramOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaProgramOutput? value)
        {
            value = ProgramOutput;
            return IsProgramOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramOutput PickProgramOutput() => IsProgramOutput
            ? ProgramOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgramOutput' but the value was {ToString()}.");

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
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMultiAgentCall? MultiAgentCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMultiAgentCall? MultiAgentCall { get; }
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
            out global::tryAGI.OpenAI.BetaMultiAgentCall? value)
        {
            value = MultiAgentCall;
            return IsMultiAgentCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCall PickMultiAgentCall() => IsMultiAgentCall
            ? MultiAgentCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MultiAgentCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? MultiAgentCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput? MultiAgentCallOutput { get; }
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
            out global::tryAGI.OpenAI.BetaMultiAgentCallOutput? value)
        {
            value = MultiAgentCallOutput;
            return IsMultiAgentCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMultiAgentCallOutput PickMultiAgentCallOutput() => IsMultiAgentCallOutput
            ? MultiAgentCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MultiAgentCallOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolSearchCall? ToolSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolSearchCall? ToolSearchCall { get; }
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
            out global::tryAGI.OpenAI.BetaToolSearchCall? value)
        {
            value = ToolSearchCall;
            return IsToolSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchCall PickToolSearchCall() => IsToolSearchCall
            ? ToolSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolSearchOutput? ToolSearchOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolSearchOutput? ToolSearchOutput { get; }
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
            out global::tryAGI.OpenAI.BetaToolSearchOutput? value)
        {
            value = ToolSearchOutput;
            return IsToolSearchOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchOutput PickToolSearchOutput() => IsToolSearchOutput
            ? ToolSearchOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaAdditionalTools? AdditionalTools { get; init; }
#else
        public global::tryAGI.OpenAI.BetaAdditionalTools? AdditionalTools { get; }
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
            out global::tryAGI.OpenAI.BetaAdditionalTools? value)
        {
            value = AdditionalTools;
            return IsAdditionalTools;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAdditionalTools PickAdditionalTools() => IsAdditionalTools
            ? AdditionalTools!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdditionalTools' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaAgentMessage? AgentMessage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaAgentMessage? AgentMessage { get; }
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
            out global::tryAGI.OpenAI.BetaAgentMessage? value)
        {
            value = AgentMessage;
            return IsAgentMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessage PickAgentMessage() => IsAgentMessage
            ? AgentMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessage' but the value was {ToString()}.");

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionToolCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

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
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? ComputerToolCallOutputResource { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? ComputerToolCallOutputResource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutputResource))]
#endif
        public bool IsComputerToolCallOutputResource => ComputerToolCallOutputResource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerToolCallOutputResource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? value)
        {
            value = ComputerToolCallOutputResource;
            return IsComputerToolCallOutputResource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResource PickComputerToolCallOutputResource() => IsComputerToolCallOutputResource
            ? ComputerToolCallOutputResource!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerToolCallOutputResource' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.BetaCompactionBody? Compaction { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCompactionBody? Compaction { get; }
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
            out global::tryAGI.OpenAI.BetaCompactionBody? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCompactionBody PickCompaction() => IsCompaction
            ? Compaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

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
        /// A tool call that executes one or more shell commands in a managed environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellCall? ShellCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellCall? ShellCall { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionShellCall? value)
        {
            value = ShellCall;
            return IsShellCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCall PickShellCall() => IsShellCall
            ? ShellCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCall' but the value was {ToString()}.");

        /// <summary>
        /// The output of a shell tool call that was emitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? ShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput? ShellCallOutput { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionShellCallOutput? value)
        {
            value = ShellCallOutput;
            return IsShellCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutput PickShellCallOutput() => IsShellCallOutput
            ? ShellCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// A tool call that applies file diffs by creating, deleting, or updating files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? ApplyPatchCall { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall? ApplyPatchCall { get; }
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
            out global::tryAGI.OpenAI.BetaApplyPatchToolCall? value)
        {
            value = ApplyPatchCall;
            return IsApplyPatchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCall PickApplyPatchCall() => IsApplyPatchCall
            ? ApplyPatchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCall' but the value was {ToString()}.");

        /// <summary>
        /// The output emitted by an apply patch tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? ApplyPatchCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? ApplyPatchCallOutput { get; }
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
            out global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? value)
        {
            value = ApplyPatchCallOutput;
            return IsApplyPatchCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput PickApplyPatchCallOutput() => IsApplyPatchCallOutput
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
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? McpApprovalResponse { get; }
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
            out global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? value)
        {
            value = McpApprovalResponse;
            return IsMcpApprovalResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPApprovalResponseResource PickMcpApprovalResponse() => IsMcpApprovalResponse
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
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMessage value) => new BetaItemField((global::tryAGI.OpenAI.BetaMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMessage?(BetaItemField @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMessage? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMessage(global::tryAGI.OpenAI.BetaMessage? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaProgram value) => new BetaItemField((global::tryAGI.OpenAI.BetaProgram?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaProgram?(BetaItemField @this) => @this.Program;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaProgram? value)
        {
            Program = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromProgram(global::tryAGI.OpenAI.BetaProgram? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaProgramOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaProgramOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaProgramOutput?(BetaItemField @this) => @this.ProgramOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaProgramOutput? value)
        {
            ProgramOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromProgramOutput(global::tryAGI.OpenAI.BetaProgramOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaFunctionToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaFunctionToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCall?(BetaItemField @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaFunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromFunctionCall(global::tryAGI.OpenAI.BetaFunctionToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMultiAgentCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaMultiAgentCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMultiAgentCall?(BetaItemField @this) => @this.MultiAgentCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMultiAgentCall? value)
        {
            MultiAgentCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMultiAgentCall(global::tryAGI.OpenAI.BetaMultiAgentCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMultiAgentCallOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaMultiAgentCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMultiAgentCallOutput?(BetaItemField @this) => @this.MultiAgentCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMultiAgentCallOutput? value)
        {
            MultiAgentCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMultiAgentCallOutput(global::tryAGI.OpenAI.BetaMultiAgentCallOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaToolSearchCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaToolSearchCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolSearchCall?(BetaItemField @this) => @this.ToolSearchCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaToolSearchCall? value)
        {
            ToolSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromToolSearchCall(global::tryAGI.OpenAI.BetaToolSearchCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaToolSearchOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaToolSearchOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolSearchOutput?(BetaItemField @this) => @this.ToolSearchOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaToolSearchOutput? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromToolSearchOutput(global::tryAGI.OpenAI.BetaToolSearchOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaAdditionalTools value) => new BetaItemField((global::tryAGI.OpenAI.BetaAdditionalTools?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaAdditionalTools?(BetaItemField @this) => @this.AdditionalTools;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaAdditionalTools? value)
        {
            AdditionalTools = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromAdditionalTools(global::tryAGI.OpenAI.BetaAdditionalTools? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaAgentMessage value) => new BetaItemField((global::tryAGI.OpenAI.BetaAgentMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaAgentMessage?(BetaItemField @this) => @this.AgentMessage;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaAgentMessage? value)
        {
            AgentMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromAgentMessage(global::tryAGI.OpenAI.BetaAgentMessage? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaFunctionToolCallOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaFunctionToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCallOutput?(BetaItemField @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaFunctionToolCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromFunctionCallOutput(global::tryAGI.OpenAI.BetaFunctionToolCallOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaFileSearchToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaFileSearchToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFileSearchToolCall?(BetaItemField @this) => @this.FileSearchCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaFileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromFileSearchCall(global::tryAGI.OpenAI.BetaFileSearchToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaWebSearchToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaWebSearchToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchToolCall?(BetaItemField @this) => @this.WebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaWebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromWebSearchCall(global::tryAGI.OpenAI.BetaWebSearchToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaImageGenToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaImageGenToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaImageGenToolCall?(BetaItemField @this) => @this.ImageGenerationCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromImageGenerationCall(global::tryAGI.OpenAI.BetaImageGenToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaComputerToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaComputerToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerToolCall?(BetaItemField @this) => @this.ComputerCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromComputerCall(global::tryAGI.OpenAI.BetaComputerToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource value) => new BetaItemField((global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?(BetaItemField @this) => @this.ComputerToolCallOutputResource;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? value)
        {
            ComputerToolCallOutputResource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromComputerToolCallOutputResource(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaReasoningItem value) => new BetaItemField((global::tryAGI.OpenAI.BetaReasoningItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaReasoningItem?(BetaItemField @this) => @this.Reasoning;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromReasoning(global::tryAGI.OpenAI.BetaReasoningItem? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaCompactionBody value) => new BetaItemField((global::tryAGI.OpenAI.BetaCompactionBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCompactionBody?(BetaItemField @this) => @this.Compaction;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaCompactionBody? value)
        {
            Compaction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromCompaction(global::tryAGI.OpenAI.BetaCompactionBody? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaCodeInterpreterToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCodeInterpreterToolCall?(BetaItemField @this) => @this.CodeInterpreterCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromCodeInterpreterCall(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaLocalShellToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaLocalShellToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalShellToolCall?(BetaItemField @this) => @this.LocalShellCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaLocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromLocalShellCall(global::tryAGI.OpenAI.BetaLocalShellToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaLocalShellToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalShellToolCallOutput?(BetaItemField @this) => @this.LocalShellCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? value)
        {
            LocalShellCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromLocalShellCallOutput(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaFunctionShellCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaFunctionShellCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellCall?(BetaItemField @this) => @this.ShellCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaFunctionShellCall? value)
        {
            ShellCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromShellCall(global::tryAGI.OpenAI.BetaFunctionShellCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaFunctionShellCallOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaFunctionShellCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellCallOutput?(BetaItemField @this) => @this.ShellCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaFunctionShellCallOutput? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromShellCallOutput(global::tryAGI.OpenAI.BetaFunctionShellCallOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaApplyPatchToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaApplyPatchToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchToolCall?(BetaItemField @this) => @this.ApplyPatchCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaApplyPatchToolCall? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromApplyPatchCall(global::tryAGI.OpenAI.BetaApplyPatchToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput?(BetaItemField @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromApplyPatchCallOutput(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMCPListTools value) => new BetaItemField((global::tryAGI.OpenAI.BetaMCPListTools?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPListTools?(BetaItemField @this) => @this.McpListTools;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMcpListTools(global::tryAGI.OpenAI.BetaMCPListTools? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMCPApprovalRequest value) => new BetaItemField((global::tryAGI.OpenAI.BetaMCPApprovalRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPApprovalRequest?(BetaItemField @this) => @this.McpApprovalRequest;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMcpApprovalRequest(global::tryAGI.OpenAI.BetaMCPApprovalRequest? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMCPApprovalResponseResource value) => new BetaItemField((global::tryAGI.OpenAI.BetaMCPApprovalResponseResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPApprovalResponseResource?(BetaItemField @this) => @this.McpApprovalResponse;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMcpApprovalResponse(global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaMCPToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaMCPToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPToolCall?(BetaItemField @this) => @this.McpCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaMCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromMcpCall(global::tryAGI.OpenAI.BetaMCPToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaCustomToolCall value) => new BetaItemField((global::tryAGI.OpenAI.BetaCustomToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCall?(BetaItemField @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaCustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromCustomToolCall(global::tryAGI.OpenAI.BetaCustomToolCall? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaItemField(global::tryAGI.OpenAI.BetaCustomToolCallOutput value) => new BetaItemField((global::tryAGI.OpenAI.BetaCustomToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCallOutput?(BetaItemField @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(global::tryAGI.OpenAI.BetaCustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaItemField FromCustomToolCallOutput(global::tryAGI.OpenAI.BetaCustomToolCallOutput? value) => new BetaItemField(value);

        /// <summary>
        ///
        /// </summary>
        public BetaItemField(
            global::tryAGI.OpenAI.BetaMessage? message,
            global::tryAGI.OpenAI.BetaProgram? program,
            global::tryAGI.OpenAI.BetaProgramOutput? programOutput,
            global::tryAGI.OpenAI.BetaFunctionToolCall? functionCall,
            global::tryAGI.OpenAI.BetaMultiAgentCall? multiAgentCall,
            global::tryAGI.OpenAI.BetaMultiAgentCallOutput? multiAgentCallOutput,
            global::tryAGI.OpenAI.BetaToolSearchCall? toolSearchCall,
            global::tryAGI.OpenAI.BetaToolSearchOutput? toolSearchOutput,
            global::tryAGI.OpenAI.BetaAdditionalTools? additionalTools,
            global::tryAGI.OpenAI.BetaAgentMessage? agentMessage,
            global::tryAGI.OpenAI.BetaFunctionToolCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.BetaFileSearchToolCall? fileSearchCall,
            global::tryAGI.OpenAI.BetaWebSearchToolCall? webSearchCall,
            global::tryAGI.OpenAI.BetaImageGenToolCall? imageGenerationCall,
            global::tryAGI.OpenAI.BetaComputerToolCall? computerCall,
            global::tryAGI.OpenAI.BetaComputerToolCallOutputResource? computerToolCallOutputResource,
            global::tryAGI.OpenAI.BetaReasoningItem? reasoning,
            global::tryAGI.OpenAI.BetaCompactionBody? compaction,
            global::tryAGI.OpenAI.BetaCodeInterpreterToolCall? codeInterpreterCall,
            global::tryAGI.OpenAI.BetaLocalShellToolCall? localShellCall,
            global::tryAGI.OpenAI.BetaLocalShellToolCallOutput? localShellCallOutput,
            global::tryAGI.OpenAI.BetaFunctionShellCall? shellCall,
            global::tryAGI.OpenAI.BetaFunctionShellCallOutput? shellCallOutput,
            global::tryAGI.OpenAI.BetaApplyPatchToolCall? applyPatchCall,
            global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput? applyPatchCallOutput,
            global::tryAGI.OpenAI.BetaMCPListTools? mcpListTools,
            global::tryAGI.OpenAI.BetaMCPApprovalRequest? mcpApprovalRequest,
            global::tryAGI.OpenAI.BetaMCPApprovalResponseResource? mcpApprovalResponse,
            global::tryAGI.OpenAI.BetaMCPToolCall? mcpCall,
            global::tryAGI.OpenAI.BetaCustomToolCall? customToolCall,
            global::tryAGI.OpenAI.BetaCustomToolCallOutput? customToolCallOutput
            )
        {
            Message = message;
            Program = program;
            ProgramOutput = programOutput;
            FunctionCall = functionCall;
            MultiAgentCall = multiAgentCall;
            MultiAgentCallOutput = multiAgentCallOutput;
            ToolSearchCall = toolSearchCall;
            ToolSearchOutput = toolSearchOutput;
            AdditionalTools = additionalTools;
            AgentMessage = agentMessage;
            FunctionCallOutput = functionCallOutput;
            FileSearchCall = fileSearchCall;
            WebSearchCall = webSearchCall;
            ImageGenerationCall = imageGenerationCall;
            ComputerCall = computerCall;
            ComputerToolCallOutputResource = computerToolCallOutputResource;
            Reasoning = reasoning;
            Compaction = compaction;
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
            CustomToolCall = customToolCall;
            CustomToolCallOutput = customToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolCallOutput as object ??
            CustomToolCall as object ??
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
            Compaction as object ??
            Reasoning as object ??
            ComputerToolCallOutputResource as object ??
            ComputerCall as object ??
            ImageGenerationCall as object ??
            WebSearchCall as object ??
            FileSearchCall as object ??
            FunctionCallOutput as object ??
            AgentMessage as object ??
            AdditionalTools as object ??
            ToolSearchOutput as object ??
            ToolSearchCall as object ??
            MultiAgentCallOutput as object ??
            MultiAgentCall as object ??
            FunctionCall as object ??
            ProgramOutput as object ??
            Program as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Program?.ToString() ??
            ProgramOutput?.ToString() ??
            FunctionCall?.ToString() ??
            MultiAgentCall?.ToString() ??
            MultiAgentCallOutput?.ToString() ??
            ToolSearchCall?.ToString() ??
            ToolSearchOutput?.ToString() ??
            AdditionalTools?.ToString() ??
            AgentMessage?.ToString() ??
            FunctionCallOutput?.ToString() ??
            FileSearchCall?.ToString() ??
            WebSearchCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerToolCallOutputResource?.ToString() ??
            Reasoning?.ToString() ??
            Compaction?.ToString() ??
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
            CustomToolCall?.ToString() ??
            CustomToolCallOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsProgram && !IsProgramOutput && !IsFunctionCall && !IsMultiAgentCall && !IsMultiAgentCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsAdditionalTools && !IsAgentMessage && !IsFunctionCallOutput && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsReasoning && !IsCompaction && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaMessage, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.BetaProgram, TResult>? program = null,
            global::System.Func<global::tryAGI.OpenAI.BetaProgramOutput, TResult>? programOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCall, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMultiAgentCall, TResult>? multiAgentCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMultiAgentCallOutput, TResult>? multiAgentCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolSearchCall, TResult>? toolSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolSearchOutput, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaAdditionalTools, TResult>? additionalTools = null,
            global::System.Func<global::tryAGI.OpenAI.BetaAgentMessage, TResult>? agentMessage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFileSearchToolCall, TResult>? fileSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchToolCall, TResult>? webSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaImageGenToolCall, TResult>? imageGenerationCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerToolCall, TResult>? computerCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?, TResult>? computerToolCallOutputResource = null,
            global::System.Func<global::tryAGI.OpenAI.BetaReasoningItem, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCompactionBody, TResult>? compaction = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall, TResult>? codeInterpreterCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaLocalShellToolCall, TResult>? localShellCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput, TResult>? localShellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellCall, TResult>? shellCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellCallOutput, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchToolCall, TResult>? applyPatchCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPListTools, TResult>? mcpListTools = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPApprovalRequest, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPApprovalResponseResource, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPToolCall, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCall, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCallOutput, TResult>? customToolCallOutput = null,
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
            else if (IsProgram && program != null)
            {
                return program(Program!);
            }
            else if (IsProgramOutput && programOutput != null)
            {
                return programOutput(ProgramOutput!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
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
            else if (IsAgentMessage && agentMessage != null)
            {
                return agentMessage(AgentMessage!);
            }
            else if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsImageGenerationCall && imageGenerationCall != null)
            {
                return imageGenerationCall(ImageGenerationCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerToolCallOutputResource && computerToolCallOutputResource != null)
            {
                return computerToolCallOutputResource(ComputerToolCallOutputResource!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
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
            else if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsCustomToolCallOutput && customToolCallOutput != null)
            {
                return customToolCallOutput(CustomToolCallOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaMessage>? message = null,

            global::System.Action<global::tryAGI.OpenAI.BetaProgram>? program = null,

            global::System.Action<global::tryAGI.OpenAI.BetaProgramOutput>? programOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCall>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCall>? multiAgentCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCallOutput>? multiAgentCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchCall>? toolSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchOutput>? toolSearchOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaAdditionalTools>? additionalTools = null,

            global::System.Action<global::tryAGI.OpenAI.BetaAgentMessage>? agentMessage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallOutput>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFileSearchToolCall>? fileSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchToolCall>? webSearchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaImageGenToolCall>? imageGenerationCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCall>? computerCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?>? computerToolCallOutputResource = null,

            global::System.Action<global::tryAGI.OpenAI.BetaReasoningItem>? reasoning = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCompactionBody>? compaction = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall>? codeInterpreterCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCall>? localShellCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput>? localShellCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCall>? shellCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutput>? shellCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCall>? applyPatchCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput>? applyPatchCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPListTools>? mcpListTools = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalRequest>? mcpApprovalRequest = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalResponseResource>? mcpApprovalResponse = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPToolCall>? mcpCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCall>? customToolCall = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutput>? customToolCallOutput = null,
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
            else if (IsProgram)
            {
                program?.Invoke(Program!);
            }
            else if (IsProgramOutput)
            {
                programOutput?.Invoke(ProgramOutput!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
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
            else if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerToolCallOutputResource)
            {
                computerToolCallOutputResource?.Invoke(ComputerToolCallOutputResource!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaMessage>? message = null,
            global::System.Action<global::tryAGI.OpenAI.BetaProgram>? program = null,
            global::System.Action<global::tryAGI.OpenAI.BetaProgramOutput>? programOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCall>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCall>? multiAgentCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMultiAgentCallOutput>? multiAgentCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchCall>? toolSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchOutput>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaAdditionalTools>? additionalTools = null,
            global::System.Action<global::tryAGI.OpenAI.BetaAgentMessage>? agentMessage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallOutput>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFileSearchToolCall>? fileSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchToolCall>? webSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaImageGenToolCall>? imageGenerationCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCall>? computerCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?>? computerToolCallOutputResource = null,
            global::System.Action<global::tryAGI.OpenAI.BetaReasoningItem>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCompactionBody>? compaction = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall>? codeInterpreterCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCall>? localShellCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput>? localShellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCall>? shellCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutput>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCall>? applyPatchCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPListTools>? mcpListTools = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalRequest>? mcpApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPApprovalResponseResource>? mcpApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPToolCall>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCall>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutput>? customToolCallOutput = null,
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
            else if (IsProgram)
            {
                program?.Invoke(Program!);
            }
            else if (IsProgramOutput)
            {
                programOutput?.Invoke(ProgramOutput!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
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
            else if (IsAgentMessage)
            {
                agentMessage?.Invoke(AgentMessage!);
            }
            else if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerToolCallOutputResource)
            {
                computerToolCallOutputResource?.Invoke(ComputerToolCallOutputResource!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
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
                typeof(global::tryAGI.OpenAI.BetaMessage),
                Program,
                typeof(global::tryAGI.OpenAI.BetaProgram),
                ProgramOutput,
                typeof(global::tryAGI.OpenAI.BetaProgramOutput),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCall),
                MultiAgentCall,
                typeof(global::tryAGI.OpenAI.BetaMultiAgentCall),
                MultiAgentCallOutput,
                typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutput),
                ToolSearchCall,
                typeof(global::tryAGI.OpenAI.BetaToolSearchCall),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.BetaToolSearchOutput),
                AdditionalTools,
                typeof(global::tryAGI.OpenAI.BetaAdditionalTools),
                AgentMessage,
                typeof(global::tryAGI.OpenAI.BetaAgentMessage),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutput),
                FileSearchCall,
                typeof(global::tryAGI.OpenAI.BetaFileSearchToolCall),
                WebSearchCall,
                typeof(global::tryAGI.OpenAI.BetaWebSearchToolCall),
                ImageGenerationCall,
                typeof(global::tryAGI.OpenAI.BetaImageGenToolCall),
                ComputerCall,
                typeof(global::tryAGI.OpenAI.BetaComputerToolCall),
                ComputerToolCallOutputResource,
                typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource),
                Reasoning,
                typeof(global::tryAGI.OpenAI.BetaReasoningItem),
                Compaction,
                typeof(global::tryAGI.OpenAI.BetaCompactionBody),
                CodeInterpreterCall,
                typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall),
                LocalShellCall,
                typeof(global::tryAGI.OpenAI.BetaLocalShellToolCall),
                LocalShellCallOutput,
                typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput),
                ShellCall,
                typeof(global::tryAGI.OpenAI.BetaFunctionShellCall),
                ShellCallOutput,
                typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutput),
                ApplyPatchCall,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCall),
                ApplyPatchCallOutput,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput),
                McpListTools,
                typeof(global::tryAGI.OpenAI.BetaMCPListTools),
                McpApprovalRequest,
                typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequest),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResource),
                McpCall,
                typeof(global::tryAGI.OpenAI.BetaMCPToolCall),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCall),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutput),
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
        public bool Equals(BetaItemField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaProgram?>.Default.Equals(Program, other.Program) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaProgramOutput?>.Default.Equals(ProgramOutput, other.ProgramOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMultiAgentCall?>.Default.Equals(MultiAgentCall, other.MultiAgentCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMultiAgentCallOutput?>.Default.Equals(MultiAgentCallOutput, other.MultiAgentCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolSearchCall?>.Default.Equals(ToolSearchCall, other.ToolSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolSearchOutput?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaAdditionalTools?>.Default.Equals(AdditionalTools, other.AdditionalTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaAgentMessage?>.Default.Equals(AgentMessage, other.AgentMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutputResource, other.ComputerToolCallOutputResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCompactionBody?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalShellToolCallOutput?>.Default.Equals(LocalShellCallOutput, other.LocalShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellCall?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellCallOutput?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchToolCall?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPApprovalResponseResource?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaItemField obj1, BetaItemField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaItemField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaItemField obj1, BetaItemField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaItemField o && Equals(o);
        }
    }
}
