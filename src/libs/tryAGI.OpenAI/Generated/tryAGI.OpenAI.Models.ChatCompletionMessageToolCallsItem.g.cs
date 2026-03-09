#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionMessageToolCallsItem : global::System.IEquatable<ChatCompletionMessageToolCallsItem>
    {
        /// <summary>
        /// A call to a function tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Function { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageToolCall value) => new ChatCompletionMessageToolCallsItem((global::tryAGI.OpenAI.ChatCompletionMessageToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionMessageToolCall?(ChatCompletionMessageToolCallsItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageToolCall? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall value) => new ChatCompletionMessageToolCallsItem((global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?(ChatCompletionMessageToolCallsItem @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCallsItem(
            global::tryAGI.OpenAI.ChatCompletionMessageToolCall? function,
            global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? custom
            )
        {
            Function = function;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsCustom || !IsFunction && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionMessageToolCall?, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionMessageToolCall?>? function = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCall),
                Custom,
                typeof(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall),
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
        public bool Equals(ChatCompletionMessageToolCallsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionMessageToolCall?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionMessageToolCallsItem obj1, ChatCompletionMessageToolCallsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionMessageToolCallsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionMessageToolCallsItem obj1, ChatCompletionMessageToolCallsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionMessageToolCallsItem o && Equals(o);
        }
    }
}
