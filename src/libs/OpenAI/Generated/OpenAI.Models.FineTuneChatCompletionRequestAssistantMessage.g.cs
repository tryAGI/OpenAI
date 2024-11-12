#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
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
        public global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1? Value1 { get; init; }
#else
        public global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FineTuneChatCompletionRequestAssistantMessage(global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1 value) => new FineTuneChatCompletionRequestAssistantMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1?(FineTuneChatCompletionRequestAssistantMessage @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessage(global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionRequestAssistantMessage? Value2 { get; init; }
#else
        public global::OpenAI.ChatCompletionRequestAssistantMessage? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FineTuneChatCompletionRequestAssistantMessage(global::OpenAI.ChatCompletionRequestAssistantMessage value) => new FineTuneChatCompletionRequestAssistantMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionRequestAssistantMessage?(FineTuneChatCompletionRequestAssistantMessage @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessage(global::OpenAI.ChatCompletionRequestAssistantMessage? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessage(
            global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1? value1,
            global::OpenAI.ChatCompletionRequestAssistantMessage? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1?, TResult>? value1 = null,
            global::System.Func<global::OpenAI.ChatCompletionRequestAssistantMessage?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1?>? value1 = null,
            global::System.Action<global::OpenAI.ChatCompletionRequestAssistantMessage?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1),
                Value2,
                typeof(global::OpenAI.ChatCompletionRequestAssistantMessage),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.FineTuneChatCompletionRequestAssistantMessageVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionRequestAssistantMessage?>.Default.Equals(Value2, other.Value2) 
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
