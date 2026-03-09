#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The input format for the custom tool. Default is unconstrained text.
    /// </summary>
    public readonly partial struct Format2 : global::System.IEquatable<Format2>
    {
        /// <summary>
        /// Unconstrained free-form text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomTextFormatParam? Text { get; init; }
#else
        public global::tryAGI.OpenAI.CustomTextFormatParam? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// A grammar defined by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Grammar { get; init; }
#else
        public global::tryAGI.OpenAI.CustomGrammarFormatParam? Grammar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Grammar))]
#endif
        public bool IsGrammar => Grammar != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Format2(global::tryAGI.OpenAI.CustomTextFormatParam value) => new Format2((global::tryAGI.OpenAI.CustomTextFormatParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomTextFormatParam?(Format2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Format2(global::tryAGI.OpenAI.CustomTextFormatParam? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Format2(global::tryAGI.OpenAI.CustomGrammarFormatParam value) => new Format2((global::tryAGI.OpenAI.CustomGrammarFormatParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomGrammarFormatParam?(Format2 @this) => @this.Grammar;

        /// <summary>
        /// 
        /// </summary>
        public Format2(global::tryAGI.OpenAI.CustomGrammarFormatParam? value)
        {
            Grammar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Format2(
            global::tryAGI.OpenAI.CustomTextFormatParam? text,
            global::tryAGI.OpenAI.CustomGrammarFormatParam? grammar
            )
        {
            Text = text;
            Grammar = grammar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Grammar as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Grammar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsGrammar || !IsText && IsGrammar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CustomTextFormatParam?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.CustomGrammarFormatParam?, TResult>? grammar = null,
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
            else if (IsGrammar && grammar != null)
            {
                return grammar(Grammar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CustomTextFormatParam?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.CustomGrammarFormatParam?>? grammar = null,
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
            else if (IsGrammar)
            {
                grammar?.Invoke(Grammar!);
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
                typeof(global::tryAGI.OpenAI.CustomTextFormatParam),
                Grammar,
                typeof(global::tryAGI.OpenAI.CustomGrammarFormatParam),
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
        public bool Equals(Format2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomTextFormatParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomGrammarFormatParam?>.Default.Equals(Grammar, other.Grammar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Format2 obj1, Format2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Format2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Format2 obj1, Format2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Format2 o && Equals(o);
        }
    }
}
