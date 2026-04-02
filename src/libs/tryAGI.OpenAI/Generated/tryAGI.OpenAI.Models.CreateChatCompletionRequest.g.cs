#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateChatCompletionRequest : global::System.IEquatable<CreateChatCompletionRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateModelResponseProperties? ModelResponseProperties { get; init; }
#else
        public global::tryAGI.OpenAI.CreateModelResponseProperties? ModelResponseProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelResponseProperties))]
#endif
        public bool IsModelResponseProperties => ModelResponseProperties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? CreateChatCompletionRequestVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? CreateChatCompletionRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateChatCompletionRequestVariant2))]
#endif
        public bool IsCreateChatCompletionRequestVariant2 => CreateChatCompletionRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionRequest(global::tryAGI.OpenAI.CreateModelResponseProperties value) => new CreateChatCompletionRequest((global::tryAGI.OpenAI.CreateModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateModelResponseProperties?(CreateChatCompletionRequest @this) => @this.ModelResponseProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequest(global::tryAGI.OpenAI.CreateModelResponseProperties? value)
        {
            ModelResponseProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionRequest(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2 value) => new CreateChatCompletionRequest((global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2?(CreateChatCompletionRequest @this) => @this.CreateChatCompletionRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequest(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? value)
        {
            CreateChatCompletionRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequest(
            global::tryAGI.OpenAI.CreateModelResponseProperties? modelResponseProperties,
            global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2? createChatCompletionRequestVariant2
            )
        {
            ModelResponseProperties = modelResponseProperties;
            CreateChatCompletionRequestVariant2 = createChatCompletionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateChatCompletionRequestVariant2 as object ??
            ModelResponseProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelResponseProperties?.ToString() ??
            CreateChatCompletionRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelResponseProperties && IsCreateChatCompletionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateModelResponseProperties?, TResult>? modelResponseProperties = null,
            global::System.Func<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2?, TResult>? createChatCompletionRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties && modelResponseProperties != null)
            {
                return modelResponseProperties(ModelResponseProperties!);
            }
            else if (IsCreateChatCompletionRequestVariant2 && createChatCompletionRequestVariant2 != null)
            {
                return createChatCompletionRequestVariant2(CreateChatCompletionRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateModelResponseProperties?>? modelResponseProperties = null,
            global::System.Action<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2?>? createChatCompletionRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties)
            {
                modelResponseProperties?.Invoke(ModelResponseProperties!);
            }
            else if (IsCreateChatCompletionRequestVariant2)
            {
                createChatCompletionRequestVariant2?.Invoke(CreateChatCompletionRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelResponseProperties,
                typeof(global::tryAGI.OpenAI.CreateModelResponseProperties),
                CreateChatCompletionRequestVariant2,
                typeof(global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CreateChatCompletionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateModelResponseProperties?>.Default.Equals(ModelResponseProperties, other.ModelResponseProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateChatCompletionRequestVariant2?>.Default.Equals(CreateChatCompletionRequestVariant2, other.CreateChatCompletionRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateChatCompletionRequest obj1, CreateChatCompletionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateChatCompletionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateChatCompletionRequest obj1, CreateChatCompletionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateChatCompletionRequest o && Equals(o);
        }
    }
}
