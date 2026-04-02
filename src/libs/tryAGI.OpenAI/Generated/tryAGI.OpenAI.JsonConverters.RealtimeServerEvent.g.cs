#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeServerEvent Read(
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
            if (__jsonProps.Contains("conversation")) __score0++;
            if (__jsonProps.Contains("event_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_id")) __score1++;
            if (__jsonProps.Contains("item")) __score1++;
            if (__jsonProps.Contains("previous_item_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("event_id")) __score2++;
            if (__jsonProps.Contains("item_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content_index")) __score3++;
            if (__jsonProps.Contains("event_id")) __score3++;
            if (__jsonProps.Contains("item_id")) __score3++;
            if (__jsonProps.Contains("logprobs")) __score3++;
            if (__jsonProps.Contains("transcript")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("usage")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content_index")) __score4++;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("event_id")) __score4++;
            if (__jsonProps.Contains("item_id")) __score4++;
            if (__jsonProps.Contains("logprobs")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content_index")) __score5++;
            if (__jsonProps.Contains("error")) __score5++;
            if (__jsonProps.Contains("event_id")) __score5++;
            if (__jsonProps.Contains("item_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("event_id")) __score6++;
            if (__jsonProps.Contains("item")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score7++;
            if (__jsonProps.Contains("content_index")) __score7++;
            if (__jsonProps.Contains("event_id")) __score7++;
            if (__jsonProps.Contains("item_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("error")) __score8++;
            if (__jsonProps.Contains("event_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("event_id")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("event_id")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("previous_item_id")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("event")) __score11++;
            if (__jsonProps.Contains("received_at")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("audio_start_ms")) __score12++;
            if (__jsonProps.Contains("event_id")) __score12++;
            if (__jsonProps.Contains("item_id")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score13++;
            if (__jsonProps.Contains("event_id")) __score13++;
            if (__jsonProps.Contains("item_id")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("event_id")) __score14++;
            if (__jsonProps.Contains("rate_limits")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("content_index")) __score15++;
            if (__jsonProps.Contains("delta")) __score15++;
            if (__jsonProps.Contains("event_id")) __score15++;
            if (__jsonProps.Contains("item_id")) __score15++;
            if (__jsonProps.Contains("output_index")) __score15++;
            if (__jsonProps.Contains("response_id")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("content_index")) __score16++;
            if (__jsonProps.Contains("event_id")) __score16++;
            if (__jsonProps.Contains("item_id")) __score16++;
            if (__jsonProps.Contains("output_index")) __score16++;
            if (__jsonProps.Contains("response_id")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("content_index")) __score17++;
            if (__jsonProps.Contains("delta")) __score17++;
            if (__jsonProps.Contains("event_id")) __score17++;
            if (__jsonProps.Contains("item_id")) __score17++;
            if (__jsonProps.Contains("output_index")) __score17++;
            if (__jsonProps.Contains("response_id")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("content_index")) __score18++;
            if (__jsonProps.Contains("event_id")) __score18++;
            if (__jsonProps.Contains("item_id")) __score18++;
            if (__jsonProps.Contains("output_index")) __score18++;
            if (__jsonProps.Contains("response_id")) __score18++;
            if (__jsonProps.Contains("transcript")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("content_index")) __score19++;
            if (__jsonProps.Contains("event_id")) __score19++;
            if (__jsonProps.Contains("item_id")) __score19++;
            if (__jsonProps.Contains("output_index")) __score19++;
            if (__jsonProps.Contains("part")) __score19++;
            if (__jsonProps.Contains("response_id")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("content_index")) __score20++;
            if (__jsonProps.Contains("event_id")) __score20++;
            if (__jsonProps.Contains("item_id")) __score20++;
            if (__jsonProps.Contains("output_index")) __score20++;
            if (__jsonProps.Contains("part")) __score20++;
            if (__jsonProps.Contains("response_id")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("event_id")) __score21++;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("event_id")) __score22++;
            if (__jsonProps.Contains("response")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("call_id")) __score23++;
            if (__jsonProps.Contains("delta")) __score23++;
            if (__jsonProps.Contains("event_id")) __score23++;
            if (__jsonProps.Contains("item_id")) __score23++;
            if (__jsonProps.Contains("output_index")) __score23++;
            if (__jsonProps.Contains("response_id")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("arguments")) __score24++;
            if (__jsonProps.Contains("call_id")) __score24++;
            if (__jsonProps.Contains("event_id")) __score24++;
            if (__jsonProps.Contains("item_id")) __score24++;
            if (__jsonProps.Contains("name")) __score24++;
            if (__jsonProps.Contains("output_index")) __score24++;
            if (__jsonProps.Contains("response_id")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("event_id")) __score25++;
            if (__jsonProps.Contains("item")) __score25++;
            if (__jsonProps.Contains("output_index")) __score25++;
            if (__jsonProps.Contains("response_id")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("event_id")) __score26++;
            if (__jsonProps.Contains("item")) __score26++;
            if (__jsonProps.Contains("output_index")) __score26++;
            if (__jsonProps.Contains("response_id")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("content_index")) __score27++;
            if (__jsonProps.Contains("delta")) __score27++;
            if (__jsonProps.Contains("event_id")) __score27++;
            if (__jsonProps.Contains("item_id")) __score27++;
            if (__jsonProps.Contains("output_index")) __score27++;
            if (__jsonProps.Contains("response_id")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("content_index")) __score28++;
            if (__jsonProps.Contains("event_id")) __score28++;
            if (__jsonProps.Contains("item_id")) __score28++;
            if (__jsonProps.Contains("output_index")) __score28++;
            if (__jsonProps.Contains("response_id")) __score28++;
            if (__jsonProps.Contains("text")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("event_id")) __score29++;
            if (__jsonProps.Contains("session")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("event_id")) __score30++;
            if (__jsonProps.Contains("session")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("event_id")) __score31++;
            if (__jsonProps.Contains("response_id")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __score32 = 0;
            if (__jsonProps.Contains("event_id")) __score32++;
            if (__jsonProps.Contains("response_id")) __score32++;
            if (__jsonProps.Contains("type")) __score32++;
            var __score33 = 0;
            if (__jsonProps.Contains("event_id")) __score33++;
            if (__jsonProps.Contains("response_id")) __score33++;
            if (__jsonProps.Contains("type")) __score33++;
            var __score34 = 0;
            if (__jsonProps.Contains("event_id")) __score34++;
            if (__jsonProps.Contains("item")) __score34++;
            if (__jsonProps.Contains("previous_item_id")) __score34++;
            if (__jsonProps.Contains("type")) __score34++;
            var __score35 = 0;
            if (__jsonProps.Contains("event_id")) __score35++;
            if (__jsonProps.Contains("item")) __score35++;
            if (__jsonProps.Contains("previous_item_id")) __score35++;
            if (__jsonProps.Contains("type")) __score35++;
            var __score36 = 0;
            if (__jsonProps.Contains("audio_end_ms")) __score36++;
            if (__jsonProps.Contains("audio_start_ms")) __score36++;
            if (__jsonProps.Contains("event_id")) __score36++;
            if (__jsonProps.Contains("item_id")) __score36++;
            if (__jsonProps.Contains("type")) __score36++;
            var __score37 = 0;
            if (__jsonProps.Contains("content_index")) __score37++;
            if (__jsonProps.Contains("end")) __score37++;
            if (__jsonProps.Contains("event_id")) __score37++;
            if (__jsonProps.Contains("id")) __score37++;
            if (__jsonProps.Contains("item_id")) __score37++;
            if (__jsonProps.Contains("speaker")) __score37++;
            if (__jsonProps.Contains("start")) __score37++;
            if (__jsonProps.Contains("text")) __score37++;
            if (__jsonProps.Contains("type")) __score37++;
            var __score38 = 0;
            if (__jsonProps.Contains("event_id")) __score38++;
            if (__jsonProps.Contains("item_id")) __score38++;
            if (__jsonProps.Contains("type")) __score38++;
            var __score39 = 0;
            if (__jsonProps.Contains("event_id")) __score39++;
            if (__jsonProps.Contains("item_id")) __score39++;
            if (__jsonProps.Contains("type")) __score39++;
            var __score40 = 0;
            if (__jsonProps.Contains("event_id")) __score40++;
            if (__jsonProps.Contains("item_id")) __score40++;
            if (__jsonProps.Contains("type")) __score40++;
            var __score41 = 0;
            if (__jsonProps.Contains("delta")) __score41++;
            if (__jsonProps.Contains("event_id")) __score41++;
            if (__jsonProps.Contains("item_id")) __score41++;
            if (__jsonProps.Contains("obfuscation")) __score41++;
            if (__jsonProps.Contains("output_index")) __score41++;
            if (__jsonProps.Contains("response_id")) __score41++;
            if (__jsonProps.Contains("type")) __score41++;
            var __score42 = 0;
            if (__jsonProps.Contains("arguments")) __score42++;
            if (__jsonProps.Contains("event_id")) __score42++;
            if (__jsonProps.Contains("item_id")) __score42++;
            if (__jsonProps.Contains("output_index")) __score42++;
            if (__jsonProps.Contains("response_id")) __score42++;
            if (__jsonProps.Contains("type")) __score42++;
            var __score43 = 0;
            if (__jsonProps.Contains("event_id")) __score43++;
            if (__jsonProps.Contains("item_id")) __score43++;
            if (__jsonProps.Contains("output_index")) __score43++;
            if (__jsonProps.Contains("type")) __score43++;
            var __score44 = 0;
            if (__jsonProps.Contains("event_id")) __score44++;
            if (__jsonProps.Contains("item_id")) __score44++;
            if (__jsonProps.Contains("output_index")) __score44++;
            if (__jsonProps.Contains("type")) __score44++;
            var __score45 = 0;
            if (__jsonProps.Contains("event_id")) __score45++;
            if (__jsonProps.Contains("item_id")) __score45++;
            if (__jsonProps.Contains("output_index")) __score45++;
            if (__jsonProps.Contains("type")) __score45++;
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
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }
            if (__score32 > __bestScore) { __bestScore = __score32; __bestIndex = 32; }
            if (__score33 > __bestScore) { __bestScore = __score33; __bestIndex = 33; }
            if (__score34 > __bestScore) { __bestScore = __score34; __bestIndex = 34; }
            if (__score35 > __bestScore) { __bestScore = __score35; __bestIndex = 35; }
            if (__score36 > __bestScore) { __bestScore = __score36; __bestIndex = 36; }
            if (__score37 > __bestScore) { __bestScore = __score37; __bestIndex = 37; }
            if (__score38 > __bestScore) { __bestScore = __score38; __bestIndex = 38; }
            if (__score39 > __bestScore) { __bestScore = __score39; __bestIndex = 39; }
            if (__score40 > __bestScore) { __bestScore = __score40; __bestIndex = 40; }
            if (__score41 > __bestScore) { __bestScore = __score41; __bestIndex = 41; }
            if (__score42 > __bestScore) { __bestScore = __score42; __bestIndex = 42; }
            if (__score43 > __bestScore) { __bestScore = __score43; __bestIndex = 43; }
            if (__score44 > __bestScore) { __bestScore = __score44; __bestIndex = 44; }
            if (__score45 > __bestScore) { __bestScore = __score45; __bestIndex = 45; }

            global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? conversationCreated = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? conversationItemCreated = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? conversationItemDeleted = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? conversationItemTruncated = default;
            global::tryAGI.OpenAI.RealtimeServerEventError? error = default;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared = default;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? inputAudioBufferDtmfEventReceived = default;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? responseOutputAudioDelta = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? responseOutputAudioDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? responseOutputAudioTranscriptDelta = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? responseOutputAudioTranscriptDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? responseContentPartDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? responseCreated = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseDone? responseDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? responseOutputTextDelta = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? responseOutputTextDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? sessionCreated = default;
            global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? sessionUpdated = default;
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted = default;
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped = default;
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? conversationItemAdded = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? conversationItemDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered = default;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? conversationItemInputAudioTranscriptionSegment = default;
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? mcpListToolsInProgress = default;
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? mcpListToolsCompleted = default;
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? mcpListToolsFailed = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? responseMcpCallArgumentsDelta = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? responseMcpCallArgumentsDone = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? responseMcpCallInProgress = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? responseMcpCallCompleted = default;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? responseMcpCallFailed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated>(__rawJson, options);
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
                        conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated>(__rawJson, options);
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
                        conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted>(__rawJson, options);
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
                        conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>(__rawJson, options);
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
                        conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>(__rawJson, options);
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
                        conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>(__rawJson, options);
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
                        conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved>(__rawJson, options);
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
                        conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventError>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        inputAudioBufferDtmfEventReceived = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        responseDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 27)
                {
                    try
                    {
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 28)
                {
                    try
                    {
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 29)
                {
                    try
                    {
                        sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 30)
                {
                    try
                    {
                        sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 31)
                {
                    try
                    {
                        outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 32)
                {
                    try
                    {
                        outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 33)
                {
                    try
                    {
                        outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 34)
                {
                    try
                    {
                        conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 35)
                {
                    try
                    {
                        conversationItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 36)
                {
                    try
                    {
                        inputAudioBufferTimeoutTriggered = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 37)
                {
                    try
                    {
                        conversationItemInputAudioTranscriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 38)
                {
                    try
                    {
                        mcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 39)
                {
                    try
                    {
                        mcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 40)
                {
                    try
                    {
                        mcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 41)
                {
                    try
                    {
                        responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 42)
                {
                    try
                    {
                        responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 43)
                {
                    try
                    {
                        responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 44)
                {
                    try
                    {
                        responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 45)
                {
                    try
                    {
                        responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (conversationCreated == null && conversationItemCreated == null && conversationItemDeleted == null && conversationItemInputAudioTranscriptionCompleted == null && conversationItemInputAudioTranscriptionDelta == null && conversationItemInputAudioTranscriptionFailed == null && conversationItemRetrieved == null && conversationItemTruncated == null && error == null && inputAudioBufferCleared == null && inputAudioBufferCommitted == null && inputAudioBufferDtmfEventReceived == null && inputAudioBufferSpeechStarted == null && inputAudioBufferSpeechStopped == null && rateLimitsUpdated == null && responseOutputAudioDelta == null && responseOutputAudioDone == null && responseOutputAudioTranscriptDelta == null && responseOutputAudioTranscriptDone == null && responseContentPartAdded == null && responseContentPartDone == null && responseCreated == null && responseDone == null && responseFunctionCallArgumentsDelta == null && responseFunctionCallArgumentsDone == null && responseOutputItemAdded == null && responseOutputItemDone == null && responseOutputTextDelta == null && responseOutputTextDone == null && sessionCreated == null && sessionUpdated == null && outputAudioBufferStarted == null && outputAudioBufferStopped == null && outputAudioBufferCleared == null && conversationItemAdded == null && conversationItemDone == null && inputAudioBufferTimeoutTriggered == null && conversationItemInputAudioTranscriptionSegment == null && mcpListToolsInProgress == null && mcpListToolsCompleted == null && mcpListToolsFailed == null && responseMcpCallArgumentsDelta == null && responseMcpCallArgumentsDone == null && responseMcpCallInProgress == null && responseMcpCallCompleted == null && responseMcpCallFailed == null)
            {
                try
                {
                    conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventError>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferDtmfEventReceived = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudioBufferTimeoutTriggered = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationItemInputAudioTranscriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.RealtimeServerEvent(
                conversationCreated,

                conversationItemCreated,

                conversationItemDeleted,

                conversationItemInputAudioTranscriptionCompleted,

                conversationItemInputAudioTranscriptionDelta,

                conversationItemInputAudioTranscriptionFailed,

                conversationItemRetrieved,

                conversationItemTruncated,

                error,

                inputAudioBufferCleared,

                inputAudioBufferCommitted,

                inputAudioBufferDtmfEventReceived,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                rateLimitsUpdated,

                responseOutputAudioDelta,

                responseOutputAudioDone,

                responseOutputAudioTranscriptDelta,

                responseOutputAudioTranscriptDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                responseDone,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                sessionCreated,

                sessionUpdated,

                outputAudioBufferStarted,

                outputAudioBufferStopped,

                outputAudioBufferCleared,

                conversationItemAdded,

                conversationItemDone,

                inputAudioBufferTimeoutTriggered,

                conversationItemInputAudioTranscriptionSegment,

                mcpListToolsInProgress,

                mcpListToolsCompleted,

                mcpListToolsFailed,

                responseMcpCallArgumentsDelta,

                responseMcpCallArgumentsDone,

                responseMcpCallInProgress,

                responseMcpCallCompleted,

                responseMcpCallFailed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConversationCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated), options);
            }
            else if (value.IsConversationItemCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated), options);
            }
            else if (value.IsConversationItemDeleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options);
            }
            else if (value.IsConversationItemRetrieved)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved), options);
            }
            else if (value.IsConversationItemTruncated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared), options);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted), options);
            }
            else if (value.IsInputAudioBufferDtmfEventReceived)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferDtmfEventReceived, typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived), options);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted), options);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped), options);
            }
            else if (value.IsRateLimitsUpdated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated), options);
            }
            else if (value.IsResponseOutputAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDelta, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta), options);
            }
            else if (value.IsResponseOutputAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone), options);
            }
            else if (value.IsResponseOutputAudioTranscriptDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDelta, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta), options);
            }
            else if (value.IsResponseOutputAudioTranscriptDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone), options);
            }
            else if (value.IsResponseContentPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded), options);
            }
            else if (value.IsResponseContentPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone), options);
            }
            else if (value.IsResponseCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated), options);
            }
            else if (value.IsResponseDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone), options);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded), options);
            }
            else if (value.IsResponseOutputItemDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone), options);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta), options);
            }
            else if (value.IsResponseOutputTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone), options);
            }
            else if (value.IsSessionCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated), options);
            }
            else if (value.IsSessionUpdated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated), options);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted, typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted), options);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped, typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped), options);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared, typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared), options);
            }
            else if (value.IsConversationItemAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemAdded, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded), options);
            }
            else if (value.IsConversationItemDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone), options);
            }
            else if (value.IsInputAudioBufferTimeoutTriggered)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferTimeoutTriggered, typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered), options);
            }
            else if (value.IsConversationItemInputAudioTranscriptionSegment)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionSegment, typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options);
            }
            else if (value.IsMcpListToolsInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsInProgress, typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress), options);
            }
            else if (value.IsMcpListToolsCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsCompleted, typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted), options);
            }
            else if (value.IsMcpListToolsFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsFailed, typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed), options);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta), options);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone), options);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress), options);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted), options);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed, typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed), options);
            }
        }
    }
}