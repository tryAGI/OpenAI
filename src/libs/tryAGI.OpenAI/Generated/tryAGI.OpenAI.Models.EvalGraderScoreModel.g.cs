#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderScoreModel : global::System.IEquatable<EvalGraderScoreModel>
    {
        /// <summary>
        /// A ScoreModelGrader object that uses a model to assign a score to the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderScoreModel? ScoreModelGrader { get; init; }
#else
        public global::tryAGI.OpenAI.GraderScoreModel? ScoreModelGrader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreModelGrader))]
#endif
        public bool IsScoreModelGrader => ScoreModelGrader != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? EvalGraderScoreModelVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? EvalGraderScoreModelVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalGraderScoreModelVariant2))]
#endif
        public bool IsEvalGraderScoreModelVariant2 => EvalGraderScoreModelVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderScoreModel(global::tryAGI.OpenAI.GraderScoreModel value) => new EvalGraderScoreModel((global::tryAGI.OpenAI.GraderScoreModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderScoreModel?(EvalGraderScoreModel @this) => @this.ScoreModelGrader;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderScoreModel(global::tryAGI.OpenAI.GraderScoreModel? value)
        {
            ScoreModelGrader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderScoreModel(global::tryAGI.OpenAI.EvalGraderScoreModelVariant2 value) => new EvalGraderScoreModel((global::tryAGI.OpenAI.EvalGraderScoreModelVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalGraderScoreModelVariant2?(EvalGraderScoreModel @this) => @this.EvalGraderScoreModelVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderScoreModel(global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? value)
        {
            EvalGraderScoreModelVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderScoreModel(
            global::tryAGI.OpenAI.GraderScoreModel? scoreModelGrader,
            global::tryAGI.OpenAI.EvalGraderScoreModelVariant2? evalGraderScoreModelVariant2
            )
        {
            ScoreModelGrader = scoreModelGrader;
            EvalGraderScoreModelVariant2 = evalGraderScoreModelVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EvalGraderScoreModelVariant2 as object ??
            ScoreModelGrader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScoreModelGrader?.ToString() ??
            EvalGraderScoreModelVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScoreModelGrader && IsEvalGraderScoreModelVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.GraderScoreModel?, TResult>? scoreModelGrader = null,
            global::System.Func<global::tryAGI.OpenAI.EvalGraderScoreModelVariant2?, TResult>? evalGraderScoreModelVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreModelGrader && scoreModelGrader != null)
            {
                return scoreModelGrader(ScoreModelGrader!);
            }
            else if (IsEvalGraderScoreModelVariant2 && evalGraderScoreModelVariant2 != null)
            {
                return evalGraderScoreModelVariant2(EvalGraderScoreModelVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.GraderScoreModel?>? scoreModelGrader = null,
            global::System.Action<global::tryAGI.OpenAI.EvalGraderScoreModelVariant2?>? evalGraderScoreModelVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreModelGrader)
            {
                scoreModelGrader?.Invoke(ScoreModelGrader!);
            }
            else if (IsEvalGraderScoreModelVariant2)
            {
                evalGraderScoreModelVariant2?.Invoke(EvalGraderScoreModelVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreModelGrader,
                typeof(global::tryAGI.OpenAI.GraderScoreModel),
                EvalGraderScoreModelVariant2,
                typeof(global::tryAGI.OpenAI.EvalGraderScoreModelVariant2),
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
        public bool Equals(EvalGraderScoreModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderScoreModel?>.Default.Equals(ScoreModelGrader, other.ScoreModelGrader) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalGraderScoreModelVariant2?>.Default.Equals(EvalGraderScoreModelVariant2, other.EvalGraderScoreModelVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderScoreModel obj1, EvalGraderScoreModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderScoreModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderScoreModel obj1, EvalGraderScoreModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderScoreModel o && Equals(o);
        }
    }
}
