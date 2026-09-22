#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// User-provided content recorded in a session item.
    /// </summary>
    public readonly partial struct InputContentResource : global::System.IEquatable<InputContentResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Text input recorded in a session item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputContentResourceInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.InputContentResourceInputText? InputText { get; }
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
            out global::tryAGI.OpenAI.InputContentResourceInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputText PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// Image input recorded in a session item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputContentResourceInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.InputContentResourceInputImage? InputImage { get; }
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
            out global::tryAGI.OpenAI.InputContentResourceInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.InputContentResourceInputImage PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputContentResource(global::tryAGI.OpenAI.InputContentResourceInputText value) => new InputContentResource((global::tryAGI.OpenAI.InputContentResourceInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputContentResourceInputText?(InputContentResource @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public InputContentResource(global::tryAGI.OpenAI.InputContentResourceInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputContentResource FromInputText(global::tryAGI.OpenAI.InputContentResourceInputText? value) => new InputContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputContentResource(global::tryAGI.OpenAI.InputContentResourceInputImage value) => new InputContentResource((global::tryAGI.OpenAI.InputContentResourceInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputContentResourceInputImage?(InputContentResource @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public InputContentResource(global::tryAGI.OpenAI.InputContentResourceInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputContentResource FromInputImage(global::tryAGI.OpenAI.InputContentResourceInputImage? value) => new InputContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public InputContentResource(
            global::tryAGI.OpenAI.InputContentResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.InputContentResourceInputText? inputText,
            global::tryAGI.OpenAI.InputContentResourceInputImage? inputImage
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
            global::System.Func<global::tryAGI.OpenAI.InputContentResourceInputText, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.InputContentResourceInputImage, TResult>? inputImage = null,
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
            global::System.Action<global::tryAGI.OpenAI.InputContentResourceInputText>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.InputContentResourceInputImage>? inputImage = null,
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
            global::System.Action<global::tryAGI.OpenAI.InputContentResourceInputText>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.InputContentResourceInputImage>? inputImage = null,
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
                typeof(global::tryAGI.OpenAI.InputContentResourceInputText),
                InputImage,
                typeof(global::tryAGI.OpenAI.InputContentResourceInputImage),
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
        public bool Equals(InputContentResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputContentResourceInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputContentResourceInputImage?>.Default.Equals(InputImage, other.InputImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputContentResource obj1, InputContentResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContentResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputContentResource obj1, InputContentResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContentResource o && Equals(o);
        }
    }
}
