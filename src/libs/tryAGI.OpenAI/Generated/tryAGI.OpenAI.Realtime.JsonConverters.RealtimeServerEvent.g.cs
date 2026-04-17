#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Realtime.RealtimeServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("conversation")) __score0++;
            if (__jsonProps.Contains("conversation.id")) __score0++;
            if (__jsonProps.Contains("conversation.object")) __score0++;
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
            if (__jsonProps.Contains("error.code")) __score5++;
            if (__jsonProps.Contains("error.message")) __score5++;
            if (__jsonProps.Contains("error.param")) __score5++;
            if (__jsonProps.Contains("error.type")) __score5++;
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
            if (__jsonProps.Contains("error.code")) __score8++;
            if (__jsonProps.Contains("error.event_id")) __score8++;
            if (__jsonProps.Contains("error.message")) __score8++;
            if (__jsonProps.Contains("error.param")) __score8++;
            if (__jsonProps.Contains("error.type")) __score8++;
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
            if (__jsonProps.Contains("part.audio")) __score19++;
            if (__jsonProps.Contains("part.text")) __score19++;
            if (__jsonProps.Contains("part.transcript")) __score19++;
            if (__jsonProps.Contains("part.type")) __score19++;
            if (__jsonProps.Contains("response_id")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("content_index")) __score20++;
            if (__jsonProps.Contains("event_id")) __score20++;
            if (__jsonProps.Contains("item_id")) __score20++;
            if (__jsonProps.Contains("output_index")) __score20++;
            if (__jsonProps.Contains("part")) __score20++;
            if (__jsonProps.Contains("part.audio")) __score20++;
            if (__jsonProps.Contains("part.text")) __score20++;
            if (__jsonProps.Contains("part.transcript")) __score20++;
            if (__jsonProps.Contains("part.type")) __score20++;
            if (__jsonProps.Contains("response_id")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("event_id")) __score21++;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("response.audio")) __score21++;
            if (__jsonProps.Contains("response.conversation_id")) __score21++;
            if (__jsonProps.Contains("response.id")) __score21++;
            if (__jsonProps.Contains("response.max_output_tokens")) __score21++;
            if (__jsonProps.Contains("response.metadata")) __score21++;
            if (__jsonProps.Contains("response.object")) __score21++;
            if (__jsonProps.Contains("response.output")) __score21++;
            if (__jsonProps.Contains("response.output_modalities")) __score21++;
            if (__jsonProps.Contains("response.status")) __score21++;
            if (__jsonProps.Contains("response.status_details")) __score21++;
            if (__jsonProps.Contains("response.usage")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("event_id")) __score22++;
            if (__jsonProps.Contains("response")) __score22++;
            if (__jsonProps.Contains("response.audio")) __score22++;
            if (__jsonProps.Contains("response.conversation_id")) __score22++;
            if (__jsonProps.Contains("response.id")) __score22++;
            if (__jsonProps.Contains("response.max_output_tokens")) __score22++;
            if (__jsonProps.Contains("response.metadata")) __score22++;
            if (__jsonProps.Contains("response.object")) __score22++;
            if (__jsonProps.Contains("response.output")) __score22++;
            if (__jsonProps.Contains("response.output_modalities")) __score22++;
            if (__jsonProps.Contains("response.status")) __score22++;
            if (__jsonProps.Contains("response.status_details")) __score22++;
            if (__jsonProps.Contains("response.usage")) __score22++;
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

            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated? conversationCreated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated? conversationItemCreated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted? conversationItemDeleted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated? conversationItemTruncated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventError? error = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived? inputAudioBufferDtmfEventReceived = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta? responseOutputAudioDelta = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone? responseOutputAudioDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta? responseOutputAudioTranscriptDelta = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone? responseOutputAudioTranscriptDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone? responseContentPartDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated? responseCreated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone? responseDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta? responseOutputTextDelta = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone? responseOutputTextDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated? sessionCreated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated? sessionUpdated = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded? conversationItemAdded = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone? conversationItemDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? conversationItemInputAudioTranscriptionSegment = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress? mcpListToolsInProgress = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted? mcpListToolsCompleted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed? mcpListToolsFailed = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta? responseMcpCallArgumentsDelta = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone? responseMcpCallArgumentsDone = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress? responseMcpCallInProgress = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted? responseMcpCallCompleted = default;
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed? responseMcpCallFailed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated).Name}");
                        conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated).Name}");
                        conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted).Name}");
                        conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                        conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                        conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                        conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved).Name}");
                        conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated).Name}");
                        conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared).Name}");
                        inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted).Name}");
                        inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived).Name}");
                        inputAudioBufferDtmfEventReceived = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                        inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                        inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated).Name}");
                        rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta).Name}");
                        responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone).Name}");
                        responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                        responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                        responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded).Name}");
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone).Name}");
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated).Name}");
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone).Name}");
                        responseDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded).Name}");
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone).Name}");
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta).Name}");
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone).Name}");
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated).Name}");
                        sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated).Name}");
                        sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted).Name}");
                        outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped).Name}");
                        outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared).Name}");
                        outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded).Name}");
                        conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone).Name}");
                        conversationItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered).Name}");
                        inputAudioBufferTimeoutTriggered = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment).Name}");
                        conversationItemInputAudioTranscriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress).Name}");
                        mcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted).Name}");
                        mcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed).Name}");
                        mcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta).Name}");
                        responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone).Name}");
                        responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress).Name}");
                        responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted).Name}");
                        responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed).Name}");
                        responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated).Name}");
                    conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated).Name}");
                    conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted).Name}");
                    conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                    conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                    conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                    conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved).Name}");
                    conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated).Name}");
                    conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared).Name}");
                    inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted).Name}");
                    inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived).Name}");
                    inputAudioBufferDtmfEventReceived = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                    inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                    inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated).Name}");
                    rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta).Name}");
                    responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone).Name}");
                    responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                    responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                    responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded).Name}");
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone).Name}");
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated).Name}");
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone).Name}");
                    responseDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded).Name}");
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone).Name}");
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta).Name}");
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone).Name}");
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated).Name}");
                    sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated).Name}");
                    sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted).Name}");
                    outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped).Name}");
                    outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared).Name}");
                    outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded).Name}");
                    conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone).Name}");
                    conversationItemDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered).Name}");
                    inputAudioBufferTimeoutTriggered = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment).Name}");
                    conversationItemInputAudioTranscriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress).Name}");
                    mcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted).Name}");
                    mcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed).Name}");
                    mcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta).Name}");
                    responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone).Name}");
                    responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress).Name}");
                    responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted).Name}");
                    responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed).Name}");
                    responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.Realtime.RealtimeServerEvent(
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
            global::tryAGI.OpenAI.Realtime.RealtimeServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated!, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated!, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed!, typeInfo);
            }
            else if (value.IsConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved!, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared!, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted!, typeInfo);
            }
            else if (value.IsInputAudioBufferDtmfEventReceived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferDtmfEventReceived!, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted!, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped!, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated!, typeInfo);
            }
            else if (value.IsResponseOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDelta!, typeInfo);
            }
            else if (value.IsResponseOutputAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDone!, typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDelta!, typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDone!, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded!, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone!, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated!, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded!, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone!, typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta!, typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone!, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted!, typeInfo);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped!, typeInfo);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared!, typeInfo);
            }
            else if (value.IsConversationItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemAdded!, typeInfo);
            }
            else if (value.IsConversationItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDone!, typeInfo);
            }
            else if (value.IsInputAudioBufferTimeoutTriggered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferTimeoutTriggered!, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionSegment!, typeInfo);
            }
            else if (value.IsMcpListToolsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsInProgress!, typeInfo);
            }
            else if (value.IsMcpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsCompleted!, typeInfo);
            }
            else if (value.IsMcpListToolsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsFailed!, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta!, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone!, typeInfo);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress!, typeInfo);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted!, typeInfo);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed!, typeInfo);
            }
        }
    }
}