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
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? Image { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?(ChatCompletionRequestUserMessageContentPart @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// Learn about [audio inputs](/docs/guides/audio).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? Audio { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?(ChatCompletionRequestUserMessageContentPart @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// Learn about [file inputs](/docs/guides/text) for text generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? File { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile value) => new ChatCompletionRequestUserMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?(ChatCompletionRequestUserMessageContentPart @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestUserMessageContentPart(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText? text,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage? image,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio? audio,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile? file
            )
        {
            Text = text;
            Image = image;
            Audio = audio;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Audio as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsAudio && !IsFile || !IsText && IsImage && !IsAudio && !IsFile || !IsText && !IsImage && IsAudio && !IsFile || !IsText && !IsImage && !IsAudio && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?, TResult>? image = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?, TResult>? audio = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?, TResult>? file = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?>? image = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?>? audio = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?>? file = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
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
                Image,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage),
                Audio,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio),
                File,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImage?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartAudio?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartFile?>.Default.Equals(File, other.File) 
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
