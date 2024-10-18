#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant3ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.InputVariant3Item>
    {
        /// <inheritdoc />
        public override global::OpenAI.InputVariant3Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1? value1 = default;
            if (discriminator?.Type == global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2? value2 = default;
            if (discriminator?.Type == global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.InputVariant3Item(
                discriminator?.Type,
                value1,
                value2
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.InputVariant3Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}