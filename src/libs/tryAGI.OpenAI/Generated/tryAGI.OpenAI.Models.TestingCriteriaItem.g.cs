#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestingCriteriaItem : global::System.IEquatable<TestingCriteriaItem>
    {
        /// <summary>
        /// A LabelModelGrader object which uses a model to assign labels to each item<br/>
        /// in the evaluation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalLabelModelGrader? CreateEvalLabelModelGrader { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalLabelModelGrader? CreateEvalLabelModelGrader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateEvalLabelModelGrader))]
#endif
        public bool IsCreateEvalLabelModelGrader => CreateEvalLabelModelGrader != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestingCriteriaItem(global::tryAGI.OpenAI.CreateEvalLabelModelGrader value) => new TestingCriteriaItem((global::tryAGI.OpenAI.CreateEvalLabelModelGrader?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalLabelModelGrader?(TestingCriteriaItem @this) => @this.CreateEvalLabelModelGrader;

        /// <summary>
        /// 
        /// </summary>
        public TestingCriteriaItem(global::tryAGI.OpenAI.CreateEvalLabelModelGrader? value)
        {
            CreateEvalLabelModelGrader = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalGraderStringCheck? EvalGraderStringCheck { get; init; }
#else
        public global::tryAGI.OpenAI.EvalGraderStringCheck? EvalGraderStringCheck { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalGraderStringCheck))]
#endif
        public bool IsEvalGraderStringCheck => EvalGraderStringCheck != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderStringCheck value) => new TestingCriteriaItem((global::tryAGI.OpenAI.EvalGraderStringCheck?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalGraderStringCheck?(TestingCriteriaItem @this) => @this.EvalGraderStringCheck;

        /// <summary>
        /// 
        /// </summary>
        public TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderStringCheck? value)
        {
            EvalGraderStringCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalGraderTextSimilarity? EvalGraderTextSimilarity { get; init; }
#else
        public global::tryAGI.OpenAI.EvalGraderTextSimilarity? EvalGraderTextSimilarity { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalGraderTextSimilarity))]
#endif
        public bool IsEvalGraderTextSimilarity => EvalGraderTextSimilarity != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderTextSimilarity value) => new TestingCriteriaItem((global::tryAGI.OpenAI.EvalGraderTextSimilarity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalGraderTextSimilarity?(TestingCriteriaItem @this) => @this.EvalGraderTextSimilarity;

        /// <summary>
        /// 
        /// </summary>
        public TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderTextSimilarity? value)
        {
            EvalGraderTextSimilarity = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalGraderPython? EvalGraderPython { get; init; }
#else
        public global::tryAGI.OpenAI.EvalGraderPython? EvalGraderPython { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalGraderPython))]
#endif
        public bool IsEvalGraderPython => EvalGraderPython != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderPython value) => new TestingCriteriaItem((global::tryAGI.OpenAI.EvalGraderPython?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalGraderPython?(TestingCriteriaItem @this) => @this.EvalGraderPython;

        /// <summary>
        /// 
        /// </summary>
        public TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderPython? value)
        {
            EvalGraderPython = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalGraderScoreModel? EvalGraderScoreModel { get; init; }
#else
        public global::tryAGI.OpenAI.EvalGraderScoreModel? EvalGraderScoreModel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalGraderScoreModel))]
#endif
        public bool IsEvalGraderScoreModel => EvalGraderScoreModel != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderScoreModel value) => new TestingCriteriaItem((global::tryAGI.OpenAI.EvalGraderScoreModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalGraderScoreModel?(TestingCriteriaItem @this) => @this.EvalGraderScoreModel;

        /// <summary>
        /// 
        /// </summary>
        public TestingCriteriaItem(global::tryAGI.OpenAI.EvalGraderScoreModel? value)
        {
            EvalGraderScoreModel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestingCriteriaItem(
            global::tryAGI.OpenAI.CreateEvalLabelModelGrader? createEvalLabelModelGrader,
            global::tryAGI.OpenAI.EvalGraderStringCheck? evalGraderStringCheck,
            global::tryAGI.OpenAI.EvalGraderTextSimilarity? evalGraderTextSimilarity,
            global::tryAGI.OpenAI.EvalGraderPython? evalGraderPython,
            global::tryAGI.OpenAI.EvalGraderScoreModel? evalGraderScoreModel
            )
        {
            CreateEvalLabelModelGrader = createEvalLabelModelGrader;
            EvalGraderStringCheck = evalGraderStringCheck;
            EvalGraderTextSimilarity = evalGraderTextSimilarity;
            EvalGraderPython = evalGraderPython;
            EvalGraderScoreModel = evalGraderScoreModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EvalGraderScoreModel as object ??
            EvalGraderPython as object ??
            EvalGraderTextSimilarity as object ??
            EvalGraderStringCheck as object ??
            CreateEvalLabelModelGrader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateEvalLabelModelGrader?.ToString() ??
            EvalGraderStringCheck?.ToString() ??
            EvalGraderTextSimilarity?.ToString() ??
            EvalGraderPython?.ToString() ??
            EvalGraderScoreModel?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateEvalLabelModelGrader || IsEvalGraderStringCheck || IsEvalGraderTextSimilarity || IsEvalGraderPython || IsEvalGraderScoreModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateEvalLabelModelGrader?, TResult>? createEvalLabelModelGrader = null,
            global::System.Func<global::tryAGI.OpenAI.EvalGraderStringCheck?, TResult>? evalGraderStringCheck = null,
            global::System.Func<global::tryAGI.OpenAI.EvalGraderTextSimilarity?, TResult>? evalGraderTextSimilarity = null,
            global::System.Func<global::tryAGI.OpenAI.EvalGraderPython?, TResult>? evalGraderPython = null,
            global::System.Func<global::tryAGI.OpenAI.EvalGraderScoreModel?, TResult>? evalGraderScoreModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateEvalLabelModelGrader && createEvalLabelModelGrader != null)
            {
                return createEvalLabelModelGrader(CreateEvalLabelModelGrader!);
            }
            else if (IsEvalGraderStringCheck && evalGraderStringCheck != null)
            {
                return evalGraderStringCheck(EvalGraderStringCheck!);
            }
            else if (IsEvalGraderTextSimilarity && evalGraderTextSimilarity != null)
            {
                return evalGraderTextSimilarity(EvalGraderTextSimilarity!);
            }
            else if (IsEvalGraderPython && evalGraderPython != null)
            {
                return evalGraderPython(EvalGraderPython!);
            }
            else if (IsEvalGraderScoreModel && evalGraderScoreModel != null)
            {
                return evalGraderScoreModel(EvalGraderScoreModel!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateEvalLabelModelGrader?>? createEvalLabelModelGrader = null,
            global::System.Action<global::tryAGI.OpenAI.EvalGraderStringCheck?>? evalGraderStringCheck = null,
            global::System.Action<global::tryAGI.OpenAI.EvalGraderTextSimilarity?>? evalGraderTextSimilarity = null,
            global::System.Action<global::tryAGI.OpenAI.EvalGraderPython?>? evalGraderPython = null,
            global::System.Action<global::tryAGI.OpenAI.EvalGraderScoreModel?>? evalGraderScoreModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateEvalLabelModelGrader)
            {
                createEvalLabelModelGrader?.Invoke(CreateEvalLabelModelGrader!);
            }
            else if (IsEvalGraderStringCheck)
            {
                evalGraderStringCheck?.Invoke(EvalGraderStringCheck!);
            }
            else if (IsEvalGraderTextSimilarity)
            {
                evalGraderTextSimilarity?.Invoke(EvalGraderTextSimilarity!);
            }
            else if (IsEvalGraderPython)
            {
                evalGraderPython?.Invoke(EvalGraderPython!);
            }
            else if (IsEvalGraderScoreModel)
            {
                evalGraderScoreModel?.Invoke(EvalGraderScoreModel!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateEvalLabelModelGrader,
                typeof(global::tryAGI.OpenAI.CreateEvalLabelModelGrader),
                EvalGraderStringCheck,
                typeof(global::tryAGI.OpenAI.EvalGraderStringCheck),
                EvalGraderTextSimilarity,
                typeof(global::tryAGI.OpenAI.EvalGraderTextSimilarity),
                EvalGraderPython,
                typeof(global::tryAGI.OpenAI.EvalGraderPython),
                EvalGraderScoreModel,
                typeof(global::tryAGI.OpenAI.EvalGraderScoreModel),
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
        public bool Equals(TestingCriteriaItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalLabelModelGrader?>.Default.Equals(CreateEvalLabelModelGrader, other.CreateEvalLabelModelGrader) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalGraderStringCheck?>.Default.Equals(EvalGraderStringCheck, other.EvalGraderStringCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalGraderTextSimilarity?>.Default.Equals(EvalGraderTextSimilarity, other.EvalGraderTextSimilarity) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalGraderPython?>.Default.Equals(EvalGraderPython, other.EvalGraderPython) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalGraderScoreModel?>.Default.Equals(EvalGraderScoreModel, other.EvalGraderScoreModel) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestingCriteriaItem obj1, TestingCriteriaItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestingCriteriaItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestingCriteriaItem obj1, TestingCriteriaItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestingCriteriaItem o && Equals(o);
        }
    }
}
