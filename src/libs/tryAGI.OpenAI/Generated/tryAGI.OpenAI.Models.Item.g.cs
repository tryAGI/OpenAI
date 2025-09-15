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
        public global::tryAGI.OpenAI.InputMessage? InputMessage { get; init; }
#else
        public global::tryAGI.OpenAI.InputMessage? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.InputMessage value) => new Item((global::tryAGI.OpenAI.InputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputMessage?(Item @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.InputMessage? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// An output message from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputMessage? OutputMessage { get; init; }
#else
        public global::tryAGI.OpenAI.OutputMessage? OutputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessage))]
#endif
        public bool IsOutputMessage => OutputMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.OutputMessage value) => new Item((global::tryAGI.OpenAI.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputMessage?(Item @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.OutputMessage? value)
        {
            OutputMessage = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.FileSearchToolCall value) => new Item((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(Item @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FileSearchToolCall? value)
        {
            FileSearchToolCall = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.ComputerToolCall value) => new Item((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(Item @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? ComputerCallOutputParam { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerCallOutputItemParam? ComputerCallOutputParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutputParam))]
#endif
        public bool IsComputerCallOutputParam => ComputerCallOutputParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.ComputerCallOutputItemParam value) => new Item((global::tryAGI.OpenAI.ComputerCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerCallOutputItemParam?(Item @this) => @this.ComputerCallOutputParam;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ComputerCallOutputItemParam? value)
        {
            ComputerCallOutputParam = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.WebSearchToolCall value) => new Item((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(Item @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// A tool call to run a function. See the <br/>
        /// [function calling guide](https://platform.openai.com/docs/guides/function-calling) for more information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCall? FunctionToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCall? FunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCall))]
#endif
        public bool IsFunctionToolCall => FunctionToolCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionToolCall value) => new Item((global::tryAGI.OpenAI.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCall?(Item @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionToolCall? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? FunctionCallOutputParam { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionCallOutputItemParam? FunctionCallOutputParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputParam))]
#endif
        public bool IsFunctionCallOutputParam => FunctionCallOutputParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionCallOutputItemParam value) => new Item((global::tryAGI.OpenAI.FunctionCallOutputItemParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionCallOutputItemParam?(Item @this) => @this.FunctionCallOutputParam;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionCallOutputItemParam? value)
        {
            FunctionCallOutputParam = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.ImageGenToolCall value) => new Item((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(Item @this) => @this.ImageGenToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ImageGenToolCall? value)
        {
            ImageGenToolCall = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new Item((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(Item @this) => @this.CodeInterpreterToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
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
        public static implicit operator Item(global::tryAGI.OpenAI.LocalShellToolCall value) => new Item((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(Item @this) => @this.LocalShellToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.LocalShellToolCall? value)
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
        public static implicit operator Item(global::tryAGI.OpenAI.LocalShellToolCallOutput value) => new Item((global::tryAGI.OpenAI.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCallOutput?(Item @this) => @this.LocalShellToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.LocalShellToolCallOutput? value)
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
        public static implicit operator Item(global::tryAGI.OpenAI.MCPListTools value) => new Item((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(Item @this) => @this.MCPListTools;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPListTools? value)
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
        public static implicit operator Item(global::tryAGI.OpenAI.MCPApprovalRequest value) => new Item((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(Item @this) => @this.MCPApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            MCPApprovalRequest = value;
        }

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPApprovalResponse? MCPApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalResponse? MCPApprovalResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPApprovalResponse))]
#endif
        public bool IsMCPApprovalResponse => MCPApprovalResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Item(global::tryAGI.OpenAI.MCPApprovalResponse value) => new Item((global::tryAGI.OpenAI.MCPApprovalResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalResponse?(Item @this) => @this.MCPApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPApprovalResponse? value)
        {
            MCPApprovalResponse = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.MCPToolCall value) => new Item((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(Item @this) => @this.MCPToolCall;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            MCPToolCall = value;
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
            global::tryAGI.OpenAI.InputMessage? inputMessage,
            global::tryAGI.OpenAI.OutputMessage? outputMessage,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall,
            global::tryAGI.OpenAI.ComputerCallOutputItemParam? computerCallOutputParam,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall,
            global::tryAGI.OpenAI.FunctionToolCall? functionToolCall,
            global::tryAGI.OpenAI.FunctionCallOutputItemParam? functionCallOutputParam,
            global::tryAGI.OpenAI.ReasoningItem? reasoning,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenToolCall,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterToolCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellToolCall,
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellToolCallOutput,
            global::tryAGI.OpenAI.MCPListTools? mCPListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mCPApprovalRequest,
            global::tryAGI.OpenAI.MCPApprovalResponse? mCPApprovalResponse,
            global::tryAGI.OpenAI.MCPToolCall? mCPToolCall,
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.CustomToolCall? customToolCall
            )
        {
            InputMessage = inputMessage;
            OutputMessage = outputMessage;
            FileSearchToolCall = fileSearchToolCall;
            ComputerToolCall = computerToolCall;
            ComputerCallOutputParam = computerCallOutputParam;
            WebSearchToolCall = webSearchToolCall;
            FunctionToolCall = functionToolCall;
            FunctionCallOutputParam = functionCallOutputParam;
            Reasoning = reasoning;
            ImageGenToolCall = imageGenToolCall;
            CodeInterpreterToolCall = codeInterpreterToolCall;
            LocalShellToolCall = localShellToolCall;
            LocalShellToolCallOutput = localShellToolCallOutput;
            MCPListTools = mCPListTools;
            MCPApprovalRequest = mCPApprovalRequest;
            MCPApprovalResponse = mCPApprovalResponse;
            MCPToolCall = mCPToolCall;
            CustomToolCallOutput = customToolCallOutput;
            CustomToolCall = customToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCall as object ??
            CustomToolCallOutput as object ??
            MCPToolCall as object ??
            MCPApprovalResponse as object ??
            MCPApprovalRequest as object ??
            MCPListTools as object ??
            LocalShellToolCallOutput as object ??
            LocalShellToolCall as object ??
            CodeInterpreterToolCall as object ??
            ImageGenToolCall as object ??
            Reasoning as object ??
            FunctionCallOutputParam as object ??
            FunctionToolCall as object ??
            WebSearchToolCall as object ??
            ComputerCallOutputParam as object ??
            ComputerToolCall as object ??
            FileSearchToolCall as object ??
            OutputMessage as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            OutputMessage?.ToString() ??
            FileSearchToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            ComputerCallOutputParam?.ToString() ??
            WebSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionCallOutputParam?.ToString() ??
            Reasoning?.ToString() ??
            ImageGenToolCall?.ToString() ??
            CodeInterpreterToolCall?.ToString() ??
            LocalShellToolCall?.ToString() ??
            LocalShellToolCallOutput?.ToString() ??
            MCPListTools?.ToString() ??
            MCPApprovalRequest?.ToString() ??
            MCPApprovalResponse?.ToString() ??
            MCPToolCall?.ToString() ??
            CustomToolCallOutput?.ToString() ??
            CustomToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage || IsOutputMessage || IsFileSearchToolCall || IsComputerToolCall || IsComputerCallOutputParam || IsWebSearchToolCall || IsFunctionToolCall || IsFunctionCallOutputParam || IsReasoning || IsImageGenToolCall || IsCodeInterpreterToolCall || IsLocalShellToolCall || IsLocalShellToolCallOutput || IsMCPListTools || IsMCPApprovalRequest || IsMCPApprovalResponse || IsMCPToolCall || IsCustomToolCallOutput || IsCustomToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputMessage?, TResult>? inputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerCallOutputItemParam?, TResult>? computerCallOutputParam = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionCallOutputItemParam?, TResult>? functionCallOutputParam = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCallOutput?, TResult>? localShellToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mCPListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mCPApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalResponse?, TResult>? mCPApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mCPToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutput?, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCall?, TResult>? customToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsOutputMessage && outputMessage != null)
            {
                return outputMessage(OutputMessage!);
            }
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
            }
            else if (IsComputerCallOutputParam && computerCallOutputParam != null)
            {
                return computerCallOutputParam(ComputerCallOutputParam!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionCallOutputParam && functionCallOutputParam != null)
            {
                return functionCallOutputParam(FunctionCallOutputParam!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsImageGenToolCall && imageGenToolCall != null)
            {
                return imageGenToolCall(ImageGenToolCall!);
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
            else if (IsMCPApprovalResponse && mCPApprovalResponse != null)
            {
                return mCPApprovalResponse(MCPApprovalResponse!);
            }
            else if (IsMCPToolCall && mCPToolCall != null)
            {
                return mCPToolCall(MCPToolCall!);
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
            global::System.Action<global::tryAGI.OpenAI.InputMessage?>? inputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.OutputMessage?>? outputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerCallOutputItemParam?>? computerCallOutputParam = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionCallOutputItemParam?>? functionCallOutputParam = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCallOutput?>? localShellToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mCPListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mCPApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalResponse?>? mCPApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mCPToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutput?>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCall?>? customToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsOutputMessage)
            {
                outputMessage?.Invoke(OutputMessage!);
            }
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
            }
            else if (IsComputerCallOutputParam)
            {
                computerCallOutputParam?.Invoke(ComputerCallOutputParam!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionCallOutputParam)
            {
                functionCallOutputParam?.Invoke(FunctionCallOutputParam!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsImageGenToolCall)
            {
                imageGenToolCall?.Invoke(ImageGenToolCall!);
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
            else if (IsMCPApprovalResponse)
            {
                mCPApprovalResponse?.Invoke(MCPApprovalResponse!);
            }
            else if (IsMCPToolCall)
            {
                mCPToolCall?.Invoke(MCPToolCall!);
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
                InputMessage,
                typeof(global::tryAGI.OpenAI.InputMessage),
                OutputMessage,
                typeof(global::tryAGI.OpenAI.OutputMessage),
                FileSearchToolCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                ComputerToolCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerCallOutputParam,
                typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam),
                WebSearchToolCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::tryAGI.OpenAI.FunctionToolCall),
                FunctionCallOutputParam,
                typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItem),
                ImageGenToolCall,
                typeof(global::tryAGI.OpenAI.ImageGenToolCall),
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
                MCPApprovalResponse,
                typeof(global::tryAGI.OpenAI.MCPApprovalResponse),
                MCPToolCall,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputMessage?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerCallOutputItemParam?>.Default.Equals(ComputerCallOutputParam, other.ComputerCallOutputParam) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionCallOutputItemParam?>.Default.Equals(FunctionCallOutputParam, other.FunctionCallOutputParam) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenToolCall, other.ImageGenToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterToolCall, other.CodeInterpreterToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellToolCall, other.LocalShellToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCallOutput?>.Default.Equals(LocalShellToolCallOutput, other.LocalShellToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(MCPListTools, other.MCPListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(MCPApprovalRequest, other.MCPApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalResponse?>.Default.Equals(MCPApprovalResponse, other.MCPApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(MCPToolCall, other.MCPToolCall) &&
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
