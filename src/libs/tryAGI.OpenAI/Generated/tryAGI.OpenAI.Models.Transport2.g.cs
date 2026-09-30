#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// WebRTC transport with an SDP answer, or SIP transport without SDP or trunk credentials. For SIP, attach a sideband using session.id to receive transport.ringing, transport.answered, and transport.failed notifications.
    /// </summary>
    public readonly partial struct Transport2 : global::System.IEquatable<Transport2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? Type { get; }

        /// <summary>
        /// WebRTC transport carrying the offer SDP in a creation request or answer SDP in its response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Webrtc { get; init; }
#else
        public global::tryAGI.OpenAI.LiveWebRTCTransport? Webrtc { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webrtc))]
#endif
        public bool IsWebrtc => Webrtc != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebrtc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveWebRTCTransport? value)
        {
            value = Webrtc;
            return IsWebrtc;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebRTCTransport PickWebrtc() => Webrtc is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webrtc' but the value was {ToString()}.");

        /// <summary>
        /// The SIP transport. Trunk credentials and SDP are not returned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Sip { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? Sip { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sip))]
#endif
        public bool IsSip => Sip != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSip(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? value)
        {
            value = Sip;
            return IsSip;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2 PickSip() => Sip is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sip' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Transport2(global::tryAGI.OpenAI.LiveWebRTCTransport value) => new Transport2((global::tryAGI.OpenAI.LiveWebRTCTransport?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveWebRTCTransport?(Transport2 @this) => @this.Webrtc;

        /// <summary>
        ///
        /// </summary>
        public Transport2(global::tryAGI.OpenAI.LiveWebRTCTransport? value)
        {
            Webrtc = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Transport2 FromWebrtc(global::tryAGI.OpenAI.LiveWebRTCTransport? value) => new Transport2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Transport2(global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2 value) => new Transport2((global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2?(Transport2 @this) => @this.Sip;

        /// <summary>
        ///
        /// </summary>
        public Transport2(global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? value)
        {
            Sip = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Transport2 FromSip(global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? value) => new Transport2(value);

        /// <summary>
        ///
        /// </summary>
        public Transport2(
            global::tryAGI.OpenAI.LiveSessionCreateResponseTransportDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveWebRTCTransport? webrtc,
            global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2? sip
            )
        {
            Type = type;

            Webrtc = webrtc;
            Sip = sip;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sip as object ??
            Webrtc as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Webrtc?.ToString() ??
            Sip?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebrtc && !IsSip || !IsWebrtc && IsSip;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveWebRTCTransport, TResult>? webrtc = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2, TResult>? sip = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Webrtc is { } __value0 && webrtc != null)
            {
                return webrtc(__value0);
            }
            else if (Sip is { } __value1 && sip != null)
            {
                return sip(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveWebRTCTransport>? webrtc = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2>? sip = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Webrtc is { } __value0)
            {
                webrtc?.Invoke(__value0);
            }
            else if (Sip is { } __value1)
            {
                sip?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveWebRTCTransport>? webrtc = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2>? sip = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Webrtc is { } __value0)
            {
                webrtc?.Invoke(__value0);
            }
            else if (Sip is { } __value1)
            {
                sip?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webrtc,
                typeof(global::tryAGI.OpenAI.LiveWebRTCTransport),
                Sip,
                typeof(global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2),
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
        public bool Equals(Transport2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveWebRTCTransport?>.Default.Equals(Webrtc, other.Webrtc) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionCreateResponseTransportVariant2?>.Default.Equals(Sip, other.Sip)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Transport2 obj1, Transport2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Transport2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Transport2 obj1, Transport2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Transport2 o && Equals(o);
        }
    }
}
