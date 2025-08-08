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
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Call { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionMessageToolCall? Call { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Call))]
#endif
        public bool IsCall => Call != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageToolCall value) => new ChatCompletionMessageToolCallsItem((global::tryAGI.OpenAI.ChatCompletionMessageToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionMessageToolCall?(ChatCompletionMessageToolCallsItem @this) => @this.Call;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageToolCall? value)
        {
            Call = value;
        }

        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? CustomCall { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? CustomCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomCall))]
#endif
        public bool IsCustomCall => CustomCall != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall value) => new ChatCompletionMessageToolCallsItem((global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?(ChatCompletionMessageToolCallsItem @this) => @this.CustomCall;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCallsItem(global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? value)
        {
            CustomCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCallsItem(
            global::tryAGI.OpenAI.ChatCompletionMessageToolCall? call,
            global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall? customCall
            )
        {
            Call = call;
            CustomCall = customCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomCall as object ??
            Call as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Call?.ToString() ??
            CustomCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCall || IsCustomCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionMessageToolCall?, TResult>? call = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?, TResult>? customCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCall && call != null)
            {
                return call(Call!);
            }
            else if (IsCustomCall && customCall != null)
            {
                return customCall(CustomCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionMessageToolCall?>? call = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?>? customCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCall)
            {
                call?.Invoke(Call!);
            }
            else if (IsCustomCall)
            {
                customCall?.Invoke(CustomCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Call,
                typeof(global::tryAGI.OpenAI.ChatCompletionMessageToolCall),
                CustomCall,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionMessageToolCall?>.Default.Equals(Call, other.Call) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionMessageCustomToolCall?>.Default.Equals(CustomCall, other.CustomCall) 
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
