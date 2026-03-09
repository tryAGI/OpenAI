#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A single content item: input text, output text, input image, or input audio.
    /// </summary>
    public readonly partial struct EvalItemContentItem : global::System.IEquatable<EvalItemContentItem>
    {
        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TextInput { get; init; }
#else
        public string? TextInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextInput))]
#endif
        public bool IsTextInput => TextInput != null;

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
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalItemContentOutputText? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.EvalItemContentOutputText? OutputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        /// An image input block used within EvalItem content arrays.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalItemInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.EvalItemInputImage? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// An audio input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputAudio? InputAudio { get; init; }
#else
        public global::tryAGI.OpenAI.InputAudio? InputAudio { get; }
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
        public static implicit operator EvalItemContentItem(string value) => new EvalItemContentItem((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EvalItemContentItem @this) => @this.TextInput;

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContentItem(string? value)
        {
            TextInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalItemContentItem(global::tryAGI.OpenAI.InputTextContent value) => new EvalItemContentItem((global::tryAGI.OpenAI.InputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContent?(EvalItemContentItem @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContentItem(global::tryAGI.OpenAI.InputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalItemContentItem(global::tryAGI.OpenAI.EvalItemContentOutputText value) => new EvalItemContentItem((global::tryAGI.OpenAI.EvalItemContentOutputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalItemContentOutputText?(EvalItemContentItem @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContentItem(global::tryAGI.OpenAI.EvalItemContentOutputText? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalItemContentItem(global::tryAGI.OpenAI.EvalItemInputImage value) => new EvalItemContentItem((global::tryAGI.OpenAI.EvalItemInputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalItemInputImage?(EvalItemContentItem @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContentItem(global::tryAGI.OpenAI.EvalItemInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalItemContentItem(global::tryAGI.OpenAI.InputAudio value) => new EvalItemContentItem((global::tryAGI.OpenAI.InputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputAudio?(EvalItemContentItem @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContentItem(global::tryAGI.OpenAI.InputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContentItem(
            string? textInput,
            global::tryAGI.OpenAI.InputTextContent? inputText,
            global::tryAGI.OpenAI.EvalItemContentOutputText? outputText,
            global::tryAGI.OpenAI.EvalItemInputImage? inputImage,
            global::tryAGI.OpenAI.InputAudio? inputAudio
            )
        {
            TextInput = textInput;
            InputText = inputText;
            OutputText = outputText;
            InputImage = inputImage;
            InputAudio = inputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputAudio as object ??
            InputImage as object ??
            OutputText as object ??
            InputText as object ??
            TextInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextInput?.ToString() ??
            InputText?.ToString() ??
            OutputText?.ToString() ??
            InputImage?.ToString() ??
            InputAudio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextInput && !IsInputText && !IsOutputText && !IsInputImage && !IsInputAudio || !IsTextInput && IsInputText && !IsOutputText && !IsInputImage && !IsInputAudio || !IsTextInput && !IsInputText && IsOutputText && !IsInputImage && !IsInputAudio || !IsTextInput && !IsInputText && !IsOutputText && IsInputImage && !IsInputAudio || !IsTextInput && !IsInputText && !IsOutputText && !IsInputImage && IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? textInput = null,
            global::System.Func<global::tryAGI.OpenAI.InputTextContent?, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.EvalItemContentOutputText?, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.EvalItemInputImage?, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.InputAudio?, TResult>? inputAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput && textInput != null)
            {
                return textInput(TextInput!);
            }
            else if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
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
            global::System.Action<string?>? textInput = null,
            global::System.Action<global::tryAGI.OpenAI.InputTextContent?>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.EvalItemContentOutputText?>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.EvalItemInputImage?>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.InputAudio?>? inputAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextInput)
            {
                textInput?.Invoke(TextInput!);
            }
            else if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
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
                TextInput,
                typeof(string),
                InputText,
                typeof(global::tryAGI.OpenAI.InputTextContent),
                OutputText,
                typeof(global::tryAGI.OpenAI.EvalItemContentOutputText),
                InputImage,
                typeof(global::tryAGI.OpenAI.EvalItemInputImage),
                InputAudio,
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
        public bool Equals(EvalItemContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TextInput, other.TextInput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputTextContent?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalItemContentOutputText?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalItemInputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputAudio?>.Default.Equals(InputAudio, other.InputAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalItemContentItem obj1, EvalItemContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalItemContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalItemContentItem obj1, EvalItemContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalItemContentItem o && Equals(o);
        }
    }
}
