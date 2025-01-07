#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestAssistantMessageContentPart : global::System.IEquatable<ChatCompletionRequestAssistantMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? Type { get; }

        /// <summary>
        /// Learn about [text inputs](/docs/guides/text-generation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestAssistantMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal value) => new ChatCompletionRequestAssistantMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(
            global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? type,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? text,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal? refusal
            )
        {
            Type = type;

            Text = text;
            Refusal = refusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refusal as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsRefusal || !IsText && IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal?, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal?>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText),
                Refusal,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal),
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
        public bool Equals(ChatCompletionRequestAssistantMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartRefusal?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestAssistantMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestAssistantMessageContentPart o && Equals(o);
        }
    }
}
