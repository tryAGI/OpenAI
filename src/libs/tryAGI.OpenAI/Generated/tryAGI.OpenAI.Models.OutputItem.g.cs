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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.OutputMessage value) => new OutputItem(value);

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
        /// [file search guide](/docs/guides/tools-file-search) for more information.
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FileSearchToolCall value) => new OutputItem(value);

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
        /// [function calling guide](/docs/guides/function-calling) for more information.
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.FunctionToolCall value) => new OutputItem(value);

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
        /// [web search guide](/docs/guides/tools-web-search) for more information.
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.WebSearchToolCall value) => new OutputItem(value);

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
        /// [computer use guide](/docs/guides/tools-computer-use) for more information.
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ComputerToolCall value) => new OutputItem(value);

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
        /// a response.
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
        public static implicit operator OutputItem(global::tryAGI.OpenAI.ReasoningItem value) => new OutputItem(value);

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
        public OutputItem(
            global::tryAGI.OpenAI.OutputMessage? message,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall,
            global::tryAGI.OpenAI.FunctionToolCall? functionToolCall,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall,
            global::tryAGI.OpenAI.ReasoningItem? reasoning
            )
        {
            Message = message;
            FileSearchToolCall = fileSearchToolCall;
            FunctionToolCall = functionToolCall;
            WebSearchToolCall = webSearchToolCall;
            ComputerToolCall = computerToolCall;
            Reasoning = reasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
        public bool Validate()
        {
            return IsMessage || IsFileSearchToolCall || IsFunctionToolCall || IsWebSearchToolCall || IsComputerToolCall || IsReasoning;
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) 
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
