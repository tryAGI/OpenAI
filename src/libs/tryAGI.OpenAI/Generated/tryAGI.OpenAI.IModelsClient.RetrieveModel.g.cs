#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Retrieve model<br/>
        /// Retrieves a model instance, providing basic information about the model such as the owner and permissioning.
        /// </summary>
        /// <param name="model">
        /// Example: gpt-4o-mini
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Model16> RetrieveModelAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}