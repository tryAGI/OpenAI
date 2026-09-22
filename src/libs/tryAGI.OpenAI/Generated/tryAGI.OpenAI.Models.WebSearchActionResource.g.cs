#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An action performed by the web search tool.
    /// </summary>
    public readonly partial struct WebSearchActionResource : global::System.IEquatable<WebSearchActionResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A search query or group of search queries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Search { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch? Search { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebSearchActionResourceSearch? value)
        {
            value = Search;
            return IsSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceSearch PickSearch() => IsSearch
            ? Search!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Search' but the value was {ToString()}.");

        /// <summary>
        /// Opens a web page.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? OpenPage { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? OpenPage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenPage))]
#endif
        public bool IsOpenPage => OpenPage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenPage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? value)
        {
            value = OpenPage;
            return IsOpenPage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOpenPage PickOpenPage() => IsOpenPage
            ? OpenPage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenPage' but the value was {ToString()}.");

        /// <summary>
        /// Finds text within a web page.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? FindInPage { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? FindInPage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FindInPage))]
#endif
        public bool IsFindInPage => FindInPage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFindInPage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? value)
        {
            value = FindInPage;
            return IsFindInPage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceFindInPage PickFindInPage() => IsFindInPage
            ? FindInPage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FindInPage' but the value was {ToString()}.");

        /// <summary>
        /// Another web search action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Other { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchActionResourceOther? Other { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Other))]
#endif
        public bool IsOther => Other != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOther(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.WebSearchActionResourceOther? value)
        {
            value = Other;
            return IsOther;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.WebSearchActionResourceOther PickOther() => IsOther
            ? Other!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Other' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceSearch value) => new WebSearchActionResource((global::tryAGI.OpenAI.WebSearchActionResourceSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionResourceSearch?(WebSearchActionResource @this) => @this.Search;

        /// <summary>
        ///
        /// </summary>
        public WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceSearch? value)
        {
            Search = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchActionResource FromSearch(global::tryAGI.OpenAI.WebSearchActionResourceSearch? value) => new WebSearchActionResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceOpenPage value) => new WebSearchActionResource((global::tryAGI.OpenAI.WebSearchActionResourceOpenPage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionResourceOpenPage?(WebSearchActionResource @this) => @this.OpenPage;

        /// <summary>
        ///
        /// </summary>
        public WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? value)
        {
            OpenPage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchActionResource FromOpenPage(global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? value) => new WebSearchActionResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceFindInPage value) => new WebSearchActionResource((global::tryAGI.OpenAI.WebSearchActionResourceFindInPage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionResourceFindInPage?(WebSearchActionResource @this) => @this.FindInPage;

        /// <summary>
        ///
        /// </summary>
        public WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? value)
        {
            FindInPage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchActionResource FromFindInPage(global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? value) => new WebSearchActionResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceOther value) => new WebSearchActionResource((global::tryAGI.OpenAI.WebSearchActionResourceOther?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchActionResourceOther?(WebSearchActionResource @this) => @this.Other;

        /// <summary>
        ///
        /// </summary>
        public WebSearchActionResource(global::tryAGI.OpenAI.WebSearchActionResourceOther? value)
        {
            Other = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebSearchActionResource FromOther(global::tryAGI.OpenAI.WebSearchActionResourceOther? value) => new WebSearchActionResource(value);

        /// <summary>
        ///
        /// </summary>
        public WebSearchActionResource(
            global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.WebSearchActionResourceSearch? search,
            global::tryAGI.OpenAI.WebSearchActionResourceOpenPage? openPage,
            global::tryAGI.OpenAI.WebSearchActionResourceFindInPage? findInPage,
            global::tryAGI.OpenAI.WebSearchActionResourceOther? other
            )
        {
            Type = type;

            Search = search;
            OpenPage = openPage;
            FindInPage = findInPage;
            Other = other;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Other as object ??
            FindInPage as object ??
            OpenPage as object ??
            Search as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Search?.ToString() ??
            OpenPage?.ToString() ??
            FindInPage?.ToString() ??
            Other?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSearch && !IsOpenPage && !IsFindInPage && !IsOther || !IsSearch && IsOpenPage && !IsFindInPage && !IsOther || !IsSearch && !IsOpenPage && IsFindInPage && !IsOther || !IsSearch && !IsOpenPage && !IsFindInPage && IsOther;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionResourceSearch, TResult>? search = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionResourceOpenPage, TResult>? openPage = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionResourceFindInPage, TResult>? findInPage = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchActionResourceOther, TResult>? other = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsOpenPage && openPage != null)
            {
                return openPage(OpenPage!);
            }
            else if (IsFindInPage && findInPage != null)
            {
                return findInPage(FindInPage!);
            }
            else if (IsOther && other != null)
            {
                return other(Other!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceSearch>? search = null,

            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceOpenPage>? openPage = null,

            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceFindInPage>? findInPage = null,

            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceOther>? other = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsOpenPage)
            {
                openPage?.Invoke(OpenPage!);
            }
            else if (IsFindInPage)
            {
                findInPage?.Invoke(FindInPage!);
            }
            else if (IsOther)
            {
                other?.Invoke(Other!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceSearch>? search = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceOpenPage>? openPage = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceFindInPage>? findInPage = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchActionResourceOther>? other = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsOpenPage)
            {
                openPage?.Invoke(OpenPage!);
            }
            else if (IsFindInPage)
            {
                findInPage?.Invoke(FindInPage!);
            }
            else if (IsOther)
            {
                other?.Invoke(Other!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Search,
                typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearch),
                OpenPage,
                typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPage),
                FindInPage,
                typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPage),
                Other,
                typeof(global::tryAGI.OpenAI.WebSearchActionResourceOther),
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
        public bool Equals(WebSearchActionResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionResourceSearch?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionResourceOpenPage?>.Default.Equals(OpenPage, other.OpenPage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionResourceFindInPage?>.Default.Equals(FindInPage, other.FindInPage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchActionResourceOther?>.Default.Equals(Other, other.Other)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebSearchActionResource obj1, WebSearchActionResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebSearchActionResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebSearchActionResource obj1, WebSearchActionResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebSearchActionResource o && Equals(o);
        }
    }
}
