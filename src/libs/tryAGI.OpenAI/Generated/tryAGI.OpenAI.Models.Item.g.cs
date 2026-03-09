#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct Item : global::System.IEquatable<Item>
    {
        /// <summary>
        /// A message input to the model with a role indicating instruction following<br/>
        /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
        /// precedence over instructions given with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputMessage? Message1 { get; init; }
#else
        public global::tryAGI.OpenAI.InputMessage? Message1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message1))]
#endif
        public bool IsMessage1 => Message1 != null;

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputMessage? Message2 { get; init; }
#else
        public global::tryAGI.OpenAI.OutputMessage? Message2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message2))]
#endif
        public bool IsMessage2 => Message2 != null;

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
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? ComputerCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? ComputerCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutput))]
#endif
        public bool IsComputerCallOutput => ComputerCallOutput != null;

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
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? FunctionCallOutput { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolSearchCallItemParam? ToolSearchCall { get; init; }
#else
        public global::tryAGI.OpenAI.ToolSearchCallItemParam? ToolSearchCall { get; }
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
        public global::tryAGI.OpenAI.ToolSearchOutputItemParam? ToolSearchOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ToolSearchOutputItemParam? ToolSearchOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchOutput))]
#endif
        public bool IsToolSearchOutput => ToolSearchOutput != null;

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
        /// A compaction item generated by the [`v1/responses/compact` API](/docs/api-reference/responses/compact).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CompactionSummaryItemParam? Compaction { get; init; }
#else
        public global::tryAGI.OpenAI.CompactionSummaryItemParam? Compaction { get; }
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
        /// A tool representing a request to execute one or more shell commands.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCallItemParam? ShellCall { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallItemParam? ShellCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCall))]
#endif
        public bool IsShellCall => ShellCall != null;

        /// <summary>
        /// The streamed output items emitted by a shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? ShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? ShellCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        /// A tool call representing a request to create, delete, or update files using diff patches.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? ApplyPatchCall { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? ApplyPatchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        /// The streamed output emitted by an apply patch tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? ApplyPatchCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? ApplyPatchCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutput))]
#endif
        public bool IsApplyPatchCallOutput => ApplyPatchCallOutput != null;

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
        public global::tryAGI.OpenAI.MCPApprovalResponse? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalResponse? McpApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

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
        /// The output of a custom tool call from your code, being sent back to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCallOutput? CustomToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutput))]
#endif
        public bool IsCustomToolCallOutput => CustomToolCallOutput != null;

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
        public static implicit operator Item(global::tryAGI.OpenAI.InputMessage value) => new Item((global::tryAGI.OpenAI.InputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputMessage?(Item @this) => @this.Message1;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.InputMessage? value)
        {
            Message1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.OutputMessage value) => new Item((global::tryAGI.OpenAI.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputMessage?(Item @this) => @this.Message2;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.OutputMessage? value)
        {
            Message2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FileSearchToolCall value) => new Item((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(Item @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ComputerToolCall value) => new Item((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(Item @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ComputerCallOutputItemParam value) => new Item((global::tryAGI.OpenAI.ComputerCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerCallOutputItemParam?(Item @this) => @this.ComputerCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ComputerCallOutputItemParam? value)
        {
            ComputerCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.WebSearchToolCall value) => new Item((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(Item @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionToolCall value) => new Item((global::tryAGI.OpenAI.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCall?(Item @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionToolCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionCallOutputItemParam value) => new Item((global::tryAGI.OpenAI.FunctionCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionCallOutputItemParam?(Item @this) => @this.FunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionCallOutputItemParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ToolSearchCallItemParam value) => new Item((global::tryAGI.OpenAI.ToolSearchCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchCallItemParam?(Item @this) => @this.ToolSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ToolSearchCallItemParam? value)
        {
            ToolSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ToolSearchOutputItemParam value) => new Item((global::tryAGI.OpenAI.ToolSearchOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchOutputItemParam?(Item @this) => @this.ToolSearchOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ToolSearchOutputItemParam? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ReasoningItem value) => new Item((global::tryAGI.OpenAI.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningItem?(Item @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.CompactionSummaryItemParam value) => new Item((global::tryAGI.OpenAI.CompactionSummaryItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CompactionSummaryItemParam?(Item @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.CompactionSummaryItemParam? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ImageGenToolCall value) => new Item((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(Item @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new Item((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(Item @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.LocalShellToolCall value) => new Item((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(Item @this) => @this.LocalShellCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.LocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.LocalShellToolCallOutput value) => new Item((global::tryAGI.OpenAI.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCallOutput?(Item @this) => @this.LocalShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.LocalShellToolCallOutput? value)
        {
            LocalShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionShellCallItemParam value) => new Item((global::tryAGI.OpenAI.FunctionShellCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallItemParam?(Item @this) => @this.ShellCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionShellCallItemParam? value)
        {
            ShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam value) => new Item((global::tryAGI.OpenAI.FunctionShellCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutputItemParam?(Item @this) => @this.ShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam value) => new Item((global::tryAGI.OpenAI.ApplyPatchToolCallItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolCallItemParam?(Item @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam value) => new Item((global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam?(Item @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.MCPListTools value) => new Item((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(Item @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.MCPApprovalRequest value) => new Item((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(Item @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.MCPApprovalResponse value) => new Item((global::tryAGI.OpenAI.MCPApprovalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalResponse?(Item @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPApprovalResponse? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.MCPToolCall value) => new Item((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(Item @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.CustomToolCallOutput value) => new Item((global::tryAGI.OpenAI.CustomToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallOutput?(Item @this) => @this.CustomToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.CustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.CustomToolCall value) => new Item((global::tryAGI.OpenAI.CustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCall?(Item @this) => @this.CustomToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.CustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Item(
            global::tryAGI.OpenAI.InputMessage? message1,
            global::tryAGI.OpenAI.OutputMessage? message2,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerCall,
            global::tryAGI.OpenAI.ComputerCallOutputItemParam? computerCallOutput,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchCall,
            global::tryAGI.OpenAI.FunctionToolCall? functionCall,
            global::tryAGI.OpenAI.FunctionCallOutputItemParam? functionCallOutput,
            global::tryAGI.OpenAI.ToolSearchCallItemParam? toolSearchCall,
            global::tryAGI.OpenAI.ToolSearchOutputItemParam? toolSearchOutput,
            global::tryAGI.OpenAI.ReasoningItem? reasoning,
            global::tryAGI.OpenAI.CompactionSummaryItemParam? compaction,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenerationCall,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellCall,
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellCallOutput,
            global::tryAGI.OpenAI.FunctionShellCallItemParam? shellCall,
            global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? shellCallOutput,
            global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? applyPatchCall,
            global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? applyPatchCallOutput,
            global::tryAGI.OpenAI.MCPListTools? mcpListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mcpApprovalRequest,
            global::tryAGI.OpenAI.MCPApprovalResponse? mcpApprovalResponse,
            global::tryAGI.OpenAI.MCPToolCall? mcpCall,
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.CustomToolCall? customToolCall
            )
        {
            Message1 = message1;
            Message2 = message2;
            FileSearchCall = fileSearchCall;
            ComputerCall = computerCall;
            ComputerCallOutput = computerCallOutput;
            WebSearchCall = webSearchCall;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            ToolSearchCall = toolSearchCall;
            ToolSearchOutput = toolSearchOutput;
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
            ToolSearchOutput as object ??
            ToolSearchCall as object ??
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
            ToolSearchCall?.ToString() ??
            ToolSearchOutput?.ToString() ??
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
            return IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsMcpCall && !IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && IsCustomToolCallOutput && !IsCustomToolCall || !IsMessage1 && !IsMessage2 && !IsFileSearchCall && !IsComputerCall && !IsComputerCallOutput && !IsWebSearchCall && !IsFunctionCall && !IsFunctionCallOutput && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCompaction && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCallOutput && IsCustomToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputMessage?, TResult>? message1 = null,
            global::System.Func<global::tryAGI.OpenAI.OutputMessage?, TResult>? message2 = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerCallOutputItemParam?, TResult>? computerCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCall?, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionCallOutputItemParam?, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchCallItemParam?, TResult>? toolSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchOutputItemParam?, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.CompactionSummaryItemParam?, TResult>? compaction = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenerationCall = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCallOutput?, TResult>? localShellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallItemParam?, TResult>? shellCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutputItemParam?, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolCallItemParam?, TResult>? applyPatchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam?, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mcpListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalResponse?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutput?, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCall?, TResult>? customToolCall = null,
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
            else if (IsToolSearchCall && toolSearchCall != null)
            {
                return toolSearchCall(ToolSearchCall!);
            }
            else if (IsToolSearchOutput && toolSearchOutput != null)
            {
                return toolSearchOutput(ToolSearchOutput!);
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
            global::System.Action<global::tryAGI.OpenAI.InputMessage?>? message1 = null,
            global::System.Action<global::tryAGI.OpenAI.OutputMessage?>? message2 = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerCallOutputItemParam?>? computerCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCall?>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionCallOutputItemParam?>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchCallItemParam?>? toolSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchOutputItemParam?>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.CompactionSummaryItemParam?>? compaction = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenerationCall = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCallOutput?>? localShellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallItemParam?>? shellCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutputItemParam?>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolCallItemParam?>? applyPatchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam?>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mcpListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mcpApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalResponse?>? mcpApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutput?>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCall?>? customToolCall = null,
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
            else if (IsToolSearchCall)
            {
                toolSearchCall?.Invoke(ToolSearchCall!);
            }
            else if (IsToolSearchOutput)
            {
                toolSearchOutput?.Invoke(ToolSearchOutput!);
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
                typeof(global::tryAGI.OpenAI.InputMessage),
                Message2,
                typeof(global::tryAGI.OpenAI.OutputMessage),
                FileSearchCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                ComputerCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerCallOutput,
                typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam),
                WebSearchCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.FunctionToolCall),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam),
                ToolSearchCall,
                typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItem),
                Compaction,
                typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam),
                ImageGenerationCall,
                typeof(global::tryAGI.OpenAI.ImageGenToolCall),
                CodeInterpreterCall,
                typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall),
                LocalShellCall,
                typeof(global::tryAGI.OpenAI.LocalShellToolCall),
                LocalShellCallOutput,
                typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput),
                ShellCall,
                typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam),
                ShellCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam),
                ApplyPatchCall,
                typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam),
                ApplyPatchCallOutput,
                typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam),
                McpListTools,
                typeof(global::tryAGI.OpenAI.MCPListTools),
                McpApprovalRequest,
                typeof(global::tryAGI.OpenAI.MCPApprovalRequest),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.MCPApprovalResponse),
                McpCall,
                typeof(global::tryAGI.OpenAI.MCPToolCall),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.CustomToolCallOutput),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.CustomToolCall),
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
        public bool Equals(Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputMessage?>.Default.Equals(Message1, other.Message1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputMessage?>.Default.Equals(Message2, other.Message2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerCallOutputItemParam?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchCallItemParam?>.Default.Equals(ToolSearchCall, other.ToolSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchOutputItemParam?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CompactionSummaryItemParam?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCallOutput?>.Default.Equals(LocalShellCallOutput, other.LocalShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallItemParam?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutputItemParam?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolCallItemParam?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalResponse?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Item obj1, Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Item obj1, Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Item o && Equals(o);
        }
    }
}
