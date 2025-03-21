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
        public global::tryAGI.OpenAI.InputText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.InputText? Text { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputText value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputText?(InputContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputText? value)
        {
            Text = value;
        }

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputImage? Image { get; init; }
#else
        public global::tryAGI.OpenAI.InputImage? Image { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputImage value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImage?(InputContent @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputFile? File { get; init; }
#else
        public global::tryAGI.OpenAI.InputFile? File { get; }
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
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputFile value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFile?(InputContent @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputFile? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContent(
            global::tryAGI.OpenAI.InputText? text,
            global::tryAGI.OpenAI.InputImage? image,
            global::tryAGI.OpenAI.InputFile? file
            )
        {
            Text = text;
            Image = image;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsFile || !IsText && IsImage && !IsFile || !IsText && !IsImage && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputText?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.InputImage?, TResult>? image = null,
            global::System.Func<global::tryAGI.OpenAI.InputFile?, TResult>? file = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputText?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.InputImage?>? image = null,
            global::System.Action<global::tryAGI.OpenAI.InputFile?>? file = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::tryAGI.OpenAI.InputText),
                Image,
                typeof(global::tryAGI.OpenAI.InputImage),
                File,
                typeof(global::tryAGI.OpenAI.InputFile),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputImage?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputFile?>.Default.Equals(File, other.File) 
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
