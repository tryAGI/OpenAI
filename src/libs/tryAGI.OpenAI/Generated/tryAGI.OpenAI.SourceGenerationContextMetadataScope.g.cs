
#nullable enable
namespace tryAGI.OpenAI
{
    // Instances reference only this component and its outgoing dependency components.
    internal sealed partial class SourceGenerationContextMetadataScope : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(string))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_String.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Object.Create_Object(options);
                }
                if (type == typeof(bool))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Boolean.Create_Boolean(options);
                }
                if (type == typeof(byte))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Byte.Create_Byte(options);
                }
                if (type == typeof(int))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Int32.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Int64.Create_Int64(options);
                }
                if (type == typeof(float))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Single.Create_Single(options);
                }
                if (type == typeof(double))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_Double.Create_Double(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_ByteArray.Create_ByteArray(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_DateTime.Create_DateTime(options);
                }
                if (type == typeof(global::System.DateTimeOffset))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_DateTimeOffset.Create_DateTimeOffset(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_JsonElement.Create_JsonElement(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_NullableJsonElement.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_FC0ACBA26C044EC8.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_7024F6984ED20EB8.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::tryAGI.OpenAI.SourceGenerationContextMetadata0Factory_SourceGenerationContextMetadataType_92E1ACA86984772C.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

        private static readonly SharedMetadataResolver Intrinsic = new();
        private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? _own;
        private readonly global::System.Func<SourceGenerationContextMetadataScope>[] _dependencies;
        private readonly global::System.Action<ConverterCollector>? _contribute;
        internal SourceGenerationContextMetadataScope(global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? own,
            global::System.Func<SourceGenerationContextMetadataScope>[] dependencies, global::System.Action<ConverterCollector>? contribute)
        {
            _own = own;
            _dependencies = dependencies;
            _contribute = contribute;
        }
        // Iteration bounds deep graphs and visits a shared diamond dependency only once.
        private global::System.Collections.Generic.IEnumerable<SourceGenerationContextMetadataScope> Traverse()
        {
            var visited = new global::System.Collections.Generic.HashSet<SourceGenerationContextMetadataScope>();
            var pending = new global::System.Collections.Generic.Stack<SourceGenerationContextMetadataScope>();
            pending.Push(this);
            while (pending.Count != 0)
            {
                var scope = pending.Pop();
                if (!visited.Add(scope)) continue;
                yield return scope;
                for (var index = scope._dependencies.Length - 1; index >= 0; index--)
                    pending.Push(scope._dependencies[index]());
            }
        }
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
        {
            foreach (var scope in Traverse())
                if (scope._own?.GetTypeInfo(type, options) is { } info) return info;
            return Intrinsic.GetTypeInfo(type, options);
        }
        internal global::System.Text.Json.JsonSerializerOptions CreateOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = this,
            };
            AddConverters(options);
            return options;
        }
        internal void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            var collector = new ConverterCollector(options);
            foreach (var scope in Traverse()) scope._contribute?.Invoke(collector);
            collector.Complete();
        }
        internal sealed class ConverterCollector(global::System.Text.Json.JsonSerializerOptions options)
        {
            private readonly global::System.Collections.Generic.Dictionary<global::System.Type,
                global::System.Func<global::System.Text.Json.Serialization.JsonConverter>> _enums = new();
            private readonly global::System.Collections.Generic.HashSet<global::System.Type> _eager = new();
            internal void AddEnum(global::System.Type type,
                global::System.Func<global::System.Text.Json.Serialization.JsonConverter> factory) => _enums.TryAdd(type, factory);
            internal void AddEager<T>(global::System.Func<T> factory) where T : global::System.Text.Json.Serialization.JsonConverter
            {
                if (!_eager.Add(typeof(T))) return;
                foreach (var converter in options.Converters) if (converter is T) return;
                options.Converters.Add(factory());
            }
            internal void Complete()
            {
                if (_enums.Count != 0) options.Converters.Add(new EnumConverters(_enums));
            }
        }
        private sealed class EnumConverters(global::System.Collections.Generic.Dictionary<global::System.Type,
            global::System.Func<global::System.Text.Json.Serialization.JsonConverter>> factories)
            : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert) => factories.ContainsKey(typeToConvert);
            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) =>
                factories.TryGetValue(typeToConvert, out var factory) ? factory() :
                    throw new global::System.NotSupportedException(typeToConvert.FullName);
        }
    }
}