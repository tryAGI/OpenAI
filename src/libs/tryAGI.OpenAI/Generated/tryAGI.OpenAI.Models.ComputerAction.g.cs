#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComputerAction : global::System.IEquatable<ComputerAction>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ComputerActionDiscriminatorType? Type { get; }

        /// <summary>
        /// A click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ClickParam? Click { get; init; }
#else
        public global::tryAGI.OpenAI.ClickParam? Click { get; }
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
            out global::tryAGI.OpenAI.ClickParam? value)
        {
            value = Click;
            return IsClick;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ClickParam PickClick() => IsClick
            ? Click!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Click' but the value was {ToString()}.");

        /// <summary>
        /// A double click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DoubleClickAction? DoubleClick { get; init; }
#else
        public global::tryAGI.OpenAI.DoubleClickAction? DoubleClick { get; }
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
            out global::tryAGI.OpenAI.DoubleClickAction? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.DoubleClickAction PickDoubleClick() => IsDoubleClick
            ? DoubleClick!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        /// A drag action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DragParam? Drag { get; init; }
#else
        public global::tryAGI.OpenAI.DragParam? Drag { get; }
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
            out global::tryAGI.OpenAI.DragParam? value)
        {
            value = Drag;
            return IsDrag;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.DragParam PickDrag() => IsDrag
            ? Drag!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Drag' but the value was {ToString()}.");

        /// <summary>
        /// A collection of keypresses the model would like to perform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.KeyPressAction? Keypress { get; init; }
#else
        public global::tryAGI.OpenAI.KeyPressAction? Keypress { get; }
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
            out global::tryAGI.OpenAI.KeyPressAction? value)
        {
            value = Keypress;
            return IsKeypress;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.KeyPressAction PickKeypress() => IsKeypress
            ? Keypress!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Keypress' but the value was {ToString()}.");

        /// <summary>
        /// A mouse move action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MoveParam? Move { get; init; }
#else
        public global::tryAGI.OpenAI.MoveParam? Move { get; }
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
            out global::tryAGI.OpenAI.MoveParam? value)
        {
            value = Move;
            return IsMove;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.MoveParam PickMove() => IsMove
            ? Move!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Move' but the value was {ToString()}.");

        /// <summary>
        /// A screenshot action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ScreenshotParam? Screenshot { get; init; }
#else
        public global::tryAGI.OpenAI.ScreenshotParam? Screenshot { get; }
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
            out global::tryAGI.OpenAI.ScreenshotParam? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ScreenshotParam PickScreenshot() => IsScreenshot
            ? Screenshot!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        /// A scroll action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ScrollParam? Scroll { get; init; }
#else
        public global::tryAGI.OpenAI.ScrollParam? Scroll { get; }
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
            out global::tryAGI.OpenAI.ScrollParam? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ScrollParam PickScroll() => IsScroll
            ? Scroll!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        /// An action to type in text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TypeParam? TypeValue { get; init; }
#else
        public global::tryAGI.OpenAI.TypeParam? TypeValue { get; }
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
            out global::tryAGI.OpenAI.TypeParam? value)
        {
            value = TypeValue;
            return IsTypeValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.TypeParam PickTypeValue() => IsTypeValue
            ? TypeValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TypeValue' but the value was {ToString()}.");

        /// <summary>
        /// A wait action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WaitParam? Wait { get; init; }
#else
        public global::tryAGI.OpenAI.WaitParam? Wait { get; }
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
            out global::tryAGI.OpenAI.WaitParam? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.WaitParam PickWait() => IsWait
            ? Wait!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.ClickParam value) => new ComputerAction((global::tryAGI.OpenAI.ClickParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ClickParam?(ComputerAction @this) => @this.Click;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.ClickParam? value)
        {
            Click = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromClick(global::tryAGI.OpenAI.ClickParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.DoubleClickAction value) => new ComputerAction((global::tryAGI.OpenAI.DoubleClickAction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DoubleClickAction?(ComputerAction @this) => @this.DoubleClick;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.DoubleClickAction? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromDoubleClick(global::tryAGI.OpenAI.DoubleClickAction? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.DragParam value) => new ComputerAction((global::tryAGI.OpenAI.DragParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DragParam?(ComputerAction @this) => @this.Drag;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.DragParam? value)
        {
            Drag = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromDrag(global::tryAGI.OpenAI.DragParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.KeyPressAction value) => new ComputerAction((global::tryAGI.OpenAI.KeyPressAction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.KeyPressAction?(ComputerAction @this) => @this.Keypress;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.KeyPressAction? value)
        {
            Keypress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromKeypress(global::tryAGI.OpenAI.KeyPressAction? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.MoveParam value) => new ComputerAction((global::tryAGI.OpenAI.MoveParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MoveParam?(ComputerAction @this) => @this.Move;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.MoveParam? value)
        {
            Move = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromMove(global::tryAGI.OpenAI.MoveParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.ScreenshotParam value) => new ComputerAction((global::tryAGI.OpenAI.ScreenshotParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ScreenshotParam?(ComputerAction @this) => @this.Screenshot;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.ScreenshotParam? value)
        {
            Screenshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromScreenshot(global::tryAGI.OpenAI.ScreenshotParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.ScrollParam value) => new ComputerAction((global::tryAGI.OpenAI.ScrollParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ScrollParam?(ComputerAction @this) => @this.Scroll;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.ScrollParam? value)
        {
            Scroll = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromScroll(global::tryAGI.OpenAI.ScrollParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.TypeParam value) => new ComputerAction((global::tryAGI.OpenAI.TypeParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TypeParam?(ComputerAction @this) => @this.TypeValue;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.TypeParam? value)
        {
            TypeValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromTypeValue(global::tryAGI.OpenAI.TypeParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.WaitParam value) => new ComputerAction((global::tryAGI.OpenAI.WaitParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WaitParam?(ComputerAction @this) => @this.Wait;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.WaitParam? value)
        {
            Wait = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComputerAction FromWait(global::tryAGI.OpenAI.WaitParam? value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(
            global::tryAGI.OpenAI.ComputerActionDiscriminatorType? type,
            global::tryAGI.OpenAI.ClickParam? click,
            global::tryAGI.OpenAI.DoubleClickAction? doubleClick,
            global::tryAGI.OpenAI.DragParam? drag,
            global::tryAGI.OpenAI.KeyPressAction? keypress,
            global::tryAGI.OpenAI.MoveParam? move,
            global::tryAGI.OpenAI.ScreenshotParam? screenshot,
            global::tryAGI.OpenAI.ScrollParam? scroll,
            global::tryAGI.OpenAI.TypeParam? typeValue,
            global::tryAGI.OpenAI.WaitParam? wait
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
            global::System.Func<global::tryAGI.OpenAI.ClickParam, TResult>? click = null,
            global::System.Func<global::tryAGI.OpenAI.DoubleClickAction, TResult>? doubleClick = null,
            global::System.Func<global::tryAGI.OpenAI.DragParam, TResult>? drag = null,
            global::System.Func<global::tryAGI.OpenAI.KeyPressAction, TResult>? keypress = null,
            global::System.Func<global::tryAGI.OpenAI.MoveParam, TResult>? move = null,
            global::System.Func<global::tryAGI.OpenAI.ScreenshotParam, TResult>? screenshot = null,
            global::System.Func<global::tryAGI.OpenAI.ScrollParam, TResult>? scroll = null,
            global::System.Func<global::tryAGI.OpenAI.TypeParam, TResult>? typeValue = null,
            global::System.Func<global::tryAGI.OpenAI.WaitParam, TResult>? wait = null,
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
            global::System.Action<global::tryAGI.OpenAI.ClickParam>? click = null,

            global::System.Action<global::tryAGI.OpenAI.DoubleClickAction>? doubleClick = null,

            global::System.Action<global::tryAGI.OpenAI.DragParam>? drag = null,

            global::System.Action<global::tryAGI.OpenAI.KeyPressAction>? keypress = null,

            global::System.Action<global::tryAGI.OpenAI.MoveParam>? move = null,

            global::System.Action<global::tryAGI.OpenAI.ScreenshotParam>? screenshot = null,

            global::System.Action<global::tryAGI.OpenAI.ScrollParam>? scroll = null,

            global::System.Action<global::tryAGI.OpenAI.TypeParam>? typeValue = null,

            global::System.Action<global::tryAGI.OpenAI.WaitParam>? wait = null,
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
            global::System.Action<global::tryAGI.OpenAI.ClickParam>? click = null,
            global::System.Action<global::tryAGI.OpenAI.DoubleClickAction>? doubleClick = null,
            global::System.Action<global::tryAGI.OpenAI.DragParam>? drag = null,
            global::System.Action<global::tryAGI.OpenAI.KeyPressAction>? keypress = null,
            global::System.Action<global::tryAGI.OpenAI.MoveParam>? move = null,
            global::System.Action<global::tryAGI.OpenAI.ScreenshotParam>? screenshot = null,
            global::System.Action<global::tryAGI.OpenAI.ScrollParam>? scroll = null,
            global::System.Action<global::tryAGI.OpenAI.TypeParam>? typeValue = null,
            global::System.Action<global::tryAGI.OpenAI.WaitParam>? wait = null,
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
                typeof(global::tryAGI.OpenAI.ClickParam),
                DoubleClick,
                typeof(global::tryAGI.OpenAI.DoubleClickAction),
                Drag,
                typeof(global::tryAGI.OpenAI.DragParam),
                Keypress,
                typeof(global::tryAGI.OpenAI.KeyPressAction),
                Move,
                typeof(global::tryAGI.OpenAI.MoveParam),
                Screenshot,
                typeof(global::tryAGI.OpenAI.ScreenshotParam),
                Scroll,
                typeof(global::tryAGI.OpenAI.ScrollParam),
                TypeValue,
                typeof(global::tryAGI.OpenAI.TypeParam),
                Wait,
                typeof(global::tryAGI.OpenAI.WaitParam),
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
        public bool Equals(ComputerAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ClickParam?>.Default.Equals(Click, other.Click) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DoubleClickAction?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DragParam?>.Default.Equals(Drag, other.Drag) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.KeyPressAction?>.Default.Equals(Keypress, other.Keypress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MoveParam?>.Default.Equals(Move, other.Move) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ScreenshotParam?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ScrollParam?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TypeParam?>.Default.Equals(TypeValue, other.TypeValue) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WaitParam?>.Default.Equals(Wait, other.Wait) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputerAction obj1, ComputerAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputerAction obj1, ComputerAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerAction o && Equals(o);
        }
    }
}
