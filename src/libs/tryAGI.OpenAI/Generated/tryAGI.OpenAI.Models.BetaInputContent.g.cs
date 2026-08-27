#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaInputContent : global::System.IEquatable<BetaInputContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputTextContent? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputTextContent? InputText { get; }
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
            out global::tryAGI.OpenAI.BetaInputTextContent? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContent PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputImageContent? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputImageContent? InputImage { get; }
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
            out global::tryAGI.OpenAI.BetaInputImageContent? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContent PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputFileContent? InputFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputFileContent? InputFile { get; }
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
            out global::tryAGI.OpenAI.BetaInputFileContent? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContent PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputContent(global::tryAGI.OpenAI.BetaInputTextContent value) => new BetaInputContent((global::tryAGI.OpenAI.BetaInputTextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputTextContent?(BetaInputContent @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public BetaInputContent(global::tryAGI.OpenAI.BetaInputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputContent FromInputText(global::tryAGI.OpenAI.BetaInputTextContent? value) => new BetaInputContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputContent(global::tryAGI.OpenAI.BetaInputImageContent value) => new BetaInputContent((global::tryAGI.OpenAI.BetaInputImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputImageContent?(BetaInputContent @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public BetaInputContent(global::tryAGI.OpenAI.BetaInputImageContent? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputContent FromInputImage(global::tryAGI.OpenAI.BetaInputImageContent? value) => new BetaInputContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputContent(global::tryAGI.OpenAI.BetaInputFileContent value) => new BetaInputContent((global::tryAGI.OpenAI.BetaInputFileContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputFileContent?(BetaInputContent @this) => @this.InputFile;

        /// <summary>
        ///
        /// </summary>
        public BetaInputContent(global::tryAGI.OpenAI.BetaInputFileContent? value)
        {
            InputFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputContent FromInputFile(global::tryAGI.OpenAI.BetaInputFileContent? value) => new BetaInputContent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaInputContent(
            global::tryAGI.OpenAI.BetaInputContentDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaInputTextContent? inputText,
            global::tryAGI.OpenAI.BetaInputImageContent? inputImage,
            global::tryAGI.OpenAI.BetaInputFileContent? inputFile
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
            global::System.Func<global::tryAGI.OpenAI.BetaInputTextContent, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputImageContent, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputFileContent, TResult>? inputFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContent>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContent>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputFileContent>? inputFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContent>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContent>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputFileContent>? inputFile = null,
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
                typeof(global::tryAGI.OpenAI.BetaInputTextContent),
                InputImage,
                typeof(global::tryAGI.OpenAI.BetaInputImageContent),
                InputFile,
                typeof(global::tryAGI.OpenAI.BetaInputFileContent),
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
        public bool Equals(BetaInputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputTextContent?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputImageContent?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputFileContent?>.Default.Equals(InputFile, other.InputFile)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaInputContent obj1, BetaInputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaInputContent obj1, BetaInputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputContent o && Equals(o);
        }
    }
}
