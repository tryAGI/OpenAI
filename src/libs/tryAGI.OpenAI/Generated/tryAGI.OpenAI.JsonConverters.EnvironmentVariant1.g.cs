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
            if (__jsonProps.Contains("file_ids")) __score0++;
            if (__jsonProps.Contains("memory_limit")) __score0++;
            if (__jsonProps.Contains("network_policy")) __score0++;
            if (__jsonProps.Contains("skills")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("skills")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("container_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.ContainerAutoParam? containerAuto = default;
            global::tryAGI.OpenAI.LocalEnvironmentParam? local = default;
            global::tryAGI.OpenAI.ContainerReferenceParam? containerReference = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        containerAuto = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ContainerAutoParam>(__rawJson, options);
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
                        local = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalEnvironmentParam>(__rawJson, options);
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
                        containerReference = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ContainerReferenceParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (containerAuto == null && local == null && containerReference == null)
            {
                try
                {
                    containerAuto = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ContainerAutoParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    local = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalEnvironmentParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    containerReference = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ContainerReferenceParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.EnvironmentVariant1(
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

            if (value.IsContainerAuto)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerAuto, typeof(global::tryAGI.OpenAI.ContainerAutoParam), options);
            }
            else if (value.IsLocal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Local, typeof(global::tryAGI.OpenAI.LocalEnvironmentParam), options);
            }
            else if (value.IsContainerReference)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerReference, typeof(global::tryAGI.OpenAI.ContainerReferenceParam), options);
            }
        }
    }
}