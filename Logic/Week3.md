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

| Natural Deduction                                            | Sequent Calculus                                             |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
|                                                              |                                                              |
| $\cfrac{A \qquad A\to B}{B}{[\to E]}$        | $\cfrac{\Gamma \vdash A \qquad \Gamma, B \vdash C}{\Gamma, A \to B \vdash C}{[\to L]}$ |
|                                                              |                                                              |
| $\cfrac{\begin{matrix}\cfrac{}{A}1\\...\\B\\\end{matrix}}{A\to B}{1\ [\to I]}$ | $\cfrac{\Gamma, A \vdash B}{\Gamma \vdash A \to B}{[\to R]}$ |
|                                                              |                                                              |

| Natural Deduction                                | Sequent Calculus                                             |
| ------------------------------------------------ | ------------------------------------------------------------ |
|                                                  |                                                              |
| $\cfrac{A \qquad \neg A}{\bot}{[\to E]}$ | $\cfrac{\Gamma, A \vdash \bot}{\Gamma \vdash \neg A}{[\neg R]}$ |
|                                                  |                                                              |

| Natural Deduction                                            | Sequent Calculus                                             |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
|                                                              |                                                              |
| $\cfrac{A}{A \vee B}{[\vee I_L]}$                            | $\cfrac{\Gamma \vdash A}{\Gamma \vdash A \vee B}{[\vee R_1]}$ |
|                                                              |                                                              |
| $\cfrac{A}{B \vee A}{[\vee I_R]}$                            | $\cfrac{\Gamma \vdash A}{\Gamma \vdash B \vee A}{[\vee R_2]}$ |
|                                                              |                                                              |
| $\cfrac{A\vee B \qquad A\to C \qquad B \to C}{C}{[\vee E]}$ | $\cfrac{\Gamma, A \vdash C \qquad \Gamma, B \vdash C}{\Gamma, A \vee B\vdash C}{[\vee L]}$ |
|                                                              |                                                              |

| Natural Deduction                 | Sequent Calculus                                             |
| --------------------------------- | ------------------------------------------------------------ |
|                                   |                                                              |
|$\cfrac{A \qquad B}{A \wedge B}{[\wedge I]}$|$\cfrac{\Gamma \vdash A \qquad \Gamma\vdash B}{\Gamma \vdash A \wedge B }{[\wedge R]}$|
|                                   |                                                              |
|$\cfrac{A \wedge B}{B}{[\wedge E_R]}$||
||$\cfrac{\Gamma, A, B \vdash C}{\Gamma, A \wedge B \vdash C }{[\wedge L]}$|
|$\cfrac{A \wedge B}{A}{[\wedge E_L]}$||

### Identity and Structural Rules

#### Identity

$$
\cfrac{}{A \vdash A}{[Id]}
$$

#### Exchange

$$
\cfrac{\Gamma, B, A, \Delta \vdash C}{\Gamma, A, B. \Delta \vdash C}[X]
$$

#### Weakening

$$
\cfrac{\Gamma \vdash B}{\Gamma, A \vdash B}{[W]}
$$

#### Contraction

$$
\cfrac{\Gamma, A, A \vdash B}{\Gamma, A \vdash B}{[C]}
$$

#### Cut

$$
\cfrac{\Gamma \vdash B \qquad \Gamma, B \vdash A}{\Gamma \vdash B}{[Cut]}
$$

## Fomulas

![](img\wk3-0.png)  
![](img\wk3-1.png)  
![](img\wk3-2.png)