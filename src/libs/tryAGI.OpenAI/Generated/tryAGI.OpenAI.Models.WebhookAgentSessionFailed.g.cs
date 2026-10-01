#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent session fails.
    /// </summary>
    public readonly partial struct WebhookAgentSessionFailed : global::System.IEquatable<WebhookAgentSessionFailed>
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
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? WebhookAgentSessionFailedVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? WebhookAgentSessionFailedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentSessionFailedVariant2))]
#endif
        public bool IsWebhookAgentSessionFailedVariant2 => WebhookAgentSessionFailedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentSessionFailedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? value)
        {
            value = WebhookAgentSessionFailedVariant2;
            return IsWebhookAgentSessionFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2 PickWebhookAgentSessionFailedVariant2() => WebhookAgentSessionFailedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentSessionFailedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionFailed(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentSessionFailed((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentSessionFailed @this) => @this.Envelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionFailed(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            Envelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionFailed FromEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentSessionFailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionFailed(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2 value) => new WebhookAgentSessionFailed((global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2?(WebhookAgentSessionFailed @this) => @this.WebhookAgentSessionFailedVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionFailed(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? value)
        {
            WebhookAgentSessionFailedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionFailed FromWebhookAgentSessionFailedVariant2(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? value) => new WebhookAgentSessionFailed(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionFailed(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? envelope,
            global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2? webhookAgentSessionFailedVariant2
            )
        {
            Envelope = envelope;
            WebhookAgentSessionFailedVariant2 = webhookAgentSessionFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentSessionFailedVariant2 as object ??
            Envelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Envelope?.ToString() ??
            WebhookAgentSessionFailedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvelope && IsWebhookAgentSessionFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? envelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2, TResult>? webhookAgentSessionFailedVariant2 = null,
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
            else if (WebhookAgentSessionFailedVariant2 is { } __value1 && webhookAgentSessionFailedVariant2 != null)
            {
                return webhookAgentSessionFailedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2>? webhookAgentSessionFailedVariant2 = null,
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
            else if (WebhookAgentSessionFailedVariant2 is { } __value1)
            {
                webhookAgentSessionFailedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2>? webhookAgentSessionFailedVariant2 = null,
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
            else if (WebhookAgentSessionFailedVariant2 is { } __value1)
            {
                webhookAgentSessionFailedVariant2?.Invoke(__value1);
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
                WebhookAgentSessionFailedVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2),
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
        public bool Equals(WebhookAgentSessionFailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(Envelope, other.Envelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionFailedVariant2?>.Default.Equals(WebhookAgentSessionFailedVariant2, other.WebhookAgentSessionFailedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentSessionFailed obj1, WebhookAgentSessionFailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentSessionFailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentSessionFailed obj1, WebhookAgentSessionFailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentSessionFailed o && Equals(o);
        }
    }
}
