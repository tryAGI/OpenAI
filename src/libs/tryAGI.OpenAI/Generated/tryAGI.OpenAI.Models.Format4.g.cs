#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The input format for the custom tool. Default is unconstrained text.
    /// </summary>
    public readonly partial struct Format4 : global::System.IEquatable<Format4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? Type { get; }

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
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CustomTextFormatParam? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomTextFormatParam PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickGrammar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CustomGrammarFormatParam? value)
        {
            value = Grammar;
            return IsGrammar;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomGrammarFormatParam PickGrammar() => Grammar is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grammar' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Format4(global::tryAGI.OpenAI.CustomTextFormatParam value) => new Format4((global::tryAGI.OpenAI.CustomTextFormatParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomTextFormatParam?(Format4 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Format4(global::tryAGI.OpenAI.CustomTextFormatParam? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Format4 FromText(global::tryAGI.OpenAI.CustomTextFormatParam? value) => new Format4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Format4(global::tryAGI.OpenAI.CustomGrammarFormatParam value) => new Format4((global::tryAGI.OpenAI.CustomGrammarFormatParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomGrammarFormatParam?(Format4 @this) => @this.Grammar;

        /// <summary>
        ///
        /// </summary>
        public Format4(global::tryAGI.OpenAI.CustomGrammarFormatParam? value)
        {
            Grammar = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Format4 FromGrammar(global::tryAGI.OpenAI.CustomGrammarFormatParam? value) => new Format4(value);

        /// <summary>
        ///
        /// </summary>
        public Format4(
            global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType? type,
            global::tryAGI.OpenAI.CustomTextFormatParam? text,
            global::tryAGI.OpenAI.CustomGrammarFormatParam? grammar
            )
        {
            Type = type;

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
            global::System.Func<global::tryAGI.OpenAI.CustomTextFormatParam, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.CustomGrammarFormatParam, TResult>? grammar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Grammar is { } __value1 && grammar != null)
            {
                return grammar(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CustomTextFormatParam>? text = null,

            global::System.Action<global::tryAGI.OpenAI.CustomGrammarFormatParam>? grammar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Grammar is { } __value1)
            {
                grammar?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.CustomTextFormatParam>? text = null,
            global::System.Action<global::tryAGI.OpenAI.CustomGrammarFormatParam>? grammar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Grammar is { } __value1)
            {
                grammar?.Invoke(__value1);
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
        public bool Equals(Format4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomTextFormatParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomGrammarFormatParam?>.Default.Equals(Grammar, other.Grammar)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Format4 obj1, Format4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Format4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Format4 obj1, Format4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Format4 o && Equals(o);
        }
    }
}
