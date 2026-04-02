#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: gpt-5.1
    /// </summary>
    public readonly partial struct ModelIdsResponses : global::System.IEquatable<ModelIdsResponses>
    {
        /// <summary>
        /// Example: gpt-5.4
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModelIdsShared? Shared { get; init; }
#else
        public global::tryAGI.OpenAI.ModelIdsShared? Shared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared))]
#endif
        public bool IsShared => Shared != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? ResponsesOnlyModel { get; init; }
#else
        public global::tryAGI.OpenAI.ModelIdsResponsesEnum? ResponsesOnlyModel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesOnlyModel))]
#endif
        public bool IsResponsesOnlyModel => ResponsesOnlyModel != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsResponses(global::tryAGI.OpenAI.ModelIdsShared value) => new ModelIdsResponses((global::tryAGI.OpenAI.ModelIdsShared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsShared?(ModelIdsResponses @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(global::tryAGI.OpenAI.ModelIdsShared? value)
        {
            Shared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsResponses(global::tryAGI.OpenAI.ModelIdsResponsesEnum value) => new ModelIdsResponses((global::tryAGI.OpenAI.ModelIdsResponsesEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsResponsesEnum?(ModelIdsResponses @this) => @this.ResponsesOnlyModel;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(global::tryAGI.OpenAI.ModelIdsResponsesEnum? value)
        {
            ResponsesOnlyModel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(
            global::tryAGI.OpenAI.ModelIdsShared? shared,
            global::tryAGI.OpenAI.ModelIdsResponsesEnum? responsesOnlyModel
            )
        {
            Shared = shared;
            ResponsesOnlyModel = responsesOnlyModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesOnlyModel as object ??
            Shared as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Shared?.ToString() ??
            ResponsesOnlyModel?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShared || IsResponsesOnlyModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ModelIdsShared?, TResult>? shared = null,
            global::System.Func<global::tryAGI.OpenAI.ModelIdsResponsesEnum?, TResult>? responsesOnlyModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared && shared != null)
            {
                return shared(Shared!);
            }
            else if (IsResponsesOnlyModel && responsesOnlyModel != null)
            {
                return responsesOnlyModel(ResponsesOnlyModel!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ModelIdsShared?>? shared = null,
            global::System.Action<global::tryAGI.OpenAI.ModelIdsResponsesEnum?>? responsesOnlyModel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
            else if (IsResponsesOnlyModel)
            {
                responsesOnlyModel?.Invoke(ResponsesOnlyModel!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared,
                typeof(global::tryAGI.OpenAI.ModelIdsShared),
                ResponsesOnlyModel,
                typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum),
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
        public bool Equals(ModelIdsResponses other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsShared?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsResponsesEnum?>.Default.Equals(ResponsesOnlyModel, other.ResponsesOnlyModel) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelIdsResponses obj1, ModelIdsResponses obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIdsResponses>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelIdsResponses obj1, ModelIdsResponses obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIdsResponses o && Equals(o);
        }
    }
}
