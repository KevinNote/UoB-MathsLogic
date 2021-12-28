# Propositional Logic/命题逻辑

<center>
<span>07/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Vocabulary/词汇表

| 单词         | 释意            |
| ----------- | -------------- |
| Argument    | 自变量          |
| Proposition | 命题            |
| Premise     | 前提            |
| Conclusion  | 结论            |
| iff         | if and only if |
| Hypotheses  | 假说            |

## Formalise Logical Statements/形式化逻辑表达式

Take a symbolic approach

Advantages:

- Unambiguous
- More concise

### Symbols/符号

- 原子命题（atomic proposition）  
  - $\top$ true
  - $\bot$ false
- 逻辑连接词（connectives）
  - conjunction/合取 $\wedge$: and
  - disjunction/析取 $\vee$: or
  - implication/蕴含 $\to$: implies/if ... then ...
  - negation   /否定 $\neg$: not
  - Arbitrary  /任意 $\forall$: for all objects, 对于所有对象

### Atomic Propositions/原子命题

$$
P ::= a \mid P \vee P \mid P \wedge P \mid P \to P \mid \neg P
$$

a ranges over atomic propositions

atomic propositions are formulas

没有子公式的公式

### Connectives/连接词

#### Disjunction/析取式

Aka "inclusive or"

**Note:** Or in English is often exclusive or

#### Precedence/优先级

Decreasing: $\neg, \wedge, \vee, \to$

#### Associativity/结合

Right associative
use parentheses for clarity

#### Scope/作用域

Connective itself + what it connects

Main connective: a formula
- the connective whose scope is the whole formula
- Parse tree's root node

### Sequent/相继式

$$
\Gamma\vdash\Sigma
$$

**Example:**

- $p\to q, \neg q \vdash \neg p$

$\vdash$, aka 十字转门/turnstile or T型符号/tee.

## Natural Deduction/自然演绎

### Formal Proof

- Formal Language
  - For representing propositions, arguments  
    (We use propositional logic)
  - Proof Theory

## Inference Rules/推理规则

### Types/种类

- introduction 用于定义符号
- elimination 用于消去符号

### Implication-Elimination

$$
\cfrac{A \qquad A \to B}{B}{[\to E]}
$$

### False-Elimination

$$
\cfrac{\bot}{A}{[\bot E]}
$$

### True-Introduction

$$
\cfrac{}{\top}{[\top I]}
$$

### Negation-Elimination

$$
\cfrac{A \qquad \neg A}{\bot}{[\to E]}
$$

**Attention:** $\neg A$ is defined as $\neg A = A \to \bot$ ,  so this elimination is just to demonstrate that
$$
\cfrac{A \qquad A \to \bot}{\bot}{[\to E]}
$$
It uses *Implication-Elimination*, so its name is **$\to E$**.

## Natural Deduction

### Discharging/Cancellation

#### Implication-Introduction

$$
\cfrac{\begin{matrix}\cfrac{}{A}1\\...\\B\\\end{matrix}}{A\to B}{1\ [\to I]}
$$

Tip: We don't have to make use of A in which case we can just omit it:
$$
\cfrac{B}{A \to B}{[\to I]}
$$

### Negation

#### Introduction


$$
\cfrac{\begin{matrix}\cfrac{}{A}1\\...\\\bot\\\end{matrix}}{A\to\bot}{1\ [\neg I]}
$$

#### Elimination

$$
\cfrac{A\qquad \neg A}{\bot}{[\neg E]}
$$

### Or

#### Introduction

Left:
$$
\cfrac{A}{A \vee B}{[\vee I_L]}
$$
Right:
$$
\cfrac{A}{B \vee A}{[\vee I_R]}
$$

#### Elimination

$$
\cfrac{A\vee B \qquad A\to C \qquad B \to C}{C}{[\vee E]}
$$

### And

#### Introduction


$$
\cfrac{A \qquad B}{A \wedge B}{[\wedge I]}
$$

#### Elimination

Left:
$$
\cfrac{A \wedge B}{A}{[\wedge E_L]}
$$
Right:

$$
\cfrac{A \wedge B}{B}{[\wedge E_R]}
$$
