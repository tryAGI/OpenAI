#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ApplyPatchOperationParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ApplyPatchOperationParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ApplyPatchOperationParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? createFile = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType.CreateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam)}");
                createFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? deleteFile = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType.DeleteFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam)}");
                deleteFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? updateFile = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType.UpdateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam)}");
                updateFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.ApplyPatchOperationParam(
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
            global::tryAGI.OpenAI.ApplyPatchOperationParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateFile!, typeInfo);
            }
            else if (value.IsDeleteFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteFile!, typeInfo);
            }
            else if (value.IsUpdateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateFile!, typeInfo);
            }
        }
    }
}