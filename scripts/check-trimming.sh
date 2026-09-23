#!/usr/bin/env bash
set -euo pipefail

runtime_id=${1:-linux-x64}
log_file=$(mktemp)

heartbeat() {
  while sleep 60; do
    echo "Trimming publish is still running..."
  done
}

heartbeat &
heartbeat_pid=$!
cleanup() {
  kill "$heartbeat_pid" 2>/dev/null || true
  wait "$heartbeat_pid" 2>/dev/null || true
  rm -f "$log_file"
}
trap cleanup EXIT

dotnet publish src/tests/OpenAI.TrimmingCheck/OpenAI.TrimmingCheck.csproj \
  --configuration Release \
  --runtime "$runtime_id" \
  --self-contained true \
  -m:1 \
  -nodeReuse:false \
  -p:UseSharedCompilation=false \
  -p:GeneratePackageOnBuild=false \
  2>&1 | tee "$log_file"

if grep -Ei 'warning IL[0-9]+' "$log_file"; then
  echo "Trimming warnings found." >&2
  exit 1
fi

echo "No trimming warnings found. The project is trimming-compatible."
