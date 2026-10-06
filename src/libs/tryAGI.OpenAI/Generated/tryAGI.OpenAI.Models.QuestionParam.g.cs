#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A question about the request's input, with an optional correlation name.
    /// </summary>
    public readonly partial struct QuestionParam : global::System.IEquatable<QuestionParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.QuestionParamPredicate? Predicate { get; init; }
#else
        public global::tryAGI.OpenAI.QuestionParamPredicate? Predicate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Predicate))]
#endif
        public bool IsPredicate => Predicate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPredicate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.QuestionParamPredicate? value)
        {
            value = Predicate;
            return IsPredicate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamPredicate PickPredicate() => Predicate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Predicate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.QuestionParamChoice? Choice { get; init; }
#else
        public global::tryAGI.OpenAI.QuestionParamChoice? Choice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Choice))]
#endif
        public bool IsChoice => Choice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.QuestionParamChoice? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamChoice PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.QuestionParamScore? Score { get; init; }
#else
        public global::tryAGI.OpenAI.QuestionParamScore? Score { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Score))]
#endif
        public bool IsScore => Score != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.QuestionParamScore? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.QuestionParamScore PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuestionParam(global::tryAGI.OpenAI.QuestionParamPredicate value) => new QuestionParam((global::tryAGI.OpenAI.QuestionParamPredicate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.QuestionParamPredicate?(QuestionParam @this) => @this.Predicate;

        /// <summary>
        ///
        /// </summary>
        public QuestionParam(global::tryAGI.OpenAI.QuestionParamPredicate? value)
        {
            Predicate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuestionParam FromPredicate(global::tryAGI.OpenAI.QuestionParamPredicate? value) => new QuestionParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuestionParam(global::tryAGI.OpenAI.QuestionParamChoice value) => new QuestionParam((global::tryAGI.OpenAI.QuestionParamChoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.QuestionParamChoice?(QuestionParam @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public QuestionParam(global::tryAGI.OpenAI.QuestionParamChoice? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuestionParam FromChoice(global::tryAGI.OpenAI.QuestionParamChoice? value) => new QuestionParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator QuestionParam(global::tryAGI.OpenAI.QuestionParamScore value) => new QuestionParam((global::tryAGI.OpenAI.QuestionParamScore?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.QuestionParamScore?(QuestionParam @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public QuestionParam(global::tryAGI.OpenAI.QuestionParamScore? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static QuestionParam FromScore(global::tryAGI.OpenAI.QuestionParamScore? value) => new QuestionParam(value);

        /// <summary>
        ///
        /// </summary>
        public QuestionParam(
            global::tryAGI.OpenAI.QuestionParamDiscriminatorType? type,
            global::tryAGI.OpenAI.QuestionParamPredicate? predicate,
            global::tryAGI.OpenAI.QuestionParamChoice? choice,
            global::tryAGI.OpenAI.QuestionParamScore? score
            )
        {
            Type = type;

            Predicate = predicate;
            Choice = choice;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            Choice as object ??
            Predicate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Predicate?.ToString() ??
            Choice?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPredicate && !IsChoice && !IsScore || !IsPredicate && IsChoice && !IsScore || !IsPredicate && !IsChoice && IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.QuestionParamPredicate, TResult>? predicate = null,
            global::System.Func<global::tryAGI.OpenAI.QuestionParamChoice, TResult>? choice = null,
            global::System.Func<global::tryAGI.OpenAI.QuestionParamScore, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Predicate is { } __value0 && predicate != null)
            {
                return predicate(__value0);
            }
            else if (Choice is { } __value1 && choice != null)
            {
                return choice(__value1);
            }
            else if (Score is { } __value2 && score != null)
            {
                return score(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.QuestionParamPredicate>? predicate = null,

            global::System.Action<global::tryAGI.OpenAI.QuestionParamChoice>? choice = null,

            global::System.Action<global::tryAGI.OpenAI.QuestionParamScore>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Predicate is { } __value0)
            {
                predicate?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.QuestionParamPredicate>? predicate = null,
            global::System.Action<global::tryAGI.OpenAI.QuestionParamChoice>? choice = null,
            global::System.Action<global::tryAGI.OpenAI.QuestionParamScore>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Predicate is { } __value0)
            {
                predicate?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Predicate,
                typeof(global::tryAGI.OpenAI.QuestionParamPredicate),
                Choice,
                typeof(global::tryAGI.OpenAI.QuestionParamChoice),
                Score,
                typeof(global::tryAGI.OpenAI.QuestionParamScore),
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
        public bool Equals(QuestionParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.QuestionParamPredicate?>.Default.Equals(Predicate, other.Predicate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.QuestionParamChoice?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.QuestionParamScore?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(QuestionParam obj1, QuestionParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QuestionParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(QuestionParam obj1, QuestionParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QuestionParam o && Equals(o);
        }
    }
}
