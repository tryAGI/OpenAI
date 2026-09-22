#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A skill installed in an OpenAI-hosted environment.
    /// </summary>
    public readonly partial struct HostedSkillResource : global::System.IEquatable<HostedSkillResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A skill installed from the Skills API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? SkillReference { get; init; }
#else
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference? SkillReference { get; }
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
            out global::tryAGI.OpenAI.HostedSkillResourceSkillReference? value)
        {
            value = SkillReference;
            return IsSkillReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceSkillReference PickSkillReference() => IsSkillReference
            ? SkillReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillReference' but the value was {ToString()}.");

        /// <summary>
        /// A skill installed from an inline ZIP archive.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedSkillResourceInline? Inline { get; }
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
            out global::tryAGI.OpenAI.HostedSkillResourceInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillResourceInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedSkillResource(global::tryAGI.OpenAI.HostedSkillResourceSkillReference value) => new HostedSkillResource((global::tryAGI.OpenAI.HostedSkillResourceSkillReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedSkillResourceSkillReference?(HostedSkillResource @this) => @this.SkillReference;

        /// <summary>
        ///
        /// </summary>
        public HostedSkillResource(global::tryAGI.OpenAI.HostedSkillResourceSkillReference? value)
        {
            SkillReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedSkillResource FromSkillReference(global::tryAGI.OpenAI.HostedSkillResourceSkillReference? value) => new HostedSkillResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedSkillResource(global::tryAGI.OpenAI.HostedSkillResourceInline value) => new HostedSkillResource((global::tryAGI.OpenAI.HostedSkillResourceInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedSkillResourceInline?(HostedSkillResource @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedSkillResource(global::tryAGI.OpenAI.HostedSkillResourceInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedSkillResource FromInline(global::tryAGI.OpenAI.HostedSkillResourceInline? value) => new HostedSkillResource(value);

        /// <summary>
        ///
        /// </summary>
        public HostedSkillResource(
            global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedSkillResourceSkillReference? skillReference,
            global::tryAGI.OpenAI.HostedSkillResourceInline? inline
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
            global::System.Func<global::tryAGI.OpenAI.HostedSkillResourceSkillReference, TResult>? skillReference = null,
            global::System.Func<global::tryAGI.OpenAI.HostedSkillResourceInline, TResult>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedSkillResourceSkillReference>? skillReference = null,

            global::System.Action<global::tryAGI.OpenAI.HostedSkillResourceInline>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedSkillResourceSkillReference>? skillReference = null,
            global::System.Action<global::tryAGI.OpenAI.HostedSkillResourceInline>? inline = null,
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
                typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReference),
                Inline,
                typeof(global::tryAGI.OpenAI.HostedSkillResourceInline),
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
        public bool Equals(HostedSkillResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedSkillResourceSkillReference?>.Default.Equals(SkillReference, other.SkillReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedSkillResourceInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedSkillResource obj1, HostedSkillResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedSkillResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedSkillResource obj1, HostedSkillResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedSkillResource o && Equals(o);
        }
    }
}
