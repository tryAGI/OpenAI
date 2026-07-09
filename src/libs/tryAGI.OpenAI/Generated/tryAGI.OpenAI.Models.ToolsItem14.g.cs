#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function or custom tool that belongs to a namespace.
    /// </summary>
    public readonly partial struct ToolsItem14 : global::System.IEquatable<ToolsItem14>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Function { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolParam? Function { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionToolParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolParam PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A custom tool that processes input using a specified format. Learn more about   [custom tools](/docs/guides/function-calling#custom-tools)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolParam? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolParam? Custom { get; }
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
            out global::tryAGI.OpenAI.BetaCustomToolParam? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.BetaFunctionToolParam value) => new ToolsItem14((global::tryAGI.OpenAI.BetaFunctionToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolParam?(ToolsItem14 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.BetaFunctionToolParam? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem14 FromFunction(global::tryAGI.OpenAI.BetaFunctionToolParam? value) => new ToolsItem14(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.BetaCustomToolParam value) => new ToolsItem14((global::tryAGI.OpenAI.BetaCustomToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolParam?(ToolsItem14 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.BetaCustomToolParam? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem14 FromCustom(global::tryAGI.OpenAI.BetaCustomToolParam? value) => new ToolsItem14(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem14(
            global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaFunctionToolParam? function,
            global::tryAGI.OpenAI.BetaCustomToolParam? custom
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
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolParam, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolParam, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolParam>? function = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolParam>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolParam>? function = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolParam>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
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
                typeof(global::tryAGI.OpenAI.BetaFunctionToolParam),
                Custom,
                typeof(global::tryAGI.OpenAI.BetaCustomToolParam),
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
        public bool Equals(ToolsItem14 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolParam?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem14 obj1, ToolsItem14 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem14>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem14 obj1, ToolsItem14 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem14 o && Equals(o);
        }
    }
}
