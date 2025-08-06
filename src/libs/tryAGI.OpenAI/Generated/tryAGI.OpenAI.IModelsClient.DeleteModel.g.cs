#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete a fine-tuned model<br/>
        /// Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.
        /// </summary>
        /// <param name="model">
        /// Example: ft:gpt-4o-mini:acemeco:suffix:abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeleteModelResponse> DeleteModelAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}