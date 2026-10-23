using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text.Json;

using var stream = File.OpenRead(args[0]);
using var pe = new PEReader(stream);
var reader = pe.GetMetadataReader();
var types = reader.TypeDefinitions.Select(h => reader.GetString(reader.GetTypeDefinition(h).Name)).ToHashSet(StringComparer.Ordinal);
var methods = reader.MethodDefinitions.Select(h => reader.GetString(reader.GetMethodDefinition(h).Name)).ToHashSet(StringComparer.Ordinal);
var unused = new[] { "CreateAssistantRequest", "VectorStoreObject", "CreateBatchRequest" };
var retained = unused.Where(name => types.Contains(name) || methods.Contains("Create_" + name)).ToArray();
Console.WriteLine(JsonSerializer.Serialize(new { typeCount = types.Count, methodCount = methods.Count, unusedModelsRetained = retained }));
if (!args.Skip(1).SequenceEqual(["--report-only"]) && retained.Length != 0)
    throw new InvalidOperationException("Unused models/factories retained: " + string.Join(", ", retained));
