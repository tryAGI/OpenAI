#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function or custom tool that belongs to a namespace.
    /// </summary>
    public readonly partial struct ToolsItem4 : global::System.IEquatable<ToolsItem4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolParam? Function { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolParam? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.FunctionToolParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionToolParam PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A custom tool that processes input using a specified format. Learn more about   [custom tools](https://developers.openai.com/api/docs/guides/function-calling#custom-tools)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolParam? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolParam? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CustomToolParam? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CustomToolParam PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem4(global::tryAGI.OpenAI.FunctionToolParam value) => new ToolsItem4((global::tryAGI.OpenAI.FunctionToolParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolParam?(ToolsItem4 @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem4(global::tryAGI.OpenAI.FunctionToolParam? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem4 FromFunction(global::tryAGI.OpenAI.FunctionToolParam? value) => new ToolsItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem4(global::tryAGI.OpenAI.CustomToolParam value) => new ToolsItem4((global::tryAGI.OpenAI.CustomToolParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolParam?(ToolsItem4 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem4(global::tryAGI.OpenAI.CustomToolParam? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem4 FromCustom(global::tryAGI.OpenAI.CustomToolParam? value) => new ToolsItem4(value);

        /// <summary>
        ///
        /// </summary>
        public ToolsItem4(
            global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType? type,
            global::tryAGI.OpenAI.FunctionToolParam? function,
            global::tryAGI.OpenAI.CustomToolParam? custom
            )
        {
            Type = type;

            Function = function;
            Custom = custom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Custom as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Custom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsCustom || !IsFunction && IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FunctionToolParam, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolParam, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0 && function != null)
            {
                return function(__value0);
            }
            else if (Custom is { } __value1 && custom != null)
            {
                return custom(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FunctionToolParam>? function = null,

            global::System.Action<global::tryAGI.OpenAI.CustomToolParam>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.FunctionToolParam>? function = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolParam>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::tryAGI.OpenAI.FunctionToolParam),
                Custom,
                typeof(global::tryAGI.OpenAI.CustomToolParam),
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
        public bool Equals(ToolsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolParam?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem4 o && Equals(o);
        }
    }
}
