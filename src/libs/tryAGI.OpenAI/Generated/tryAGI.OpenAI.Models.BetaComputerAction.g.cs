#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaComputerAction : global::System.IEquatable<BetaComputerAction>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? Type { get; }

        /// <summary>
        /// A click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaClickParam? Click { get; init; }
#else
        public global::tryAGI.OpenAI.BetaClickParam? Click { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Click))]
#endif
        public bool IsClick => Click != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaClickParam? value)
        {
            value = Click;
            return IsClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaClickParam PickClick() => IsClick
            ? Click!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Click' but the value was {ToString()}.");

        /// <summary>
        /// A double click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaDoubleClickAction? DoubleClick { get; init; }
#else
        public global::tryAGI.OpenAI.BetaDoubleClickAction? DoubleClick { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoubleClick))]
#endif
        public bool IsDoubleClick => DoubleClick != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDoubleClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaDoubleClickAction? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDoubleClickAction PickDoubleClick() => IsDoubleClick
            ? DoubleClick!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        /// A drag action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaDragParam? Drag { get; init; }
#else
        public global::tryAGI.OpenAI.BetaDragParam? Drag { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Drag))]
#endif
        public bool IsDrag => Drag != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDrag(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaDragParam? value)
        {
            value = Drag;
            return IsDrag;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDragParam PickDrag() => IsDrag
            ? Drag!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Drag' but the value was {ToString()}.");

        /// <summary>
        /// A collection of keypresses the model would like to perform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaKeyPressAction? Keypress { get; init; }
#else
        public global::tryAGI.OpenAI.BetaKeyPressAction? Keypress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Keypress))]
#endif
        public bool IsKeypress => Keypress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKeypress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaKeyPressAction? value)
        {
            value = Keypress;
            return IsKeypress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaKeyPressAction PickKeypress() => IsKeypress
            ? Keypress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Keypress' but the value was {ToString()}.");

        /// <summary>
        /// A mouse move action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMoveParam? Move { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMoveParam? Move { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Move))]
#endif
        public bool IsMove => Move != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMove(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaMoveParam? value)
        {
            value = Move;
            return IsMove;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaMoveParam PickMove() => IsMove
            ? Move!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Move' but the value was {ToString()}.");

        /// <summary>
        /// A screenshot action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaScreenshotParam? Screenshot { get; init; }
#else
        public global::tryAGI.OpenAI.BetaScreenshotParam? Screenshot { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Screenshot))]
#endif
        public bool IsScreenshot => Screenshot != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScreenshot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaScreenshotParam? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScreenshotParam PickScreenshot() => IsScreenshot
            ? Screenshot!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        /// A scroll action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaScrollParam? Scroll { get; init; }
#else
        public global::tryAGI.OpenAI.BetaScrollParam? Scroll { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scroll))]
#endif
        public bool IsScroll => Scroll != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScroll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaScrollParam? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaScrollParam PickScroll() => IsScroll
            ? Scroll!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        /// An action to type in text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaTypeParam? TypeValue { get; init; }
#else
        public global::tryAGI.OpenAI.BetaTypeParam? TypeValue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TypeValue))]
#endif
        public bool IsTypeValue => TypeValue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTypeValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaTypeParam? value)
        {
            value = TypeValue;
            return IsTypeValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaTypeParam PickTypeValue() => IsTypeValue
            ? TypeValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeValue' but the value was {ToString()}.");

        /// <summary>
        /// A wait action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWaitParam? Wait { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWaitParam? Wait { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wait))]
#endif
        public bool IsWait => Wait != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWait(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaWaitParam? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaWaitParam PickWait() => IsWait
            ? Wait!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaClickParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaClickParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaClickParam?(BetaComputerAction @this) => @this.Click;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaClickParam? value)
        {
            Click = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromClick(global::tryAGI.OpenAI.BetaClickParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaDoubleClickAction value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaDoubleClickAction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaDoubleClickAction?(BetaComputerAction @this) => @this.DoubleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaDoubleClickAction? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromDoubleClick(global::tryAGI.OpenAI.BetaDoubleClickAction? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaDragParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaDragParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaDragParam?(BetaComputerAction @this) => @this.Drag;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaDragParam? value)
        {
            Drag = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromDrag(global::tryAGI.OpenAI.BetaDragParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaKeyPressAction value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaKeyPressAction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaKeyPressAction?(BetaComputerAction @this) => @this.Keypress;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaKeyPressAction? value)
        {
            Keypress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromKeypress(global::tryAGI.OpenAI.BetaKeyPressAction? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaMoveParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaMoveParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMoveParam?(BetaComputerAction @this) => @this.Move;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaMoveParam? value)
        {
            Move = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromMove(global::tryAGI.OpenAI.BetaMoveParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaScreenshotParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaScreenshotParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaScreenshotParam?(BetaComputerAction @this) => @this.Screenshot;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaScreenshotParam? value)
        {
            Screenshot = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromScreenshot(global::tryAGI.OpenAI.BetaScreenshotParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaScrollParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaScrollParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaScrollParam?(BetaComputerAction @this) => @this.Scroll;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaScrollParam? value)
        {
            Scroll = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromScroll(global::tryAGI.OpenAI.BetaScrollParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaTypeParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaTypeParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaTypeParam?(BetaComputerAction @this) => @this.TypeValue;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaTypeParam? value)
        {
            TypeValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromTypeValue(global::tryAGI.OpenAI.BetaTypeParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerAction(global::tryAGI.OpenAI.BetaWaitParam value) => new BetaComputerAction((global::tryAGI.OpenAI.BetaWaitParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWaitParam?(BetaComputerAction @this) => @this.Wait;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(global::tryAGI.OpenAI.BetaWaitParam? value)
        {
            Wait = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerAction FromWait(global::tryAGI.OpenAI.BetaWaitParam? value) => new BetaComputerAction(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComputerAction(
            global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaClickParam? click,
            global::tryAGI.OpenAI.BetaDoubleClickAction? doubleClick,
            global::tryAGI.OpenAI.BetaDragParam? drag,
            global::tryAGI.OpenAI.BetaKeyPressAction? keypress,
            global::tryAGI.OpenAI.BetaMoveParam? move,
            global::tryAGI.OpenAI.BetaScreenshotParam? screenshot,
            global::tryAGI.OpenAI.BetaScrollParam? scroll,
            global::tryAGI.OpenAI.BetaTypeParam? typeValue,
            global::tryAGI.OpenAI.BetaWaitParam? wait
            )
        {
            Type = type;

            Click = click;
            DoubleClick = doubleClick;
            Drag = drag;
            Keypress = keypress;
            Move = move;
            Screenshot = screenshot;
            Scroll = scroll;
            TypeValue = typeValue;
            Wait = wait;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Wait as object ??
            TypeValue as object ??
            Scroll as object ??
            Screenshot as object ??
            Move as object ??
            Keypress as object ??
            Drag as object ??
            DoubleClick as object ??
            Click as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Click?.ToString() ??
            DoubleClick?.ToString() ??
            Drag?.ToString() ??
            Keypress?.ToString() ??
            Move?.ToString() ??
            Screenshot?.ToString() ??
            Scroll?.ToString() ??
            TypeValue?.ToString() ??
            Wait?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsClick && !IsDoubleClick && !IsDrag && !IsKeypress && !IsMove && !IsScreenshot && !IsScroll && !IsTypeValue && !IsWait || !IsClick && IsDoubleClick && !IsDrag && !IsKeypress && !IsMove && !IsScreenshot && !IsScroll && !IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && IsDrag && !IsKeypress && !IsMove && !IsScreenshot && !IsScroll && !IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && IsKeypress && !IsMove && !IsScreenshot && !IsScroll && !IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeypress && IsMove && !IsScreenshot && !IsScroll && !IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeypress && !IsMove && IsScreenshot && !IsScroll && !IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeypress && !IsMove && !IsScreenshot && IsScroll && !IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeypress && !IsMove && !IsScreenshot && !IsScroll && IsTypeValue && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeypress && !IsMove && !IsScreenshot && !IsScroll && !IsTypeValue && IsWait;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaClickParam, TResult>? click = null,
            global::System.Func<global::tryAGI.OpenAI.BetaDoubleClickAction, TResult>? doubleClick = null,
            global::System.Func<global::tryAGI.OpenAI.BetaDragParam, TResult>? drag = null,
            global::System.Func<global::tryAGI.OpenAI.BetaKeyPressAction, TResult>? keypress = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMoveParam, TResult>? move = null,
            global::System.Func<global::tryAGI.OpenAI.BetaScreenshotParam, TResult>? screenshot = null,
            global::System.Func<global::tryAGI.OpenAI.BetaScrollParam, TResult>? scroll = null,
            global::System.Func<global::tryAGI.OpenAI.BetaTypeParam, TResult>? typeValue = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWaitParam, TResult>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick && click != null)
            {
                return click(Click!);
            }
            else if (IsDoubleClick && doubleClick != null)
            {
                return doubleClick(DoubleClick!);
            }
            else if (IsDrag && drag != null)
            {
                return drag(Drag!);
            }
            else if (IsKeypress && keypress != null)
            {
                return keypress(Keypress!);
            }
            else if (IsMove && move != null)
            {
                return move(Move!);
            }
            else if (IsScreenshot && screenshot != null)
            {
                return screenshot(Screenshot!);
            }
            else if (IsScroll && scroll != null)
            {
                return scroll(Scroll!);
            }
            else if (IsTypeValue && typeValue != null)
            {
                return typeValue(TypeValue!);
            }
            else if (IsWait && wait != null)
            {
                return wait(Wait!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaClickParam>? click = null,

            global::System.Action<global::tryAGI.OpenAI.BetaDoubleClickAction>? doubleClick = null,

            global::System.Action<global::tryAGI.OpenAI.BetaDragParam>? drag = null,

            global::System.Action<global::tryAGI.OpenAI.BetaKeyPressAction>? keypress = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMoveParam>? move = null,

            global::System.Action<global::tryAGI.OpenAI.BetaScreenshotParam>? screenshot = null,

            global::System.Action<global::tryAGI.OpenAI.BetaScrollParam>? scroll = null,

            global::System.Action<global::tryAGI.OpenAI.BetaTypeParam>? typeValue = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWaitParam>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick)
            {
                click?.Invoke(Click!);
            }
            else if (IsDoubleClick)
            {
                doubleClick?.Invoke(DoubleClick!);
            }
            else if (IsDrag)
            {
                drag?.Invoke(Drag!);
            }
            else if (IsKeypress)
            {
                keypress?.Invoke(Keypress!);
            }
            else if (IsMove)
            {
                move?.Invoke(Move!);
            }
            else if (IsScreenshot)
            {
                screenshot?.Invoke(Screenshot!);
            }
            else if (IsScroll)
            {
                scroll?.Invoke(Scroll!);
            }
            else if (IsTypeValue)
            {
                typeValue?.Invoke(TypeValue!);
            }
            else if (IsWait)
            {
                wait?.Invoke(Wait!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaClickParam>? click = null,
            global::System.Action<global::tryAGI.OpenAI.BetaDoubleClickAction>? doubleClick = null,
            global::System.Action<global::tryAGI.OpenAI.BetaDragParam>? drag = null,
            global::System.Action<global::tryAGI.OpenAI.BetaKeyPressAction>? keypress = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMoveParam>? move = null,
            global::System.Action<global::tryAGI.OpenAI.BetaScreenshotParam>? screenshot = null,
            global::System.Action<global::tryAGI.OpenAI.BetaScrollParam>? scroll = null,
            global::System.Action<global::tryAGI.OpenAI.BetaTypeParam>? typeValue = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWaitParam>? wait = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClick)
            {
                click?.Invoke(Click!);
            }
            else if (IsDoubleClick)
            {
                doubleClick?.Invoke(DoubleClick!);
            }
            else if (IsDrag)
            {
                drag?.Invoke(Drag!);
            }
            else if (IsKeypress)
            {
                keypress?.Invoke(Keypress!);
            }
            else if (IsMove)
            {
                move?.Invoke(Move!);
            }
            else if (IsScreenshot)
            {
                screenshot?.Invoke(Screenshot!);
            }
            else if (IsScroll)
            {
                scroll?.Invoke(Scroll!);
            }
            else if (IsTypeValue)
            {
                typeValue?.Invoke(TypeValue!);
            }
            else if (IsWait)
            {
                wait?.Invoke(Wait!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Click,
                typeof(global::tryAGI.OpenAI.BetaClickParam),
                DoubleClick,
                typeof(global::tryAGI.OpenAI.BetaDoubleClickAction),
                Drag,
                typeof(global::tryAGI.OpenAI.BetaDragParam),
                Keypress,
                typeof(global::tryAGI.OpenAI.BetaKeyPressAction),
                Move,
                typeof(global::tryAGI.OpenAI.BetaMoveParam),
                Screenshot,
                typeof(global::tryAGI.OpenAI.BetaScreenshotParam),
                Scroll,
                typeof(global::tryAGI.OpenAI.BetaScrollParam),
                TypeValue,
                typeof(global::tryAGI.OpenAI.BetaTypeParam),
                Wait,
                typeof(global::tryAGI.OpenAI.BetaWaitParam),
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
        public bool Equals(BetaComputerAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaClickParam?>.Default.Equals(Click, other.Click) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaDoubleClickAction?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaDragParam?>.Default.Equals(Drag, other.Drag) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaKeyPressAction?>.Default.Equals(Keypress, other.Keypress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMoveParam?>.Default.Equals(Move, other.Move) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaScreenshotParam?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaScrollParam?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaTypeParam?>.Default.Equals(TypeValue, other.TypeValue) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWaitParam?>.Default.Equals(Wait, other.Wait)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComputerAction obj1, BetaComputerAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComputerAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComputerAction obj1, BetaComputerAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComputerAction o && Equals(o);
        }
    }
}
