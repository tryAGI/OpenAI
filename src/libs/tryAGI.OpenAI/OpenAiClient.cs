// using System.Net.Http;
// using System.Net.Http.Headers;
// using System.Security.Authentication;
// using System.Text;
//
// namespace tryAGI.OpenAI;
//
// /// <summary>
// /// Entry point to the OpenAI API, handling auth and allowing access to the various API endpoints
// /// </summary>
// public sealed partial class OpenAiClient : IDisposable
// {
//     /// <summary>
//     /// Default encoding to use when making calls to the API.
//     /// </summary>
//     public static Encoding? DefaultEncoding { get; set; } = Encoding.UTF8;
//         
//     /// <summary>
//     /// Remove the charset from the content type.
//     /// </summary>
//     public static bool RemoveCharSetFromContentType { get; set; }
//         
//     /// <summary>
//     /// Creates a new entry point to the OpenAPI API, handling auth and allowing access to the various API endpoints
//     /// </summary>
//     /// <param name="openAIAuthentication">
//     /// The API authentication information to use for API calls,
//     /// or <see langword="null"/> to attempt to use the <see cref="OpenAIAuthentication.Default"/>,
//     /// potentially loading from environment vars or from a config file.
//     /// </param>
//     /// <param name="clientSettings">
//     /// The API client settings for specifying OpenAI deployments to Azure, a proxy domain,
//     /// or <see langword="null"/> to attempt to use the <see cref="OpenAIClientSettings.Default"/>,
//     /// potentially loading from environment vars or from a config file.
//     /// </param>
//     /// <param name="client">A <see cref="HttpClient"/>.</param>
//     /// <exception cref="AuthenticationException">Raised when authentication details are missing or invalid.</exception>
//     /// <remarks>
//     /// <see cref="OpenAIClient"/> implements <see cref="IDisposable"/> to manage the lifecycle of the resources it uses, including <see cref="HttpClient"/>.
//     /// When you initialize <see cref="OpenAIClient"/>, it will create an internal <see cref="HttpClient"/> instance if one is not provided.
//     /// This internal HttpClient is disposed of when OpenAIClient is disposed of.
//     /// If you provide an external HttpClient instance to OpenAIClient, you are responsible for managing its disposal.
//     /// </remarks>
//     public OpenAiClient(OpenAIAuthentication openAIAuthentication = null, OpenAIClientSettings clientSettings = null, HttpClient client = null)
//     {
//         OpenAIAuthentication = openAIAuthentication ?? OpenAIAuthentication.Default;
//         OpenAIClientSettings = clientSettings ?? OpenAIClientSettings.Default;
//
//         if (OpenAIAuthentication?.ApiKey is null)
//         {
//             throw new AuthenticationException("You must provide API authentication.  Please refer to https://github.com/RageAgainstThePixel/OpenAI-DotNet#authentication for details.");
//         }
//
//         Client = SetupClient(client);
//         ModelsEndpoint = new ModelsEndpoint(this);
//         ChatEndpoint = new ChatEndpoint(this);
//         ImagesEndPoint = new ImagesEndpoint(this);
//         EmbeddingsEndpoint = new EmbeddingsEndpoint(this);
//         AudioEndpoint = new AudioEndpoint(this);
//         FilesEndpoint = new FilesEndpoint(this);
//         FineTuningEndpoint = new FineTuningEndpoint(this);
//         ModerationsEndpoint = new ModerationsEndpoint(this);
//         ThreadsEndpoint = new ThreadsEndpoint(this);
//         AssistantsEndpoint = new AssistantsEndpoint(this);
// #pragma warning disable CS0618 // Type or member is obsolete
//         CompletionsEndpoint = new CompletionsEndpoint(this);
//         EditsEndpoint = new EditsEndpoint(this);
// #pragma warning restore CS0618 // Type or member is obsolete
//     }
//
//     ~OpenAIClient()
//     {
//         Dispose(false);
//     }
//
//     #region IDisposable
//
//     private bool isDisposed;
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
//
//     private void Dispose(bool disposing)
//     {
//         if (!isDisposed && disposing)
//         {
//             if (!isCustomClient)
//             {
//                 Client?.Dispose();
//             }
//
//             isDisposed = true;
//         }
//     }
//
//     #endregion IDisposable
//
//     private bool isCustomClient;
//
//     #region Endpoints
//
//     /// <summary>
//     /// List and describe the various models available in the API.
//     /// You can refer to the Models documentation to understand what <see href="https://platform.openai.com/docs/models"/> are available and the differences between them.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/models"/>
//     /// </summary>
//     public ModelsEndpoint ModelsEndpoint { get; }
//
//     /// <summary>
//     /// Given a chat conversation, the model will return a chat completion response.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/chat"/>
//     /// </summary>
//     public ChatEndpoint ChatEndpoint { get; }
//
//     /// <summary>
//     /// Given a prompt and/or an input image, the model will generate a new image.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/images"/>
//     /// </summary>
//     public ImagesEndpoint ImagesEndPoint { get; }
//
//     /// <summary>
//     /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.<br/>
//     /// <see href="https://platform.openai.com/docs/guides/embeddings"/>
//     /// </summary>
//     public EmbeddingsEndpoint EmbeddingsEndpoint { get; }
//
//     /// <summary>
//     /// Transforms audio into text.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/audio"/>
//     /// </summary>
//     public AudioEndpoint AudioEndpoint { get; }
//
//     /// <summary>
//     /// Files are used to upload documents that can be used with features like Fine-tuning.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/files"/>
//     /// </summary>
//     public FilesEndpoint FilesEndpoint { get; }
//
//     /// <summary>
//     /// Manage fine-tuning jobs to tailor a model to your specific training data.<br/>
//     /// <see href="https://platform.openai.com/docs/guides/fine-tuning"/><br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/fine-tuning"/>
//     /// </summary>
//     public FineTuningEndpoint FineTuningEndpoint { get; }
//
//     /// <summary>
//     /// The moderation endpoint is a tool you can use to check whether content complies with OpenAI's content policy.
//     /// Developers can thus identify content that our content policy prohibits and take action, for instance by filtering it.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/moderations"/>
//     /// </summary>
//     public ModerationsEndpoint ModerationsEndpoint { get; }
//
//     /// <summary>
//     /// Create threads that assistants can interact with.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/threads"/>
//     /// </summary>
//     public ThreadsEndpoint ThreadsEndpoint { get; }
//
//     /// <summary>
//     /// Text generation is the core function of the API. You give the API a prompt, and it generates a completion.
//     /// The way you “program” the API to do a task is by simply describing the task in plain english or providing
//     /// a few written examples. This simple approach works for a wide range of use cases, including summarization,
//     /// translation, grammar correction, question answering, chatbots, composing emails, and much more
//     /// (see the prompt library for inspiration).<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/completions"/>
//     /// </summary>
//     [Obsolete("Deprecated")]
//     public CompletionsEndpoint CompletionsEndpoint { get; }
//
//     /// <summary>
//     /// Given a prompt and an instruction, the model will return an edited version of the prompt.<br/>
//     /// <see href="https://platform.openai.com/docs/api-reference/edits"/>
//     /// </summary>
//     [global::System.Obsolete("Deprecated")]
//     public EditsEndpoint EditsEndpoint { get; }
//
//     #endregion Endpoints
//
//     private HttpClient SetupClient(HttpClient client = null)
//     {
//         if (client == null)
//         {
//             client = new HttpClient();
//         }
//         else
//         {
//             isCustomClient = true;
//         }
//
//         client.DefaultRequestHeaders.Add("User-Agent", "OpenAI-DotNet");
//         client.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
//
//         if (!OpenAIClientSettings.BaseRequestUrlFormat.Contains(OpenAIClientSettings.AzureOpenAIDomain) &&
//             (string.IsNullOrWhiteSpace(OpenAIAuthentication.ApiKey) ||
//              (!OpenAIAuthentication.ApiKey.Contains(AuthInfo.SecretKeyPrefix) &&
//               !OpenAIAuthentication.ApiKey.Contains(AuthInfo.SessionKeyPrefix))))
//         {
//             //throw new InvalidCredentialException($"{OpenAIAuthentication.ApiKey} must start with '{AuthInfo.SecretKeyPrefix}'");
//         }
//
//         if (OpenAIClientSettings.UseOAuthAuthentication)
//         {
//             client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", OpenAIAuthentication.ApiKey);
//         }
//         else
//         {
//             client.DefaultRequestHeaders.Add("api-key", OpenAIAuthentication.ApiKey);
//         }
//
//         if (!string.IsNullOrWhiteSpace(OpenAIAuthentication.OrganizationId))
//         {
//             client.DefaultRequestHeaders.Add("OpenAI-Organization", OpenAIAuthentication.OrganizationId);
//         }
//
//         return client;
//     }
// }