#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record ChatCompletionStreamOptionsVariant1OptionSet(
    Option<bool?> IncludeUsage,
                     Option<bool?> IncludeObfuscation)
{
    public static ChatCompletionStreamOptionsVariant1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ChatCompletionStreamOptionsVariant1OptionSet(
                        IncludeUsage: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}include-usage", description: @"If set, an additional chunk will be streamed before the `data: [DONE]`
message. The `usage` field on this chunk shows the token usage statistics
for the entire request, and the `choices` field will always be an empty
array.

All other chunks will also include a `usage` field, but with a null
value. **NOTE:** If the stream is interrupted, you may not receive the
final usage chunk which contains the total token usage for the request.
"),
                IncludeObfuscation: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}include-obfuscation", description: @"When true, stream obfuscation will be enabled. Stream obfuscation adds
random characters to an `obfuscation` field on streaming delta events to
normalize payload sizes as a mitigation to certain side-channel attacks.
These obfuscation fields are included by default, but add a small amount
of overhead to the data stream. You can set `include_obfuscation` to
false to optimize for bandwidth if you trust the network links between
your application and the OpenAI API.
")
        );
    }
}