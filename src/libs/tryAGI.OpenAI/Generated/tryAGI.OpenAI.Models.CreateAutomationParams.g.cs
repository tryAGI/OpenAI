#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Creates an automation without invoking it immediately.
    /// </summary>
    public readonly partial struct CreateAutomationParams : global::System.IEquatable<CreateAutomationParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? Periodic { get; init; }
#else
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? Periodic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Periodic))]
#endif
        public bool IsPeriodic => Periodic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPeriodic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? value)
        {
            value = Periodic;
            return IsPeriodic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsPeriodic PickPeriodic() => Periodic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Periodic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateAutomationParamsOnce? Once { get; init; }
#else
        public global::tryAGI.OpenAI.CreateAutomationParamsOnce? Once { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Once))]
#endif
        public bool IsOnce => Once != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOnce(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CreateAutomationParamsOnce? value)
        {
            value = Once;
            return IsOnce;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateAutomationParamsOnce PickOnce() => Once is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Once' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAutomationParams(global::tryAGI.OpenAI.CreateAutomationParamsPeriodic value) => new CreateAutomationParams((global::tryAGI.OpenAI.CreateAutomationParamsPeriodic?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateAutomationParamsPeriodic?(CreateAutomationParams @this) => @this.Periodic;

        /// <summary>
        ///
        /// </summary>
        public CreateAutomationParams(global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? value)
        {
            Periodic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAutomationParams FromPeriodic(global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? value) => new CreateAutomationParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAutomationParams(global::tryAGI.OpenAI.CreateAutomationParamsOnce value) => new CreateAutomationParams((global::tryAGI.OpenAI.CreateAutomationParamsOnce?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateAutomationParamsOnce?(CreateAutomationParams @this) => @this.Once;

        /// <summary>
        ///
        /// </summary>
        public CreateAutomationParams(global::tryAGI.OpenAI.CreateAutomationParamsOnce? value)
        {
            Once = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAutomationParams FromOnce(global::tryAGI.OpenAI.CreateAutomationParamsOnce? value) => new CreateAutomationParams(value);

        /// <summary>
        ///
        /// </summary>
        public CreateAutomationParams(
            global::tryAGI.OpenAI.CreateAutomationParamsDiscriminatorType? type,
            global::tryAGI.OpenAI.CreateAutomationParamsPeriodic? periodic,
            global::tryAGI.OpenAI.CreateAutomationParamsOnce? once
            )
        {
            Type = type;

            Periodic = periodic;
            Once = once;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Once as object ??
            Periodic as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Periodic?.ToString() ??
            Once?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPeriodic && !IsOnce || !IsPeriodic && IsOnce;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateAutomationParamsPeriodic, TResult>? periodic = null,
            global::System.Func<global::tryAGI.OpenAI.CreateAutomationParamsOnce, TResult>? once = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Periodic is { } __value0 && periodic != null)
            {
                return periodic(__value0);
            }
            else if (Once is { } __value1 && once != null)
            {
                return once(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateAutomationParamsPeriodic>? periodic = null,

            global::System.Action<global::tryAGI.OpenAI.CreateAutomationParamsOnce>? once = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Periodic is { } __value0)
            {
                periodic?.Invoke(__value0);
            }
            else if (Once is { } __value1)
            {
                once?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.CreateAutomationParamsPeriodic>? periodic = null,
            global::System.Action<global::tryAGI.OpenAI.CreateAutomationParamsOnce>? once = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Periodic is { } __value0)
            {
                periodic?.Invoke(__value0);
            }
            else if (Once is { } __value1)
            {
                once?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Periodic,
                typeof(global::tryAGI.OpenAI.CreateAutomationParamsPeriodic),
                Once,
                typeof(global::tryAGI.OpenAI.CreateAutomationParamsOnce),
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
        public bool Equals(CreateAutomationParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateAutomationParamsPeriodic?>.Default.Equals(Periodic, other.Periodic) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateAutomationParamsOnce?>.Default.Equals(Once, other.Once)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateAutomationParams obj1, CreateAutomationParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAutomationParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAutomationParams obj1, CreateAutomationParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAutomationParams o && Equals(o);
        }
    }
}
