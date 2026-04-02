#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeConversationItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeConversationItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeConversationItem Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("object")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("object")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("object")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("arguments")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("object")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("object")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score5++;
            if (__jsonProps.Contains("approve")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("reason")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("server_label")) __score6++;
            if (__jsonProps.Contains("tools")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score7++;
            if (__jsonProps.Contains("arguments")) __score7++;
            if (__jsonProps.Contains("error")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("output")) __score7++;
            if (__jsonProps.Contains("server_label")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("arguments")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("server_label")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem? message1 = default;
            global::tryAGI.OpenAI.RealtimeConversationItemMessageUser? message2 = default;
            global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant? message3 = default;
            global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall? functionCall = default;
            global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput? functionCallOutput = default;
            global::tryAGI.OpenAI.RealtimeMCPApprovalResponse? mcpApprovalResponse = default;
            global::tryAGI.OpenAI.RealtimeMCPListTools? mcpListTools = default;
            global::tryAGI.OpenAI.RealtimeMCPToolCall? mcpCall = default;
            global::tryAGI.OpenAI.RealtimeMCPApprovalRequest? mcpApprovalRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        message1 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem>(__rawJson, options);
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
                        message2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemMessageUser>(__rawJson, options);
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
                        message3 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPApprovalResponse>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPListTools>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPToolCall>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPApprovalRequest>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message1 == null && message2 == null && message3 == null && functionCall == null && functionCallOutput == null && mcpApprovalResponse == null && mcpListTools == null && mcpCall == null && mcpApprovalRequest == null)
            {
                try
                {
                    message1 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    message2 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemMessageUser>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    message3 = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPApprovalResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPListTools>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeMCPApprovalRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.RealtimeConversationItem(
                message1,

                message2,

                message3,

                functionCall,

                functionCallOutput,

                mcpApprovalResponse,

                mcpListTools,

                mcpCall,

                mcpApprovalRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeConversationItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessage1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message1, typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageSystem), options);
            }
            else if (value.IsMessage2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message2, typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageUser), options);
            }
            else if (value.IsMessage3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message3, typeof(global::tryAGI.OpenAI.RealtimeConversationItemMessageAssistant), options);
            }
            else if (value.IsFunctionCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall, typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCall), options);
            }
            else if (value.IsFunctionCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput, typeof(global::tryAGI.OpenAI.RealtimeConversationItemFunctionCallOutput), options);
            }
            else if (value.IsMcpApprovalResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse, typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalResponse), options);
            }
            else if (value.IsMcpListTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools, typeof(global::tryAGI.OpenAI.RealtimeMCPListTools), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::tryAGI.OpenAI.RealtimeMCPToolCall), options);
            }
            else if (value.IsMcpApprovalRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest, typeof(global::tryAGI.OpenAI.RealtimeMCPApprovalRequest), options);
            }
        }
    }
}