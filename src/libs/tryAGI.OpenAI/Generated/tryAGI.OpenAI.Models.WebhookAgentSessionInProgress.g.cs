#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an agent session enters the in-progress state.
    /// </summary>
    public readonly partial struct WebhookAgentSessionInProgress : global::System.IEquatable<WebhookAgentSessionInProgress>
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
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? WebhookAgentSessionInProgressVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? WebhookAgentSessionInProgressVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentSessionInProgressVariant2))]
#endif
        public bool IsWebhookAgentSessionInProgressVariant2 => WebhookAgentSessionInProgressVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentSessionInProgressVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? value)
        {
            value = WebhookAgentSessionInProgressVariant2;
            return IsWebhookAgentSessionInProgressVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2 PickWebhookAgentSessionInProgressVariant2() => WebhookAgentSessionInProgressVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentSessionInProgressVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionInProgress(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentSessionInProgress((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentSessionInProgress @this) => @this.Envelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionInProgress(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            Envelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionInProgress FromEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentSessionInProgress(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentSessionInProgress(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2 value) => new WebhookAgentSessionInProgress((global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2?(WebhookAgentSessionInProgress @this) => @this.WebhookAgentSessionInProgressVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionInProgress(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? value)
        {
            WebhookAgentSessionInProgressVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentSessionInProgress FromWebhookAgentSessionInProgressVariant2(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? value) => new WebhookAgentSessionInProgress(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentSessionInProgress(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? envelope,
            global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2? webhookAgentSessionInProgressVariant2
            )
        {
            Envelope = envelope;
            WebhookAgentSessionInProgressVariant2 = webhookAgentSessionInProgressVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentSessionInProgressVariant2 as object ??
            Envelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Envelope?.ToString() ??
            WebhookAgentSessionInProgressVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvelope && IsWebhookAgentSessionInProgressVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? envelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2, TResult>? webhookAgentSessionInProgressVariant2 = null,
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
            else if (WebhookAgentSessionInProgressVariant2 is { } __value1 && webhookAgentSessionInProgressVariant2 != null)
            {
                return webhookAgentSessionInProgressVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2>? webhookAgentSessionInProgressVariant2 = null,
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
            else if (WebhookAgentSessionInProgressVariant2 is { } __value1)
            {
                webhookAgentSessionInProgressVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? envelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2>? webhookAgentSessionInProgressVariant2 = null,
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
            else if (WebhookAgentSessionInProgressVariant2 is { } __value1)
            {
                webhookAgentSessionInProgressVariant2?.Invoke(__value1);
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
                WebhookAgentSessionInProgressVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2),
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
        public bool Equals(WebhookAgentSessionInProgress other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(Envelope, other.Envelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionInProgressVariant2?>.Default.Equals(WebhookAgentSessionInProgressVariant2, other.WebhookAgentSessionInProgressVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentSessionInProgress obj1, WebhookAgentSessionInProgress obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentSessionInProgress>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentSessionInProgress obj1, WebhookAgentSessionInProgress obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentSessionInProgress o && Equals(o);
        }
    }
}
