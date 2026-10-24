#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutomationInvocationSourceResource : global::System.IEquatable<AutomationInvocationSourceResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? Manual { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? Manual { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Manual))]
#endif
        public bool IsManual => Manual != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickManual(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? value)
        {
            value = Manual;
            return IsManual;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual PickManual() => Manual is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Manual' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? Automation { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? Automation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Automation))]
#endif
        public bool IsAutomation => Automation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutomation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? value)
        {
            value = Automation;
            return IsAutomation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation PickAutomation() => Automation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Automation' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationInvocationSourceResource(global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual value) => new AutomationInvocationSourceResource((global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual?(AutomationInvocationSourceResource @this) => @this.Manual;

        /// <summary>
        ///
        /// </summary>
        public AutomationInvocationSourceResource(global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? value)
        {
            Manual = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationInvocationSourceResource FromManual(global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? value) => new AutomationInvocationSourceResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationInvocationSourceResource(global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation value) => new AutomationInvocationSourceResource((global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation?(AutomationInvocationSourceResource @this) => @this.Automation;

        /// <summary>
        ///
        /// </summary>
        public AutomationInvocationSourceResource(global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? value)
        {
            Automation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationInvocationSourceResource FromAutomation(global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? value) => new AutomationInvocationSourceResource(value);

        /// <summary>
        ///
        /// </summary>
        public AutomationInvocationSourceResource(
            global::tryAGI.OpenAI.AutomationInvocationSourceResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual? manual,
            global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation? automation
            )
        {
            Type = type;

            Manual = manual;
            Automation = automation;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Automation as object ??
            Manual as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Manual?.ToString() ??
            Automation?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsManual && !IsAutomation || !IsManual && IsAutomation;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual, TResult>? manual = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation, TResult>? automation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Manual is { } __value0 && manual != null)
            {
                return manual(__value0);
            }
            else if (Automation is { } __value1 && automation != null)
            {
                return automation(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual>? manual = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation>? automation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Manual is { } __value0)
            {
                manual?.Invoke(__value0);
            }
            else if (Automation is { } __value1)
            {
                automation?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual>? manual = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation>? automation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Manual is { } __value0)
            {
                manual?.Invoke(__value0);
            }
            else if (Automation is { } __value1)
            {
                automation?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Manual,
                typeof(global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual),
                Automation,
                typeof(global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation),
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
        public bool Equals(AutomationInvocationSourceResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationInvocationSourceResourceManual?>.Default.Equals(Manual, other.Manual) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationInvocationSourceResourceAutomation?>.Default.Equals(Automation, other.Automation)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutomationInvocationSourceResource obj1, AutomationInvocationSourceResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomationInvocationSourceResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutomationInvocationSourceResource obj1, AutomationInvocationSourceResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomationInvocationSourceResource o && Equals(o);
        }
    }
}
