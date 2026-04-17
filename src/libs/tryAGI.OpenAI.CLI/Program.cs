using tryAGI.OpenAI.Cli;

// Command actions wrap themselves via CliRuntime.Wrap, which catches CliException and
// tryAGI.OpenAI.ApiException and translates them into clean stderr messages + non-zero exit.
return await CliRoot
    .CreateRootCommand()
    .Parse(args)
    .InvokeAsync()
    .ConfigureAwait(false);
