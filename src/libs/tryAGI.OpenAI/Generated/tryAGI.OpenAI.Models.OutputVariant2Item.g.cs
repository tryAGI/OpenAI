#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A piece of message content, such as text, an image, or a file.
    /// </summary>
    public readonly partial struct OutputVariant2Item : global::System.IEquatable<OutputVariant2Item>
    {
        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputTextContentParam? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.InputTextContentParam? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.InputImageContentParamAutoParam? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputFileContentParam? InputFile { get; init; }
#else
        public global::tryAGI.OpenAI.InputFileContentParam? InputFile { get; }
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
        public static implicit operator OutputVariant2Item(global::tryAGI.OpenAI.InputTextContentParam value) => new OutputVariant2Item((global::tryAGI.OpenAI.InputTextContentParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContentParam?(OutputVariant2Item @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public OutputVariant2Item(global::tryAGI.OpenAI.InputTextContentParam? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputVariant2Item(global::tryAGI.OpenAI.InputImageContentParamAutoParam value) => new OutputVariant2Item((global::tryAGI.OpenAI.InputImageContentParamAutoParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImageContentParamAutoParam?(OutputVariant2Item @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public OutputVariant2Item(global::tryAGI.OpenAI.InputImageContentParamAutoParam? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputVariant2Item(global::tryAGI.OpenAI.InputFileContentParam value) => new OutputVariant2Item((global::tryAGI.OpenAI.InputFileContentParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFileContentParam?(OutputVariant2Item @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public OutputVariant2Item(global::tryAGI.OpenAI.InputFileContentParam? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputVariant2Item(
            global::tryAGI.OpenAI.InputTextContentParam? inputText,
            global::tryAGI.OpenAI.InputImageContentParamAutoParam? inputImage,
            global::tryAGI.OpenAI.InputFileContentParam? inputFile
            )
        {
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
            global::System.Func<global::tryAGI.OpenAI.InputTextContentParam?, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.InputImageContentParamAutoParam?, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.InputFileContentParam?, TResult>? inputFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.InputTextContentParam?>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.InputImageContentParamAutoParam?>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.InputFileContentParam?>? inputFile = null,
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
                typeof(global::tryAGI.OpenAI.InputTextContentParam),
                InputImage,
                typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParam),
                InputFile,
                typeof(global::tryAGI.OpenAI.InputFileContentParam),
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
        public bool Equals(OutputVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputTextContentParam?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputImageContentParamAutoParam?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputFileContentParam?>.Default.Equals(InputFile, other.InputFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputVariant2Item obj1, OutputVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputVariant2Item obj1, OutputVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputVariant2Item o && Equals(o);
        }
    }
}
