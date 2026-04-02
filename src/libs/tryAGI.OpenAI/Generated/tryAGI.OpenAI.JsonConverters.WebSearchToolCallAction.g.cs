#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class WebSearchToolCallActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.WebSearchToolCallAction>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.WebSearchToolCallAction Read(
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
            if (__jsonProps.Contains("queries")) __score0++;
            if (__jsonProps.Contains("query")) __score0++;
            if (__jsonProps.Contains("sources")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("pattern")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.WebSearchActionSearch? search = default;
            global::tryAGI.OpenAI.WebSearchActionOpenPage? openPage = default;
            global::tryAGI.OpenAI.WebSearchActionFind? findInPage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        search = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchActionSearch>(__rawJson, options);
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
                        openPage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchActionOpenPage>(__rawJson, options);
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
                        findInPage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchActionFind>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (search == null && openPage == null && findInPage == null)
            {
                try
                {
                    search = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchActionSearch>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    openPage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchActionOpenPage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    findInPage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchActionFind>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.WebSearchToolCallAction(
                search,

                openPage,

                findInPage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.WebSearchToolCallAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search, typeof(global::tryAGI.OpenAI.WebSearchActionSearch), options);
            }
            else if (value.IsOpenPage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenPage, typeof(global::tryAGI.OpenAI.WebSearchActionOpenPage), options);
            }
            else if (value.IsFindInPage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FindInPage, typeof(global::tryAGI.OpenAI.WebSearchActionFind), options);
            }
        }
    }
}