#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class BetaResponseSteerRequiredInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.BetaResponseSteerRequiredInput>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.BetaResponseSteerRequiredInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? functionCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.FunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput)}");
                functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? customToolCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.CustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput)}");
                customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? computerCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.ComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput)}");
                computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? shellCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.ShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput)}");
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? applyPatchCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.ApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput)}");
                applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? toolSearchOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.ToolSearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput)}");
                toolSearchOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? mcpApprovalResponse = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType.McpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse)}");
                mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.BetaResponseSteerRequiredInput(
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
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput!, typeInfo);
            }
            else if (value.IsCustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutput!, typeInfo);
            }
            else if (value.IsComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCallOutput!, typeInfo);
            }
            else if (value.IsShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput!, typeInfo);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput!, typeInfo);
            }
            else if (value.IsToolSearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchOutput!, typeInfo);
            }
            else if (value.IsMcpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse!, typeInfo);
            }
        }
    }
}