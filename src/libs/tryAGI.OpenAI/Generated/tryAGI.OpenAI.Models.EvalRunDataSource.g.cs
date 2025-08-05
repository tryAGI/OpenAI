#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Information about the run's data source.
    /// </summary>
    public readonly partial struct EvalRunDataSource : global::System.IEquatable<EvalRunDataSource>
    {
        /// <summary>
        /// A JsonlRunDataSource object with that specifies a JSONL file that matches the eval 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? CreateJsonl { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? CreateJsonl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateJsonl))]
#endif
        public bool IsCreateJsonl => CreateJsonl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalRunDataSource(global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource value) => new EvalRunDataSource((global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource?(EvalRunDataSource @this) => @this.CreateJsonl;

        /// <summary>
        /// 
        /// </summary>
        public EvalRunDataSource(global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? value)
        {
            CreateJsonl = value;
        }

        /// <summary>
        /// A CompletionsRunDataSource object describing a model sampling configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? CreateCompletions { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? CreateCompletions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateCompletions))]
#endif
        public bool IsCreateCompletions => CreateCompletions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalRunDataSource(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource value) => new EvalRunDataSource((global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource?(EvalRunDataSource @this) => @this.CreateCompletions;

        /// <summary>
        /// 
        /// </summary>
        public EvalRunDataSource(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? value)
        {
            CreateCompletions = value;
        }

        /// <summary>
        /// A ResponsesRunDataSource object describing a model sampling configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? CreateResponses { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? CreateResponses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateResponses))]
#endif
        public bool IsCreateResponses => CreateResponses != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalRunDataSource(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource value) => new EvalRunDataSource((global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource?(EvalRunDataSource @this) => @this.CreateResponses;

        /// <summary>
        /// 
        /// </summary>
        public EvalRunDataSource(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? value)
        {
            CreateResponses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalRunDataSource(
            global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource? createJsonl,
            global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource? createCompletions,
            global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource? createResponses
            )
        {
            CreateJsonl = createJsonl;
            CreateCompletions = createCompletions;
            CreateResponses = createResponses;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateResponses as object ??
            CreateCompletions as object ??
            CreateJsonl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateJsonl?.ToString() ??
            CreateCompletions?.ToString() ??
            CreateResponses?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateJsonl || IsCreateCompletions || IsCreateResponses;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource?, TResult>? createJsonl = null,
            global::System.Func<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource?, TResult>? createCompletions = null,
            global::System.Func<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource?, TResult>? createResponses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateJsonl && createJsonl != null)
            {
                return createJsonl(CreateJsonl!);
            }
            else if (IsCreateCompletions && createCompletions != null)
            {
                return createCompletions(CreateCompletions!);
            }
            else if (IsCreateResponses && createResponses != null)
            {
                return createResponses(CreateResponses!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource?>? createJsonl = null,
            global::System.Action<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource?>? createCompletions = null,
            global::System.Action<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource?>? createResponses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateJsonl)
            {
                createJsonl?.Invoke(CreateJsonl!);
            }
            else if (IsCreateCompletions)
            {
                createCompletions?.Invoke(CreateCompletions!);
            }
            else if (IsCreateResponses)
            {
                createResponses?.Invoke(CreateResponses!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateJsonl,
                typeof(global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource),
                CreateCompletions,
                typeof(global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource),
                CreateResponses,
                typeof(global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource),
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
        public bool Equals(EvalRunDataSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource?>.Default.Equals(CreateJsonl, other.CreateJsonl) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource?>.Default.Equals(CreateCompletions, other.CreateCompletions) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource?>.Default.Equals(CreateResponses, other.CreateResponses) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalRunDataSource obj1, EvalRunDataSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalRunDataSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalRunDataSource obj1, EvalRunDataSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalRunDataSource o && Equals(o);
        }
    }
}
