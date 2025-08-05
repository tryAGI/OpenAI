#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The grader used for the fine-tuning job.
    /// </summary>
    public readonly partial struct RunGraderRequestGrader : global::System.IEquatable<RunGraderRequestGrader>
    {
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
        public static implicit operator RunGraderRequestGrader(global::tryAGI.OpenAI.GraderStringCheck value) => new RunGraderRequestGrader((global::tryAGI.OpenAI.GraderStringCheck?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderStringCheck?(RunGraderRequestGrader @this) => @this.StringCheck;

        /// <summary>
        /// 
        /// </summary>
        public RunGraderRequestGrader(global::tryAGI.OpenAI.GraderStringCheck? value)
        {
            StringCheck = value;
        }

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
        public static implicit operator RunGraderRequestGrader(global::tryAGI.OpenAI.GraderTextSimilarity value) => new RunGraderRequestGrader((global::tryAGI.OpenAI.GraderTextSimilarity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderTextSimilarity?(RunGraderRequestGrader @this) => @this.TextSimilarity;

        /// <summary>
        /// 
        /// </summary>
        public RunGraderRequestGrader(global::tryAGI.OpenAI.GraderTextSimilarity? value)
        {
            TextSimilarity = value;
        }

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
        public static implicit operator RunGraderRequestGrader(global::tryAGI.OpenAI.GraderPython value) => new RunGraderRequestGrader((global::tryAGI.OpenAI.GraderPython?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderPython?(RunGraderRequestGrader @this) => @this.Python;

        /// <summary>
        /// 
        /// </summary>
        public RunGraderRequestGrader(global::tryAGI.OpenAI.GraderPython? value)
        {
            Python = value;
        }

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
        public static implicit operator RunGraderRequestGrader(global::tryAGI.OpenAI.GraderScoreModel value) => new RunGraderRequestGrader((global::tryAGI.OpenAI.GraderScoreModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderScoreModel?(RunGraderRequestGrader @this) => @this.ScoreModel;

        /// <summary>
        /// 
        /// </summary>
        public RunGraderRequestGrader(global::tryAGI.OpenAI.GraderScoreModel? value)
        {
            ScoreModel = value;
        }

        /// <summary>
        /// A MultiGrader object combines the output of multiple graders to produce a single score.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderMulti? Multi { get; init; }
#else
        public global::tryAGI.OpenAI.GraderMulti? Multi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Multi))]
#endif
        public bool IsMulti => Multi != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunGraderRequestGrader(global::tryAGI.OpenAI.GraderMulti value) => new RunGraderRequestGrader((global::tryAGI.OpenAI.GraderMulti?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderMulti?(RunGraderRequestGrader @this) => @this.Multi;

        /// <summary>
        /// 
        /// </summary>
        public RunGraderRequestGrader(global::tryAGI.OpenAI.GraderMulti? value)
        {
            Multi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunGraderRequestGrader(
            global::tryAGI.OpenAI.GraderStringCheck? stringCheck,
            global::tryAGI.OpenAI.GraderTextSimilarity? textSimilarity,
            global::tryAGI.OpenAI.GraderPython? python,
            global::tryAGI.OpenAI.GraderScoreModel? scoreModel,
            global::tryAGI.OpenAI.GraderMulti? multi
            )
        {
            StringCheck = stringCheck;
            TextSimilarity = textSimilarity;
            Python = python;
            ScoreModel = scoreModel;
            Multi = multi;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Multi as object ??
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
            Multi?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringCheck || IsTextSimilarity || IsPython || IsScoreModel || IsMulti;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.GraderStringCheck?, TResult>? stringCheck = null,
            global::System.Func<global::tryAGI.OpenAI.GraderTextSimilarity?, TResult>? textSimilarity = null,
            global::System.Func<global::tryAGI.OpenAI.GraderPython?, TResult>? python = null,
            global::System.Func<global::tryAGI.OpenAI.GraderScoreModel?, TResult>? scoreModel = null,
            global::System.Func<global::tryAGI.OpenAI.GraderMulti?, TResult>? multi = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringCheck && stringCheck != null)
            {
                return stringCheck(StringCheck!);
            }
            else if (IsTextSimilarity && textSimilarity != null)
            {
                return textSimilarity(TextSimilarity!);
            }
            else if (IsPython && python != null)
            {
                return python(Python!);
            }
            else if (IsScoreModel && scoreModel != null)
            {
                return scoreModel(ScoreModel!);
            }
            else if (IsMulti && multi != null)
            {
                return multi(Multi!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.GraderStringCheck?>? stringCheck = null,
            global::System.Action<global::tryAGI.OpenAI.GraderTextSimilarity?>? textSimilarity = null,
            global::System.Action<global::tryAGI.OpenAI.GraderPython?>? python = null,
            global::System.Action<global::tryAGI.OpenAI.GraderScoreModel?>? scoreModel = null,
            global::System.Action<global::tryAGI.OpenAI.GraderMulti?>? multi = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringCheck)
            {
                stringCheck?.Invoke(StringCheck!);
            }
            else if (IsTextSimilarity)
            {
                textSimilarity?.Invoke(TextSimilarity!);
            }
            else if (IsPython)
            {
                python?.Invoke(Python!);
            }
            else if (IsScoreModel)
            {
                scoreModel?.Invoke(ScoreModel!);
            }
            else if (IsMulti)
            {
                multi?.Invoke(Multi!);
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
                Multi,
                typeof(global::tryAGI.OpenAI.GraderMulti),
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
        public bool Equals(RunGraderRequestGrader other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderStringCheck?>.Default.Equals(StringCheck, other.StringCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderTextSimilarity?>.Default.Equals(TextSimilarity, other.TextSimilarity) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderPython?>.Default.Equals(Python, other.Python) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderScoreModel?>.Default.Equals(ScoreModel, other.ScoreModel) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderMulti?>.Default.Equals(Multi, other.Multi) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunGraderRequestGrader obj1, RunGraderRequestGrader obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunGraderRequestGrader>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunGraderRequestGrader obj1, RunGraderRequestGrader obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunGraderRequestGrader o && Equals(o);
        }
    }
}
