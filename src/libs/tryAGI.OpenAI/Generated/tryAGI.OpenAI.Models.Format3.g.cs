#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The input format for the custom tool. Default is unconstrained text.
    /// </summary>
    public readonly partial struct Format3 : global::System.IEquatable<Format3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? Type { get; }

        /// <summary>
        /// Unconstrained free-form text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Text { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam? Text { get; }
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
            out global::tryAGI.OpenAI.BetaCustomTextFormatParam? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomTextFormatParam PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// A grammar defined by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Grammar { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? Grammar { get; }
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
            out global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? value)
        {
            value = Grammar;
            return IsGrammar;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomGrammarFormatParam PickGrammar() => IsGrammar
            ? Grammar!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grammar' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Format3(global::tryAGI.OpenAI.BetaCustomTextFormatParam value) => new Format3((global::tryAGI.OpenAI.BetaCustomTextFormatParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomTextFormatParam?(Format3 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Format3(global::tryAGI.OpenAI.BetaCustomTextFormatParam? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Format3 FromText(global::tryAGI.OpenAI.BetaCustomTextFormatParam? value) => new Format3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Format3(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam value) => new Format3((global::tryAGI.OpenAI.BetaCustomGrammarFormatParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomGrammarFormatParam?(Format3 @this) => @this.Grammar;

        /// <summary>
        ///
        /// </summary>
        public Format3(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? value)
        {
            Grammar = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Format3 FromGrammar(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? value) => new Format3(value);

        /// <summary>
        ///
        /// </summary>
        public Format3(
            global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaCustomTextFormatParam? text,
            global::tryAGI.OpenAI.BetaCustomGrammarFormatParam? grammar
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
            global::System.Func<global::tryAGI.OpenAI.BetaCustomTextFormatParam, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomGrammarFormatParam, TResult>? grammar = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaCustomTextFormatParam>? text = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomGrammarFormatParam>? grammar = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaCustomTextFormatParam>? text = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomGrammarFormatParam>? grammar = null,
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
                typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParam),
                Grammar,
                typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam),
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
        public bool Equals(Format3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomTextFormatParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomGrammarFormatParam?>.Default.Equals(Grammar, other.Grammar)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Format3 obj1, Format3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Format3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Format3 obj1, Format3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Format3 o && Equals(o);
        }
    }
}
