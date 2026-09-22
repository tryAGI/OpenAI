#!/usr/bin/env python3
"""Keep the large generated JSON context within CI compiler resources."""

from pathlib import Path


context_path = Path(__file__).parent / "Generated/tryAGI.OpenAI.JsonSerializerContext.g.cs"
lines = context_path.read_text(encoding="utf-8").splitlines(keepends=True)
attribute = "[global::System.Text.Json.Serialization.JsonSourceGenerationOptions("
generation_mode = (
    "        GenerationMode = "
    "global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,\n"
)

updated_lines = []
contexts = 0
for index, line in enumerate(lines):
    updated_lines.append(line)
    if line.strip() != attribute:
        continue

    contexts += 1
    if index + 1 < len(lines) and "GenerationMode =" in lines[index + 1]:
        continue
    updated_lines.append(generation_mode)

if contexts == 0:
    raise SystemExit(f"No JSON source-generation contexts found in {context_path}")

context_path.write_text("".join(updated_lines), encoding="utf-8")
print(f"Configured {contexts} JSON contexts for metadata generation")
