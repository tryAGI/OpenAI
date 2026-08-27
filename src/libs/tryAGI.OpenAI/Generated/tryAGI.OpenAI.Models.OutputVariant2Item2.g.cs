#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A piece of message content, such as text, an image, or a file.
    /// </summary>
    public readonly partial struct OutputVariant2Item2 : global::System.IEquatable<OutputVariant2Item2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputTextContentParam? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputTextContentParam? InputText { get; }
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
            out global::tryAGI.OpenAI.BetaInputTextContentParam? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? InputImage { get; }
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
            out global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputFileContentParam? InputFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputFileContentParam? InputFile { get; }
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
            out global::tryAGI.OpenAI.BetaInputFileContentParam? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputFileContentParam PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item2(global::tryAGI.OpenAI.BetaInputTextContentParam value) => new OutputVariant2Item2((global::tryAGI.OpenAI.BetaInputTextContentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputTextContentParam?(OutputVariant2Item2 @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item2(global::tryAGI.OpenAI.BetaInputTextContentParam? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item2 FromInputText(global::tryAGI.OpenAI.BetaInputTextContentParam? value) => new OutputVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item2(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam value) => new OutputVariant2Item2((global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam?(OutputVariant2Item2 @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item2(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item2 FromInputImage(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? value) => new OutputVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item2(global::tryAGI.OpenAI.BetaInputFileContentParam value) => new OutputVariant2Item2((global::tryAGI.OpenAI.BetaInputFileContentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputFileContentParam?(OutputVariant2Item2 @this) => @this.InputFile;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item2(global::tryAGI.OpenAI.BetaInputFileContentParam? value)
        {
            InputFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item2 FromInputFile(global::tryAGI.OpenAI.BetaInputFileContentParam? value) => new OutputVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item2(
            global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaInputTextContentParam? inputText,
            global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? inputImage,
            global::tryAGI.OpenAI.BetaInputFileContentParam? inputFile
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
            global::System.Func<global::tryAGI.OpenAI.BetaInputTextContentParam, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputFileContentParam, TResult>? inputFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContentParam>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputFileContentParam>? inputFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContentParam>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputFileContentParam>? inputFile = null,
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
                typeof(global::tryAGI.OpenAI.BetaInputTextContentParam),
                InputImage,
                typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam),
                InputFile,
                typeof(global::tryAGI.OpenAI.BetaInputFileContentParam),
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
        public bool Equals(OutputVariant2Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputTextContentParam?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputFileContentParam?>.Default.Equals(InputFile, other.InputFile)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputVariant2Item2 obj1, OutputVariant2Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputVariant2Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputVariant2Item2 obj1, OutputVariant2Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputVariant2Item2 o && Equals(o);
        }
    }
}
