#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionInputVariant2Item : global::System.IEquatable<DecisionInputVariant2Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A user message containing input text or images, a developer or system message containing input text, or an assistant message containing output text or refusals. System messages are rendered as developer messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputMessage? Message { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputMessage? Message { get; }
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
            out global::tryAGI.OpenAI.DecisionInputMessage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputMessage PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputFunctionCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputFunctionCall? FunctionCall { get; }
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
            out global::tryAGI.OpenAI.DecisionInputFunctionCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCall PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputFunctionCallOutput PickFunctionCallOutput() => FunctionCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputCustomToolCall? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputCustomToolCall? CustomToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.DecisionInputCustomToolCall? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCall PickCustomToolCall() => CustomToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? CustomToolCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutput))]
#endif
        public bool IsCustomToolCallOutput => CustomToolCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput PickCustomToolCallOutput() => CustomToolCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputMessage value) => new DecisionInputVariant2Item((global::tryAGI.OpenAI.DecisionInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputMessage?(DecisionInputVariant2Item @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputMessage? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputVariant2Item FromMessage(global::tryAGI.OpenAI.DecisionInputMessage? value) => new DecisionInputVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputFunctionCall value) => new DecisionInputVariant2Item((global::tryAGI.OpenAI.DecisionInputFunctionCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputFunctionCall?(DecisionInputVariant2Item @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputFunctionCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputVariant2Item FromFunctionCall(global::tryAGI.OpenAI.DecisionInputFunctionCall? value) => new DecisionInputVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputFunctionCallOutput value) => new DecisionInputVariant2Item((global::tryAGI.OpenAI.DecisionInputFunctionCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputFunctionCallOutput?(DecisionInputVariant2Item @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputVariant2Item FromFunctionCallOutput(global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? value) => new DecisionInputVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputCustomToolCall value) => new DecisionInputVariant2Item((global::tryAGI.OpenAI.DecisionInputCustomToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputCustomToolCall?(DecisionInputVariant2Item @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputCustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputVariant2Item FromCustomToolCall(global::tryAGI.OpenAI.DecisionInputCustomToolCall? value) => new DecisionInputVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput value) => new DecisionInputVariant2Item((global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput?(DecisionInputVariant2Item @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputVariant2Item FromCustomToolCallOutput(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? value) => new DecisionInputVariant2Item(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputVariant2Item(
            global::tryAGI.OpenAI.DecisionInputVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.DecisionInputMessage? message,
            global::tryAGI.OpenAI.DecisionInputFunctionCall? functionCall,
            global::tryAGI.OpenAI.DecisionInputFunctionCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.DecisionInputCustomToolCall? customToolCall,
            global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput? customToolCallOutput
            )
        {
            Type = type;

            Message = message;
            FunctionCall = functionCall;
            FunctionCallOutput = functionCallOutput;
            CustomToolCall = customToolCall;
            CustomToolCallOutput = customToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolCallOutput as object ??
            CustomToolCall as object ??
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
            CustomToolCall?.ToString() ??
            CustomToolCallOutput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionCall && IsFunctionCallOutput && !IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionCall && !IsFunctionCallOutput && IsCustomToolCall && !IsCustomToolCallOutput || !IsMessage && !IsFunctionCall && !IsFunctionCallOutput && !IsCustomToolCall && IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.DecisionInputMessage, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputFunctionCall, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputFunctionCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputCustomToolCall, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput, TResult>? customToolCallOutput = null,
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
            else if (CustomToolCall is { } __value3 && customToolCall != null)
            {
                return customToolCall(__value3);
            }
            else if (CustomToolCallOutput is { } __value4 && customToolCallOutput != null)
            {
                return customToolCallOutput(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputMessage>? message = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputFunctionCall>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputFunctionCallOutput>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputCustomToolCall>? customToolCall = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput>? customToolCallOutput = null,
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
            else if (CustomToolCall is { } __value3)
            {
                customToolCall?.Invoke(__value3);
            }
            else if (CustomToolCallOutput is { } __value4)
            {
                customToolCallOutput?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.DecisionInputMessage>? message = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputFunctionCall>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputFunctionCallOutput>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputCustomToolCall>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput>? customToolCallOutput = null,
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
            else if (CustomToolCall is { } __value3)
            {
                customToolCall?.Invoke(__value3);
            }
            else if (CustomToolCallOutput is { } __value4)
            {
                customToolCallOutput?.Invoke(__value4);
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
                typeof(global::tryAGI.OpenAI.DecisionInputMessage),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.DecisionInputFunctionCall),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.DecisionInputFunctionCallOutput),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCall),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput),
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
        public bool Equals(DecisionInputVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputMessage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputFunctionCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputFunctionCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputCustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputCustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputVariant2Item obj1, DecisionInputVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputVariant2Item obj1, DecisionInputVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputVariant2Item o && Equals(o);
        }
    }
}
