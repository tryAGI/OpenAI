#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class StatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Status>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Status Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("reason")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("reason")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.ActiveStatus? active = default;
            global::tryAGI.OpenAI.LockedStatus? locked = default;
            global::tryAGI.OpenAI.ClosedStatus? closed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        active = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ActiveStatus>(__rawJson, options);
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
                        locked = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LockedStatus>(__rawJson, options);
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
                        closed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ClosedStatus>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (active == null && locked == null && closed == null)
            {
                try
                {
                    active = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ActiveStatus>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    locked = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LockedStatus>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    closed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ClosedStatus>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.Status(
                active,

                locked,

                closed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Status value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsActive)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Active, typeof(global::tryAGI.OpenAI.ActiveStatus), options);
            }
            else if (value.IsLocked)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Locked, typeof(global::tryAGI.OpenAI.LockedStatus), options);
            }
            else if (value.IsClosed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Closed, typeof(global::tryAGI.OpenAI.ClosedStatus), options);
            }
        }
    }
}