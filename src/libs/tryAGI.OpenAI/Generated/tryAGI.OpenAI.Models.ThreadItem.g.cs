#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ThreadItem : global::System.IEquatable<ThreadItem>
    {
        /// <summary>
        /// User-authored messages within a thread.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UserMessageItem? ChatkitUserMessage { get; init; }
#else
        public global::tryAGI.OpenAI.UserMessageItem? ChatkitUserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatkitUserMessage))]
#endif
        public bool IsChatkitUserMessage => ChatkitUserMessage != null;

        /// <summary>
        /// Assistant-authored message within a thread.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantMessageItem? ChatkitAssistantMessage { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantMessageItem? ChatkitAssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatkitAssistantMessage))]
#endif
        public bool IsChatkitAssistantMessage => ChatkitAssistantMessage != null;

        /// <summary>
        /// Thread item that renders a widget payload.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WidgetMessageItem? ChatkitWidget { get; init; }
#else
        public global::tryAGI.OpenAI.WidgetMessageItem? ChatkitWidget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatkitWidget))]
#endif
        public bool IsChatkitWidget => ChatkitWidget != null;

        /// <summary>
        /// Record of a client side tool invocation initiated by the assistant.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ClientToolCallItem? ChatkitClientToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.ClientToolCallItem? ChatkitClientToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatkitClientToolCall))]
#endif
        public bool IsChatkitClientToolCall => ChatkitClientToolCall != null;

        /// <summary>
        /// Task emitted by the workflow to show progress and status updates.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TaskItem? ChatkitTask { get; init; }
#else
        public global::tryAGI.OpenAI.TaskItem? ChatkitTask { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatkitTask))]
#endif
        public bool IsChatkitTask => ChatkitTask != null;

        /// <summary>
        /// Collection of workflow tasks grouped together in the thread.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TaskGroupItem? ChatkitTaskGroup { get; init; }
#else
        public global::tryAGI.OpenAI.TaskGroupItem? ChatkitTaskGroup { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatkitTaskGroup))]
#endif
        public bool IsChatkitTaskGroup => ChatkitTaskGroup != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadItem(global::tryAGI.OpenAI.UserMessageItem value) => new ThreadItem((global::tryAGI.OpenAI.UserMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UserMessageItem?(ThreadItem @this) => @this.ChatkitUserMessage;

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(global::tryAGI.OpenAI.UserMessageItem? value)
        {
            ChatkitUserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadItem(global::tryAGI.OpenAI.AssistantMessageItem value) => new ThreadItem((global::tryAGI.OpenAI.AssistantMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantMessageItem?(ThreadItem @this) => @this.ChatkitAssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(global::tryAGI.OpenAI.AssistantMessageItem? value)
        {
            ChatkitAssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadItem(global::tryAGI.OpenAI.WidgetMessageItem value) => new ThreadItem((global::tryAGI.OpenAI.WidgetMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WidgetMessageItem?(ThreadItem @this) => @this.ChatkitWidget;

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(global::tryAGI.OpenAI.WidgetMessageItem? value)
        {
            ChatkitWidget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadItem(global::tryAGI.OpenAI.ClientToolCallItem value) => new ThreadItem((global::tryAGI.OpenAI.ClientToolCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ClientToolCallItem?(ThreadItem @this) => @this.ChatkitClientToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(global::tryAGI.OpenAI.ClientToolCallItem? value)
        {
            ChatkitClientToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadItem(global::tryAGI.OpenAI.TaskItem value) => new ThreadItem((global::tryAGI.OpenAI.TaskItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TaskItem?(ThreadItem @this) => @this.ChatkitTask;

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(global::tryAGI.OpenAI.TaskItem? value)
        {
            ChatkitTask = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ThreadItem(global::tryAGI.OpenAI.TaskGroupItem value) => new ThreadItem((global::tryAGI.OpenAI.TaskGroupItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TaskGroupItem?(ThreadItem @this) => @this.ChatkitTaskGroup;

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(global::tryAGI.OpenAI.TaskGroupItem? value)
        {
            ChatkitTaskGroup = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ThreadItem(
            global::tryAGI.OpenAI.UserMessageItem? chatkitUserMessage,
            global::tryAGI.OpenAI.AssistantMessageItem? chatkitAssistantMessage,
            global::tryAGI.OpenAI.WidgetMessageItem? chatkitWidget,
            global::tryAGI.OpenAI.ClientToolCallItem? chatkitClientToolCall,
            global::tryAGI.OpenAI.TaskItem? chatkitTask,
            global::tryAGI.OpenAI.TaskGroupItem? chatkitTaskGroup
            )
        {
            ChatkitUserMessage = chatkitUserMessage;
            ChatkitAssistantMessage = chatkitAssistantMessage;
            ChatkitWidget = chatkitWidget;
            ChatkitClientToolCall = chatkitClientToolCall;
            ChatkitTask = chatkitTask;
            ChatkitTaskGroup = chatkitTaskGroup;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatkitTaskGroup as object ??
            ChatkitTask as object ??
            ChatkitClientToolCall as object ??
            ChatkitWidget as object ??
            ChatkitAssistantMessage as object ??
            ChatkitUserMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatkitUserMessage?.ToString() ??
            ChatkitAssistantMessage?.ToString() ??
            ChatkitWidget?.ToString() ??
            ChatkitClientToolCall?.ToString() ??
            ChatkitTask?.ToString() ??
            ChatkitTaskGroup?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatkitUserMessage && !IsChatkitAssistantMessage && !IsChatkitWidget && !IsChatkitClientToolCall && !IsChatkitTask && !IsChatkitTaskGroup || !IsChatkitUserMessage && IsChatkitAssistantMessage && !IsChatkitWidget && !IsChatkitClientToolCall && !IsChatkitTask && !IsChatkitTaskGroup || !IsChatkitUserMessage && !IsChatkitAssistantMessage && IsChatkitWidget && !IsChatkitClientToolCall && !IsChatkitTask && !IsChatkitTaskGroup || !IsChatkitUserMessage && !IsChatkitAssistantMessage && !IsChatkitWidget && IsChatkitClientToolCall && !IsChatkitTask && !IsChatkitTaskGroup || !IsChatkitUserMessage && !IsChatkitAssistantMessage && !IsChatkitWidget && !IsChatkitClientToolCall && IsChatkitTask && !IsChatkitTaskGroup || !IsChatkitUserMessage && !IsChatkitAssistantMessage && !IsChatkitWidget && !IsChatkitClientToolCall && !IsChatkitTask && IsChatkitTaskGroup;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.UserMessageItem?, TResult>? chatkitUserMessage = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantMessageItem?, TResult>? chatkitAssistantMessage = null,
            global::System.Func<global::tryAGI.OpenAI.WidgetMessageItem?, TResult>? chatkitWidget = null,
            global::System.Func<global::tryAGI.OpenAI.ClientToolCallItem?, TResult>? chatkitClientToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.TaskItem?, TResult>? chatkitTask = null,
            global::System.Func<global::tryAGI.OpenAI.TaskGroupItem?, TResult>? chatkitTaskGroup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatkitUserMessage && chatkitUserMessage != null)
            {
                return chatkitUserMessage(ChatkitUserMessage!);
            }
            else if (IsChatkitAssistantMessage && chatkitAssistantMessage != null)
            {
                return chatkitAssistantMessage(ChatkitAssistantMessage!);
            }
            else if (IsChatkitWidget && chatkitWidget != null)
            {
                return chatkitWidget(ChatkitWidget!);
            }
            else if (IsChatkitClientToolCall && chatkitClientToolCall != null)
            {
                return chatkitClientToolCall(ChatkitClientToolCall!);
            }
            else if (IsChatkitTask && chatkitTask != null)
            {
                return chatkitTask(ChatkitTask!);
            }
            else if (IsChatkitTaskGroup && chatkitTaskGroup != null)
            {
                return chatkitTaskGroup(ChatkitTaskGroup!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.UserMessageItem?>? chatkitUserMessage = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantMessageItem?>? chatkitAssistantMessage = null,
            global::System.Action<global::tryAGI.OpenAI.WidgetMessageItem?>? chatkitWidget = null,
            global::System.Action<global::tryAGI.OpenAI.ClientToolCallItem?>? chatkitClientToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.TaskItem?>? chatkitTask = null,
            global::System.Action<global::tryAGI.OpenAI.TaskGroupItem?>? chatkitTaskGroup = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatkitUserMessage)
            {
                chatkitUserMessage?.Invoke(ChatkitUserMessage!);
            }
            else if (IsChatkitAssistantMessage)
            {
                chatkitAssistantMessage?.Invoke(ChatkitAssistantMessage!);
            }
            else if (IsChatkitWidget)
            {
                chatkitWidget?.Invoke(ChatkitWidget!);
            }
            else if (IsChatkitClientToolCall)
            {
                chatkitClientToolCall?.Invoke(ChatkitClientToolCall!);
            }
            else if (IsChatkitTask)
            {
                chatkitTask?.Invoke(ChatkitTask!);
            }
            else if (IsChatkitTaskGroup)
            {
                chatkitTaskGroup?.Invoke(ChatkitTaskGroup!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatkitUserMessage,
                typeof(global::tryAGI.OpenAI.UserMessageItem),
                ChatkitAssistantMessage,
                typeof(global::tryAGI.OpenAI.AssistantMessageItem),
                ChatkitWidget,
                typeof(global::tryAGI.OpenAI.WidgetMessageItem),
                ChatkitClientToolCall,
                typeof(global::tryAGI.OpenAI.ClientToolCallItem),
                ChatkitTask,
                typeof(global::tryAGI.OpenAI.TaskItem),
                ChatkitTaskGroup,
                typeof(global::tryAGI.OpenAI.TaskGroupItem),
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
        public bool Equals(ThreadItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UserMessageItem?>.Default.Equals(ChatkitUserMessage, other.ChatkitUserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantMessageItem?>.Default.Equals(ChatkitAssistantMessage, other.ChatkitAssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WidgetMessageItem?>.Default.Equals(ChatkitWidget, other.ChatkitWidget) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ClientToolCallItem?>.Default.Equals(ChatkitClientToolCall, other.ChatkitClientToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TaskItem?>.Default.Equals(ChatkitTask, other.ChatkitTask) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TaskGroupItem?>.Default.Equals(ChatkitTaskGroup, other.ChatkitTaskGroup) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ThreadItem obj1, ThreadItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThreadItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ThreadItem obj1, ThreadItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThreadItem o && Equals(o);
        }
    }
}
