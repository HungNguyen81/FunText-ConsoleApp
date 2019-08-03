using System;
using System.Threading;
#region Base
public class Base
{
    public Base(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public virtual void Draw()
    { }
    private int x, y;
    public static int time = 100;
}
#endregion
#region A
public class A : Base
{
    public A(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        int i = 0;
        for (i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + i, y - i);
            Console.Write("00");
            Thread.Sleep(time);
        }
        for (; i < 13; i++)
        {
            Console.SetCursorPosition(x + i, y - 6 + i - 6);
            Console.Write("00");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 4, y - 2);
        for (int k = 0; k < 6; k++)
        {
            Console.Write("0");
            Thread.Sleep(time);
        }
    }
    private int x, y;

}
#endregion 
#region B
public class B : Base
{
    public B(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000");
            Thread.Sleep(time);
        }

        Console.SetCursorPosition(x + 3, y);
        Console.Write("0000000000");
        Thread.Sleep(time);
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 11, y - 1 - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y - 3);
        Console.Write("0000000000");
        Thread.Sleep(time);
        Console.SetCursorPosition(x + 9, y - 4);
        Console.Write("00");
        Thread.Sleep(time);
        Console.SetCursorPosition(x + 9, y - 5);
        Console.Write("000");
        Thread.Sleep(time);
        Console.SetCursorPosition(x + 3, y - 6);
        Console.Write("00000000");
        Thread.Sleep(time);
    }
    private int x, y;
    //00000000000
    //000      000
    //000      00
    //0000000000000
    //000        000
    //000        000
    //0000000000000
}
#endregion
#region C
public class C : Base
{
    public C(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y - 6);
            Console.Write("0");
            Console.SetCursorPosition(x + 13 - i, y - 5);
            Console.Write("0");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 3, y - i);
            Console.Write("00000000000");
            Thread.Sleep(time);
        }
    }

    private int x, y;
    //00000000000000
    //00000000000000
    //000
    //000
    //000
    //00000000000000
    //00000000000000
}
#endregion
#region D
public class D : Base
{
    public D(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y - 6);
        Console.Write("0000000");
        Thread.Sleep(time);
        Console.SetCursorPosition(x + 9, y - 5);
        Console.Write("000");
        Thread.Sleep(time);
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x + 11, y - 4 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 9, y - 1);
        Console.Write("000");
        Thread.Sleep(time);
        Console.SetCursorPosition(x + 3, y);
        Console.Write("0000000");
        Thread.Sleep(time);
    }
    private int x, y;
    //0000000000
    //000      000
    //000        000
    //000        000
    //000        000
    //000      000
    //0000000009
}
#endregion
#region E
public class E : Base
{
    public E(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time - 50);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 4; i += 3)
        {
            Console.SetCursorPosition(x + 3, y - i);
            Console.Write("00000000000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //00000000000000
    //000
    //000
    //00000000000000
    //000
    //000
    //00000000000000
}
#endregion
#region F
public class F : Base
{
    public F(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time/2);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y - 3);
        Console.Write("00000000");
        Thread.Sleep(time);
    }
    private int x, y;
}
#endregion
#region G
public class G : Base
{
    public G(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y - 6);
            Console.Write("0");
            Console.SetCursorPosition(x + 13 - i, y - 5);
            Console.Write("0");
            Thread.Sleep(time/2);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 3, y - i);
            Console.Write("00000000000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 11, y - 2);
        Console.Write("000");
        Thread.Sleep(time);
        Console.SetCursorPosition(x + 10, y - 3);
        Console.Write("0000");
        Thread.Sleep(time);
    }
    private int x, y;
}
#endregion    
#region H
public class H : Base
{
    public H(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000        000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 3, y - 2 - i);
            Console.Write("00000000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
}
#endregion
#region I
public class I : Base
{
    public I(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + 2, y - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
}
#endregion
#region J
public class J : Base
{
    public J(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        Console.SetCursorPosition(x + 4, y - 6);
        Console.Write("00000");
        Thread.Sleep(time);
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 5, y - 5 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y);
        Console.Write("0000");
        Thread.Sleep(time);
    }
    private int x, y;
    //    00000
    //     000
    //     000
    //     000
    //     000
    //     000
    //   0000
}
#endregion
#region K
public class K : Base
{
    public K(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(x + 10 - i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x + 8 + i, y - 2 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y - 3);
        for (int i = 0; i < 4; i++)
        {
            Console.Write("0");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000       000
    //000      000
    //000     000
    //0000000000
    //000     000
    //000      000
    //000       000

}
#endregion
#region L
public class L : Base
{
    public L(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + 3 + i, y);
            Console.Write("0");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000
    //000
    //000
    //000
    //000
    //000
    //0000000000
}
#endregion
#region M
public class M : Base
{
    public M(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 1 + i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 6, y - 1);
        Console.Write("00");
        Thread.Sleep(time);
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 6 + i, y - 2 - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + 11, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //0000      0000
    //00000    00000
    //000000  000000
    //000 000000 000
    //000  0000  000
    //000   00   000
    //000        000
}
#endregion
#region N
public class N : Base
{
    public N(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000        000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + 1 + i, y - 6 + i);
            Console.Write("0000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
}
#endregion
#region O
public class O : Base
{
    public O(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 12; i++)
        {
            Console.SetCursorPosition(x + 12 - i, y - 6);
            Console.Write("0");
            Console.SetCursorPosition(x + 12 - i, y - 5);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x, y - 5 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 2, y - i);
            Console.Write("00000000000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 11, y - 1 - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
}
#endregion
#region P
public class P : Base
{
    public P(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 9; i++)
        {
            Console.SetCursorPosition(x + 11 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time/2);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y - 3);
        Console.Write("000000000");
        Thread.Sleep(time);
        for( int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 11, y - 4 - i);
            Console.Write("00");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000000000000
    //000        00
    //000        00
    //000000000000
    //000
    //000
    //000
}
#endregion
#region Q
public class Q : Base
{
    public Q(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 9; i++)
        {
            Console.SetCursorPosition(x + 9 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for(int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x, y - 5 + i);
            Console.Write("00");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(x + 2 + i, y);
            Console.Write("0");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(x + 9, y - 2 - i);
            Console.Write("00");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(x + 6 + i, y - 3 + i);
            Console.Write("0");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    // 000000000
    //00       00
    //00       00
    //00    0  00
    //00     0 00
    //00      0
    //  0000   0
}
#endregion
#region R
public class R : Base
{
    public R(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 8; i++)
        {
            Console.SetCursorPosition(x + 10 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 3, y - 3);
        Console.Write("00000000");
        Thread.Sleep(time);
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 10, y - 4 - i);
            Console.Write("00");
            Thread.Sleep(time);
        }
        for(int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x + 8 + i, y - 2 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //00000000000
    //000       00
    //000       00
    //00000000000
    //000     000
    //000      000
    //000       000
}
#endregion
#region S
public class S : Base
{
    public S(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for ( int i = 0; i < 12; i++)
        {
            Console.SetCursorPosition(x + 12 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for (int i =0; i< 2; i++)
        {
            Console.SetCursorPosition(x, y - 5 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 12; i++)
        {
            Console.SetCursorPosition(x + 1 + i, y - 3);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 11, y - 2 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 12; i++)
        {
            Console.SetCursorPosition(x + 12 - i, y);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
    }
    private int x, y;
    // 000000000000
    //000         
    //000
    // 000000000000
    //           000
    //           000
    // 000000000000
}
#endregion
#region T
public class T : Base
{
    public T(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for(int i = 0; i < 14; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y - 6);
            Console.Write("0");
            Console.SetCursorPosition(x + 13 - i, y - 5);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 5, y - 4 + i);
            Console.Write("0000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //00000000000000
    //00000000000000
    //     0000
    //     0000
    //     0000
    //     0000
    //     0000
}
#endregion
#region U
public class U : Base
{
    public U(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x, y - i);
            Console.Write("000        000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.SetCursorPosition(x + 3, y - i);
            Console.Write("00000000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
}
#endregion
#region V
public class V : Base
{
    public V(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for(int i = 0; i < 6; i++)
        {
            Console.SetCursorPosition(x + i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 6, y);
        Console.Write("00");
        Thread.Sleep(time);
        for (int i = 0; i < 6; i++)
        {
            Console.SetCursorPosition(x + 6 + i, y - 1 - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000        000
    // 000      000
    //  000    000
    //   000  000
    //    000000
    //     0000
    //      00
}
#endregion
#region W
public class W : Base
{
    public W(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.SetCursorPosition(x + i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 6, y);
        Console.Write("00");
        Thread.Sleep(time);
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 6 + i, y - 1 - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 11, y - 6);
        Console.Write("00");
        Thread.Sleep(time);

        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 11 + i, y - 5 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        Console.SetCursorPosition(x + 16, y);
        Console.Write("00");
        Thread.Sleep(time);
        for (int i = 0; i < 6; i++)
        {
            Console.SetCursorPosition(x + 16 + i, y - 1 - i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000        00        000
    // 000      0000      000
    //  000    000000    000     24x7
    //   000  000  000  000
    //    000000    000000
    //     0000      0000
    //      00        00
}
#endregion
#region X
public class X : Base
{
    public X(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + 2*i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(x + 12 - 2*i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000         000
    //  000     000
    //    000 000       
    //      000     
    //    000 000   
    //  000     000 
    //000         000
}
#endregion
#region Y
public class Y : Base
{
    public Y(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x + 2*i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(x + 12 - 2*i, y - 6 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(x + 6, y - 3 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
    }
    private int x, y;
    //000         000
    //  000     000
    //    000 000       
    //      000     
    //      000
    //      000
    //      000
}
#endregion
#region Z
public class Z : Base
{
    public Z(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        for (int i = 0; i < 13; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y - 6);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(x + 1 + 2*i,y - 5 + i);
            Console.Write("000");
            Thread.Sleep(time);
        }
        for (int i = 0; i < 13; i++)
        {
            Console.SetCursorPosition(x + 13 - i, y);
            Console.Write("0");
            Thread.Sleep(time / 2);
        }
    }
    private int x, y;
    // 00000000000000
    //  000     
    //    000      
    //      000     
    //        000   
    //          000 
    //00000000000000
}
#endregion
#region Space
public class Space : Base
{
    public Space(int x, int y) : base(x, y)
    {
        this.x = x;
        this.y = y;
    }
    public override void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(" ");
        Thread.Sleep(time);
    }
    private int x, y;
}
#endregion

#region Main
public static class mainClass
{
    static void Main()
    {
    label:
        Console.ResetColor();
        Console.Clear();
        Base.time = 50;
        int loop = 0;
        while (loop < 30) //tạo màu nền cho cửa sổ console
        {
            for (int i = 0; i < 120; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;//cyan
                Console.Write(" ");
            }
            Console.Write("\n");
           // Thread.Sleep(50);
            loop++;
        }
        string str = "khoi tao chuoi";
        while (str.Length > 12)  //chuoi dai nhat co the de ko bi tran man hinh
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(11, 11);
            Console.Write("Your Word: \t");
            str = Console.ReadLine();
            Console.Clear();
        }
        int k = 0;
        int startPoint_x = 3;
        int startPoint_y = 18;
        int length = str.Length;

        Base[] Arr = new Base[length];
        #region DuyetChuoiKyTu
        foreach (char chr in str)
        {

            if (chr == 'a'||chr == 'A')
            {
                Arr[k] = new A(startPoint_x, startPoint_y);
            }
            else if (chr == 'b'|| chr == 'B')
            {
                Arr[k] = new B(startPoint_x, startPoint_y);
            }
            else if (chr == 'c' || chr == 'C')
            {
                Arr[k] = new C(startPoint_x, startPoint_y);
            }
            else if (chr == 'd' || chr == 'D')
            {
                Arr[k] = new D(startPoint_x, startPoint_y);
            }
            else if (chr == 'e'||chr == 'E')
            {
                Arr[k] = new E(startPoint_x, startPoint_y);
            }
            else if (chr == 'f'||chr == 'F')
            {
                Arr[k] = new F(startPoint_x, startPoint_y);
            }
            else if (chr == 'g'|| chr == 'G')
            {
                Arr[k] = new G(startPoint_x, startPoint_y);
            }
            else if (chr == 'h'|| chr == 'H')
            {
                Arr[k] = new H(startPoint_x, startPoint_y);
            }
            else if (chr == 'i'|| chr == 'I')
            {
                Arr[k] = new I(startPoint_x, startPoint_y);
            }
            else if (chr == 'j'|| chr == 'J')
            {
                Arr[k] = new J(startPoint_x, startPoint_y);
            }
            else if (chr == 'k'||chr == 'K')
            {
                Arr[k] = new K(startPoint_x, startPoint_y);
            }
            else if (chr == 'l'||chr == 'L')
            {
                Arr[k] = new L(startPoint_x, startPoint_y);
            }
            else if (chr == 'm'|| chr == 'M')
            {
                Arr[k] = new M(startPoint_x, startPoint_y);
            }
            else if (chr == 'n'||chr == 'N')
            {
                Arr[k] = new N(startPoint_x, startPoint_y);
            }
            else if (chr == 'o'||chr == 'O')
            {
                Arr[k] = new O(startPoint_x, startPoint_y);
            }
            else if (chr == 'p'||chr == 'P')
            {
                Arr[k] = new P(startPoint_x, startPoint_y);
            }
            else if (chr == 'q'||chr == 'Q')
            {
                Arr[k] = new Q(startPoint_x, startPoint_y);
            }
            else if (chr == 'r'||chr == 'R')
            {
                Arr[k] = new R(startPoint_x, startPoint_y);
            }
            else if (chr == 's'||chr == 'S')
            {
                Arr[k] = new S(startPoint_x, startPoint_y);
            }
            else if (chr == 't'||chr == 'T')
            {
                Arr[k] = new T(startPoint_x, startPoint_y);
            }
            else if (chr == 'u'||chr == 'U')
            {
                Arr[k] = new U(startPoint_x, startPoint_y);
            }
            else if (chr == 'v'||chr == 'V')
            {
                Arr[k] = new V(startPoint_x, startPoint_y);
            }
            else if (chr == 'w'||chr =='W')
            {
                Arr[k] = new W(startPoint_x, startPoint_y);
            }
            else if (chr == 'x'||chr == 'X')
            {
                Arr[k] = new X(startPoint_x, startPoint_y);
            }
            else if (chr == 'y'||chr == 'Y')
            {
                Arr[k] = new Y(startPoint_x, startPoint_y);
            }
            else if (chr == 'z'||chr =='Z')
            {
                Arr[k] = new Z(startPoint_x, startPoint_y);
            }
            if (chr == ' ')
            {
                Arr[k] = new Space(startPoint_x, startPoint_y);
                startPoint_x += 8;
            }
            else if (chr == 'w' || chr == 'W')
            {
                startPoint_x += 26;
            }
            else if (chr == 'i' || chr == 'I') 
            {
                startPoint_x += 9;
            }
            else if (chr == 'l' || chr == 'L')
            {
                startPoint_x += 12;
            }
            else
            {
                startPoint_x += 16;
            }
            k++;
        }
        #endregion
        for (int i = 0; i < length; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Arr[i].Draw();
            Thread.Sleep(Base.time);
        }
        Console.SetCursorPosition(startPoint_x, startPoint_y);
        Console.ReadKey();
        goto label;
    }
}
#endregion


