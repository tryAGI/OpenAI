#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The execution environment for a session.
    /// </summary>
    public readonly partial struct EnvironmentResource : global::System.IEquatable<EnvironmentResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// The session talks to CCA without selecting or provisioning an execution environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EnvironmentResourceNone? None { get; init; }
#else
        public global::tryAGI.OpenAI.EnvironmentResourceNone? None { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.EnvironmentResourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// An environment hosted by OpenAI.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? OpenaiHosted { get; init; }
#else
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? OpenaiHosted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenaiHosted))]
#endif
        public bool IsOpenaiHosted => OpenaiHosted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenaiHosted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? value)
        {
            value = OpenaiHosted;
            return IsOpenaiHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted PickOpenaiHosted() => IsOpenaiHosted
            ? OpenaiHosted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiHosted' but the value was {ToString()}.");

        /// <summary>
        /// An environment hosted by the application.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? SelfHosted { get; init; }
#else
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? SelfHosted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SelfHosted))]
#endif
        public bool IsSelfHosted => SelfHosted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSelfHosted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? value)
        {
            value = SelfHosted;
            return IsSelfHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentResourceSelfHosted PickSelfHosted() => IsSelfHosted
            ? SelfHosted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHosted' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentResource(global::tryAGI.OpenAI.EnvironmentResourceNone value) => new EnvironmentResource((global::tryAGI.OpenAI.EnvironmentResourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EnvironmentResourceNone?(EnvironmentResource @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentResource(global::tryAGI.OpenAI.EnvironmentResourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentResource FromNone(global::tryAGI.OpenAI.EnvironmentResourceNone? value) => new EnvironmentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentResource(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted value) => new EnvironmentResource((global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted?(EnvironmentResource @this) => @this.OpenaiHosted;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentResource(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? value)
        {
            OpenaiHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentResource FromOpenaiHosted(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? value) => new EnvironmentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentResource(global::tryAGI.OpenAI.EnvironmentResourceSelfHosted value) => new EnvironmentResource((global::tryAGI.OpenAI.EnvironmentResourceSelfHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EnvironmentResourceSelfHosted?(EnvironmentResource @this) => @this.SelfHosted;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentResource(global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? value)
        {
            SelfHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentResource FromSelfHosted(global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? value) => new EnvironmentResource(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentResource(
            global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.EnvironmentResourceNone? none,
            global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted? openaiHosted,
            global::tryAGI.OpenAI.EnvironmentResourceSelfHosted? selfHosted
            )
        {
            Type = type;

            None = none;
            OpenaiHosted = openaiHosted;
            SelfHosted = selfHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SelfHosted as object ??
            OpenaiHosted as object ??
            None as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            None?.ToString() ??
            OpenaiHosted?.ToString() ??
            SelfHosted?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsOpenaiHosted && !IsSelfHosted || !IsNone && IsOpenaiHosted && !IsSelfHosted || !IsNone && !IsOpenaiHosted && IsSelfHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.EnvironmentResourceNone, TResult>? none = null,
            global::System.Func<global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted, TResult>? openaiHosted = null,
            global::System.Func<global::tryAGI.OpenAI.EnvironmentResourceSelfHosted, TResult>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsOpenaiHosted && openaiHosted != null)
            {
                return openaiHosted(OpenaiHosted!);
            }
            else if (IsSelfHosted && selfHosted != null)
            {
                return selfHosted(SelfHosted!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.EnvironmentResourceNone>? none = null,

            global::System.Action<global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted>? openaiHosted = null,

            global::System.Action<global::tryAGI.OpenAI.EnvironmentResourceSelfHosted>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsOpenaiHosted)
            {
                openaiHosted?.Invoke(OpenaiHosted!);
            }
            else if (IsSelfHosted)
            {
                selfHosted?.Invoke(SelfHosted!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.EnvironmentResourceNone>? none = null,
            global::System.Action<global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted>? openaiHosted = null,
            global::System.Action<global::tryAGI.OpenAI.EnvironmentResourceSelfHosted>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsOpenaiHosted)
            {
                openaiHosted?.Invoke(OpenaiHosted!);
            }
            else if (IsSelfHosted)
            {
                selfHosted?.Invoke(SelfHosted!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                None,
                typeof(global::tryAGI.OpenAI.EnvironmentResourceNone),
                OpenaiHosted,
                typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted),
                SelfHosted,
                typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHosted),
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
        public bool Equals(EnvironmentResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EnvironmentResourceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted?>.Default.Equals(OpenaiHosted, other.OpenaiHosted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EnvironmentResourceSelfHosted?>.Default.Equals(SelfHosted, other.SelfHosted)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentResource obj1, EnvironmentResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentResource obj1, EnvironmentResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentResource o && Equals(o);
        }
    }
}
