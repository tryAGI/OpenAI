#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? InputText { get; }
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
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? InputAudio { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? InputAudio { get; }
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
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? value)
        {
            value = InputAudio;
            return IsInputAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio PickInputAudio() => InputAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputAudio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? InputImage { get; }
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
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage PickInputImage() => InputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText value) => new ContentItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText?(ContentItem @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem FromInputText(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? value) => new ContentItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio value) => new ContentItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio?(ContentItem @this) => @this.InputAudio;

        /// <summary>
        ///
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? value)
        {
            InputAudio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem FromInputAudio(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? value) => new ContentItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage value) => new ContentItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage?(ContentItem @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem FromInputImage(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? value) => new ContentItem(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessageUserVariant2ContentItemDiscriminatorType? type,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText? inputText,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio? inputAudio,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage? inputImage
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
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio, TResult>? inputAudio = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage, TResult>? inputImage = null,
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
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio>? inputAudio = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage>? inputImage = null,
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
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio>? inputAudio = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage>? inputImage = null,
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
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText),
                InputAudio,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio),
                InputImage,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage),
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
        public bool Equals(ContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputAudio?>.Default.Equals(InputAudio, other.InputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImage?>.Default.Equals(InputImage, other.InputImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
        }
    }
}
