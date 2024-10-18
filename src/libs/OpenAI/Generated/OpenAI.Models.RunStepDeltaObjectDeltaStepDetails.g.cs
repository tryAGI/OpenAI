using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The details of the run step.
    /// </summary>
    public readonly partial struct RunStepDeltaObjectDeltaStepDetails : global::System.IEquatable<RunStepDeltaObjectDeltaStepDetails>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the message creation by the run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject? MessageCreation { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject? MessageCreation { get; }
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
        public static implicit operator RunStepDeltaObjectDeltaStepDetails(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject value) => new RunStepDeltaObjectDeltaStepDetails(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject?(RunStepDeltaObjectDeltaStepDetails @this) => @this.MessageCreation;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaObjectDeltaStepDetails(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject? value)
        {
            MessageCreation = value;
        }

        /// <summary>
        /// Details of the tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsObject? ToolCalls { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsObject? ToolCalls { get; }
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
        public static implicit operator RunStepDeltaObjectDeltaStepDetails(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject value) => new RunStepDeltaObjectDeltaStepDetails(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsToolCallsObject?(RunStepDeltaObjectDeltaStepDetails @this) => @this.ToolCalls;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaObjectDeltaStepDetails(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject? value)
        {
            ToolCalls = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaObjectDeltaStepDetails(
            global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType? type,
            global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject? messageCreation,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsObject? toolCalls
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
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject?, TResult>? messageCreation = null,
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsToolCallsObject?, TResult>? toolCalls = null,
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
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject?>? messageCreation = null,
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsToolCallsObject?>? toolCalls = null,
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
                typeof(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject),
                ToolCalls,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject),
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
        public bool Equals(RunStepDeltaObjectDeltaStepDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject?>.Default.Equals(MessageCreation, other.MessageCreation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsToolCallsObject?>.Default.Equals(ToolCalls, other.ToolCalls) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDeltaObjectDeltaStepDetails obj1, RunStepDeltaObjectDeltaStepDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDeltaObjectDeltaStepDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDeltaObjectDeltaStepDetails obj1, RunStepDeltaObjectDeltaStepDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDeltaObjectDeltaStepDetails o && Equals(o);
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
        public static global::OpenAI.RunStepDeltaObjectDeltaStepDetails? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.RunStepDeltaObjectDeltaStepDetails),
                jsonSerializerContext) as global::OpenAI.RunStepDeltaObjectDeltaStepDetails?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.RunStepDeltaObjectDeltaStepDetails? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.RunStepDeltaObjectDeltaStepDetails>(
                json,
                jsonSerializerOptions);
        }

    }
}
