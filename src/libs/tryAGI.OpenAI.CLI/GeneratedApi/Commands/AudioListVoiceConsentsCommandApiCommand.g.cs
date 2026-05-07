#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AudioListVoiceConsentsCommandApiCommand
{
     private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.
",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.
",
    };

    public static Command Create()
    {
        var command = new Command(@"list-voice-consents", @"Returns a list of voice consent recordings.
List consent recordings available to your organization for creating custom voices.

See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
");
                        command.Options.Add(After);
                        command.Options.Add(Limit);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var after = parseResult.GetValue(After);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Audio.ListVoiceConsentsAsync(
                                    after: after,
                                    limit: limit,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}