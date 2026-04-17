# tryAGI.OpenAI.CLI

Command-line interface to the OpenAI API, packaged as a .NET 10 global tool.
Runs zero-install via `dnx`:

```bash
dnx tryAGI.OpenAI.CLI --help
dnx tryAGI.OpenAI.CLI chat complete "write me a haiku about C#"
dnx tryAGI.OpenAI.CLI images generate "a white siamese cat" --save-to ./out
```

See the bundled [SKILL.md](./SKILL.md) for agent usage and full command reference.
