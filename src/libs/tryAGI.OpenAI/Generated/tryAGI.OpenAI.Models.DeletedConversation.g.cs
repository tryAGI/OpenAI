#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DeletedConversation : global::System.IEquatable<DeletedConversation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DeletedConversationResource? Resource { get; init; }
#else
        public global::tryAGI.OpenAI.DeletedConversationResource? Resource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Resource))]
#endif
        public bool IsResource => Resource != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeletedConversation(global::tryAGI.OpenAI.DeletedConversationResource value) => new DeletedConversation((global::tryAGI.OpenAI.DeletedConversationResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DeletedConversationResource?(DeletedConversation @this) => @this.Resource;

        /// <summary>
        /// 
        /// </summary>
        public DeletedConversation(global::tryAGI.OpenAI.DeletedConversationResource? value)
        {
            Resource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Resource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Resource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.DeletedConversationResource?, TResult>? resource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResource && resource != null)
            {
                return resource(Resource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.DeletedConversationResource?>? resource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResource)
            {
                resource?.Invoke(Resource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Resource,
                typeof(global::tryAGI.OpenAI.DeletedConversationResource),
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
        public bool Equals(DeletedConversation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DeletedConversationResource?>.Default.Equals(Resource, other.Resource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DeletedConversation obj1, DeletedConversation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeletedConversation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DeletedConversation obj1, DeletedConversation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeletedConversation o && Equals(o);
        }
    }
}
