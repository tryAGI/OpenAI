#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Determines what populates the `item` namespace in this run's data source.
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? EvalJsonlFileContent { get; init; }
#else
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? EvalJsonlFileContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalJsonlFileContent))]
#endif
        public bool IsEvalJsonlFileContent => EvalJsonlFileContent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::tryAGI.OpenAI.EvalJsonlFileContentSource value) => new Source((global::tryAGI.OpenAI.EvalJsonlFileContentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalJsonlFileContentSource?(Source @this) => @this.EvalJsonlFileContent;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::tryAGI.OpenAI.EvalJsonlFileContentSource? value)
        {
            EvalJsonlFileContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? EvalJsonlFileId { get; init; }
#else
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? EvalJsonlFileId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalJsonlFileId))]
#endif
        public bool IsEvalJsonlFileId => EvalJsonlFileId != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::tryAGI.OpenAI.EvalJsonlFileIdSource value) => new Source((global::tryAGI.OpenAI.EvalJsonlFileIdSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalJsonlFileIdSource?(Source @this) => @this.EvalJsonlFileId;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::tryAGI.OpenAI.EvalJsonlFileIdSource? value)
        {
            EvalJsonlFileId = value;
        }

        /// <summary>
        /// A StoredCompletionsRunDataSource configuration describing a set of filters
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalStoredCompletionsSource? EvalStoredCompletions { get; init; }
#else
        public global::tryAGI.OpenAI.EvalStoredCompletionsSource? EvalStoredCompletions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalStoredCompletions))]
#endif
        public bool IsEvalStoredCompletions => EvalStoredCompletions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::tryAGI.OpenAI.EvalStoredCompletionsSource value) => new Source((global::tryAGI.OpenAI.EvalStoredCompletionsSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalStoredCompletionsSource?(Source @this) => @this.EvalStoredCompletions;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::tryAGI.OpenAI.EvalStoredCompletionsSource? value)
        {
            EvalStoredCompletions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::tryAGI.OpenAI.EvalJsonlFileContentSource? evalJsonlFileContent,
            global::tryAGI.OpenAI.EvalJsonlFileIdSource? evalJsonlFileId,
            global::tryAGI.OpenAI.EvalStoredCompletionsSource? evalStoredCompletions
            )
        {
            EvalJsonlFileContent = evalJsonlFileContent;
            EvalJsonlFileId = evalJsonlFileId;
            EvalStoredCompletions = evalStoredCompletions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EvalStoredCompletions as object ??
            EvalJsonlFileId as object ??
            EvalJsonlFileContent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EvalJsonlFileContent?.ToString() ??
            EvalJsonlFileId?.ToString() ??
            EvalStoredCompletions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvalJsonlFileContent || IsEvalJsonlFileId || IsEvalStoredCompletions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.EvalJsonlFileContentSource?, TResult>? evalJsonlFileContent = null,
            global::System.Func<global::tryAGI.OpenAI.EvalJsonlFileIdSource?, TResult>? evalJsonlFileId = null,
            global::System.Func<global::tryAGI.OpenAI.EvalStoredCompletionsSource?, TResult>? evalStoredCompletions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvalJsonlFileContent && evalJsonlFileContent != null)
            {
                return evalJsonlFileContent(EvalJsonlFileContent!);
            }
            else if (IsEvalJsonlFileId && evalJsonlFileId != null)
            {
                return evalJsonlFileId(EvalJsonlFileId!);
            }
            else if (IsEvalStoredCompletions && evalStoredCompletions != null)
            {
                return evalStoredCompletions(EvalStoredCompletions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.EvalJsonlFileContentSource?>? evalJsonlFileContent = null,
            global::System.Action<global::tryAGI.OpenAI.EvalJsonlFileIdSource?>? evalJsonlFileId = null,
            global::System.Action<global::tryAGI.OpenAI.EvalStoredCompletionsSource?>? evalStoredCompletions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvalJsonlFileContent)
            {
                evalJsonlFileContent?.Invoke(EvalJsonlFileContent!);
            }
            else if (IsEvalJsonlFileId)
            {
                evalJsonlFileId?.Invoke(EvalJsonlFileId!);
            }
            else if (IsEvalStoredCompletions)
            {
                evalStoredCompletions?.Invoke(EvalStoredCompletions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EvalJsonlFileContent,
                typeof(global::tryAGI.OpenAI.EvalJsonlFileContentSource),
                EvalJsonlFileId,
                typeof(global::tryAGI.OpenAI.EvalJsonlFileIdSource),
                EvalStoredCompletions,
                typeof(global::tryAGI.OpenAI.EvalStoredCompletionsSource),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalJsonlFileContentSource?>.Default.Equals(EvalJsonlFileContent, other.EvalJsonlFileContent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalJsonlFileIdSource?>.Default.Equals(EvalJsonlFileId, other.EvalJsonlFileId) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalStoredCompletionsSource?>.Default.Equals(EvalStoredCompletions, other.EvalStoredCompletions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
