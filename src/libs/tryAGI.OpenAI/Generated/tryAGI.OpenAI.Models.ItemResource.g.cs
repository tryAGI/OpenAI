#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Content item used to generate a response.
    /// </summary>
    public readonly partial struct ItemResource : global::System.IEquatable<ItemResource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputMessageResource? InputMessage { get; init; }
#else
        public global::tryAGI.OpenAI.InputMessageResource? InputMessage { get; }
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.InputMessageResource value) => new ItemResource((global::tryAGI.OpenAI.InputMessageResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputMessageResource?(ItemResource @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.InputMessageResource? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.OutputMessage value) => new ItemResource((global::tryAGI.OpenAI.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputMessage?(ItemResource @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.OutputMessage? value)
        {
            OutputMessage = value;
        }

        /// <summary>
        /// The results of a file search tool call. See the <br/>
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.FileSearchToolCall value) => new ItemResource((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(ItemResource @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.FileSearchToolCall? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.ComputerToolCall value) => new ItemResource((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(ItemResource @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? ComputerToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCallOutputResource? ComputerToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutput))]
#endif
        public bool IsComputerToolCallOutput => ComputerToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::tryAGI.OpenAI.ComputerToolCallOutputResource value) => new ItemResource((global::tryAGI.OpenAI.ComputerToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCallOutputResource?(ItemResource @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.ComputerToolCallOutputResource? value)
        {
            ComputerToolCallOutput = value;
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.WebSearchToolCall value) => new ItemResource((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(ItemResource @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallResource? FunctionToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallResource? FunctionToolCall { get; }
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.FunctionToolCallResource value) => new ItemResource((global::tryAGI.OpenAI.FunctionToolCallResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallResource?(ItemResource @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.FunctionToolCallResource? value)
        {
            FunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? FunctionToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallOutputResource? FunctionToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutput))]
#endif
        public bool IsFunctionToolCallOutput => FunctionToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ItemResource(global::tryAGI.OpenAI.FunctionToolCallOutputResource value) => new ItemResource((global::tryAGI.OpenAI.FunctionToolCallOutputResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallOutputResource?(ItemResource @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.FunctionToolCallOutputResource? value)
        {
            FunctionToolCallOutput = value;
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.ImageGenToolCall value) => new ItemResource((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(ItemResource @this) => @this.ImageGenToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.ImageGenToolCall? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new ItemResource((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(ItemResource @this) => @this.CodeInterpreterToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.LocalShellToolCall value) => new ItemResource((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(ItemResource @this) => @this.LocalShellToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.LocalShellToolCall? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.LocalShellToolCallOutput value) => new ItemResource((global::tryAGI.OpenAI.LocalShellToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCallOutput?(ItemResource @this) => @this.LocalShellToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.LocalShellToolCallOutput? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.MCPListTools value) => new ItemResource((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(ItemResource @this) => @this.MCPListTools;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.MCPListTools? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.MCPApprovalRequest value) => new ItemResource((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(ItemResource @this) => @this.MCPApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            MCPApprovalRequest = value;
        }

        /// <summary>
        /// A response to an MCP approval request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? MCPApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.MCPApprovalResponseResource? MCPApprovalResponse { get; }
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.MCPApprovalResponseResource value) => new ItemResource((global::tryAGI.OpenAI.MCPApprovalResponseResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalResponseResource?(ItemResource @this) => @this.MCPApprovalResponse;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.MCPApprovalResponseResource? value)
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
        public static implicit operator ItemResource(global::tryAGI.OpenAI.MCPToolCall value) => new ItemResource((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(ItemResource @this) => @this.MCPToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            MCPToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemResource(
            global::tryAGI.OpenAI.InputMessageResource? inputMessage,
            global::tryAGI.OpenAI.OutputMessage? outputMessage,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall,
            global::tryAGI.OpenAI.ComputerToolCallOutputResource? computerToolCallOutput,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall,
            global::tryAGI.OpenAI.FunctionToolCallResource? functionToolCall,
            global::tryAGI.OpenAI.FunctionToolCallOutputResource? functionToolCallOutput,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenToolCall,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterToolCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellToolCall,
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellToolCallOutput,
            global::tryAGI.OpenAI.MCPListTools? mCPListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mCPApprovalRequest,
            global::tryAGI.OpenAI.MCPApprovalResponseResource? mCPApprovalResponse,
            global::tryAGI.OpenAI.MCPToolCall? mCPToolCall
            )
        {
            InputMessage = inputMessage;
            OutputMessage = outputMessage;
            FileSearchToolCall = fileSearchToolCall;
            ComputerToolCall = computerToolCall;
            ComputerToolCallOutput = computerToolCallOutput;
            WebSearchToolCall = webSearchToolCall;
            FunctionToolCall = functionToolCall;
            FunctionToolCallOutput = functionToolCallOutput;
            ImageGenToolCall = imageGenToolCall;
            CodeInterpreterToolCall = codeInterpreterToolCall;
            LocalShellToolCall = localShellToolCall;
            LocalShellToolCallOutput = localShellToolCallOutput;
            MCPListTools = mCPListTools;
            MCPApprovalRequest = mCPApprovalRequest;
            MCPApprovalResponse = mCPApprovalResponse;
            MCPToolCall = mCPToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPToolCall as object ??
            MCPApprovalResponse as object ??
            MCPApprovalRequest as object ??
            MCPListTools as object ??
            LocalShellToolCallOutput as object ??
            LocalShellToolCall as object ??
            CodeInterpreterToolCall as object ??
            ImageGenToolCall as object ??
            FunctionToolCallOutput as object ??
            FunctionToolCall as object ??
            WebSearchToolCall as object ??
            ComputerToolCallOutput as object ??
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
            ComputerToolCallOutput?.ToString() ??
            WebSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            FunctionToolCallOutput?.ToString() ??
            ImageGenToolCall?.ToString() ??
            CodeInterpreterToolCall?.ToString() ??
            LocalShellToolCall?.ToString() ??
            LocalShellToolCallOutput?.ToString() ??
            MCPListTools?.ToString() ??
            MCPApprovalRequest?.ToString() ??
            MCPApprovalResponse?.ToString() ??
            MCPToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage || IsOutputMessage || IsFileSearchToolCall || IsComputerToolCall || IsComputerToolCallOutput || IsWebSearchToolCall || IsFunctionToolCall || IsFunctionToolCallOutput || IsImageGenToolCall || IsCodeInterpreterToolCall || IsLocalShellToolCall || IsLocalShellToolCallOutput || IsMCPListTools || IsMCPApprovalRequest || IsMCPApprovalResponse || IsMCPToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputMessageResource?, TResult>? inputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutputResource?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallResource?, TResult>? functionToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutputResource?, TResult>? functionToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCallOutput?, TResult>? localShellToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mCPListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mCPApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalResponseResource?, TResult>? mCPApprovalResponse = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mCPToolCall = null,
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
            else if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput && functionToolCallOutput != null)
            {
                return functionToolCallOutput(FunctionToolCallOutput!);
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputMessageResource?>? inputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.OutputMessage?>? outputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>? computerToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallResource?>? functionToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallOutputResource?>? functionToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCallOutput?>? localShellToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mCPListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mCPApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalResponseResource?>? mCPApprovalResponse = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mCPToolCall = null,
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
            else if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsFunctionToolCallOutput)
            {
                functionToolCallOutput?.Invoke(FunctionToolCallOutput!);
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::tryAGI.OpenAI.InputMessageResource),
                OutputMessage,
                typeof(global::tryAGI.OpenAI.OutputMessage),
                FileSearchToolCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                ComputerToolCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerToolCallOutput,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource),
                WebSearchToolCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::tryAGI.OpenAI.FunctionToolCallResource),
                FunctionToolCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource),
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
                typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource),
                MCPToolCall,
                typeof(global::tryAGI.OpenAI.MCPToolCall),
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
        public bool Equals(ItemResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputMessageResource?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutputResource?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallResource?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallOutputResource?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenToolCall, other.ImageGenToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterToolCall, other.CodeInterpreterToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellToolCall, other.LocalShellToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCallOutput?>.Default.Equals(LocalShellToolCallOutput, other.LocalShellToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(MCPListTools, other.MCPListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(MCPApprovalRequest, other.MCPApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalResponseResource?>.Default.Equals(MCPApprovalResponse, other.MCPApprovalResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(MCPToolCall, other.MCPToolCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ItemResource obj1, ItemResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ItemResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ItemResource obj1, ItemResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ItemResource o && Equals(o);
        }
    }
}
