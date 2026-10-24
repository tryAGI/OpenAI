#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LiveDecisionStoredInputItemParam : global::System.IEquatable<LiveDecisionStoredInputItemParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? Message { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? Message { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1 PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? FunctionCall { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam PickFunctionCallOutput() => FunctionCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? CustomToolCall { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam PickCustomToolCall() => CustomToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? CustomToolCallOutput { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam PickCustomToolCallOutput() => CustomToolCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1 value) => new LiveDecisionStoredInputItemParam((global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1?(LiveDecisionStoredInputItemParam @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionStoredInputItemParam FromMessage(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? value) => new LiveDecisionStoredInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam value) => new LiveDecisionStoredInputItemParam((global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam?(LiveDecisionStoredInputItemParam @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionStoredInputItemParam FromFunctionCall(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? value) => new LiveDecisionStoredInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam value) => new LiveDecisionStoredInputItemParam((global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam?(LiveDecisionStoredInputItemParam @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionStoredInputItemParam FromFunctionCallOutput(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? value) => new LiveDecisionStoredInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam value) => new LiveDecisionStoredInputItemParam((global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam?(LiveDecisionStoredInputItemParam @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionStoredInputItemParam FromCustomToolCall(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? value) => new LiveDecisionStoredInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam value) => new LiveDecisionStoredInputItemParam((global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam?(LiveDecisionStoredInputItemParam @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionStoredInputItemParam(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionStoredInputItemParam FromCustomToolCallOutput(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? value) => new LiveDecisionStoredInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionStoredInputItemParam(
            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? message,
            global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? functionCall,
            global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? functionCallOutput,
            global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? customToolCall,
            global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? customToolCallOutput
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
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam, TResult>? customToolCallOutput = null,
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1>? message = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam>? customToolCall = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam>? customToolCallOutput = null,
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1>? message = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam>? customToolCallOutput = null,
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
                typeof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam),
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
        public bool Equals(LiveDecisionStoredInputItemParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveDecisionStoredInputItemParam obj1, LiveDecisionStoredInputItemParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveDecisionStoredInputItemParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveDecisionStoredInputItemParam obj1, LiveDecisionStoredInputItemParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveDecisionStoredInputItemParam o && Equals(o);
        }
    }
}
