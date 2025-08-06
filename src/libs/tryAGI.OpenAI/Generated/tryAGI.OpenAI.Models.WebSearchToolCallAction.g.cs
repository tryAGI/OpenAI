#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object describing the specific action taken in this web search call.<br/>
    /// Includes details on how the model used the web (search, open_page, find).
    /// </summary>
    public readonly partial struct WebSearchToolCallAction : global::System.IEquatable<WebSearchToolCallAction>
    {
        /// <summary>
        /// Action type "search" - Performs a web search query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionSearch? Value1 { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionSearch? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionSearch value) => new WebSearchToolCallAction((global::tryAGI.OpenAI.WebSearchActionSearch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionSearch?(WebSearchToolCallAction @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionSearch? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Action type "open_page" - Opens a specific URL from search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionOpenPage? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionOpenPage value) => new WebSearchToolCallAction((global::tryAGI.OpenAI.WebSearchActionOpenPage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionOpenPage?(WebSearchToolCallAction @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionOpenPage? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Action type "find": Searches for a pattern within a loaded page.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionFind? Value3 { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionFind? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionFind value) => new WebSearchToolCallAction((global::tryAGI.OpenAI.WebSearchActionFind?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionFind?(WebSearchToolCallAction @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(global::tryAGI.OpenAI.WebSearchActionFind? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebSearchToolCallAction(
            global::tryAGI.OpenAI.WebSearchActionSearch? value1,
            global::tryAGI.OpenAI.WebSearchActionOpenPage? value2,
            global::tryAGI.OpenAI.WebSearchActionFind? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionSearch?, TResult>? value1 = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionOpenPage?, TResult>? value2 = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionFind?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionSearch?>? value1 = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionOpenPage?>? value2 = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionFind?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::tryAGI.OpenAI.WebSearchActionSearch),
                Value2,
                typeof(global::tryAGI.OpenAI.WebSearchActionOpenPage),
                Value3,
                typeof(global::tryAGI.OpenAI.WebSearchActionFind),
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
        public bool Equals(WebSearchToolCallAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionSearch?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionOpenPage?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionFind?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebSearchToolCallAction obj1, WebSearchToolCallAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchToolCallAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebSearchToolCallAction obj1, WebSearchToolCallAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchToolCallAction o && Equals(o);
        }
    }
}
