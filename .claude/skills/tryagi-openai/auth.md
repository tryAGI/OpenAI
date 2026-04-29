# OpenAI API — authentication

Credentials for `tryAGI.OpenAI.CLI` are resolved in this order:

1. `--api-key <key>` command-line flag.
2. `OPENAI_API_KEY` environment variable.
3. `dotnet user-secrets` stored under id `tryAGI.OpenAI.CLI`.

## One-time setup

```bash
dnx tryAGI.OpenAI.CLI auth set <your-key>
dnx tryAGI.OpenAI.CLI auth show
```

## Detected auth schemes

- HTTP `bearer`
- HTTP `bearer`

## For agents

If the user hasn't configured credentials:

1. Run `dnx tryAGI.OpenAI.CLI auth show`. If it reports `source: none`, ask the user for their key (format and source depend on the provider — see their docs).
2. Run `dnx tryAGI.OpenAI.CLI auth set <key>` to persist it.
3. Confirm with `auth show` again before retrying the failed command.
