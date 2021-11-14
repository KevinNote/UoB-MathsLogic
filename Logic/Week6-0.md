# Propositional Logic - Equivalences & Normal Forms/命题逻辑 - 等价与范式

<center>
<span>14/11/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Logical Equivalence/逻辑等价

$$
A \leftrightarrow B  \stackrel{\text{def}}{=} (A \to B) \wedge (B \to A)
$$

- $A$ and $B$ have the same semantics
- $\phi(A)=T$ if and only if $\phi(B)=T$
- $A$ is provable if and only if $B$ is provable
- this is called a "bi-implication"
- read as "$A$ if and only if $B$"

### Examples

- De Morgan's Law (I): $\neg (A \vee B) \leftrightarrow (\neg A \wedge \neg B)$
- De Morgan's Law (II): $\neg (A \wedge B) \leftrightarrow (\neg A \vee \neg B)$
- Implication Elimination: $(A \to B) \leftrightarrow (\neg A \vee B)$ 

## Normal Forms/范式

### Definitions

- Literal, 文字：是原子公式（atom）以及其否定（$\neg A$）
- Clause, 子句

### Conjunctive Normal Forms/CNF/合取范式

- $(A \vee B \vee C)\wedge (D \vee X) \wedge (\neg A)$
- 子句是文字的析取（$\vee$）
- 每个子句由合取（$\wedge$）连接

### Disjunctive Normal Forms/DNF/析取范式

- $(A \wedge B \wedge C)\vee (D \wedge X) \vee (\neg A)$
- 子句是文字的合取（$\wedge$）
- 每个子句由析取（$\vee$）连接

需要注意的是一个子句可以被认定为CNF与DNF。例如 $A \vee B$ 可以认为是 CNF 亦或者 DNF。

### Express in DNF/CNF

#### DNF

**Theorem:** Every proposition can be expressed in DNF

**Example:** express $(P \to Q) \wedge Q$ in **DNF**

| $P$ | $Q$ | $(P \to Q)$ | $(P \to Q)\wedge Q$ |
| :-: | :-: | :-: | :-: |
| $T$ | $T$ | $T$ | $T$ |
| $T$ | $F$ | $F$ | $F$ |
| $F$ | $T$ | $T$ | $T$ |
| $F$ | $F$ | $T$ | $F$ |

1. Find all $T$ in result
   - Row 1 is $P\wedge Q$
   - Row 3 is $\neg P \wedge Q$
2. Use OR ($\vee$) to connect
3. Final is $(P \wedge Q) \vee (\neg P \wedge Q)$

#### CNF

**Theorem:** Every proposition can be expressed in CNF

**Example:** express $(P \to Q) \wedge Q$ in **CNF**

| $P$ | $Q$ | $(P \to Q)$ | $(P \to Q)\wedge Q$ |
| :-: | :-: | :-: | :-: |
| $T$ | $T$ | $T$ | $T$ |
| $T$ | $F$ | $F$ | $F$ |
| $F$ | $T$ | $T$ | $T$ |
| $F$ | $F$ | $T$ | $F$ |

1. Find all $F$ in result
   - Row 2 is $P\wedge \neg Q$
   - Row 4 is $\neg P \wedge \neg Q$
2. Use AND ($\wedge$) to connect their **negations**
3. We get $\neg (P\wedge \neg Q) \wedge \neg (\neg P \wedge \neg Q)$
4. Final is $(\neg P \vee Q) \wedge (P \wedge Q)$

