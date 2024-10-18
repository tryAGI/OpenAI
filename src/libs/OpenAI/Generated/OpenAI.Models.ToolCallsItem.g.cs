using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem : global::System.IEquatable<ToolCallsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? RunStepDeltaDetailsCodeObject { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? RunStepDeltaDetailsCodeObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDeltaDetailsCodeObject))]
#endif
        public bool IsRunStepDeltaDetailsCodeObject => RunStepDeltaDetailsCodeObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?(ToolCallsItem @this) => @this.RunStepDeltaDetailsCodeObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? value)
        {
            RunStepDeltaDetailsCodeObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? RunStepDeltaDetailsFileSearchObject { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? RunStepDeltaDetailsFileSearchObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDeltaDetailsFileSearchObject))]
#endif
        public bool IsRunStepDeltaDetailsFileSearchObject => RunStepDeltaDetailsFileSearchObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem(global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?(ToolCallsItem @this) => @this.RunStepDeltaDetailsFileSearchObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? value)
        {
            RunStepDeltaDetailsFileSearchObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? RunStepDeltaDetailsFunctionObject { get; init; }
#else
        public global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? RunStepDeltaDetailsFunctionObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStepDeltaDetailsFunctionObject))]
#endif
        public bool IsRunStepDeltaDetailsFunctionObject => RunStepDeltaDetailsFunctionObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallsItem(global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?(ToolCallsItem @this) => @this.RunStepDeltaDetailsFunctionObject;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? value)
        {
            RunStepDeltaDetailsFunctionObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(
            global::OpenAI.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? runStepDeltaDetailsCodeObject,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? runStepDeltaDetailsFileSearchObject,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? runStepDeltaDetailsFunctionObject
            )
        {
            Type = type;

            RunStepDeltaDetailsCodeObject = runStepDeltaDetailsCodeObject;
            RunStepDeltaDetailsFileSearchObject = runStepDeltaDetailsFileSearchObject;
            RunStepDeltaDetailsFunctionObject = runStepDeltaDetailsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunStepDeltaDetailsFunctionObject as object ??
            RunStepDeltaDetailsFileSearchObject as object ??
            RunStepDeltaDetailsCodeObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunStepDeltaDetailsCodeObject && !IsRunStepDeltaDetailsFileSearchObject && !IsRunStepDeltaDetailsFunctionObject || !IsRunStepDeltaDetailsCodeObject && IsRunStepDeltaDetailsFileSearchObject && !IsRunStepDeltaDetailsFunctionObject || !IsRunStepDeltaDetailsCodeObject && !IsRunStepDeltaDetailsFileSearchObject && IsRunStepDeltaDetailsFunctionObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?, TResult>? runStepDeltaDetailsCodeObject = null,
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?, TResult>? runStepDeltaDetailsFileSearchObject = null,
            global::System.Func<global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?, TResult>? runStepDeltaDetailsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepDeltaDetailsCodeObject && runStepDeltaDetailsCodeObject != null)
            {
                return runStepDeltaDetailsCodeObject(RunStepDeltaDetailsCodeObject!);
            }
            else if (IsRunStepDeltaDetailsFileSearchObject && runStepDeltaDetailsFileSearchObject != null)
            {
                return runStepDeltaDetailsFileSearchObject(RunStepDeltaDetailsFileSearchObject!);
            }
            else if (IsRunStepDeltaDetailsFunctionObject && runStepDeltaDetailsFunctionObject != null)
            {
                return runStepDeltaDetailsFunctionObject(RunStepDeltaDetailsFunctionObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?>? runStepDeltaDetailsCodeObject = null,
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?>? runStepDeltaDetailsFileSearchObject = null,
            global::System.Action<global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?>? runStepDeltaDetailsFunctionObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStepDeltaDetailsCodeObject)
            {
                runStepDeltaDetailsCodeObject?.Invoke(RunStepDeltaDetailsCodeObject!);
            }
            else if (IsRunStepDeltaDetailsFileSearchObject)
            {
                runStepDeltaDetailsFileSearchObject?.Invoke(RunStepDeltaDetailsFileSearchObject!);
            }
            else if (IsRunStepDeltaDetailsFunctionObject)
            {
                runStepDeltaDetailsFunctionObject?.Invoke(RunStepDeltaDetailsFunctionObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStepDeltaDetailsCodeObject,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject),
                RunStepDeltaDetailsFileSearchObject,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject),
                RunStepDeltaDetailsFunctionObject,
                typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?>.Default.Equals(RunStepDeltaDetailsCodeObject, other.RunStepDeltaDetailsCodeObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?>.Default.Equals(RunStepDeltaDetailsFileSearchObject, other.RunStepDeltaDetailsFileSearchObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?>.Default.Equals(RunStepDeltaDetailsFunctionObject, other.RunStepDeltaDetailsFunctionObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem o && Equals(o);
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
        public static global::OpenAI.ToolCallsItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ToolCallsItem),
                jsonSerializerContext) as global::OpenAI.ToolCallsItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ToolCallsItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ToolCallsItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
