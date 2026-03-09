#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A single item within a conversation. The set of possible types are the same as the `output` type of a [Response object](/docs/api-reference/responses/object#responses/object-output).
    /// </summary>
    public readonly partial struct ConversationItem : global::System.IEquatable<ConversationItem>
    {
        /// <summary>
        /// A message to or from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Message? Message { get; init; }
#else
        public global::tryAGI.OpenAI.Message? Message { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallResource? FunctionToolCallResource { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallResource? FunctionToolCallResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallResource))]
#endif
        public bool IsFunctionToolCallResource => FunctionToolCallResource != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? FunctionToolCallOutputResource { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? FunctionToolCallOutputResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutputResource))]
#endif
        public bool IsFunctionToolCallOutputResource => FunctionToolCallOutputResource != null;

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
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? ComputerToolCallOutputResource { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? ComputerToolCallOutputResource { get; }
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
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.Message value) => new ConversationItem((global::tryAGI.OpenAI.Message?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Message?(ConversationItem @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.Message? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.FunctionToolCallResource value) => new ConversationItem((global::tryAGI.OpenAI.FunctionToolCallResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallResource?(ConversationItem @this) => @this.FunctionToolCallResource;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.FunctionToolCallResource? value)
        {
            FunctionToolCallResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.FunctionToolCallOutputResource value) => new ConversationItem((global::tryAGI.OpenAI.FunctionToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallOutputResource?(ConversationItem @this) => @this.FunctionToolCallOutputResource;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.FunctionToolCallOutputResource? value)
        {
            FunctionToolCallOutputResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.FileSearchToolCall value) => new ConversationItem((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(ConversationItem @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.FileSearchToolCall? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.WebSearchToolCall value) => new ConversationItem((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(ConversationItem @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ImageGenToolCall value) => new ConversationItem((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(ConversationItem @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ImageGenToolCall? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ComputerToolCall value) => new ConversationItem((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(ConversationItem @this) => @this.ComputerCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ComputerToolCallOutputResource value) => new ConversationItem((global::tryAGI.OpenAI.ComputerToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCallOutputResource?(ConversationItem @this) => @this.ComputerToolCallOutputResource;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ComputerToolCallOutputResource? value)
        {
            ComputerToolCallOutputResource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ToolSearchCall value) => new ConversationItem((global::tryAGI.OpenAI.ToolSearchCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchCall?(ConversationItem @this) => @this.ToolSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ToolSearchCall? value)
        {
            ToolSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ToolSearchOutput value) => new ConversationItem((global::tryAGI.OpenAI.ToolSearchOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchOutput?(ConversationItem @this) => @this.ToolSearchOutput;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ToolSearchOutput? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ReasoningItem value) => new ConversationItem((global::tryAGI.OpenAI.ReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningItem?(ConversationItem @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new ConversationItem((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(ConversationItem @this) => @this.CodeInterpreterCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.LocalShellToolCall value) => new ConversationItem((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(ConversationItem @this) => @this.LocalShellCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.LocalShellToolCall? value)
        {
            LocalShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.LocalShellToolCallOutput value) => new ConversationItem((global::tryAGI.OpenAI.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCallOutput?(ConversationItem @this) => @this.LocalShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.LocalShellToolCallOutput? value)
        {
            LocalShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.FunctionShellCall value) => new ConversationItem((global::tryAGI.OpenAI.FunctionShellCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCall?(ConversationItem @this) => @this.ShellCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.FunctionShellCall? value)
        {
            ShellCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.FunctionShellCallOutput value) => new ConversationItem((global::tryAGI.OpenAI.FunctionShellCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutput?(ConversationItem @this) => @this.ShellCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.FunctionShellCallOutput? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ApplyPatchToolCall value) => new ConversationItem((global::tryAGI.OpenAI.ApplyPatchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolCall?(ConversationItem @this) => @this.ApplyPatchCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ApplyPatchToolCall? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ApplyPatchToolCallOutput value) => new ConversationItem((global::tryAGI.OpenAI.ApplyPatchToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolCallOutput?(ConversationItem @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ApplyPatchToolCallOutput? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPListTools value) => new ConversationItem((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(ConversationItem @this) => @this.McpListTools;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPListTools? value)
        {
            McpListTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPApprovalRequest value) => new ConversationItem((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(ConversationItem @this) => @this.McpApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            McpApprovalRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPApprovalResponseResource value) => new ConversationItem((global::tryAGI.OpenAI.MCPApprovalResponseResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalResponseResource?(ConversationItem @this) => @this.McpApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPApprovalResponseResource? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPToolCall value) => new ConversationItem((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(ConversationItem @this) => @this.McpCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            McpCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.CustomToolCall value) => new ConversationItem((global::tryAGI.OpenAI.CustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCall?(ConversationItem @this) => @this.CustomToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.CustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.CustomToolCallOutput value) => new ConversationItem((global::tryAGI.OpenAI.CustomToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallOutput?(ConversationItem @this) => @this.CustomToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.CustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(
            global::tryAGI.OpenAI.Message? message,
            global::tryAGI.OpenAI.FunctionToolCallResource? functionToolCallResource,
            global::tryAGI.OpenAI.FunctionToolCallOutputResource? functionToolCallOutputResource,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchCall,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchCall,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenerationCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerCall,
            global::tryAGI.OpenAI.ComputerToolCallOutputResource? computerToolCallOutputResource,
            global::tryAGI.OpenAI.ToolSearchCall? toolSearchCall,
            global::tryAGI.OpenAI.ToolSearchOutput? toolSearchOutput,
            global::tryAGI.OpenAI.ReasoningItem? reasoning,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellCall,
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellCallOutput,
            global::tryAGI.OpenAI.FunctionShellCall? shellCall,
            global::tryAGI.OpenAI.FunctionShellCallOutput? shellCallOutput,
            global::tryAGI.OpenAI.ApplyPatchToolCall? applyPatchCall,
            global::tryAGI.OpenAI.ApplyPatchToolCallOutput? applyPatchCallOutput,
            global::tryAGI.OpenAI.MCPListTools? mcpListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mcpApprovalRequest,
            global::tryAGI.OpenAI.MCPApprovalResponseResource? mcpApprovalResponse,
            global::tryAGI.OpenAI.MCPToolCall? mcpCall,
            global::tryAGI.OpenAI.CustomToolCall? customToolCall,
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput
            )
        {
            Message = message;
            FunctionToolCallResource = functionToolCallResource;
            FunctionToolCallOutputResource = functionToolCallOutputResource;
            FileSearchCall = fileSearchCall;
            WebSearchCall = webSearchCall;
            ImageGenerationCall = imageGenerationCall;
            ComputerCall = computerCall;
            ComputerToolCallOutputResource = computerToolCallOutputResource;
            ToolSearchCall = toolSearchCall;
            ToolSearchOutput = toolSearchOutput;
            Reasoning = reasoning;
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
            Reasoning as object ??
            ToolSearchOutput as object ??
            ToolSearchCall as object ??
            ComputerToolCallOutputResource as object ??
            ComputerCall as object ??
            ImageGenerationCall as object ??
            WebSearchCall as object ??
            FileSearchCall as object ??
            FunctionToolCallOutputResource as object ??
            FunctionToolCallResource as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FunctionToolCallResource?.ToString() ??
            FunctionToolCallOutputResource?.ToString() ??
            FileSearchCall?.ToString() ??
            WebSearchCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            ComputerCall?.ToString() ??
            ComputerToolCallOutputResource?.ToString() ??
            ToolSearchCall?.ToString() ??
            ToolSearchOutput?.ToString() ??
            Reasoning?.ToString() ??
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
            return IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && IsMcpCall && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionToolCallResource && !IsFunctionToolCallOutputResource && !IsFileSearchCall && !IsWebSearchCall && !IsImageGenerationCall && !IsComputerCall && !IsComputerToolCallOutputResource && !IsToolSearchCall && !IsToolSearchOutput && !IsReasoning && !IsCodeInterpreterCall && !IsLocalShellCall && !IsLocalShellCallOutput && !IsShellCall && !IsShellCallOutput && !IsApplyPatchCall && !IsApplyPatchCallOutput && !IsMcpListTools && !IsMcpApprovalRequest && !IsMcpApprovalResponse && !IsMcpCall && !IsCustomToolCall && IsCustomToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Message?, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallResource?, TResult>? functionToolCallResource = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutputResource?, TResult>? functionToolCallOutputResource = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenerationCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutputResource?, TResult>? computerToolCallOutputResource = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchCall?, TResult>? toolSearchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchOutput?, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCallOutput?, TResult>? localShellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCall?, TResult>? shellCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutput?, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolCall?, TResult>? applyPatchCall = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolCallOutput?, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mcpListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mcpApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalResponseResource?, TResult>? mcpApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mcpCall = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCall?, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutput?, TResult>? customToolCallOutput = null,
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
            else if (IsFunctionToolCallResource && functionToolCallResource != null)
            {
                return functionToolCallResource(FunctionToolCallResource!);
            }
            else if (IsFunctionToolCallOutputResource && functionToolCallOutputResource != null)
            {
                return functionToolCallOutputResource(FunctionToolCallOutputResource!);
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
            global::System.Action<global::tryAGI.OpenAI.Message?>? message = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallResource?>? functionToolCallResource = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallOutputResource?>? functionToolCallOutputResource = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenerationCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>? computerToolCallOutputResource = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchCall?>? toolSearchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchOutput?>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCallOutput?>? localShellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCall?>? shellCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutput?>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolCall?>? applyPatchCall = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolCallOutput?>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mcpListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mcpApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalResponseResource?>? mcpApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mcpCall = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCall?>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutput?>? customToolCallOutput = null,
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
            else if (IsFunctionToolCallResource)
            {
                functionToolCallResource?.Invoke(FunctionToolCallResource!);
            }
            else if (IsFunctionToolCallOutputResource)
            {
                functionToolCallOutputResource?.Invoke(FunctionToolCallOutputResource!);
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
                typeof(global::tryAGI.OpenAI.Message),
                FunctionToolCallResource,
                typeof(global::tryAGI.OpenAI.FunctionToolCallResource),
                FunctionToolCallOutputResource,
                typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource),
                FileSearchCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                WebSearchCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                ImageGenerationCall,
                typeof(global::tryAGI.OpenAI.ImageGenToolCall),
                ComputerCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerToolCallOutputResource,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource),
                ToolSearchCall,
                typeof(global::tryAGI.OpenAI.ToolSearchCall),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.ToolSearchOutput),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItem),
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
                McpListTools,
                typeof(global::tryAGI.OpenAI.MCPListTools),
                McpApprovalRequest,
                typeof(global::tryAGI.OpenAI.MCPApprovalRequest),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource),
                McpCall,
                typeof(global::tryAGI.OpenAI.MCPToolCall),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.CustomToolCall),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.CustomToolCallOutput),
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
        public bool Equals(ConversationItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Message?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallResource?>.Default.Equals(FunctionToolCallResource, other.FunctionToolCallResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallOutputResource, other.FunctionToolCallOutputResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutputResource, other.ComputerToolCallOutputResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchCall?>.Default.Equals(ToolSearchCall, other.ToolSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchOutput?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellCall, other.LocalShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCallOutput?>.Default.Equals(LocalShellCallOutput, other.LocalShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCall?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutput?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolCall?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolCallOutput?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(McpListTools, other.McpListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(McpApprovalRequest, other.McpApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalResponseResource?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(McpCall, other.McpCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationItem obj1, ConversationItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationItem obj1, ConversationItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationItem o && Equals(o);
        }
    }
}
