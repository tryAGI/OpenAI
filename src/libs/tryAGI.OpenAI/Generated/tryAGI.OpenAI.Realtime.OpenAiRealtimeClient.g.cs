
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// OpenAI Realtime API for bidirectional audio/text conversations over WebSocket.<br/>
    /// Auto-generated from openapi.yaml by build-asyncapi.py — do not edit by hand.
    /// </summary>
    public sealed partial class OpenAiRealtimeClient : global::System.IDisposable, global::System.IAsyncDisposable
    {
        /// <summary>
        /// Default WebSocket base URL.
        /// </summary>
        public const string DefaultBaseUrl = "wss://api.openai.com/v1/realtime";

        private readonly global::System.Net.WebSockets.ClientWebSocket _clientWebSocket;

        /// <summary>
        /// 
        /// </summary>

        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::tryAGI.OpenAI.Realtime.RealtimeSourceGenerationContext.Default;

        /// <summary>
        /// Gets a value indicating whether the WebSocket connection is open.
        /// </summary>
        public bool IsConnected => _clientWebSocket.State == global::System.Net.WebSockets.WebSocketState.Open;

        /// <summary>
        /// Creates a new instance of the OpenAiRealtimeClient.
        /// If no clientWebSocket is provided, a new one will be created.
        /// </summary>
        /// <param name="clientWebSocket">The ClientWebSocket instance. If not provided, a new one will be created.</param>
        public OpenAiRealtimeClient(
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null)
        {
            _clientWebSocket = clientWebSocket ?? new global::System.Net.WebSockets.ClientWebSocket();

            Initialized(_clientWebSocket);
        }


        private string? _storedAuthorizationHeaderName;
        private string? _storedAuthorizationHeaderScheme;
        private string? _storedAuthorizationApiKey;

        private readonly global::System.Collections.Generic.Dictionary<string, string> _subprotocolAuthorizationValues = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);
        private bool _preferSubprotocolAuth;

        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _storedAuthorizationApiKey = apiKey;
            _storedAuthorizationHeaderName = "Authorization";
            _storedAuthorizationHeaderScheme = "bearer";
            _preferSubprotocolAuth = false;
            _subprotocolAuthorizationValues["apiKey"] = apiKey;
        }

        /// <summary>
        /// Creates a new instance with bearer token authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="clientWebSocket"></param>
        public OpenAiRealtimeClient(
            string apiKey,
            global::System.Net.WebSockets.ClientWebSocket? clientWebSocket = null) : this(clientWebSocket)
        {
            Authorizing(_clientWebSocket, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_clientWebSocket);
        }

        /// <summary>
        /// Authorize using WebSocket subprotocol authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingSubprotocol(
            string apiKey
        )
        {
            var apiKeyValue = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            _subprotocolAuthorizationValues["apiKey"] = apiKeyValue;
            _preferSubprotocolAuth = true;
        }





        private void ApplyStoredAuthorization(
            bool useSubprotocolAuth)
        {
            if (useSubprotocolAuth || _preferSubprotocolAuth)
            {
                if (_subprotocolAuthorizationValues.ContainsKey("apiKey"))
                {
                    var __apiKey = _subprotocolAuthorizationValues["apiKey"];                    var __subProtocol = "openai-insecure-api-key.{apiKey}";
                    __subProtocol = __subProtocol.Replace("{apiKey}", __apiKey);                    _clientWebSocket.Options.AddSubProtocol(__subProtocol);                    return;
                }                return;
            }

            if (_storedAuthorizationApiKey is not null &&
                _storedAuthorizationHeaderName is not null)
            {
                var __authorizationValue = _storedAuthorizationHeaderScheme is not null
                    ? $"{_storedAuthorizationHeaderScheme} {_storedAuthorizationApiKey}"
                    : _storedAuthorizationApiKey;
                _clientWebSocket.Options.SetRequestHeader(_storedAuthorizationHeaderName, __authorizationValue);
            }
        }
        private void ApplyConnectionOptions(
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols,
            global::System.TimeSpan? keepAliveInterval,
            bool useSubprotocolAuth)
        {
            if (keepAliveInterval is not null)
            {
                _clientWebSocket.Options.KeepAliveInterval = keepAliveInterval.Value;
            }

            ApplyStoredAuthorization(useSubprotocolAuth);

            if (additionalHeaders is not null)
            {
                foreach (var header in additionalHeaders)
                {
                    _clientWebSocket.Options.SetRequestHeader(header.Key, header.Value);
                }
            }

            if (additionalSubProtocols is not null)
            {
                foreach (var subProtocol in additionalSubProtocols)
                {
                    _clientWebSocket.Options.AddSubProtocol(subProtocol);
                }
            }
        }

        private async global::System.Threading.Tasks.Task ConnectAsyncCore(
            global::System.Uri uri,
            global::System.TimeSpan? connectTimeout,
            global::System.Threading.CancellationToken cancellationToken)
        {
            global::System.Threading.CancellationTokenSource? __timeoutCancellationTokenSource = null;
            var __effectiveCancellationToken = cancellationToken;

            if (connectTimeout is not null)
            {
                __timeoutCancellationTokenSource = global::System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                __timeoutCancellationTokenSource.CancelAfter(connectTimeout.Value);
                __effectiveCancellationToken = __timeoutCancellationTokenSource.Token;
            }

            try
            {
                await _clientWebSocket.ConnectAsync(uri, __effectiveCancellationToken).ConfigureAwait(false);
            }
            finally
            {
                __timeoutCancellationTokenSource?.Dispose();
            }
        }

        private const string DefaultBaseUrlTemplate = "wss://api.openai.com/v1/realtime";


        /// <inheritdoc cref="global::System.Net.WebSockets.ClientWebSocket.ConnectAsync(global::System.Uri, global::System.Threading.CancellationToken)"/>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            bool useSubprotocolAuth = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __pathBuilder = new global::tryAGI.OpenAI.Realtime.PathBuilder(
                    path: DefaultBaseUrl);

                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval, useSubprotocolAuth);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Connects to the WebSocket server with typed connection parameters.
        /// </summary>
        /// <param name="model">Realtime model ID. The generator emits this as a required parameter on ConnectAsync and appends it to the URL as ?model=&lt;id&gt;.</param>
        /// <param name="uri">Optional WebSocket endpoint override.</param>
        /// <param name="additionalHeaders">Additional headers applied before connecting.</param>
        /// <param name="additionalSubProtocols">Additional WebSocket subprotocols applied before connecting.</param>
        /// <param name="keepAliveInterval">Optional keep-alive interval.</param>
        /// <param name="connectTimeout">Optional connect timeout.</param>
        /// <param name="useSubprotocolAuth">When true, applies stored subprotocol authentication instead of header authentication.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task ConnectAsync(
            string model,
            global::System.Uri? uri = null,
            global::System.Collections.Generic.IDictionary<string, string>? additionalHeaders = null,
            global::System.Collections.Generic.IEnumerable<string>? additionalSubProtocols = null,
            global::System.TimeSpan? keepAliveInterval = null,
            global::System.TimeSpan? connectTimeout = null,
            bool useSubprotocolAuth = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            global::System.Uri __uri;
            if (uri is not null)
            {
                __uri = uri;
            }
            else
            {
                var __baseUrl = DefaultBaseUrlTemplate;
                var __pathBuilder = new global::tryAGI.OpenAI.Realtime.PathBuilder(
                    path: __baseUrl);
                __pathBuilder
                .AddRequiredParameter("model", model)
                ;

                __uri = new global::System.Uri(__pathBuilder.ToString());
            }

            ApplyConnectionOptions(additionalHeaders, additionalSubProtocols, keepAliveInterval, useSubprotocolAuth);
            await ConnectAsyncCore(__uri, connectTimeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a raw text message over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                buffer: new global::System.ArraySegment<byte>(global::System.Text.Encoding.UTF8.GetBytes(text)),
                messageType: global::System.Net.WebSockets.WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends raw bytes over the WebSocket connection.
        /// </summary>
        public async global::System.Threading.Tasks.Task SendAsync(
            global::System.ArraySegment<byte> bytes,
            global::System.Net.WebSockets.WebSocketMessageType messageType,
            bool endOfMessage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (!IsConnected)
            {
                await ConnectAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            await _clientWebSocket.SendAsync(
                bytes,
                messageType,
                endOfMessage,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _clientWebSocket.Dispose();
        }

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {
            if (IsConnected)
            {
                try
                {
                    await _clientWebSocket.CloseAsync(
                        closeStatus: global::System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                        statusDescription: "Closing",
                        cancellationToken: default).ConfigureAwait(false);
                }
                catch (global::System.Net.WebSockets.WebSocketException)
                {
                    // Ignore errors during dispose
                }
            }
            _clientWebSocket.Dispose();
        }

        partial void Initialized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void Authorizing(
            global::System.Net.WebSockets.ClientWebSocket client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareArguments(
            global::System.Net.WebSockets.ClientWebSocket client);
        partial void PrepareRequest(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.WebSockets.ClientWebSocket client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
        partial void OnReceiveException(
            global::System.Exception exception,
            ref bool rethrow);
    }
}