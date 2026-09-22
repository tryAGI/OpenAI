#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class PersistedAgentToolConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.PersistedAgentToolConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? function = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? toolSearch = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType.ToolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch)}");
                toolSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? programmaticToolCalling = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType.ProgrammaticToolCalling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling)}");
                programmaticToolCalling = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? mcp = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? webSearch = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.PersistedAgentToolConfigParam(
                discriminator?.Type,
                function,

                toolSearch,

                programmaticToolCalling,

                mcp,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsToolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearch!, typeInfo);
            }
            else if (value.IsProgrammaticToolCalling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProgrammaticToolCalling!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
        }
    }
}