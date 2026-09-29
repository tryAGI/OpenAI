#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Graders : global::System.IEquatable<Graders>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType? Type { get; }

        /// <summary>
        /// A StringCheckGrader object that performs a string comparison between input and reference using a specified operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderStringCheck? StringCheck { get; init; }
#else
        public global::tryAGI.OpenAI.GraderStringCheck? StringCheck { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringCheck))]
#endif
        public bool IsStringCheck => StringCheck != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStringCheck(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GraderStringCheck? value)
        {
            value = StringCheck;
            return IsStringCheck;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderStringCheck PickStringCheck() => StringCheck is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StringCheck' but the value was {ToString()}.");

        /// <summary>
        /// A TextSimilarityGrader object which grades text based on similarity metrics.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderTextSimilarity? TextSimilarity { get; init; }
#else
        public global::tryAGI.OpenAI.GraderTextSimilarity? TextSimilarity { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextSimilarity))]
#endif
        public bool IsTextSimilarity => TextSimilarity != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextSimilarity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GraderTextSimilarity? value)
        {
            value = TextSimilarity;
            return IsTextSimilarity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderTextSimilarity PickTextSimilarity() => TextSimilarity is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextSimilarity' but the value was {ToString()}.");

        /// <summary>
        /// A PythonGrader object that runs a python script on the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderPython? Python { get; init; }
#else
        public global::tryAGI.OpenAI.GraderPython? Python { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Python))]
#endif
        public bool IsPython => Python != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPython(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GraderPython? value)
        {
            value = Python;
            return IsPython;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderPython PickPython() => Python is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Python' but the value was {ToString()}.");

        /// <summary>
        /// A ScoreModelGrader object that uses a model to assign a score to the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderScoreModel? ScoreModel { get; init; }
#else
        public global::tryAGI.OpenAI.GraderScoreModel? ScoreModel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreModel))]
#endif
        public bool IsScoreModel => ScoreModel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScoreModel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GraderScoreModel? value)
        {
            value = ScoreModel;
            return IsScoreModel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderScoreModel PickScoreModel() => ScoreModel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScoreModel' but the value was {ToString()}.");

        /// <summary>
        /// A LabelModelGrader object which uses a model to assign labels to each item<br/>
        /// in the evaluation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderLabelModel? LabelModel { get; init; }
#else
        public global::tryAGI.OpenAI.GraderLabelModel? LabelModel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabelModel))]
#endif
        public bool IsLabelModel => LabelModel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLabelModel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GraderLabelModel? value)
        {
            value = LabelModel;
            return IsLabelModel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GraderLabelModel PickLabelModel() => LabelModel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LabelModel' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Graders(global::tryAGI.OpenAI.GraderStringCheck value) => new Graders((global::tryAGI.OpenAI.GraderStringCheck?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderStringCheck?(Graders @this) => @this.StringCheck;

        /// <summary>
        ///
        /// </summary>
        public Graders(global::tryAGI.OpenAI.GraderStringCheck? value)
        {
            StringCheck = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Graders FromStringCheck(global::tryAGI.OpenAI.GraderStringCheck? value) => new Graders(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Graders(global::tryAGI.OpenAI.GraderTextSimilarity value) => new Graders((global::tryAGI.OpenAI.GraderTextSimilarity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderTextSimilarity?(Graders @this) => @this.TextSimilarity;

        /// <summary>
        ///
        /// </summary>
        public Graders(global::tryAGI.OpenAI.GraderTextSimilarity? value)
        {
            TextSimilarity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Graders FromTextSimilarity(global::tryAGI.OpenAI.GraderTextSimilarity? value) => new Graders(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Graders(global::tryAGI.OpenAI.GraderPython value) => new Graders((global::tryAGI.OpenAI.GraderPython?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderPython?(Graders @this) => @this.Python;

        /// <summary>
        ///
        /// </summary>
        public Graders(global::tryAGI.OpenAI.GraderPython? value)
        {
            Python = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Graders FromPython(global::tryAGI.OpenAI.GraderPython? value) => new Graders(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Graders(global::tryAGI.OpenAI.GraderScoreModel value) => new Graders((global::tryAGI.OpenAI.GraderScoreModel?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderScoreModel?(Graders @this) => @this.ScoreModel;

        /// <summary>
        ///
        /// </summary>
        public Graders(global::tryAGI.OpenAI.GraderScoreModel? value)
        {
            ScoreModel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Graders FromScoreModel(global::tryAGI.OpenAI.GraderScoreModel? value) => new Graders(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Graders(global::tryAGI.OpenAI.GraderLabelModel value) => new Graders((global::tryAGI.OpenAI.GraderLabelModel?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderLabelModel?(Graders @this) => @this.LabelModel;

        /// <summary>
        ///
        /// </summary>
        public Graders(global::tryAGI.OpenAI.GraderLabelModel? value)
        {
            LabelModel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Graders FromLabelModel(global::tryAGI.OpenAI.GraderLabelModel? value) => new Graders(value);

        /// <summary>
        ///
        /// </summary>
        public Graders(
            global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType? type,
            global::tryAGI.OpenAI.GraderStringCheck? stringCheck,
            global::tryAGI.OpenAI.GraderTextSimilarity? textSimilarity,
            global::tryAGI.OpenAI.GraderPython? python,
            global::tryAGI.OpenAI.GraderScoreModel? scoreModel,
            global::tryAGI.OpenAI.GraderLabelModel? labelModel
            )
        {
            Type = type;

            StringCheck = stringCheck;
            TextSimilarity = textSimilarity;
            Python = python;
            ScoreModel = scoreModel;
            LabelModel = labelModel;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LabelModel as object ??
            ScoreModel as object ??
            Python as object ??
            TextSimilarity as object ??
            StringCheck as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StringCheck?.ToString() ??
            TextSimilarity?.ToString() ??
            Python?.ToString() ??
            ScoreModel?.ToString() ??
            LabelModel?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStringCheck && !IsTextSimilarity && !IsPython && !IsScoreModel && !IsLabelModel || !IsStringCheck && IsTextSimilarity && !IsPython && !IsScoreModel && !IsLabelModel || !IsStringCheck && !IsTextSimilarity && IsPython && !IsScoreModel && !IsLabelModel || !IsStringCheck && !IsTextSimilarity && !IsPython && IsScoreModel && !IsLabelModel || !IsStringCheck && !IsTextSimilarity && !IsPython && !IsScoreModel && IsLabelModel;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.GraderStringCheck, TResult>? stringCheck = null,
            global::System.Func<global::tryAGI.OpenAI.GraderTextSimilarity, TResult>? textSimilarity = null,
            global::System.Func<global::tryAGI.OpenAI.GraderPython, TResult>? python = null,
            global::System.Func<global::tryAGI.OpenAI.GraderScoreModel, TResult>? scoreModel = null,
            global::System.Func<global::tryAGI.OpenAI.GraderLabelModel, TResult>? labelModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StringCheck is { } __value0 && stringCheck != null)
            {
                return stringCheck(__value0);
            }
            else if (TextSimilarity is { } __value1 && textSimilarity != null)
            {
                return textSimilarity(__value1);
            }
            else if (Python is { } __value2 && python != null)
            {
                return python(__value2);
            }
            else if (ScoreModel is { } __value3 && scoreModel != null)
            {
                return scoreModel(__value3);
            }
            else if (LabelModel is { } __value4 && labelModel != null)
            {
                return labelModel(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.GraderStringCheck>? stringCheck = null,

            global::System.Action<global::tryAGI.OpenAI.GraderTextSimilarity>? textSimilarity = null,

            global::System.Action<global::tryAGI.OpenAI.GraderPython>? python = null,

            global::System.Action<global::tryAGI.OpenAI.GraderScoreModel>? scoreModel = null,

            global::System.Action<global::tryAGI.OpenAI.GraderLabelModel>? labelModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StringCheck is { } __value0)
            {
                stringCheck?.Invoke(__value0);
            }
            else if (TextSimilarity is { } __value1)
            {
                textSimilarity?.Invoke(__value1);
            }
            else if (Python is { } __value2)
            {
                python?.Invoke(__value2);
            }
            else if (ScoreModel is { } __value3)
            {
                scoreModel?.Invoke(__value3);
            }
            else if (LabelModel is { } __value4)
            {
                labelModel?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.GraderStringCheck>? stringCheck = null,
            global::System.Action<global::tryAGI.OpenAI.GraderTextSimilarity>? textSimilarity = null,
            global::System.Action<global::tryAGI.OpenAI.GraderPython>? python = null,
            global::System.Action<global::tryAGI.OpenAI.GraderScoreModel>? scoreModel = null,
            global::System.Action<global::tryAGI.OpenAI.GraderLabelModel>? labelModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StringCheck is { } __value0)
            {
                stringCheck?.Invoke(__value0);
            }
            else if (TextSimilarity is { } __value1)
            {
                textSimilarity?.Invoke(__value1);
            }
            else if (Python is { } __value2)
            {
                python?.Invoke(__value2);
            }
            else if (ScoreModel is { } __value3)
            {
                scoreModel?.Invoke(__value3);
            }
            else if (LabelModel is { } __value4)
            {
                labelModel?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringCheck,
                typeof(global::tryAGI.OpenAI.GraderStringCheck),
                TextSimilarity,
                typeof(global::tryAGI.OpenAI.GraderTextSimilarity),
                Python,
                typeof(global::tryAGI.OpenAI.GraderPython),
                ScoreModel,
                typeof(global::tryAGI.OpenAI.GraderScoreModel),
                LabelModel,
                typeof(global::tryAGI.OpenAI.GraderLabelModel),
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
        public bool Equals(Graders other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderStringCheck?>.Default.Equals(StringCheck, other.StringCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderTextSimilarity?>.Default.Equals(TextSimilarity, other.TextSimilarity) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderPython?>.Default.Equals(Python, other.Python) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderScoreModel?>.Default.Equals(ScoreModel, other.ScoreModel) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderLabelModel?>.Default.Equals(LabelModel, other.LabelModel)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Graders obj1, Graders obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Graders>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Graders obj1, Graders obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Graders o && Equals(o);
        }
    }
}
