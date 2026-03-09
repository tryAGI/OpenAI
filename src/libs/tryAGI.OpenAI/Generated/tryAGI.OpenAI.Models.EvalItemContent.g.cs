#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Inputs to the model - can contain template strings. Supports text, output text, input images, and input audio, either as a single item or an array of items.
    /// </summary>
    public readonly partial struct EvalItemContent : global::System.IEquatable<EvalItemContent>
    {
        /// <summary>
        /// A single content item: input text, output text, input image, or input audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalItemContentItem? EvalContentItem { get; init; }
#else
        public global::tryAGI.OpenAI.EvalItemContentItem? EvalContentItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalContentItem))]
#endif
        public bool IsEvalContentItem => EvalContentItem != null;

        /// <summary>
        /// A list of inputs, each of which may be either an input text, output text, input<br/>
        /// image, or input audio object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? AnArrayOfInputText,OutputText,InputImage,AndInputAudio { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? AnArrayOfInputText,OutputText,InputImage,AndInputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnArrayOfInputText,OutputText,InputImage,AndInputAudio))]
#endif
        public bool IsAnArrayOfInputText,OutputText,InputImage,AndInputAudio => AnArrayOfInputText,OutputText,InputImage,AndInputAudio != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalItemContent(global::tryAGI.OpenAI.EvalItemContentItem value) => new EvalItemContent((global::tryAGI.OpenAI.EvalItemContentItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalItemContentItem?(EvalItemContent @this) => @this.EvalContentItem;

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContent(global::tryAGI.OpenAI.EvalItemContentItem? value)
        {
            EvalContentItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalItemContent(
            global::tryAGI.OpenAI.EvalItemContentItem? evalContentItem,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? anArrayOfInputText,OutputText,InputImage,AndInputAudio
            )
        {
            EvalContentItem = evalContentItem;
            AnArrayOfInputText,OutputText,InputImage,AndInputAudio = anArrayOfInputText,OutputText,InputImage,AndInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnArrayOfInputText,OutputText,InputImage,AndInputAudio as object ??
            EvalContentItem as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EvalContentItem?.ToString() ??
            AnArrayOfInputText,OutputText,InputImage,AndInputAudio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvalContentItem && !IsAnArrayOfInputText,OutputText,InputImage,AndInputAudio || !IsEvalContentItem && IsAnArrayOfInputText,OutputText,InputImage,AndInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.EvalItemContentItem?, TResult>? evalContentItem = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>?, TResult>? anArrayOfInputText,OutputText,InputImage,AndInputAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvalContentItem && evalContentItem != null)
            {
                return evalContentItem(EvalContentItem!);
            }
            else if (IsAnArrayOfInputText,OutputText,InputImage,AndInputAudio && anArrayOfInputText,OutputText,InputImage,AndInputAudio != null)
            {
                return anArrayOfInputText,OutputText,InputImage,AndInputAudio(AnArrayOfInputText,OutputText,InputImage,AndInputAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.EvalItemContentItem?>? evalContentItem = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>?>? anArrayOfInputText,OutputText,InputImage,AndInputAudio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvalContentItem)
            {
                evalContentItem?.Invoke(EvalContentItem!);
            }
            else if (IsAnArrayOfInputText,OutputText,InputImage,AndInputAudio)
            {
                anArrayOfInputText,OutputText,InputImage,AndInputAudio?.Invoke(AnArrayOfInputText,OutputText,InputImage,AndInputAudio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EvalContentItem,
                typeof(global::tryAGI.OpenAI.EvalItemContentItem),
                AnArrayOfInputText,OutputText,InputImage,AndInputAudio,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>),
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
        public bool Equals(EvalItemContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalItemContentItem?>.Default.Equals(EvalContentItem, other.EvalContentItem) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>?>.Default.Equals(AnArrayOfInputText,OutputText,InputImage,AndInputAudio, other.AnArrayOfInputText,OutputText,InputImage,AndInputAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalItemContent obj1, EvalItemContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalItemContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalItemContent obj1, EvalItemContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalItemContent o && Equals(o);
        }
    }
}
