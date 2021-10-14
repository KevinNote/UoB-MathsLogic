# Propositional Logic - Sequent Calculus/命题逻辑 - 相继式演算

<center>
<span>15/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Definition

Use ***left/right*** rules instead of ***elimination/introduction*** rules.

Left is premises right is conclusion.

Use `Γ` and `∆` for lists of formulas separated by commas.


We will **eliminate** connectives from the **premises** (the **left**)
and **introduce** connectives from the **conclusion** (the **right**).

## Rules

### Basic

```
Natural Deduction                Sequent Calculus

A → B   A                        Γ ⊢ A   Γ, B ⊢ C
---------[→ E]                   ----------------- [→ L]
    B                              Γ, A → B ⊢ C

  --- 1
   A
  ...
   B                             Γ, A ⊢ B
-------- 1 [→ I]                ---------- [→ R]
 A → B                          Γ ⊢ A → B
```

```
Natural Deduction              Sequent Calculus

A    ¬A                        Γ, A ⊢ ⊥
------- [¬ E]                  --------- [¬ R]
   ⊥                            Γ ⊢ ¬A
```


```
Natural Deduction              Sequent Calculus

  A                              Γ ⊢ A
----- [∨ I_L]                  ---------- [∨ R_L]
A ∨ B                          Γ ⊢ A ∨ B

  A                              Γ ⊢ A
----- [∨ I_R]                  ---------- [∨ R_2]
B ∨ A                          Γ ⊢ B ∨ A

A ∨ B  A → C  B → C            Γ, A ⊢ C   Γ, B ⊢ C
--------------------- [∨ E]    -------------------- [∨ L]
         C                       Γ, A ∨ B ⊢ C
```

```
Natural Deduction             Sequent Calculus

A   B                         Γ ⊢ A  Γ ⊢ B
----- [∧ I]                   ------------ [∧ R]
A ∧ B                          Γ ⊢ A ∧ B

A ∧ B
----- [∧ E_R]
  B                           Γ, A, B ⊢ C
                             ------------- [∧ L]
A ∧ B [∧ E_L]                Γ, A ∧ B ⊢ C
-----
  A
```

### Identity and Structural Rules

#### Identity

```
----- [Id]
A ⊢ A
```

#### Exchange

```
Γ, B, A, ∆ ⊢ C
-------------- [X]
Γ, A, B, ∆ ⊢ C
```

#### Weakening

```
 Γ ⊢ B
-------- [W]
Γ, A ⊢ B
```

#### Contraction

```
Γ, A, A ⊢ B
----------- [C]
  Γ, A ⊢ B
```

#### Cut

```
Γ ⊢ B   Γ, B ⊢ A
----------------- [Cut]
     Γ ⊢ A
```
