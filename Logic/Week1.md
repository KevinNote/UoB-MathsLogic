# Symbolic Logic/符号逻辑学

<center>
<span>30/09/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Grammars/语法

BNF, aka [Backus–Naur form](https://en.wikipedia.org/wiki/Backus%E2%80%93Naur_form).

- Syntax
- Semantics 语义

### Formula/公式

$$
lhs::=rhs_1 | ... | rhs_n
$$

**Meaning:** this rule means that the left-hand-side `lhs` (a [non-terminal symbol](https://en.wikipedia.org/wiki/Terminal_and_nonterminal_symbols)) can expand to **ANY** of the forms rhs<sub>1</sub> to rhs<sub>n</sub>
on the right-hand-side. "$::=$" means "equal by definition"/"定义相等". Can simply write "=" instead.

### Definition/定义

| Name    | Meaning |
| ------- | ------- |
| Arity （元数、数量）  | Number of arguments |
| Fixity （固定性） | Where is the operator<br>prefix, infix & postfix |

**Example:**

- / 1 2
  - Arity: 2 (1, 2)
  - Fixity: Prefix
- 1 + 2
  - Arity: 2 (1, 2)
  - Fixity: Infix
- 1 2 *
  - Arity: 2 (1, 2)
  - Fixity: Postfix

### IfElseThen Statement

#### Syntax

<center>
<strong>
    if boolean then exp else exp
</strong>
</center>

#### AST

```
    if then else
     /    |   \
boolean  exp  exp
```

## AST

AST, aka Abstract Syntax Trees.

**Example:** $0 + 1 + 2$

```
    +
   / \
  +   2
 / \
0   1
```

## Associativity

Chinese: 结合

To be simple, it is the basic rule of direction of process: from left to right or right to left.

### Ambiguity

Chinese: 歧义

**Example:** $0+1+2$  
It is $(0 + 1) + 2$ or $0 + (1 + 2)$?

We should define its associativity:

- left associativity: $(0 + 1) + 2$
- right associativity: $0 + (1 + 2)$

### Precedence

Chinese: 优先级

**Example:** $0 + 1 \times 2$  
It is $(0 + 1) \times 2$ or $0 \times (1 × 2)$?

We should define symbols' precedence:

- $+$ has higher precedence: $(0 + 1) + 2$
- $\times$ has higher precedence: $0 + (1 \times 2)$

## Tip

To avoid ambiguities:
- define the associativity of symbols
- define the precedence between symbols
- use parentheses to avoid ambiguities or for clarity

Parentheses are sometimes necessary:
- using left associativity $0 + 1 + 2$ stands for $0 + (1 + 2)$
- we need parentheses to express $0 + (1 + 2)$

## (Meta)variables

Aka schematic variables.

$$
P \rightarrow P
$$
$P$ acts as variable which can range ***ALL POSSIBLE*** exp/formulas.

Why is it called a “metavariable”?

A metavariable is a variable
within the language, called the **metatheory**, used to describe and study a theory at hand.

## Axiom Schemata

Explanation: An axiom schema is a formula in the metalanguage of an axiomatic system, in which one or more schematic variables appear.  
Chinese: 公理模式：公理模式是个在公理系统的语言中的一个合式公式，其中有一个以上的模式变数出现。

## Substitution

Chinese: 代换

$$
k_0\backslash{v_0}, ..., k_n\backslash{v_n}
$$

for the substitution that maps $k_i$ to $v_i$ for $i \in {0, ..., n}$.

**Operation:** `[val]`.

**Example:** `eq[s]`

takes an equality `eq` and a substitutions, and replaces all occurrences of the keys of `s` by the corresponding values in `eq`.

**Example:** $exp_1+exp_2=exp_2+exp_1[exp_1\backslash1]$ return?  

$1+exp_2=exp_2+1$
