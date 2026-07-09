#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: gpt-5.1
    /// </summary>
    public readonly partial struct BetaModelIdsResponses : global::System.IEquatable<BetaModelIdsResponses>
    {
        /// <summary>
        /// Example: gpt-5.4
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModelIdsShared? Shared { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModelIdsShared? Shared { get; }
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
        public bool TryPickShared(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaModelIdsShared? value)
        {
            value = Shared;
            return IsShared;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsShared PickShared() => IsShared
            ? Shared!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? ResponsesOnlyModel { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? ResponsesOnlyModel { get; }
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
        public bool TryPickResponsesOnlyModel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? value)
        {
            value = ResponsesOnlyModel;
            return IsResponsesOnlyModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelIdsResponsesEnum PickResponsesOnlyModel() => IsResponsesOnlyModel
            ? ResponsesOnlyModel!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesOnlyModel' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaModelIdsResponses(global::tryAGI.OpenAI.BetaModelIdsShared value) => new BetaModelIdsResponses((global::tryAGI.OpenAI.BetaModelIdsShared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModelIdsShared?(BetaModelIdsResponses @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public BetaModelIdsResponses(global::tryAGI.OpenAI.BetaModelIdsShared? value)
        {
            Shared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaModelIdsResponses FromShared(global::tryAGI.OpenAI.BetaModelIdsShared? value) => new BetaModelIdsResponses(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaModelIdsResponses(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum value) => new BetaModelIdsResponses((global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?(BetaModelIdsResponses @this) => @this.ResponsesOnlyModel;

        /// <summary>
        /// 
        /// </summary>
        public BetaModelIdsResponses(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? value)
        {
            ResponsesOnlyModel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaModelIdsResponses FromResponsesOnlyModel(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? value) => new BetaModelIdsResponses(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaModelIdsResponses(
            global::tryAGI.OpenAI.BetaModelIdsShared? shared,
            global::tryAGI.OpenAI.BetaModelIdsResponsesEnum? responsesOnlyModel
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
            global::System.Func<global::tryAGI.OpenAI.BetaModelIdsShared?, TResult>? shared = null,
            global::System.Func<global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?, TResult>? responsesOnlyModel = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsShared?>? shared = null,

            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?>? responsesOnlyModel = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsShared?>? shared = null,
            global::System.Action<global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?>? responsesOnlyModel = null,
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
                typeof(global::tryAGI.OpenAI.BetaModelIdsShared),
                ResponsesOnlyModel,
                typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum),
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
        public bool Equals(BetaModelIdsResponses other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModelIdsShared?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?>.Default.Equals(ResponsesOnlyModel, other.ResponsesOnlyModel) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaModelIdsResponses obj1, BetaModelIdsResponses obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaModelIdsResponses>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaModelIdsResponses obj1, BetaModelIdsResponses obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaModelIdsResponses o && Equals(o);
        }
    }
}
