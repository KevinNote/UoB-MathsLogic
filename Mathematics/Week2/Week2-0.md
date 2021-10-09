# 数论基础：最大公约数与裴蜀等式

<center>
<span>08/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Fractions & Rational Numbers/分数与比例

Law of arithmetic (dist.) are only valid when fractions express the same **radio**.

Rational Numbers satisfy Ring laws + [a × a<sup>-1</sup> = 1 if a ≠ 0] (multiplicative inverse), so it is a **field**.

Multiplicative cancellation is valid in every field.

## LCF/最大公约数

Aka Largest Common Factor (LCF), Greatest Common Factor (GCF), Greatest Common denominator (GCD), Highest Common Factor (HCF), Greatest Common Divisor (GCD)

```
LCF(a, b), b = 0, a ≠ 0
```

### 更相减损术

```csharp
public static int Lcf(int x, int y)
{
    while (true)
    {
        if (x > y)
            x -= y;
        else if (x < y)
            y -= x;
        else
            return x;
    }
}
```

**解释：** 存在数 x 和 y，假定其公约数为 g  
则必然存在 x = g × k<sub>0</sub> 以及 y = g × k<sub>1</sub>  
如果 k<sub>0</sub> = k<sub>1</sub>， 则 x = y，那么其本身就为最大公约数  
如果不是，可以假定 x > y  
我们可以获得两个更小间隙  
x = x - y = g × (k<sub>0</sub> - k<sub>1</sub>) = g × k<sub>2</sub>  
y = g × k<sub>1</sub>  
对于新生成的 x, y 进行再次大数减小数，直到求出 x = y 的时刻。

其逻辑使用了基础为：  
N<sub>greater</sub> = N<sub>less</sub> + N<sub>r</sub>  
N<sub>r</sub> = N<sub>LCF</sub> × K<sub>0</sub>  
N<sub>greater</sub> = N<sub>LCF</sub> × K<sub>1</sub>   
N<sub>less</sub> = N<sub>LCF</sub> × K<sub>2</sub>   
通过算式寻求为 K<sub>1</sub> = K<sub>2</sub> 的场景


### 辗转相除法/Euclidean Algorithm

Aka 欧几里得算法

```
lcf(a, b)
x <- a
y <- b
while (y != 0) {
    r <- x mod y
    x <- y
    y <- r
}
```

```csharp
public static int Lcf(int x, int y)
{
    while (y != 0)
    {
        int r = x % y;
        x = y;
        y = r;
    }
    return x;
}
```

**解释：** 辗转相除法本质上是对更相减损术的优化。通过更相减损术的基础逻辑，我们可以获得定义

N<sub>greater</sub> = N<sub>less</sub> + N<sub>r</sub>

但是如果 N<sub>greater</sub> 足够大，那我们可以存在以下关系式

N<sub>greater</sub> = K × N<sub>less</sub> + R, R ∈ [0, N<sub>less</sub>), K ∈ Z<sup>+</sup>

如果使用更相减损术，我们需要进行 K 次相减。而如果使用取模运算，我们则可以一次性得出所需要的部分 R：

N<sub>greater</sub> mod N<sub>less</sub> = R

### Proof

Loop invariant: lcf(a, b) = lcf (x, y)

Before start of the loop: Yes, because x contains a and y contains b. (Ground case)

Inductive Step: Assume lcf(a, b) = lcf(x, y)

If p is a factor of x and y, x = s × p, y = t × p

r = x - m × y = s × p - m × t × p = (s - m × t) × p

x <- y  
y <- r

QED.

## Bézout's Identity/裴蜀等式

aka 贝祖定理/Bézout's lemma

In Z<sub>m</sub>, assume that m in a prime number

a ≠ 0 in Z<sub>m</sub>

lcf(a, m) = 1 = u × a + v × m ≡ u × a

a<sup>-1</sup> = u

If `m` is prime, then every number in Z<sub>m</sub>, ≠ 0, has a multiplication inverse. Hence, Z<sub>m</sub> is a field.

**Example:** m = 2

|  ×  |  0  |  1  |
| :-: | :-: | :-: |
|  0  |  0  |  0  |
|  1  |  0  |  1  |

Z<sub>2</sub> aka GF(2), **"Galois Field"**.


**Example:** m = 5

|  ×  |  0  |  1  |  2  |  3  |  4  |
| :-: | :-: | :-: | :-: | :-: | :-: |
|  0  |  0  |  0  |  0  |  0  |  0  |
|  1  |  0  |**[1]**|  2  |  3  |  4  |
|  2  |  0  |  2  |  4  |**[1]**|  3  |
|  3  |  0  |  3  |**[1]**|  4  |  2  |
|  4  |  0  |  4  |  3  |  2  |**[1]**|

1<sup>-1</sup> = 1  
2<sup>-1</sup> = 3  
3<sup>-1</sup> = 2  
4<sup>-1</sup> = 4  

Z<sub>5</sub> or GF(5) is a field.

**Example:** m = 4

|  ×  |  0  |  1  |  2  |  3  |
| :-: | :-: | :-: | :-: | :-: |
|  0  |  0  |  0  |  0  |  0  |
|  1  |  0  |**[1]**|  2  |  3  |
|  2  |  0  |  2  |  0  |  2  |
|  3  |  0  |  3  |  2  |**[1]**|

1<sup>-1</sup> = 1  
**2<sup>-1</sup> does not exist**   
3<sup>-1</sup> = 3  

Z<sub>4</sub> or GF(4) is **NOT** a field.


### Extended Euclidean algorithm/扩展欧几里得算法

```
x <- a
y <- b

u_x <- 1
v_x <- 0

u_y <- 0
v_y <- 1

while (y != 0) {
    r <- x mod y
    k <- x div y

    u <- u_x
    v <- v_x

    u_x <- u_y
    v_x <- v_y

    u_y <- u - k * u_y
    v_y <- v - k * v_y

    x <- y
    y <- r
}
return x, u_x, v_x
```

```csharp
public static (int x, int u, int v) GetBezoutIdentity(int x, int y)
{
    int u_x = 1,
        v_x = 0;
    
    int u_y = 0,
        v_y = 1;

    while (y != 0)
    {
        int r = x % y;
        int k = x / y;

        int u = u_x;
        int v = v_x;

        u_x = u_y;
        v_x = v_y;

        u_y = u - k * u_y;
        v_y = v - k * v_y;

        x = y;
        y = r;
    }
    return (x, u_x, v_x);
}
```
