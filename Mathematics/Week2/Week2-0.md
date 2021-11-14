# 数论基础：最大公约数与裴蜀等式

<center>
<span>08/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Fractions & Rational Numbers/分数与比例

Law of arithmetic (dist.) are only valid when fractions express the same **radio**.

Rational Numbers satisfy Ring laws + [a × a<sup>-1</sup> = 1 if a ≠ 0] (multiplicative inverse), so it is a **field**.

Multiplicative cancellation is valid in every field.

Fraction is be represented by $\mathbb{Q}$ (有理数数集).

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

**解释：** 存在数 $x$ 和 $y$，假定其公约数为 $g$  
则必然存在 $x=g\times k_0$ 以及 $y=g\times k_1$  
如果 $k_0=k_1$， 则 $x = y$，那么其本身就为最大公约数  
如果不是，可以假定 $x > y$  
我们可以获得两个更小间隙

$$
x = x - y = g × (k_0 - k_1) = g × k_2\\
y = g × k_1
$$

对于新生成的 $x, y$ 进行再次大数减小数，直到求出 $x = y$ 的时刻。

其逻辑使用了基础为：
$$
N_{\text{greater}}=N_{\text{less}}+N_{\text{r}}\\
N_{\text{r}}=N_{\text{LCF}}\times K_0\\
N_{\text{greater}}=N_{\text{LCF}}\times K_1\\
N_{\text{less}}=N_{\text{LCF}}\times K_2
$$

通过算式寻求为 $K_1=K_2$  的场景


### Euclidean Algorithm/辗转相除法

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

$$
N_{\text{greater}} = N_{\text{less}} + N_{\text{r}}
$$

但是如果 $N_{\text{greater}}$ 足够大，那我们可以存在以下关系式

$$
N_{\text{greater}}=K \times N_{\text{less}}+R, R \in [0, N_{\text{less}}), K \in \Z^+
$$

如果使用更相减损术，我们需要进行 $K$ 次相减。而如果使用取模运算，我们则可以一次性得出所需要的部分 $R$：

$$
N_{\text{greater}} \mod N_{\text{less}} = R
$$

### 理论基础

$$
a = qb + r\\
a, b, q, r \in Z
$$
所以 $\text{GCD}(a, b) = \text{GCD}(b, r)$

Pf. if $d \mid a$ and $d \mid b$, then $d \mid b$ and $d \mid r = (a - qb)$  
if $d \mid b$ and $d \mid r$, then $d \mid (qb + r), d \mid a$  
Then $a$, $b$ 的公因子集合与 $b$ 与 $r$ 的公因子集合相同，继而最大公因子相同

### Proof/证明

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

- 对于不全为 0 的整数 $a, b, d$，方程 $sa + tb = d$ 存在整数解 s **当且仅当** LCF(a, b)|d
- 方程 $sa + tb = d$ 称作裴蜀等式

In $\Z_m$, assume that m in a prime number

$$
a \neq 0 \text{ in } \Z_m \\
\text{lcf}(a, m) = 1 = u \times a + v \times m \equiv u \times a\\
a^{-1} = u
$$

If $m$ is prime, then every number in $\Z_m$, ≠ 0, has a multiplication inverse. Hence, $\Z_m$ is a field.

**Example:** $m = 2$

|  ×  |  0  |  1  |
| :-: | :-: | :-: |
|  0  |  0  |  0  |
|  1  |  0  |  1  |

$\Z_2$ aka GF(2), **"Galois Field"**.


**Example:** $m = 5$

|  ×  |  0  |  1  |  2  |  3  |  4  |
| :-: | :-: | :-: | :-: | :-: | :-: |
|  0  |  0  |  0  |  0  |  0  |  0  |
|  1  |  0  |**[1]**|  2  |  3  |  4  |
|  2  |  0  |  2  |  4  |**[1]**|  3  |
|  3  |  0  |  3  |**[1]**|  4  |  2  |
|  4  |  0  |  4  |  3  |  2  |**[1]**|

$1^{-1} = 1$  
$2^{-1} = 3$  
$3^{-1} = 2$  
$4^{-1} = 4$  

$\Z_5$ or GF(5) is a field.

**Example:** $m = 4$

|  ×  |  0  |  1  |  2  |  3  |
| :-: | :-: | :-: | :-: | :-: |
|  0  |  0  |  0  |  0  |  0  |
|  1  |  0  |**[1]**|  2  |  3  |
|  2  |  0  |  2  |  0  |  2  |
|  3  |  0  |  3  |  2  |**[1]**|

$1^{-1} = 1$  
**$2^{-1}$ does not exist**   
$3^{-1} = 3$

$\Z_4$ or GF(4) is **NOT** a field.



### Example/例子

GCD(210, 715)

```
             210  715 715=3*210+85
210=2*85+40  210  85
              40  85  85=2*40+5
   40=8*5+0   40  5
               0  5
GCD(715, 210) = 5
5 = 85 - 2 * 40
             ^^ = 85 - 2 * (210 - 2 * 85)
  = 5 * 85 - 2 * 210
        ^^      = 5 * (715 - 3 * 210) - 2 * 210
  = 5 * 715 - 17  * 210
        ^^^         ^^^
```
### Proof/证明

- 充分性
  - 通过回代法可知 $sa+tb = \text{GCD}(a, b)$存在整数解，设其为 $s_0, t_0$
  - 若 $d = k \times \text{GCD}(a, b)$，则其 $k \times s_0, k \times t_0$是方程的一个解
- 必要性
  - 若方程 $sa + tb = d$ 存在整数解 $s$ 和 $t$ 则 $\text{GCD}(a, b) \mid (sa+tb)=d$

### Extended Euclidean Algorithm/扩展欧几里得算法

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

## References/参考

- "欧几里得算法与婓蜀等式 - YouTube" - <https://www.youtube.com/watch?v=2A3a05gkI90>
