#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent session becomes idle.
    /// </summary>
    public readonly partial struct WebhookAgentSessionIdle : global::System.IEquatable<WebhookAgentSessionIdle>
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
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? WebhookAgentSessionIdleVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? WebhookAgentSessionIdleVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentSessionIdleVariant2))]
#endif
        public bool IsWebhookAgentSessionIdleVariant2 => WebhookAgentSessionIdleVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentSessionIdleVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? value)
        {
            value = WebhookAgentSessionIdleVariant2;
            return IsWebhookAgentSessionIdleVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2 PickWebhookAgentSessionIdleVariant2() => WebhookAgentSessionIdleVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentSessionIdleVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionIdle(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentSessionIdle((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentSessionIdle @this) => @this.Envelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionIdle(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            Envelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionIdle FromEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentSessionIdle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionIdle(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2 value) => new WebhookAgentSessionIdle((global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2?(WebhookAgentSessionIdle @this) => @this.WebhookAgentSessionIdleVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionIdle(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? value)
        {
            WebhookAgentSessionIdleVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionIdle FromWebhookAgentSessionIdleVariant2(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? value) => new WebhookAgentSessionIdle(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionIdle(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? envelope,
            global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2? webhookAgentSessionIdleVariant2
            )
        {
            Envelope = envelope;
            WebhookAgentSessionIdleVariant2 = webhookAgentSessionIdleVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentSessionIdleVariant2 as object ??
            Envelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Envelope?.ToString() ??
            WebhookAgentSessionIdleVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvelope && IsWebhookAgentSessionIdleVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? envelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2, TResult>? webhookAgentSessionIdleVariant2 = null,
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
            else if (WebhookAgentSessionIdleVariant2 is { } __value1 && webhookAgentSessionIdleVariant2 != null)
            {
                return webhookAgentSessionIdleVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2>? webhookAgentSessionIdleVariant2 = null,
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
            else if (WebhookAgentSessionIdleVariant2 is { } __value1)
            {
                webhookAgentSessionIdleVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2>? webhookAgentSessionIdleVariant2 = null,
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
            else if (WebhookAgentSessionIdleVariant2 is { } __value1)
            {
                webhookAgentSessionIdleVariant2?.Invoke(__value1);
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
                WebhookAgentSessionIdleVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2),
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
        public bool Equals(WebhookAgentSessionIdle other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(Envelope, other.Envelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionIdleVariant2?>.Default.Equals(WebhookAgentSessionIdleVariant2, other.WebhookAgentSessionIdleVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentSessionIdle obj1, WebhookAgentSessionIdle obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentSessionIdle>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentSessionIdle obj1, WebhookAgentSessionIdle obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentSessionIdle o && Equals(o);
        }
    }
}
