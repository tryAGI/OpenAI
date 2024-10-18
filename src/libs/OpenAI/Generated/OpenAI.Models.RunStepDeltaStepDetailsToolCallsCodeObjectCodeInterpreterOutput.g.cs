using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput : global::System.IEquatable<RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// Text output from the Code Interpreter tool call as part of a run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Logs { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Logs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Logs))]
#endif
        public bool IsLogs => Logs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject value) => new RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Image { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject value) => new RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? type,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? logs,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? image
            )
        {
            Type = type;

            Logs = logs;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Logs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLogs && !IsImage || !IsLogs && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?, TResult>? logs = null,
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs && logs != null)
            {
                return logs(Logs!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?>? logs = null,
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs)
            {
                logs?.Invoke(Logs!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Logs,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject),
                Image,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject),
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
        public bool Equals(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput o && Equals(o);
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
        public static global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput),
                jsonSerializerContext) as global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>(
                json,
                jsonSerializerOptions);
        }

    }
}
