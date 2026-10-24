#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// How the automation was created, independently of how an invocation started.
    /// </summary>
    public readonly partial struct AutomationCreatedByResource : global::System.IEquatable<AutomationCreatedByResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? Developer { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? Developer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Developer))]
#endif
        public bool IsDeveloper => Developer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeveloper(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper PickDeveloper() => Developer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Developer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? Agent { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? Agent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgent PickAgent() => Agent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationCreatedByResource(global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper value) => new AutomationCreatedByResource((global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper?(AutomationCreatedByResource @this) => @this.Developer;

        /// <summary>
        ///
        /// </summary>
        public AutomationCreatedByResource(global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? value)
        {
            Developer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationCreatedByResource FromDeveloper(global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? value) => new AutomationCreatedByResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationCreatedByResource(global::tryAGI.OpenAI.AutomationCreatedByResourceAgent value) => new AutomationCreatedByResource((global::tryAGI.OpenAI.AutomationCreatedByResourceAgent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationCreatedByResourceAgent?(AutomationCreatedByResource @this) => @this.Agent;

        /// <summary>
        ///
        /// </summary>
        public AutomationCreatedByResource(global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? value)
        {
            Agent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationCreatedByResource FromAgent(global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? value) => new AutomationCreatedByResource(value);

        /// <summary>
        ///
        /// </summary>
        public AutomationCreatedByResource(
            global::tryAGI.OpenAI.AutomationCreatedByResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper? developer,
            global::tryAGI.OpenAI.AutomationCreatedByResourceAgent? agent
            )
        {
            Type = type;

            Developer = developer;
            Agent = agent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Agent as object ??
            Developer as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Developer?.ToString() ??
            Agent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDeveloper && !IsAgent || !IsDeveloper && IsAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper, TResult>? developer = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationCreatedByResourceAgent, TResult>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Developer is { } __value0 && developer != null)
            {
                return developer(__value0);
            }
            else if (Agent is { } __value1 && agent != null)
            {
                return agent(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper>? developer = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationCreatedByResourceAgent>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Developer is { } __value0)
            {
                developer?.Invoke(__value0);
            }
            else if (Agent is { } __value1)
            {
                agent?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper>? developer = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationCreatedByResourceAgent>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Developer is { } __value0)
            {
                developer?.Invoke(__value0);
            }
            else if (Agent is { } __value1)
            {
                agent?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Developer,
                typeof(global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper),
                Agent,
                typeof(global::tryAGI.OpenAI.AutomationCreatedByResourceAgent),
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
        public bool Equals(AutomationCreatedByResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationCreatedByResourceDeveloper?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationCreatedByResourceAgent?>.Default.Equals(Agent, other.Agent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutomationCreatedByResource obj1, AutomationCreatedByResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomationCreatedByResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutomationCreatedByResource obj1, AutomationCreatedByResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomationCreatedByResource o && Equals(o);
        }
    }
}
