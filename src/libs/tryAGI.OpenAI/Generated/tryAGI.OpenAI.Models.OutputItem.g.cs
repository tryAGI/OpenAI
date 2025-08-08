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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FileSearchToolCall value) => new OutputItem((global::tryAGI.OpenAI.FileSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchToolCall?(OutputItem @this) => @this.FileSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FileSearchToolCall? value)
        {
            FileSearchToolCall = value;
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FunctionToolCall value) => new OutputItem((global::tryAGI.OpenAI.FunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCall?(OutputItem @this) => @this.FunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.FunctionToolCall? value)
        {
            FunctionToolCall = value;
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.WebSearchToolCall value) => new OutputItem((global::tryAGI.OpenAI.WebSearchToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchToolCall?(OutputItem @this) => @this.WebSearchToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.WebSearchToolCall? value)
        {
            WebSearchToolCall = value;
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ComputerToolCall value) => new OutputItem((global::tryAGI.OpenAI.ComputerToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCall?(OutputItem @this) => @this.ComputerToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ComputerToolCall? value)
        {
            ComputerToolCall = value;
        }

        /// <summary>
        /// A description of the chain of thought used by a reasoning model while generating<br/>
        /// a response. Be sure to include these items in your `input` to the Responses API<br/>
        /// for subsequent turns of a conversation if you are manually <br/>
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ImageGenToolCall value) => new OutputItem((global::tryAGI.OpenAI.ImageGenToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenToolCall?(OutputItem @this) => @this.ImageGenToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.ImageGenToolCall? value)
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.CodeInterpreterToolCall value) => new OutputItem((global::tryAGI.OpenAI.CodeInterpreterToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterToolCall?(OutputItem @this) => @this.CodeInterpreterToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.CodeInterpreterToolCall? value)
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.LocalShellToolCall value) => new OutputItem((global::tryAGI.OpenAI.LocalShellToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolCall?(OutputItem @this) => @this.LocalShellToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.LocalShellToolCall? value)
        {
            LocalShellToolCall = value;
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPToolCall value) => new OutputItem((global::tryAGI.OpenAI.MCPToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPToolCall?(OutputItem @this) => @this.MCPToolCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPToolCall? value)
        {
            MCPToolCall = value;
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPListTools value) => new OutputItem((global::tryAGI.OpenAI.MCPListTools?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPListTools?(OutputItem @this) => @this.MCPListTools;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPListTools? value)
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.MCPApprovalRequest value) => new OutputItem((global::tryAGI.OpenAI.MCPApprovalRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPApprovalRequest?(OutputItem @this) => @this.MCPApprovalRequest;

        /// <summary>
        /// 
        /// </summary>
        public OutputItem(global::tryAGI.OpenAI.MCPApprovalRequest? value)
        {
            MCPApprovalRequest = value;
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
        public OutputItem(
            global::tryAGI.OpenAI.OutputMessage? message,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall,
            global::tryAGI.OpenAI.FunctionToolCall? functionToolCall,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall,
            global::tryAGI.OpenAI.ReasoningItem? reasoning,
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenToolCall,
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterToolCall,
            global::tryAGI.OpenAI.LocalShellToolCall? localShellToolCall,
            global::tryAGI.OpenAI.MCPToolCall? mCPToolCall,
            global::tryAGI.OpenAI.MCPListTools? mCPListTools,
            global::tryAGI.OpenAI.MCPApprovalRequest? mCPApprovalRequest,
            global::tryAGI.OpenAI.CustomToolCall? customToolCall
            )
        {
            Message = message;
            FileSearchToolCall = fileSearchToolCall;
            FunctionToolCall = functionToolCall;
            WebSearchToolCall = webSearchToolCall;
            ComputerToolCall = computerToolCall;
            Reasoning = reasoning;
            ImageGenToolCall = imageGenToolCall;
            CodeInterpreterToolCall = codeInterpreterToolCall;
            LocalShellToolCall = localShellToolCall;
            MCPToolCall = mCPToolCall;
            MCPListTools = mCPListTools;
            MCPApprovalRequest = mCPApprovalRequest;
            CustomToolCall = customToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCall as object ??
            MCPApprovalRequest as object ??
            MCPListTools as object ??
            MCPToolCall as object ??
            LocalShellToolCall as object ??
            CodeInterpreterToolCall as object ??
            ImageGenToolCall as object ??
            Reasoning as object ??
            ComputerToolCall as object ??
            WebSearchToolCall as object ??
            FunctionToolCall as object ??
            FileSearchToolCall as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FileSearchToolCall?.ToString() ??
            FunctionToolCall?.ToString() ??
            WebSearchToolCall?.ToString() ??
            ComputerToolCall?.ToString() ??
            Reasoning?.ToString() ??
            ImageGenToolCall?.ToString() ??
            CodeInterpreterToolCall?.ToString() ??
            LocalShellToolCall?.ToString() ??
            MCPToolCall?.ToString() ??
            MCPListTools?.ToString() ??
            MCPApprovalRequest?.ToString() ??
            CustomToolCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFileSearchToolCall || IsFunctionToolCall || IsWebSearchToolCall || IsComputerToolCall || IsReasoning || IsImageGenToolCall || IsCodeInterpreterToolCall || IsLocalShellToolCall || IsMCPToolCall || IsMCPListTools || IsMCPApprovalRequest || IsCustomToolCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.OutputMessage?, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenToolCall?, TResult>? imageGenToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterToolCall?, TResult>? codeInterpreterToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolCall?, TResult>? localShellToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.MCPToolCall?, TResult>? mCPToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.MCPListTools?, TResult>? mCPListTools = null,
            global::System.Func<global::tryAGI.OpenAI.MCPApprovalRequest?, TResult>? mCPApprovalRequest = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCall?, TResult>? customToolCall = null,
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
            else if (IsFileSearchToolCall && fileSearchToolCall != null)
            {
                return fileSearchToolCall(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall && functionToolCall != null)
            {
                return functionToolCall(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall && webSearchToolCall != null)
            {
                return webSearchToolCall(WebSearchToolCall!);
            }
            else if (IsComputerToolCall && computerToolCall != null)
            {
                return computerToolCall(ComputerToolCall!);
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
            else if (IsMCPToolCall && mCPToolCall != null)
            {
                return mCPToolCall(MCPToolCall!);
            }
            else if (IsMCPListTools && mCPListTools != null)
            {
                return mCPListTools(MCPListTools!);
            }
            else if (IsMCPApprovalRequest && mCPApprovalRequest != null)
            {
                return mCPApprovalRequest(MCPApprovalRequest!);
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
            global::System.Action<global::tryAGI.OpenAI.OutputMessage?>? message = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenToolCall?>? imageGenToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterToolCall?>? codeInterpreterToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolCall?>? localShellToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.MCPToolCall?>? mCPToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.MCPListTools?>? mCPListTools = null,
            global::System.Action<global::tryAGI.OpenAI.MCPApprovalRequest?>? mCPApprovalRequest = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCall?>? customToolCall = null,
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
            else if (IsFileSearchToolCall)
            {
                fileSearchToolCall?.Invoke(FileSearchToolCall!);
            }
            else if (IsFunctionToolCall)
            {
                functionToolCall?.Invoke(FunctionToolCall!);
            }
            else if (IsWebSearchToolCall)
            {
                webSearchToolCall?.Invoke(WebSearchToolCall!);
            }
            else if (IsComputerToolCall)
            {
                computerToolCall?.Invoke(ComputerToolCall!);
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
            else if (IsMCPToolCall)
            {
                mCPToolCall?.Invoke(MCPToolCall!);
            }
            else if (IsMCPListTools)
            {
                mCPListTools?.Invoke(MCPListTools!);
            }
            else if (IsMCPApprovalRequest)
            {
                mCPApprovalRequest?.Invoke(MCPApprovalRequest!);
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
                Message,
                typeof(global::tryAGI.OpenAI.OutputMessage),
                FileSearchToolCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                FunctionToolCall,
                typeof(global::tryAGI.OpenAI.FunctionToolCall),
                WebSearchToolCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                ComputerToolCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                Reasoning,
                typeof(global::tryAGI.OpenAI.ReasoningItem),
                ImageGenToolCall,
                typeof(global::tryAGI.OpenAI.ImageGenToolCall),
                CodeInterpreterToolCall,
                typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall),
                LocalShellToolCall,
                typeof(global::tryAGI.OpenAI.LocalShellToolCall),
                MCPToolCall,
                typeof(global::tryAGI.OpenAI.MCPToolCall),
                MCPListTools,
                typeof(global::tryAGI.OpenAI.MCPListTools),
                MCPApprovalRequest,
                typeof(global::tryAGI.OpenAI.MCPApprovalRequest),
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
        public bool Equals(OutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenToolCall?>.Default.Equals(ImageGenToolCall, other.ImageGenToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterToolCall?>.Default.Equals(CodeInterpreterToolCall, other.CodeInterpreterToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolCall?>.Default.Equals(LocalShellToolCall, other.LocalShellToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPToolCall?>.Default.Equals(MCPToolCall, other.MCPToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPListTools?>.Default.Equals(MCPListTools, other.MCPListTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPApprovalRequest?>.Default.Equals(MCPApprovalRequest, other.MCPApprovalRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) 
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
