#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponseSteerRequiredInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ResponseSteerRequiredInput>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ResponseSteerRequiredInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? functionCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.FunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput)}");
                functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? customToolCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.CustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput)}");
                customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? computerCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.ComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput)}");
                computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? shellCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.ShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput)}");
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? applyPatchCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.ApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput)}");
                applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? toolSearchOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.ToolSearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput)}");
                toolSearchOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? mcpApprovalResponse = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType.McpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse)}");
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.ResponseSteerRequiredInput(
                discriminator?.Type,
                functionCallOutput,

                customToolCallOutput,

                computerCallOutput,

                shellCallOutput,

                applyPatchCallOutput,

                toolSearchOutput,

                mcpApprovalResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ResponseSteerRequiredInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput!, typeInfo);
            }
            else if (value.IsCustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutput!, typeInfo);
            }
            else if (value.IsComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCallOutput!, typeInfo);
            }
            else if (value.IsShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput!, typeInfo);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput!, typeInfo);
            }
            else if (value.IsToolSearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchOutput!, typeInfo);
            }
            else if (value.IsMcpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse!, typeInfo);
            }
        }
    }
}