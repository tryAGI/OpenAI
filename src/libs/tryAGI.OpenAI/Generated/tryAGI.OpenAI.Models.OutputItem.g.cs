#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputItem : global::System.IEquatable<OutputItem>
    {
        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputMessage? Message { get; init; }
#else
        public global::tryAGI.OpenAI.OutputMessage? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// The results of a file search tool call. See the<br/>
        /// [file search guide](/docs/guides/tools-file-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FileSearchToolCall? FileSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.FileSearchToolCall? FileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCall? FunctionCall { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? FunctionToolCallResource { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? FunctionToolCallResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallResource))]
#endif
        public bool IsFunctionToolCallResource => FunctionToolCallResource != null;

        /// <summary>
        /// The results of a web search tool call. See the<br/>
        /// [web search guide](/docs/guides/tools-web-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchToolCall? WebSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchToolCall? WebSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        /// A tool call to a computer use tool. See the<br/>
        /// [computer use guide](/docs/guides/tools-computer-use) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerToolCall? ComputerCall { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCall? ComputerCall { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? ComputerToolCallResource { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? ComputerToolCallResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallResource))]
#endif
        public bool IsComputerToolCallResource => ComputerToolCallResource != null;

        /// <summary>
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response. Be sure to include these items in your `input` to the Responses API<br/>
        /// for subsequent turns of a conversation if you are manually<br/>
        /// [managing context](/docs/guides/conversation-state).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ReasoningItem? Reasoning { get; init; }
#else
        public global::tryAGI.OpenAI.ReasoningItem? Reasoning { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolSearchCall? ToolSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.ToolSearchCall? ToolSearchCall { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolSearchOutput? ToolSearchOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ToolSearchOutput? ToolSearchOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchOutput))]
#endif
        public bool IsToolSearchOutput => ToolSearchOutput != null;

        /// <summary>
        /// A compaction item generated by the [`v1/responses/compact` API](/docs/api-reference/responses/compact).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CompactionBody? Compaction { get; init; }
#else
        public global::tryAGI.OpenAI.CompactionBody? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;

        /// <summary>
        /// An image generation request made by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageGenToolCall? ImageGenerationCall { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenToolCall? ImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        /// A tool call to run code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? CodeInterpreterCall { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? CodeInterpreterCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCall))]
#endif
        public bool IsCodeInterpreterCall => CodeInterpreterCall != null;

        /// <summary>
        /// A tool call to run a command on the local shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalShellToolCall? LocalShellCall { get; init; }
#else
        public global::tryAGI.OpenAI.LocalShellToolCall? LocalShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCall))]
#endif
        public bool IsLocalShellCall => LocalShellCall != null;

        /// <summary>
        /// The output of a local shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? LocalShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? LocalShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCallOutput))]
#endif
        public bool IsLocalShellCallOutput => LocalShellCallOutput != null;

        /// <summary>
        /// A tool call that executes one or more shell commands in a managed environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCall? ShellCall { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCall? ShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCall))]
#endif
        public bool IsShellCall => ShellCall != null;

        /// <summary>
        /// The output of a shell tool call that was emitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCallOutput? ShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallOutput? ShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        /// A tool call that applies file diffs by creating, deleting, or updating files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchToolCall? ApplyPatchCall { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchToolCall? ApplyPatchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        /// The output emitted by an apply patch tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutput? ApplyPatchCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutput? ApplyPatchCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutput))]
#endif
        public bool IsApplyPatchCallOutput => ApplyPatchCallOutput != null;

        /// <summary>
        /// An invocation of a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPToolCall? McpCall { get; init; }
#else
        public global::tryAGI.OpenAI.MCPToolCall? McpCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCall))]
#endif
        public bool IsMcpCall => McpCall != null;

        /// <summary>
        /// A list of tools available on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPListTools? McpListTools { get; init; }
#else
        public global::tryAGI.OpenAI.MCPListTools? McpListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListTools))]
#endif
        public bool IsMcpListTools => McpListTools != null;

        /// <summary>
        /// A request for human approval of a tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPApprovalRequest? McpApprovalRequest { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalRequest? McpApprovalRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalRequest))]
#endif
        public bool IsMcpApprovalRequest => McpApprovalRequest != null;

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? McpApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCall? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCall? CustomToolCall { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCallOutputResource? ResponseCustomToolCallOutputItem { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCallOutputResource? ResponseCustomToolCallOutputItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallOutputItem))]
#endif
        public bool IsResponseCustomToolCallOutputItem => ResponseCustomToolCallOutputItem != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.OutputMessage value) => new OutputItem((global::tryAGI.OpenAI.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputMessage?(OutputItem @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.OutputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FileSearchToolCall value) => new OutputItem((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(OutputItem @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FunctionToolCall value) => new OutputItem((global::tryAGI.OpenAI.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCall?(OutputItem @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FunctionToolCallOutputResource value) => new OutputItem((global::tryAGI.OpenAI.FunctionToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallOutputResource?(OutputItem @this) => @this.FunctionToolCallResource;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FunctionToolCallOutputResource? value)
        {
            FunctionToolCallResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.WebSearchToolCall value) => new OutputItem((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(OutputItem @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ComputerToolCall value) => new OutputItem((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(OutputItem @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ComputerToolCallOutputResource value) => new OutputItem((global::tryAGI.OpenAI.ComputerToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCallOutputResource?(OutputItem @this) => @this.ComputerToolCallResource;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ComputerToolCallOutputResource? value)
        {
            ComputerToolCallResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ReasoningItem value) => new OutputItem((global::tryAGI.OpenAI.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningItem?(OutputItem @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ToolSearchCall value) => new OutputItem((global::tryAGI.OpenAI.ToolSearchCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchCall?(OutputItem @this) => @this.ToolSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ToolSearchCall? value)
        {
            ToolSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ToolSearchOutput value) => new OutputItem((global::tryAGI.OpenAI.ToolSearchOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchOutput?(OutputItem @this) => @this.ToolSearchOutput;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ToolSearchOutput? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.CompactionBody value) => new OutputItem((global::tryAGI.OpenAI.CompactionBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CompactionBody?(OutputItem @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.CompactionBody? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ImageGenToolCall value) => new OutputItem((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(OutputItem @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new OutputItem((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(OutputItem @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.LocalShellToolCall value) => new OutputItem((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(OutputItem @this) => @this.LocalShellCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.LocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.LocalShellToolCallOutput value) => new OutputItem((global::tryAGI.OpenAI.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCallOutput?(OutputItem @this) => @this.LocalShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.LocalShellToolCallOutput? value)
        {
            LocalShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FunctionShellCall value) => new OutputItem((global::tryAGI.OpenAI.FunctionShellCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCall?(OutputItem @this) => @this.ShellCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FunctionShellCall? value)
        {
            ShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FunctionShellCallOutput value) => new OutputItem((global::tryAGI.OpenAI.FunctionShellCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutput?(OutputItem @this) => @this.ShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FunctionShellCallOutput? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ApplyPatchToolCall value) => new OutputItem((global::tryAGI.OpenAI.ApplyPatchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolCall?(OutputItem @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ApplyPatchToolCall? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ApplyPatchToolCallOutput value) => new OutputItem((global::tryAGI.OpenAI.ApplyPatchToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolCallOutput?(OutputItem @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ApplyPatchToolCallOutput? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPToolCall value) => new OutputItem((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(OutputItem @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPListTools value) => new OutputItem((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(OutputItem @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPApprovalRequest value) => new OutputItem((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(OutputItem @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPApprovalResponseResource value) => new OutputItem((global::tryAGI.OpenAI.MCPApprovalResponseResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalResponseResource?(OutputItem @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPApprovalResponseResource? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.CustomToolCall value) => new OutputItem((global::tryAGI.OpenAI.CustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCall?(OutputItem @this) => @this.CustomToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.CustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItem(global::tryAGI.OpenAI.CustomToolCallOutputResource value) => new OutputItem((global::tryAGI.OpenAI.CustomToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallOutputResource?(OutputItem @this) => @this.ResponseCustomToolCallOutputItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.CustomToolCallOutputResource? value)
        {
            ResponseCustomToolCallOutputItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(
            global::tryAGI.OpenAI.OutputMessage? message,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchCall,
            global::tryAGI.OpenAI.FunctionToolCall? functionCall,
            global::tryAGI.OpenAI.FunctionToolCallOutputResource? functionToolCallResource,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerCall,
            global::tryAGI.OpenAI.ComputerToolCallOutputResource? computerToolCallResource,
            global::tryAGI.OpenAI.ReasoningItem? reasoning,
            global::tryAGI.OpenAI.ToolSearchCall? toolSearchCall,
            global::tryAGI.OpenAI.ToolSearchOutput? toolSearchOutput,
            global::tryAGI.OpenAI.CompactionBody? compaction,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenerationCall,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellCall,
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellCallOutput,
            global::tryAGI.OpenAI.FunctionShellCall? shellCall,
            global::tryAGI.OpenAI.FunctionShellCallOutput? shellCallOutput,
            global::tryAGI.OpenAI.ApplyPatchToolCall? applyPatchCall,
            global::tryAGI.OpenAI.ApplyPatchToolCallOutput? applyPatchCallOutput,
            global::tryAGI.OpenAI.MCPToolCall? mcpCall,
            global::tryAGI.OpenAI.MCPListTools? mcpListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mcpApprovalRequest,
            global::tryAGI.OpenAI.MCPApprovalResponseResource? mcpApprovalResponse,
            global::tryAGI.OpenAI.CustomToolCall? customToolCall,
            global::tryAGI.OpenAI.CustomToolCallOutputResource? responseCustomToolCallOutputItem
            )
        {
            Message = message;
            FileSearchCall = fileSearchCall;
            FunctionCall = functionCall;
            FunctionToolCallResource = functionToolCallResource;
            WebSearchCall = webSearchCall;
            ComputerCall = computerCall;
            ComputerToolCallResource = computerToolCallResource;
            Reasoning = reasoning;
            ToolSearchCall = toolSearchCall;
            ToolSearchOutput = toolSearchOutput;
            Compaction = compaction;
            ImageGenerationCall = imageGenerationCall;
            CodeInterpreterCall = codeInterpreterCall;
            LocalShellCall = localShellCall;
            LocalShellCallOutput = localShellCallOutput;
            ShellCall = shellCall;
            ShellCallOutput = shellCallOutput;
            ApplyPatchCall = applyPatchCall;
            ApplyPatchCallOutput = applyPatchCallOutput;
            McpCall = mcpCall;
            McpListTools = mcpListTools;
            McpApprovalRequest = mcpApprovalRequest;
            McpApprovalResponse = mcpApprovalResponse;
            CustomToolCall = customToolCall;
            ResponseCustomToolCallOutputItem = responseCustomToolCallOutputItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseCustomToolCallOutputItem as object ??
            CustomToolCall as object ??
            McpApprovalResponse as object ??
            McpApprovalRequest as object ??
            McpListTools as object ??
            McpCall as object ??
            ApplyPatchCallOutput as object ??
            ApplyPatchCall as object ??
            ShellCallOutput as object ??
            ShellCall as object ??
            LocalShellCallOutput as object ??
            LocalShellCall as object ??
            CodeInterpreterCall as object ??
            ImageGenerationCall as object ??
            Compaction as object ??
            ToolSearchOutput as object ??
            ToolSearchCall as object ??
            Reasoning as object ??
            ComputerToolCallResource as object ??
            ComputerCall as object ??
            WebSearchCall as object ??
            FunctionToolCallResource as object ??
            FunctionCall as object ??
            FileSearchCall as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FileSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionToolCallResource?.ToString() ??
            WebSearchCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerToolCallResource?.ToString() ??
            Reasoning?.ToString() ??
            ToolSearchCall?.ToString() ??
            ToolSearchOutput?.ToString() ??
            Compaction?.ToString() ??
            ImageGenerationCall?.ToString() ??
            CodeInterpreterCall?.ToString() ??
            LocalShellCall?.ToString() ??
            LocalShellCallOutput?.ToString() ??
            ShellCall?.ToString() ??
            ShellCallOutput?.ToString() ??
            ApplyPatchCall?.ToString() ??
            ApplyPatchCallOutput?.ToString() ??
            McpCall?.ToString() ??
            McpListTools?.ToString() ??
            McpApprovalRequest?.ToString() ??
            McpApprovalResponse?.ToString() ??
            CustomToolCall?.ToString() ??
            ResponseCustomToolCallOutputItem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsCustomToolCall && !IsResponseCustomToolCallOutputItem || !IsMessage && !IsFileSearchCall && !IsFunctionCall && !IsFunctionToolCallResource && !IsWebSearchCall && !IsComputerCall && !IsComputerToolCallResource && !IsReasoning && !IsToolSearchCall && !IsToolSearchOutput && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpCall && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsCustomToolCall && IsResponseCustomToolCallOutputItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.OutputMessage?, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCall?, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutputResource?, TResult>? functionToolCallResource = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutputResource?, TResult>? computerToolCallResource = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchCall?, TResult>? toolSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchOutput?, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.CompactionBody?, TResult>? compaction = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenerationCall = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCallOutput?, TResult>? localShellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCall?, TResult>? shellCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutput?, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolCall?, TResult>? applyPatchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolCallOutput?, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mcpListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalResponseResource?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCall?, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutputResource?, TResult>? responseCustomToolCallOutputItem = null,
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
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsFunctionToolCallResource && functionToolCallResource != null)
            {
                return functionToolCallResource(FunctionToolCallResource!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }
            else if (IsComputerCall && computerCall != null)
            {
                return computerCall(ComputerCall!);
            }
            else if (IsComputerToolCallResource && computerToolCallResource != null)
            {
                return computerToolCallResource(ComputerToolCallResource!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsToolSearchCall && toolSearchCall != null)
            {
                return toolSearchCall(ToolSearchCall!);
            }
            else if (IsToolSearchOutput && toolSearchOutput != null)
            {
                return toolSearchOutput(ToolSearchOutput!);
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
            else if (IsMcpCall && mcpCall != null)
            {
                return mcpCall(McpCall!);
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
            else if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsResponseCustomToolCallOutputItem && responseCustomToolCallOutputItem != null)
            {
                return responseCustomToolCallOutputItem(ResponseCustomToolCallOutputItem!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.OutputMessage?>? message = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCall?>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallOutputResource?>? functionToolCallResource = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>? computerToolCallResource = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchCall?>? toolSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchOutput?>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.CompactionBody?>? compaction = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenerationCall = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCallOutput?>? localShellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCall?>? shellCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutput?>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolCall?>? applyPatchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolCallOutput?>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mcpListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mcpApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalResponseResource?>? mcpApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCall?>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutputResource?>? responseCustomToolCallOutputItem = null,
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
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsFunctionToolCallResource)
            {
                functionToolCallResource?.Invoke(FunctionToolCallResource!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
            else if (IsComputerCall)
            {
                computerCall?.Invoke(ComputerCall!);
            }
            else if (IsComputerToolCallResource)
            {
                computerToolCallResource?.Invoke(ComputerToolCallResource!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsToolSearchCall)
            {
                toolSearchCall?.Invoke(ToolSearchCall!);
            }
            else if (IsToolSearchOutput)
            {
                toolSearchOutput?.Invoke(ToolSearchOutput!);
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
            else if (IsMcpCall)
            {
                mcpCall?.Invoke(McpCall!);
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
            else if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsResponseCustomToolCallOutputItem)
            {
                responseCustomToolCallOutputItem?.Invoke(ResponseCustomToolCallOutputItem!);
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
                typeof(global::tryAGI.OpenAI.OutputMessage),
                FileSearchCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.FunctionToolCall),
                FunctionToolCallResource,
                typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource),
                WebSearchCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                ComputerCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerToolCallResource,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItem),
                ToolSearchCall,
                typeof(global::tryAGI.OpenAI.ToolSearchCall),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.ToolSearchOutput),
                Compaction,
                typeof(global::tryAGI.OpenAI.CompactionBody),
                ImageGenerationCall,
                typeof(global::tryAGI.OpenAI.ImageGenToolCall),
                CodeInterpreterCall,
                typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall),
                LocalShellCall,
                typeof(global::tryAGI.OpenAI.LocalShellToolCall),
                LocalShellCallOutput,
                typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput),
                ShellCall,
                typeof(global::tryAGI.OpenAI.FunctionShellCall),
                ShellCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionShellCallOutput),
                ApplyPatchCall,
                typeof(global::tryAGI.OpenAI.ApplyPatchToolCall),
                ApplyPatchCallOutput,
                typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutput),
                McpCall,
                typeof(global::tryAGI.OpenAI.MCPToolCall),
                McpListTools,
                typeof(global::tryAGI.OpenAI.MCPListTools),
                McpApprovalRequest,
                typeof(global::tryAGI.OpenAI.MCPApprovalRequest),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.CustomToolCall),
                ResponseCustomToolCallOutputItem,
                typeof(global::tryAGI.OpenAI.CustomToolCallOutputResource),
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
        public bool Equals(OutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallResource, other.FunctionToolCallResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallResource, other.ComputerToolCallResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchCall?>.Default.Equals(ToolSearchCall, other.ToolSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchOutput?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CompactionBody?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCallOutput?>.Default.Equals(LocalShellCallOutput, other.LocalShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCall?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutput?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolCall?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolCallOutput?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalResponseResource?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallOutputResource?>.Default.Equals(ResponseCustomToolCallOutputItem, other.ResponseCustomToolCallOutputItem) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItem obj1, OutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItem obj1, OutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItem o && Equals(o);
        }
    }
}
