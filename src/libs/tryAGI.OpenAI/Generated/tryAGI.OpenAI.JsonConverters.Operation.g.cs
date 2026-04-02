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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("diff")) __score0++;
            if (__jsonProps.Contains("path")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("path")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("diff")) __score2++;
            if (__jsonProps.Contains("path")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? createFile = default;
            global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? deleteFile = default;
            global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? updateFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        createFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        deleteFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        updateFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createFile == null && deleteFile == null && updateFile == null)
            {
                try
                {
                    createFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    deleteFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    updateFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.Operation(
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

            if (value.IsCreateFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateFile, typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation), options);
            }
            else if (value.IsDeleteFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteFile, typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation), options);
            }
            else if (value.IsUpdateFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateFile, typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation), options);
            }
        }
    }
}