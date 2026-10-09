#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a prewarmed OpenAI-hosted environment finishes setup before being attached to a session.
    /// </summary>
    public readonly partial struct WebhookAgentEnvironmentReady : global::System.IEquatable<WebhookAgentEnvironmentReady>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? SessionEnvelope { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? SessionEnvelope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionEnvelope))]
#endif
        public bool IsSessionEnvelope => SessionEnvelope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionEnvelope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            value = SessionEnvelope;
            return IsSessionEnvelope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentSessionEnvelope PickSessionEnvelope() => SessionEnvelope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionEnvelope' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? WebhookAgentEnvironmentReadyVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? WebhookAgentEnvironmentReadyVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentEnvironmentReadyVariant2))]
#endif
        public bool IsWebhookAgentEnvironmentReadyVariant2 => WebhookAgentEnvironmentReadyVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentEnvironmentReadyVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? value)
        {
            value = WebhookAgentEnvironmentReadyVariant2;
            return IsWebhookAgentEnvironmentReadyVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2 PickWebhookAgentEnvironmentReadyVariant2() => WebhookAgentEnvironmentReadyVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentEnvironmentReadyVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentReady(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentEnvironmentReady((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentEnvironmentReady @this) => @this.SessionEnvelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentReady(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            SessionEnvelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentReady FromSessionEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentEnvironmentReady(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentReady(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2 value) => new WebhookAgentEnvironmentReady((global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2?(WebhookAgentEnvironmentReady @this) => @this.WebhookAgentEnvironmentReadyVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentReady(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? value)
        {
            WebhookAgentEnvironmentReadyVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentReady FromWebhookAgentEnvironmentReadyVariant2(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? value) => new WebhookAgentEnvironmentReady(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentReady(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? sessionEnvelope,
            global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2? webhookAgentEnvironmentReadyVariant2
            )
        {
            SessionEnvelope = sessionEnvelope;
            WebhookAgentEnvironmentReadyVariant2 = webhookAgentEnvironmentReadyVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentEnvironmentReadyVariant2 as object ??
            SessionEnvelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionEnvelope?.ToString() ??
            WebhookAgentEnvironmentReadyVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionEnvelope && IsWebhookAgentEnvironmentReadyVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? sessionEnvelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2, TResult>? webhookAgentEnvironmentReadyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionEnvelope is { } __value0 && sessionEnvelope != null)
            {
                return sessionEnvelope(__value0);
            }
            else if (WebhookAgentEnvironmentReadyVariant2 is { } __value1 && webhookAgentEnvironmentReadyVariant2 != null)
            {
                return webhookAgentEnvironmentReadyVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2>? webhookAgentEnvironmentReadyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionEnvelope is { } __value0)
            {
                sessionEnvelope?.Invoke(__value0);
            }
            else if (WebhookAgentEnvironmentReadyVariant2 is { } __value1)
            {
                webhookAgentEnvironmentReadyVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2>? webhookAgentEnvironmentReadyVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SessionEnvelope is { } __value0)
            {
                sessionEnvelope?.Invoke(__value0);
            }
            else if (WebhookAgentEnvironmentReadyVariant2 is { } __value1)
            {
                webhookAgentEnvironmentReadyVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionEnvelope,
                typeof(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope),
                WebhookAgentEnvironmentReadyVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2),
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
        public bool Equals(WebhookAgentEnvironmentReady other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(SessionEnvelope, other.SessionEnvelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentEnvironmentReadyVariant2?>.Default.Equals(WebhookAgentEnvironmentReadyVariant2, other.WebhookAgentEnvironmentReadyVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentEnvironmentReady obj1, WebhookAgentEnvironmentReady obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentEnvironmentReady>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentEnvironmentReady obj1, WebhookAgentEnvironmentReady obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentEnvironmentReady o && Equals(o);
        }
    }
}
