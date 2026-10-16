#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LiveDecisionQuestion : global::System.IEquatable<LiveDecisionQuestion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? Choice { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? Choice { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? Predicate { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? Predicate { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? value)
        {
            value = Predicate;
            return IsPredicate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam PickPredicate() => Predicate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Predicate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? Score { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? Score { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionQuestion(global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam value) => new LiveDecisionQuestion((global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam?(LiveDecisionQuestion @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionQuestion(global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionQuestion FromChoice(global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? value) => new LiveDecisionQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionQuestion(global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam value) => new LiveDecisionQuestion((global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam?(LiveDecisionQuestion @this) => @this.Predicate;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionQuestion(global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? value)
        {
            Predicate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionQuestion FromPredicate(global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? value) => new LiveDecisionQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionQuestion(global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam value) => new LiveDecisionQuestion((global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam?(LiveDecisionQuestion @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionQuestion(global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionQuestion FromScore(global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? value) => new LiveDecisionQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionQuestion(
            global::tryAGI.OpenAI.LiveDecisionQuestionDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam? choice,
            global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam? predicate,
            global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam? score
            )
        {
            Type = type;

            Choice = choice;
            Predicate = predicate;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            Predicate as object ??
            Choice as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Choice?.ToString() ??
            Predicate?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChoice && !IsPredicate && !IsScore || !IsChoice && IsPredicate && !IsScore || !IsChoice && !IsPredicate && IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam, TResult>? choice = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam, TResult>? predicate = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0 && choice != null)
            {
                return choice(__value0);
            }
            else if (Predicate is { } __value1 && predicate != null)
            {
                return predicate(__value1);
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam>? choice = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam>? predicate = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0)
            {
                choice?.Invoke(__value0);
            }
            else if (Predicate is { } __value1)
            {
                predicate?.Invoke(__value1);
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam>? choice = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam>? predicate = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0)
            {
                choice?.Invoke(__value0);
            }
            else if (Predicate is { } __value1)
            {
                predicate?.Invoke(__value1);
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
                Choice,
                typeof(global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam),
                Predicate,
                typeof(global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam),
                Score,
                typeof(global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam),
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
        public bool Equals(LiveDecisionQuestion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionChoiceQuestionParam?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionPredicateQuestionParam?>.Default.Equals(Predicate, other.Predicate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionScoreQuestionParam?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveDecisionQuestion obj1, LiveDecisionQuestion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveDecisionQuestion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveDecisionQuestion obj1, LiveDecisionQuestion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveDecisionQuestion o && Equals(o);
        }
    }
}
