#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionInputVariant2Item : global::System.IEquatable<DecisionInputVariant2Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A user message containing text or inline images.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputMessage? Message { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputMessage? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.DecisionInputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessage PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputMessage value) => new DecisionInputVariant2Item((global::tryAGI.OpenAI.DecisionInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputMessage?(DecisionInputVariant2Item @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputVariant2Item FromMessage(global::tryAGI.OpenAI.DecisionInputMessage? value) => new DecisionInputVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(
            global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.DecisionInputMessage? message
            )
        {
            Type = type;

            Message = message;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.DecisionInputMessage, TResult>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0 && message != null)
            {
                return message(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputMessage>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputMessage>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::tryAGI.OpenAI.DecisionInputMessage),
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
        public bool Equals(DecisionInputVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputMessage?>.Default.Equals(Message, other.Message)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputVariant2Item obj1, DecisionInputVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputVariant2Item obj1, DecisionInputVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputVariant2Item o && Equals(o);
        }
    }
}
