#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? InputText { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParam PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? InputImage { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionUserInputImageParam PickInputImage() => InputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParam? InputJson { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParam? InputJson { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJson))]
#endif
        public bool IsInputJson => InputJson != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputJson(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionInputJsonParam? value)
        {
            value = InputJson;
            return IsInputJson;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputJsonParam PickInputJson() => InputJson is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputJson' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.LiveDecisionUserInputTextParam value) => new ContentVariant2Item((global::tryAGI.OpenAI.LiveDecisionUserInputTextParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionUserInputTextParam?(ContentVariant2Item @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromInputText(global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.LiveDecisionUserInputImageParam value) => new ContentVariant2Item((global::tryAGI.OpenAI.LiveDecisionUserInputImageParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionUserInputImageParam?(ContentVariant2Item @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromInputImage(global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.LiveDecisionInputJsonParam value) => new ContentVariant2Item((global::tryAGI.OpenAI.LiveDecisionInputJsonParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionInputJsonParam?(ContentVariant2Item @this) => @this.InputJson;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.LiveDecisionInputJsonParam? value)
        {
            InputJson = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item FromInputJson(global::tryAGI.OpenAI.LiveDecisionInputJsonParam? value) => new ContentVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item(
            global::tryAGI.OpenAI.LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveDecisionUserInputTextParam? inputText,
            global::tryAGI.OpenAI.LiveDecisionUserInputImageParam? inputImage,
            global::tryAGI.OpenAI.LiveDecisionInputJsonParam? inputJson
            )
        {
            Type = type;

            InputText = inputText;
            InputImage = inputImage;
            InputJson = inputJson;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputJson as object ??
            InputImage as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            InputJson?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsInputJson || !IsInputText && IsInputImage && !IsInputJson || !IsInputText && !IsInputImage && IsInputJson;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionUserInputTextParam, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionUserInputImageParam, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionInputJsonParam, TResult>? inputJson = null,
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
            else if (InputJson is { } __value2 && inputJson != null)
            {
                return inputJson(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionUserInputTextParam>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionUserInputImageParam>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputJsonParam>? inputJson = null,
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
            else if (InputJson is { } __value2)
            {
                inputJson?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionUserInputTextParam>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionUserInputImageParam>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputJsonParam>? inputJson = null,
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
            else if (InputJson is { } __value2)
            {
                inputJson?.Invoke(__value2);
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
                typeof(global::tryAGI.OpenAI.LiveDecisionUserInputTextParam),
                InputImage,
                typeof(global::tryAGI.OpenAI.LiveDecisionUserInputImageParam),
                InputJson,
                typeof(global::tryAGI.OpenAI.LiveDecisionInputJsonParam),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionUserInputTextParam?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionUserInputImageParam?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionInputJsonParam?>.Default.Equals(InputJson, other.InputJson)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
