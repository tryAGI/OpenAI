#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionInputMessage : global::System.IEquatable<DecisionInputMessage>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// A user message containing input text, images, or JSON.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputUserMessage? User { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputUserMessage? User { get; }
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
            out global::tryAGI.OpenAI.DecisionInputUserMessage? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputUserMessage PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        /// A developer message containing input text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessage? Developer { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessage? Developer { get; }
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
            out global::tryAGI.OpenAI.DecisionInputDeveloperMessage? value)
        {
            value = Developer;
            return IsDeveloper;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessage PickDeveloper() => Developer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Developer' but the value was {ToString()}.");

        /// <summary>
        /// A system message containing input text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputSystemMessage? System { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputSystemMessage? System { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.DecisionInputSystemMessage? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputSystemMessage PickSystem() => System is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

        /// <summary>
        /// An assistant message containing output text or refusals.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputAssistantMessage? Assistant { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputAssistantMessage? Assistant { get; }
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
            out global::tryAGI.OpenAI.DecisionInputAssistantMessage? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantMessage PickAssistant() => Assistant is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputUserMessage value) => new DecisionInputMessage((global::tryAGI.OpenAI.DecisionInputUserMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputUserMessage?(DecisionInputMessage @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputUserMessage? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputMessage FromUser(global::tryAGI.OpenAI.DecisionInputUserMessage? value) => new DecisionInputMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputDeveloperMessage value) => new DecisionInputMessage((global::tryAGI.OpenAI.DecisionInputDeveloperMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputDeveloperMessage?(DecisionInputMessage @this) => @this.Developer;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputDeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputMessage FromDeveloper(global::tryAGI.OpenAI.DecisionInputDeveloperMessage? value) => new DecisionInputMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputSystemMessage value) => new DecisionInputMessage((global::tryAGI.OpenAI.DecisionInputSystemMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputSystemMessage?(DecisionInputMessage @this) => @this.System;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputSystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputMessage FromSystem(global::tryAGI.OpenAI.DecisionInputSystemMessage? value) => new DecisionInputMessage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputAssistantMessage value) => new DecisionInputMessage((global::tryAGI.OpenAI.DecisionInputAssistantMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputAssistantMessage?(DecisionInputMessage @this) => @this.Assistant;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputMessage(global::tryAGI.OpenAI.DecisionInputAssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputMessage FromAssistant(global::tryAGI.OpenAI.DecisionInputAssistantMessage? value) => new DecisionInputMessage(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputMessage(
            global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole? role,
            global::tryAGI.OpenAI.DecisionInputUserMessage? user,
            global::tryAGI.OpenAI.DecisionInputDeveloperMessage? developer,
            global::tryAGI.OpenAI.DecisionInputSystemMessage? system,
            global::tryAGI.OpenAI.DecisionInputAssistantMessage? assistant
            )
        {
            Role = role;

            User = user;
            Developer = developer;
            System = system;
            Assistant = assistant;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Assistant as object ??
            System as object ??
            Developer as object ??
            User as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            Developer?.ToString() ??
            System?.ToString() ??
            Assistant?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsDeveloper && !IsSystem && !IsAssistant || !IsUser && IsDeveloper && !IsSystem && !IsAssistant || !IsUser && !IsDeveloper && IsSystem && !IsAssistant || !IsUser && !IsDeveloper && !IsSystem && IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.DecisionInputUserMessage, TResult>? user = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputDeveloperMessage, TResult>? developer = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputSystemMessage, TResult>? system = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputAssistantMessage, TResult>? assistant = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0 && user != null)
            {
                return user(__value0);
            }
            else if (Developer is { } __value1 && developer != null)
            {
                return developer(__value1);
            }
            else if (System is { } __value2 && system != null)
            {
                return system(__value2);
            }
            else if (Assistant is { } __value3 && assistant != null)
            {
                return assistant(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputUserMessage>? user = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputDeveloperMessage>? developer = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputSystemMessage>? system = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputAssistantMessage>? assistant = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0)
            {
                user?.Invoke(__value0);
            }
            else if (Developer is { } __value1)
            {
                developer?.Invoke(__value1);
            }
            else if (System is { } __value2)
            {
                system?.Invoke(__value2);
            }
            else if (Assistant is { } __value3)
            {
                assistant?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputUserMessage>? user = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputDeveloperMessage>? developer = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputSystemMessage>? system = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputAssistantMessage>? assistant = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0)
            {
                user?.Invoke(__value0);
            }
            else if (Developer is { } __value1)
            {
                developer?.Invoke(__value1);
            }
            else if (System is { } __value2)
            {
                system?.Invoke(__value2);
            }
            else if (Assistant is { } __value3)
            {
                assistant?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::tryAGI.OpenAI.DecisionInputUserMessage),
                Developer,
                typeof(global::tryAGI.OpenAI.DecisionInputDeveloperMessage),
                System,
                typeof(global::tryAGI.OpenAI.DecisionInputSystemMessage),
                Assistant,
                typeof(global::tryAGI.OpenAI.DecisionInputAssistantMessage),
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
        public bool Equals(DecisionInputMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputUserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputDeveloperMessage?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputSystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputAssistantMessage?>.Default.Equals(Assistant, other.Assistant)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputMessage obj1, DecisionInputMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputMessage obj1, DecisionInputMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputMessage o && Equals(o);
        }
    }
}
