

$\forall right$

$$
\cfrac{
    \Gamma \vdash P[x\backslash y]
}{
    \Gamma \vdash \forall x. P
} [\forall R]

$$

**Condition:** y 必须不能在 $\Gamma$ 或在 $\forall x.P$ 中自由。

$\forall left$

$$
\cfrac{
    \Gamma, P[x\backslash t] \vdash Q
}{
    \Gamma, \forall x. P \vdash Q
} [\forall L]

$$

**Condition:** fv(t) 不能与 bv(P) 冲突

$\exists right$

$$
\cfrac{
    \Gamma \vdash P[x\backslash t]
}{
    \Gamma \vdash \exists x. P
} [\exists R]

$$

**Condition:** fv(t) 不能与 bv(P) 冲突。

$\exists left$

$$
\cfrac{
    \Gamma, P[x\backslash y] \vdash Q
}{
    \Gamma, \exists x. P \vdash Q
} [\exists L]
$$

**Condition:** y 必须不能在 $\Gamma$, $Q$ 或者在 $\exists x.P$ 中自由