#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A content part in a session message.
    /// </summary>
    public readonly partial struct MessageContentResource : global::System.IEquatable<MessageContentResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Text supplied by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentResourceInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentResourceInputText? InputText { get; }
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
            out global::tryAGI.OpenAI.MessageContentResourceInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputText PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// An image supplied by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentResourceInputImage? InputImage { get; }
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
            out global::tryAGI.OpenAI.MessageContentResourceInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceInputImage PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// Text produced by the assistant.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentResourceOutputText? OutputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.MessageContentResourceOutputText? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentResourceOutputText PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessageContentResource(global::tryAGI.OpenAI.MessageContentResourceInputText value) => new MessageContentResource((global::tryAGI.OpenAI.MessageContentResourceInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentResourceInputText?(MessageContentResource @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public MessageContentResource(global::tryAGI.OpenAI.MessageContentResourceInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessageContentResource FromInputText(global::tryAGI.OpenAI.MessageContentResourceInputText? value) => new MessageContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessageContentResource(global::tryAGI.OpenAI.MessageContentResourceInputImage value) => new MessageContentResource((global::tryAGI.OpenAI.MessageContentResourceInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentResourceInputImage?(MessageContentResource @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public MessageContentResource(global::tryAGI.OpenAI.MessageContentResourceInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessageContentResource FromInputImage(global::tryAGI.OpenAI.MessageContentResourceInputImage? value) => new MessageContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessageContentResource(global::tryAGI.OpenAI.MessageContentResourceOutputText value) => new MessageContentResource((global::tryAGI.OpenAI.MessageContentResourceOutputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentResourceOutputText?(MessageContentResource @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public MessageContentResource(global::tryAGI.OpenAI.MessageContentResourceOutputText? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessageContentResource FromOutputText(global::tryAGI.OpenAI.MessageContentResourceOutputText? value) => new MessageContentResource(value);

        /// <summary>
        ///
        /// </summary>
        public MessageContentResource(
            global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.MessageContentResourceInputText? inputText,
            global::tryAGI.OpenAI.MessageContentResourceInputImage? inputImage,
            global::tryAGI.OpenAI.MessageContentResourceOutputText? outputText
            )
        {
            Type = type;

            InputText = inputText;
            InputImage = inputImage;
            OutputText = outputText;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputText as object ??
            InputImage as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            OutputText?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsOutputText || !IsInputText && IsInputImage && !IsOutputText || !IsInputText && !IsInputImage && IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.MessageContentResourceInputText, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.MessageContentResourceInputImage, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.MessageContentResourceOutputText, TResult>? outputText = null,
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
            else if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.MessageContentResourceInputText>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.MessageContentResourceInputImage>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.MessageContentResourceOutputText>? outputText = null,
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
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.MessageContentResourceInputText>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.MessageContentResourceInputImage>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.MessageContentResourceOutputText>? outputText = null,
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
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
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
                typeof(global::tryAGI.OpenAI.MessageContentResourceInputText),
                InputImage,
                typeof(global::tryAGI.OpenAI.MessageContentResourceInputImage),
                OutputText,
                typeof(global::tryAGI.OpenAI.MessageContentResourceOutputText),
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
        public bool Equals(MessageContentResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentResourceInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentResourceInputImage?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentResourceOutputText?>.Default.Equals(OutputText, other.OutputText)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MessageContentResource obj1, MessageContentResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageContentResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessageContentResource obj1, MessageContentResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageContentResource o && Equals(o);
        }
    }
}
