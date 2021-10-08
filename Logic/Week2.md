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

## Formalise 逻辑表达式

Take a symbolic approach

Advantages:

- Unambiguous
- More concise

### 符号/Symbols

- 原子命题（atomic proposition）  
  - ⊤ true
  - ⊥ false
- 逻辑连接词（connectives）
  - conjunction/合取 ∧: and
  - disjunction/析取 ∨: or
  - implication/蕴含 →: implies/if ... then ...
  - negation   /否定 ¬: not

### 原子命题/Atomic propositions

P ::= a | P ∨ P | P ∧ P | P → P | ¬P

a ranges over atomic propositions

atomic propositions are formulas

没有子公式的公式

### 连接词/Connectives

#### 析取式/Disjunction

Aka "inclusive or"

**Note:** Or in English is often exclusive or

#### 优先级/Precedence

Decreasing: ¬, ∧, ∨, →

#### 结合/Associativity

Right associative
use parentheses for clarity

#### 作用域/Scope

Connective itself + what it connects

Main connective: a formula
- the connective whose scope is the whole formula
- Parse tree's root node

### 相继式/Sequent

<center><strong>
Γ ⊢ Σ
</strong></center>

**Example:**

- p → q, ¬q ⊢ ¬p

⊢, aka 十字转门/turnstile or T型符号/tee.

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

```
A    A → B
---------- [→E]
    B
```

### False-Elimination

```
 ⊥
--- [⊥E]
 A
```

### True-Introduction

```
--- [⊤I]
 ⊤
```

### Negation-Elimination

```
A  ¬A 
----- [→E]
  ⊥
```

**Attention:** ¬A is defined as ¬A = A → ⊥,  so this elimination is just to demonstrate that

```
A  A → ⊥
-------- [→E]
  ⊥
```

It uses *Implication-Elimination*, so its name is **→E**.

## Natural Deduction

### Discharging/Cancellation

#### Implication-Introduction

```
 --- 1
  A
 ...
  B
----- 1 [→I]
A → B
```

Tip: We don't have to make use of A in which case we can just omit it:

```
  B
-----
A → B
```

### Negation

#### Introduction

```
 --- 1
  A
 ...
  ⊥
----- 1 [¬I]
A → ⊥
```

#### Elimination

```
A    ¬A
------- [¬E]
   ⊥
```

### Or

#### Introduction

Left:

```
  A
----- [∨I_L]
A ∨ B
```

Right:

```
  A
----- [∨I_R]
B ∨ A
```

#### Elimination

```
A ∨ B   A → C   B → C
--------------------- [∨E]
          C
```

### And

#### Introduction

```
A   B
----- [∧I]
A ∧ B
```

#### Elimination

Left:

```
A ∧ B
----- [∧E_L]
  A
```

Right:

```
A ∧ B
----- [∧E_R]
  B
```