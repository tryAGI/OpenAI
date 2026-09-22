#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A developer, user, or assistant message supplied as text history before the Live session starts.
    /// </summary>
    public readonly partial struct LiveInitialItem : global::System.IEquatable<LiveInitialItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? Role { get; }

        /// <summary>
        /// A developer message included in the initial text history of a Live session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Developer { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? Developer { get; }
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
            out global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam PickDeveloper() => IsDeveloper
            ? Developer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Developer' but the value was {ToString()}.");

        /// <summary>
        /// A user message included in the initial text history of a Live session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? User { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? User { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialUserMessageItemParam PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// An assistant message included in the initial text history of a Live session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Assistant { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? Assistant { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssistant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam PickAssistant() => IsAssistant
            ? Assistant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveInitialItem(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam value) => new LiveInitialItem((global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam?(LiveInitialItem @this) => @this.Developer;

        /// <summary>
        ///
        /// </summary>
        public LiveInitialItem(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? value)
        {
            Developer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveInitialItem FromDeveloper(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? value) => new LiveInitialItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveInitialItem(global::tryAGI.OpenAI.LiveInitialUserMessageItemParam value) => new LiveInitialItem((global::tryAGI.OpenAI.LiveInitialUserMessageItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInitialUserMessageItemParam?(LiveInitialItem @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public LiveInitialItem(global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveInitialItem FromUser(global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? value) => new LiveInitialItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveInitialItem(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam value) => new LiveInitialItem((global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam?(LiveInitialItem @this) => @this.Assistant;

        /// <summary>
        ///
        /// </summary>
        public LiveInitialItem(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? value)
        {
            Assistant = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveInitialItem FromAssistant(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? value) => new LiveInitialItem(value);

        /// <summary>
        ///
        /// </summary>
        public LiveInitialItem(
            global::tryAGI.OpenAI.LiveInitialItemDiscriminatorRole? role,
            global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam? developer,
            global::tryAGI.OpenAI.LiveInitialUserMessageItemParam? user,
            global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam? assistant
            )
        {
            Role = role;

            Developer = developer;
            User = user;
            Assistant = assistant;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Assistant as object ??
            User as object ??
            Developer as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Developer?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDeveloper && !IsUser && !IsAssistant || !IsDeveloper && IsUser && !IsAssistant || !IsDeveloper && !IsUser && IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam, TResult>? developer = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInitialUserMessageItemParam, TResult>? user = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam, TResult>? assistant = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeveloper && developer != null)
            {
                return developer(Developer!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam>? developer = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInitialUserMessageItemParam>? user = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam>? assistant = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam>? developer = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInitialUserMessageItemParam>? user = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam>? assistant = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeveloper)
            {
                developer?.Invoke(Developer!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
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
                typeof(global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam),
                User,
                typeof(global::tryAGI.OpenAI.LiveInitialUserMessageItemParam),
                Assistant,
                typeof(global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam),
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
        public bool Equals(LiveInitialItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInitialDeveloperMessageItemParam?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInitialUserMessageItemParam?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParam?>.Default.Equals(Assistant, other.Assistant)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveInitialItem obj1, LiveInitialItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveInitialItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveInitialItem obj1, LiveInitialItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveInitialItem o && Equals(o);
        }
    }
}
