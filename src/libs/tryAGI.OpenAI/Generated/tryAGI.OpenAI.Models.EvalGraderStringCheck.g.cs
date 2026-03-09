#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderStringCheck : global::System.IEquatable<EvalGraderStringCheck>
    {
        /// <summary>
        /// A StringCheckGrader object that performs a string comparison between input and reference using a specified operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderStringCheck? StringCheckGrader { get; init; }
#else
        public global::tryAGI.OpenAI.GraderStringCheck? StringCheckGrader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringCheckGrader))]
#endif
        public bool IsStringCheckGrader => StringCheckGrader != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderStringCheck(global::tryAGI.OpenAI.GraderStringCheck value) => new EvalGraderStringCheck((global::tryAGI.OpenAI.GraderStringCheck?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderStringCheck?(EvalGraderStringCheck @this) => @this.StringCheckGrader;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderStringCheck(global::tryAGI.OpenAI.GraderStringCheck? value)
        {
            StringCheckGrader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StringCheckGrader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringCheckGrader?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringCheckGrader;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.GraderStringCheck?, TResult>? stringCheckGrader = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringCheckGrader && stringCheckGrader != null)
            {
                return stringCheckGrader(StringCheckGrader!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.GraderStringCheck?>? stringCheckGrader = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringCheckGrader)
            {
                stringCheckGrader?.Invoke(StringCheckGrader!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringCheckGrader,
                typeof(global::tryAGI.OpenAI.GraderStringCheck),
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
        public bool Equals(EvalGraderStringCheck other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderStringCheck?>.Default.Equals(StringCheckGrader, other.StringCheckGrader) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderStringCheck obj1, EvalGraderStringCheck obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderStringCheck>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderStringCheck obj1, EvalGraderStringCheck obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderStringCheck o && Equals(o);
        }
    }
}
