---
name: tryagi-openai
description: The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details. Invoke any endpoint via `dnx tryAGI.OpenAI.CLI <group> <command>`. Requires an API key in `$OPENAI_API_KEY`.
---

# OpenAI API CLI

The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.

## Quickstart

```bash
# one-time: save your API key
dnx tryAGI.OpenAI.CLI auth set <your-key>

# run a command
dnx tryAGI.OpenAI.CLI <group> <command> [options]

# explore
dnx tryAGI.OpenAI.CLI --help
dnx tryAGI.OpenAI.CLI <group> --help
```

## Command groups

| Group | Operations | Summary |
|-------|-----------:|---------|
| `assistant` | 18 | Build Assistants that can call models and use tools. |
| `audio` | 9 | Turn audio into text or text into audio. |
| `audit-log` | 1 | List user actions and configuration changes within this organization. |
| `batch` | 4 | Create large batches of API requests to run asynchronously. |
| `certificate` | 10 |  |
| `chat` | 6 | Given a list of messages comprising a conversation, the model will return a response. |
| `completion` | 1 | Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position. |
| `conversation` | 8 | Manage conversations and conversation items. |
| `embedding` | 1 | Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms. |
| `eval` | 12 | Manage and run evals in the OpenAI platform. |
| `file` | 5 | Files are used to upload documents that can be used with features like Assistants and Fine-tuning. |
| `fine-tuning` | 13 | Manage fine-tuning jobs to tailor a model to your specific training data. |
| `group` | 4 |  |
| `group-organization-role-assignment` | 3 |  |
| `group-user` | 3 |  |
| `image` | 3 | Given a prompt and/or an input image, the model will generate a new image. |
| `invite` | 4 |  |
| `model` | 3 | List and describe the various models available in the API. |
| `moderation` | 1 | Given text and/or image inputs, classifies if those inputs are potentially harmful. |
| `project` | 19 |  |
| `project-group` | 3 |  |
| `project-group-role-assignment` | 3 |  |
| `project-user-role-assignment` | 3 |  |
| `realtime` | 8 |  |
| `response` | 5 |  |
| `role` | 8 |  |
| `skill` | 11 |  |
| `upload` | 4 | Use Uploads to upload large files in multiple parts. |
| `usage` | 9 |  |
| `user` | 4 |  |
| `user-organization-role-assignment` | 3 |  |
| `vector-store` | 16 |  |
| `video` | 10 |  |
| `default` | 21 |  |

## References

- [commands.md](./commands.md) — full per-command reference (name, description, HTTP route).
- [auth.md](./auth.md) — auth schemes detected in the spec + credential setup.

The bundled CLI also prints any of these on demand:

```bash
dnx tryAGI.OpenAI.CLI skill          # SKILL.md
dnx tryAGI.OpenAI.CLI skill commands # commands.md
dnx tryAGI.OpenAI.CLI skill auth     # auth.md
dnx tryAGI.OpenAI.CLI skill list     # list bundled skill files
```

## For agents

When the user asks to perform an operation against this API:
1. Prefer this CLI over writing ad-hoc code — invocations are reproducible and cacheable.
2. Before the first call, verify credentials with `dnx tryAGI.OpenAI.CLI auth show`. If `source: none`, ask the user for their key.
3. Use `--json` to get structured output for downstream parsing.
4. For unfamiliar groups/commands, run `--help` on the group rather than guessing.

## Links

- Home: https://github.com/tryAGI/OpenAI
- Package: https://www.nuget.org/packages/tryAGI.OpenAI.CLI
