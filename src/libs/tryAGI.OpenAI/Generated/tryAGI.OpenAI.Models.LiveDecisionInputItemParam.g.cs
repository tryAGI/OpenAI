#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LiveDecisionInputItemParam : global::System.IEquatable<LiveDecisionInputItemParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? Message { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? Message { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1 PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? FunctionCall { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallParam PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam PickFunctionCallOutput() => FunctionCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? CustomToolCall { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam PickCustomToolCall() => CustomToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? CustomToolCallOutput { get; }
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
            out global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam PickCustomToolCallOutput() => CustomToolCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1 value) => new LiveDecisionInputItemParam((global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1?(LiveDecisionInputItemParam @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionInputItemParam FromMessage(global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? value) => new LiveDecisionInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionFunctionCallParam value) => new LiveDecisionInputItemParam((global::tryAGI.OpenAI.LiveDecisionFunctionCallParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionFunctionCallParam?(LiveDecisionInputItemParam @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionInputItemParam FromFunctionCall(global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? value) => new LiveDecisionInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam value) => new LiveDecisionInputItemParam((global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam?(LiveDecisionInputItemParam @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionInputItemParam FromFunctionCallOutput(global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? value) => new LiveDecisionInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam value) => new LiveDecisionInputItemParam((global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam?(LiveDecisionInputItemParam @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionInputItemParam FromCustomToolCall(global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? value) => new LiveDecisionInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam value) => new LiveDecisionInputItemParam((global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam?(LiveDecisionInputItemParam @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionInputItemParam(global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveDecisionInputItemParam FromCustomToolCallOutput(global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? value) => new LiveDecisionInputItemParam(value);

        /// <summary>
        ///
        /// </summary>
        public LiveDecisionInputItemParam(
            global::tryAGI.OpenAI.LiveDecisionInputItemParamDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1? message,
            global::tryAGI.OpenAI.LiveDecisionFunctionCallParam? functionCall,
            global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam? functionCallOutput,
            global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam? customToolCall,
            global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam? customToolCallOutput
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
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1, TResult>? message = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionFunctionCallParam, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam, TResult>? customToolCallOutput = null,
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1>? message = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionFunctionCallParam>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam>? customToolCall = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam>? customToolCallOutput = null,
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
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1>? message = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionFunctionCallParam>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam>? customToolCallOutput = null,
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
                typeof(global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1),
                FunctionCall,
                typeof(global::tryAGI.OpenAI.LiveDecisionFunctionCallParam),
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam),
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam),
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
        public bool Equals(LiveDecisionInputItemParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionInputItemParamVariant1?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionFunctionCallParam?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionFunctionCallOutputParam?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionCustomToolCallParam?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionCustomToolCallOutputParam?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveDecisionInputItemParam obj1, LiveDecisionInputItemParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveDecisionInputItemParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveDecisionInputItemParam obj1, LiveDecisionInputItemParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveDecisionInputItemParam o && Equals(o);
        }
    }
}
