#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class Provider2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Provider2>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Provider2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? aws = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? azure = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? gcp = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Provider2(
                discriminator?.Type,
                aws,

                azure,

                gcp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Provider2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
        }
    }
}