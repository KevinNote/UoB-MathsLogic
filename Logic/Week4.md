# Propositional Logic - Classical Reasoning/命题逻辑 - 经典逻辑

<center>
<span>24/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Basic Laws

### Law of Excluded Middle (LEM)

For each A we can always prove $A$ or $\neg A$

To make it simple $\vdash A \vee \neg A$

$$
\cfrac{}{A \vee \neg A}{[LEM]}
$$

### Double Negation Elimination (DNE)

$\neg \neg A \vdash A$

Equivalently, $(\neg A)\to \bot \vdash A$

$$
\cfrac{\neg\neg A}{A}{[DNE]}
$$

**proof by contradiction（构造性证明）** 

Classical reasoning allows using these 2 rules.

We should use them by **constructive(构造性)** or **intuitionistic(直觉)** logic.

### Some proof

#### LEM implies DNE

Assuming $A\vee \neg A$, infer $\neg\neg A \vdash A$

![](img/wk4-0.png)

<!--$$
\cfrac{A \vee\neg A
          \qquad
          \cfrac
              {\cfrac{}{A}{1}}
              {A \to A}
              {\ 1\ [\to I]}
          \qquad
          \cfrac
              {
                  \cfrac
                  {
                      \cfrac
                      {
                          \cfrac
                          {}
                          {\neg A}
                          {\ 2}
                          \qquad
                          \neg\neg A
                      }
                      {\bot}
                      {[\neg E]}
                  }
                  {A}
                  {\ 2 \ [\bot E]}
              }
              {\neg A\to A}
              {\ 2 \ [\to I]}
      }
      {A}
      {[\vee E]}
$$-->

#### DNE implies LME

Assuming $\neg\neg A \vdash A$, infer $\vdash A\vee \neg A$

![](img/wk4-1.png)

<!--$$
\cfrac
{
    \cfrac
    {
        \cfrac
        {
            \cfrac {}
            {
                \neg (A \vee \neg A)
            }{1}
            \qquad
            \cfrac
            {
                \cfrac
                {
                    \cfrac
                    {
                        \cfrac
                        {}
                        {\neg(A \vee \neg A)}
                        {1}
                        \qquad
                        \cfrac
                        {
                            \cfrac {}
                            {A}{2}
                        }
                        {A \vee \neg A}
                        {[\vee I_L]}
                    }
                    {\bot}
                    {[\neg E]}
                }
                {\neg A}
                {\ 2\ [\neg I]}
            }
            {A \vee \neg A}
            {\ [\vee I]}
        }
        {\bot}
        {[\neg E]}
    }
    {\neg\neg(A \vee \neg A)}
    {\ 1\ [\neg I]}
}
{A\vee \neg A}
{[DNE]}
$$-->

### Contrapositive/换质位推理

Given an implication $A \to B$, the formula $\neg B \to\neg A$ is called the **contrapositive**.

**Proof:** $A\to B \vdash \neg B \to \neg A$

![](img/wk4-2.png)

**Proof:** $\neg B \to \neg A \vdash A\to B$

![](img/wk4-3.png)

### In Sequent Calculus

$$
\cfrac{}
{\Gamma\vdash A \vee\neg A}{[LEM]}
$$

$$
\cfrac
{\Gamma\vdash\neg\neg A}
{\Gamma \vdash A}
{[DNE]}
$$

## Classical vs Intuitionistic 



| **Intuitionistic**                                                                        | **Classic**                                                                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma\vdash A\qquad\Gamma, B\vdash C}{\Gamma, A \to B \vdash C}[\to E]$          | $\cfrac{\Gamma\vdash A, \Delta\qquad\Gamma, B\vdash \Delta'}{\Gamma, A \to B \vdash \Delta, \Delta'}[\to L]$                              |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma, A \vdash B}{\Gamma\vdash A \to B}{[\to R]}$                               | $\cfrac{\Gamma, A \vdash B, \Delta}{\Gamma\vdash A \to B, \Delta}{[\to R]}$                                                               |
|                                                                                           |                                                                                                                                           |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma\vdash B \qquad \Gamma, B\vdash A}{\Gamma\vdash A}{[Cut]}$                  | $\cfrac{\Gamma_1\vdash B,\Delta_1 \qquad \Gamma_2, B\vdash \Delta_2}{\Gamma_1, \Gamma_2\vdash \Delta_1, \Delta_2}{[Cut]}$                 |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma\vdash A \qquad \Gamma\vdash B}{\Gamma\vdash A\wedge B}{[\wedge R]}$        | $\cfrac{\Gamma_1\vdash A,\Delta_1 \qquad \Gamma_2\vdash B, \Delta_2}{\Gamma_1, \Gamma_2\vdash A\wedge B, \Delta_1, \Delta_2}{[\wedge R]}$ |
|                                                                                           |                                                                                                                                           |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma, A\vdash C \qquad \Gamma, B\vdash C}{\Gamma, A \vee B \vdash C}{[\vee L]}$ | $\cfrac{\Gamma_1, A\vdash \Delta_1 \qquad \Gamma_2, B\vdash \Delta_2}{\Gamma_1, \Gamma_2, A \vee B \vdash \Delta_1, \Delta_2}{[\vee L]}$  |
|                                                                                           |                                                                                                                                           |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma\vdash A}{\Gamma, \neg A \vdash B}{[\neg L]}$                               | $\cfrac{\Gamma\vdash A, \Delta}{\Gamma, \neg A \vdash \Delta}{[\neg L]}$                                                                  |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma, A\vdash \bot}{\Gamma\vdash \neg A}{[\neg R]}$                             | $\cfrac{\Gamma, A\vdash \Delta}{\Gamma\vdash \neg A, \Delta}{[\neg R]}$                                                                   |
|                                                                                           |                                                                                                                                           |
|                                                                                           |                                                                                                                                           |
| $\cfrac{\Gamma\vdash A}{\Gamma\vdash A \vee B}{[\vee R_L]}$                               |                                                                                                                                           |
|                                                                                           | $\cfrac{\Gamma\vdash A, B, \Delta}{\Gamma\vdash A \vee B}{[\vee R]}$                                                                      |
| $\cfrac{\Gamma\vdash A}{\Gamma\vdash B \vee A}{[\vee R_2]}$                               |                                                                                                                                           |
|                                                                                           |                                                                                                                                           |

### Other Structural Formulas

#### Right Exchange

$$
\cfrac{\Gamma\vdash\Delta_1, B, A, \Delta_2}{\Gamma\vdash\Delta_1, A, B, \Delta_2}{[X_R]}
$$

#### Right Weakening

$$
\cfrac{\Gamma\vdash\Delta}{\Gamma\vdash A, \Delta}{[W_R]}
$$

#### Right Contraction

$$
\cfrac{\Gamma\vdash A, A, \Delta}{\Gamma\vdash A, \Delta}{[C_R]}
$$

## Rules of the Classical Sequent Calculus

![](img\wk4-4.png)

