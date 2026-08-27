#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaInputMessageResource : global::System.IEquatable<BetaInputMessageResource>
    {
        /// <summary>
        /// A message input to the model with a role indicating instruction following<br/>
        /// hierarchy. Instructions given with the `developer` or `system` role take<br/>
        /// precedence over instructions given with the `user` role.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputMessage? InputMessage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputMessage? InputMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputMessage? value)
        {
            value = InputMessage;
            return IsInputMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessage PickInputMessage() => IsInputMessage
            ? InputMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? BetaInputMessageResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? BetaInputMessageResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaInputMessageResourceVariant2))]
#endif
        public bool IsBetaInputMessageResourceVariant2 => BetaInputMessageResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaInputMessageResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? value)
        {
            value = BetaInputMessageResourceVariant2;
            return IsBetaInputMessageResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputMessageResourceVariant2 PickBetaInputMessageResourceVariant2() => IsBetaInputMessageResourceVariant2
            ? BetaInputMessageResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaInputMessageResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputMessageResource(global::tryAGI.OpenAI.BetaInputMessage value) => new BetaInputMessageResource((global::tryAGI.OpenAI.BetaInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputMessage?(BetaInputMessageResource @this) => @this.InputMessage;

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageResource(global::tryAGI.OpenAI.BetaInputMessage? value)
        {
            InputMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputMessageResource FromInputMessage(global::tryAGI.OpenAI.BetaInputMessage? value) => new BetaInputMessageResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputMessageResource(global::tryAGI.OpenAI.BetaInputMessageResourceVariant2 value) => new BetaInputMessageResource((global::tryAGI.OpenAI.BetaInputMessageResourceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputMessageResourceVariant2?(BetaInputMessageResource @this) => @this.BetaInputMessageResourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageResource(global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? value)
        {
            BetaInputMessageResourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputMessageResource FromBetaInputMessageResourceVariant2(global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? value) => new BetaInputMessageResource(value);

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageResource(
            global::tryAGI.OpenAI.BetaInputMessage? inputMessage,
            global::tryAGI.OpenAI.BetaInputMessageResourceVariant2? betaInputMessageResourceVariant2
            )
        {
            InputMessage = inputMessage;
            BetaInputMessageResourceVariant2 = betaInputMessageResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaInputMessageResourceVariant2 as object ??
            InputMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            BetaInputMessageResourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && IsBetaInputMessageResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaInputMessage, TResult>? inputMessage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputMessageResourceVariant2, TResult>? betaInputMessageResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsBetaInputMessageResourceVariant2 && betaInputMessageResourceVariant2 != null)
            {
                return betaInputMessageResourceVariant2(BetaInputMessageResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaInputMessage>? inputMessage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputMessageResourceVariant2>? betaInputMessageResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsBetaInputMessageResourceVariant2)
            {
                betaInputMessageResourceVariant2?.Invoke(BetaInputMessageResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaInputMessage>? inputMessage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputMessageResourceVariant2>? betaInputMessageResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsBetaInputMessageResourceVariant2)
            {
                betaInputMessageResourceVariant2?.Invoke(BetaInputMessageResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::tryAGI.OpenAI.BetaInputMessage),
                BetaInputMessageResourceVariant2,
                typeof(global::tryAGI.OpenAI.BetaInputMessageResourceVariant2),
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
        public bool Equals(BetaInputMessageResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputMessage?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputMessageResourceVariant2?>.Default.Equals(BetaInputMessageResourceVariant2, other.BetaInputMessageResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaInputMessageResource obj1, BetaInputMessageResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputMessageResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaInputMessageResource obj1, BetaInputMessageResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputMessageResource o && Equals(o);
        }
    }
}
