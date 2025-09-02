#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputContent : global::System.IEquatable<InputContent>
    {
        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputTextContent? Text { get; init; }
#else
        public global::tryAGI.OpenAI.InputTextContent? Text { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputTextContent value) => new InputContent((global::tryAGI.OpenAI.InputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContent?(InputContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// An image input to the model. Learn about [image inputs](https://platform.openai.com/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputImageContent? Image { get; init; }
#else
        public global::tryAGI.OpenAI.InputImageContent? Image { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputImageContent value) => new InputContent((global::tryAGI.OpenAI.InputImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImageContent?(InputContent @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputFileContent? File { get; init; }
#else
        public global::tryAGI.OpenAI.InputFileContent? File { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputFileContent value) => new InputContent((global::tryAGI.OpenAI.InputFileContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFileContent?(InputContent @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputFileContent? value)
        {
            File = value;
        }

        /// <summary>
        /// An audio input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputAudio? Audio { get; init; }
#else
        public global::tryAGI.OpenAI.InputAudio? Audio { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputAudio value) => new InputContent((global::tryAGI.OpenAI.InputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputAudio?(InputContent @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContent(
            global::tryAGI.OpenAI.InputTextContent? text,
            global::tryAGI.OpenAI.InputImageContent? image,
            global::tryAGI.OpenAI.InputFileContent? file,
            global::tryAGI.OpenAI.InputAudio? audio
            )
        {
            Text = text;
            Image = image;
            File = file;
            Audio = audio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Audio as object ??
            File as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            File?.ToString() ??
            Audio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText || IsImage || IsFile || IsAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputTextContent?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.InputImageContent?, TResult>? image = null,
            global::System.Func<global::tryAGI.OpenAI.InputFileContent?, TResult>? file = null,
            global::System.Func<global::tryAGI.OpenAI.InputAudio?, TResult>? audio = null,
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
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputTextContent?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.InputImageContent?>? image = null,
            global::System.Action<global::tryAGI.OpenAI.InputFileContent?>? file = null,
            global::System.Action<global::tryAGI.OpenAI.InputAudio?>? audio = null,
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
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
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
                typeof(global::tryAGI.OpenAI.InputTextContent),
                Image,
                typeof(global::tryAGI.OpenAI.InputImageContent),
                File,
                typeof(global::tryAGI.OpenAI.InputFileContent),
                Audio,
                typeof(global::tryAGI.OpenAI.InputAudio),
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
        public bool Equals(InputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputFileContent?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputAudio?>.Default.Equals(Audio, other.Audio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputContent obj1, InputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputContent obj1, InputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContent o && Equals(o);
        }
    }
}
