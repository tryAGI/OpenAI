#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Content included in an input message.
    /// </summary>
    public readonly partial struct InputContentParam : global::System.IEquatable<InputContentParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputContentParamInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.InputContentParamInputText? InputText { get; }
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
            out global::tryAGI.OpenAI.InputContentParamInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputText PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// Image input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputContentParamInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.InputContentParamInputImage? InputImage { get; }
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
            out global::tryAGI.OpenAI.InputContentParamInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentParamInputImage PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputContentParam(global::tryAGI.OpenAI.InputContentParamInputText value) => new InputContentParam((global::tryAGI.OpenAI.InputContentParamInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputContentParamInputText?(InputContentParam @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public InputContentParam(global::tryAGI.OpenAI.InputContentParamInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputContentParam FromInputText(global::tryAGI.OpenAI.InputContentParamInputText? value) => new InputContentParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputContentParam(global::tryAGI.OpenAI.InputContentParamInputImage value) => new InputContentParam((global::tryAGI.OpenAI.InputContentParamInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputContentParamInputImage?(InputContentParam @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public InputContentParam(global::tryAGI.OpenAI.InputContentParamInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputContentParam FromInputImage(global::tryAGI.OpenAI.InputContentParamInputImage? value) => new InputContentParam(value);

        /// <summary>
        ///
        /// </summary>
        public InputContentParam(
            global::tryAGI.OpenAI.InputContentParamDiscriminatorType? type,
            global::tryAGI.OpenAI.InputContentParamInputText? inputText,
            global::tryAGI.OpenAI.InputContentParamInputImage? inputImage
            )
        {
            Type = type;

            InputText = inputText;
            InputImage = inputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputImage as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage || !IsInputText && IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputContentParamInputText, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.InputContentParamInputImage, TResult>? inputImage = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputContentParamInputText>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.InputContentParamInputImage>? inputImage = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.InputContentParamInputText>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.InputContentParamInputImage>? inputImage = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::tryAGI.OpenAI.InputContentParamInputText),
                InputImage,
                typeof(global::tryAGI.OpenAI.InputContentParamInputImage),
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
        public bool Equals(InputContentParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputContentParamInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputContentParamInputImage?>.Default.Equals(InputImage, other.InputImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputContentParam obj1, InputContentParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContentParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputContentParam obj1, InputContentParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContentParam o && Equals(o);
        }
    }
}
