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
#if NET6_0_OR_GREATER
        public global::OpenAI.ThreadStreamEvent? Thread { get; init; }
#else
        public global::OpenAI.ThreadStreamEvent? Thread { get; }
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
        public static implicit operator AssistantStreamEvent(global::OpenAI.ThreadStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ThreadStreamEvent?(AssistantStreamEvent @this) => @this.Thread;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.ThreadStreamEvent? value)
        {
            Thread = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStreamEvent? Run { get; init; }
#else
        public global::OpenAI.RunStreamEvent? Run { get; }
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
        public static implicit operator AssistantStreamEvent(global::OpenAI.RunStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStreamEvent?(AssistantStreamEvent @this) => @this.Run;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.RunStreamEvent? value)
        {
            Run = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepStreamEvent? RunStep { get; init; }
#else
        public global::OpenAI.RunStepStreamEvent? RunStep { get; }
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
        public static implicit operator AssistantStreamEvent(global::OpenAI.RunStepStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepStreamEvent?(AssistantStreamEvent @this) => @this.RunStep;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.RunStepStreamEvent? value)
        {
            RunStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageStreamEvent? Message { get; init; }
#else
        public global::OpenAI.MessageStreamEvent? Message { get; }
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
        public static implicit operator AssistantStreamEvent(global::OpenAI.MessageStreamEvent value) => new AssistantStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageStreamEvent?(AssistantStreamEvent @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public AssistantStreamEvent(global::OpenAI.MessageStreamEvent? value)
        {
            Message = value;
        }

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
        /// 
        /// </summary>
        public AssistantStreamEvent(
            global::OpenAI.ThreadStreamEvent? thread,
            global::OpenAI.RunStreamEvent? run,
            global::OpenAI.RunStepStreamEvent? runStep,
            global::OpenAI.MessageStreamEvent? message,
            global::OpenAI.ErrorEvent? error,
            global::OpenAI.DoneEvent? done
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
        public bool Validate()
        {
            return IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && IsRun && !IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && IsRunStep && !IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && IsMessage && !IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && IsError && !IsDone || !IsThread && !IsRun && !IsRunStep && !IsMessage && !IsError && IsDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.ThreadStreamEvent?, TResult>? thread = null,
            global::System.Func<global::OpenAI.RunStreamEvent?, TResult>? run = null,
            global::System.Func<global::OpenAI.RunStepStreamEvent?, TResult>? runStep = null,
            global::System.Func<global::OpenAI.MessageStreamEvent?, TResult>? message = null,
            global::System.Func<global::OpenAI.ErrorEvent?, TResult>? error = null,
            global::System.Func<global::OpenAI.DoneEvent?, TResult>? done = null,
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
            global::System.Action<global::OpenAI.ThreadStreamEvent?>? thread = null,
            global::System.Action<global::OpenAI.RunStreamEvent?>? run = null,
            global::System.Action<global::OpenAI.RunStepStreamEvent?>? runStep = null,
            global::System.Action<global::OpenAI.MessageStreamEvent?>? message = null,
            global::System.Action<global::OpenAI.ErrorEvent?>? error = null,
            global::System.Action<global::OpenAI.DoneEvent?>? done = null,
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
                typeof(global::OpenAI.ThreadStreamEvent),
                Run,
                typeof(global::OpenAI.RunStreamEvent),
                RunStep,
                typeof(global::OpenAI.RunStepStreamEvent),
                Message,
                typeof(global::OpenAI.MessageStreamEvent),
                Error,
                typeof(global::OpenAI.ErrorEvent),
                Done,
                typeof(global::OpenAI.DoneEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ThreadStreamEvent?>.Default.Equals(Thread, other.Thread) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStreamEvent?>.Default.Equals(Run, other.Run) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepStreamEvent?>.Default.Equals(RunStep, other.RunStep) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageStreamEvent?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.DoneEvent?>.Default.Equals(Done, other.Done) 
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
