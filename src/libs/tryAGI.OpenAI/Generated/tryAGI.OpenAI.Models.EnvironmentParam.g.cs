#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The execution environment and optional reusable template for a session.
    /// </summary>
    public readonly partial struct EnvironmentParam : global::System.IEquatable<EnvironmentParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Runs the agent without an execution environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EnvironmentParamNone? None { get; init; }
#else
        public global::tryAGI.OpenAI.EnvironmentParamNone? None { get; }
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
            out global::tryAGI.OpenAI.EnvironmentParamNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamNone PickNone() => None is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// An existing OpenAI-hosted environment or new inline/template-based hosted configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? OpenaiHosted { get; init; }
#else
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? OpenaiHosted { get; }
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
            out global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? value)
        {
            value = OpenaiHosted;
            return IsOpenaiHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted PickOpenaiHosted() => OpenaiHosted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiHosted' but the value was {ToString()}.");

        /// <summary>
        /// An application-hosted environment configured inline.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? SelfHosted { get; init; }
#else
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted? SelfHosted { get; }
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
            out global::tryAGI.OpenAI.EnvironmentParamSelfHosted? value)
        {
            value = SelfHosted;
            return IsSelfHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.EnvironmentParamSelfHosted PickSelfHosted() => SelfHosted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SelfHosted' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentParam(global::tryAGI.OpenAI.EnvironmentParamNone value) => new EnvironmentParam((global::tryAGI.OpenAI.EnvironmentParamNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EnvironmentParamNone?(EnvironmentParam @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentParam(global::tryAGI.OpenAI.EnvironmentParamNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentParam FromNone(global::tryAGI.OpenAI.EnvironmentParamNone? value) => new EnvironmentParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentParam(global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted value) => new EnvironmentParam((global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted?(EnvironmentParam @this) => @this.OpenaiHosted;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentParam(global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? value)
        {
            OpenaiHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentParam FromOpenaiHosted(global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? value) => new EnvironmentParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentParam(global::tryAGI.OpenAI.EnvironmentParamSelfHosted value) => new EnvironmentParam((global::tryAGI.OpenAI.EnvironmentParamSelfHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.EnvironmentParamSelfHosted?(EnvironmentParam @this) => @this.SelfHosted;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentParam(global::tryAGI.OpenAI.EnvironmentParamSelfHosted? value)
        {
            SelfHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentParam FromSelfHosted(global::tryAGI.OpenAI.EnvironmentParamSelfHosted? value) => new EnvironmentParam(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentParam(
            global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType? type,
            global::tryAGI.OpenAI.EnvironmentParamNone? none,
            global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted? openaiHosted,
            global::tryAGI.OpenAI.EnvironmentParamSelfHosted? selfHosted
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
            global::System.Func<global::tryAGI.OpenAI.EnvironmentParamNone, TResult>? none = null,
            global::System.Func<global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted, TResult>? openaiHosted = null,
            global::System.Func<global::tryAGI.OpenAI.EnvironmentParamSelfHosted, TResult>? selfHosted = null,
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
            global::System.Action<global::tryAGI.OpenAI.EnvironmentParamNone>? none = null,

            global::System.Action<global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted>? openaiHosted = null,

            global::System.Action<global::tryAGI.OpenAI.EnvironmentParamSelfHosted>? selfHosted = null,
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
            global::System.Action<global::tryAGI.OpenAI.EnvironmentParamNone>? none = null,
            global::System.Action<global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted>? openaiHosted = null,
            global::System.Action<global::tryAGI.OpenAI.EnvironmentParamSelfHosted>? selfHosted = null,
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
                typeof(global::tryAGI.OpenAI.EnvironmentParamNone),
                OpenaiHosted,
                typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted),
                SelfHosted,
                typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHosted),
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
        public bool Equals(EnvironmentParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EnvironmentParamNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted?>.Default.Equals(OpenaiHosted, other.OpenaiHosted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.EnvironmentParamSelfHosted?>.Default.Equals(SelfHosted, other.SelfHosted)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentParam obj1, EnvironmentParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentParam obj1, EnvironmentParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentParam o && Equals(o);
        }
    }
}
