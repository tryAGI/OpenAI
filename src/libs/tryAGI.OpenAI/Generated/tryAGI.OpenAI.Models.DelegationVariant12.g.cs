#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Who handles tasks delegated by the Live model. Omitted or null selects your application; use `responses` or `decisions` to delegate to the corresponding API.
    /// </summary>
    public readonly partial struct DelegationVariant12 : global::System.IEquatable<DelegationVariant12>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? Type { get; }

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
        public global::tryAGI.OpenAI.LiveClientDelegationParam PickClient() => Client is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");

        /// <summary>
        /// Delegate tasks to a Responses model managed by the Live session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Responses { get; init; }
#else
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam? Responses { get; }
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
            out global::tryAGI.OpenAI.LiveResponsesDelegationParam? value)
        {
            value = Responses;
            return IsResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationParam PickResponses() => Responses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Responses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam? Decisions { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam? Decisions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Decisions))]
#endif
        public bool IsDecisions => Decisions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionsDelegationParam? value)
        {
            value = Decisions;
            return IsDecisions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionsDelegationParam PickDecisions() => Decisions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Decisions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DelegationVariant12(global::tryAGI.OpenAI.LiveClientDelegationParam value) => new DelegationVariant12((global::tryAGI.OpenAI.LiveClientDelegationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveClientDelegationParam?(DelegationVariant12 @this) => @this.Client;

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant12(global::tryAGI.OpenAI.LiveClientDelegationParam? value)
        {
            Client = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DelegationVariant12 FromClient(global::tryAGI.OpenAI.LiveClientDelegationParam? value) => new DelegationVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DelegationVariant12(global::tryAGI.OpenAI.LiveResponsesDelegationParam value) => new DelegationVariant12((global::tryAGI.OpenAI.LiveResponsesDelegationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponsesDelegationParam?(DelegationVariant12 @this) => @this.Responses;

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant12(global::tryAGI.OpenAI.LiveResponsesDelegationParam? value)
        {
            Responses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DelegationVariant12 FromResponses(global::tryAGI.OpenAI.LiveResponsesDelegationParam? value) => new DelegationVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DelegationVariant12(global::tryAGI.OpenAI.LiveDecisionsDelegationParam value) => new DelegationVariant12((global::tryAGI.OpenAI.LiveDecisionsDelegationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionsDelegationParam?(DelegationVariant12 @this) => @this.Decisions;

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant12(global::tryAGI.OpenAI.LiveDecisionsDelegationParam? value)
        {
            Decisions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DelegationVariant12 FromDecisions(global::tryAGI.OpenAI.LiveDecisionsDelegationParam? value) => new DelegationVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public DelegationVariant12(
            global::tryAGI.OpenAI.LiveSessionCreateParamsDelegationVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.LiveClientDelegationParam? client,
            global::tryAGI.OpenAI.LiveResponsesDelegationParam? responses,
            global::tryAGI.OpenAI.LiveDecisionsDelegationParam? decisions
            )
        {
            Type = type;

            Client = client;
            Responses = responses;
            Decisions = decisions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Decisions as object ??
            Responses as object ??
            Client as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Client?.ToString() ??
            Responses?.ToString() ??
            Decisions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsClient && !IsResponses && !IsDecisions || !IsClient && IsResponses && !IsDecisions || !IsClient && !IsResponses && IsDecisions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveClientDelegationParam, TResult>? client = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponsesDelegationParam, TResult>? responses = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionsDelegationParam, TResult>? decisions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Client is { } __value0 && client != null)
            {
                return client(__value0);
            }
            else if (Responses is { } __value1 && responses != null)
            {
                return responses(__value1);
            }
            else if (Decisions is { } __value2 && decisions != null)
            {
                return decisions(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveClientDelegationParam>? client = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponsesDelegationParam>? responses = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionsDelegationParam>? decisions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Client is { } __value0)
            {
                client?.Invoke(__value0);
            }
            else if (Responses is { } __value1)
            {
                responses?.Invoke(__value1);
            }
            else if (Decisions is { } __value2)
            {
                decisions?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveClientDelegationParam>? client = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponsesDelegationParam>? responses = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionsDelegationParam>? decisions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Client is { } __value0)
            {
                client?.Invoke(__value0);
            }
            else if (Responses is { } __value1)
            {
                responses?.Invoke(__value1);
            }
            else if (Decisions is { } __value2)
            {
                decisions?.Invoke(__value2);
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
                typeof(global::tryAGI.OpenAI.LiveResponsesDelegationParam),
                Decisions,
                typeof(global::tryAGI.OpenAI.LiveDecisionsDelegationParam),
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
        public bool Equals(DelegationVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveClientDelegationParam?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveResponsesDelegationParam?>.Default.Equals(Responses, other.Responses) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionsDelegationParam?>.Default.Equals(Decisions, other.Decisions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DelegationVariant12 obj1, DelegationVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DelegationVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DelegationVariant12 obj1, DelegationVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DelegationVariant12 o && Equals(o);
        }
    }
}
