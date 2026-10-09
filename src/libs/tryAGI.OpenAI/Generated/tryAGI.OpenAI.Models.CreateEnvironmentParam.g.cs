#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for a new prewarmed OpenAI-hosted environment.
    /// </summary>
    public readonly partial struct CreateEnvironmentParam : global::System.IEquatable<CreateEnvironmentParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Provision an OpenAI-hosted environment from inline configuration or a template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? OpenaiHosted { get; init; }
#else
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? OpenaiHosted { get; }
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
            out global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? value)
        {
            value = OpenaiHosted;
            return IsOpenaiHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted PickOpenaiHosted() => OpenaiHosted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenaiHosted' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEnvironmentParam(global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted value) => new CreateEnvironmentParam((global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted?(CreateEnvironmentParam @this) => @this.OpenaiHosted;

        /// <summary>
        ///
        /// </summary>
        public CreateEnvironmentParam(global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? value)
        {
            OpenaiHosted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEnvironmentParam FromOpenaiHosted(global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? value) => new CreateEnvironmentParam(value);

        /// <summary>
        ///
        /// </summary>
        public CreateEnvironmentParam(
            global::tryAGI.OpenAI.CreateEnvironmentParamDiscriminatorType? type,
            global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted? openaiHosted
            )
        {
            Type = type;

            OpenaiHosted = openaiHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenaiHosted as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenaiHosted?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenaiHosted;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted, TResult>? openaiHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenaiHosted is { } __value0 && openaiHosted != null)
            {
                return openaiHosted(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted>? openaiHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenaiHosted is { } __value0)
            {
                openaiHosted?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted>? openaiHosted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenaiHosted is { } __value0)
            {
                openaiHosted?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenaiHosted,
                typeof(global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted),
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
        public bool Equals(CreateEnvironmentParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted?>.Default.Equals(OpenaiHosted, other.OpenaiHosted)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateEnvironmentParam obj1, CreateEnvironmentParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEnvironmentParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateEnvironmentParam obj1, CreateEnvironmentParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEnvironmentParam o && Equals(o);
        }
    }
}
