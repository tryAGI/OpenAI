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
        /// Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? ImageContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageContentPart))]
#endif
        public bool IsImageContentPart => ImageContentPart != null;

        /// <summary>
        /// Learn about [audio inputs](/docs/guides/audio).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? AudioContentPart { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? AudioContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioContentPart))]
#endif
        public bool IsAudioContentPart => AudioContentPart != null;

        /// <summary>
        /// Learn about [file inputs](/docs/guides/text) for text generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? FileContentPart { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? FileContentPart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileContentPart))]
#endif
        public bool IsFileContentPart => FileContentPart != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestUserMessageContentPart((global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestUserMessageContentPart @this) => @this.TextContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? value)
        {
            TextContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestUserMessageContentPart((global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestUserMessageContentPart @this) => @this.ImageContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? value)
        {
            ImageContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio value) => new ChatCompletionRequestUserMessageContentPart((global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?(ChatCompletionRequestUserMessageContentPart @this) => @this.AudioContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? value)
        {
            AudioContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile value) => new ChatCompletionRequestUserMessageContentPart((global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?(ChatCompletionRequestUserMessageContentPart @this) => @this.FileContentPart;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? value)
        {
            FileContentPart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? textContentPart,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? imageContentPart,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? audioContentPart,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? fileContentPart
            )
        {
            TextContentPart = textContentPart;
            ImageContentPart = imageContentPart;
            AudioContentPart = audioContentPart;
            FileContentPart = fileContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileContentPart as object ??
            AudioContentPart as object ??
            ImageContentPart as object ??
            TextContentPart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextContentPart?.ToString() ??
            ImageContentPart?.ToString() ??
            AudioContentPart?.ToString() ??
            FileContentPart?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextContentPart && !IsImageContentPart && !IsAudioContentPart && !IsFileContentPart || !IsTextContentPart && IsImageContentPart && !IsAudioContentPart && !IsFileContentPart || !IsTextContentPart && !IsImageContentPart && IsAudioContentPart && !IsFileContentPart || !IsTextContentPart && !IsImageContentPart && !IsAudioContentPart && IsFileContentPart;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?, TResult>? textContentPart = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?, TResult>? imageContentPart = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?, TResult>? audioContentPart = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?, TResult>? fileContentPart = null,
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
            else if (IsImageContentPart && imageContentPart != null)
            {
                return imageContentPart(ImageContentPart!);
            }
            else if (IsAudioContentPart && audioContentPart != null)
            {
                return audioContentPart(AudioContentPart!);
            }
            else if (IsFileContentPart && fileContentPart != null)
            {
                return fileContentPart(FileContentPart!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>? textContentPart = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?>? imageContentPart = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?>? audioContentPart = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?>? fileContentPart = null,
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
            else if (IsImageContentPart)
            {
                imageContentPart?.Invoke(ImageContentPart!);
            }
            else if (IsAudioContentPart)
            {
                audioContentPart?.Invoke(AudioContentPart!);
            }
            else if (IsFileContentPart)
            {
                fileContentPart?.Invoke(FileContentPart!);
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
                ImageContentPart,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage),
                AudioContentPart,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio),
                FileContentPart,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(TextContentPart, other.TextContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(ImageContentPart, other.ImageContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?>.Default.Equals(AudioContentPart, other.AudioContentPart) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?>.Default.Equals(FileContentPart, other.FileContentPart) 
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
