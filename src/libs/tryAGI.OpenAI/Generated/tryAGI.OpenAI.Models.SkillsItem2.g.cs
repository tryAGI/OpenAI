#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SkillsItem2 : global::System.IEquatable<SkillsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SkillReferenceParam? SkillReference { get; init; }
#else
        public global::tryAGI.OpenAI.SkillReferenceParam? SkillReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillReference))]
#endif
        public bool IsSkillReference => SkillReference != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InlineSkillParam? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.InlineSkillParam? Inline { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inline))]
#endif
        public bool IsInline => Inline != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkillsItem2(global::tryAGI.OpenAI.SkillReferenceParam value) => new SkillsItem2((global::tryAGI.OpenAI.SkillReferenceParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SkillReferenceParam?(SkillsItem2 @this) => @this.SkillReference;

        /// <summary>
        /// 
        /// </summary>
        public SkillsItem2(global::tryAGI.OpenAI.SkillReferenceParam? value)
        {
            SkillReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkillsItem2(global::tryAGI.OpenAI.InlineSkillParam value) => new SkillsItem2((global::tryAGI.OpenAI.InlineSkillParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InlineSkillParam?(SkillsItem2 @this) => @this.Inline;

        /// <summary>
        /// 
        /// </summary>
        public SkillsItem2(global::tryAGI.OpenAI.InlineSkillParam? value)
        {
            Inline = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SkillsItem2(
            global::tryAGI.OpenAI.SkillReferenceParam? skillReference,
            global::tryAGI.OpenAI.InlineSkillParam? inline
            )
        {
            SkillReference = skillReference;
            Inline = inline;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Inline as object ??
            SkillReference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SkillReference?.ToString() ??
            Inline?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSkillReference && !IsInline || !IsSkillReference && IsInline;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.SkillReferenceParam?, TResult>? skillReference = null,
            global::System.Func<global::tryAGI.OpenAI.InlineSkillParam?, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSkillReference && skillReference != null)
            {
                return skillReference(SkillReference!);
            }
            else if (IsInline && inline != null)
            {
                return inline(Inline!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.SkillReferenceParam?>? skillReference = null,
            global::System.Action<global::tryAGI.OpenAI.InlineSkillParam?>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSkillReference)
            {
                skillReference?.Invoke(SkillReference!);
            }
            else if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SkillReference,
                typeof(global::tryAGI.OpenAI.SkillReferenceParam),
                Inline,
                typeof(global::tryAGI.OpenAI.InlineSkillParam),
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
        public bool Equals(SkillsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SkillReferenceParam?>.Default.Equals(SkillReference, other.SkillReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InlineSkillParam?>.Default.Equals(Inline, other.Inline) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SkillsItem2 obj1, SkillsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SkillsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SkillsItem2 obj1, SkillsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SkillsItem2 o && Equals(o);
        }
    }
}
