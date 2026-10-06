#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SkillsVariant1Item : global::System.IEquatable<SkillsVariant1Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSkillReferenceParam? SkillReference { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSkillReferenceParam? SkillReference { get; }
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
            out global::tryAGI.OpenAI.LiveSkillReferenceParam? value)
        {
            value = SkillReference;
            return IsSkillReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSkillReferenceParam PickSkillReference() => SkillReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillReference' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInlineSkillParam? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInlineSkillParam? Inline { get; }
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
            out global::tryAGI.OpenAI.LiveInlineSkillParam? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInlineSkillParam PickInline() => Inline is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SkillsVariant1Item(global::tryAGI.OpenAI.LiveSkillReferenceParam value) => new SkillsVariant1Item((global::tryAGI.OpenAI.LiveSkillReferenceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSkillReferenceParam?(SkillsVariant1Item @this) => @this.SkillReference;

        /// <summary>
        ///
        /// </summary>
        public SkillsVariant1Item(global::tryAGI.OpenAI.LiveSkillReferenceParam? value)
        {
            SkillReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SkillsVariant1Item FromSkillReference(global::tryAGI.OpenAI.LiveSkillReferenceParam? value) => new SkillsVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SkillsVariant1Item(global::tryAGI.OpenAI.LiveInlineSkillParam value) => new SkillsVariant1Item((global::tryAGI.OpenAI.LiveInlineSkillParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInlineSkillParam?(SkillsVariant1Item @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public SkillsVariant1Item(global::tryAGI.OpenAI.LiveInlineSkillParam? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SkillsVariant1Item FromInline(global::tryAGI.OpenAI.LiveInlineSkillParam? value) => new SkillsVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public SkillsVariant1Item(
            global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveSkillReferenceParam? skillReference,
            global::tryAGI.OpenAI.LiveInlineSkillParam? inline
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
            global::System.Func<global::tryAGI.OpenAI.LiveSkillReferenceParam, TResult>? skillReference = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInlineSkillParam, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SkillReference is { } __value0 && skillReference != null)
            {
                return skillReference(__value0);
            }
            else if (Inline is { } __value1 && inline != null)
            {
                return inline(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveSkillReferenceParam>? skillReference = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInlineSkillParam>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SkillReference is { } __value0)
            {
                skillReference?.Invoke(__value0);
            }
            else if (Inline is { } __value1)
            {
                inline?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveSkillReferenceParam>? skillReference = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInlineSkillParam>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SkillReference is { } __value0)
            {
                skillReference?.Invoke(__value0);
            }
            else if (Inline is { } __value1)
            {
                inline?.Invoke(__value1);
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
                typeof(global::tryAGI.OpenAI.LiveSkillReferenceParam),
                Inline,
                typeof(global::tryAGI.OpenAI.LiveInlineSkillParam),
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
        public bool Equals(SkillsVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSkillReferenceParam?>.Default.Equals(SkillReference, other.SkillReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInlineSkillParam?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SkillsVariant1Item obj1, SkillsVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SkillsVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SkillsVariant1Item obj1, SkillsVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SkillsVariant1Item o && Equals(o);
        }
    }
}
