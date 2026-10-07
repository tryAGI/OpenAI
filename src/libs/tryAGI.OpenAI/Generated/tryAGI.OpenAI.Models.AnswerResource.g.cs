#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A completed question always includes its name, including null when unnamed.
    /// </summary>
    public readonly partial struct AnswerResource : global::System.IEquatable<AnswerResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AnswerResourcePredicate? Predicate { get; init; }
#else
        public global::tryAGI.OpenAI.AnswerResourcePredicate? Predicate { get; }
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
            out global::tryAGI.OpenAI.AnswerResourcePredicate? value)
        {
            value = Predicate;
            return IsPredicate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourcePredicate PickPredicate() => Predicate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Predicate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AnswerResourceChoice? Choice { get; init; }
#else
        public global::tryAGI.OpenAI.AnswerResourceChoice? Choice { get; }
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
            out global::tryAGI.OpenAI.AnswerResourceChoice? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceChoice PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AnswerResourceScore? Score { get; init; }
#else
        public global::tryAGI.OpenAI.AnswerResourceScore? Score { get; }
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
            out global::tryAGI.OpenAI.AnswerResourceScore? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceScore PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");

        /// <summary>
        /// The model declined to answer this question. Other questions in the same request can still receive answers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AnswerResourceRefusal? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.AnswerResourceRefusal? Refusal { get; }
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
        public bool TryPickRefusal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AnswerResourceRefusal? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AnswerResourceRefusal PickRefusal() => Refusal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerResource(global::tryAGI.OpenAI.AnswerResourcePredicate value) => new AnswerResource((global::tryAGI.OpenAI.AnswerResourcePredicate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AnswerResourcePredicate?(AnswerResource @this) => @this.Predicate;

        /// <summary>
        ///
        /// </summary>
        public AnswerResource(global::tryAGI.OpenAI.AnswerResourcePredicate? value)
        {
            Predicate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerResource FromPredicate(global::tryAGI.OpenAI.AnswerResourcePredicate? value) => new AnswerResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerResource(global::tryAGI.OpenAI.AnswerResourceChoice value) => new AnswerResource((global::tryAGI.OpenAI.AnswerResourceChoice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AnswerResourceChoice?(AnswerResource @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public AnswerResource(global::tryAGI.OpenAI.AnswerResourceChoice? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerResource FromChoice(global::tryAGI.OpenAI.AnswerResourceChoice? value) => new AnswerResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerResource(global::tryAGI.OpenAI.AnswerResourceScore value) => new AnswerResource((global::tryAGI.OpenAI.AnswerResourceScore?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AnswerResourceScore?(AnswerResource @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public AnswerResource(global::tryAGI.OpenAI.AnswerResourceScore? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerResource FromScore(global::tryAGI.OpenAI.AnswerResourceScore? value) => new AnswerResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnswerResource(global::tryAGI.OpenAI.AnswerResourceRefusal value) => new AnswerResource((global::tryAGI.OpenAI.AnswerResourceRefusal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AnswerResourceRefusal?(AnswerResource @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public AnswerResource(global::tryAGI.OpenAI.AnswerResourceRefusal? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnswerResource FromRefusal(global::tryAGI.OpenAI.AnswerResourceRefusal? value) => new AnswerResource(value);

        /// <summary>
        ///
        /// </summary>
        public AnswerResource(
            global::tryAGI.OpenAI.AnswerResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AnswerResourcePredicate? predicate,
            global::tryAGI.OpenAI.AnswerResourceChoice? choice,
            global::tryAGI.OpenAI.AnswerResourceScore? score,
            global::tryAGI.OpenAI.AnswerResourceRefusal? refusal
            )
        {
            Type = type;

            Predicate = predicate;
            Choice = choice;
            Score = score;
            Refusal = refusal;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Refusal as object ??
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
            Score?.ToString() ??
            Refusal?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPredicate && !IsChoice && !IsScore && !IsRefusal || !IsPredicate && IsChoice && !IsScore && !IsRefusal || !IsPredicate && !IsChoice && IsScore && !IsRefusal || !IsPredicate && !IsChoice && !IsScore && IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AnswerResourcePredicate, TResult>? predicate = null,
            global::System.Func<global::tryAGI.OpenAI.AnswerResourceChoice, TResult>? choice = null,
            global::System.Func<global::tryAGI.OpenAI.AnswerResourceScore, TResult>? score = null,
            global::System.Func<global::tryAGI.OpenAI.AnswerResourceRefusal, TResult>? refusal = null,
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
            else if (Refusal is { } __value3 && refusal != null)
            {
                return refusal(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AnswerResourcePredicate>? predicate = null,

            global::System.Action<global::tryAGI.OpenAI.AnswerResourceChoice>? choice = null,

            global::System.Action<global::tryAGI.OpenAI.AnswerResourceScore>? score = null,

            global::System.Action<global::tryAGI.OpenAI.AnswerResourceRefusal>? refusal = null,
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
            else if (Refusal is { } __value3)
            {
                refusal?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AnswerResourcePredicate>? predicate = null,
            global::System.Action<global::tryAGI.OpenAI.AnswerResourceChoice>? choice = null,
            global::System.Action<global::tryAGI.OpenAI.AnswerResourceScore>? score = null,
            global::System.Action<global::tryAGI.OpenAI.AnswerResourceRefusal>? refusal = null,
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
            else if (Refusal is { } __value3)
            {
                refusal?.Invoke(__value3);
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
                typeof(global::tryAGI.OpenAI.AnswerResourcePredicate),
                Choice,
                typeof(global::tryAGI.OpenAI.AnswerResourceChoice),
                Score,
                typeof(global::tryAGI.OpenAI.AnswerResourceScore),
                Refusal,
                typeof(global::tryAGI.OpenAI.AnswerResourceRefusal),
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
        public bool Equals(AnswerResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AnswerResourcePredicate?>.Default.Equals(Predicate, other.Predicate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AnswerResourceChoice?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AnswerResourceScore?>.Default.Equals(Score, other.Score) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AnswerResourceRefusal?>.Default.Equals(Refusal, other.Refusal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnswerResource obj1, AnswerResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnswerResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnswerResource obj1, AnswerResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnswerResource o && Equals(o);
        }
    }
}
