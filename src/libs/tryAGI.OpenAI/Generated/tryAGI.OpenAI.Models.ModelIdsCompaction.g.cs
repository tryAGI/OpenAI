#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Model ID used to generate the response, like `gpt-5` or `o3`. OpenAI offers a wide range of models with different capabilities, performance characteristics, and price points. Refer to the [model guide](/docs/models) to browse and compare available models.
    /// </summary>
    public readonly partial struct ModelIdsCompaction : global::System.IEquatable<ModelIdsCompaction>
    {
        /// <summary>
        /// Example: gpt-5.1
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModelIdsResponses? Responses { get; init; }
#else
        public global::tryAGI.OpenAI.ModelIdsResponses? Responses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Responses))]
#endif
        public bool IsResponses => Responses != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ModelIdsCompactionVariant2 { get; init; }
#else
        public string? ModelIdsCompactionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelIdsCompactionVariant2))]
#endif
        public bool IsModelIdsCompactionVariant2 => ModelIdsCompactionVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ModelIdsCompactionVariant3 { get; init; }
#else
        public object? ModelIdsCompactionVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelIdsCompactionVariant3))]
#endif
        public bool IsModelIdsCompactionVariant3 => ModelIdsCompactionVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsCompaction(global::tryAGI.OpenAI.ModelIdsResponses value) => new ModelIdsCompaction((global::tryAGI.OpenAI.ModelIdsResponses?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsResponses?(ModelIdsCompaction @this) => @this.Responses;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsCompaction(global::tryAGI.OpenAI.ModelIdsResponses? value)
        {
            Responses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsCompaction(string value) => new ModelIdsCompaction((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ModelIdsCompaction @this) => @this.ModelIdsCompactionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsCompaction(string? value)
        {
            ModelIdsCompactionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsCompaction(
            global::tryAGI.OpenAI.ModelIdsResponses? responses,
            string? modelIdsCompactionVariant2,
            object? modelIdsCompactionVariant3
            )
        {
            Responses = responses;
            ModelIdsCompactionVariant2 = modelIdsCompactionVariant2;
            ModelIdsCompactionVariant3 = modelIdsCompactionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModelIdsCompactionVariant3 as object ??
            ModelIdsCompactionVariant2 as object ??
            Responses as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Responses?.ToString() ??
            ModelIdsCompactionVariant2?.ToString() ??
            ModelIdsCompactionVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponses || IsModelIdsCompactionVariant2 || IsModelIdsCompactionVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ModelIdsResponses?, TResult>? responses = null,
            global::System.Func<string?, TResult>? modelIdsCompactionVariant2 = null,
            global::System.Func<object?, TResult>? modelIdsCompactionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponses && responses != null)
            {
                return responses(Responses!);
            }
            else if (IsModelIdsCompactionVariant2 && modelIdsCompactionVariant2 != null)
            {
                return modelIdsCompactionVariant2(ModelIdsCompactionVariant2!);
            }
            else if (IsModelIdsCompactionVariant3 && modelIdsCompactionVariant3 != null)
            {
                return modelIdsCompactionVariant3(ModelIdsCompactionVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ModelIdsResponses?>? responses = null,
            global::System.Action<string?>? modelIdsCompactionVariant2 = null,
            global::System.Action<object?>? modelIdsCompactionVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponses)
            {
                responses?.Invoke(Responses!);
            }
            else if (IsModelIdsCompactionVariant2)
            {
                modelIdsCompactionVariant2?.Invoke(ModelIdsCompactionVariant2!);
            }
            else if (IsModelIdsCompactionVariant3)
            {
                modelIdsCompactionVariant3?.Invoke(ModelIdsCompactionVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Responses,
                typeof(global::tryAGI.OpenAI.ModelIdsResponses),
                ModelIdsCompactionVariant2,
                typeof(string),
                ModelIdsCompactionVariant3,
                typeof(object),
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
        public bool Equals(ModelIdsCompaction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsResponses?>.Default.Equals(Responses, other.Responses) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ModelIdsCompactionVariant2, other.ModelIdsCompactionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ModelIdsCompactionVariant3, other.ModelIdsCompactionVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelIdsCompaction obj1, ModelIdsCompaction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIdsCompaction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelIdsCompaction obj1, ModelIdsCompaction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIdsCompaction o && Equals(o);
        }
    }
}
