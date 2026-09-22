#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A skill installed in an OpenAI-hosted environment.
    /// </summary>
    public readonly partial struct HostedSkillParam : global::System.IEquatable<HostedSkillParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? Type { get; }

        /// <summary>
        /// References a skill uploaded through the Skills API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? SkillReference { get; init; }
#else
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference? SkillReference { get; }
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
            out global::tryAGI.OpenAI.HostedSkillParamSkillReference? value)
        {
            value = SkillReference;
            return IsSkillReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamSkillReference PickSkillReference() => IsSkillReference
            ? SkillReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SkillReference' but the value was {ToString()}.");

        /// <summary>
        /// Supplies a skill ZIP directly in the session request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedSkillParamInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedSkillParamInline? Inline { get; }
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
            out global::tryAGI.OpenAI.HostedSkillParamInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedSkillParamInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedSkillParam(global::tryAGI.OpenAI.HostedSkillParamSkillReference value) => new HostedSkillParam((global::tryAGI.OpenAI.HostedSkillParamSkillReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedSkillParamSkillReference?(HostedSkillParam @this) => @this.SkillReference;

        /// <summary>
        ///
        /// </summary>
        public HostedSkillParam(global::tryAGI.OpenAI.HostedSkillParamSkillReference? value)
        {
            SkillReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedSkillParam FromSkillReference(global::tryAGI.OpenAI.HostedSkillParamSkillReference? value) => new HostedSkillParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedSkillParam(global::tryAGI.OpenAI.HostedSkillParamInline value) => new HostedSkillParam((global::tryAGI.OpenAI.HostedSkillParamInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedSkillParamInline?(HostedSkillParam @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedSkillParam(global::tryAGI.OpenAI.HostedSkillParamInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedSkillParam FromInline(global::tryAGI.OpenAI.HostedSkillParamInline? value) => new HostedSkillParam(value);

        /// <summary>
        ///
        /// </summary>
        public HostedSkillParam(
            global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedSkillParamSkillReference? skillReference,
            global::tryAGI.OpenAI.HostedSkillParamInline? inline
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
            global::System.Func<global::tryAGI.OpenAI.HostedSkillParamSkillReference, TResult>? skillReference = null,
            global::System.Func<global::tryAGI.OpenAI.HostedSkillParamInline, TResult>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedSkillParamSkillReference>? skillReference = null,

            global::System.Action<global::tryAGI.OpenAI.HostedSkillParamInline>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedSkillParamSkillReference>? skillReference = null,
            global::System.Action<global::tryAGI.OpenAI.HostedSkillParamInline>? inline = null,
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
                typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReference),
                Inline,
                typeof(global::tryAGI.OpenAI.HostedSkillParamInline),
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
        public bool Equals(HostedSkillParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedSkillParamSkillReference?>.Default.Equals(SkillReference, other.SkillReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedSkillParamInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedSkillParam obj1, HostedSkillParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedSkillParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedSkillParam obj1, HostedSkillParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedSkillParam o && Equals(o);
        }
    }
}
