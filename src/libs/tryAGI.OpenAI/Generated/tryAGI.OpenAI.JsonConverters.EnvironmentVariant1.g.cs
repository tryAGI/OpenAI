#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class EnvironmentVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.EnvironmentVariant1>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.EnvironmentVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.ContainerAutoParam? containerAuto = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ContainerAutoParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ContainerAutoParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ContainerAutoParam)}");
                containerAuto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LocalEnvironmentParam? local = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType.Local)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalEnvironmentParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalEnvironmentParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LocalEnvironmentParam)}");
                local = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ContainerReferenceParam? containerReference = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType.ContainerReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ContainerReferenceParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ContainerReferenceParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ContainerReferenceParam)}");
                containerReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.EnvironmentVariant1(
                discriminator?.Type,
                containerAuto,

                local,

                containerReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.EnvironmentVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsContainerAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ContainerAutoParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ContainerAutoParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ContainerAutoParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerAuto!, typeInfo);
            }
            else if (value.IsLocal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalEnvironmentParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalEnvironmentParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalEnvironmentParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Local!, typeInfo);
            }
            else if (value.IsContainerReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ContainerReferenceParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ContainerReferenceParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ContainerReferenceParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerReference!, typeInfo);
            }
        }
    }
}