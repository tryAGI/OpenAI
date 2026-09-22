#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Safe metadata for a skill configured by an environment template.
    /// </summary>
    public readonly partial struct HostedTemplateSkillResource : global::System.IEquatable<HostedTemplateSkillResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A skill resolved afresh from the Skills API whenever a session starts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? SkillReference { get; init; }
#else
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? SkillReference { get; }
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
            out global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? value)
        {
            value = SkillReference;
            return IsSkillReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference PickSkillReference() => IsSkillReference
            ? SkillReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillReference' but the value was {ToString()}.");

        /// <summary>
        /// Safe metadata for an inline skill archive.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? Inline { get; }
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
            out global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateSkillResourceInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedTemplateSkillResource(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference value) => new HostedTemplateSkillResource((global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference?(HostedTemplateSkillResource @this) => @this.SkillReference;

        /// <summary>
        ///
        /// </summary>
        public HostedTemplateSkillResource(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? value)
        {
            SkillReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedTemplateSkillResource FromSkillReference(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? value) => new HostedTemplateSkillResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedTemplateSkillResource(global::tryAGI.OpenAI.HostedTemplateSkillResourceInline value) => new HostedTemplateSkillResource((global::tryAGI.OpenAI.HostedTemplateSkillResourceInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedTemplateSkillResourceInline?(HostedTemplateSkillResource @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedTemplateSkillResource(global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedTemplateSkillResource FromInline(global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? value) => new HostedTemplateSkillResource(value);

        /// <summary>
        ///
        /// </summary>
        public HostedTemplateSkillResource(
            global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference? skillReference,
            global::tryAGI.OpenAI.HostedTemplateSkillResourceInline? inline
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
            global::System.Func<global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference, TResult>? skillReference = null,
            global::System.Func<global::tryAGI.OpenAI.HostedTemplateSkillResourceInline, TResult>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference>? skillReference = null,

            global::System.Action<global::tryAGI.OpenAI.HostedTemplateSkillResourceInline>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference>? skillReference = null,
            global::System.Action<global::tryAGI.OpenAI.HostedTemplateSkillResourceInline>? inline = null,
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
                typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference),
                Inline,
                typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInline),
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
        public bool Equals(HostedTemplateSkillResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference?>.Default.Equals(SkillReference, other.SkillReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedTemplateSkillResourceInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedTemplateSkillResource obj1, HostedTemplateSkillResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedTemplateSkillResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedTemplateSkillResource obj1, HostedTemplateSkillResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedTemplateSkillResource o && Equals(o);
        }
    }
}
