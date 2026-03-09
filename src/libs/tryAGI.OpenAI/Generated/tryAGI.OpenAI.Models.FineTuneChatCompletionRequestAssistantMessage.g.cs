#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FineTuneChatCompletionRequestAssistantMessage : global::System.IEquatable<FineTuneChatCompletionRequestAssistantMessage>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? AssistantMessage1 { get; init; }
#else
        public global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? AssistantMessage1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage1))]
#endif
        public bool IsAssistantMessage1 => AssistantMessage1 != null;

        /// <summary>
        /// Messages sent by the model in response to user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? AssistantMessage2 { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? AssistantMessage2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage2))]
#endif
        public bool IsAssistantMessage2 => AssistantMessage2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FineTuneChatCompletionRequestAssistantMessage(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage value) => new FineTuneChatCompletionRequestAssistantMessage((global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage?(FineTuneChatCompletionRequestAssistantMessage @this) => @this.AssistantMessage1;

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessage(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? value)
        {
            AssistantMessage1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FineTuneChatCompletionRequestAssistantMessage(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage value) => new FineTuneChatCompletionRequestAssistantMessage((global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?(FineTuneChatCompletionRequestAssistantMessage @this) => @this.AssistantMessage2;

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessage(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? value)
        {
            AssistantMessage2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessage(
            global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage? assistantMessage1,
            global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? assistantMessage2
            )
        {
            AssistantMessage1 = assistantMessage1;
            AssistantMessage2 = assistantMessage2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantMessage2 as object ??
            AssistantMessage1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AssistantMessage1?.ToString() ??
            AssistantMessage2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistantMessage1 && IsAssistantMessage2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage?, TResult>? assistantMessage1 = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?, TResult>? assistantMessage2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantMessage1 && assistantMessage1 != null)
            {
                return assistantMessage1(AssistantMessage1!);
            }
            else if (IsAssistantMessage2 && assistantMessage2 != null)
            {
                return assistantMessage2(AssistantMessage2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage?>? assistantMessage1 = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?>? assistantMessage2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantMessage1)
            {
                assistantMessage1?.Invoke(AssistantMessage1!);
            }
            else if (IsAssistantMessage2)
            {
                assistantMessage2?.Invoke(AssistantMessage2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssistantMessage1,
                typeof(global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage),
                AssistantMessage2,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage),
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
        public bool Equals(FineTuneChatCompletionRequestAssistantMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FineTuneChatCompletionRequestAssistantMessageAssistantMessage?>.Default.Equals(AssistantMessage1, other.AssistantMessage1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?>.Default.Equals(AssistantMessage2, other.AssistantMessage2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FineTuneChatCompletionRequestAssistantMessage obj1, FineTuneChatCompletionRequestAssistantMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FineTuneChatCompletionRequestAssistantMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FineTuneChatCompletionRequestAssistantMessage obj1, FineTuneChatCompletionRequestAssistantMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FineTuneChatCompletionRequestAssistantMessage o && Equals(o);
        }
    }
}
