#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IModerationsClient
    {
        /// <summary>
        /// Create moderation<br/>
        /// Classifies if text and/or image inputs are potentially harmful. Learn<br/>
        /// more in the [moderation guide](https://platform.openai.com/docs/guides/moderation).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateModerationResponse> CreateModerationAsync(
            global::tryAGI.OpenAI.CreateModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create moderation<br/>
        /// Classifies if text and/or image inputs are potentially harmful. Learn<br/>
        /// more in the [moderation guide](https://platform.openai.com/docs/guides/moderation).
        /// </summary>
        /// <param name="input">
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </param>
        /// <param name="model">
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](https://platform.openai.com/docs/guides/moderation), and learn about<br/>
        /// available models [here](https://platform.openai.com/docs/models#moderation).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateModerationResponse> CreateModerationAsync(
            global::tryAGI.OpenAI.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputVariant3Item>> input,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateModerationRequestModel?>? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}