#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputContent : global::System.IEquatable<OutputContent>
    {
        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.OutputText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContent(global::tryAGI.OpenAI.OutputText value) => new OutputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputText?(OutputContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::tryAGI.OpenAI.OutputText? value)
        {
            Text = value;
        }

        /// <summary>
        /// A refusal from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Refusal? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.Refusal? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContent(global::tryAGI.OpenAI.Refusal value) => new OutputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Refusal?(OutputContent @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::tryAGI.OpenAI.Refusal? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(
            global::tryAGI.OpenAI.OutputText? text,
            global::tryAGI.OpenAI.Refusal? refusal
            )
        {
            Text = text;
            Refusal = refusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refusal as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Refusal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsRefusal || !IsText && IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.OutputText?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.Refusal?, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.OutputText?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.Refusal?>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::tryAGI.OpenAI.OutputText),
                Refusal,
                typeof(global::tryAGI.OpenAI.Refusal),
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
        public bool Equals(OutputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Refusal?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputContent obj1, OutputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputContent obj1, OutputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputContent o && Equals(o);
        }
    }
}
