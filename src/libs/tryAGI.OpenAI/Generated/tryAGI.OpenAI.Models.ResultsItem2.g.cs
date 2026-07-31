#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultsItem2 : global::System.IEquatable<ResultsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.C2PAProvenanceResult? C2pa { get; init; }
#else
        public global::tryAGI.OpenAI.C2PAProvenanceResult? C2pa { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(C2pa))]
#endif
        public bool IsC2pa => C2pa != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickC2pa(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.C2PAProvenanceResult? value)
        {
            value = C2pa;
            return IsC2pa;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.C2PAProvenanceResult PickC2pa() => IsC2pa
            ? C2pa!
            : throw new global::System.InvalidOperationException($"Expected union variant 'C2pa' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Synthid { get; init; }
#else
        public global::tryAGI.OpenAI.SynthIDProvenanceResult? Synthid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Synthid))]
#endif
        public bool IsSynthid => Synthid != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSynthid(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SynthIDProvenanceResult? value)
        {
            value = Synthid;
            return IsSynthid;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.SynthIDProvenanceResult PickSynthid() => IsSynthid
            ? Synthid!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Synthid' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem2(global::tryAGI.OpenAI.C2PAProvenanceResult value) => new ResultsItem2((global::tryAGI.OpenAI.C2PAProvenanceResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.C2PAProvenanceResult?(ResultsItem2 @this) => @this.C2pa;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem2(global::tryAGI.OpenAI.C2PAProvenanceResult? value)
        {
            C2pa = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem2 FromC2pa(global::tryAGI.OpenAI.C2PAProvenanceResult? value) => new ResultsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem2(global::tryAGI.OpenAI.SynthIDProvenanceResult value) => new ResultsItem2((global::tryAGI.OpenAI.SynthIDProvenanceResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SynthIDProvenanceResult?(ResultsItem2 @this) => @this.Synthid;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem2(global::tryAGI.OpenAI.SynthIDProvenanceResult? value)
        {
            Synthid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem2 FromSynthid(global::tryAGI.OpenAI.SynthIDProvenanceResult? value) => new ResultsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem2(
            global::tryAGI.OpenAI.ProvenanceResourceResultDiscriminatorType? type,
            global::tryAGI.OpenAI.C2PAProvenanceResult? c2pa,
            global::tryAGI.OpenAI.SynthIDProvenanceResult? synthid
            )
        {
            Type = type;

            C2pa = c2pa;
            Synthid = synthid;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Synthid as object ??
            C2pa as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            C2pa?.ToString() ??
            Synthid?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsC2pa && !IsSynthid || !IsC2pa && IsSynthid;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.C2PAProvenanceResult, TResult>? c2pa = null,
            global::System.Func<global::tryAGI.OpenAI.SynthIDProvenanceResult, TResult>? synthid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsC2pa && c2pa != null)
            {
                return c2pa(C2pa!);
            }
            else if (IsSynthid && synthid != null)
            {
                return synthid(Synthid!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.C2PAProvenanceResult>? c2pa = null,

            global::System.Action<global::tryAGI.OpenAI.SynthIDProvenanceResult>? synthid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsC2pa)
            {
                c2pa?.Invoke(C2pa!);
            }
            else if (IsSynthid)
            {
                synthid?.Invoke(Synthid!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.C2PAProvenanceResult>? c2pa = null,
            global::System.Action<global::tryAGI.OpenAI.SynthIDProvenanceResult>? synthid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsC2pa)
            {
                c2pa?.Invoke(C2pa!);
            }
            else if (IsSynthid)
            {
                synthid?.Invoke(Synthid!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                C2pa,
                typeof(global::tryAGI.OpenAI.C2PAProvenanceResult),
                Synthid,
                typeof(global::tryAGI.OpenAI.SynthIDProvenanceResult),
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
        public bool Equals(ResultsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.C2PAProvenanceResult?>.Default.Equals(C2pa, other.C2pa) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SynthIDProvenanceResult?>.Default.Equals(Synthid, other.Synthid) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultsItem2 obj1, ResultsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultsItem2 obj1, ResultsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultsItem2 o && Equals(o);
        }
    }
}
