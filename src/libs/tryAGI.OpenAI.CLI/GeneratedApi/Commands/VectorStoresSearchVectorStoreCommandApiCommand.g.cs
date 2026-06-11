#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class VectorStoresSearchVectorStoreCommandApiCommand
{
    private static Argument<string> VectorStoreId { get; } = new(
        name: @"vector-store-id")
    {
        Description = @"The ID of the vector store to search.",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>> Query { get; } = new(
        name: @"--query")
    {
        Description = @"A query string for a search",
        Required = true,
    };

    private static Option<bool?> RewriteQuery { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--rewrite-query",
        description: @"Whether to rewrite the natural language query for vector search.");

    private static Option<int?> MaxNumResults { get; } = new(
        name: @"--max-num-results")
    {
        Description = @"The maximum number of results to return. This number should be between 1 and 50 inclusive.",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>?> Filters { get; } = new(
        name: @"--filters")
    {
        Description = @"A filter to apply based on file attributes.",
    };

    private static Option<global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions?> RankingOptions { get; } = new(
        name: @"--ranking-options")
    {
        Description = @"Ranking options for search.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VectorStoreSearchResultsPage value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VectorStoreSearchResultsPage value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"search-vector-store", @"Search a vector store for relevant chunks based on a query and file attributes filter.");
                        command.Arguments.Add(VectorStoreId);
                        command.Options.Add(Query);
                        command.Options.Add(RewriteQuery);
                        command.Options.Add(MaxNumResults);
                        command.Options.Add(Filters);
                        command.Options.Add(RankingOptions);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.VectorStoreSearchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
                        var query = parseResult.GetRequiredValue(Query);
                        var rewriteQuery = CliRuntime.WasSpecified(parseResult, RewriteQuery) ? parseResult.GetValue(RewriteQuery) : __requestBase is not null ? __requestBase.RewriteQuery : default;
                        var maxNumResults = CliRuntime.WasSpecified(parseResult, MaxNumResults) ? parseResult.GetValue(MaxNumResults) : __requestBase is not null ? __requestBase.MaxNumResults : default;
                        var filters = CliRuntime.WasSpecified(parseResult, Filters) ? parseResult.GetValue(Filters) : __requestBase is not null ? __requestBase.Filters : default;
                        var rankingOptions = CliRuntime.WasSpecified(parseResult, RankingOptions) ? parseResult.GetValue(RankingOptions) : __requestBase is not null ? __requestBase.RankingOptions : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VectorStores.SearchVectorStoreAsync(
                                    vectorStoreId: vectorStoreId,
                                    query: query,
                                    rewriteQuery: rewriteQuery,
                                    maxNumResults: maxNumResults,
                                    filters: filters,
                                    rankingOptions: rankingOptions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}