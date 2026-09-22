#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Delegation settings to update. The delegation type must match the current session; omitted settings retain their values.
    /// </summary>
    public readonly partial struct DelegationVariant13 : global::System.IEquatable<DelegationVariant13>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Delegate tasks to your application. The Live session emits delegation events that your backend handles.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Client { get; init; }
#else
        public global::tryAGI.OpenAI.LiveClientDelegationParam? Client { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveClientDelegationParam? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveClientDelegationParam PickClient() => IsClient
            ? Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");

        /// <summary>
        /// Update the Responses backend for an existing Live session without changing delegation ownership.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Responses { get; init; }
#else
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? Responses { get; }
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
        public bool TryPickResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? value)
        {
            value = Responses;
            return IsResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam PickResponses() => IsResponses
            ? Responses!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Responses' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DelegationVariant13(global::tryAGI.OpenAI.LiveClientDelegationParam value) => new DelegationVariant13((global::tryAGI.OpenAI.LiveClientDelegationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveClientDelegationParam?(DelegationVariant13 @this) => @this.Client;

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant13(global::tryAGI.OpenAI.LiveClientDelegationParam? value)
        {
            Client = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DelegationVariant13 FromClient(global::tryAGI.OpenAI.LiveClientDelegationParam? value) => new DelegationVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DelegationVariant13(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam value) => new DelegationVariant13((global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam?(DelegationVariant13 @this) => @this.Responses;

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant13(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? value)
        {
            Responses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DelegationVariant13 FromResponses(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? value) => new DelegationVariant13(value);

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant13(
            global::tryAGI.OpenAI.LiveSessionUpdateParamsDelegationVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.LiveClientDelegationParam? client,
            global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam? responses
            )
        {
            Type = type;

            Client = client;
            Responses = responses;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Responses as object ??
            Client as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Client?.ToString() ??
            Responses?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsClient && !IsResponses || !IsClient && IsResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveClientDelegationParam, TResult>? client = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam, TResult>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClient && client != null)
            {
                return client(Client!);
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
            global::System.Action<global::tryAGI.OpenAI.LiveClientDelegationParam>? client = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClient)
            {
                client?.Invoke(Client!);
            }
            else if (IsResponses)
            {
                responses?.Invoke(Responses!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveClientDelegationParam>? client = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClient)
            {
                client?.Invoke(Client!);
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
                Client,
                typeof(global::tryAGI.OpenAI.LiveClientDelegationParam),
                Responses,
                typeof(global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam),
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
        public bool Equals(DelegationVariant13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveClientDelegationParam?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveResponsesDelegationUpdateParam?>.Default.Equals(Responses, other.Responses)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DelegationVariant13 obj1, DelegationVariant13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DelegationVariant13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DelegationVariant13 obj1, DelegationVariant13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DelegationVariant13 o && Equals(o);
        }
    }
}
