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
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputTextContent? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.InputTextContent? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InputTextContent? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContent PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputImageContent? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.InputImageContent? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InputImageContent? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContent PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputFileContent? InputFile { get; init; }
#else
        public global::tryAGI.OpenAI.InputFileContent? InputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InputFileContent? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContent PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputTextContent value) => new InputContent((global::tryAGI.OpenAI.InputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContent?(InputContent @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContent FromInputText(global::tryAGI.OpenAI.InputTextContent? value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputImageContent value) => new InputContent((global::tryAGI.OpenAI.InputImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImageContent?(InputContent @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputImageContent? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContent FromInputImage(global::tryAGI.OpenAI.InputImageContent? value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputContent(global::tryAGI.OpenAI.InputFileContent value) => new InputContent((global::tryAGI.OpenAI.InputFileContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFileContent?(InputContent @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public InputContent(global::tryAGI.OpenAI.InputFileContent? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputContent FromInputFile(global::tryAGI.OpenAI.InputFileContent? value) => new InputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public InputContent(
            global::tryAGI.OpenAI.InputContentDiscriminatorType? type,
            global::tryAGI.OpenAI.InputTextContent? inputText,
            global::tryAGI.OpenAI.InputImageContent? inputImage,
            global::tryAGI.OpenAI.InputFileContent? inputFile
            )
        {
            Type = type;

            InputText = inputText;
            InputImage = inputImage;
            InputFile = inputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFile as object ??
            InputImage as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsInputFile || !IsInputText && IsInputImage && !IsInputFile || !IsInputText && !IsInputImage && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputTextContent, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.InputImageContent, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.InputFileContent, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputTextContent>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.InputImageContent>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.InputFileContent>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.InputTextContent>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.InputImageContent>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.InputFileContent>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::tryAGI.OpenAI.InputTextContent),
                InputImage,
                typeof(global::tryAGI.OpenAI.InputImageContent),
                InputFile,
                typeof(global::tryAGI.OpenAI.InputFileContent),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputTextContent?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputImageContent?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputFileContent?>.Default.Equals(InputFile, other.InputFile) 
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
