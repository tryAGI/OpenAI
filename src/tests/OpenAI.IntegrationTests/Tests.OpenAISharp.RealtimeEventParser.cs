using System.Text.Json;
using tryAGI.OpenAI.OpenAISharp;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void OpenAISharp_Parse_ErrorEvent_MapsError()
    {
        var json = """
        {
          "type": "error",
          "event_id": "evt_1",
          "error": {
            "type": "invalid_request_error",
            "code": "bad_param",
            "message": "Bad input",
            "param": "foo"
          }
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var error = evt.Should().BeOfType<OpenAIRealtimeErrorEvent>().Subject;

        error.Type.Should().Be("error");
        error.EventId.Should().Be("evt_1");
        error.Error.Type.Should().Be("invalid_request_error");
        error.Error.Code.Should().Be("bad_param");
        error.Error.Message.Should().Be("Bad input");
        error.Error.Param.Should().Be("foo");
    }

    [TestMethod]
    public void OpenAISharp_Parse_SessionEvent_MapsSessionPayload()
    {
        var json = """
        {
          "type": "session.created",
          "event_id": "evt_2",
          "session": { "id": "sess_1", "model": "gpt-realtime-1.5" }
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var session = evt.Should().BeOfType<OpenAIRealtimeSessionEvent>().Subject;

        session.Type.Should().Be("session.created");
        session.EventId.Should().Be("evt_2");
        session.Session.GetProperty("id").GetString().Should().Be("sess_1");
        session.Session.GetProperty("model").GetString().Should().Be("gpt-realtime-1.5");
    }

    [TestMethod]
    public void OpenAISharp_Parse_ResponseEvent_MapsResponsePayload()
    {
        var json = """
        {
          "type": "response.created",
          "event_id": "evt_3",
          "response": { "id": "resp_1", "status": "in_progress" }
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var response = evt.Should().BeOfType<OpenAIRealtimeResponseEvent>().Subject;

        response.Type.Should().Be("response.created");
        response.EventId.Should().Be("evt_3");
        response.Response.GetProperty("id").GetString().Should().Be("resp_1");
        response.Response.GetProperty("status").GetString().Should().Be("in_progress");
    }

    [TestMethod]
    public void OpenAISharp_Parse_ItemEvent_MapsItemPayload()
    {
        var json = """
        {
          "type": "conversation.item.created",
          "event_id": "evt_4",
          "item": { "id": "item_1", "type": "message" }
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var item = evt.Should().BeOfType<OpenAIRealtimeConversationItemEvent>().Subject;

        item.Type.Should().Be("conversation.item.created");
        item.EventId.Should().Be("evt_4");
        item.Item.GetProperty("id").GetString().Should().Be("item_1");
    }

    [TestMethod]
    public void OpenAISharp_Parse_RateLimitsEvent_MapsRateLimitsPayload()
    {
        var json = """
        {
          "type": "rate_limits.updated",
          "event_id": "evt_5",
          "rate_limits": { "requests": { "limit": 100, "remaining": 99 } }
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var rateLimits = evt.Should().BeOfType<OpenAIRealtimeRateLimitsEvent>().Subject;

        rateLimits.Type.Should().Be("rate_limits.updated");
        rateLimits.EventId.Should().Be("evt_5");
        rateLimits.RateLimits.GetProperty("requests").GetProperty("limit").GetInt32().Should().Be(100);
    }

    [TestMethod]
    public void OpenAISharp_Parse_UnknownEvent_ReturnsUnknown()
    {
        var json = """
        { "foo": "bar" }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        evt.Should().BeOfType<OpenAIRealtimeUnknownEvent>();
    }

    [TestMethod]
    public void OpenAISharp_Parse_AudioDelta_DecodesBase64AndMapsMetadata()
    {
        var json = """
        {
          "type": "response.audio.delta",
          "event_id": "evt_audio",
          "delta": "AQID",
          "item_id": "item_abc",
          "output_index": 0,
          "content_index": 1
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var audio = evt.Should().BeOfType<OpenAIRealtimeAudioDeltaEvent>().Subject;

        audio.Type.Should().Be("response.audio.delta");
        audio.EventType.Should().Be(RealtimeServerEventType.ResponseAudioDelta);
        audio.EventId.Should().Be("evt_audio");
        audio.AudioBytes.Should().Equal(new byte[] { 1, 2, 3 });
        audio.ItemId.Should().Be("item_abc");
        audio.OutputIndex.Should().Be(0);
        audio.ContentIndex.Should().Be(1);
    }

    [TestMethod]
    public void OpenAISharp_Parse_GaOutputAudioDelta_DecodesBase64AndMapsMetadata()
    {
        var json = """
        {
          "type": "response.output_audio.delta",
          "event_id": "evt_output_audio",
          "delta": "AQID",
          "item_id": "item_abc",
          "output_index": 0,
          "content_index": 1
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var audio = evt.Should().BeOfType<OpenAIRealtimeAudioDeltaEvent>().Subject;

        audio.Type.Should().Be("response.output_audio.delta");
        audio.EventType.Should().Be(RealtimeServerEventType.ResponseOutputAudioDelta);
        audio.AudioBytes.Should().Equal(new byte[] { 1, 2, 3 });
        audio.ItemId.Should().Be("item_abc");
        audio.OutputIndex.Should().Be(0);
        audio.ContentIndex.Should().Be(1);
    }

    [TestMethod]
    public void OpenAISharp_Parse_AudioDelta_EmptyDelta_ReturnsEmptyBytes()
    {
        var json = """
        {
          "type": "response.audio.delta",
          "event_id": "evt_empty",
          "delta": ""
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var audio = evt.Should().BeOfType<OpenAIRealtimeAudioDeltaEvent>().Subject;

        audio.AudioBytes.Should().BeEmpty();
        audio.ItemId.Should().BeNull();
        audio.OutputIndex.Should().BeNull();
        audio.ContentIndex.Should().BeNull();
    }

    [TestMethod]
    public void OpenAISharp_Parse_FunctionCallArgsDelta_MapsAllFields()
    {
        var json = """
        {
          "type": "response.function_call_arguments.delta",
          "event_id": "evt_fn",
          "item_id": "item_fn1",
          "call_id": "call_xyz",
          "delta": "{\"location\":"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var functionCall = evt.Should().BeOfType<OpenAIRealtimeFunctionCallArgsDeltaEvent>().Subject;

        functionCall.Type.Should().Be("response.function_call_arguments.delta");
        functionCall.EventType.Should().Be(RealtimeServerEventType.ResponseFunctionCallArgumentsDelta);
        functionCall.EventId.Should().Be("evt_fn");
        functionCall.ItemId.Should().Be("item_fn1");
        functionCall.CallId.Should().Be("call_xyz");
        functionCall.Delta.Should().Be("{\"location\":");
    }

    [TestMethod]
    public void OpenAISharp_Parse_FunctionCallArgsDone_MapsCompleteArguments()
    {
        var json = """
        {
          "type": "response.function_call_arguments.done",
          "event_id": "evt_fn_done",
          "item_id": "item_fn1",
          "call_id": "call_xyz",
          "arguments": "{\"questions\":[{\"question\":\"Pick one\",\"header\":\"Track\",\"options\":[{\"label\":\"A\",\"description\":\"First\"}]}]}"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var functionCall = evt.Should().BeOfType<OpenAIRealtimeFunctionCallArgsDoneEvent>().Subject;

        functionCall.Type.Should().Be("response.function_call_arguments.done");
        functionCall.EventType.Should().Be(RealtimeServerEventType.ResponseFunctionCallArgumentsDone);
        functionCall.EventId.Should().Be("evt_fn_done");
        functionCall.ItemId.Should().Be("item_fn1");
        functionCall.CallId.Should().Be("call_xyz");
        functionCall.Arguments.Should().Contain("\"questions\"");
        functionCall.Arguments.Should().Contain("Pick one");
    }

    [TestMethod]
    public void OpenAISharp_Parse_OutputTextDelta_MapsDeltaAndMetadata()
    {
        var json = """
        {
          "type": "response.output_text.delta",
          "event_id": "evt_text",
          "response_id": "resp_1",
          "item_id": "item_1",
          "output_index": 0,
          "content_index": 0,
          "delta": "hel"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var text = evt.Should().BeOfType<OpenAIRealtimeTextDeltaEvent>().Subject;

        text.EventType.Should().Be(RealtimeServerEventType.ResponseOutputTextDelta);
        text.ResponseId.Should().Be("resp_1");
        text.ItemId.Should().Be("item_1");
        text.OutputIndex.Should().Be(0);
        text.ContentIndex.Should().Be(0);
        text.Delta.Should().Be("hel");
    }

    [TestMethod]
    public void OpenAISharp_Parse_OutputItemDone_ClonesItemElement()
    {
        var json = """
        {
          "type": "response.output_item.done",
          "event_id": "evt_done",
          "item": {
            "id": "item_42",
            "type": "function_call",
            "call_id": "call_abc",
            "name": "get_weather"
          }
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var done = evt.Should().BeOfType<OpenAIRealtimeOutputItemDoneEvent>().Subject;

        done.Type.Should().Be("response.output_item.done");
        done.EventType.Should().Be(RealtimeServerEventType.ResponseOutputItemDone);
        done.EventId.Should().Be("evt_done");
        done.Item.GetProperty("id").GetString().Should().Be("item_42");
        done.Item.GetProperty("type").GetString().Should().Be("function_call");
        done.Item.GetProperty("call_id").GetString().Should().Be("call_abc");
        done.Item.GetProperty("name").GetString().Should().Be("get_weather");
    }

    [TestMethod]
    public void OpenAISharp_Parse_SpeechStarted_MapsAudioStartMs()
    {
        var json = """
        {
          "type": "input_audio_buffer.speech_started",
          "event_id": "evt_speech_start",
          "audio_start_ms": 1250
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var speech = evt.Should().BeOfType<OpenAIRealtimeSpeechStartedEvent>().Subject;

        speech.Type.Should().Be("input_audio_buffer.speech_started");
        speech.EventType.Should().Be(RealtimeServerEventType.InputAudioBufferSpeechStarted);
        speech.EventId.Should().Be("evt_speech_start");
        speech.AudioStartMs.Should().Be(1250);
    }

    [TestMethod]
    public void OpenAISharp_Parse_SpeechStarted_MissingMs_ReturnsNull()
    {
        var json = """
        {
          "type": "input_audio_buffer.speech_started",
          "event_id": "evt_no_ms"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var speech = evt.Should().BeOfType<OpenAIRealtimeSpeechStartedEvent>().Subject;

        speech.AudioStartMs.Should().BeNull();
    }

    [TestMethod]
    public void OpenAISharp_Parse_SpeechStopped_MapsAudioEndMs()
    {
        var json = """
        {
          "type": "input_audio_buffer.speech_stopped",
          "event_id": "evt_speech_stop",
          "audio_end_ms": 3400
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var speech = evt.Should().BeOfType<OpenAIRealtimeSpeechStoppedEvent>().Subject;

        speech.Type.Should().Be("input_audio_buffer.speech_stopped");
        speech.EventType.Should().Be(RealtimeServerEventType.InputAudioBufferSpeechStopped);
        speech.EventId.Should().Be("evt_speech_stop");
        speech.AudioEndMs.Should().Be(3400);
    }

    [TestMethod]
    public void OpenAISharp_Parse_SpeechStopped_MissingMs_ReturnsNull()
    {
        var json = """
        {
          "type": "input_audio_buffer.speech_stopped",
          "event_id": "evt_stop_no_ms"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var speech = evt.Should().BeOfType<OpenAIRealtimeSpeechStoppedEvent>().Subject;

        speech.AudioEndMs.Should().BeNull();
    }

    [TestMethod]
    public void OpenAISharp_Parse_TranscriptionCompleted_MapsTranscriptAndSpeaker()
    {
        var json = """
        {
          "type": "conversation.item.input_audio_transcription.completed",
          "event_id": "evt_tx",
          "transcript": "Hello, how are you?",
          "speaker": "speaker_0"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var transcription = evt.Should().BeOfType<OpenAIRealtimeTranscriptionCompletedEvent>().Subject;

        transcription.Type.Should().Be("conversation.item.input_audio_transcription.completed");
        transcription.EventType.Should().Be(RealtimeServerEventType.ConversationItemInputAudioTranscriptionCompleted);
        transcription.EventId.Should().Be("evt_tx");
        transcription.Transcript.Should().Be("Hello, how are you?");
        transcription.Speaker.Should().Be("speaker_0");
    }

    [TestMethod]
    public void OpenAISharp_Parse_TranscriptionDelta_MapsDeltaAndLogprobs()
    {
        var json = """
        {
          "type": "conversation.item.input_audio_transcription.delta",
          "event_id": "evt_tx_delta",
          "item_id": "item_1",
          "content_index": 0,
          "delta": "hel",
          "logprobs": [{ "token": "hel", "logprob": -0.1 }]
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var transcription = evt.Should().BeOfType<OpenAIRealtimeTranscriptionDeltaEvent>().Subject;

        transcription.EventType.Should().Be(RealtimeServerEventType.ConversationItemInputAudioTranscriptionDelta);
        transcription.ItemId.Should().Be("item_1");
        transcription.ContentIndex.Should().Be(0);
        transcription.Delta.Should().Be("hel");
        transcription.Logprobs.Should().NotBeNull();
        transcription.Logprobs!.Value.ValueKind.Should().Be(JsonValueKind.Array);
    }

    [TestMethod]
    public void OpenAISharp_Parse_TranslationSessionDeltas_MapToAudioAndTextDeltaEvents()
    {
        var audioJson = """{"type":"session.output_audio.delta","delta":"AQID"}""";
        var transcriptJson = """{"type":"session.output_transcript.delta","delta":"hello"}""";

        var audio = OpenAIRealtimeEventParser.Parse(audioJson).Should().BeOfType<OpenAIRealtimeAudioDeltaEvent>().Subject;
        var transcript = OpenAIRealtimeEventParser.Parse(transcriptJson).Should().BeOfType<OpenAIRealtimeTextDeltaEvent>().Subject;

        audio.EventType.Should().Be(RealtimeServerEventType.SessionOutputAudioDelta);
        audio.AudioBytes.Should().Equal(new byte[] { 1, 2, 3 });
        transcript.EventType.Should().Be(RealtimeServerEventType.SessionOutputTranscriptDelta);
        transcript.Delta.Should().Be("hello");
    }

    [TestMethod]
    public void OpenAISharp_Parse_TranscriptionCompleted_NullSpeaker_ReturnsNull()
    {
        var json = """
        {
          "type": "conversation.item.input_audio_transcription.completed",
          "event_id": "evt_tx2",
          "transcript": "Just text, no speaker"
        }
        """;

        var evt = OpenAIRealtimeEventParser.Parse(json);
        var transcription = evt.Should().BeOfType<OpenAIRealtimeTranscriptionCompletedEvent>().Subject;

        transcription.Transcript.Should().Be("Just text, no speaker");
        transcription.Speaker.Should().BeNull();
    }

    [TestMethod]
    [DataRow("error", RealtimeServerEventType.Error)]
    [DataRow("session.created", RealtimeServerEventType.SessionCreated)]
    [DataRow("session.updated", RealtimeServerEventType.SessionUpdated)]
    [DataRow("response.created", RealtimeServerEventType.ResponseCreated)]
    [DataRow("response.done", RealtimeServerEventType.ResponseDone)]
    [DataRow("response.audio.delta", RealtimeServerEventType.ResponseAudioDelta)]
    [DataRow("response.audio.done", RealtimeServerEventType.ResponseAudioDone)]
    [DataRow("response.audio_transcript.delta", RealtimeServerEventType.ResponseAudioTranscriptDelta)]
    [DataRow("response.audio_transcript.done", RealtimeServerEventType.ResponseAudioTranscriptDone)]
    [DataRow("response.output_audio.delta", RealtimeServerEventType.ResponseOutputAudioDelta)]
    [DataRow("response.output_audio.done", RealtimeServerEventType.ResponseOutputAudioDone)]
    [DataRow("response.output_audio_transcript.delta", RealtimeServerEventType.ResponseOutputAudioTranscriptDelta)]
    [DataRow("response.output_audio_transcript.done", RealtimeServerEventType.ResponseOutputAudioTranscriptDone)]
    [DataRow("response.output_text.delta", RealtimeServerEventType.ResponseOutputTextDelta)]
    [DataRow("response.output_text.done", RealtimeServerEventType.ResponseOutputTextDone)]
    [DataRow("response.content_part.added", RealtimeServerEventType.ResponseContentPartAdded)]
    [DataRow("response.content_part.done", RealtimeServerEventType.ResponseContentPartDone)]
    [DataRow("response.text.delta", RealtimeServerEventType.ResponseTextDelta)]
    [DataRow("response.text.done", RealtimeServerEventType.ResponseTextDone)]
    [DataRow("response.function_call_arguments.delta", RealtimeServerEventType.ResponseFunctionCallArgumentsDelta)]
    [DataRow("response.function_call_arguments.done", RealtimeServerEventType.ResponseFunctionCallArgumentsDone)]
    [DataRow("response.output_item.added", RealtimeServerEventType.ResponseOutputItemAdded)]
    [DataRow("response.output_item.done", RealtimeServerEventType.ResponseOutputItemDone)]
    [DataRow("conversation.created", RealtimeServerEventType.ConversationCreated)]
    [DataRow("conversation.item.added", RealtimeServerEventType.ConversationItemAdded)]
    [DataRow("conversation.item.done", RealtimeServerEventType.ConversationItemDone)]
    [DataRow("conversation.item.created", RealtimeServerEventType.ConversationItemCreated)]
    [DataRow("conversation.item.deleted", RealtimeServerEventType.ConversationItemDeleted)]
    [DataRow("conversation.item.truncated", RealtimeServerEventType.ConversationItemTruncated)]
    [DataRow("conversation.item.input_audio_transcription.delta", RealtimeServerEventType.ConversationItemInputAudioTranscriptionDelta)]
    [DataRow("conversation.item.input_audio_transcription.completed", RealtimeServerEventType.ConversationItemInputAudioTranscriptionCompleted)]
    [DataRow("conversation.item.input_audio_transcription.failed", RealtimeServerEventType.ConversationItemInputAudioTranscriptionFailed)]
    [DataRow("input_audio_buffer.speech_started", RealtimeServerEventType.InputAudioBufferSpeechStarted)]
    [DataRow("input_audio_buffer.speech_stopped", RealtimeServerEventType.InputAudioBufferSpeechStopped)]
    [DataRow("input_audio_buffer.committed", RealtimeServerEventType.InputAudioBufferCommitted)]
    [DataRow("input_audio_buffer.cleared", RealtimeServerEventType.InputAudioBufferCleared)]
    [DataRow("input_audio_buffer.timeout_triggered", RealtimeServerEventType.InputAudioBufferTimeoutTriggered)]
    [DataRow("output_audio_buffer.cleared", RealtimeServerEventType.OutputAudioBufferCleared)]
    [DataRow("session.input_audio_buffer.committed", RealtimeServerEventType.SessionInputAudioBufferCommitted)]
    [DataRow("session.input_transcript.delta", RealtimeServerEventType.SessionInputTranscriptDelta)]
    [DataRow("session.output_audio.delta", RealtimeServerEventType.SessionOutputAudioDelta)]
    [DataRow("session.output_transcript.delta", RealtimeServerEventType.SessionOutputTranscriptDelta)]
    [DataRow("rate_limits.updated", RealtimeServerEventType.RateLimitsUpdated)]
    public void OpenAISharp_Parse_EventType_MapsCorrectly(string typeString, RealtimeServerEventType expectedEnum)
    {
        var json = typeString switch
        {
            "error" => $$$"""{"type":"{{{typeString}}}","error":{"message":"test"}}""",
            var value when value.StartsWith("session.", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","session":{}}""",
            var value when value.Contains("audio.delta", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","delta":""}""",
            var value when value.Contains("text.delta", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","delta":""}""",
            var value when value.Contains("transcript.delta", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","delta":""}""",
            var value when value.StartsWith("response.function_call_arguments.delta", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","item_id":"","call_id":"","delta":""}""",
            var value when value.StartsWith("response.output_item.done", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","item":{}}""",
            var value when value.StartsWith("response.content_part.", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","part":{}}""",
            var value when value.StartsWith("response.", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","response":{}}""",
            var value when value.StartsWith("conversation.item.input_audio_transcription.delta", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","delta":"test"}""",
            var value when value.StartsWith("conversation.item.input_audio_transcription", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","transcript":"test"}""",
            var value when value.StartsWith("conversation.item.", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","item":{}}""",
            var value when value.StartsWith("conversation.", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","conversation":{}}""",
            var value when value.StartsWith("input_audio_buffer.speech_started", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","audio_start_ms":0}""",
            var value when value.StartsWith("input_audio_buffer.speech_stopped", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}","audio_end_ms":0}""",
            var value when value.StartsWith("input_audio_buffer.", StringComparison.Ordinal) => $$$"""{"type":"{{{typeString}}}"}""",
            "rate_limits.updated" => $$$"""{"type":"{{{typeString}}}","rate_limits":{}}""",
            _ => $$$"""{"type":"{{{typeString}}}"}""",
        };

        var evt = OpenAIRealtimeEventParser.Parse(json);
        evt.EventType.Should().Be(expectedEnum);
    }

    [TestMethod]
    public void OpenAISharp_Parse_UnknownTypeString_ReturnsUnknownEnum()
    {
        var json = """{"type": "some.future.event", "data": "test"}""";

        var evt = OpenAIRealtimeEventParser.Parse(json);
        evt.EventType.Should().Be(RealtimeServerEventType.Unknown);
    }

    [TestMethod]
    public void OpenAISharp_Parse_AllEvents_PreserveRawJson()
    {
        var json = """{"type":"response.audio.delta","delta":"AQID","item_id":"i1"}""";

        var evt = OpenAIRealtimeEventParser.Parse(json);

        evt.RawJson.Should().Be(json);
    }

    [TestMethod]
    public void OpenAISharp_Parse_ErrorEvent_HasCorrectEventType()
    {
        var json = """{"type":"error","error":{"message":"fail"}}""";
        var evt = OpenAIRealtimeEventParser.Parse(json);

        evt.EventType.Should().Be(RealtimeServerEventType.Error);
    }

    [TestMethod]
    public void OpenAISharp_Parse_SessionCreated_HasCorrectEventType()
    {
        var json = """{"type":"session.created","session":{"id":"s1"}}""";
        var evt = OpenAIRealtimeEventParser.Parse(json);

        evt.EventType.Should().Be(RealtimeServerEventType.SessionCreated);
    }

    [TestMethod]
    public void OpenAISharp_Parse_ConversationItemCreated_HasCorrectEventType()
    {
        var json = """{"type":"conversation.item.created","item":{"id":"i1"}}""";
        var evt = OpenAIRealtimeEventParser.Parse(json);

        evt.EventType.Should().Be(RealtimeServerEventType.ConversationItemCreated);
        evt.Should().BeOfType<OpenAIRealtimeConversationItemEvent>();
    }
}
