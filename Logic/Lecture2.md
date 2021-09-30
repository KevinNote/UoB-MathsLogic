# Lecture 2 - Symbolic Logic

## Grammars

BNF, aka [Backus–Naur form](https://en.wikipedia.org/wiki/Backus%E2%80%93Naur_form).

- Syntax
- Semantics 语义

### Formula

<center>
<strong>
    lhs ::= rhs<sub>1</sub> | ... | rhs<sub>1</sub>
</strong>
</center>

**Meaning:** this rule means that the left-hand-side `lhs` (a
[non-terminal symbol](https://en.wikipedia.org/wiki/Terminal_and_nonterminal_symbols)) can expand to **ANY** of the forms rhs<sub>1</sub> to rhs<sub>n</sub>
on the right-hand-side.

### Definition

| Name   | Meaning |
| ------ | ------- |
| Arity  | Number of arguments |
| Fixity | Where is the operator<br>prefix, infix & postfix |

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

**Example:** 0 + 1 + 2
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

**Example:** 0 + 1 + 2  
It is (0 + 1) + 2 or 0 + (1 + 2)?

We should define its associativity:

- left associativity: (0 + 1) + 2
- right associativity: 0 + (1 + 2)

### Precedence

Chinese: 优先级

**Example:** 0 + 1 × 2  
It is (0 + 1) × 2 or 0 + (1 × 2)?

We should define symbols' precedence:

- \+ has higher precedence: (0 + 1) + 2
- × has higher precedence: 0 + (1 × 2)

# Tip

To avoid ambiguities:
- define the associativity of symbols
- define the precedence between symbols
- use parentheses to avoid ambiguities or for clarity

Parentheses are sometimes necessary:
- using left associativity 0 + 1 + 2 stands for 0 + (1 + 2)
- we need parentheses to express 0 + (1 + 2)

## (Meta)variables

Aka schematic variables.

```
P → P
```

`P` acts as variable which can range ***ALL POSSIBLE*** exp/formulas.

Why is it called a “metavariable”?

A metavariable is a variable
within the language, called the **metatheory**, used to describe and study a theory at hand.

## Axiom Schemata

Chinese: 公理

## Substitution

Chinese: 代换


<center>
<strong>
k<sub>0</sub>\v<sub>0</sub>, . . . , k<sub>n</sub>\v<sub>n</sub>
</strong>
</center>

for the substitution that maps k<sub>i</sub> to v<sub>i</sub> for i ∈ {0, ..., n}.

**Operation:** `[val]`.

**Example:** `eq[s]`

takes an equality `eq` and a substitutions, and replaces all occurrences of the keys of `s` by the corresponding values in `eq`.

**Example:** (exp<sub>1</sub> + exp<sub>2</sub> = exp<sub>2</sub> + exp<sub>1</sub>)\[exp<sub>1</sub>\1] return?  
1 + exp<sub>2</sub> = exp<sub>2</sub> + 1
