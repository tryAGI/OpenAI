#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ThreadStreamEvent? Thread { get; init; }
#else
        public global::tryAGI.OpenAI.ThreadStreamEvent? Thread { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thread))]
#endif
        public bool IsThread => Thread != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::tryAGI.OpenAI.ThreadStreamEvent value) => new AssistantStreamEvent((global::tryAGI.OpenAI.ThreadStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ThreadStreamEvent?(AssistantStreamEvent @this) => @this.Thread;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::tryAGI.OpenAI.ThreadStreamEvent? value)
        {
            Thread = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStreamEvent? Run { get; init; }
#else
        public global::tryAGI.OpenAI.RunStreamEvent? Run { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Run))]
#endif
        public bool IsRun => Run != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::tryAGI.OpenAI.RunStreamEvent value) => new AssistantStreamEvent((global::tryAGI.OpenAI.RunStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStreamEvent?(AssistantStreamEvent @this) => @this.Run;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::tryAGI.OpenAI.RunStreamEvent? value)
        {
            Run = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepStreamEvent? RunStep { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepStreamEvent? RunStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStep))]
#endif
        public bool IsRunStep => RunStep != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::tryAGI.OpenAI.RunStepStreamEvent value) => new AssistantStreamEvent((global::tryAGI.OpenAI.RunStepStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepStreamEvent?(AssistantStreamEvent @this) => @this.RunStep;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::tryAGI.OpenAI.RunStepStreamEvent? value)
        {
            RunStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageStreamEvent? Message { get; init; }
#else
        public global::tryAGI.OpenAI.MessageStreamEvent? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantStreamEvent(global::tryAGI.OpenAI.MessageStreamEvent value) => new AssistantStreamEvent((global::tryAGI.OpenAI.MessageStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageStreamEvent?(AssistantStreamEvent @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::tryAGI.OpenAI.MessageStreamEvent? value)
        {
            Message = value;
        }

        /// <summary>
        /// Occurs when an [error](/docs/guides/error-codes#api-errors) occurs. This can happen due to an internal server error or a timeout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ErrorEvent? Error { get; init; }
#else
        public global::tryAGI.OpenAI.ErrorEvent? Error { get; }
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
        public static implicit operator AssistantStreamEvent(global::tryAGI.OpenAI.ErrorEvent value) => new AssistantStreamEvent((global::tryAGI.OpenAI.ErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ErrorEvent?(AssistantStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::tryAGI.OpenAI.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// Occurs when a stream ends.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DoneEvent? Done { get; init; }
#else
        public global::tryAGI.OpenAI.DoneEvent? Done { get; }
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
        public static implicit operator AssistantStreamEvent(global::tryAGI.OpenAI.DoneEvent value) => new AssistantStreamEvent((global::tryAGI.OpenAI.DoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DoneEvent?(AssistantStreamEvent @this) => @this.Done;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::tryAGI.OpenAI.DoneEvent? value)
        {
            Done = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::tryAGI.OpenAI.ThreadStreamEvent? thread,
            global::tryAGI.OpenAI.RunStreamEvent? run,
            global::tryAGI.OpenAI.RunStepStreamEvent? runStep,
            global::tryAGI.OpenAI.MessageStreamEvent? message,
            global::tryAGI.OpenAI.ErrorEvent? error,
            global::tryAGI.OpenAI.DoneEvent? done
            )
        {
            Thread = thread;
            Run = run;
            RunStep = runStep;
            Message = message;
            Error = error;
            Done = done;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Done as object ??
            Error as object ??
            Message as object ??
            RunStep as object ??
            Run as object ??
            Thread as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Thread?.ToString() ??
            Run?.ToString() ??
            RunStep?.ToString() ??
            Message?.ToString() ??
            Error?.ToString() ??
            Done?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && IsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ThreadStreamEvent?, TResult>? thread = null,
            global::System.Func<global::tryAGI.OpenAI.RunStreamEvent?, TResult>? run = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepStreamEvent?, TResult>? runStep = null,
            global::System.Func<global::tryAGI.OpenAI.MessageStreamEvent?, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.ErrorEvent?, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.DoneEvent?, TResult>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread && thread != null)
            {
                return thread(Thread!);
            }
            else if (IsRun && run != null)
            {
                return run(Run!);
            }
            else if (IsRunStep && runStep != null)
            {
                return runStep(RunStep!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsDone && done != null)
            {
                return done(Done!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ThreadStreamEvent?>? thread = null,
            global::System.Action<global::tryAGI.OpenAI.RunStreamEvent?>? run = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepStreamEvent?>? runStep = null,
            global::System.Action<global::tryAGI.OpenAI.MessageStreamEvent?>? message = null,
            global::System.Action<global::tryAGI.OpenAI.ErrorEvent?>? error = null,
            global::System.Action<global::tryAGI.OpenAI.DoneEvent?>? done = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThread)
            {
                thread?.Invoke(Thread!);
            }
            else if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsRunStep)
            {
                runStep?.Invoke(RunStep!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsDone)
            {
                done?.Invoke(Done!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Thread,
                typeof(global::tryAGI.OpenAI.ThreadStreamEvent),
                Run,
                typeof(global::tryAGI.OpenAI.RunStreamEvent),
                RunStep,
                typeof(global::tryAGI.OpenAI.RunStepStreamEvent),
                Message,
                typeof(global::tryAGI.OpenAI.MessageStreamEvent),
                Error,
                typeof(global::tryAGI.OpenAI.ErrorEvent),
                Done,
                typeof(global::tryAGI.OpenAI.DoneEvent),
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
        public bool Equals(AssistantStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ThreadStreamEvent?>.Default.Equals(Thread, other.Thread) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStreamEvent?>.Default.Equals(Run, other.Run) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepStreamEvent?>.Default.Equals(RunStep, other.RunStep) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageStreamEvent?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DoneEvent?>.Default.Equals(Done, other.Done) 
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
    }
}
