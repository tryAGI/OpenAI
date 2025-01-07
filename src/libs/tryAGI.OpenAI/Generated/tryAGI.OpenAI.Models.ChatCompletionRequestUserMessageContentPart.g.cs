#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestUserMessageContentPart : global::System.IEquatable<ChatCompletionRequestUserMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminatorType? Type { get; }

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
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestUserMessageContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        /// Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? ImageUrl { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestUserMessageContentPart @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// Learn about [audio inputs](/docs/guides/audio).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? InputAudio { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?(ChatCompletionRequestUserMessageContentPart @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(
            global::tryAGI.OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminatorType? type,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? text,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? imageUrl,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? inputAudio
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            InputAudio = inputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputAudio as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsInputAudio || !IsText && IsImageUrl && !IsInputAudio || !IsText && !IsImageUrl && IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?, TResult>? imageUrl = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?, TResult>? inputAudio = null,
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
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?>? imageUrl = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?>? inputAudio = null,
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
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
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
                ImageUrl,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage),
                InputAudio,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio),
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
        public bool Equals(ChatCompletionRequestUserMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?>.Default.Equals(InputAudio, other.InputAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestUserMessageContentPart obj1, ChatCompletionRequestUserMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestUserMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestUserMessageContentPart obj1, ChatCompletionRequestUserMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestUserMessageContentPart o && Equals(o);
        }
    }
}
