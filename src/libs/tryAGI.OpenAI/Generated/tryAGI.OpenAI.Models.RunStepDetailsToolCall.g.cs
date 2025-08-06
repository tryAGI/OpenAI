#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDetailsToolCall : global::System.IEquatable<RunStepDetailsToolCall>
    {
        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? CallsCodeObject { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? CallsCodeObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallsCodeObject))]
#endif
        public bool IsCallsCodeObject => CallsCodeObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject value) => new RunStepDetailsToolCall((global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?(RunStepDetailsToolCall @this) => @this.CallsCodeObject;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? value)
        {
            CallsCodeObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? CallsFileSearchObject { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? CallsFileSearchObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallsFileSearchObject))]
#endif
        public bool IsCallsFileSearchObject => CallsFileSearchObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject value) => new RunStepDetailsToolCall((global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?(RunStepDetailsToolCall @this) => @this.CallsFileSearchObject;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? value)
        {
            CallsFileSearchObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? CallsFunctionObject { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? CallsFunctionObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallsFunctionObject))]
#endif
        public bool IsCallsFunctionObject => CallsFunctionObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject value) => new RunStepDetailsToolCall((global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?(RunStepDetailsToolCall @this) => @this.CallsFunctionObject;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? value)
        {
            CallsFunctionObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCall(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject? callsCodeObject,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject? callsFileSearchObject,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject? callsFunctionObject
            )
        {
            CallsCodeObject = callsCodeObject;
            CallsFileSearchObject = callsFileSearchObject;
            CallsFunctionObject = callsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CallsFunctionObject as object ??
            CallsFileSearchObject as object ??
            CallsCodeObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CallsCodeObject?.ToString() ??
            CallsFileSearchObject?.ToString() ??
            CallsFunctionObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCallsCodeObject || IsCallsFileSearchObject || IsCallsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?, TResult>? callsCodeObject = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?, TResult>? callsFileSearchObject = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?, TResult>? callsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallsCodeObject && callsCodeObject != null)
            {
                return callsCodeObject(CallsCodeObject!);
            }
            else if (IsCallsFileSearchObject && callsFileSearchObject != null)
            {
                return callsFileSearchObject(CallsFileSearchObject!);
            }
            else if (IsCallsFunctionObject && callsFunctionObject != null)
            {
                return callsFunctionObject(CallsFunctionObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?>? callsCodeObject = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?>? callsFileSearchObject = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?>? callsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallsCodeObject)
            {
                callsCodeObject?.Invoke(CallsCodeObject!);
            }
            else if (IsCallsFileSearchObject)
            {
                callsFileSearchObject?.Invoke(CallsFileSearchObject!);
            }
            else if (IsCallsFunctionObject)
            {
                callsFunctionObject?.Invoke(CallsFunctionObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CallsCodeObject,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject),
                CallsFileSearchObject,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject),
                CallsFunctionObject,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject),
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
        public bool Equals(RunStepDetailsToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeObject?>.Default.Equals(CallsCodeObject, other.CallsCodeObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchObject?>.Default.Equals(CallsFileSearchObject, other.CallsFileSearchObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsFunctionObject?>.Default.Equals(CallsFunctionObject, other.CallsFunctionObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDetailsToolCall obj1, RunStepDetailsToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDetailsToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDetailsToolCall obj1, RunStepDetailsToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDetailsToolCall o && Equals(o);
        }
    }
}
