#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Retrieve fine-tuning job<br/>
        /// Get info about a fine-tuning job.<br/>
        /// [Learn more about fine-tuning](https://platform.openai.com/docs/guides/model-optimization)
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.FineTuningJob> RetrieveFineTuningJobAsync(
            string fineTuningJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}