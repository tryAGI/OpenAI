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
        public static implicit operator Item(global::tryAGI.OpenAI.InputMessage value) => new Item(value);

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
        public static implicit operator Item(global::tryAGI.OpenAI.OutputMessage value) => new Item(value);

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
        public static implicit operator Item(global::tryAGI.OpenAI.FileSearchToolCall value) => new Item(value);

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
        public static implicit operator Item(global::tryAGI.OpenAI.ComputerToolCall value) => new Item(value);

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
        public global::tryAGI.OpenAI.ComputerToolCallOutput? ComputerToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCallOutput? ComputerToolCallOutput { get; }
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
        public static implicit operator Item(global::tryAGI.OpenAI.ComputerToolCallOutput value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCallOutput?(Item @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.ComputerToolCallOutput? value)
        {
            ComputerToolCallOutput = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.WebSearchToolCall value) => new Item(value);

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
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionToolCall value) => new Item(value);

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
        public global::tryAGI.OpenAI.FunctionToolCallOutput? FunctionToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallOutput? FunctionToolCallOutput { get; }
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
        public static implicit operator Item(global::tryAGI.OpenAI.FunctionToolCallOutput value) => new Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallOutput?(Item @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public Item(global::tryAGI.OpenAI.FunctionToolCallOutput? value)
        {
            FunctionToolCallOutput = value;
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
        public static implicit operator Item(global::tryAGI.OpenAI.ReasoningItem value) => new Item(value);

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
        public Item(
            global::tryAGI.OpenAI.InputMessage? inputMessage,
            global::tryAGI.OpenAI.OutputMessage? outputMessage,
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall,
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall,
            global::tryAGI.OpenAI.ComputerToolCallOutput? computerToolCallOutput,
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall,
            global::tryAGI.OpenAI.FunctionToolCall? functionToolCall,
            global::tryAGI.OpenAI.FunctionToolCallOutput? functionToolCallOutput,
            global::tryAGI.OpenAI.ReasoningItem? reasoning
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
            Reasoning = reasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Reasoning as object ??
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
        public bool Validate()
        {
            return IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && IsFunctionToolCall && !IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && IsFunctionToolCallOutput && !IsReasoning || !IsInputMessage && !IsOutputMessage && !IsFileSearchToolCall && !IsComputerToolCall && !IsComputerToolCallOutput && !IsWebSearchToolCall && !IsFunctionToolCall && !IsFunctionToolCallOutput && IsReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputMessage?, TResult>? inputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.OutputMessage?, TResult>? outputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchToolCall?, TResult>? fileSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCall?, TResult>? computerToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutput?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchToolCall?, TResult>? webSearchToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCall?, TResult>? functionToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutput?, TResult>? functionToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningItem?, TResult>? reasoning = null,
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
            global::System.Action<global::tryAGI.OpenAI.InputMessage?>? inputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.OutputMessage?>? outputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchToolCall?>? fileSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCall?>? computerToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutput?>? computerToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchToolCall?>? webSearchToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCall?>? functionToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallOutput?>? functionToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningItem?>? reasoning = null,
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
                InputMessage,
                typeof(global::tryAGI.OpenAI.InputMessage),
                OutputMessage,
                typeof(global::tryAGI.OpenAI.OutputMessage),
                FileSearchToolCall,
                typeof(global::tryAGI.OpenAI.FileSearchToolCall),
                ComputerToolCall,
                typeof(global::tryAGI.OpenAI.ComputerToolCall),
                ComputerToolCallOutput,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutput),
                WebSearchToolCall,
                typeof(global::tryAGI.OpenAI.WebSearchToolCall),
                FunctionToolCall,
                typeof(global::tryAGI.OpenAI.FunctionToolCall),
                FunctionToolCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionToolCallOutput),
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
        public bool Equals(Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputMessage?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchToolCall?>.Default.Equals(FileSearchToolCall, other.FileSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCall?>.Default.Equals(ComputerToolCall, other.ComputerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutput?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchToolCall?>.Default.Equals(WebSearchToolCall, other.WebSearchToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCall?>.Default.Equals(FunctionToolCall, other.FunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallOutput?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) 
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
