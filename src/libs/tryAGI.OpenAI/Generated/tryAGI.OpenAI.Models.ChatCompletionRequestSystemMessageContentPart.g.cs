#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestSystemMessageContentPart : global::System.IEquatable<ChatCompletionRequestSystemMessageContentPart>
    {
        /// <summary>
        /// Learn about [text inputs](/docs/guides/text-generation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? TextContentPart { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? TextContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContentPart))]
#endif
        public bool IsTextContentPart => TextContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestSystemMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestSystemMessageContentPart((global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestSystemMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestSystemMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart && textContentPart != null)
            {
                return textContentPart(TextContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextContentPart)
            {
                textContentPart?.Invoke(TextContentPart!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextContentPart,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText),
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
        public bool Equals(ChatCompletionRequestSystemMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestSystemMessageContentPart obj1, ChatCompletionRequestSystemMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestSystemMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestSystemMessageContentPart obj1, ChatCompletionRequestSystemMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestSystemMessageContentPart o && Equals(o);
        }
    }
}
