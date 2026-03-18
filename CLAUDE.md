# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [OpenAI](https://openai.com/) API, auto-generated from the official OpenAI OpenAPI specification using [AutoSDK](https://github.com/tryAGI/AutoSDK). Published as the `tryAGI.OpenAI` NuGet package. Includes support for custom providers (Azure, DeepSeek, Groq, Ollama, OpenRouter, Together, and many more), a source generator for native C# function/tool definitions, pricing constants, and structured output helpers.

## Build Commands

```bash
# Build the solution
dotnet build OpenAI.slnx

# Build for release (also produces NuGet package)
dotnet build OpenAI.slnx -c Release

# Run integration tests (requires OPENAI_API_KEY env var)
dotnet test src/tests/OpenAI.IntegrationTests/OpenAI.IntegrationTests.csproj

# Run snapshot tests for CSharpToJsonSchema
dotnet test src/tests/CSharpToJsonSchema.SnapshotTests/CSharpToJsonSchema.SnapshotTests.csproj

# Run unit tests for CSharpToJsonSchema
dotnet test src/tests/CSharpToJsonSchema.UnitTests/CSharpToJsonSchema.UnitTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/tryAGI.OpenAI && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `Generated/` is **auto-generated** -- do not manually edit files in `src/libs/tryAGI.OpenAI/Generated/`.

1. `src/libs/tryAGI.OpenAI/openapi.yaml` -- the OpenAI OpenAPI spec (fetched from Stainless)
2. `src/helpers/FixOpenApiSpec/` -- converts OpenAPI 3.1 to 3.0 format for compatibility
3. `src/libs/tryAGI.OpenAI/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Hand-Written Extensions

Unlike most other tryAGI SDKs, this repo has significant **hand-written code** alongside the generated code:

| Path | Purpose |
|------|---------|
| `Metadata/` | Pricing constants and model metadata (chat, embedding, images, TTS, STT) |
| `Conversions/` | Implicit conversions for `ChatCompletionRequestMessage`, `CreateMessageRequest`, etc. |
| `Extensions/StringExtensions.cs` | Helper extension methods |
| `CustomProviders.cs` | Factory methods for Azure, DeepSeek, Groq, Ollama, OpenRouter, etc. |
| `ChatClient.CreateChatCompletion.AsStream.cs` | Streaming chat completion extensions |
| `ChatClient.CreateChatCompletion.As.cs` | Structured output (`CreateChatCompletionAsAsync<T>`) |
| `AssistantClient.CreateRun.AsStream.cs` | Streaming assistant run extensions |
| `RealtimeConversationClient.cs` | Realtime API WebSocket client |
| `OpenAiApi.Headers.cs` | Custom header helpers |
| `TypeToSchemaHelpers.cs` | JSON schema generation helpers for tools |
| `Image.Bytes.cs` | Image byte conversion helpers |

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/tryAGI.OpenAI/` | Main SDK library (`OpenAiClient` / `OpenAiApi`) |
| `src/tests/OpenAI.IntegrationTests/` | Integration tests against real OpenAI API and custom providers |
| `src/tests/CSharpToJsonSchema.SnapshotTests/` | Snapshot tests for schema generation |
| `src/tests/CSharpToJsonSchema.UnitTests/` | Unit tests for schema generation |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |

### Key Dependencies

- `CSharpToJsonSchema` -- source generator for defining tools/functions via C# interfaces
- `Tiktoken` -- token counting for pricing calculations
- `System.Net.ServerSentEvents` -- SSE parsing for streaming endpoints

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions
- **CLS Compliant:** Assembly marked as CLS-compliant

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material

## Key Conventions

- The NuGet package name is `tryAGI.OpenAI` (not just `OpenAI`) to avoid conflicts with the official OpenAI package
- The main client class is `OpenAiApi` (for backward compatibility) with `OpenAiClient` as the generated variant
- Custom providers are accessed via static factory methods on `CustomProviders` class (e.g., `CustomProviders.Azure(...)`)

## CustomProviders — Environment Variables for Tests

Each custom provider requires specific environment variables to run its integration tests. Tests skip (not fail) if the key is unset.

| Provider | Env Var(s) | Default Model | Capabilities |
|----------|-----------|---------------|--------------|
| **OpenAI** | `OPENAI_API_KEY` | `gpt-4o-mini` | Chat, streaming, tools, embeddings, images, audio |
| **Azure** | `AZURE_OPENAI_API_KEY`, `AZURE_OPENAI_ENDPOINT`, `AZURE_OPENAI_MODEL` (optional), `AZURE_OPENAI_EMBEDDING_MODEL` (optional) | `gpt-4o-mini` | Chat, streaming, tools, embeddings |
| **DeepInfra** | `DEEPINFRA_API_KEY` | `Qwen/Qwen2.5-72B-Instruct` | Chat, streaming, tools, embeddings (`BAAI/bge-en-icl`) |
| **Groq** | `GROQ_API_KEY`, `GROQ_CHAT_MODEL` (optional) | `llama-3.3-70b-versatile` | Chat, streaming, tools |
| **OpenRouter** | `OPENROUTER_API_KEY` | `meta-llama/llama-3.2-3b-instruct:free` | Chat, streaming (no tools on free tier) |
| **Fireworks** | `FIREWORKS_API_KEY` | `accounts/fireworks/models/llama-v3p3-70b-instruct` | Chat, streaming, tools, embeddings (`nomic-ai/nomic-embed-text-v1.5`) |
| **Together** | `TOGETHER_API_KEY`, `TOGETHER_CHAT_MODEL` (optional) | `meta-llama/Llama-3.3-70B-Instruct-Turbo` | Chat, streaming, tools, embeddings (`BAAI/bge-large-en-v1.5`) |
| **DeepSeek** | `DEEPSEEK_API_KEY` | `deepseek-chat` | Chat, streaming, tools |
| **XAi** | `XAI_API_KEY`, `XAI_CHAT_MODEL` (optional) | `grok-3-mini` | Chat, streaming, tools |
| **Perplexity** | `PERPLEXITY_API_KEY` | `sonar` | Chat, streaming (no tools) |
| **SambaNova** | `SAMBANOVA_API_KEY` | `Meta-Llama-3.3-70B-Instruct` | Chat, streaming, tools |
| **Mistral** | `MISTRAL_API_KEY` | `mistral-large-latest` | Chat, streaming, tools, embeddings (`mistral-embed`) |
| **Codestral** | `CODESTRAL_API_KEY` | `codestral-latest` | Chat, streaming |
| **Cerebras** | `CEREBRAS_API_KEY` | `llama3.1-70b` | Chat, streaming, tools |
| **Cohere** | `COHERE_API_KEY` | `command-r-08-2024` | Chat, streaming, tools, embeddings (`embed-english-v3.0`) |
| **Nebius** | `NEBIUS_API_KEY` | `Qwen/Qwen2.5-72B-Instruct` | Chat, streaming, tools, embeddings (`BAAI/bge-en-icl`) |
| **GitHub Models** | `TOKEN_FOR_GITHUB_MODELS` | `gpt-4o` | Chat, streaming, tools, embeddings (`text-embedding-3-small`) |
| **Hyperbolic** | `HYPERBOLIC_API_KEY`, `HYPERBOLIC_CHAT_MODEL` (optional) | `meta-llama/Llama-3.3-70B-Instruct` | Chat, streaming |
| **Ollama** | *(local, no key)* | `llama3.2` | Chat, streaming (local only) |
| **LM Studio** | *(local, no key)* | `lmstudio-community/Llama-3.2-3B-Instruct-GGUF` | Chat, streaming (local only) |

### MEAI Namespace Conflict

The generated SDK has its own `IChatClient` interface that shadows `Microsoft.Extensions.AI.IChatClient`. In tests, use the alias pattern:
```csharp
using Meai = Microsoft.Extensions.AI;
Meai.IChatClient chatClient = client;
```
