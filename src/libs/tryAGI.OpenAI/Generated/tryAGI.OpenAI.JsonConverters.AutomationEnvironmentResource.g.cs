#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AutomationEnvironmentResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.AutomationEnvironmentResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.AutomationEnvironmentResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.AutomationEnvironmentResourceNone? none = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted? openaiHosted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType.OpenaiHosted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted)}");
                openaiHosted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted? selfHosted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AutomationEnvironmentResourceDiscriminatorType.SelfHosted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted)}");
                selfHosted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.AutomationEnvironmentResource(
                discriminator?.Type,
                none,

                openaiHosted,

                selfHosted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.AutomationEnvironmentResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNone(), typeInfo);
            }
            else if (value.IsOpenaiHosted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceOpenaiHosted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenaiHosted(), typeInfo);
            }
            else if (value.IsSelfHosted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AutomationEnvironmentResourceSelfHosted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSelfHosted(), typeInfo);
            }
        }
    }
}