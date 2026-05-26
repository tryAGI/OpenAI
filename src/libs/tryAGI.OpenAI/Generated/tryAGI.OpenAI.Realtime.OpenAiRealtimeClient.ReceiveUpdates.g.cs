
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    public sealed partial class OpenAiRealtimeClient
    {
        /// <summary>
        /// Receives updates from the WebSocket connection as an async enumerable.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token.</param>
        /// <returns>An async enumerable of server events.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.Realtime.ServerEvent> ReceiveUpdatesAsync(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            var buffer = new byte[1024 * 1024]; // 1MB buffer size
            var arraySegment = new global::System.ArraySegment<byte>(buffer);

            while (_clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    yield break;
                }

                using var __messageBuffer = new global::System.IO.MemoryStream();
                var __receivedTextMessage = false;

                while (true)
                {
                    global::System.Net.WebSockets.WebSocketReceiveResult result;

                    try
                    {
                        result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.WebSockets.WebSocketException exception)
                    {
                        RaiseException(exception);
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (await TryReconnectAsync(exception, cancellationToken).ConfigureAwait(false))
                        {
                            continue;
                        }

                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }
                    catch (global::System.OperationCanceledException exception)
                    {
                        if (!cancellationToken.IsCancellationRequested)
                        {
                            RaiseException(exception);
                        }

                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        if (rethrow)
                        {
                            throw;
                        }

                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Close)
                    {
                        RaiseClosed(result.CloseStatus, result.CloseStatusDescription);
                        await _clientWebSocket.CloseAsync(
                            closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                            statusDescription: "Closing",
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        yield break;
                    }

                    if (result.MessageType == global::System.Net.WebSockets.WebSocketMessageType.Text)
                    {
                        __receivedTextMessage = true;

                        if (result.Count > 0)
                        {
                            __messageBuffer.Write(buffer, 0, result.Count);
                        }
                    }

                    if (result.EndOfMessage)
                    {
                        break;
                    }
                }

                if (!__receivedTextMessage)
                {
                    continue;
                }

                string json = global::System.Text.Encoding.UTF8.GetString(__messageBuffer.ToArray());
                    global::tryAGI.OpenAI.Realtime.ServerEvent @event;
                    try
                    {
                        @event = (global::tryAGI.OpenAI.Realtime.ServerEvent)global::System.Text.Json.JsonSerializer.Deserialize(json, typeof(global::tryAGI.OpenAI.Realtime.ServerEvent), JsonSerializerContext)!;
                    }
                    catch (global::System.Exception exception) when (
                        exception is global::System.Text.Json.JsonException ||
                        exception is global::System.NotSupportedException ||
                        exception is global::System.InvalidOperationException)
                    {
                        var rethrow = false;
                        OnReceiveException(exception, ref rethrow);
                        DispatchUnknownMessage(json);
                        if (rethrow)
                        {
                            throw;
                        }

                        continue;
                    }

                    DispatchReceivedMessage(@event, json);
                    yield return @event;
            }
        }


        private static global::System.Text.Json.JsonElement? TryParseMessageJson(
            string rawText)
        {
            try
            {
                using var document = global::System.Text.Json.JsonDocument.Parse(rawText);
                return document.RootElement.Clone();
            }
            catch (global::System.Text.Json.JsonException)
            {
                return null;
            }
        }

        private void DispatchUnknownMessage(
            string rawText)
        {
            UnknownMessage?.Invoke(
                this,
                new AutoSDKWebSocketUnknownMessageEventArgs(
                    rawText,
                    TryParseMessageJson(rawText)));
        }

        private void DispatchReceivedMessage(
            global::tryAGI.OpenAI.Realtime.ServerEvent @event,
            string rawText)
        {
            var json = TryParseMessageJson(rawText);
            MessageReceived?.Invoke(
                this,
                new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.ServerEvent>(
                    @event,
                    rawText,
                    json));

            if (@event.ConversationCreated is { } __ConversationCreatedReceived)
            {
                ConversationCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationCreated>(
                        __ConversationCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemAdded is { } __ConversationItemAddedReceived)
            {
                ConversationItemAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemAdded>(
                        __ConversationItemAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemCreated is { } __ConversationItemCreatedReceived)
            {
                ConversationItemCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemCreated>(
                        __ConversationItemCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemDeleted is { } __ConversationItemDeletedReceived)
            {
                ConversationItemDeletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDeleted>(
                        __ConversationItemDeletedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemDone is { } __ConversationItemDoneReceived)
            {
                ConversationItemDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemDone>(
                        __ConversationItemDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemInputAudioTranscriptionCompleted is { } __ConversationItemInputAudioTranscriptionCompletedReceived)
            {
                ConversationItemInputAudioTranscriptionCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted>(
                        __ConversationItemInputAudioTranscriptionCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemInputAudioTranscriptionDelta is { } __ConversationItemInputAudioTranscriptionDeltaReceived)
            {
                ConversationItemInputAudioTranscriptionDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionDelta>(
                        __ConversationItemInputAudioTranscriptionDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemInputAudioTranscriptionFailed is { } __ConversationItemInputAudioTranscriptionFailedReceived)
            {
                ConversationItemInputAudioTranscriptionFailedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionFailed>(
                        __ConversationItemInputAudioTranscriptionFailedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemInputAudioTranscriptionSegment is { } __ConversationItemInputAudioTranscriptionSegmentReceived)
            {
                ConversationItemInputAudioTranscriptionSegmentReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemInputAudioTranscriptionSegment>(
                        __ConversationItemInputAudioTranscriptionSegmentReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemRetrieved is { } __ConversationItemRetrievedReceived)
            {
                ConversationItemRetrievedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemRetrieved>(
                        __ConversationItemRetrievedReceived,
                        rawText,
                        json));
            }
            if (@event.ConversationItemTruncated is { } __ConversationItemTruncatedReceived)
            {
                ConversationItemTruncatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventConversationItemTruncated>(
                        __ConversationItemTruncatedReceived,
                        rawText,
                        json));
            }
            if (@event.Error is { } __ErrorReceived)
            {
                ErrorReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventError>(
                        __ErrorReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferCleared is { } __InputAudioBufferClearedReceived)
            {
                InputAudioBufferClearedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCleared>(
                        __InputAudioBufferClearedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferCommitted is { } __InputAudioBufferCommittedReceived)
            {
                InputAudioBufferCommittedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferCommitted>(
                        __InputAudioBufferCommittedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferDtmfEventReceived is { } __InputAudioBufferDtmfEventReceivedReceived)
            {
                InputAudioBufferDtmfEventReceivedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferDtmfEventReceived>(
                        __InputAudioBufferDtmfEventReceivedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferSpeechStarted is { } __InputAudioBufferSpeechStartedReceived)
            {
                InputAudioBufferSpeechStartedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStarted>(
                        __InputAudioBufferSpeechStartedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferSpeechStopped is { } __InputAudioBufferSpeechStoppedReceived)
            {
                InputAudioBufferSpeechStoppedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferSpeechStopped>(
                        __InputAudioBufferSpeechStoppedReceived,
                        rawText,
                        json));
            }
            if (@event.InputAudioBufferTimeoutTriggered is { } __InputAudioBufferTimeoutTriggeredReceived)
            {
                InputAudioBufferTimeoutTriggeredReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventInputAudioBufferTimeoutTriggered>(
                        __InputAudioBufferTimeoutTriggeredReceived,
                        rawText,
                        json));
            }
            if (@event.McpListToolsCompleted is { } __MCPListToolsCompletedReceived)
            {
                MCPListToolsCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsCompleted>(
                        __MCPListToolsCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.McpListToolsFailed is { } __MCPListToolsFailedReceived)
            {
                MCPListToolsFailedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsFailed>(
                        __MCPListToolsFailedReceived,
                        rawText,
                        json));
            }
            if (@event.McpListToolsInProgress is { } __MCPListToolsInProgressReceived)
            {
                MCPListToolsInProgressReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventMCPListToolsInProgress>(
                        __MCPListToolsInProgressReceived,
                        rawText,
                        json));
            }
            if (@event.OutputAudioBufferCleared is { } __OutputAudioBufferClearedReceived)
            {
                OutputAudioBufferClearedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferCleared>(
                        __OutputAudioBufferClearedReceived,
                        rawText,
                        json));
            }
            if (@event.OutputAudioBufferStarted is { } __OutputAudioBufferStartedReceived)
            {
                OutputAudioBufferStartedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStarted>(
                        __OutputAudioBufferStartedReceived,
                        rawText,
                        json));
            }
            if (@event.OutputAudioBufferStopped is { } __OutputAudioBufferStoppedReceived)
            {
                OutputAudioBufferStoppedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventOutputAudioBufferStopped>(
                        __OutputAudioBufferStoppedReceived,
                        rawText,
                        json));
            }
            if (@event.RateLimitsUpdated is { } __RateLimitsUpdatedReceived)
            {
                RateLimitsUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventRateLimitsUpdated>(
                        __RateLimitsUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseContentPartAdded is { } __ResponseContentPartAddedReceived)
            {
                ResponseContentPartAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartAdded>(
                        __ResponseContentPartAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseContentPartDone is { } __ResponseContentPartDoneReceived)
            {
                ResponseContentPartDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseContentPartDone>(
                        __ResponseContentPartDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseCreated is { } __ResponseCreatedReceived)
            {
                ResponseCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseCreated>(
                        __ResponseCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseDone is { } __ResponseDoneReceived)
            {
                ResponseDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseDone>(
                        __ResponseDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseFunctionCallArgumentsDelta is { } __ResponseFunctionCallArgumentsDeltaReceived)
            {
                ResponseFunctionCallArgumentsDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDelta>(
                        __ResponseFunctionCallArgumentsDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseFunctionCallArgumentsDone is { } __ResponseFunctionCallArgumentsDoneReceived)
            {
                ResponseFunctionCallArgumentsDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseFunctionCallArgumentsDone>(
                        __ResponseFunctionCallArgumentsDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallCompleted is { } __ResponseMCPCallCompletedReceived)
            {
                ResponseMCPCallCompletedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallCompleted>(
                        __ResponseMCPCallCompletedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallFailed is { } __ResponseMCPCallFailedReceived)
            {
                ResponseMCPCallFailedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallFailed>(
                        __ResponseMCPCallFailedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallInProgress is { } __ResponseMCPCallInProgressReceived)
            {
                ResponseMCPCallInProgressReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallInProgress>(
                        __ResponseMCPCallInProgressReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallArgumentsDelta is { } __ResponseMCPCallArgumentsDeltaReceived)
            {
                ResponseMCPCallArgumentsDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDelta>(
                        __ResponseMCPCallArgumentsDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseMcpCallArgumentsDone is { } __ResponseMCPCallArgumentsDoneReceived)
            {
                ResponseMCPCallArgumentsDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseMCPCallArgumentsDone>(
                        __ResponseMCPCallArgumentsDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioDelta is { } __ResponseAudioDeltaReceived)
            {
                ResponseAudioDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDelta>(
                        __ResponseAudioDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioDone is { } __ResponseAudioDoneReceived)
            {
                ResponseAudioDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioDone>(
                        __ResponseAudioDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioTranscriptDelta is { } __ResponseAudioTranscriptDeltaReceived)
            {
                ResponseAudioTranscriptDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDelta>(
                        __ResponseAudioTranscriptDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputAudioTranscriptDone is { } __ResponseAudioTranscriptDoneReceived)
            {
                ResponseAudioTranscriptDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseAudioTranscriptDone>(
                        __ResponseAudioTranscriptDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputItemAdded is { } __ResponseOutputItemAddedReceived)
            {
                ResponseOutputItemAddedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemAdded>(
                        __ResponseOutputItemAddedReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputItemDone is { } __ResponseOutputItemDoneReceived)
            {
                ResponseOutputItemDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseOutputItemDone>(
                        __ResponseOutputItemDoneReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputTextDelta is { } __ResponseTextDeltaReceived)
            {
                ResponseTextDeltaReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDelta>(
                        __ResponseTextDeltaReceived,
                        rawText,
                        json));
            }
            if (@event.ResponseOutputTextDone is { } __ResponseTextDoneReceived)
            {
                ResponseTextDoneReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventResponseTextDone>(
                        __ResponseTextDoneReceived,
                        rawText,
                        json));
            }
            if (@event.SessionCreated is { } __SessionCreatedReceived)
            {
                SessionCreatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionCreated>(
                        __SessionCreatedReceived,
                        rawText,
                        json));
            }
            if (@event.SessionUpdated is { } __SessionUpdatedReceived)
            {
                SessionUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdated>(
                        __SessionUpdatedReceived,
                        rawText,
                        json));
            }
            if (@event.TranscriptionSessionUpdated is { } __TranscriptionSessionUpdatedReceived)
            {
                TranscriptionSessionUpdatedReceived?.Invoke(
                    this,
                    new AutoSDKWebSocketMessageEventArgs<global::tryAGI.OpenAI.Realtime.RealtimeServerEventTranscriptionSessionUpdated>(
                        __TranscriptionSessionUpdatedReceived,
                        rawText,
                        json));
            }
        }
    }
}