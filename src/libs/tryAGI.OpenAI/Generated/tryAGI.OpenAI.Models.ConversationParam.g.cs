#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The conversation that this response belongs to. Items from this conversation are prepended to `input_items` for this response request.<br/>
    /// Input items and output items from this response are automatically added to this conversation after this response completes.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public readonly partial struct ConversationParam : global::System.IEquatable<ConversationParam>
    {
        /// <summary>
        /// The unique ID of the conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ConversationId { get; init; }
#else
        public string? ConversationId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationId))]
#endif
        public bool IsConversationId => ConversationId != null;

        /// <summary>
        /// The conversation that this response belongs to.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ConversationParam2? ConversationObject { get; init; }
#else
        public global::tryAGI.OpenAI.ConversationParam2? ConversationObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationObject))]
#endif
        public bool IsConversationObject => ConversationObject != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationParam(string value) => new ConversationParam((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ConversationParam @this) => @this.ConversationId;

        /// <summary>
        /// 
        /// </summary>
        public ConversationParam(string? value)
        {
            ConversationId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationParam(global::tryAGI.OpenAI.ConversationParam2 value) => new ConversationParam((global::tryAGI.OpenAI.ConversationParam2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ConversationParam2?(ConversationParam @this) => @this.ConversationObject;

        /// <summary>
        /// 
        /// </summary>
        public ConversationParam(global::tryAGI.OpenAI.ConversationParam2? value)
        {
            ConversationObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationParam(
            string? conversationId,
            global::tryAGI.OpenAI.ConversationParam2? conversationObject
            )
        {
            ConversationId = conversationId;
            ConversationObject = conversationObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationObject as object ??
            ConversationId as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationId?.ToString() ??
            ConversationObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationId && !IsConversationObject || !IsConversationId && IsConversationObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? conversationId = null,
            global::System.Func<global::tryAGI.OpenAI.ConversationParam2?, TResult>? conversationObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationId && conversationId != null)
            {
                return conversationId(ConversationId!);
            }
            else if (IsConversationObject && conversationObject != null)
            {
                return conversationObject(ConversationObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? conversationId = null,
            global::System.Action<global::tryAGI.OpenAI.ConversationParam2?>? conversationObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationId)
            {
                conversationId?.Invoke(ConversationId!);
            }
            else if (IsConversationObject)
            {
                conversationObject?.Invoke(ConversationObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationId,
                typeof(string),
                ConversationObject,
                typeof(global::tryAGI.OpenAI.ConversationParam2),
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
        public bool Equals(ConversationParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ConversationId, other.ConversationId) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ConversationParam2?>.Default.Equals(ConversationObject, other.ConversationObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationParam obj1, ConversationParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationParam obj1, ConversationParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationParam o && Equals(o);
        }
    }
}
