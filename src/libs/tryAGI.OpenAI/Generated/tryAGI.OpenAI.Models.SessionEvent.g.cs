#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An event emitted by a Managed Agents session.
    /// </summary>
    public readonly partial struct SessionEvent : global::System.IEquatable<SessionEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Emitted when a turn or session fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventError? Error { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventError? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a hosted session environment is ready to connect.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? AgentSessionEnvironmentReady { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? AgentSessionEnvironmentReady { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionEnvironmentReady))]
#endif
        public bool IsAgentSessionEnvironmentReady => AgentSessionEnvironmentReady != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionEnvironmentReady(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? value)
        {
            value = AgentSessionEnvironmentReady;
            return IsAgentSessionEnvironmentReady;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady PickAgentSessionEnvironmentReady() => IsAgentSessionEnvironmentReady
            ? AgentSessionEnvironmentReady!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionEnvironmentReady' but the value was {ToString()}.");

        /// <summary>
        /// Emitted after a hosted sandbox is replaced. Conversation history survives; changes to the previous sandbox's files and processes do not.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? AgentSessionEnvironmentReset { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? AgentSessionEnvironmentReset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionEnvironmentReset))]
#endif
        public bool IsAgentSessionEnvironmentReset => AgentSessionEnvironmentReset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionEnvironmentReset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? value)
        {
            value = AgentSessionEnvironmentReset;
            return IsAgentSessionEnvironmentReset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset PickAgentSessionEnvironmentReset() => IsAgentSessionEnvironmentReset
            ? AgentSessionEnvironmentReset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionEnvironmentReset' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when command execution produces an output delta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? AgentOutputCommandExecutionOutputDelta { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? AgentOutputCommandExecutionOutputDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentOutputCommandExecutionOutputDelta))]
#endif
        public bool IsAgentOutputCommandExecutionOutputDelta => AgentOutputCommandExecutionOutputDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentOutputCommandExecutionOutputDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? value)
        {
            value = AgentOutputCommandExecutionOutputDelta;
            return IsAgentOutputCommandExecutionOutputDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta PickAgentOutputCommandExecutionOutputDelta() => IsAgentOutputCommandExecutionOutputDelta
            ? AgentOutputCommandExecutionOutputDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentOutputCommandExecutionOutputDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? AgentSessionCreated { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated? AgentSessionCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionCreated))]
#endif
        public bool IsAgentSessionCreated => AgentSessionCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionCreated? value)
        {
            value = AgentSessionCreated;
            return IsAgentSessionCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreated PickAgentSessionCreated() => IsAgentSessionCreated
            ? AgentSessionCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a turn is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? AgentSessionTurnCreated { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? AgentSessionTurnCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnCreated))]
#endif
        public bool IsAgentSessionTurnCreated => AgentSessionTurnCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? value)
        {
            value = AgentSessionTurnCreated;
            return IsAgentSessionTurnCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated PickAgentSessionTurnCreated() => IsAgentSessionTurnCreated
            ? AgentSessionTurnCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a turn starts running.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? AgentSessionTurnInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? AgentSessionTurnInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnInProgress))]
#endif
        public bool IsAgentSessionTurnInProgress => AgentSessionTurnInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? value)
        {
            value = AgentSessionTurnInProgress;
            return IsAgentSessionTurnInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress PickAgentSessionTurnInProgress() => IsAgentSessionTurnInProgress
            ? AgentSessionTurnInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a turn completes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? AgentSessionTurnCompleted { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? AgentSessionTurnCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnCompleted))]
#endif
        public bool IsAgentSessionTurnCompleted => AgentSessionTurnCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? value)
        {
            value = AgentSessionTurnCompleted;
            return IsAgentSessionTurnCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted PickAgentSessionTurnCompleted() => IsAgentSessionTurnCompleted
            ? AgentSessionTurnCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a turn fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? AgentSessionTurnFailed { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? AgentSessionTurnFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnFailed))]
#endif
        public bool IsAgentSessionTurnFailed => AgentSessionTurnFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? value)
        {
            value = AgentSessionTurnFailed;
            return IsAgentSessionTurnFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed PickAgentSessionTurnFailed() => IsAgentSessionTurnFailed
            ? AgentSessionTurnFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a turn is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? AgentSessionTurnCancelled { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? AgentSessionTurnCancelled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnCancelled))]
#endif
        public bool IsAgentSessionTurnCancelled => AgentSessionTurnCancelled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnCancelled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? value)
        {
            value = AgentSessionTurnCancelled;
            return IsAgentSessionTurnCancelled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled PickAgentSessionTurnCancelled() => IsAgentSessionTurnCancelled
            ? AgentSessionTurnCancelled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnCancelled' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an item is added to a turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? AgentSessionTurnItemAdded { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? AgentSessionTurnItemAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnItemAdded))]
#endif
        public bool IsAgentSessionTurnItemAdded => AgentSessionTurnItemAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? value)
        {
            value = AgentSessionTurnItemAdded;
            return IsAgentSessionTurnItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded PickAgentSessionTurnItemAdded() => IsAgentSessionTurnItemAdded
            ? AgentSessionTurnItemAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnItemAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session becomes idle.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? AgentSessionIdle { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle? AgentSessionIdle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionIdle))]
#endif
        public bool IsAgentSessionIdle => AgentSessionIdle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionIdle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionIdle? value)
        {
            value = AgentSessionIdle;
            return IsAgentSessionIdle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdle PickAgentSessionIdle() => IsAgentSessionIdle
            ? AgentSessionIdle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionIdle' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session starts processing a turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? AgentSessionInProgress { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? AgentSessionInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionInProgress))]
#endif
        public bool IsAgentSessionInProgress => AgentSessionInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? value)
        {
            value = AgentSessionInProgress;
            return IsAgentSessionInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgress PickAgentSessionInProgress() => IsAgentSessionInProgress
            ? AgentSessionInProgress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session is waiting for one or more required actions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? AgentSessionRequiresAction { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? AgentSessionRequiresAction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionRequiresAction))]
#endif
        public bool IsAgentSessionRequiresAction => AgentSessionRequiresAction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionRequiresAction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? value)
        {
            value = AgentSessionRequiresAction;
            return IsAgentSessionRequiresAction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction PickAgentSessionRequiresAction() => IsAgentSessionRequiresAction
            ? AgentSessionRequiresAction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionRequiresAction' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? AgentSessionFailed { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed? AgentSessionFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionFailed))]
#endif
        public bool IsAgentSessionFailed => AgentSessionFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionFailed? value)
        {
            value = AgentSessionFailed;
            return IsAgentSessionFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailed PickAgentSessionFailed() => IsAgentSessionFailed
            ? AgentSessionFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted while a session environment is being prepared.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? AgentSessionEnvironmentPending { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? AgentSessionEnvironmentPending { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionEnvironmentPending))]
#endif
        public bool IsAgentSessionEnvironmentPending => AgentSessionEnvironmentPending != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionEnvironmentPending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? value)
        {
            value = AgentSessionEnvironmentPending;
            return IsAgentSessionEnvironmentPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending PickAgentSessionEnvironmentPending() => IsAgentSessionEnvironmentPending
            ? AgentSessionEnvironmentPending!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionEnvironmentPending' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session environment connects.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? AgentSessionEnvironmentConnected { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? AgentSessionEnvironmentConnected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionEnvironmentConnected))]
#endif
        public bool IsAgentSessionEnvironmentConnected => AgentSessionEnvironmentConnected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionEnvironmentConnected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? value)
        {
            value = AgentSessionEnvironmentConnected;
            return IsAgentSessionEnvironmentConnected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected PickAgentSessionEnvironmentConnected() => IsAgentSessionEnvironmentConnected
            ? AgentSessionEnvironmentConnected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionEnvironmentConnected' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session environment disconnects.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? AgentSessionEnvironmentDisconnected { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? AgentSessionEnvironmentDisconnected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionEnvironmentDisconnected))]
#endif
        public bool IsAgentSessionEnvironmentDisconnected => AgentSessionEnvironmentDisconnected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionEnvironmentDisconnected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? value)
        {
            value = AgentSessionEnvironmentDisconnected;
            return IsAgentSessionEnvironmentDisconnected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected PickAgentSessionEnvironmentDisconnected() => IsAgentSessionEnvironmentDisconnected
            ? AgentSessionEnvironmentDisconnected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionEnvironmentDisconnected' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a session environment fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? AgentSessionEnvironmentFailed { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? AgentSessionEnvironmentFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionEnvironmentFailed))]
#endif
        public bool IsAgentSessionEnvironmentFailed => AgentSessionEnvironmentFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionEnvironmentFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? value)
        {
            value = AgentSessionEnvironmentFailed;
            return IsAgentSessionEnvironmentFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed PickAgentSessionEnvironmentFailed() => IsAgentSessionEnvironmentFailed
            ? AgentSessionEnvironmentFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionEnvironmentFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a subagent is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? AgentSessionSubagentCreated { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? AgentSessionSubagentCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionSubagentCreated))]
#endif
        public bool IsAgentSessionSubagentCreated => AgentSessionSubagentCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionSubagentCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? value)
        {
            value = AgentSessionSubagentCreated;
            return IsAgentSessionSubagentCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated PickAgentSessionSubagentCreated() => IsAgentSessionSubagentCreated
            ? AgentSessionSubagentCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionSubagentCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a closed subagent successfully resumes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? AgentSessionSubagentActive { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? AgentSessionSubagentActive { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionSubagentActive))]
#endif
        public bool IsAgentSessionSubagentActive => AgentSessionSubagentActive != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionSubagentActive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? value)
        {
            value = AgentSessionSubagentActive;
            return IsAgentSessionSubagentActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive PickAgentSessionSubagentActive() => IsAgentSessionSubagentActive
            ? AgentSessionSubagentActive!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionSubagentActive' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a subagent is closed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? AgentSessionSubagentClosed { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? AgentSessionSubagentClosed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionSubagentClosed))]
#endif
        public bool IsAgentSessionSubagentClosed => AgentSessionSubagentClosed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionSubagentClosed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? value)
        {
            value = AgentSessionSubagentClosed;
            return IsAgentSessionSubagentClosed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed PickAgentSessionSubagentClosed() => IsAgentSessionSubagentClosed
            ? AgentSessionSubagentClosed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionSubagentClosed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output item is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? AgentSessionTurnItemDone { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? AgentSessionTurnItemDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnItemDone))]
#endif
        public bool IsAgentSessionTurnItemDone => AgentSessionTurnItemDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? value)
        {
            value = AgentSessionTurnItemDone;
            return IsAgentSessionTurnItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone PickAgentSessionTurnItemDone() => IsAgentSessionTurnItemDone
            ? AgentSessionTurnItemDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnItemDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output text content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? AgentSessionTurnContentPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? AgentSessionTurnContentPartAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnContentPartAdded))]
#endif
        public bool IsAgentSessionTurnContentPartAdded => AgentSessionTurnContentPartAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? value)
        {
            value = AgentSessionTurnContentPartAdded;
            return IsAgentSessionTurnContentPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded PickAgentSessionTurnContentPartAdded() => IsAgentSessionTurnContentPartAdded
            ? AgentSessionTurnContentPartAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnContentPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output content part is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? AgentSessionTurnContentPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? AgentSessionTurnContentPartDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnContentPartDone))]
#endif
        public bool IsAgentSessionTurnContentPartDone => AgentSessionTurnContentPartDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? value)
        {
            value = AgentSessionTurnContentPartDone;
            return IsAgentSessionTurnContentPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone PickAgentSessionTurnContentPartDone() => IsAgentSessionTurnContentPartDone
            ? AgentSessionTurnContentPartDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnContentPartDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when text is appended to an output text content part.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? AgentSessionTurnOutputTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? AgentSessionTurnOutputTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnOutputTextDelta))]
#endif
        public bool IsAgentSessionTurnOutputTextDelta => AgentSessionTurnOutputTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? value)
        {
            value = AgentSessionTurnOutputTextDelta;
            return IsAgentSessionTurnOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta PickAgentSessionTurnOutputTextDelta() => IsAgentSessionTurnOutputTextDelta
            ? AgentSessionTurnOutputTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnOutputTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output text content part is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? AgentSessionTurnOutputTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? AgentSessionTurnOutputTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnOutputTextDone))]
#endif
        public bool IsAgentSessionTurnOutputTextDone => AgentSessionTurnOutputTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? value)
        {
            value = AgentSessionTurnOutputTextDone;
            return IsAgentSessionTurnOutputTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone PickAgentSessionTurnOutputTextDone() => IsAgentSessionTurnOutputTextDone
            ? AgentSessionTurnOutputTextDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnOutputTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary content part is added.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? AgentSessionTurnReasoningSummaryPartAdded { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? AgentSessionTurnReasoningSummaryPartAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnReasoningSummaryPartAdded))]
#endif
        public bool IsAgentSessionTurnReasoningSummaryPartAdded => AgentSessionTurnReasoningSummaryPartAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnReasoningSummaryPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? value)
        {
            value = AgentSessionTurnReasoningSummaryPartAdded;
            return IsAgentSessionTurnReasoningSummaryPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded PickAgentSessionTurnReasoningSummaryPartAdded() => IsAgentSessionTurnReasoningSummaryPartAdded
            ? AgentSessionTurnReasoningSummaryPartAdded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnReasoningSummaryPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary part is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? AgentSessionTurnReasoningSummaryPartDone { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? AgentSessionTurnReasoningSummaryPartDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnReasoningSummaryPartDone))]
#endif
        public bool IsAgentSessionTurnReasoningSummaryPartDone => AgentSessionTurnReasoningSummaryPartDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnReasoningSummaryPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? value)
        {
            value = AgentSessionTurnReasoningSummaryPartDone;
            return IsAgentSessionTurnReasoningSummaryPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone PickAgentSessionTurnReasoningSummaryPartDone() => IsAgentSessionTurnReasoningSummaryPartDone
            ? AgentSessionTurnReasoningSummaryPartDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnReasoningSummaryPartDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when text is appended to a reasoning summary.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? AgentSessionTurnReasoningSummaryTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? AgentSessionTurnReasoningSummaryTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnReasoningSummaryTextDelta))]
#endif
        public bool IsAgentSessionTurnReasoningSummaryTextDelta => AgentSessionTurnReasoningSummaryTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnReasoningSummaryTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? value)
        {
            value = AgentSessionTurnReasoningSummaryTextDelta;
            return IsAgentSessionTurnReasoningSummaryTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta PickAgentSessionTurnReasoningSummaryTextDelta() => IsAgentSessionTurnReasoningSummaryTextDelta
            ? AgentSessionTurnReasoningSummaryTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnReasoningSummaryTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a reasoning summary content part is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? AgentSessionTurnReasoningSummaryTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? AgentSessionTurnReasoningSummaryTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentSessionTurnReasoningSummaryTextDone))]
#endif
        public bool IsAgentSessionTurnReasoningSummaryTextDone => AgentSessionTurnReasoningSummaryTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentSessionTurnReasoningSummaryTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? value)
        {
            value = AgentSessionTurnReasoningSummaryTextDone;
            return IsAgentSessionTurnReasoningSummaryTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone PickAgentSessionTurnReasoningSummaryTextDone() => IsAgentSessionTurnReasoningSummaryTextDone
            ? AgentSessionTurnReasoningSummaryTextDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentSessionTurnReasoningSummaryTextDone' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventError value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventError?(SessionEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromError(global::tryAGI.OpenAI.SessionEventError? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady?(SessionEvent @this) => @this.AgentSessionEnvironmentReady;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? value)
        {
            AgentSessionEnvironmentReady = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionEnvironmentReady(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset?(SessionEvent @this) => @this.AgentSessionEnvironmentReset;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? value)
        {
            AgentSessionEnvironmentReset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionEnvironmentReset(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta?(SessionEvent @this) => @this.AgentOutputCommandExecutionOutputDelta;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? value)
        {
            AgentOutputCommandExecutionOutputDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentOutputCommandExecutionOutputDelta(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionCreated value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionCreated?(SessionEvent @this) => @this.AgentSessionCreated;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionCreated? value)
        {
            AgentSessionCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionCreated(global::tryAGI.OpenAI.SessionEventAgentSessionCreated? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated?(SessionEvent @this) => @this.AgentSessionTurnCreated;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? value)
        {
            AgentSessionTurnCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnCreated(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress?(SessionEvent @this) => @this.AgentSessionTurnInProgress;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? value)
        {
            AgentSessionTurnInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnInProgress(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted?(SessionEvent @this) => @this.AgentSessionTurnCompleted;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? value)
        {
            AgentSessionTurnCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnCompleted(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed?(SessionEvent @this) => @this.AgentSessionTurnFailed;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? value)
        {
            AgentSessionTurnFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnFailed(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled?(SessionEvent @this) => @this.AgentSessionTurnCancelled;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? value)
        {
            AgentSessionTurnCancelled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnCancelled(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded?(SessionEvent @this) => @this.AgentSessionTurnItemAdded;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? value)
        {
            AgentSessionTurnItemAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnItemAdded(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionIdle value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionIdle?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionIdle?(SessionEvent @this) => @this.AgentSessionIdle;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionIdle? value)
        {
            AgentSessionIdle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionIdle(global::tryAGI.OpenAI.SessionEventAgentSessionIdle? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionInProgress?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionInProgress?(SessionEvent @this) => @this.AgentSessionInProgress;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? value)
        {
            AgentSessionInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionInProgress(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction?(SessionEvent @this) => @this.AgentSessionRequiresAction;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? value)
        {
            AgentSessionRequiresAction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionRequiresAction(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionFailed value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionFailed?(SessionEvent @this) => @this.AgentSessionFailed;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionFailed? value)
        {
            AgentSessionFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionFailed(global::tryAGI.OpenAI.SessionEventAgentSessionFailed? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending?(SessionEvent @this) => @this.AgentSessionEnvironmentPending;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? value)
        {
            AgentSessionEnvironmentPending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionEnvironmentPending(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected?(SessionEvent @this) => @this.AgentSessionEnvironmentConnected;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? value)
        {
            AgentSessionEnvironmentConnected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionEnvironmentConnected(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected?(SessionEvent @this) => @this.AgentSessionEnvironmentDisconnected;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? value)
        {
            AgentSessionEnvironmentDisconnected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionEnvironmentDisconnected(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed?(SessionEvent @this) => @this.AgentSessionEnvironmentFailed;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? value)
        {
            AgentSessionEnvironmentFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionEnvironmentFailed(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated?(SessionEvent @this) => @this.AgentSessionSubagentCreated;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? value)
        {
            AgentSessionSubagentCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionSubagentCreated(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive?(SessionEvent @this) => @this.AgentSessionSubagentActive;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? value)
        {
            AgentSessionSubagentActive = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionSubagentActive(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed?(SessionEvent @this) => @this.AgentSessionSubagentClosed;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? value)
        {
            AgentSessionSubagentClosed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionSubagentClosed(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone?(SessionEvent @this) => @this.AgentSessionTurnItemDone;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? value)
        {
            AgentSessionTurnItemDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnItemDone(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded?(SessionEvent @this) => @this.AgentSessionTurnContentPartAdded;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? value)
        {
            AgentSessionTurnContentPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnContentPartAdded(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone?(SessionEvent @this) => @this.AgentSessionTurnContentPartDone;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? value)
        {
            AgentSessionTurnContentPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnContentPartDone(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta?(SessionEvent @this) => @this.AgentSessionTurnOutputTextDelta;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? value)
        {
            AgentSessionTurnOutputTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnOutputTextDelta(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone?(SessionEvent @this) => @this.AgentSessionTurnOutputTextDone;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? value)
        {
            AgentSessionTurnOutputTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnOutputTextDone(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded?(SessionEvent @this) => @this.AgentSessionTurnReasoningSummaryPartAdded;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? value)
        {
            AgentSessionTurnReasoningSummaryPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnReasoningSummaryPartAdded(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone?(SessionEvent @this) => @this.AgentSessionTurnReasoningSummaryPartDone;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? value)
        {
            AgentSessionTurnReasoningSummaryPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnReasoningSummaryPartDone(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta?(SessionEvent @this) => @this.AgentSessionTurnReasoningSummaryTextDelta;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? value)
        {
            AgentSessionTurnReasoningSummaryTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnReasoningSummaryTextDelta(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone value) => new SessionEvent((global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone?(SessionEvent @this) => @this.AgentSessionTurnReasoningSummaryTextDone;

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? value)
        {
            AgentSessionTurnReasoningSummaryTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionEvent FromAgentSessionTurnReasoningSummaryTextDone(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? value) => new SessionEvent(value);

        /// <summary>
        ///
        /// </summary>
        public SessionEvent(
            global::tryAGI.OpenAI.SessionEventDiscriminatorType? type,
            global::tryAGI.OpenAI.SessionEventError? error,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? agentSessionEnvironmentReady,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? agentSessionEnvironmentReset,
            global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? agentOutputCommandExecutionOutputDelta,
            global::tryAGI.OpenAI.SessionEventAgentSessionCreated? agentSessionCreated,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? agentSessionTurnCreated,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? agentSessionTurnInProgress,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? agentSessionTurnCompleted,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? agentSessionTurnFailed,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? agentSessionTurnCancelled,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? agentSessionTurnItemAdded,
            global::tryAGI.OpenAI.SessionEventAgentSessionIdle? agentSessionIdle,
            global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? agentSessionInProgress,
            global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? agentSessionRequiresAction,
            global::tryAGI.OpenAI.SessionEventAgentSessionFailed? agentSessionFailed,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? agentSessionEnvironmentPending,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? agentSessionEnvironmentConnected,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? agentSessionEnvironmentDisconnected,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? agentSessionEnvironmentFailed,
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? agentSessionSubagentCreated,
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? agentSessionSubagentActive,
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? agentSessionSubagentClosed,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? agentSessionTurnItemDone,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? agentSessionTurnContentPartAdded,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? agentSessionTurnContentPartDone,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? agentSessionTurnOutputTextDelta,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? agentSessionTurnOutputTextDone,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? agentSessionTurnReasoningSummaryPartAdded,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? agentSessionTurnReasoningSummaryPartDone,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? agentSessionTurnReasoningSummaryTextDelta,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? agentSessionTurnReasoningSummaryTextDone
            )
        {
            Type = type;

            Error = error;
            AgentSessionEnvironmentReady = agentSessionEnvironmentReady;
            AgentSessionEnvironmentReset = agentSessionEnvironmentReset;
            AgentOutputCommandExecutionOutputDelta = agentOutputCommandExecutionOutputDelta;
            AgentSessionCreated = agentSessionCreated;
            AgentSessionTurnCreated = agentSessionTurnCreated;
            AgentSessionTurnInProgress = agentSessionTurnInProgress;
            AgentSessionTurnCompleted = agentSessionTurnCompleted;
            AgentSessionTurnFailed = agentSessionTurnFailed;
            AgentSessionTurnCancelled = agentSessionTurnCancelled;
            AgentSessionTurnItemAdded = agentSessionTurnItemAdded;
            AgentSessionIdle = agentSessionIdle;
            AgentSessionInProgress = agentSessionInProgress;
            AgentSessionRequiresAction = agentSessionRequiresAction;
            AgentSessionFailed = agentSessionFailed;
            AgentSessionEnvironmentPending = agentSessionEnvironmentPending;
            AgentSessionEnvironmentConnected = agentSessionEnvironmentConnected;
            AgentSessionEnvironmentDisconnected = agentSessionEnvironmentDisconnected;
            AgentSessionEnvironmentFailed = agentSessionEnvironmentFailed;
            AgentSessionSubagentCreated = agentSessionSubagentCreated;
            AgentSessionSubagentActive = agentSessionSubagentActive;
            AgentSessionSubagentClosed = agentSessionSubagentClosed;
            AgentSessionTurnItemDone = agentSessionTurnItemDone;
            AgentSessionTurnContentPartAdded = agentSessionTurnContentPartAdded;
            AgentSessionTurnContentPartDone = agentSessionTurnContentPartDone;
            AgentSessionTurnOutputTextDelta = agentSessionTurnOutputTextDelta;
            AgentSessionTurnOutputTextDone = agentSessionTurnOutputTextDone;
            AgentSessionTurnReasoningSummaryPartAdded = agentSessionTurnReasoningSummaryPartAdded;
            AgentSessionTurnReasoningSummaryPartDone = agentSessionTurnReasoningSummaryPartDone;
            AgentSessionTurnReasoningSummaryTextDelta = agentSessionTurnReasoningSummaryTextDelta;
            AgentSessionTurnReasoningSummaryTextDone = agentSessionTurnReasoningSummaryTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AgentSessionTurnReasoningSummaryTextDone as object ??
            AgentSessionTurnReasoningSummaryTextDelta as object ??
            AgentSessionTurnReasoningSummaryPartDone as object ??
            AgentSessionTurnReasoningSummaryPartAdded as object ??
            AgentSessionTurnOutputTextDone as object ??
            AgentSessionTurnOutputTextDelta as object ??
            AgentSessionTurnContentPartDone as object ??
            AgentSessionTurnContentPartAdded as object ??
            AgentSessionTurnItemDone as object ??
            AgentSessionSubagentClosed as object ??
            AgentSessionSubagentActive as object ??
            AgentSessionSubagentCreated as object ??
            AgentSessionEnvironmentFailed as object ??
            AgentSessionEnvironmentDisconnected as object ??
            AgentSessionEnvironmentConnected as object ??
            AgentSessionEnvironmentPending as object ??
            AgentSessionFailed as object ??
            AgentSessionRequiresAction as object ??
            AgentSessionInProgress as object ??
            AgentSessionIdle as object ??
            AgentSessionTurnItemAdded as object ??
            AgentSessionTurnCancelled as object ??
            AgentSessionTurnFailed as object ??
            AgentSessionTurnCompleted as object ??
            AgentSessionTurnInProgress as object ??
            AgentSessionTurnCreated as object ??
            AgentSessionCreated as object ??
            AgentOutputCommandExecutionOutputDelta as object ??
            AgentSessionEnvironmentReset as object ??
            AgentSessionEnvironmentReady as object ??
            Error as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            AgentSessionEnvironmentReady?.ToString() ??
            AgentSessionEnvironmentReset?.ToString() ??
            AgentOutputCommandExecutionOutputDelta?.ToString() ??
            AgentSessionCreated?.ToString() ??
            AgentSessionTurnCreated?.ToString() ??
            AgentSessionTurnInProgress?.ToString() ??
            AgentSessionTurnCompleted?.ToString() ??
            AgentSessionTurnFailed?.ToString() ??
            AgentSessionTurnCancelled?.ToString() ??
            AgentSessionTurnItemAdded?.ToString() ??
            AgentSessionIdle?.ToString() ??
            AgentSessionInProgress?.ToString() ??
            AgentSessionRequiresAction?.ToString() ??
            AgentSessionFailed?.ToString() ??
            AgentSessionEnvironmentPending?.ToString() ??
            AgentSessionEnvironmentConnected?.ToString() ??
            AgentSessionEnvironmentDisconnected?.ToString() ??
            AgentSessionEnvironmentFailed?.ToString() ??
            AgentSessionSubagentCreated?.ToString() ??
            AgentSessionSubagentActive?.ToString() ??
            AgentSessionSubagentClosed?.ToString() ??
            AgentSessionTurnItemDone?.ToString() ??
            AgentSessionTurnContentPartAdded?.ToString() ??
            AgentSessionTurnContentPartDone?.ToString() ??
            AgentSessionTurnOutputTextDelta?.ToString() ??
            AgentSessionTurnOutputTextDone?.ToString() ??
            AgentSessionTurnReasoningSummaryPartAdded?.ToString() ??
            AgentSessionTurnReasoningSummaryPartDone?.ToString() ??
            AgentSessionTurnReasoningSummaryTextDelta?.ToString() ??
            AgentSessionTurnReasoningSummaryTextDone?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && IsAgentSessionTurnReasoningSummaryTextDelta && !IsAgentSessionTurnReasoningSummaryTextDone || !IsError && !IsAgentSessionEnvironmentReady && !IsAgentSessionEnvironmentReset && !IsAgentOutputCommandExecutionOutputDelta && !IsAgentSessionCreated && !IsAgentSessionTurnCreated && !IsAgentSessionTurnInProgress && !IsAgentSessionTurnCompleted && !IsAgentSessionTurnFailed && !IsAgentSessionTurnCancelled && !IsAgentSessionTurnItemAdded && !IsAgentSessionIdle && !IsAgentSessionInProgress && !IsAgentSessionRequiresAction && !IsAgentSessionFailed && !IsAgentSessionEnvironmentPending && !IsAgentSessionEnvironmentConnected && !IsAgentSessionEnvironmentDisconnected && !IsAgentSessionEnvironmentFailed && !IsAgentSessionSubagentCreated && !IsAgentSessionSubagentActive && !IsAgentSessionSubagentClosed && !IsAgentSessionTurnItemDone && !IsAgentSessionTurnContentPartAdded && !IsAgentSessionTurnContentPartDone && !IsAgentSessionTurnOutputTextDelta && !IsAgentSessionTurnOutputTextDone && !IsAgentSessionTurnReasoningSummaryPartAdded && !IsAgentSessionTurnReasoningSummaryPartDone && !IsAgentSessionTurnReasoningSummaryTextDelta && IsAgentSessionTurnReasoningSummaryTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.SessionEventError, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady, TResult>? agentSessionEnvironmentReady = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset, TResult>? agentSessionEnvironmentReset = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta, TResult>? agentOutputCommandExecutionOutputDelta = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionCreated, TResult>? agentSessionCreated = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated, TResult>? agentSessionTurnCreated = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress, TResult>? agentSessionTurnInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted, TResult>? agentSessionTurnCompleted = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed, TResult>? agentSessionTurnFailed = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled, TResult>? agentSessionTurnCancelled = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded, TResult>? agentSessionTurnItemAdded = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionIdle, TResult>? agentSessionIdle = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionInProgress, TResult>? agentSessionInProgress = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction, TResult>? agentSessionRequiresAction = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionFailed, TResult>? agentSessionFailed = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending, TResult>? agentSessionEnvironmentPending = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected, TResult>? agentSessionEnvironmentConnected = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected, TResult>? agentSessionEnvironmentDisconnected = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed, TResult>? agentSessionEnvironmentFailed = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated, TResult>? agentSessionSubagentCreated = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive, TResult>? agentSessionSubagentActive = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed, TResult>? agentSessionSubagentClosed = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone, TResult>? agentSessionTurnItemDone = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded, TResult>? agentSessionTurnContentPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone, TResult>? agentSessionTurnContentPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta, TResult>? agentSessionTurnOutputTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone, TResult>? agentSessionTurnOutputTextDone = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded, TResult>? agentSessionTurnReasoningSummaryPartAdded = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone, TResult>? agentSessionTurnReasoningSummaryPartDone = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta, TResult>? agentSessionTurnReasoningSummaryTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone, TResult>? agentSessionTurnReasoningSummaryTextDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsAgentSessionEnvironmentReady && agentSessionEnvironmentReady != null)
            {
                return agentSessionEnvironmentReady(AgentSessionEnvironmentReady!);
            }
            else if (IsAgentSessionEnvironmentReset && agentSessionEnvironmentReset != null)
            {
                return agentSessionEnvironmentReset(AgentSessionEnvironmentReset!);
            }
            else if (IsAgentOutputCommandExecutionOutputDelta && agentOutputCommandExecutionOutputDelta != null)
            {
                return agentOutputCommandExecutionOutputDelta(AgentOutputCommandExecutionOutputDelta!);
            }
            else if (IsAgentSessionCreated && agentSessionCreated != null)
            {
                return agentSessionCreated(AgentSessionCreated!);
            }
            else if (IsAgentSessionTurnCreated && agentSessionTurnCreated != null)
            {
                return agentSessionTurnCreated(AgentSessionTurnCreated!);
            }
            else if (IsAgentSessionTurnInProgress && agentSessionTurnInProgress != null)
            {
                return agentSessionTurnInProgress(AgentSessionTurnInProgress!);
            }
            else if (IsAgentSessionTurnCompleted && agentSessionTurnCompleted != null)
            {
                return agentSessionTurnCompleted(AgentSessionTurnCompleted!);
            }
            else if (IsAgentSessionTurnFailed && agentSessionTurnFailed != null)
            {
                return agentSessionTurnFailed(AgentSessionTurnFailed!);
            }
            else if (IsAgentSessionTurnCancelled && agentSessionTurnCancelled != null)
            {
                return agentSessionTurnCancelled(AgentSessionTurnCancelled!);
            }
            else if (IsAgentSessionTurnItemAdded && agentSessionTurnItemAdded != null)
            {
                return agentSessionTurnItemAdded(AgentSessionTurnItemAdded!);
            }
            else if (IsAgentSessionIdle && agentSessionIdle != null)
            {
                return agentSessionIdle(AgentSessionIdle!);
            }
            else if (IsAgentSessionInProgress && agentSessionInProgress != null)
            {
                return agentSessionInProgress(AgentSessionInProgress!);
            }
            else if (IsAgentSessionRequiresAction && agentSessionRequiresAction != null)
            {
                return agentSessionRequiresAction(AgentSessionRequiresAction!);
            }
            else if (IsAgentSessionFailed && agentSessionFailed != null)
            {
                return agentSessionFailed(AgentSessionFailed!);
            }
            else if (IsAgentSessionEnvironmentPending && agentSessionEnvironmentPending != null)
            {
                return agentSessionEnvironmentPending(AgentSessionEnvironmentPending!);
            }
            else if (IsAgentSessionEnvironmentConnected && agentSessionEnvironmentConnected != null)
            {
                return agentSessionEnvironmentConnected(AgentSessionEnvironmentConnected!);
            }
            else if (IsAgentSessionEnvironmentDisconnected && agentSessionEnvironmentDisconnected != null)
            {
                return agentSessionEnvironmentDisconnected(AgentSessionEnvironmentDisconnected!);
            }
            else if (IsAgentSessionEnvironmentFailed && agentSessionEnvironmentFailed != null)
            {
                return agentSessionEnvironmentFailed(AgentSessionEnvironmentFailed!);
            }
            else if (IsAgentSessionSubagentCreated && agentSessionSubagentCreated != null)
            {
                return agentSessionSubagentCreated(AgentSessionSubagentCreated!);
            }
            else if (IsAgentSessionSubagentActive && agentSessionSubagentActive != null)
            {
                return agentSessionSubagentActive(AgentSessionSubagentActive!);
            }
            else if (IsAgentSessionSubagentClosed && agentSessionSubagentClosed != null)
            {
                return agentSessionSubagentClosed(AgentSessionSubagentClosed!);
            }
            else if (IsAgentSessionTurnItemDone && agentSessionTurnItemDone != null)
            {
                return agentSessionTurnItemDone(AgentSessionTurnItemDone!);
            }
            else if (IsAgentSessionTurnContentPartAdded && agentSessionTurnContentPartAdded != null)
            {
                return agentSessionTurnContentPartAdded(AgentSessionTurnContentPartAdded!);
            }
            else if (IsAgentSessionTurnContentPartDone && agentSessionTurnContentPartDone != null)
            {
                return agentSessionTurnContentPartDone(AgentSessionTurnContentPartDone!);
            }
            else if (IsAgentSessionTurnOutputTextDelta && agentSessionTurnOutputTextDelta != null)
            {
                return agentSessionTurnOutputTextDelta(AgentSessionTurnOutputTextDelta!);
            }
            else if (IsAgentSessionTurnOutputTextDone && agentSessionTurnOutputTextDone != null)
            {
                return agentSessionTurnOutputTextDone(AgentSessionTurnOutputTextDone!);
            }
            else if (IsAgentSessionTurnReasoningSummaryPartAdded && agentSessionTurnReasoningSummaryPartAdded != null)
            {
                return agentSessionTurnReasoningSummaryPartAdded(AgentSessionTurnReasoningSummaryPartAdded!);
            }
            else if (IsAgentSessionTurnReasoningSummaryPartDone && agentSessionTurnReasoningSummaryPartDone != null)
            {
                return agentSessionTurnReasoningSummaryPartDone(AgentSessionTurnReasoningSummaryPartDone!);
            }
            else if (IsAgentSessionTurnReasoningSummaryTextDelta && agentSessionTurnReasoningSummaryTextDelta != null)
            {
                return agentSessionTurnReasoningSummaryTextDelta(AgentSessionTurnReasoningSummaryTextDelta!);
            }
            else if (IsAgentSessionTurnReasoningSummaryTextDone && agentSessionTurnReasoningSummaryTextDone != null)
            {
                return agentSessionTurnReasoningSummaryTextDone(AgentSessionTurnReasoningSummaryTextDone!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.SessionEventError>? error = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady>? agentSessionEnvironmentReady = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset>? agentSessionEnvironmentReset = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta>? agentOutputCommandExecutionOutputDelta = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionCreated>? agentSessionCreated = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated>? agentSessionTurnCreated = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress>? agentSessionTurnInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted>? agentSessionTurnCompleted = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed>? agentSessionTurnFailed = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled>? agentSessionTurnCancelled = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded>? agentSessionTurnItemAdded = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionIdle>? agentSessionIdle = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionInProgress>? agentSessionInProgress = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction>? agentSessionRequiresAction = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionFailed>? agentSessionFailed = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending>? agentSessionEnvironmentPending = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected>? agentSessionEnvironmentConnected = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected>? agentSessionEnvironmentDisconnected = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed>? agentSessionEnvironmentFailed = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated>? agentSessionSubagentCreated = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive>? agentSessionSubagentActive = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed>? agentSessionSubagentClosed = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone>? agentSessionTurnItemDone = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded>? agentSessionTurnContentPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone>? agentSessionTurnContentPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta>? agentSessionTurnOutputTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone>? agentSessionTurnOutputTextDone = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded>? agentSessionTurnReasoningSummaryPartAdded = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone>? agentSessionTurnReasoningSummaryPartDone = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta>? agentSessionTurnReasoningSummaryTextDelta = null,

            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone>? agentSessionTurnReasoningSummaryTextDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsAgentSessionEnvironmentReady)
            {
                agentSessionEnvironmentReady?.Invoke(AgentSessionEnvironmentReady!);
            }
            else if (IsAgentSessionEnvironmentReset)
            {
                agentSessionEnvironmentReset?.Invoke(AgentSessionEnvironmentReset!);
            }
            else if (IsAgentOutputCommandExecutionOutputDelta)
            {
                agentOutputCommandExecutionOutputDelta?.Invoke(AgentOutputCommandExecutionOutputDelta!);
            }
            else if (IsAgentSessionCreated)
            {
                agentSessionCreated?.Invoke(AgentSessionCreated!);
            }
            else if (IsAgentSessionTurnCreated)
            {
                agentSessionTurnCreated?.Invoke(AgentSessionTurnCreated!);
            }
            else if (IsAgentSessionTurnInProgress)
            {
                agentSessionTurnInProgress?.Invoke(AgentSessionTurnInProgress!);
            }
            else if (IsAgentSessionTurnCompleted)
            {
                agentSessionTurnCompleted?.Invoke(AgentSessionTurnCompleted!);
            }
            else if (IsAgentSessionTurnFailed)
            {
                agentSessionTurnFailed?.Invoke(AgentSessionTurnFailed!);
            }
            else if (IsAgentSessionTurnCancelled)
            {
                agentSessionTurnCancelled?.Invoke(AgentSessionTurnCancelled!);
            }
            else if (IsAgentSessionTurnItemAdded)
            {
                agentSessionTurnItemAdded?.Invoke(AgentSessionTurnItemAdded!);
            }
            else if (IsAgentSessionIdle)
            {
                agentSessionIdle?.Invoke(AgentSessionIdle!);
            }
            else if (IsAgentSessionInProgress)
            {
                agentSessionInProgress?.Invoke(AgentSessionInProgress!);
            }
            else if (IsAgentSessionRequiresAction)
            {
                agentSessionRequiresAction?.Invoke(AgentSessionRequiresAction!);
            }
            else if (IsAgentSessionFailed)
            {
                agentSessionFailed?.Invoke(AgentSessionFailed!);
            }
            else if (IsAgentSessionEnvironmentPending)
            {
                agentSessionEnvironmentPending?.Invoke(AgentSessionEnvironmentPending!);
            }
            else if (IsAgentSessionEnvironmentConnected)
            {
                agentSessionEnvironmentConnected?.Invoke(AgentSessionEnvironmentConnected!);
            }
            else if (IsAgentSessionEnvironmentDisconnected)
            {
                agentSessionEnvironmentDisconnected?.Invoke(AgentSessionEnvironmentDisconnected!);
            }
            else if (IsAgentSessionEnvironmentFailed)
            {
                agentSessionEnvironmentFailed?.Invoke(AgentSessionEnvironmentFailed!);
            }
            else if (IsAgentSessionSubagentCreated)
            {
                agentSessionSubagentCreated?.Invoke(AgentSessionSubagentCreated!);
            }
            else if (IsAgentSessionSubagentActive)
            {
                agentSessionSubagentActive?.Invoke(AgentSessionSubagentActive!);
            }
            else if (IsAgentSessionSubagentClosed)
            {
                agentSessionSubagentClosed?.Invoke(AgentSessionSubagentClosed!);
            }
            else if (IsAgentSessionTurnItemDone)
            {
                agentSessionTurnItemDone?.Invoke(AgentSessionTurnItemDone!);
            }
            else if (IsAgentSessionTurnContentPartAdded)
            {
                agentSessionTurnContentPartAdded?.Invoke(AgentSessionTurnContentPartAdded!);
            }
            else if (IsAgentSessionTurnContentPartDone)
            {
                agentSessionTurnContentPartDone?.Invoke(AgentSessionTurnContentPartDone!);
            }
            else if (IsAgentSessionTurnOutputTextDelta)
            {
                agentSessionTurnOutputTextDelta?.Invoke(AgentSessionTurnOutputTextDelta!);
            }
            else if (IsAgentSessionTurnOutputTextDone)
            {
                agentSessionTurnOutputTextDone?.Invoke(AgentSessionTurnOutputTextDone!);
            }
            else if (IsAgentSessionTurnReasoningSummaryPartAdded)
            {
                agentSessionTurnReasoningSummaryPartAdded?.Invoke(AgentSessionTurnReasoningSummaryPartAdded!);
            }
            else if (IsAgentSessionTurnReasoningSummaryPartDone)
            {
                agentSessionTurnReasoningSummaryPartDone?.Invoke(AgentSessionTurnReasoningSummaryPartDone!);
            }
            else if (IsAgentSessionTurnReasoningSummaryTextDelta)
            {
                agentSessionTurnReasoningSummaryTextDelta?.Invoke(AgentSessionTurnReasoningSummaryTextDelta!);
            }
            else if (IsAgentSessionTurnReasoningSummaryTextDone)
            {
                agentSessionTurnReasoningSummaryTextDone?.Invoke(AgentSessionTurnReasoningSummaryTextDone!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.SessionEventError>? error = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady>? agentSessionEnvironmentReady = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset>? agentSessionEnvironmentReset = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta>? agentOutputCommandExecutionOutputDelta = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionCreated>? agentSessionCreated = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated>? agentSessionTurnCreated = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress>? agentSessionTurnInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted>? agentSessionTurnCompleted = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed>? agentSessionTurnFailed = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled>? agentSessionTurnCancelled = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded>? agentSessionTurnItemAdded = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionIdle>? agentSessionIdle = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionInProgress>? agentSessionInProgress = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction>? agentSessionRequiresAction = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionFailed>? agentSessionFailed = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending>? agentSessionEnvironmentPending = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected>? agentSessionEnvironmentConnected = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected>? agentSessionEnvironmentDisconnected = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed>? agentSessionEnvironmentFailed = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated>? agentSessionSubagentCreated = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive>? agentSessionSubagentActive = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed>? agentSessionSubagentClosed = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone>? agentSessionTurnItemDone = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded>? agentSessionTurnContentPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone>? agentSessionTurnContentPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta>? agentSessionTurnOutputTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone>? agentSessionTurnOutputTextDone = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded>? agentSessionTurnReasoningSummaryPartAdded = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone>? agentSessionTurnReasoningSummaryPartDone = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta>? agentSessionTurnReasoningSummaryTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone>? agentSessionTurnReasoningSummaryTextDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsAgentSessionEnvironmentReady)
            {
                agentSessionEnvironmentReady?.Invoke(AgentSessionEnvironmentReady!);
            }
            else if (IsAgentSessionEnvironmentReset)
            {
                agentSessionEnvironmentReset?.Invoke(AgentSessionEnvironmentReset!);
            }
            else if (IsAgentOutputCommandExecutionOutputDelta)
            {
                agentOutputCommandExecutionOutputDelta?.Invoke(AgentOutputCommandExecutionOutputDelta!);
            }
            else if (IsAgentSessionCreated)
            {
                agentSessionCreated?.Invoke(AgentSessionCreated!);
            }
            else if (IsAgentSessionTurnCreated)
            {
                agentSessionTurnCreated?.Invoke(AgentSessionTurnCreated!);
            }
            else if (IsAgentSessionTurnInProgress)
            {
                agentSessionTurnInProgress?.Invoke(AgentSessionTurnInProgress!);
            }
            else if (IsAgentSessionTurnCompleted)
            {
                agentSessionTurnCompleted?.Invoke(AgentSessionTurnCompleted!);
            }
            else if (IsAgentSessionTurnFailed)
            {
                agentSessionTurnFailed?.Invoke(AgentSessionTurnFailed!);
            }
            else if (IsAgentSessionTurnCancelled)
            {
                agentSessionTurnCancelled?.Invoke(AgentSessionTurnCancelled!);
            }
            else if (IsAgentSessionTurnItemAdded)
            {
                agentSessionTurnItemAdded?.Invoke(AgentSessionTurnItemAdded!);
            }
            else if (IsAgentSessionIdle)
            {
                agentSessionIdle?.Invoke(AgentSessionIdle!);
            }
            else if (IsAgentSessionInProgress)
            {
                agentSessionInProgress?.Invoke(AgentSessionInProgress!);
            }
            else if (IsAgentSessionRequiresAction)
            {
                agentSessionRequiresAction?.Invoke(AgentSessionRequiresAction!);
            }
            else if (IsAgentSessionFailed)
            {
                agentSessionFailed?.Invoke(AgentSessionFailed!);
            }
            else if (IsAgentSessionEnvironmentPending)
            {
                agentSessionEnvironmentPending?.Invoke(AgentSessionEnvironmentPending!);
            }
            else if (IsAgentSessionEnvironmentConnected)
            {
                agentSessionEnvironmentConnected?.Invoke(AgentSessionEnvironmentConnected!);
            }
            else if (IsAgentSessionEnvironmentDisconnected)
            {
                agentSessionEnvironmentDisconnected?.Invoke(AgentSessionEnvironmentDisconnected!);
            }
            else if (IsAgentSessionEnvironmentFailed)
            {
                agentSessionEnvironmentFailed?.Invoke(AgentSessionEnvironmentFailed!);
            }
            else if (IsAgentSessionSubagentCreated)
            {
                agentSessionSubagentCreated?.Invoke(AgentSessionSubagentCreated!);
            }
            else if (IsAgentSessionSubagentActive)
            {
                agentSessionSubagentActive?.Invoke(AgentSessionSubagentActive!);
            }
            else if (IsAgentSessionSubagentClosed)
            {
                agentSessionSubagentClosed?.Invoke(AgentSessionSubagentClosed!);
            }
            else if (IsAgentSessionTurnItemDone)
            {
                agentSessionTurnItemDone?.Invoke(AgentSessionTurnItemDone!);
            }
            else if (IsAgentSessionTurnContentPartAdded)
            {
                agentSessionTurnContentPartAdded?.Invoke(AgentSessionTurnContentPartAdded!);
            }
            else if (IsAgentSessionTurnContentPartDone)
            {
                agentSessionTurnContentPartDone?.Invoke(AgentSessionTurnContentPartDone!);
            }
            else if (IsAgentSessionTurnOutputTextDelta)
            {
                agentSessionTurnOutputTextDelta?.Invoke(AgentSessionTurnOutputTextDelta!);
            }
            else if (IsAgentSessionTurnOutputTextDone)
            {
                agentSessionTurnOutputTextDone?.Invoke(AgentSessionTurnOutputTextDone!);
            }
            else if (IsAgentSessionTurnReasoningSummaryPartAdded)
            {
                agentSessionTurnReasoningSummaryPartAdded?.Invoke(AgentSessionTurnReasoningSummaryPartAdded!);
            }
            else if (IsAgentSessionTurnReasoningSummaryPartDone)
            {
                agentSessionTurnReasoningSummaryPartDone?.Invoke(AgentSessionTurnReasoningSummaryPartDone!);
            }
            else if (IsAgentSessionTurnReasoningSummaryTextDelta)
            {
                agentSessionTurnReasoningSummaryTextDelta?.Invoke(AgentSessionTurnReasoningSummaryTextDelta!);
            }
            else if (IsAgentSessionTurnReasoningSummaryTextDone)
            {
                agentSessionTurnReasoningSummaryTextDone?.Invoke(AgentSessionTurnReasoningSummaryTextDone!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Error,
                typeof(global::tryAGI.OpenAI.SessionEventError),
                AgentSessionEnvironmentReady,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady),
                AgentSessionEnvironmentReset,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset),
                AgentOutputCommandExecutionOutputDelta,
                typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta),
                AgentSessionCreated,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreated),
                AgentSessionTurnCreated,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated),
                AgentSessionTurnInProgress,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress),
                AgentSessionTurnCompleted,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted),
                AgentSessionTurnFailed,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed),
                AgentSessionTurnCancelled,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled),
                AgentSessionTurnItemAdded,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded),
                AgentSessionIdle,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdle),
                AgentSessionInProgress,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress),
                AgentSessionRequiresAction,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction),
                AgentSessionFailed,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailed),
                AgentSessionEnvironmentPending,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending),
                AgentSessionEnvironmentConnected,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected),
                AgentSessionEnvironmentDisconnected,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected),
                AgentSessionEnvironmentFailed,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed),
                AgentSessionSubagentCreated,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated),
                AgentSessionSubagentActive,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive),
                AgentSessionSubagentClosed,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed),
                AgentSessionTurnItemDone,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone),
                AgentSessionTurnContentPartAdded,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded),
                AgentSessionTurnContentPartDone,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone),
                AgentSessionTurnOutputTextDelta,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta),
                AgentSessionTurnOutputTextDone,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone),
                AgentSessionTurnReasoningSummaryPartAdded,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded),
                AgentSessionTurnReasoningSummaryPartDone,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone),
                AgentSessionTurnReasoningSummaryTextDelta,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta),
                AgentSessionTurnReasoningSummaryTextDone,
                typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone),
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
        public bool Equals(SessionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady?>.Default.Equals(AgentSessionEnvironmentReady, other.AgentSessionEnvironmentReady) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset?>.Default.Equals(AgentSessionEnvironmentReset, other.AgentSessionEnvironmentReset) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta?>.Default.Equals(AgentOutputCommandExecutionOutputDelta, other.AgentOutputCommandExecutionOutputDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionCreated?>.Default.Equals(AgentSessionCreated, other.AgentSessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated?>.Default.Equals(AgentSessionTurnCreated, other.AgentSessionTurnCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress?>.Default.Equals(AgentSessionTurnInProgress, other.AgentSessionTurnInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted?>.Default.Equals(AgentSessionTurnCompleted, other.AgentSessionTurnCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed?>.Default.Equals(AgentSessionTurnFailed, other.AgentSessionTurnFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled?>.Default.Equals(AgentSessionTurnCancelled, other.AgentSessionTurnCancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded?>.Default.Equals(AgentSessionTurnItemAdded, other.AgentSessionTurnItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionIdle?>.Default.Equals(AgentSessionIdle, other.AgentSessionIdle) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionInProgress?>.Default.Equals(AgentSessionInProgress, other.AgentSessionInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction?>.Default.Equals(AgentSessionRequiresAction, other.AgentSessionRequiresAction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionFailed?>.Default.Equals(AgentSessionFailed, other.AgentSessionFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending?>.Default.Equals(AgentSessionEnvironmentPending, other.AgentSessionEnvironmentPending) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected?>.Default.Equals(AgentSessionEnvironmentConnected, other.AgentSessionEnvironmentConnected) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected?>.Default.Equals(AgentSessionEnvironmentDisconnected, other.AgentSessionEnvironmentDisconnected) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed?>.Default.Equals(AgentSessionEnvironmentFailed, other.AgentSessionEnvironmentFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated?>.Default.Equals(AgentSessionSubagentCreated, other.AgentSessionSubagentCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive?>.Default.Equals(AgentSessionSubagentActive, other.AgentSessionSubagentActive) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed?>.Default.Equals(AgentSessionSubagentClosed, other.AgentSessionSubagentClosed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone?>.Default.Equals(AgentSessionTurnItemDone, other.AgentSessionTurnItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded?>.Default.Equals(AgentSessionTurnContentPartAdded, other.AgentSessionTurnContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone?>.Default.Equals(AgentSessionTurnContentPartDone, other.AgentSessionTurnContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta?>.Default.Equals(AgentSessionTurnOutputTextDelta, other.AgentSessionTurnOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone?>.Default.Equals(AgentSessionTurnOutputTextDone, other.AgentSessionTurnOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded?>.Default.Equals(AgentSessionTurnReasoningSummaryPartAdded, other.AgentSessionTurnReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone?>.Default.Equals(AgentSessionTurnReasoningSummaryPartDone, other.AgentSessionTurnReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta?>.Default.Equals(AgentSessionTurnReasoningSummaryTextDelta, other.AgentSessionTurnReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone?>.Default.Equals(AgentSessionTurnReasoningSummaryTextDone, other.AgentSessionTurnReasoningSummaryTextDone)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SessionEvent obj1, SessionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SessionEvent obj1, SessionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionEvent o && Equals(o);
        }
    }
}
