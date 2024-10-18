using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput : global::System.IEquatable<RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// Text output from the Code Interpreter tool call as part of a run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Logs { get; init; }
#else
        public global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Logs { get; }
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
        public static implicit operator RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject value) => new RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Image { get; init; }
#else
        public global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Image { get; }
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
        public static implicit operator RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject value) => new RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
            global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? type,
            global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? logs,
            global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? image
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
            global::System.Func<global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?, TResult>? logs = null,
            global::System.Func<global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?, TResult>? image = null,
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
            global::System.Action<global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?>? logs = null,
            global::System.Action<global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?>? image = null,
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
                typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject),
                Image,
                typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject),
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
        public bool Equals(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput o && Equals(o);
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
        public static global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput),
                jsonSerializerContext) as global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>(
                json,
                jsonSerializerOptions);
        }

    }
}
