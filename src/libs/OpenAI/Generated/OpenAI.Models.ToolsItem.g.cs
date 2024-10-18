using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem : global::System.IEquatable<ToolsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.AssistantObjectToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantToolsCode? AssistantCode { get; init; }
#else
        public global::OpenAI.AssistantToolsCode? AssistantCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantCode))]
#endif
        public bool IsAssistantCode => AssistantCode != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::OpenAI.AssistantToolsCode value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantToolsCode?(ToolsItem @this) => @this.AssistantCode;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::OpenAI.AssistantToolsCode? value)
        {
            AssistantCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantToolsFileSearch? AssistantFileSearch { get; init; }
#else
        public global::OpenAI.AssistantToolsFileSearch? AssistantFileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantFileSearch))]
#endif
        public bool IsAssistantFileSearch => AssistantFileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::OpenAI.AssistantToolsFileSearch value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantToolsFileSearch?(ToolsItem @this) => @this.AssistantFileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::OpenAI.AssistantToolsFileSearch? value)
        {
            AssistantFileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantToolsFunction? AssistantFunction { get; init; }
#else
        public global::OpenAI.AssistantToolsFunction? AssistantFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantFunction))]
#endif
        public bool IsAssistantFunction => AssistantFunction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::OpenAI.AssistantToolsFunction value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantToolsFunction?(ToolsItem @this) => @this.AssistantFunction;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::OpenAI.AssistantToolsFunction? value)
        {
            AssistantFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::OpenAI.AssistantObjectToolDiscriminatorType? type,
            global::OpenAI.AssistantToolsCode? assistantCode,
            global::OpenAI.AssistantToolsFileSearch? assistantFileSearch,
            global::OpenAI.AssistantToolsFunction? assistantFunction
            )
        {
            Type = type;

            AssistantCode = assistantCode;
            AssistantFileSearch = assistantFileSearch;
            AssistantFunction = assistantFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantFunction as object ??
            AssistantFileSearch as object ??
            AssistantCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistantCode && !IsAssistantFileSearch && !IsAssistantFunction || !IsAssistantCode && IsAssistantFileSearch && !IsAssistantFunction || !IsAssistantCode && !IsAssistantFileSearch && IsAssistantFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.AssistantToolsCode?, TResult>? assistantCode = null,
            global::System.Func<global::OpenAI.AssistantToolsFileSearch?, TResult>? assistantFileSearch = null,
            global::System.Func<global::OpenAI.AssistantToolsFunction?, TResult>? assistantFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantCode && assistantCode != null)
            {
                return assistantCode(AssistantCode!);
            }
            else if (IsAssistantFileSearch && assistantFileSearch != null)
            {
                return assistantFileSearch(AssistantFileSearch!);
            }
            else if (IsAssistantFunction && assistantFunction != null)
            {
                return assistantFunction(AssistantFunction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.AssistantToolsCode?>? assistantCode = null,
            global::System.Action<global::OpenAI.AssistantToolsFileSearch?>? assistantFileSearch = null,
            global::System.Action<global::OpenAI.AssistantToolsFunction?>? assistantFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistantCode)
            {
                assistantCode?.Invoke(AssistantCode!);
            }
            else if (IsAssistantFileSearch)
            {
                assistantFileSearch?.Invoke(AssistantFileSearch!);
            }
            else if (IsAssistantFunction)
            {
                assistantFunction?.Invoke(AssistantFunction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssistantCode,
                typeof(global::OpenAI.AssistantToolsCode),
                AssistantFileSearch,
                typeof(global::OpenAI.AssistantToolsFileSearch),
                AssistantFunction,
                typeof(global::OpenAI.AssistantToolsFunction),
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
        public bool Equals(ToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantToolsCode?>.Default.Equals(AssistantCode, other.AssistantCode) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantToolsFileSearch?>.Default.Equals(AssistantFileSearch, other.AssistantFileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantToolsFunction?>.Default.Equals(AssistantFunction, other.AssistantFunction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem obj1, ToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem obj1, ToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem o && Equals(o);
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
        public static global::OpenAI.ToolsItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ToolsItem),
                jsonSerializerContext) as global::OpenAI.ToolsItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ToolsItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ToolsItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
