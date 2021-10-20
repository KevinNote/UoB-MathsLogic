# 布尔代数基础：集合与布尔代数

<center>
<span>20/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Basic

### Subset/子集

```
{1, 2, 4, 2048} ⊆ N
                ^ is a subset/part of
```

{} ⊆ A ∅

{} and ∅ are both empty set.

B = {x ∈ A | x satisfies c}

B ⊆ A iff ∀x. x ∈ B ⇒ x ∈ A

A = B iff ∀x. x ∈ B ⇔ x ∈ A
      iff A ⊆ B and B ⊆ A

### Intersection/交集

B<sub>1</sub>, B<sub>2</sub> ⊆ A

B<sub>1</sub>, B<sub>2</sub> = {x ∈ A | x ∈ B<sub>1</sub> and x ∈ B<sub>2</sub>}

B ∩ ∅ = ∅
B ∩ A = B
B<sub>1</sub> ∩ B<sub>2</sub> = B<sub>2</sub> ∩ B<sub>1</sub>  
B<sub>1</sub> ∩ (B<sub>2</sub> ∩ B<sub>3</sub>) = (B<sub>1</sub> ∩ B<sub>2</sub>) ∩ B<sub>3</sub>


### Complement/补集

```
B ⊆ A
_
B = {x ∈ A|x ∉ B}
```
### Set Difference

B<sub>1</sub>, B<sub>2</sub> ⊆ A  
B<sub>1</sub> \ B<sub>2</sub> = {x ∈ A | x ∈ B<sub>1</sub> and x ∉ B<sub>2</sub>}  
B \ ∅ = B  
B \ A = ∅  
B<sub>1</sub> \ B<sub>2</sub> = B<sub>1</sub> \ (B<sub>2</sub> ∩ B<sub>2</sub>)


## Powerset/幂集

原集合中所有的子集（包括全集和空集）构成的集族

P{a, b, c} = {∅, {a}, {b}, {c}, {a, b}, {a, c}, {b, c}, {a, b, c}}

**Theorem:** The carinality of PA is strictly larger than the card. of A.

|N| < |R| < |PR|

## Propositional logic and Boolean algebras

### Distributivity Laws

A ∩ (B ∪ C) = (A ∩ B) ∪ (A ∩ C)  
A ∪ (B ∩ C) = (A ∪ B) ∩ (A ∪ C)

### de Morgan law

```
______    _    _
A ∪ B  = A ∩ B
______    _    _
A ∩ B  = A ∪ B
```

### Symbols

| Set | Boolean Algebra |
| :-: | :-------------: |
|  ∪  |       ∨         |
|  ∩  |       ∧         |
|  _  |       ¬         |
|  ∅  | false, ff, ⊥    |
|  X  | true, tt, T     |

false ∨ true = true (by Anihalation)

| ∨ | F | T |
| - | - | - |
| F | F | T |
| T | T | T |

| ∧ | F | T |
| - | - | - |
| F | F | F |
| T | F | T |

¬ False = ¬ false ∨ true (neutral element)
= true (complement)

| ¬ | F | T |
| - | - | - |
|   | T | F |

### Maths in CPU

C means carry (进位).

![](img/math-in-cpu.png)