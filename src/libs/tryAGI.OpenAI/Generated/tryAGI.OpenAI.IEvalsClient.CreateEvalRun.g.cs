#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Kicks off a new run for a given evaluation, specifying the data source, and what model configuration to use to test. The datasource will be validated against the schema specified in the config of the evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalRun> CreateEvalRunAsync(
            string evalId,
            global::tryAGI.OpenAI.CreateEvalRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Kicks off a new run for a given evaluation, specifying the data source, and what model configuration to use to test. The datasource will be validated against the schema specified in the config of the evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="dataSource">
        /// Details about the run's data source.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="name">
        /// The name of the run.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalRun> CreateEvalRunAsync(
            string evalId,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateEvalJsonlRunDataSource, global::tryAGI.OpenAI.CreateEvalCompletionsRunDataSource, global::tryAGI.OpenAI.CreateEvalResponsesRunDataSource> dataSource,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}