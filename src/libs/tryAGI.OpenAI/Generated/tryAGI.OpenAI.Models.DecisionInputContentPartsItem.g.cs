#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionInputContentPartsItem : global::System.IEquatable<DecisionInputContentPartsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputText? InputText { get; }
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
            out global::tryAGI.OpenAI.DecisionInputText? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputText PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// An inline image. External URLs and file IDs are not supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputImage? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputImage? InputImage { get; }
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
            out global::tryAGI.OpenAI.DecisionInputImage? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputImage PickInputImage() => InputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputContentPartsItem(global::tryAGI.OpenAI.DecisionInputText value) => new DecisionInputContentPartsItem((global::tryAGI.OpenAI.DecisionInputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputText?(DecisionInputContentPartsItem @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputContentPartsItem(global::tryAGI.OpenAI.DecisionInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputContentPartsItem FromInputText(global::tryAGI.OpenAI.DecisionInputText? value) => new DecisionInputContentPartsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputContentPartsItem(global::tryAGI.OpenAI.DecisionInputImage value) => new DecisionInputContentPartsItem((global::tryAGI.OpenAI.DecisionInputImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputImage?(DecisionInputContentPartsItem @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputContentPartsItem(global::tryAGI.OpenAI.DecisionInputImage? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputContentPartsItem FromInputImage(global::tryAGI.OpenAI.DecisionInputImage? value) => new DecisionInputContentPartsItem(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputContentPartsItem(
            global::tryAGI.OpenAI.DecisionInputContentPartDiscriminatorType? type,
            global::tryAGI.OpenAI.DecisionInputText? inputText,
            global::tryAGI.OpenAI.DecisionInputImage? inputImage
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
            global::System.Func<global::tryAGI.OpenAI.DecisionInputText, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputImage, TResult>? inputImage = null,
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
            else if (InputImage is { } __value1 && inputImage != null)
            {
                return inputImage(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputText>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputImage>? inputImage = null,
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
            else if (InputImage is { } __value1)
            {
                inputImage?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputText>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputImage>? inputImage = null,
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
            else if (InputImage is { } __value1)
            {
                inputImage?.Invoke(__value1);
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
                typeof(global::tryAGI.OpenAI.DecisionInputText),
                InputImage,
                typeof(global::tryAGI.OpenAI.DecisionInputImage),
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
        public bool Equals(DecisionInputContentPartsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputImage?>.Default.Equals(InputImage, other.InputImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputContentPartsItem obj1, DecisionInputContentPartsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputContentPartsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputContentPartsItem obj1, DecisionInputContentPartsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputContentPartsItem o && Equals(o);
        }
    }
}
