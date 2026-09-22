#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolsItem14 : global::System.IEquatable<ToolsItem14>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A function tool available to the Responses backend when the Live model delegates a task.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Function { get; init; }
#else
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Function { get; }
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
            out global::tryAGI.OpenAI.LiveFunctionToolInputParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A web search tool available to the Live session’s Responses backend.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveFunctionToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveFunctionToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveFunctionToolInputParam?(ToolsItem14 @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveFunctionToolInputParam? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromFunction(global::tryAGI.OpenAI.LiveFunctionToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveWebSearchToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveWebSearchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveWebSearchToolInputParam?(ToolsItem14 @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromWebSearch(global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(
            global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveFunctionToolInputParam? function,
            global::tryAGI.OpenAI.LiveWebSearchToolInputParam? webSearch
            )
        {
            Type = type;

            Function = function;
            WebSearch = webSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsWebSearch || !IsFunction && IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveFunctionToolInputParam, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.LiveWebSearchToolInputParam, TResult>? webSearch = null,
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
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolInputParam>? function = null,

            global::System.Action<global::tryAGI.OpenAI.LiveWebSearchToolInputParam>? webSearch = null,
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
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolInputParam>? function = null,
            global::System.Action<global::tryAGI.OpenAI.LiveWebSearchToolInputParam>? webSearch = null,
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
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
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
                typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParam),
                WebSearch,
                typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParam),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveFunctionToolInputParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveWebSearchToolInputParam?>.Default.Equals(WebSearch, other.WebSearch)
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
