// namespace tryAGI.OpenAI;
//
// #pragma warning disable CS0618
//
// /// <summary>
// /// 
// /// </summary>
// public static class ApiHelpers
// {
//     /// <summary>
//     /// Supports embedding models and GPT models <br/>
//     /// According https://openai.com/pricing/ <br/>
//     /// According https://platform.openai.com/docs/guides/embeddings/embedding-models <br/>
//     /// </summary>
//     /// <param name="modelId">The model id we want to know the context size for.</param>
//     /// <param name="completionTokens"></param>
//     /// <param name="promptTokens"></param>
//     /// <returns>The maximum context size</returns>
//     /// <exception cref="NotImplementedException"></exception>
//     public static double? TryCalculatePriceInUsd(string modelId, int completionTokens, int promptTokens)
//     {
//         var (promptPricePerToken, completionPricePerToken) = modelId switch
//         {
//             // GPT models
//             ModelIds.Gpt4 => (0.03 * 0.001, 0.06 * 0.001),
//             ModelIds.Gpt4_0314 => (0.03 * 0.001, 0.06 * 0.001),
//             ModelIds.Gpt4_0613 => (0.03 * 0.001, 0.06 * 0.001),
//             
//             ModelIds.Gpt4_32k => (0.06 * 0.001, 0.12 * 0.001),
//             ModelIds.Gpt4_32k_0314 => (0.06 * 0.001, 0.12 * 0.001),
//             ModelIds.Gpt4_32k_0613 => (0.06 * 0.001, 0.12 * 0.001),
//             
//             ModelIds.Gpt35Turbo => (0.0015 * 0.001, 0.002 * 0.001),
//             ModelIds.Gpt35Turbo_0301 => (0.0015 * 0.001, 0.002 * 0.001),
//             ModelIds.Gpt35Turbo_0613 => (0.0015 * 0.001, 0.002 * 0.001),
//             
//             ModelIds.Gpt35Turbo_16k =>(0.003 * 0.001, 0.004 * 0.001),
//             ModelIds.Gpt35Turbo_16k_0613 => (0.003 * 0.001, 0.004 * 0.001),
//             
//             // Embedding models
//             EmbeddingModelIds.Ada002 => (0.0001 * 0.001, 0.0),
//             
//             _ => (-1.0, -1.0)
//         };
//         if (promptPricePerToken < 0.0)
//         {
//             return null;
//         }
//         
//         return completionTokens * completionPricePerToken +
//                promptTokens * promptPricePerToken;
//     }
//     
//     /// <inheritdoc cref="TryCalculatePriceInUsd(string, int, int)"/>
//     public static double CalculatePriceInUsd(string modelId, int completionTokens, int promptTokens)
//     {
//         return TryCalculatePriceInUsd(modelId, completionTokens, promptTokens) ??
//                throw new NotImplementedException();
//     }
//
//     /// <summary>
//     /// Build DALL·E directly into your apps to generate and edit novel images and art. <br/>
//     /// Our image models offer three tiers of resolution for flexibility. <br/>
//     /// According https://openai.com/pricing/ <br/>
//     /// </summary>
//     /// <param name="request"></param>
//     /// <returns></returns>
//     /// <exception cref="NotImplementedException"></exception>
//     public static double? TryCalculatePriceInUsd(CreateImageRequest request)
//     {
//         return (request.Model, request.Quality, request.Size) switch
//         {
//             (CreateImageRequest_size.TwoFiveSixx256) => 0.020,
//             CreateImageRequest_size.FiveOneTwox512 => 0.018,
//             CreateImageRequest_size.OneZeroTwoFourx1024 => 0.016,
//             
//             _ => null,
//         };
//     }
//     
//     /// <inheritdoc cref="TryCalculatePriceInUsd(CreateImageRequestSize)"/>
//     public static double CalculatePriceInUsd(CreateImageRequest createImageRequest)
//     {
//         return TryCalculatePriceInUsd(size) ??
//                throw new NotImplementedException();
//     }
//
//     /// <summary>
//     /// According https://openai.com/pricing/ <br/>
//     /// </summary>
//     /// <param name="modelId"></param>
//     /// <param name="minutes">rounded to the nearest second</param>
//     /// <returns></returns>
//     /// <exception cref="NotImplementedException"></exception>
//     public static double? TryCalculatePriceInUsd(string modelId, int minutes)
//     {
//         var pricePerMinute = modelId switch
//         {
//             AudioModelIds.Whisper1 => 0.006,
//             
//             _ => -1.0,
//         };
//         if (pricePerMinute < 0.0)
//         {
//             return null;
//         }
//         
//         return pricePerMinute * minutes;
//     }
//     
//     /// <inheritdoc cref="TryCalculatePriceInUsd(string, int)"/>
//     public static double CalculatePriceInUsd(string modelId, int minutes)
//     {
//         return TryCalculatePriceInUsd(modelId, minutes) ??
//                throw new NotImplementedException();
//     }
//     
//     /// <summary>
//     /// Calculates the maximum number of tokens possible to generate for a model. <br/>
//     /// Returns the maximum input number of tokens for a embedding model. <br/>
//     /// According https://platform.openai.com/docs/models/overview <br/>
//     /// </summary>
//     /// <param name="modelId"></param>
//     /// <returns></returns>
//     /// <exception cref="NotImplementedException"></exception>
//     public static int? TryCalculateContextLength(string modelId)
//     {
//         return modelId switch
//         {
//             // GPT models
//             ModelIds.Gpt4 => 8_192,
//             ModelIds.Gpt4_0314 => 8_192,
//             ModelIds.Gpt4_0613 => 8_192,
//             
//             ModelIds.Gpt4_32k => 32_768,
//             ModelIds.Gpt4_32k_0314 => 32_768,
//             ModelIds.Gpt4_32k_0613 => 32_768,
//             
//             ModelIds.Gpt35Turbo => 4_096,
//             ModelIds.Gpt35Turbo_0301 => 4_096,
//             ModelIds.Gpt35Turbo_0613 => 4_096,
//             
//             ModelIds.Gpt35Turbo_16k => 16_384,
//             ModelIds.Gpt35Turbo_16k_0613 => 16_384,
//             
//             // Embedding models
//             EmbeddingModelIds.Ada002 => 8_191,
//             
//             "ada" or "text-ada-001" => 2_049,
//             "text-babbage-001" => 2_040,
//             "babbage" => 2_049,
//             "text-curie-001" => 2_049,
//             "curie" => 2_049,
//             "davinci" => 2_049,
//             "text-davinci-003" => 4_097,
//             "text-davinci-002" => 4_097,
//             "code-davinci-002" => 8_001,
//             "code-davinci-001" => 8_001,
//             "code-cushman-002" => 2_048,
//             "code-cushman-001" => 2_048,
//             
//             _ => null,
//         };
//     }
//     
//     /// <inheritdoc cref="TryCalculateContextLength"/>
//     public static int CalculateContextLength(string modelId)
//     {
//         return TryCalculateContextLength(modelId) ??
//                throw new NotImplementedException();
//     }
// }