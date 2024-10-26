using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Represents an event emitted when streaming a Run.<br/>
    /// Each event in a server-sent events stream has an `event` and `data` property:<br/>
    /// ```<br/>
    /// event: thread.created<br/>
    /// data: {"id": "thread_123", "object": "thread", ...}<br/>
    /// ```<br/>
    /// We emit events whenever a new object is created, transitions to a new state, or is being<br/>
    /// streamed in parts (deltas). For example, we emit `thread.run.created` when a new run<br/>
    /// is created, `thread.run.completed` when a run completes, and so on. When an Assistant chooses<br/>
    /// to create a message during a run, we emit a `thread.message.created event`, a<br/>
    /// `thread.message.in_progress` event, many `thread.message.delta` events, and finally a<br/>
    /// `thread.message.completed` event.<br/>
    /// We may add additional events over time, so we recommend handling unknown events gracefully<br/>
    /// in your code. See the [Assistants API quickstart](/docs/assistants/overview) to learn how to<br/>
    /// integrate the Assistants API with streaming.
    /// </summary>
    public readonly partial struct AssistantStreamEvent : global::System.IEquatable<AssistantStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.AssistantStreamEventDiscriminatorEvent? Event { get; }

        /// <summary>
        /// Occurs when an [error](/docs/guides/error-codes/api-errors) occurs. This can happen due to an internal server error or a timeout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ErrorEvent? Error { get; init; }
#else
        public global::OpenAI.ErrorEvent? Error { get; }
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
        public static implicit operator AssistantStreamEvent(global::OpenAI.ErrorEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ErrorEvent?(AssistantStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// Occurs when a stream ends.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.DoneEvent? Done { get; init; }
#else
        public global::OpenAI.DoneEvent? Done { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Done))]
#endif
        public bool IsDone => Done != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.DoneEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.DoneEvent?(AssistantStreamEvent @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.DoneEvent? value)
        {
            Done = value;
        }

        /// <summary>
        /// Occurs when a new [thread](/docs/api-reference/threads/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant3? ThreadCreated { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant3? ThreadCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadCreated))]
#endif
        public bool IsThreadCreated => ThreadCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant3 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant3?(AssistantStreamEvent @this) => @this.ThreadCreated;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant3? value)
        {
            ThreadCreated = value;
        }

        /// <summary>
        /// Occurs when a new [run](/docs/api-reference/runs/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant4? ThreadRunCreated { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant4? ThreadRunCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunCreated))]
#endif
        public bool IsThreadRunCreated => ThreadRunCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant4 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant4?(AssistantStreamEvent @this) => @this.ThreadRunCreated;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant4? value)
        {
            ThreadRunCreated = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `queued` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant5? ThreadRunQueued { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant5? ThreadRunQueued { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunQueued))]
#endif
        public bool IsThreadRunQueued => ThreadRunQueued != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant5 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant5?(AssistantStreamEvent @this) => @this.ThreadRunQueued;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant5? value)
        {
            ThreadRunQueued = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to an `in_progress` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant6? ThreadRunInProgress { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant6? ThreadRunInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunInProgress))]
#endif
        public bool IsThreadRunInProgress => ThreadRunInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant6 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant6?(AssistantStreamEvent @this) => @this.ThreadRunInProgress;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant6? value)
        {
            ThreadRunInProgress = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `requires_action` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant7? ThreadRunRequiresAction { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant7? ThreadRunRequiresAction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunRequiresAction))]
#endif
        public bool IsThreadRunRequiresAction => ThreadRunRequiresAction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant7 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant7?(AssistantStreamEvent @this) => @this.ThreadRunRequiresAction;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant7? value)
        {
            ThreadRunRequiresAction = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant8? ThreadRunCompleted { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant8? ThreadRunCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunCompleted))]
#endif
        public bool IsThreadRunCompleted => ThreadRunCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant8 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant8?(AssistantStreamEvent @this) => @this.ThreadRunCompleted;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant8? value)
        {
            ThreadRunCompleted = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) ends with status `incomplete`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant9? ThreadRunIncomplete { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant9? ThreadRunIncomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunIncomplete))]
#endif
        public bool IsThreadRunIncomplete => ThreadRunIncomplete != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant9 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant9?(AssistantStreamEvent @this) => @this.ThreadRunIncomplete;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant9? value)
        {
            ThreadRunIncomplete = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant10? ThreadRunFailed { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant10? ThreadRunFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunFailed))]
#endif
        public bool IsThreadRunFailed => ThreadRunFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant10 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant10?(AssistantStreamEvent @this) => @this.ThreadRunFailed;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant10? value)
        {
            ThreadRunFailed = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `cancelling` status.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant11? ThreadRunCancelling { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant11? ThreadRunCancelling { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunCancelling))]
#endif
        public bool IsThreadRunCancelling => ThreadRunCancelling != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant11 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant11?(AssistantStreamEvent @this) => @this.ThreadRunCancelling;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant11? value)
        {
            ThreadRunCancelling = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant12? ThreadRunCancelled { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant12? ThreadRunCancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunCancelled))]
#endif
        public bool IsThreadRunCancelled => ThreadRunCancelled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant12 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant12?(AssistantStreamEvent @this) => @this.ThreadRunCancelled;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant12? value)
        {
            ThreadRunCancelled = value;
        }

        /// <summary>
        /// Occurs when a [run](/docs/api-reference/runs/object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant13? ThreadRunExpired { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant13? ThreadRunExpired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunExpired))]
#endif
        public bool IsThreadRunExpired => ThreadRunExpired != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant13 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant13?(AssistantStreamEvent @this) => @this.ThreadRunExpired;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant13? value)
        {
            ThreadRunExpired = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant14? ThreadRunStepCreated { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant14? ThreadRunStepCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepCreated))]
#endif
        public bool IsThreadRunStepCreated => ThreadRunStepCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant14 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant14?(AssistantStreamEvent @this) => @this.ThreadRunStepCreated;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant14? value)
        {
            ThreadRunStepCreated = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant15? ThreadRunStepInProgress { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant15? ThreadRunStepInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepInProgress))]
#endif
        public bool IsThreadRunStepInProgress => ThreadRunStepInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant15 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant15?(AssistantStreamEvent @this) => @this.ThreadRunStepInProgress;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant15? value)
        {
            ThreadRunStepInProgress = value;
        }

        /// <summary>
        /// Occurs when parts of a [run step](/docs/api-reference/run-steps/step-object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant16? ThreadRunStepDelta { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant16? ThreadRunStepDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepDelta))]
#endif
        public bool IsThreadRunStepDelta => ThreadRunStepDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant16 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant16?(AssistantStreamEvent @this) => @this.ThreadRunStepDelta;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant16? value)
        {
            ThreadRunStepDelta = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant17? ThreadRunStepCompleted { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant17? ThreadRunStepCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepCompleted))]
#endif
        public bool IsThreadRunStepCompleted => ThreadRunStepCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant17 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant17?(AssistantStreamEvent @this) => @this.ThreadRunStepCompleted;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant17? value)
        {
            ThreadRunStepCompleted = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) fails.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant18? ThreadRunStepFailed { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant18? ThreadRunStepFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepFailed))]
#endif
        public bool IsThreadRunStepFailed => ThreadRunStepFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant18 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant18?(AssistantStreamEvent @this) => @this.ThreadRunStepFailed;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant18? value)
        {
            ThreadRunStepFailed = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant19? ThreadRunStepCancelled { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant19? ThreadRunStepCancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepCancelled))]
#endif
        public bool IsThreadRunStepCancelled => ThreadRunStepCancelled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant19 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant19?(AssistantStreamEvent @this) => @this.ThreadRunStepCancelled;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant19? value)
        {
            ThreadRunStepCancelled = value;
        }

        /// <summary>
        /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) expires.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant20? ThreadRunStepExpired { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant20? ThreadRunStepExpired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadRunStepExpired))]
#endif
        public bool IsThreadRunStepExpired => ThreadRunStepExpired != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant20 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant20?(AssistantStreamEvent @this) => @this.ThreadRunStepExpired;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant20? value)
        {
            ThreadRunStepExpired = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) is created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant21? ThreadMessageCreated { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant21? ThreadMessageCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadMessageCreated))]
#endif
        public bool IsThreadMessageCreated => ThreadMessageCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant21 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant21?(AssistantStreamEvent @this) => @this.ThreadMessageCreated;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant21? value)
        {
            ThreadMessageCreated = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) moves to an `in_progress` state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant22? ThreadMessageInProgress { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant22? ThreadMessageInProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadMessageInProgress))]
#endif
        public bool IsThreadMessageInProgress => ThreadMessageInProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant22 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant22?(AssistantStreamEvent @this) => @this.ThreadMessageInProgress;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant22? value)
        {
            ThreadMessageInProgress = value;
        }

        /// <summary>
        /// Occurs when parts of a [Message](/docs/api-reference/messages/object) are being streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant23? ThreadMessageDelta { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant23? ThreadMessageDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadMessageDelta))]
#endif
        public bool IsThreadMessageDelta => ThreadMessageDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant23 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant23?(AssistantStreamEvent @this) => @this.ThreadMessageDelta;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant23? value)
        {
            ThreadMessageDelta = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant24? ThreadMessageCompleted { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant24? ThreadMessageCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadMessageCompleted))]
#endif
        public bool IsThreadMessageCompleted => ThreadMessageCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant24 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant24?(AssistantStreamEvent @this) => @this.ThreadMessageCompleted;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant24? value)
        {
            ThreadMessageCompleted = value;
        }

        /// <summary>
        /// Occurs when a [message](/docs/api-reference/messages/object) ends before it is completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantStreamEventVariant25? ThreadMessageIncomplete { get; init; }
#else
        public global::OpenAI.AssistantStreamEventVariant25? ThreadMessageIncomplete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadMessageIncomplete))]
#endif
        public bool IsThreadMessageIncomplete => ThreadMessageIncomplete != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant25 value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantStreamEventVariant25?(AssistantStreamEvent @this) => @this.ThreadMessageIncomplete;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.AssistantStreamEventVariant25? value)
        {
            ThreadMessageIncomplete = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::OpenAI.AssistantStreamEventDiscriminatorEvent? @event,
            global::OpenAI.ErrorEvent? error,
            global::OpenAI.DoneEvent? done,
            global::OpenAI.AssistantStreamEventVariant3? threadCreated,
            global::OpenAI.AssistantStreamEventVariant4? threadRunCreated,
            global::OpenAI.AssistantStreamEventVariant5? threadRunQueued,
            global::OpenAI.AssistantStreamEventVariant6? threadRunInProgress,
            global::OpenAI.AssistantStreamEventVariant7? threadRunRequiresAction,
            global::OpenAI.AssistantStreamEventVariant8? threadRunCompleted,
            global::OpenAI.AssistantStreamEventVariant9? threadRunIncomplete,
            global::OpenAI.AssistantStreamEventVariant10? threadRunFailed,
            global::OpenAI.AssistantStreamEventVariant11? threadRunCancelling,
            global::OpenAI.AssistantStreamEventVariant12? threadRunCancelled,
            global::OpenAI.AssistantStreamEventVariant13? threadRunExpired,
            global::OpenAI.AssistantStreamEventVariant14? threadRunStepCreated,
            global::OpenAI.AssistantStreamEventVariant15? threadRunStepInProgress,
            global::OpenAI.AssistantStreamEventVariant16? threadRunStepDelta,
            global::OpenAI.AssistantStreamEventVariant17? threadRunStepCompleted,
            global::OpenAI.AssistantStreamEventVariant18? threadRunStepFailed,
            global::OpenAI.AssistantStreamEventVariant19? threadRunStepCancelled,
            global::OpenAI.AssistantStreamEventVariant20? threadRunStepExpired,
            global::OpenAI.AssistantStreamEventVariant21? threadMessageCreated,
            global::OpenAI.AssistantStreamEventVariant22? threadMessageInProgress,
            global::OpenAI.AssistantStreamEventVariant23? threadMessageDelta,
            global::OpenAI.AssistantStreamEventVariant24? threadMessageCompleted,
            global::OpenAI.AssistantStreamEventVariant25? threadMessageIncomplete
            )
        {
            Event = @event;

            Error = error;
            Done = done;
            ThreadCreated = threadCreated;
            ThreadRunCreated = threadRunCreated;
            ThreadRunQueued = threadRunQueued;
            ThreadRunInProgress = threadRunInProgress;
            ThreadRunRequiresAction = threadRunRequiresAction;
            ThreadRunCompleted = threadRunCompleted;
            ThreadRunIncomplete = threadRunIncomplete;
            ThreadRunFailed = threadRunFailed;
            ThreadRunCancelling = threadRunCancelling;
            ThreadRunCancelled = threadRunCancelled;
            ThreadRunExpired = threadRunExpired;
            ThreadRunStepCreated = threadRunStepCreated;
            ThreadRunStepInProgress = threadRunStepInProgress;
            ThreadRunStepDelta = threadRunStepDelta;
            ThreadRunStepCompleted = threadRunStepCompleted;
            ThreadRunStepFailed = threadRunStepFailed;
            ThreadRunStepCancelled = threadRunStepCancelled;
            ThreadRunStepExpired = threadRunStepExpired;
            ThreadMessageCreated = threadMessageCreated;
            ThreadMessageInProgress = threadMessageInProgress;
            ThreadMessageDelta = threadMessageDelta;
            ThreadMessageCompleted = threadMessageCompleted;
            ThreadMessageIncomplete = threadMessageIncomplete;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThreadMessageIncomplete as object ??
            ThreadMessageCompleted as object ??
            ThreadMessageDelta as object ??
            ThreadMessageInProgress as object ??
            ThreadMessageCreated as object ??
            ThreadRunStepExpired as object ??
            ThreadRunStepCancelled as object ??
            ThreadRunStepFailed as object ??
            ThreadRunStepCompleted as object ??
            ThreadRunStepDelta as object ??
            ThreadRunStepInProgress as object ??
            ThreadRunStepCreated as object ??
            ThreadRunExpired as object ??
            ThreadRunCancelled as object ??
            ThreadRunCancelling as object ??
            ThreadRunFailed as object ??
            ThreadRunIncomplete as object ??
            ThreadRunCompleted as object ??
            ThreadRunRequiresAction as object ??
            ThreadRunInProgress as object ??
            ThreadRunQueued as object ??
            ThreadRunCreated as object ??
            ThreadCreated as object ??
            Done as object ??
            Error as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && IsThreadMessageDelta && !IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && IsThreadMessageCompleted && !IsThreadMessageIncomplete || !IsError && !IsDone && !IsThreadCreated && !IsThreadRunCreated && !IsThreadRunQueued && !IsThreadRunInProgress && !IsThreadRunRequiresAction && !IsThreadRunCompleted && !IsThreadRunIncomplete && !IsThreadRunFailed && !IsThreadRunCancelling && !IsThreadRunCancelled && !IsThreadRunExpired && !IsThreadRunStepCreated && !IsThreadRunStepInProgress && !IsThreadRunStepDelta && !IsThreadRunStepCompleted && !IsThreadRunStepFailed && !IsThreadRunStepCancelled && !IsThreadRunStepExpired && !IsThreadMessageCreated && !IsThreadMessageInProgress && !IsThreadMessageDelta && !IsThreadMessageCompleted && IsThreadMessageIncomplete;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.ErrorEvent?, TResult>? error = null,
            global::System.Func<global::OpenAI.DoneEvent?, TResult>? done = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant3?, TResult>? threadCreated = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant4?, TResult>? threadRunCreated = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant5?, TResult>? threadRunQueued = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant6?, TResult>? threadRunInProgress = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant7?, TResult>? threadRunRequiresAction = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant8?, TResult>? threadRunCompleted = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant9?, TResult>? threadRunIncomplete = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant10?, TResult>? threadRunFailed = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant11?, TResult>? threadRunCancelling = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant12?, TResult>? threadRunCancelled = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant13?, TResult>? threadRunExpired = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant14?, TResult>? threadRunStepCreated = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant15?, TResult>? threadRunStepInProgress = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant16?, TResult>? threadRunStepDelta = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant17?, TResult>? threadRunStepCompleted = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant18?, TResult>? threadRunStepFailed = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant19?, TResult>? threadRunStepCancelled = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant20?, TResult>? threadRunStepExpired = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant21?, TResult>? threadMessageCreated = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant22?, TResult>? threadMessageInProgress = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant23?, TResult>? threadMessageDelta = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant24?, TResult>? threadMessageCompleted = null,
            global::System.Func<global::OpenAI.AssistantStreamEventVariant25?, TResult>? threadMessageIncomplete = null,
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
            else if (IsDone && done != null)
            {
                return done(Done!);
            }
            else if (IsThreadCreated && threadCreated != null)
            {
                return threadCreated(ThreadCreated!);
            }
            else if (IsThreadRunCreated && threadRunCreated != null)
            {
                return threadRunCreated(ThreadRunCreated!);
            }
            else if (IsThreadRunQueued && threadRunQueued != null)
            {
                return threadRunQueued(ThreadRunQueued!);
            }
            else if (IsThreadRunInProgress && threadRunInProgress != null)
            {
                return threadRunInProgress(ThreadRunInProgress!);
            }
            else if (IsThreadRunRequiresAction && threadRunRequiresAction != null)
            {
                return threadRunRequiresAction(ThreadRunRequiresAction!);
            }
            else if (IsThreadRunCompleted && threadRunCompleted != null)
            {
                return threadRunCompleted(ThreadRunCompleted!);
            }
            else if (IsThreadRunIncomplete && threadRunIncomplete != null)
            {
                return threadRunIncomplete(ThreadRunIncomplete!);
            }
            else if (IsThreadRunFailed && threadRunFailed != null)
            {
                return threadRunFailed(ThreadRunFailed!);
            }
            else if (IsThreadRunCancelling && threadRunCancelling != null)
            {
                return threadRunCancelling(ThreadRunCancelling!);
            }
            else if (IsThreadRunCancelled && threadRunCancelled != null)
            {
                return threadRunCancelled(ThreadRunCancelled!);
            }
            else if (IsThreadRunExpired && threadRunExpired != null)
            {
                return threadRunExpired(ThreadRunExpired!);
            }
            else if (IsThreadRunStepCreated && threadRunStepCreated != null)
            {
                return threadRunStepCreated(ThreadRunStepCreated!);
            }
            else if (IsThreadRunStepInProgress && threadRunStepInProgress != null)
            {
                return threadRunStepInProgress(ThreadRunStepInProgress!);
            }
            else if (IsThreadRunStepDelta && threadRunStepDelta != null)
            {
                return threadRunStepDelta(ThreadRunStepDelta!);
            }
            else if (IsThreadRunStepCompleted && threadRunStepCompleted != null)
            {
                return threadRunStepCompleted(ThreadRunStepCompleted!);
            }
            else if (IsThreadRunStepFailed && threadRunStepFailed != null)
            {
                return threadRunStepFailed(ThreadRunStepFailed!);
            }
            else if (IsThreadRunStepCancelled && threadRunStepCancelled != null)
            {
                return threadRunStepCancelled(ThreadRunStepCancelled!);
            }
            else if (IsThreadRunStepExpired && threadRunStepExpired != null)
            {
                return threadRunStepExpired(ThreadRunStepExpired!);
            }
            else if (IsThreadMessageCreated && threadMessageCreated != null)
            {
                return threadMessageCreated(ThreadMessageCreated!);
            }
            else if (IsThreadMessageInProgress && threadMessageInProgress != null)
            {
                return threadMessageInProgress(ThreadMessageInProgress!);
            }
            else if (IsThreadMessageDelta && threadMessageDelta != null)
            {
                return threadMessageDelta(ThreadMessageDelta!);
            }
            else if (IsThreadMessageCompleted && threadMessageCompleted != null)
            {
                return threadMessageCompleted(ThreadMessageCompleted!);
            }
            else if (IsThreadMessageIncomplete && threadMessageIncomplete != null)
            {
                return threadMessageIncomplete(ThreadMessageIncomplete!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.ErrorEvent?>? error = null,
            global::System.Action<global::OpenAI.DoneEvent?>? done = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant3?>? threadCreated = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant4?>? threadRunCreated = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant5?>? threadRunQueued = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant6?>? threadRunInProgress = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant7?>? threadRunRequiresAction = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant8?>? threadRunCompleted = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant9?>? threadRunIncomplete = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant10?>? threadRunFailed = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant11?>? threadRunCancelling = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant12?>? threadRunCancelled = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant13?>? threadRunExpired = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant14?>? threadRunStepCreated = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant15?>? threadRunStepInProgress = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant16?>? threadRunStepDelta = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant17?>? threadRunStepCompleted = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant18?>? threadRunStepFailed = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant19?>? threadRunStepCancelled = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant20?>? threadRunStepExpired = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant21?>? threadMessageCreated = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant22?>? threadMessageInProgress = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant23?>? threadMessageDelta = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant24?>? threadMessageCompleted = null,
            global::System.Action<global::OpenAI.AssistantStreamEventVariant25?>? threadMessageIncomplete = null,
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
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
            else if (IsThreadCreated)
            {
                threadCreated?.Invoke(ThreadCreated!);
            }
            else if (IsThreadRunCreated)
            {
                threadRunCreated?.Invoke(ThreadRunCreated!);
            }
            else if (IsThreadRunQueued)
            {
                threadRunQueued?.Invoke(ThreadRunQueued!);
            }
            else if (IsThreadRunInProgress)
            {
                threadRunInProgress?.Invoke(ThreadRunInProgress!);
            }
            else if (IsThreadRunRequiresAction)
            {
                threadRunRequiresAction?.Invoke(ThreadRunRequiresAction!);
            }
            else if (IsThreadRunCompleted)
            {
                threadRunCompleted?.Invoke(ThreadRunCompleted!);
            }
            else if (IsThreadRunIncomplete)
            {
                threadRunIncomplete?.Invoke(ThreadRunIncomplete!);
            }
            else if (IsThreadRunFailed)
            {
                threadRunFailed?.Invoke(ThreadRunFailed!);
            }
            else if (IsThreadRunCancelling)
            {
                threadRunCancelling?.Invoke(ThreadRunCancelling!);
            }
            else if (IsThreadRunCancelled)
            {
                threadRunCancelled?.Invoke(ThreadRunCancelled!);
            }
            else if (IsThreadRunExpired)
            {
                threadRunExpired?.Invoke(ThreadRunExpired!);
            }
            else if (IsThreadRunStepCreated)
            {
                threadRunStepCreated?.Invoke(ThreadRunStepCreated!);
            }
            else if (IsThreadRunStepInProgress)
            {
                threadRunStepInProgress?.Invoke(ThreadRunStepInProgress!);
            }
            else if (IsThreadRunStepDelta)
            {
                threadRunStepDelta?.Invoke(ThreadRunStepDelta!);
            }
            else if (IsThreadRunStepCompleted)
            {
                threadRunStepCompleted?.Invoke(ThreadRunStepCompleted!);
            }
            else if (IsThreadRunStepFailed)
            {
                threadRunStepFailed?.Invoke(ThreadRunStepFailed!);
            }
            else if (IsThreadRunStepCancelled)
            {
                threadRunStepCancelled?.Invoke(ThreadRunStepCancelled!);
            }
            else if (IsThreadRunStepExpired)
            {
                threadRunStepExpired?.Invoke(ThreadRunStepExpired!);
            }
            else if (IsThreadMessageCreated)
            {
                threadMessageCreated?.Invoke(ThreadMessageCreated!);
            }
            else if (IsThreadMessageInProgress)
            {
                threadMessageInProgress?.Invoke(ThreadMessageInProgress!);
            }
            else if (IsThreadMessageDelta)
            {
                threadMessageDelta?.Invoke(ThreadMessageDelta!);
            }
            else if (IsThreadMessageCompleted)
            {
                threadMessageCompleted?.Invoke(ThreadMessageCompleted!);
            }
            else if (IsThreadMessageIncomplete)
            {
                threadMessageIncomplete?.Invoke(ThreadMessageIncomplete!);
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
                typeof(global::OpenAI.ErrorEvent),
                Done,
                typeof(global::OpenAI.DoneEvent),
                ThreadCreated,
                typeof(global::OpenAI.AssistantStreamEventVariant3),
                ThreadRunCreated,
                typeof(global::OpenAI.AssistantStreamEventVariant4),
                ThreadRunQueued,
                typeof(global::OpenAI.AssistantStreamEventVariant5),
                ThreadRunInProgress,
                typeof(global::OpenAI.AssistantStreamEventVariant6),
                ThreadRunRequiresAction,
                typeof(global::OpenAI.AssistantStreamEventVariant7),
                ThreadRunCompleted,
                typeof(global::OpenAI.AssistantStreamEventVariant8),
                ThreadRunIncomplete,
                typeof(global::OpenAI.AssistantStreamEventVariant9),
                ThreadRunFailed,
                typeof(global::OpenAI.AssistantStreamEventVariant10),
                ThreadRunCancelling,
                typeof(global::OpenAI.AssistantStreamEventVariant11),
                ThreadRunCancelled,
                typeof(global::OpenAI.AssistantStreamEventVariant12),
                ThreadRunExpired,
                typeof(global::OpenAI.AssistantStreamEventVariant13),
                ThreadRunStepCreated,
                typeof(global::OpenAI.AssistantStreamEventVariant14),
                ThreadRunStepInProgress,
                typeof(global::OpenAI.AssistantStreamEventVariant15),
                ThreadRunStepDelta,
                typeof(global::OpenAI.AssistantStreamEventVariant16),
                ThreadRunStepCompleted,
                typeof(global::OpenAI.AssistantStreamEventVariant17),
                ThreadRunStepFailed,
                typeof(global::OpenAI.AssistantStreamEventVariant18),
                ThreadRunStepCancelled,
                typeof(global::OpenAI.AssistantStreamEventVariant19),
                ThreadRunStepExpired,
                typeof(global::OpenAI.AssistantStreamEventVariant20),
                ThreadMessageCreated,
                typeof(global::OpenAI.AssistantStreamEventVariant21),
                ThreadMessageInProgress,
                typeof(global::OpenAI.AssistantStreamEventVariant22),
                ThreadMessageDelta,
                typeof(global::OpenAI.AssistantStreamEventVariant23),
                ThreadMessageCompleted,
                typeof(global::OpenAI.AssistantStreamEventVariant24),
                ThreadMessageIncomplete,
                typeof(global::OpenAI.AssistantStreamEventVariant25),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AssistantStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.DoneEvent?>.Default.Equals(Done, other.Done) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant3?>.Default.Equals(ThreadCreated, other.ThreadCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant4?>.Default.Equals(ThreadRunCreated, other.ThreadRunCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant5?>.Default.Equals(ThreadRunQueued, other.ThreadRunQueued) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant6?>.Default.Equals(ThreadRunInProgress, other.ThreadRunInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant7?>.Default.Equals(ThreadRunRequiresAction, other.ThreadRunRequiresAction) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant8?>.Default.Equals(ThreadRunCompleted, other.ThreadRunCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant9?>.Default.Equals(ThreadRunIncomplete, other.ThreadRunIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant10?>.Default.Equals(ThreadRunFailed, other.ThreadRunFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant11?>.Default.Equals(ThreadRunCancelling, other.ThreadRunCancelling) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant12?>.Default.Equals(ThreadRunCancelled, other.ThreadRunCancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant13?>.Default.Equals(ThreadRunExpired, other.ThreadRunExpired) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant14?>.Default.Equals(ThreadRunStepCreated, other.ThreadRunStepCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant15?>.Default.Equals(ThreadRunStepInProgress, other.ThreadRunStepInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant16?>.Default.Equals(ThreadRunStepDelta, other.ThreadRunStepDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant17?>.Default.Equals(ThreadRunStepCompleted, other.ThreadRunStepCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant18?>.Default.Equals(ThreadRunStepFailed, other.ThreadRunStepFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant19?>.Default.Equals(ThreadRunStepCancelled, other.ThreadRunStepCancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant20?>.Default.Equals(ThreadRunStepExpired, other.ThreadRunStepExpired) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant21?>.Default.Equals(ThreadMessageCreated, other.ThreadMessageCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant22?>.Default.Equals(ThreadMessageInProgress, other.ThreadMessageInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant23?>.Default.Equals(ThreadMessageDelta, other.ThreadMessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant24?>.Default.Equals(ThreadMessageCompleted, other.ThreadMessageCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantStreamEventVariant25?>.Default.Equals(ThreadMessageIncomplete, other.ThreadMessageIncomplete) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantStreamEvent obj1, AssistantStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantStreamEvent obj1, AssistantStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantStreamEvent o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.AssistantStreamEvent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.AssistantStreamEvent),
                jsonSerializerContext) as global::OpenAI.AssistantStreamEvent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.AssistantStreamEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.AssistantStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
