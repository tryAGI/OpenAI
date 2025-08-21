#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Conversation : global::System.IEquatable<Conversation>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ConversationResource? Resource { get; init; }
#else
        public global::tryAGI.OpenAI.ConversationResource? Resource { get; }
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
        public static implicit operator Conversation(global::tryAGI.OpenAI.ConversationResource value) => new Conversation((global::tryAGI.OpenAI.ConversationResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ConversationResource?(Conversation @this) => @this.Resource;

        /// <summary>
        /// 
        /// </summary>
        public Conversation(global::tryAGI.OpenAI.ConversationResource? value)
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
            global::System.Func<global::tryAGI.OpenAI.ConversationResource?, TResult>? resource = null,
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
            global::System.Action<global::tryAGI.OpenAI.ConversationResource?>? resource = null,
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
                typeof(global::tryAGI.OpenAI.ConversationResource),
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
        public bool Equals(Conversation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ConversationResource?>.Default.Equals(Resource, other.Resource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Conversation obj1, Conversation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Conversation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Conversation obj1, Conversation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Conversation o && Equals(o);
        }
    }
}
