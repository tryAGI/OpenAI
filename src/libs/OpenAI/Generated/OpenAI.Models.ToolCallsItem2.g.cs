using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem2 : global::System.IEquatable<ToolCallsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDetailsToolCallsCodeObject? RunStepDetailsCodeObject { get; init; }
#else
        public global::OpenAI.RunStepDetailsToolCallsCodeObject? RunStepDetailsCodeObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDetailsCodeObject))]
#endif
        public bool IsRunStepDetailsCodeObject => RunStepDetailsCodeObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem2(global::OpenAI.RunStepDetailsToolCallsCodeObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDetailsToolCallsCodeObject?(ToolCallsItem2 @this) => @this.RunStepDetailsCodeObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::OpenAI.RunStepDetailsToolCallsCodeObject? value)
        {
            RunStepDetailsCodeObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDetailsToolCallsFileSearchObject? RunStepDetailsFileSearchObject { get; init; }
#else
        public global::OpenAI.RunStepDetailsToolCallsFileSearchObject? RunStepDetailsFileSearchObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDetailsFileSearchObject))]
#endif
        public bool IsRunStepDetailsFileSearchObject => RunStepDetailsFileSearchObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem2(global::OpenAI.RunStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDetailsToolCallsFileSearchObject?(ToolCallsItem2 @this) => @this.RunStepDetailsFileSearchObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::OpenAI.RunStepDetailsToolCallsFileSearchObject? value)
        {
            RunStepDetailsFileSearchObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDetailsToolCallsFunctionObject? RunStepDetailsFunctionObject { get; init; }
#else
        public global::OpenAI.RunStepDetailsToolCallsFunctionObject? RunStepDetailsFunctionObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDetailsFunctionObject))]
#endif
        public bool IsRunStepDetailsFunctionObject => RunStepDetailsFunctionObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem2(global::OpenAI.RunStepDetailsToolCallsFunctionObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDetailsToolCallsFunctionObject?(ToolCallsItem2 @this) => @this.RunStepDetailsFunctionObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::OpenAI.RunStepDetailsToolCallsFunctionObject? value)
        {
            RunStepDetailsFunctionObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(
            global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::OpenAI.RunStepDetailsToolCallsCodeObject? runStepDetailsCodeObject,
            global::OpenAI.RunStepDetailsToolCallsFileSearchObject? runStepDetailsFileSearchObject,
            global::OpenAI.RunStepDetailsToolCallsFunctionObject? runStepDetailsFunctionObject
            )
        {
            Type = type;

            RunStepDetailsCodeObject = runStepDetailsCodeObject;
            RunStepDetailsFileSearchObject = runStepDetailsFileSearchObject;
            RunStepDetailsFunctionObject = runStepDetailsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunStepDetailsFunctionObject as object ??
            RunStepDetailsFileSearchObject as object ??
            RunStepDetailsCodeObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunStepDetailsCodeObject && !IsRunStepDetailsFileSearchObject && !IsRunStepDetailsFunctionObject || !IsRunStepDetailsCodeObject && IsRunStepDetailsFileSearchObject && !IsRunStepDetailsFunctionObject || !IsRunStepDetailsCodeObject && !IsRunStepDetailsFileSearchObject && IsRunStepDetailsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.RunStepDetailsToolCallsCodeObject?, TResult>? runStepDetailsCodeObject = null,
            global::System.Func<global::OpenAI.RunStepDetailsToolCallsFileSearchObject?, TResult>? runStepDetailsFileSearchObject = null,
            global::System.Func<global::OpenAI.RunStepDetailsToolCallsFunctionObject?, TResult>? runStepDetailsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepDetailsCodeObject && runStepDetailsCodeObject != null)
            {
                return runStepDetailsCodeObject(RunStepDetailsCodeObject!);
            }
            else if (IsRunStepDetailsFileSearchObject && runStepDetailsFileSearchObject != null)
            {
                return runStepDetailsFileSearchObject(RunStepDetailsFileSearchObject!);
            }
            else if (IsRunStepDetailsFunctionObject && runStepDetailsFunctionObject != null)
            {
                return runStepDetailsFunctionObject(RunStepDetailsFunctionObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.RunStepDetailsToolCallsCodeObject?>? runStepDetailsCodeObject = null,
            global::System.Action<global::OpenAI.RunStepDetailsToolCallsFileSearchObject?>? runStepDetailsFileSearchObject = null,
            global::System.Action<global::OpenAI.RunStepDetailsToolCallsFunctionObject?>? runStepDetailsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepDetailsCodeObject)
            {
                runStepDetailsCodeObject?.Invoke(RunStepDetailsCodeObject!);
            }
            else if (IsRunStepDetailsFileSearchObject)
            {
                runStepDetailsFileSearchObject?.Invoke(RunStepDetailsFileSearchObject!);
            }
            else if (IsRunStepDetailsFunctionObject)
            {
                runStepDetailsFunctionObject?.Invoke(RunStepDetailsFunctionObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStepDetailsCodeObject,
                typeof(global::OpenAI.RunStepDetailsToolCallsCodeObject),
                RunStepDetailsFileSearchObject,
                typeof(global::OpenAI.RunStepDetailsToolCallsFileSearchObject),
                RunStepDetailsFunctionObject,
                typeof(global::OpenAI.RunStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDetailsToolCallsCodeObject?>.Default.Equals(RunStepDetailsCodeObject, other.RunStepDetailsCodeObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDetailsToolCallsFileSearchObject?>.Default.Equals(RunStepDetailsFileSearchObject, other.RunStepDetailsFileSearchObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDetailsToolCallsFunctionObject?>.Default.Equals(RunStepDetailsFunctionObject, other.RunStepDetailsFunctionObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem2 obj1, ToolCallsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem2 obj1, ToolCallsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem2 o && Equals(o);
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
        public static global::OpenAI.ToolCallsItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ToolCallsItem2),
                jsonSerializerContext) as global::OpenAI.ToolCallsItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ToolCallsItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ToolCallsItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
