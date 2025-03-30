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
        /// A click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Click? Click { get; init; }
#else
        public global::tryAGI.OpenAI.Click? Click { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Click value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Click?(ComputerAction @this) => @this.Click;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Click? value)
        {
            Click = value;
        }

        /// <summary>
        /// A double click action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DoubleClick? DoubleClick { get; init; }
#else
        public global::tryAGI.OpenAI.DoubleClick? DoubleClick { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.DoubleClick value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DoubleClick?(ComputerAction @this) => @this.DoubleClick;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.DoubleClick? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        /// A drag action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Drag? Drag { get; init; }
#else
        public global::tryAGI.OpenAI.Drag? Drag { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Drag value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Drag?(ComputerAction @this) => @this.Drag;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Drag? value)
        {
            Drag = value;
        }

        /// <summary>
        /// A collection of keypresses the model would like to perform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.KeyPress? KeyPress { get; init; }
#else
        public global::tryAGI.OpenAI.KeyPress? KeyPress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyPress))]
#endif
        public bool IsKeyPress => KeyPress != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.KeyPress value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.KeyPress?(ComputerAction @this) => @this.KeyPress;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.KeyPress? value)
        {
            KeyPress = value;
        }

        /// <summary>
        /// A mouse move action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Move? Move { get; init; }
#else
        public global::tryAGI.OpenAI.Move? Move { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Move value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Move?(ComputerAction @this) => @this.Move;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Move? value)
        {
            Move = value;
        }

        /// <summary>
        /// A screenshot action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Screenshot? Screenshot { get; init; }
#else
        public global::tryAGI.OpenAI.Screenshot? Screenshot { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Screenshot value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Screenshot?(ComputerAction @this) => @this.Screenshot;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Screenshot? value)
        {
            Screenshot = value;
        }

        /// <summary>
        /// A scroll action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Scroll? Scroll { get; init; }
#else
        public global::tryAGI.OpenAI.Scroll? Scroll { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Scroll value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Scroll?(ComputerAction @this) => @this.Scroll;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Scroll? value)
        {
            Scroll = value;
        }

        /// <summary>
        /// An action to type in text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Type? Type { get; init; }
#else
        public global::tryAGI.OpenAI.Type? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Type value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Type?(ComputerAction @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Type? value)
        {
            Type = value;
        }

        /// <summary>
        /// A wait action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Wait? Wait { get; init; }
#else
        public global::tryAGI.OpenAI.Wait? Wait { get; }
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
        public static implicit operator ComputerAction(global::tryAGI.OpenAI.Wait value) => new ComputerAction(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Wait?(ComputerAction @this) => @this.Wait;

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(global::tryAGI.OpenAI.Wait? value)
        {
            Wait = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComputerAction(
            global::tryAGI.OpenAI.Click? click,
            global::tryAGI.OpenAI.DoubleClick? doubleClick,
            global::tryAGI.OpenAI.Drag? drag,
            global::tryAGI.OpenAI.KeyPress? keyPress,
            global::tryAGI.OpenAI.Move? move,
            global::tryAGI.OpenAI.Screenshot? screenshot,
            global::tryAGI.OpenAI.Scroll? scroll,
            global::tryAGI.OpenAI.Type? type,
            global::tryAGI.OpenAI.Wait? wait
            )
        {
            Click = click;
            DoubleClick = doubleClick;
            Drag = drag;
            KeyPress = keyPress;
            Move = move;
            Screenshot = screenshot;
            Scroll = scroll;
            Type = type;
            Wait = wait;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Wait as object ??
            Type as object ??
            Scroll as object ??
            Screenshot as object ??
            Move as object ??
            KeyPress as object ??
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
            KeyPress?.ToString() ??
            Move?.ToString() ??
            Screenshot?.ToString() ??
            Scroll?.ToString() ??
            Type?.ToString() ??
            Wait?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && IsMove && !IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && IsScreenshot && !IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && IsScroll && !IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && IsType && !IsWait || !IsClick && !IsDoubleClick && !IsDrag && !IsKeyPress && !IsMove && !IsScreenshot && !IsScroll && !IsType && IsWait;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Click?, TResult>? click = null,
            global::System.Func<global::tryAGI.OpenAI.DoubleClick?, TResult>? doubleClick = null,
            global::System.Func<global::tryAGI.OpenAI.Drag?, TResult>? drag = null,
            global::System.Func<global::tryAGI.OpenAI.KeyPress?, TResult>? keyPress = null,
            global::System.Func<global::tryAGI.OpenAI.Move?, TResult>? move = null,
            global::System.Func<global::tryAGI.OpenAI.Screenshot?, TResult>? screenshot = null,
            global::System.Func<global::tryAGI.OpenAI.Scroll?, TResult>? scroll = null,
            global::System.Func<global::tryAGI.OpenAI.Type?, TResult>? type = null,
            global::System.Func<global::tryAGI.OpenAI.Wait?, TResult>? wait = null,
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
            else if (IsKeyPress && keyPress != null)
            {
                return keyPress(KeyPress!);
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
            else if (IsType && type != null)
            {
                return type(Type!);
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
            global::System.Action<global::tryAGI.OpenAI.Click?>? click = null,
            global::System.Action<global::tryAGI.OpenAI.DoubleClick?>? doubleClick = null,
            global::System.Action<global::tryAGI.OpenAI.Drag?>? drag = null,
            global::System.Action<global::tryAGI.OpenAI.KeyPress?>? keyPress = null,
            global::System.Action<global::tryAGI.OpenAI.Move?>? move = null,
            global::System.Action<global::tryAGI.OpenAI.Screenshot?>? screenshot = null,
            global::System.Action<global::tryAGI.OpenAI.Scroll?>? scroll = null,
            global::System.Action<global::tryAGI.OpenAI.Type?>? type = null,
            global::System.Action<global::tryAGI.OpenAI.Wait?>? wait = null,
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
            else if (IsKeyPress)
            {
                keyPress?.Invoke(KeyPress!);
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
            else if (IsType)
            {
                type?.Invoke(Type!);
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
                typeof(global::tryAGI.OpenAI.Click),
                DoubleClick,
                typeof(global::tryAGI.OpenAI.DoubleClick),
                Drag,
                typeof(global::tryAGI.OpenAI.Drag),
                KeyPress,
                typeof(global::tryAGI.OpenAI.KeyPress),
                Move,
                typeof(global::tryAGI.OpenAI.Move),
                Screenshot,
                typeof(global::tryAGI.OpenAI.Screenshot),
                Scroll,
                typeof(global::tryAGI.OpenAI.Scroll),
                Type,
                typeof(global::tryAGI.OpenAI.Type),
                Wait,
                typeof(global::tryAGI.OpenAI.Wait),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Click?>.Default.Equals(Click, other.Click) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DoubleClick?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Drag?>.Default.Equals(Drag, other.Drag) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.KeyPress?>.Default.Equals(KeyPress, other.KeyPress) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Move?>.Default.Equals(Move, other.Move) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Screenshot?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Scroll?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Type?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Wait?>.Default.Equals(Wait, other.Wait) 
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
