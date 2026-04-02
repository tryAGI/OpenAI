#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderPython : global::System.IEquatable<EvalGraderPython>
    {
        /// <summary>
        /// A PythonGrader object that runs a python script on the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GraderPython? PythonGrader { get; init; }
#else
        public global::tryAGI.OpenAI.GraderPython? PythonGrader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PythonGrader))]
#endif
        public bool IsPythonGrader => PythonGrader != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EvalGraderPythonVariant2? EvalGraderPythonVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.EvalGraderPythonVariant2? EvalGraderPythonVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EvalGraderPythonVariant2))]
#endif
        public bool IsEvalGraderPythonVariant2 => EvalGraderPythonVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderPython(global::tryAGI.OpenAI.GraderPython value) => new EvalGraderPython((global::tryAGI.OpenAI.GraderPython?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GraderPython?(EvalGraderPython @this) => @this.PythonGrader;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderPython(global::tryAGI.OpenAI.GraderPython? value)
        {
            PythonGrader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderPython(global::tryAGI.OpenAI.EvalGraderPythonVariant2 value) => new EvalGraderPython((global::tryAGI.OpenAI.EvalGraderPythonVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EvalGraderPythonVariant2?(EvalGraderPython @this) => @this.EvalGraderPythonVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderPython(global::tryAGI.OpenAI.EvalGraderPythonVariant2? value)
        {
            EvalGraderPythonVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderPython(
            global::tryAGI.OpenAI.GraderPython? pythonGrader,
            global::tryAGI.OpenAI.EvalGraderPythonVariant2? evalGraderPythonVariant2
            )
        {
            PythonGrader = pythonGrader;
            EvalGraderPythonVariant2 = evalGraderPythonVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EvalGraderPythonVariant2 as object ??
            PythonGrader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PythonGrader?.ToString() ??
            EvalGraderPythonVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPythonGrader && IsEvalGraderPythonVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.GraderPython?, TResult>? pythonGrader = null,
            global::System.Func<global::tryAGI.OpenAI.EvalGraderPythonVariant2?, TResult>? evalGraderPythonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPythonGrader && pythonGrader != null)
            {
                return pythonGrader(PythonGrader!);
            }
            else if (IsEvalGraderPythonVariant2 && evalGraderPythonVariant2 != null)
            {
                return evalGraderPythonVariant2(EvalGraderPythonVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.GraderPython?>? pythonGrader = null,
            global::System.Action<global::tryAGI.OpenAI.EvalGraderPythonVariant2?>? evalGraderPythonVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPythonGrader)
            {
                pythonGrader?.Invoke(PythonGrader!);
            }
            else if (IsEvalGraderPythonVariant2)
            {
                evalGraderPythonVariant2?.Invoke(EvalGraderPythonVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PythonGrader,
                typeof(global::tryAGI.OpenAI.GraderPython),
                EvalGraderPythonVariant2,
                typeof(global::tryAGI.OpenAI.EvalGraderPythonVariant2),
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
        public bool Equals(EvalGraderPython other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GraderPython?>.Default.Equals(PythonGrader, other.PythonGrader) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EvalGraderPythonVariant2?>.Default.Equals(EvalGraderPythonVariant2, other.EvalGraderPythonVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderPython obj1, EvalGraderPython obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderPython>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderPython obj1, EvalGraderPython obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderPython o && Equals(o);
        }
    }
}
