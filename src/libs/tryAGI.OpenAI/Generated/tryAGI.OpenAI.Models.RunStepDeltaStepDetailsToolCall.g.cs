#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDeltaStepDetailsToolCall : global::System.IEquatable<RunStepDeltaStepDetailsToolCall>
    {
        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? CallsCodeObject { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? CallsCodeObject { get; }
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
        public static implicit operator RunStepDeltaStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject value) => new RunStepDeltaStepDetailsToolCall((global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?(RunStepDeltaStepDetailsToolCall @this) => @this.CallsCodeObject;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? value)
        {
            CallsCodeObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? CallsFileSearchObject { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? CallsFileSearchObject { get; }
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
        public static implicit operator RunStepDeltaStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject value) => new RunStepDeltaStepDetailsToolCall((global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?(RunStepDeltaStepDetailsToolCall @this) => @this.CallsFileSearchObject;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? value)
        {
            CallsFileSearchObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? CallsFunctionObject { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? CallsFunctionObject { get; }
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
        public static implicit operator RunStepDeltaStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject value) => new RunStepDeltaStepDetailsToolCall((global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?(RunStepDeltaStepDetailsToolCall @this) => @this.CallsFunctionObject;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCall(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? value)
        {
            CallsFunctionObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCall(
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? callsCodeObject,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? callsFileSearchObject,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? callsFunctionObject
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
            global::System.Func<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?, TResult>? callsCodeObject = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?, TResult>? callsFileSearchObject = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?, TResult>? callsFunctionObject = null,
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
            global::System.Action<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?>? callsCodeObject = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?>? callsFileSearchObject = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?>? callsFunctionObject = null,
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
                typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject),
                CallsFileSearchObject,
                typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject),
                CallsFunctionObject,
                typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject),
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
        public bool Equals(RunStepDeltaStepDetailsToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?>.Default.Equals(CallsCodeObject, other.CallsCodeObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?>.Default.Equals(CallsFileSearchObject, other.CallsFileSearchObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?>.Default.Equals(CallsFunctionObject, other.CallsFunctionObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDeltaStepDetailsToolCall obj1, RunStepDeltaStepDetailsToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDeltaStepDetailsToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDeltaStepDetailsToolCall obj1, RunStepDeltaStepDetailsToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDeltaStepDetailsToolCall o && Equals(o);
        }
    }
}
