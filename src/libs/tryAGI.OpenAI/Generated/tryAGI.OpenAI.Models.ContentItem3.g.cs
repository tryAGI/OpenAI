#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentItem3 : global::System.IEquatable<ContentItem3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputText? InputText { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputText PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputAudio? InputAudio { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputAudio? InputAudio { get; }
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
        public bool TryPickInputAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RealtimeResponseInputAudio? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputAudio PickInputAudio() => InputAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputImage? InputImage { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputImage PickInputImage() => InputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.RealtimeResponseInputText value) => new ContentItem3((global::tryAGI.OpenAI.RealtimeResponseInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputText?(ContentItem3 @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.RealtimeResponseInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem3 FromInputText(global::tryAGI.OpenAI.RealtimeResponseInputText? value) => new ContentItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.RealtimeResponseInputAudio value) => new ContentItem3((global::tryAGI.OpenAI.RealtimeResponseInputAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputAudio?(ContentItem3 @this) => @this.InputAudio;

        /// <summary>
        ///
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.RealtimeResponseInputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem3 FromInputAudio(global::tryAGI.OpenAI.RealtimeResponseInputAudio? value) => new ContentItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.RealtimeResponseInputImage value) => new ContentItem3((global::tryAGI.OpenAI.RealtimeResponseInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputImage?(ContentItem3 @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.RealtimeResponseInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem3 FromInputImage(global::tryAGI.OpenAI.RealtimeResponseInputImage? value) => new ContentItem3(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem3(
            global::tryAGI.OpenAI.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? type,
            global::tryAGI.OpenAI.RealtimeResponseInputText? inputText,
            global::tryAGI.OpenAI.RealtimeResponseInputAudio? inputAudio,
            global::tryAGI.OpenAI.RealtimeResponseInputImage? inputImage
            )
        {
            Type = type;

            InputText = inputText;
            InputAudio = inputAudio;
            InputImage = inputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputImage as object ??
            InputAudio as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputAudio?.ToString() ??
            InputImage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText || IsInputAudio || IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputText, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputAudio, TResult>? inputAudio = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputImage, TResult>? inputImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0 && inputText != null)
            {
                return inputText(__value0);
            }
            else if (InputAudio is { } __value1 && inputAudio != null)
            {
                return inputAudio(__value1);
            }
            else if (InputImage is { } __value2 && inputImage != null)
            {
                return inputImage(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputText>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputAudio>? inputAudio = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputImage>? inputImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0)
            {
                inputText?.Invoke(__value0);
            }
            else if (InputAudio is { } __value1)
            {
                inputAudio?.Invoke(__value1);
            }
            else if (InputImage is { } __value2)
            {
                inputImage?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputText>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputAudio>? inputAudio = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputImage>? inputImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputText is { } __value0)
            {
                inputText?.Invoke(__value0);
            }
            else if (InputAudio is { } __value1)
            {
                inputAudio?.Invoke(__value1);
            }
            else if (InputImage is { } __value2)
            {
                inputImage?.Invoke(__value2);
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
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputText),
                InputAudio,
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputAudio),
                InputImage,
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputImage),
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
        public bool Equals(ContentItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputImage?>.Default.Equals(InputImage, other.InputImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem3 obj1, ContentItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem3 obj1, ContentItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem3 o && Equals(o);
        }
    }
}
