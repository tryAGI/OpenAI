using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputVariant3Item : global::System.IEquatable<InputVariant3Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// An object describing an image to classify.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1? ImageUrl { get; init; }
#else
        public global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant3Item(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1 value) => new InputVariant3Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1?(InputVariant3Item @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// An object describing text to classify.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2? Text { get; init; }
#else
        public global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant3Item(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2 value) => new InputVariant3Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2?(InputVariant3Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(
            global::OpenAI.CreateModerationRequestInputVariant3ItemDiscriminatorType? type,
            global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1? imageUrl,
            global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2? text
            )
        {
            Type = type;

            ImageUrl = imageUrl;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            ImageUrl as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageUrl && !IsText || !IsImageUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1?, TResult>? imageUrl = null,
            global::System.Func<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1?>? imageUrl = null,
            global::System.Action<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageUrl,
                typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1),
                Text,
                typeof(global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(InputVariant3Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.CreateModerationRequestInputVariant3ItemVariant2?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputVariant3Item obj1, InputVariant3Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputVariant3Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputVariant3Item obj1, InputVariant3Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputVariant3Item o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.InputVariant3Item? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.InputVariant3Item),
                jsonSerializerContext) as global::OpenAI.InputVariant3Item?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.InputVariant3Item? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.InputVariant3Item>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::OpenAI.InputVariant3Item?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::OpenAI.InputVariant3Item),
                jsonSerializerContext).ConfigureAwait(false)) as global::OpenAI.InputVariant3Item?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::OpenAI.InputVariant3Item?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::OpenAI.InputVariant3Item?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
