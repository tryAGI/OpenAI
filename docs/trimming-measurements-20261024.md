# OpenAI MEAI trimming measurements (2026-10-24)

Issue: [OpenAI #452](https://github.com/tryAGI/OpenAI/issues/452).

The MEAI adapters now use narrow model serialization helpers by default. An explicitly supplied speech serializer context is still honored. The public aggregate context remains available to callers who deliberately select it.

## Consumer and controls

The consumer references the packed NuGet SDK, invokes real `IChatClient` / speech interfaces with an offline HTTP handler, and checks nonempty request/response payloads. Reflection serialization is disabled. It has no `TrimmerRootAssembly`. Trim/AOT warnings are errors. Chat includes streaming, tools and a structured response schema. Separate profiles exercise tool/schema helpers, speech, caller-supplied speech context, and direct typed clients.

The measured Linux ARM64 cohort used .NET SDK 10.0.402/runtime 10.0.13, two container CPUs, cached NuGet packages, the same OpenAPI spec and generated code, and baseline commit `8bad364b9784ea0590fdc1ba6fa581c458fe3936`. Only four handwritten library files differ in the candidate. Host build admission wait is excluded from the process timings below. These are single observations, not statistical confidence intervals or Docker image build measurements.

## Results

All 14 candidate profiles published and executed successfully. For trimmed output, a PE metadata inspector confirms that `CreateAssistantRequest`, `VectorStoreObject` and `CreateBatchRequest` are absent.

| Profile | Trimmed SDK DLL bytes | Native executable bytes |
| --- | ---: | ---: |
| MEAI chat | 1,135,104 | 16,581,896 |
| Typed chat | 1,036,288 | 15,971,984 |
| Tool helpers | 36,864 | 3,368,056 |
| Schema helpers | 35,840 | 3,434,096 |
| MEAI speech | 96,256 | 7,417,816 |
| Custom speech context | 96,256 | 7,483,368 |
| Typed speech | 154,624 | 8,145,472 |

The aggregate baseline MEAI chat retains all three unwanted model families: **31,651,840 DLL bytes, 18,665 CLR types and 82,638 methods**. The candidate retains **1,135,104 bytes, 813 types and 3,069 methods**, a **96.4% DLL reduction**. Total trimmed self-contained publication falls from 57,114,740 to 26,598,009 bytes; this includes the runtime and dependencies.

Packed SDK source builds took 104.643 seconds baseline and 95.787 seconds candidate. MEAI chat publication process times were 20.884 seconds baseline trim, 12.370 seconds candidate trim and 25.785 seconds candidate AOT. These do not measure unchanged warm publishes or backend deployment latency.

Native executable bytes exclude the separate native debugging file. Full publication sizes include it and must not be mistaken for a runtime Docker image size.

## Reproduce and CI

Run `scripts/check-meai-trimming.sh` with a packed SDK in the configured local NuGet feed. The tracked consumer and PE inspector live in `src/tests/OpenAI.MeaiTrimmingCheck` and `src/tests/OpenAI.RetentionInspector`.

The independent Linux x64 matrix also passed all 14 profiles:
[MEAI CI 40021060293](https://github.com/tryAGI/OpenAI/actions/runs/40021060293).
The library publish workflow passed:
[Publish CI 40021060760](https://github.com/tryAGI/OpenAI/actions/runs/40021060760).

The offline consumer proves serializer and adapter behavior without provider credentials. It does not measure provider latency or execute live OpenAI requests.
