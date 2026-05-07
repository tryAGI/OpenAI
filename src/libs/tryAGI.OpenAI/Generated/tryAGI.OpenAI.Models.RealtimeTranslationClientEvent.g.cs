#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime translation client event.
    /// </summary>
    public readonly partial struct RealtimeTranslationClientEvent : global::System.IEquatable<RealtimeTranslationClientEvent>
    {
        /// <summary>
        /// Send this event to update the translation session configuration. Translation<br/>
        /// sessions support updates to `audio.output.language`, `audio.input.transcription`,<br/>
        /// and `audio.input.noise_reduction`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? SessionUpdate { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? SessionUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdate))]
#endif
        public bool IsSessionUpdate => SessionUpdate != null;

        /// <summary>
        /// Send this event to append audio bytes to the translation session input audio buffer.<br/>
        /// WebSocket translation sessions accept base64-encoded 24 kHz PCM16 mono<br/>
        /// little-endian raw audio bytes. Unsupported websocket audio formats return a<br/>
        /// validation error because lower-quality audio materially degrades translation<br/>
        /// quality.<br/>
        /// Translation consumes 200 ms engine frames. For best realtime behavior, append<br/>
        /// audio in 200 ms chunks. If a chunk is shorter, the server buffers it until it<br/>
        /// has enough audio for one frame. If a chunk is longer, the server splits it into<br/>
        /// 200 ms frames and enqueues them back-to-back.<br/>
        /// Keep appending silence while the session is active. If a client stops sending<br/>
        /// audio and later resumes, model time treats the resumed audio as contiguous with<br/>
        /// the previous audio rather than as a real-world pause.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? SessionInputAudioBufferAppend { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? SessionInputAudioBufferAppend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInputAudioBufferAppend))]
#endif
        public bool IsSessionInputAudioBufferAppend => SessionInputAudioBufferAppend != null;

        /// <summary>
        /// Gracefully close the realtime translation session. The server flushes pending<br/>
        /// input audio and emits any remaining translated output before closing the<br/>
        /// session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? SessionClose { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? SessionClose { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionClose))]
#endif
        public bool IsSessionClose => SessionClose != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationClientEvent(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate value) => new RealtimeTranslationClientEvent((global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate?(RealtimeTranslationClientEvent @this) => @this.SessionUpdate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationClientEvent(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? value)
        {
            SessionUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationClientEvent(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend value) => new RealtimeTranslationClientEvent((global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend?(RealtimeTranslationClientEvent @this) => @this.SessionInputAudioBufferAppend;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationClientEvent(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? value)
        {
            SessionInputAudioBufferAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranslationClientEvent(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose value) => new RealtimeTranslationClientEvent((global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose?(RealtimeTranslationClientEvent @this) => @this.SessionClose;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationClientEvent(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? value)
        {
            SessionClose = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranslationClientEvent(
            global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? sessionUpdate,
            global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? sessionInputAudioBufferAppend,
            global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? sessionClose
            )
        {
            SessionUpdate = sessionUpdate;
            SessionInputAudioBufferAppend = sessionInputAudioBufferAppend;
            SessionClose = sessionClose;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SessionClose as object ??
            SessionInputAudioBufferAppend as object ??
            SessionUpdate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionUpdate?.ToString() ??
            SessionInputAudioBufferAppend?.ToString() ??
            SessionClose?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionUpdate || IsSessionInputAudioBufferAppend || IsSessionClose;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate?, TResult>? sessionUpdate = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend?, TResult>? sessionInputAudioBufferAppend = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose?, TResult>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionUpdate && sessionUpdate != null)
            {
                return sessionUpdate(SessionUpdate!);
            }
            else if (IsSessionInputAudioBufferAppend && sessionInputAudioBufferAppend != null)
            {
                return sessionInputAudioBufferAppend(SessionInputAudioBufferAppend!);
            }
            else if (IsSessionClose && sessionClose != null)
            {
                return sessionClose(SessionClose!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate?>? sessionUpdate = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend?>? sessionInputAudioBufferAppend = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose?>? sessionClose = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionUpdate)
            {
                sessionUpdate?.Invoke(SessionUpdate!);
            }
            else if (IsSessionInputAudioBufferAppend)
            {
                sessionInputAudioBufferAppend?.Invoke(SessionInputAudioBufferAppend!);
            }
            else if (IsSessionClose)
            {
                sessionClose?.Invoke(SessionClose!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionUpdate,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate),
                SessionInputAudioBufferAppend,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend),
                SessionClose,
                typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose),
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
        public bool Equals(RealtimeTranslationClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate?>.Default.Equals(SessionUpdate, other.SessionUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend?>.Default.Equals(SessionInputAudioBufferAppend, other.SessionInputAudioBufferAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose?>.Default.Equals(SessionClose, other.SessionClose) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTranslationClientEvent obj1, RealtimeTranslationClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTranslationClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTranslationClientEvent obj1, RealtimeTranslationClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTranslationClientEvent o && Equals(o);
        }
    }
}
