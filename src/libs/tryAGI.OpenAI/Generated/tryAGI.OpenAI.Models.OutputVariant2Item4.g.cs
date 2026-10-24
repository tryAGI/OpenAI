#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputVariant2Item4 : global::System.IEquatable<OutputVariant2Item4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionInputTextParam? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionInputTextParam? InputText { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionInputTextParam? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputTextParam PickInputText() => InputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionInputImageParam? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionInputImageParam? InputImage { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionInputImageParam? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputImageParam PickInputImage() => InputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item4(global::tryAGI.OpenAI.LiveDecisionInputTextParam value) => new OutputVariant2Item4((global::tryAGI.OpenAI.LiveDecisionInputTextParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionInputTextParam?(OutputVariant2Item4 @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(global::tryAGI.OpenAI.LiveDecisionInputTextParam? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item4 FromInputText(global::tryAGI.OpenAI.LiveDecisionInputTextParam? value) => new OutputVariant2Item4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputVariant2Item4(global::tryAGI.OpenAI.LiveDecisionInputImageParam value) => new OutputVariant2Item4((global::tryAGI.OpenAI.LiveDecisionInputImageParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionInputImageParam?(OutputVariant2Item4 @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(global::tryAGI.OpenAI.LiveDecisionInputImageParam? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputVariant2Item4 FromInputImage(global::tryAGI.OpenAI.LiveDecisionInputImageParam? value) => new OutputVariant2Item4(value);

        /// <summary>
        ///
        /// </summary>
        public OutputVariant2Item4(
            global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveDecisionInputTextParam? inputText,
            global::tryAGI.OpenAI.LiveDecisionInputImageParam? inputImage
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
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionInputTextParam, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionInputImageParam, TResult>? inputImage = null,
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputTextParam>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputImageParam>? inputImage = null,
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputTextParam>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputImageParam>? inputImage = null,
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
                typeof(global::tryAGI.OpenAI.LiveDecisionInputTextParam),
                InputImage,
                typeof(global::tryAGI.OpenAI.LiveDecisionInputImageParam),
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
        public bool Equals(OutputVariant2Item4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionInputTextParam?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionInputImageParam?>.Default.Equals(InputImage, other.InputImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputVariant2Item4 obj1, OutputVariant2Item4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputVariant2Item4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputVariant2Item4 obj1, OutputVariant2Item4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputVariant2Item4 o && Equals(o);
        }
    }
}
