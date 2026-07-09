#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SkillsItem3 : global::System.IEquatable<SkillsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? SkillReference { get; init; }
#else
        public global::tryAGI.OpenAI.BetaSkillReferenceParam? SkillReference { get; }
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
        public bool TryPickSkillReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaSkillReferenceParam? value)
        {
            value = SkillReference;
            return IsSkillReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaSkillReferenceParam PickSkillReference() => IsSkillReference
            ? SkillReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillReference' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInlineSkillParam? Inline { get; }
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
        public bool TryPickInline(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInlineSkillParam? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaInlineSkillParam PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkillsItem3(global::tryAGI.OpenAI.BetaSkillReferenceParam value) => new SkillsItem3((global::tryAGI.OpenAI.BetaSkillReferenceParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaSkillReferenceParam?(SkillsItem3 @this) => @this.SkillReference;

        /// <summary>
        /// 
        /// </summary>
        public SkillsItem3(global::tryAGI.OpenAI.BetaSkillReferenceParam? value)
        {
            SkillReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SkillsItem3 FromSkillReference(global::tryAGI.OpenAI.BetaSkillReferenceParam? value) => new SkillsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkillsItem3(global::tryAGI.OpenAI.BetaInlineSkillParam value) => new SkillsItem3((global::tryAGI.OpenAI.BetaInlineSkillParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInlineSkillParam?(SkillsItem3 @this) => @this.Inline;

        /// <summary>
        /// 
        /// </summary>
        public SkillsItem3(global::tryAGI.OpenAI.BetaInlineSkillParam? value)
        {
            Inline = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SkillsItem3 FromInline(global::tryAGI.OpenAI.BetaInlineSkillParam? value) => new SkillsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public SkillsItem3(
            global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaSkillReferenceParam? skillReference,
            global::tryAGI.OpenAI.BetaInlineSkillParam? inline
            )
        {
            Type = type;

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
            global::System.Func<global::tryAGI.OpenAI.BetaSkillReferenceParam, TResult>? skillReference = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInlineSkillParam, TResult>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaSkillReferenceParam>? skillReference = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInlineSkillParam>? inline = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaSkillReferenceParam>? skillReference = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInlineSkillParam>? inline = null,
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
                typeof(global::tryAGI.OpenAI.BetaSkillReferenceParam),
                Inline,
                typeof(global::tryAGI.OpenAI.BetaInlineSkillParam),
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
        public bool Equals(SkillsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaSkillReferenceParam?>.Default.Equals(SkillReference, other.SkillReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInlineSkillParam?>.Default.Equals(Inline, other.Inline) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SkillsItem3 obj1, SkillsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SkillsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SkillsItem3 obj1, SkillsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SkillsItem3 o && Equals(o);
        }
    }
}
