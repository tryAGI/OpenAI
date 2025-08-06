#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Run grader<br/>
        /// Run a grader.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RunGraderResponse> RunGraderAsync(
            global::tryAGI.OpenAI.RunGraderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run grader<br/>
        /// Run a grader.
        /// </summary>
        /// <param name="grader">
        /// The grader used for the fine-tuning job.
        /// </param>
        /// <param name="item">
        /// The dataset item provided to the grader. This will be used to populate <br/>
        /// the `item` namespace. See [the guide](https://platform.openai.com/docs/guides/graders) for more details. 
        /// </param>
        /// <param name="modelSample">
        /// The model sample to be evaluated. This value will be used to populate <br/>
        /// the `sample` namespace. See [the guide](https://platform.openai.com/docs/guides/graders) for more details.<br/>
        /// The `output_json` variable will be populated if the model sample is a <br/>
        /// valid JSON string.<br/>
        ///  
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RunGraderResponse> RunGraderAsync(
            global::tryAGI.OpenAI.RunGraderRequestGrader grader,
            string modelSample,
            object? item = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}