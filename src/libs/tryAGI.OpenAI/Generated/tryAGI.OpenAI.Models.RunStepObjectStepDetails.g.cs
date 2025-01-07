#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details of the run step.
    /// </summary>
    public readonly partial struct RunStepObjectStepDetails : global::System.IEquatable<RunStepObjectStepDetails>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.RunStepObjectStepDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the message creation by the run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? MessageCreation { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? MessageCreation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageCreation))]
#endif
        public bool IsMessageCreation => MessageCreation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepObjectStepDetails(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject value) => new RunStepObjectStepDetails(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject?(RunStepObjectStepDetails @this) => @this.MessageCreation;

        /// <summary>
        /// 
        /// </summary>
        public RunStepObjectStepDetails(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? value)
        {
            MessageCreation = value;
        }

        /// <summary>
        /// Details of the tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? ToolCalls { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? ToolCalls { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCalls))]
#endif
        public bool IsToolCalls => ToolCalls != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepObjectStepDetails(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject value) => new RunStepObjectStepDetails(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsObject?(RunStepObjectStepDetails @this) => @this.ToolCalls;

        /// <summary>
        /// 
        /// </summary>
        public RunStepObjectStepDetails(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? value)
        {
            ToolCalls = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepObjectStepDetails(
            global::tryAGI.OpenAI.RunStepObjectStepDetailsDiscriminatorType? type,
            global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject? messageCreation,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsObject? toolCalls
            )
        {
            Type = type;

            MessageCreation = messageCreation;
            ToolCalls = toolCalls;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolCalls as object ??
            MessageCreation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageCreation && !IsToolCalls || !IsMessageCreation && IsToolCalls;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject?, TResult>? messageCreation = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsObject?, TResult>? toolCalls = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageCreation && messageCreation != null)
            {
                return messageCreation(MessageCreation!);
            }
            else if (IsToolCalls && toolCalls != null)
            {
                return toolCalls(ToolCalls!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject?>? messageCreation = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsObject?>? toolCalls = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageCreation)
            {
                messageCreation?.Invoke(MessageCreation!);
            }
            else if (IsToolCalls)
            {
                toolCalls?.Invoke(ToolCalls!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageCreation,
                typeof(global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject),
                ToolCalls,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsObject),
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
        public bool Equals(RunStepObjectStepDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsMessageCreationObject?>.Default.Equals(MessageCreation, other.MessageCreation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsObject?>.Default.Equals(ToolCalls, other.ToolCalls) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepObjectStepDetails obj1, RunStepObjectStepDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepObjectStepDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepObjectStepDetails obj1, RunStepObjectStepDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepObjectStepDetails o && Equals(o);
        }
    }
}
