#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationsItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.AnnotationsItem4>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.AnnotationsItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.BetaFileCitationParam? fileCitation = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaFileCitationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaFileCitationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaFileCitationParam)}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaUrlCitationParam? urlCitation = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType.UrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaUrlCitationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaUrlCitationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaUrlCitationParam)}");
                urlCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaContainerFileCitationParam? containerFileCitation = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType.ContainerFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerFileCitationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaContainerFileCitationParam)}");
                containerFileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.AnnotationsItem4(
                discriminator?.Type,
                fileCitation,

                urlCitation,

                containerFileCitation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.AnnotationsItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaFileCitationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaFileCitationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaFileCitationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation!, typeInfo);
            }
            else if (value.IsUrlCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaUrlCitationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaUrlCitationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaUrlCitationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UrlCitation!, typeInfo);
            }
            else if (value.IsContainerFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerFileCitationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerFileCitation!, typeInfo);
            }
        }
    }
}