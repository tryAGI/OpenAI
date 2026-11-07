#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An existing item reference or a new message or function call item for a Realtime response.
    /// </summary>
    public readonly partial struct RealtimeResponseInputItem : global::System.IEquatable<RealtimeResponseInputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A message supplied as input to a Realtime response. The role determines the allowed content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputMessage? Message { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputMessage? Message { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseInputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputMessage PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// A function call supplied as input to a Realtime response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? FunctionCall { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// The result of a function call supplied as input to a Realtime response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput PickFunctionCallOutput() => FunctionCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Reference an existing item in this Realtime session as response.create input.<br/>
        /// Item references are only accepted in the response input array, not as new<br/>
        /// conversation items.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeResponseItemReference? ItemReference { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeResponseItemReference? ItemReference { get; }
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
            out global::tryAGI.OpenAI.RealtimeResponseItemReference? value)
        {
            value = ItemReference;
            return IsItemReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RealtimeResponseItemReference PickItemReference() => ItemReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ItemReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseInputMessage value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.RealtimeResponseInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputMessage?(RealtimeResponseInputItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseInputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromMessage(global::tryAGI.OpenAI.RealtimeResponseInputMessage? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall?(RealtimeResponseInputItem @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromFunctionCall(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput?(RealtimeResponseInputItem @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromFunctionCallOutput(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseItemReference value) => new RealtimeResponseInputItem((global::tryAGI.OpenAI.RealtimeResponseItemReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeResponseItemReference?(RealtimeResponseInputItem @this) => @this.ItemReference;

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(global::tryAGI.OpenAI.RealtimeResponseItemReference? value)
        {
            ItemReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RealtimeResponseInputItem FromItemReference(global::tryAGI.OpenAI.RealtimeResponseItemReference? value) => new RealtimeResponseInputItem(value);

        /// <summary>
        ///
        /// </summary>
        public RealtimeResponseInputItem(
            global::tryAGI.OpenAI.RealtimeResponseInputItemDiscriminatorType? type,
            global::tryAGI.OpenAI.RealtimeResponseInputMessage? message,
            global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall? functionCall,
            global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.RealtimeResponseItemReference? itemReference
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
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputMessage, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeResponseItemReference, TResult>? itemReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputMessage>? message = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseItemReference>? itemReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputMessage>? message = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeResponseItemReference>? itemReference = null,
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
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputMessage),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput),
                ItemReference,
                typeof(global::tryAGI.OpenAI.RealtimeResponseItemReference),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseInputFunctionCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeResponseItemReference?>.Default.Equals(ItemReference, other.ItemReference)
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
