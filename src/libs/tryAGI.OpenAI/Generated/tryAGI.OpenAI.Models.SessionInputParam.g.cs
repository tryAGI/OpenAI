#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Input submitted to an existing session.
    /// </summary>
    public readonly partial struct SessionInputParam : global::System.IEquatable<SessionInputParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Adds one or more user messages and starts a turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? AgentSessionInputMessage { get; init; }
#else
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? AgentSessionInputMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionInputMessage))]
#endif
        public bool IsAgentSessionInputMessage => AgentSessionInputMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionInputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? value)
        {
            value = AgentSessionInputMessage;
            return IsAgentSessionInputMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage PickAgentSessionInputMessage() => IsAgentSessionInputMessage
            ? AgentSessionInputMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionInputMessage' but the value was {ToString()}.");

        /// <summary>
        /// Cancels the session's active turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? AgentSessionInputCancel { get; init; }
#else
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? AgentSessionInputCancel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionInputCancel))]
#endif
        public bool IsAgentSessionInputCancel => AgentSessionInputCancel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionInputCancel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? value)
        {
            value = AgentSessionInputCancel;
            return IsAgentSessionInputCancel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel PickAgentSessionInputCancel() => IsAgentSessionInputCancel
            ? AgentSessionInputCancel!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionInputCancel' but the value was {ToString()}.");

        /// <summary>
        /// Submits the result of a function call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? AgentSessionInputToolResult { get; init; }
#else
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? AgentSessionInputToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionInputToolResult))]
#endif
        public bool IsAgentSessionInputToolResult => AgentSessionInputToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionInputToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? value)
        {
            value = AgentSessionInputToolResult;
            return IsAgentSessionInputToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult PickAgentSessionInputToolResult() => IsAgentSessionInputToolResult
            ? AgentSessionInputToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionInputToolResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionInputParam(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage value) => new SessionInputParam((global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage?(SessionInputParam @this) => @this.AgentSessionInputMessage;

        /// <summary>
        ///
        /// </summary>
        public SessionInputParam(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? value)
        {
            AgentSessionInputMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionInputParam FromAgentSessionInputMessage(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? value) => new SessionInputParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionInputParam(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel value) => new SessionInputParam((global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel?(SessionInputParam @this) => @this.AgentSessionInputCancel;

        /// <summary>
        ///
        /// </summary>
        public SessionInputParam(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? value)
        {
            AgentSessionInputCancel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionInputParam FromAgentSessionInputCancel(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? value) => new SessionInputParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionInputParam(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult value) => new SessionInputParam((global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult?(SessionInputParam @this) => @this.AgentSessionInputToolResult;

        /// <summary>
        ///
        /// </summary>
        public SessionInputParam(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? value)
        {
            AgentSessionInputToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionInputParam FromAgentSessionInputToolResult(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? value) => new SessionInputParam(value);

        /// <summary>
        ///
        /// </summary>
        public SessionInputParam(
            global::tryAGI.OpenAI.SessionInputParamDiscriminatorType? type,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? agentSessionInputMessage,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? agentSessionInputCancel,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? agentSessionInputToolResult
            )
        {
            Type = type;

            AgentSessionInputMessage = agentSessionInputMessage;
            AgentSessionInputCancel = agentSessionInputCancel;
            AgentSessionInputToolResult = agentSessionInputToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AgentSessionInputToolResult as object ??
            AgentSessionInputCancel as object ??
            AgentSessionInputMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AgentSessionInputMessage?.ToString() ??
            AgentSessionInputCancel?.ToString() ??
            AgentSessionInputToolResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAgentSessionInputMessage && !IsAgentSessionInputCancel && !IsAgentSessionInputToolResult || !IsAgentSessionInputMessage && IsAgentSessionInputCancel && !IsAgentSessionInputToolResult || !IsAgentSessionInputMessage && !IsAgentSessionInputCancel && IsAgentSessionInputToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage, TResult>? agentSessionInputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel, TResult>? agentSessionInputCancel = null,
            global::System.Func<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult, TResult>? agentSessionInputToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentSessionInputMessage && agentSessionInputMessage != null)
            {
                return agentSessionInputMessage(AgentSessionInputMessage!);
            }
            else if (IsAgentSessionInputCancel && agentSessionInputCancel != null)
            {
                return agentSessionInputCancel(AgentSessionInputCancel!);
            }
            else if (IsAgentSessionInputToolResult && agentSessionInputToolResult != null)
            {
                return agentSessionInputToolResult(AgentSessionInputToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage>? agentSessionInputMessage = null,

            global::System.Action<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel>? agentSessionInputCancel = null,

            global::System.Action<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult>? agentSessionInputToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentSessionInputMessage)
            {
                agentSessionInputMessage?.Invoke(AgentSessionInputMessage!);
            }
            else if (IsAgentSessionInputCancel)
            {
                agentSessionInputCancel?.Invoke(AgentSessionInputCancel!);
            }
            else if (IsAgentSessionInputToolResult)
            {
                agentSessionInputToolResult?.Invoke(AgentSessionInputToolResult!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage>? agentSessionInputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel>? agentSessionInputCancel = null,
            global::System.Action<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult>? agentSessionInputToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentSessionInputMessage)
            {
                agentSessionInputMessage?.Invoke(AgentSessionInputMessage!);
            }
            else if (IsAgentSessionInputCancel)
            {
                agentSessionInputCancel?.Invoke(AgentSessionInputCancel!);
            }
            else if (IsAgentSessionInputToolResult)
            {
                agentSessionInputToolResult?.Invoke(AgentSessionInputToolResult!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentSessionInputMessage,
                typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage),
                AgentSessionInputCancel,
                typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel),
                AgentSessionInputToolResult,
                typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult),
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
        public bool Equals(SessionInputParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage?>.Default.Equals(AgentSessionInputMessage, other.AgentSessionInputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel?>.Default.Equals(AgentSessionInputCancel, other.AgentSessionInputCancel) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult?>.Default.Equals(AgentSessionInputToolResult, other.AgentSessionInputToolResult)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SessionInputParam obj1, SessionInputParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionInputParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SessionInputParam obj1, SessionInputParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionInputParam o && Equals(o);
        }
    }
}
