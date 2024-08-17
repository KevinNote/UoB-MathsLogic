# 证明论基础：归纳

<center>
<span>15/11/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Inductive Definition/归纳定义

$$
X = \left\{a \in A \mid a \text{ satisfies condition } c\right\}
$$

$$
\Sigma^* \text{ set of strings over } \Sigma
$$

"[]", "[[]]", "[][]", Good (Well-balanced) （成对）  
"]", "[[]", "[]]", Bad(Not well-balanced)（不成对）

那我们如何定义 wbb(well balanced bracket) 呢？

$$
wbb \subseteq \Sigma^*\qquad \Sigma = \left\{ ^"[^", ^"]^"\right\}
$$

An inductive definition of wbb:
- Rule 1: $^"[]^" \in wbb$ (Base Case)
- Rule 2: If $s\in wbb$ then $"[s]" \in wbb$ (Inductive Case 1)
- Rule 3: If $s, t \in wbb$ then $st \in wbb$ (Inductive Case 2)

## Grammars/语法

$$
wbb ::= [] \mid [wbb] \mid wbb\ wbb
$$

by selection: $\left\{ x \in \N \mid 2^{2^x}+1 \text{ is prime}\right\}$

by inductive definition:
- $17 \in \mathcal{I}$
- $20 \in \mathcal{I}$
- If $x, y \in \mathcal{I}$ then $x - y \in \mathcal{I}$

简单来说，by selection是规范了一个集合，而定义，是指定一个集合内的构造。而by inductive definition则是定义基础条件，以及迭代条件，通过基础条件迭代实现向后证明。

wbb 我们假定一个 wbb 的字符串，将其截成两半，我们可以发现，前侧的字符串 $s'$ 的 $\#_{[}(s') \geq \#_{]}(s')$。

对于其证明，我们可以：  
Proof.  
**Base case:**  

$$
[] \in wbb \qquad 
\begin{matrix}s'=\varepsilon\qquad 0\geq 0\\
s'=[\qquad 1 \geq 0\\
s'=[] \qquad 1 \geq 1\\
\end{matrix}
$$

**Inductive Case 1:** 
$$
s \in wbb
$$

**Assume** statement holds for $s$.  
**Want:** that it holds also $[s]$.

| Case | Result |
| --------- | ------ |
| $s'=\varepsilon$ | $0\geq 0$ |
| $s'=[$  | $1 \geq 0$ |
| $s'=[\overline{s}$ | See Sub Proof #1 |
| $s'=[s]$  | - |

Sub Proof #1:
1. $\#_[(\overline{s}) \geq \#_](\overline{s})$ by assume
2. Then $\#_[(s')=\#_[([\overline{s})=\#_[(\overline{s}) + 1\geq \#_](\overline{s})+1= \#_]([\overline{s}) + 1 =\#_](s') + 1>\#_](s')$

**Inductive Case 2:**  
$$
s, t \in wbb
$$

**Assume** the statement holds for $s$ and it holds for $t$.  
**Want:** Statement holds for $st$.


| Case | Result |
| --------- | ------ |
| $s'=\overline{s}$ | $\#_[(\overline{s}\geq \#_](\overline{s})$ by assumption |
| $s'=s\overline{t}$ | $\#_[(\overline{t}\geq \#_](\overline{t})$ by assumption</br> $\#_[(\overline{s}\geq \#_](\overline{s})$ by assumption |

$\#_[{(s\overline{t})}=\#_[{(s)}+\#_[{(\overline{t})} \geq  \#_](\overline{t}) + \#_](\overline{s}) = \#_](s\overline{t})$

## Defining Function/定义函数

define a function: 
$\text{lon}: wbb \to \N$ means "level of nesting"

$\text{lon}([]) = 1$  
$\text{lon}([][]) = 1$  
$\text{lon}([[][]]) = 2$

**Bae case:** $\text{lon}([]) = 1$  
**Inductive Case 1:** If $\text{lon}(s) = n$ then $\text{lon}([s]) = n + 1$  
**Inductive Case 2:** If $\text{lon}(s) = n$ and $\text{lon}(t) = m$ then $\text{lon}(st) = \max{(n, m)}$

### In Haskell

Code Generation:  

```c
if (condition)
    block1
else
    block2
```

```
    +----------+
    |  S_cond  |
    +----------+
    B_IF_FALSE  GOTO label 25
    +----------+
    | S_block1 |
    +----------+
    BRANCH      GOTO label 26
25: +----------+
    | S_block1 |
    +----------+
26: +----------+
    |          |
    +----------+
```

对于表达式优先级

- Maybe need a better grammar (BODMAS法则)
- May adopt a convention ("left most evaluation")

