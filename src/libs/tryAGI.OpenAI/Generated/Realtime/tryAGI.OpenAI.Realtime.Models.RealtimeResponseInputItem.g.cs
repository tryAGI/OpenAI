#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// An existing item reference or a new message or function call item for a Realtime response.
    /// </summary>
    public readonly partial struct RealtimeResponseInputItem : global::System.IEquatable<RealtimeResponseInputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A message supplied as input to a Realtime response. The role determines the allowed content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? Message { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// A function call supplied as input to a Realtime response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// The result of a function call supplied as input to a Realtime response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? FunctionCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput PickFunctionCallOutput() => FunctionCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Reference an existing item in this Realtime session as response.create input.<br/>
        /// Item references are only accepted in the response input array, not as new<br/>
        /// conversation items.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? ItemReference { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? ItemReference { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ItemReference))]
#endif
        public bool IsItemReference => ItemReference != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickItemReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? value)
        {
            value = ItemReference;
            return IsItemReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference PickItemReference() => ItemReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ItemReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage?(RealtimeResponseInputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromMessage(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall?(RealtimeResponseInputItem @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromFunctionCall(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput?(RealtimeResponseInputItem @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromFunctionCallOutput(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference?(RealtimeResponseInputItem @this) => @this.ItemReference;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? value)
        {
            ItemReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromItemReference(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType? type,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? message,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? functionCall,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? itemReference
            )
        {
            Type = type;

            Message = message;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            ItemReference = itemReference;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ItemReference as object ??
            FunctionCallOutput as object ??
            FunctionCall as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionCallOutput?.ToString() ??
            ItemReference?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage || IsFunctionCall || IsFunctionCallOutput || IsItemReference;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference, TResult>? itemReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0 && message != null)
            {
                return message(__value0);
            }
            else if (FunctionCall is { } __value1 && functionCall != null)
            {
                return functionCall(__value1);
            }
            else if (FunctionCallOutput is { } __value2 && functionCallOutput != null)
            {
                return functionCallOutput(__value2);
            }
            else if (ItemReference is { } __value3 && itemReference != null)
            {
                return itemReference(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage>? message = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference>? itemReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (FunctionCall is { } __value1)
            {
                functionCall?.Invoke(__value1);
            }
            else if (FunctionCallOutput is { } __value2)
            {
                functionCallOutput?.Invoke(__value2);
            }
            else if (ItemReference is { } __value3)
            {
                itemReference?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage>? message = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference>? itemReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (FunctionCall is { } __value1)
            {
                functionCall?.Invoke(__value1);
            }
            else if (FunctionCallOutput is { } __value2)
            {
                functionCallOutput?.Invoke(__value2);
            }
            else if (ItemReference is { } __value3)
            {
                itemReference?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput),
                ItemReference,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference),
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
        public bool Equals(RealtimeResponseInputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference?>.Default.Equals(ItemReference, other.ItemReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RealtimeResponseInputItem obj1, RealtimeResponseInputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeResponseInputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RealtimeResponseInputItem obj1, RealtimeResponseInputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeResponseInputItem o && Equals(o);
        }
    }
}
