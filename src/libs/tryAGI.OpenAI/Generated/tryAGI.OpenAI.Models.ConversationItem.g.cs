#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A single item within a conversation. The set of possible types are the same as the `output` type of a [Response object](https://platform.openai.com/docs/api-reference/responses/object#responses/object-output).
    /// </summary>
    public readonly partial struct ConversationItem : global::System.IEquatable<ConversationItem>
    {
        /// <summary>
        /// 
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
        /// The results of a file search tool call. See the<br/>
        /// [file search guide](https://platform.openai.com/docs/guides/tools-file-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FileSearchToolCall? FileSearchToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.FileSearchToolCall? FileSearchToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchToolCall))]
#endif
        public bool IsFileSearchToolCall => FileSearchToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.FileSearchToolCall value) => new ConversationItem((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(ConversationItem @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.FileSearchToolCall? value)
        {
            FileSearchToolCall = value;
        }

        /// <summary>
        /// The results of a web search tool call. See the <br/>
        /// [web search guide](https://platform.openai.com/docs/guides/tools-web-search) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchToolCall? WebSearchToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchToolCall? WebSearchToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolCall))]
#endif
        public bool IsWebSearchToolCall => WebSearchToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.WebSearchToolCall value) => new ConversationItem((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(ConversationItem @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// An image generation request made by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageGenToolCall? ImageGenToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenToolCall? ImageGenToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenToolCall))]
#endif
        public bool IsImageGenToolCall => ImageGenToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ImageGenToolCall value) => new ConversationItem((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(ConversationItem @this) => @this.ImageGenToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ImageGenToolCall? value)
        {
            ImageGenToolCall = value;
        }

        /// <summary>
        /// A tool call to a computer use tool. See the <br/>
        /// [computer use guide](https://platform.openai.com/docs/guides/tools-computer-use) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerToolCall? ComputerToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCall? ComputerToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCall))]
#endif
        public bool IsComputerToolCall => ComputerToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.ComputerToolCall value) => new ConversationItem((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(ConversationItem @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

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
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response. Be sure to include these items in your `input` to the Responses API<br/>
        /// for subsequent turns of a conversation if you are manually<br/>
        /// [managing context](https://platform.openai.com/docs/guides/conversation-state).
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
        /// A tool call to run code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? CodeInterpreterToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterToolCall? CodeInterpreterToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterToolCall))]
#endif
        public bool IsCodeInterpreterToolCall => CodeInterpreterToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new ConversationItem((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(ConversationItem @this) => @this.CodeInterpreterToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
        {
            CodeInterpreterToolCall = value;
        }

        /// <summary>
        /// A tool call to run a command on the local shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalShellToolCall? LocalShellToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.LocalShellToolCall? LocalShellToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellToolCall))]
#endif
        public bool IsLocalShellToolCall => LocalShellToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.LocalShellToolCall value) => new ConversationItem((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(ConversationItem @this) => @this.LocalShellToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.LocalShellToolCall? value)
        {
            LocalShellToolCall = value;
        }

        /// <summary>
        /// The output of a local shell tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? LocalShellToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.LocalShellToolCallOutput? LocalShellToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellToolCallOutput))]
#endif
        public bool IsLocalShellToolCallOutput => LocalShellToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.LocalShellToolCallOutput value) => new ConversationItem((global::tryAGI.OpenAI.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCallOutput?(ConversationItem @this) => @this.LocalShellToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.LocalShellToolCallOutput? value)
        {
            LocalShellToolCallOutput = value;
        }

        /// <summary>
        /// A list of tools available on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPListTools? MCPListTools { get; init; }
#else
        public global::tryAGI.OpenAI.MCPListTools? MCPListTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPListTools))]
#endif
        public bool IsMCPListTools => MCPListTools != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPListTools value) => new ConversationItem((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(ConversationItem @this) => @this.MCPListTools;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPListTools? value)
        {
            MCPListTools = value;
        }

        /// <summary>
        /// A request for human approval of a tool invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPApprovalRequest? MCPApprovalRequest { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalRequest? MCPApprovalRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPApprovalRequest))]
#endif
        public bool IsMCPApprovalRequest => MCPApprovalRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPApprovalRequest value) => new ConversationItem((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(ConversationItem @this) => @this.MCPApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            MCPApprovalRequest = value;
        }

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? MCPApprovalResponseResource { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? MCPApprovalResponseResource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPApprovalResponseResource))]
#endif
        public bool IsMCPApprovalResponseResource => MCPApprovalResponseResource != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPApprovalResponseResource value) => new ConversationItem((global::tryAGI.OpenAI.MCPApprovalResponseResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalResponseResource?(ConversationItem @this) => @this.MCPApprovalResponseResource;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPApprovalResponseResource? value)
        {
            MCPApprovalResponseResource = value;
        }

        /// <summary>
        /// An invocation of a tool on an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPToolCall? MCPToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.MCPToolCall? MCPToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPToolCall))]
#endif
        public bool IsMCPToolCall => MCPToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationItem(global::tryAGI.OpenAI.MCPToolCall value) => new ConversationItem((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(ConversationItem @this) => @this.MCPToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ConversationItem(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            MCPToolCall = value;
        }

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
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenToolCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall,
            global::tryAGI.OpenAI.ComputerToolCallOutputResource? computerToolCallOutputResource,
            global::tryAGI.OpenAI.ReasoningItem? reasoning,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterToolCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellToolCall,
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellToolCallOutput,
            global::tryAGI.OpenAI.MCPListTools? mCPListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mCPApprovalRequest,
            global::tryAGI.OpenAI.MCPApprovalResponseResource? mCPApprovalResponseResource,
            global::tryAGI.OpenAI.MCPToolCall? mCPToolCall,
            global::tryAGI.OpenAI.CustomToolCall? customToolCall,
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput
            )
        {
            Message = message;
            FunctionToolCallResource = functionToolCallResource;
            FunctionToolCallOutputResource = functionToolCallOutputResource;
            FileSearchToolCall = fileSearchToolCall;
            WebSearchToolCall = webSearchToolCall;
            ImageGenToolCall = imageGenToolCall;
            ComputerToolCall = computerToolCall;
            ComputerToolCallOutputResource = computerToolCallOutputResource;
            Reasoning = reasoning;
            CodeInterpreterToolCall = codeInterpreterToolCall;
            LocalShellToolCall = localShellToolCall;
            LocalShellToolCallOutput = localShellToolCallOutput;
            MCPListTools = mCPListTools;
            MCPApprovalRequest = mCPApprovalRequest;
            MCPApprovalResponseResource = mCPApprovalResponseResource;
            MCPToolCall = mCPToolCall;
            CustomToolCall = customToolCall;
            CustomToolCallOutput = customToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCallOutput as object ??
            CustomToolCall as object ??
            MCPToolCall as object ??
            MCPApprovalResponseResource as object ??
            MCPApprovalRequest as object ??
            MCPListTools as object ??
            LocalShellToolCallOutput as object ??
            LocalShellToolCall as object ??
            CodeInterpreterToolCall as object ??
            Reasoning as object ??
            ComputerToolCallOutputResource as object ??
            ComputerToolCall as object ??
            ImageGenToolCall as object ??
            WebSearchToolCall as object ??
            FileSearchToolCall as object ??
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
            FileSearchToolCall?.ToString() ??
            WebSearchToolCall?.ToString() ??
            ImageGenToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            ComputerToolCallOutputResource?.ToString() ??
            Reasoning?.ToString() ??
            CodeInterpreterToolCall?.ToString() ??
            LocalShellToolCall?.ToString() ??
            LocalShellToolCallOutput?.ToString() ??
            MCPListTools?.ToString() ??
            MCPApprovalRequest?.ToString() ??
            MCPApprovalResponseResource?.ToString() ??
            MCPToolCall?.ToString() ??
            CustomToolCall?.ToString() ??
            CustomToolCallOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFunctionToolCallResource || IsFunctionToolCallOutputResource || IsFileSearchToolCall || IsWebSearchToolCall || IsImageGenToolCall || IsComputerToolCall || IsComputerToolCallOutputResource || IsReasoning || IsCodeInterpreterToolCall || IsLocalShellToolCall || IsLocalShellToolCallOutput || IsMCPListTools || IsMCPApprovalRequest || IsMCPApprovalResponseResource || IsMCPToolCall || IsCustomToolCall || IsCustomToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Message?, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallResource?, TResult>? functionToolCallResource = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutputResource?, TResult>? functionToolCallOutputResource = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutputResource?, TResult>? computerToolCallOutputResource = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCallOutput?, TResult>? localShellToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mCPListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mCPApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalResponseResource?, TResult>? mCPApprovalResponseResource = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mCPToolCall = null,
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
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsImageGenToolCall && imageGenToolCall != null)
            {
                return imageGenToolCall(ImageGenToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
            }
            else if (IsComputerToolCallOutputResource && computerToolCallOutputResource != null)
            {
                return computerToolCallOutputResource(ComputerToolCallOutputResource!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsCodeInterpreterToolCall && codeInterpreterToolCall != null)
            {
                return codeInterpreterToolCall(CodeInterpreterToolCall!);
            }
            else if (IsLocalShellToolCall && localShellToolCall != null)
            {
                return localShellToolCall(LocalShellToolCall!);
            }
            else if (IsLocalShellToolCallOutput && localShellToolCallOutput != null)
            {
                return localShellToolCallOutput(LocalShellToolCallOutput!);
            }
            else if (IsMCPListTools && mCPListTools != null)
            {
                return mCPListTools(MCPListTools!);
            }
            else if (IsMCPApprovalRequest && mCPApprovalRequest != null)
            {
                return mCPApprovalRequest(MCPApprovalRequest!);
            }
            else if (IsMCPApprovalResponseResource && mCPApprovalResponseResource != null)
            {
                return mCPApprovalResponseResource(MCPApprovalResponseResource!);
            }
            else if (IsMCPToolCall && mCPToolCall != null)
            {
                return mCPToolCall(MCPToolCall!);
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
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>? computerToolCallOutputResource = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCallOutput?>? localShellToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mCPListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mCPApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalResponseResource?>? mCPApprovalResponseResource = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mCPToolCall = null,
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
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsImageGenToolCall)
            {
                imageGenToolCall?.Invoke(ImageGenToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsComputerToolCallOutputResource)
            {
                computerToolCallOutputResource?.Invoke(ComputerToolCallOutputResource!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsCodeInterpreterToolCall)
            {
                codeInterpreterToolCall?.Invoke(CodeInterpreterToolCall!);
            }
            else if (IsLocalShellToolCall)
            {
                localShellToolCall?.Invoke(LocalShellToolCall!);
            }
            else if (IsLocalShellToolCallOutput)
            {
                localShellToolCallOutput?.Invoke(LocalShellToolCallOutput!);
            }
            else if (IsMCPListTools)
            {
                mCPListTools?.Invoke(MCPListTools!);
            }
            else if (IsMCPApprovalRequest)
            {
                mCPApprovalRequest?.Invoke(MCPApprovalRequest!);
            }
            else if (IsMCPApprovalResponseResource)
            {
                mCPApprovalResponseResource?.Invoke(MCPApprovalResponseResource!);
            }
            else if (IsMCPToolCall)
            {
                mCPToolCall?.Invoke(MCPToolCall!);
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
                FileSearchToolCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                WebSearchToolCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                ImageGenToolCall,
                typeof(global::tryAGI.OpenAI.ImageGenToolCall),
                ComputerToolCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerToolCallOutputResource,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItem),
                CodeInterpreterToolCall,
                typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall),
                LocalShellToolCall,
                typeof(global::tryAGI.OpenAI.LocalShellToolCall),
                LocalShellToolCallOutput,
                typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput),
                MCPListTools,
                typeof(global::tryAGI.OpenAI.MCPListTools),
                MCPApprovalRequest,
                typeof(global::tryAGI.OpenAI.MCPApprovalRequest),
                MCPApprovalResponseResource,
                typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource),
                MCPToolCall,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenToolCall, other.ImageGenToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutputResource, other.ComputerToolCallOutputResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterToolCall, other.CodeInterpreterToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellToolCall, other.LocalShellToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCallOutput?>.Default.Equals(LocalShellToolCallOutput, other.LocalShellToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(MCPListTools, other.MCPListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(MCPApprovalRequest, other.MCPApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalResponseResource?>.Default.Equals(MCPApprovalResponseResource, other.MCPApprovalResponseResource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(MCPToolCall, other.MCPToolCall) &&
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
