#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class Provider3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Provider3>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Provider3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.AwsExternalStorageProviderParams? aws = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AwsExternalStorageProviderParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.AzureExternalStorageProviderParams? azure = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AzureExternalStorageProviderParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.GcpExternalStorageProviderParams? gcp = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GcpExternalStorageProviderParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Provider3(
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
            global::tryAGI.OpenAI.Provider3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AwsExternalStorageProviderParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AzureExternalStorageProviderParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GcpExternalStorageProviderParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
        }
    }
}