#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestMessage : global::System.IEquatable<ChatCompletionRequestMessage>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// Developer-provided instructions that the model should follow, regardless of<br/>
        /// messages sent by the user. With o1 models and newer, `developer` messages<br/>
        /// replace the previous `system` messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? Developer { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? Developer { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage?(ChatCompletionRequestMessage @this) => @this.Developer;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? value)
        {
            Developer = value;
        }

        /// <summary>
        /// Developer-provided instructions that the model should follow, regardless of<br/>
        /// messages sent by the user. With o1 models and newer, use `developer` messages<br/>
        /// for this purpose instead.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? System { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? System { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage?(ChatCompletionRequestMessage @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// Messages sent by an end user, containing prompts or additional context<br/>
        /// information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? User { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? User { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestUserMessage?(ChatCompletionRequestMessage @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// Messages sent by the model in response to user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? Assistant { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? Assistant { get; }
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
        public static implicit operator ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?(ChatCompletionRequestMessage @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? Tool { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestToolMessage?(ChatCompletionRequestMessage @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? Function { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage value) => new ChatCompletionRequestMessage(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage?(ChatCompletionRequestMessage @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestMessage(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageDiscriminatorRole? role,
            global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage? developer,
            global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage? system,
            global::tryAGI.OpenAI.ChatCompletionRequestUserMessage? user,
            global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage? assistant,
            global::tryAGI.OpenAI.ChatCompletionRequestToolMessage? tool,
            global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage? function
            )
        {
            Role = role;

            Developer = developer;
            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            Tool as object ??
            Assistant as object ??
            User as object ??
            System as object ??
            Developer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeveloper && !IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsDeveloper && IsSystem && !IsUser && !IsAssistant && !IsTool && !IsFunction || !IsDeveloper && !IsSystem && IsUser && !IsAssistant && !IsTool && !IsFunction || !IsDeveloper && !IsSystem && !IsUser && IsAssistant && !IsTool && !IsFunction || !IsDeveloper && !IsSystem && !IsUser && !IsAssistant && IsTool && !IsFunction || !IsDeveloper && !IsSystem && !IsUser && !IsAssistant && !IsTool && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage?, TResult>? developer = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage?, TResult>? system = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestUserMessage?, TResult>? user = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?, TResult>? assistant = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestToolMessage?, TResult>? tool = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage?, TResult>? function = null,
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
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage?>? developer = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage?>? system = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestUserMessage?>? user = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?>? assistant = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestToolMessage?>? tool = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage?>? function = null,
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
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
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
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage),
                System,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage),
                User,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestUserMessage),
                Assistant,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage),
                Tool,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestToolMessage),
                Function,
                typeof(global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage),
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
        public bool Equals(ChatCompletionRequestMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestDeveloperMessage?>.Default.Equals(Developer, other.Developer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestSystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestUserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestToolMessage?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionRequestFunctionMessage?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestMessage obj1, ChatCompletionRequestMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestMessage o && Equals(o);
        }
    }
}
