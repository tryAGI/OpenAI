#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class OperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Operation>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Operation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? createFile = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType.CreateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation)}");
                createFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? deleteFile = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType.DeleteFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation)}");
                deleteFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? updateFile = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType.UpdateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation)}");
                updateFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Operation(
                discriminator?.Type,
                createFile,

                deleteFile,

                updateFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Operation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateFile!, typeInfo);
            }
            else if (value.IsDeleteFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteFile!, typeInfo);
            }
            else if (value.IsUpdateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateFile!, typeInfo);
            }
        }
    }
}