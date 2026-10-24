#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A saved automation and its schedule.
    /// </summary>
    public readonly partial struct AutomationResource : global::System.IEquatable<AutomationResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Fields shared by periodic and one-time automations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationResourcePeriodic? Periodic { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationResourcePeriodic? Periodic { get; }
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
            out global::tryAGI.OpenAI.AutomationResourcePeriodic? value)
        {
            value = Periodic;
            return IsPeriodic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourcePeriodic PickPeriodic() => Periodic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Periodic' but the value was {ToString()}.");

        /// <summary>
        /// Fields shared by periodic and one-time automations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationResourceOnce? Once { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationResourceOnce? Once { get; }
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
            out global::tryAGI.OpenAI.AutomationResourceOnce? value)
        {
            value = Once;
            return IsOnce;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationResourceOnce PickOnce() => Once is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Once' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationResource(global::tryAGI.OpenAI.AutomationResourcePeriodic value) => new AutomationResource((global::tryAGI.OpenAI.AutomationResourcePeriodic?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationResourcePeriodic?(AutomationResource @this) => @this.Periodic;

        /// <summary>
        ///
        /// </summary>
        public AutomationResource(global::tryAGI.OpenAI.AutomationResourcePeriodic? value)
        {
            Periodic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationResource FromPeriodic(global::tryAGI.OpenAI.AutomationResourcePeriodic? value) => new AutomationResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationResource(global::tryAGI.OpenAI.AutomationResourceOnce value) => new AutomationResource((global::tryAGI.OpenAI.AutomationResourceOnce?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationResourceOnce?(AutomationResource @this) => @this.Once;

        /// <summary>
        ///
        /// </summary>
        public AutomationResource(global::tryAGI.OpenAI.AutomationResourceOnce? value)
        {
            Once = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationResource FromOnce(global::tryAGI.OpenAI.AutomationResourceOnce? value) => new AutomationResource(value);

        /// <summary>
        ///
        /// </summary>
        public AutomationResource(
            global::tryAGI.OpenAI.AutomationResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AutomationResourcePeriodic? periodic,
            global::tryAGI.OpenAI.AutomationResourceOnce? once
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
            global::System.Func<global::tryAGI.OpenAI.AutomationResourcePeriodic, TResult>? periodic = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationResourceOnce, TResult>? once = null,
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
            global::System.Action<global::tryAGI.OpenAI.AutomationResourcePeriodic>? periodic = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationResourceOnce>? once = null,
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
            global::System.Action<global::tryAGI.OpenAI.AutomationResourcePeriodic>? periodic = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationResourceOnce>? once = null,
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
                typeof(global::tryAGI.OpenAI.AutomationResourcePeriodic),
                Once,
                typeof(global::tryAGI.OpenAI.AutomationResourceOnce),
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
        public bool Equals(AutomationResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationResourcePeriodic?>.Default.Equals(Periodic, other.Periodic) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationResourceOnce?>.Default.Equals(Once, other.Once)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutomationResource obj1, AutomationResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomationResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutomationResource obj1, AutomationResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomationResource o && Equals(o);
        }
    }
}
