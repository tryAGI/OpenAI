#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function or custom tool that belongs to a namespace.
    /// </summary>
    public readonly partial struct ToolsItem13 : global::System.IEquatable<ToolsItem13>
    {
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
        /// A custom tool that processes input using a specified format. Learn more about   [custom tools](/docs/guides/function-calling#custom-tools)
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
        public static implicit operator ToolsItem13(global::tryAGI.OpenAI.FunctionToolParam value) => new ToolsItem13((global::tryAGI.OpenAI.FunctionToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolParam?(ToolsItem13 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem13(global::tryAGI.OpenAI.FunctionToolParam? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem13(global::tryAGI.OpenAI.CustomToolParam value) => new ToolsItem13((global::tryAGI.OpenAI.CustomToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolParam?(ToolsItem13 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem13(global::tryAGI.OpenAI.CustomToolParam? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem13(
            global::tryAGI.OpenAI.FunctionToolParam? function,
            global::tryAGI.OpenAI.CustomToolParam? custom
            )
        {
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
            global::System.Func<global::tryAGI.OpenAI.FunctionToolParam?, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolParam?, TResult>? custom = null,
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
            global::System.Action<global::tryAGI.OpenAI.FunctionToolParam?>? function = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolParam?>? custom = null,
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
        public bool Equals(ToolsItem13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolParam?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem13 obj1, ToolsItem13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem13 obj1, ToolsItem13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem13 o && Equals(o);
        }
    }
}
