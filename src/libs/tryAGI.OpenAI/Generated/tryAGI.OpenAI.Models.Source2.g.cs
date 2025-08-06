#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Determines what populates the `item` namespace in the data source.
    /// </summary>
    public readonly partial struct Source2 : global::System.IEquatable<Source2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? EvalJsonlFileContentSource { get; init; }
#else
        public global::tryAGI.OpenAI.EvalJsonlFileContentSource? EvalJsonlFileContentSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalJsonlFileContentSource))]
#endif
        public bool IsEvalJsonlFileContentSource => EvalJsonlFileContentSource != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::tryAGI.OpenAI.EvalJsonlFileContentSource value) => new Source2((global::tryAGI.OpenAI.EvalJsonlFileContentSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalJsonlFileContentSource?(Source2 @this) => @this.EvalJsonlFileContentSource;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::tryAGI.OpenAI.EvalJsonlFileContentSource? value)
        {
            EvalJsonlFileContentSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? EvalJsonlFileIdSource { get; init; }
#else
        public global::tryAGI.OpenAI.EvalJsonlFileIdSource? EvalJsonlFileIdSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalJsonlFileIdSource))]
#endif
        public bool IsEvalJsonlFileIdSource => EvalJsonlFileIdSource != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::tryAGI.OpenAI.EvalJsonlFileIdSource value) => new Source2((global::tryAGI.OpenAI.EvalJsonlFileIdSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalJsonlFileIdSource?(Source2 @this) => @this.EvalJsonlFileIdSource;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::tryAGI.OpenAI.EvalJsonlFileIdSource? value)
        {
            EvalJsonlFileIdSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source2(
            global::tryAGI.OpenAI.EvalJsonlFileContentSource? evalJsonlFileContentSource,
            global::tryAGI.OpenAI.EvalJsonlFileIdSource? evalJsonlFileIdSource
            )
        {
            EvalJsonlFileContentSource = evalJsonlFileContentSource;
            EvalJsonlFileIdSource = evalJsonlFileIdSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EvalJsonlFileIdSource as object ??
            EvalJsonlFileContentSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EvalJsonlFileContentSource?.ToString() ??
            EvalJsonlFileIdSource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvalJsonlFileContentSource || IsEvalJsonlFileIdSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.EvalJsonlFileContentSource?, TResult>? evalJsonlFileContentSource = null,
            global::System.Func<global::tryAGI.OpenAI.EvalJsonlFileIdSource?, TResult>? evalJsonlFileIdSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvalJsonlFileContentSource && evalJsonlFileContentSource != null)
            {
                return evalJsonlFileContentSource(EvalJsonlFileContentSource!);
            }
            else if (IsEvalJsonlFileIdSource && evalJsonlFileIdSource != null)
            {
                return evalJsonlFileIdSource(EvalJsonlFileIdSource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.EvalJsonlFileContentSource?>? evalJsonlFileContentSource = null,
            global::System.Action<global::tryAGI.OpenAI.EvalJsonlFileIdSource?>? evalJsonlFileIdSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvalJsonlFileContentSource)
            {
                evalJsonlFileContentSource?.Invoke(EvalJsonlFileContentSource!);
            }
            else if (IsEvalJsonlFileIdSource)
            {
                evalJsonlFileIdSource?.Invoke(EvalJsonlFileIdSource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EvalJsonlFileContentSource,
                typeof(global::tryAGI.OpenAI.EvalJsonlFileContentSource),
                EvalJsonlFileIdSource,
                typeof(global::tryAGI.OpenAI.EvalJsonlFileIdSource),
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
        public bool Equals(Source2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalJsonlFileContentSource?>.Default.Equals(EvalJsonlFileContentSource, other.EvalJsonlFileContentSource) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalJsonlFileIdSource?>.Default.Equals(EvalJsonlFileIdSource, other.EvalJsonlFileIdSource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source2 obj1, Source2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source2 obj1, Source2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source2 o && Equals(o);
        }
    }
}
