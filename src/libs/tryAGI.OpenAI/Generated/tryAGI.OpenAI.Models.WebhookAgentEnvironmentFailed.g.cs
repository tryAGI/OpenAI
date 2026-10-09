#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when setup fails for a prewarmed OpenAI-hosted environment before it is attached to a session.
    /// </summary>
    public readonly partial struct WebhookAgentEnvironmentFailed : global::System.IEquatable<WebhookAgentEnvironmentFailed>
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
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? WebhookAgentEnvironmentFailedVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? WebhookAgentEnvironmentFailedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookAgentEnvironmentFailedVariant2))]
#endif
        public bool IsWebhookAgentEnvironmentFailedVariant2 => WebhookAgentEnvironmentFailedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookAgentEnvironmentFailedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? value)
        {
            value = WebhookAgentEnvironmentFailedVariant2;
            return IsWebhookAgentEnvironmentFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2 PickWebhookAgentEnvironmentFailedVariant2() => WebhookAgentEnvironmentFailedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookAgentEnvironmentFailedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentFailed(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope value) => new WebhookAgentEnvironmentFailed((global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?(WebhookAgentEnvironmentFailed @this) => @this.SessionEnvelope;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentFailed(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value)
        {
            SessionEnvelope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentFailed FromSessionEnvelope(global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? value) => new WebhookAgentEnvironmentFailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookAgentEnvironmentFailed(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2 value) => new WebhookAgentEnvironmentFailed((global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2?(WebhookAgentEnvironmentFailed @this) => @this.WebhookAgentEnvironmentFailedVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentFailed(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? value)
        {
            WebhookAgentEnvironmentFailedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookAgentEnvironmentFailed FromWebhookAgentEnvironmentFailedVariant2(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? value) => new WebhookAgentEnvironmentFailed(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookAgentEnvironmentFailed(
            global::tryAGI.OpenAI.WebhookAgentSessionEnvelope? sessionEnvelope,
            global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2? webhookAgentEnvironmentFailedVariant2
            )
        {
            SessionEnvelope = sessionEnvelope;
            WebhookAgentEnvironmentFailedVariant2 = webhookAgentEnvironmentFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookAgentEnvironmentFailedVariant2 as object ??
            SessionEnvelope as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SessionEnvelope?.ToString() ??
            WebhookAgentEnvironmentFailedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionEnvelope && IsWebhookAgentEnvironmentFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope, TResult>? sessionEnvelope = null,
            global::System.Func<global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2, TResult>? webhookAgentEnvironmentFailedVariant2 = null,
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
            else if (WebhookAgentEnvironmentFailedVariant2 is { } __value1 && webhookAgentEnvironmentFailedVariant2 != null)
            {
                return webhookAgentEnvironmentFailedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,

            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2>? webhookAgentEnvironmentFailedVariant2 = null,
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
            else if (WebhookAgentEnvironmentFailedVariant2 is { } __value1)
            {
                webhookAgentEnvironmentFailedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope>? sessionEnvelope = null,
            global::System.Action<global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2>? webhookAgentEnvironmentFailedVariant2 = null,
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
            else if (WebhookAgentEnvironmentFailedVariant2 is { } __value1)
            {
                webhookAgentEnvironmentFailedVariant2?.Invoke(__value1);
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
                WebhookAgentEnvironmentFailedVariant2,
                typeof(global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2),
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
        public bool Equals(WebhookAgentEnvironmentFailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentSessionEnvelope?>.Default.Equals(SessionEnvelope, other.SessionEnvelope) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebhookAgentEnvironmentFailedVariant2?>.Default.Equals(WebhookAgentEnvironmentFailedVariant2, other.WebhookAgentEnvironmentFailedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookAgentEnvironmentFailed obj1, WebhookAgentEnvironmentFailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookAgentEnvironmentFailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookAgentEnvironmentFailed obj1, WebhookAgentEnvironmentFailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookAgentEnvironmentFailed o && Equals(o);
        }
    }
}
