#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Environment selection saved before an invocation creates its session.
    /// </summary>
    public readonly partial struct AutomationEnvironmentResource : global::System.IEquatable<AutomationEnvironmentResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? None { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? None { get; }
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
            out global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceNone PickNone() => None is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// Hosted environment selection with confidential setup commands and variables omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? OpenaiHosted { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? OpenaiHosted { get; }
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
            out global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? value)
        {
            value = OpenaiHosted;
            return IsOpenaiHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted PickOpenaiHosted() => OpenaiHosted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiHosted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? SelfHosted { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? SelfHosted { get; }
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
            out global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? value)
        {
            value = SelfHosted;
            return IsSelfHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted PickSelfHosted() => SelfHosted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHosted' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationEnvironmentResource(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone value) => new AutomationEnvironmentResource((global::tryAGI.OpenAI.AutomationEnvironmentResourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationEnvironmentResourceNone?(AutomationEnvironmentResource @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public AutomationEnvironmentResource(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationEnvironmentResource FromNone(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? value) => new AutomationEnvironmentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationEnvironmentResource(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted value) => new AutomationEnvironmentResource((global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted?(AutomationEnvironmentResource @this) => @this.OpenaiHosted;

        /// <summary>
        ///
        /// </summary>
        public AutomationEnvironmentResource(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? value)
        {
            OpenaiHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationEnvironmentResource FromOpenaiHosted(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? value) => new AutomationEnvironmentResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationEnvironmentResource(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted value) => new AutomationEnvironmentResource((global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted?(AutomationEnvironmentResource @this) => @this.SelfHosted;

        /// <summary>
        ///
        /// </summary>
        public AutomationEnvironmentResource(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? value)
        {
            SelfHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationEnvironmentResource FromSelfHosted(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? value) => new AutomationEnvironmentResource(value);

        /// <summary>
        ///
        /// </summary>
        public AutomationEnvironmentResource(
            global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? none,
            global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? openaiHosted,
            global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? selfHosted
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
            global::System.Func<global::tryAGI.OpenAI.AutomationEnvironmentResourceNone, TResult>? none = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted, TResult>? openaiHosted = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted, TResult>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (None is { } __value0 && none != null)
            {
                return none(__value0);
            }
            else if (OpenaiHosted is { } __value1 && openaiHosted != null)
            {
                return openaiHosted(__value1);
            }
            else if (SelfHosted is { } __value2 && selfHosted != null)
            {
                return selfHosted(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AutomationEnvironmentResourceNone>? none = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted>? openaiHosted = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (None is { } __value0)
            {
                none?.Invoke(__value0);
            }
            else if (OpenaiHosted is { } __value1)
            {
                openaiHosted?.Invoke(__value1);
            }
            else if (SelfHosted is { } __value2)
            {
                selfHosted?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AutomationEnvironmentResourceNone>? none = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted>? openaiHosted = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted>? selfHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (None is { } __value0)
            {
                none?.Invoke(__value0);
            }
            else if (OpenaiHosted is { } __value1)
            {
                openaiHosted?.Invoke(__value1);
            }
            else if (SelfHosted is { } __value2)
            {
                selfHosted?.Invoke(__value2);
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
                typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone),
                OpenaiHosted,
                typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted),
                SelfHosted,
                typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted),
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
        public bool Equals(AutomationEnvironmentResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationEnvironmentResourceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted?>.Default.Equals(OpenaiHosted, other.OpenaiHosted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted?>.Default.Equals(SelfHosted, other.SelfHosted)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutomationEnvironmentResource obj1, AutomationEnvironmentResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomationEnvironmentResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutomationEnvironmentResource obj1, AutomationEnvironmentResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomationEnvironmentResource o && Equals(o);
        }
    }
}
