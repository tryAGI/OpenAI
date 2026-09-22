#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server events for Live. Response lifecycle events are wrapped inside response.event; dispatch the nested event by its full type and tolerate new response event types. Follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) when designing the conversation and delegation policy.
    /// </summary>
    public readonly partial struct LiveServerEvent : global::System.IEquatable<LiveServerEvent>
    {
        /// <summary>
        /// An event sent by the Live API on a primary WebSocket or sideband connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveServerEvent2? Event2 { get; init; }
#else
        public global::tryAGI.OpenAI.LiveServerEvent2? Event2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event2))]
#endif
        public bool IsEvent2 => Event2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEvent2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveServerEvent2? value)
        {
            value = Event2;
            return IsEvent2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2 PickEvent2() => IsEvent2
            ? Event2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent(global::tryAGI.OpenAI.LiveServerEvent2 value) => new LiveServerEvent((global::tryAGI.OpenAI.LiveServerEvent2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveServerEvent2?(LiveServerEvent @this) => @this.Event2;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent(global::tryAGI.OpenAI.LiveServerEvent2? value)
        {
            Event2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent FromEvent2(global::tryAGI.OpenAI.LiveServerEvent2? value) => new LiveServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Event2 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Event2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvent2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveServerEvent2?, TResult>? event2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent2 && event2 != null)
            {
                return event2(Event2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveServerEvent2?>? event2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent2)
            {
                event2?.Invoke(Event2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveServerEvent2?>? event2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent2)
            {
                event2?.Invoke(Event2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Event2,
                typeof(global::tryAGI.OpenAI.LiveServerEvent2),
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
        public bool Equals(LiveServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveServerEvent2?>.Default.Equals(Event2, other.Event2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveServerEvent obj1, LiveServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveServerEvent obj1, LiveServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveServerEvent o && Equals(o);
        }
    }
}
