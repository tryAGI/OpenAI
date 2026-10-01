#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent session requires an action. Retrieve the session for action details.
    /// </summary>
    public readonly partial struct WebhookAgentSessionActionRequired : global::System.IEquatable<WebhookAgentSessionActionRequired>
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
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? WebhookAgentSessionActionRequiredVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? WebhookAgentSessionActionRequiredVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentSessionActionRequiredVariant2))]
#endif
        public bool IsWebhookAgentSessionActionRequiredVariant2 => WebhookAgentSessionActionRequiredVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentSessionActionRequiredVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? value)
        {
            value = WebhookAgentSessionActionRequiredVariant2;
            return IsWebhookAgentSessionActionRequiredVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2 PickWebhookAgentSessionActionRequiredVariant2() => WebhookAgentSessionActionRequiredVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentSessionActionRequiredVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionActionRequired(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentSessionActionRequired((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentSessionActionRequired @this) => @this.Envelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionActionRequired(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            Envelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionActionRequired FromEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentSessionActionRequired(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionActionRequired(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2 value) => new WebhookAgentSessionActionRequired((global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2?(WebhookAgentSessionActionRequired @this) => @this.WebhookAgentSessionActionRequiredVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionActionRequired(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? value)
        {
            WebhookAgentSessionActionRequiredVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionActionRequired FromWebhookAgentSessionActionRequiredVariant2(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? value) => new WebhookAgentSessionActionRequired(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionActionRequired(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? envelope,
            global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2? webhookAgentSessionActionRequiredVariant2
            )
        {
            Envelope = envelope;
            WebhookAgentSessionActionRequiredVariant2 = webhookAgentSessionActionRequiredVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentSessionActionRequiredVariant2 as object ??
            Envelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Envelope?.ToString() ??
            WebhookAgentSessionActionRequiredVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvelope && IsWebhookAgentSessionActionRequiredVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? envelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2, TResult>? webhookAgentSessionActionRequiredVariant2 = null,
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
            else if (WebhookAgentSessionActionRequiredVariant2 is { } __value1 && webhookAgentSessionActionRequiredVariant2 != null)
            {
                return webhookAgentSessionActionRequiredVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2>? webhookAgentSessionActionRequiredVariant2 = null,
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
            else if (WebhookAgentSessionActionRequiredVariant2 is { } __value1)
            {
                webhookAgentSessionActionRequiredVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2>? webhookAgentSessionActionRequiredVariant2 = null,
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
            else if (WebhookAgentSessionActionRequiredVariant2 is { } __value1)
            {
                webhookAgentSessionActionRequiredVariant2?.Invoke(__value1);
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
                WebhookAgentSessionActionRequiredVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2),
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
        public bool Equals(WebhookAgentSessionActionRequired other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(Envelope, other.Envelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionActionRequiredVariant2?>.Default.Equals(WebhookAgentSessionActionRequiredVariant2, other.WebhookAgentSessionActionRequiredVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentSessionActionRequired obj1, WebhookAgentSessionActionRequired obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentSessionActionRequired>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentSessionActionRequired obj1, WebhookAgentSessionActionRequired obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentSessionActionRequired o && Equals(o);
        }
    }
}
