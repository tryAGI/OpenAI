#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ComputerUseApprovalResponseParamBrowserAuthentication
    {
        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerContext.Options.GetTypeInfo(typeof(ComputerUseApprovalResponseParamBrowserAuthentication)));
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public string ToJson()
        {
            return ToJson(global::tryAGI.OpenAI.SourceGenerationContextComponent_EC50E43E7B65E9A9.Default);
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
            if (jsonSerializerOptions is null)
            {
                return ToJson(global::tryAGI.OpenAI.SourceGenerationContextComponent_EC50E43E7B65E9A9.Default);
            }

            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                typeof(ComputerUseApprovalResponseParamBrowserAuthentication),
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static T? FromJson<T>(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            where T : ComputerUseApprovalResponseParamBrowserAuthentication
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                jsonSerializerContext.Options.GetTypeInfo(typeof(ComputerUseApprovalResponseParamBrowserAuthentication))) as T;
        }

        /// <summary>
        /// Deserializes a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public static T? FromJson<T>(
            string json)
            where T : ComputerUseApprovalResponseParamBrowserAuthentication
        {
            return FromJson<T>(
                json,
                global::tryAGI.OpenAI.SourceGenerationContextComponent_EC50E43E7B65E9A9.Default);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static T? FromJson<T>(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            where T : ComputerUseApprovalResponseParamBrowserAuthentication
        {
            if (jsonSerializerOptions is null)
            {
                return FromJson<T>(
                    json,
                    global::tryAGI.OpenAI.SourceGenerationContextComponent_EC50E43E7B65E9A9.Default);
            }

            return global::System.Text.Json.JsonSerializer.Deserialize<ComputerUseApprovalResponseParamBrowserAuthentication>(
                json,
                jsonSerializerOptions) as T;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<T?> FromJsonStreamAsync<T>(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
            where T : ComputerUseApprovalResponseParamBrowserAuthentication
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                jsonSerializerContext.Options.GetTypeInfo(typeof(ComputerUseApprovalResponseParamBrowserAuthentication))).ConfigureAwait(false)) as T;
        }

        /// <summary>
        /// Deserializes a JSON stream using the generated default JsonSerializerContext.
        /// </summary>
        public static global::System.Threading.Tasks.ValueTask<T?> FromJsonStreamAsync<T>(
            global::System.IO.Stream jsonStream)
            where T : ComputerUseApprovalResponseParamBrowserAuthentication
        {
            return FromJsonStreamAsync<T>(
                jsonStream,
                global::tryAGI.OpenAI.SourceGenerationContextComponent_EC50E43E7B65E9A9.Default);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static async global::System.Threading.Tasks.ValueTask<T?> FromJsonStreamAsync<T>(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
            where T : ComputerUseApprovalResponseParamBrowserAuthentication
        {
            if (jsonSerializerOptions is null)
            {
                return await FromJsonStreamAsync<T>(
                    jsonStream,
                    global::tryAGI.OpenAI.SourceGenerationContextComponent_EC50E43E7B65E9A9.Default).ConfigureAwait(false);
            }

            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync<ComputerUseApprovalResponseParamBrowserAuthentication?>(
                jsonStream,
                jsonSerializerOptions).ConfigureAwait(false)) as T;
        }
    }
}
