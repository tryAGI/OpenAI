#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelIds : global::System.IEquatable<ModelIds>
    {
        /// <summary>
        /// Example: gpt-4o
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
        public static implicit operator ModelIds(global::tryAGI.OpenAI.ModelIdsShared value) => new ModelIds(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsShared?(ModelIds @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public ModelIds(global::tryAGI.OpenAI.ModelIdsShared? value)
        {
            Shared = value;
        }

        /// <summary>
        /// Example: gpt-4o
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
        public static implicit operator ModelIds(global::tryAGI.OpenAI.ModelIdsResponses value) => new ModelIds(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsResponses?(ModelIds @this) => @this.Responses;

        /// <summary>
        /// 
        /// </summary>
        public ModelIds(global::tryAGI.OpenAI.ModelIdsResponses? value)
        {
            Responses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelIds(
            global::tryAGI.OpenAI.ModelIdsShared? shared,
            global::tryAGI.OpenAI.ModelIdsResponses? responses
            )
        {
            Shared = shared;
            Responses = responses;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Responses as object ??
            Shared as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShared || IsResponses;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ModelIdsShared?, TResult>? shared = null,
            global::System.Func<global::tryAGI.OpenAI.ModelIdsResponses?, TResult>? responses = null,
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
            else if (IsResponses && responses != null)
            {
                return responses(Responses!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ModelIdsShared?>? shared = null,
            global::System.Action<global::tryAGI.OpenAI.ModelIdsResponses?>? responses = null,
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
            else if (IsResponses)
            {
                responses?.Invoke(Responses!);
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
                Responses,
                typeof(global::tryAGI.OpenAI.ModelIdsResponses),
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
        public bool Equals(ModelIds other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsShared?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsResponses?>.Default.Equals(Responses, other.Responses) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelIds obj1, ModelIds obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIds>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelIds obj1, ModelIds obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIds o && Equals(o);
        }
    }
}
