#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent session is created.
    /// </summary>
    public readonly partial struct WebhookAgentSessionCreated : global::System.IEquatable<WebhookAgentSessionCreated>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Envelope { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? Envelope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Envelope))]
#endif
        public bool IsEnvelope => Envelope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnvelope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            value = Envelope;
            return IsEnvelope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope PickEnvelope() => Envelope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Envelope' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? WebhookAgentSessionCreatedVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? WebhookAgentSessionCreatedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentSessionCreatedVariant2))]
#endif
        public bool IsWebhookAgentSessionCreatedVariant2 => WebhookAgentSessionCreatedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentSessionCreatedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? value)
        {
            value = WebhookAgentSessionCreatedVariant2;
            return IsWebhookAgentSessionCreatedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2 PickWebhookAgentSessionCreatedVariant2() => WebhookAgentSessionCreatedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentSessionCreatedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionCreated(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentSessionCreated((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentSessionCreated @this) => @this.Envelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionCreated(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            Envelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionCreated FromEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentSessionCreated(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionCreated(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2 value) => new WebhookAgentSessionCreated((global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2?(WebhookAgentSessionCreated @this) => @this.WebhookAgentSessionCreatedVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionCreated(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? value)
        {
            WebhookAgentSessionCreatedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionCreated FromWebhookAgentSessionCreatedVariant2(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? value) => new WebhookAgentSessionCreated(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionCreated(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? envelope,
            global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2? webhookAgentSessionCreatedVariant2
            )
        {
            Envelope = envelope;
            WebhookAgentSessionCreatedVariant2 = webhookAgentSessionCreatedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentSessionCreatedVariant2 as object ??
            Envelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Envelope?.ToString() ??
            WebhookAgentSessionCreatedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvelope && IsWebhookAgentSessionCreatedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? envelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2, TResult>? webhookAgentSessionCreatedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Envelope is { } __value0 && envelope != null)
            {
                return envelope(__value0);
            }
            else if (WebhookAgentSessionCreatedVariant2 is { } __value1 && webhookAgentSessionCreatedVariant2 != null)
            {
                return webhookAgentSessionCreatedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2>? webhookAgentSessionCreatedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Envelope is { } __value0)
            {
                envelope?.Invoke(__value0);
            }
            else if (WebhookAgentSessionCreatedVariant2 is { } __value1)
            {
                webhookAgentSessionCreatedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2>? webhookAgentSessionCreatedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Envelope is { } __value0)
            {
                envelope?.Invoke(__value0);
            }
            else if (WebhookAgentSessionCreatedVariant2 is { } __value1)
            {
                webhookAgentSessionCreatedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Envelope,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope),
                WebhookAgentSessionCreatedVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2),
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
        public bool Equals(WebhookAgentSessionCreated other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(Envelope, other.Envelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionCreatedVariant2?>.Default.Equals(WebhookAgentSessionCreatedVariant2, other.WebhookAgentSessionCreatedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentSessionCreated obj1, WebhookAgentSessionCreated obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentSessionCreated>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentSessionCreated obj1, WebhookAgentSessionCreated obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentSessionCreated o && Equals(o);
        }
    }
}
