# Propositional Logic - Semantics/命题逻辑 - 语义

<center>
<span>13/11/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Basic

Assigning meaning/iterpertations with formula

### For English

Syntax   ：alphabet and grammar  
Semantics: meanings for works

### Truth Assignment

Function assigning a truth value for each atomic proposition

**Example:** to $p \vee q$  
One truth assignment $\phi$ is $\phi(p) = T$ and $\phi(q) = F$

Atmos $\bot, \top$ have the iterpretations $T, F$ respectively. i.e. $\phi(\bot) = F$ and $\phi(\top) = T$.

## Satisfiability & Validity

$\phi$ satisfies $A$ if $\phi(A) = T$.

- $A$ is **satisfiable** if there exists a valuation $\phi$ φ on atomic
propositions such that $\phi(A) = T$.
- $A$ is **valid** if $\phi(A) = T$ for all possible valuations $\phi$.


A formula is **satisfiable** iff there is a valuation that satisfies it  
i.e., if there is a T in the rightmost column of its truth table

A formula is **falsifiable** iff there is a valuation that makes it false  
i.e., if there is a F in the rightmost column of its truth table

A formula is **unsatisfiable** iff no valuation satisfies it  
i.e., the cells of the rightmost column of its truth table all contain F

A formula is **valid** iff every valuation satisfies it
i.e., the cells of the rightmost column of its truth table all contain T

换句话说，对于一个表达式，对于任何情况都满足时称之为 valid，如果对于部分情况满足，则为 satisfiable。对于任何情况都不满足的称之为 unsatisfiable，对于部分情况可使其不满足则称之为 falsifiable。


### Validity of an argument

- **Syntactically:** we can derive the conclusion from the premises
- **Semantically:** the conclusion is true whenever the premises are

$$
P_1, ..., P_n \vDash C
$$
If the corresponding argument is **semantically valid**.  
i.e.every valuation that evaluates each of the premises $P_1, ..., P_n$ to $T$ also the conclusion $C$ to $T$.

We could check it by:
- Natural Deduction
- Sequent Calculus
- Truth Table
- Bonus

## Soundness & Completeness/可靠性与完整性

- formula is provable if
  - a syntactic notion
  -  it asserts the existence of a syntactic object: a proof
  - typically written $\vdash A$
- formula is valid if $\phi(A)=T$ for all possible valuations $\phi$
  - it's a semantic notion

### Soundness/可靠性

**可靠性定理：** 如果 $\phi_1, \phi_2, ... \phi_n \vdash \psi$ 是有效的，则 $\phi_1, \phi_2, ... \phi_n \vDash \psi$ 有效。


这个定理是在说，我们为逻辑系统定义好语法和语义后，如果在语法上，我们可以利用推导规则，将  $\phi_1, \phi_2, ... \phi_n$ 转化为 $\psi$，

那么在语义上，如果 $\phi_1, \phi_2, ... \phi_n$ 都为 $T$, 那么 $\psi$ 一定为 $T$.

### Completeness/完备性

**完备性定理：** 如果 $\phi_1, \phi_2, ... \phi_n \vDash \psi$ 是有效的， 那么 $\phi_1, \phi_2, ... \phi_n \vdash \psi$ 是有效的。

在一个逻辑系统中，如果从语义上看， $\phi_1, \phi_2, ... \phi_n \vDash \psi$ 是有效的， 那么我们一定可以为 $\phi_1, \phi_2, ... \phi_n \vdash \psi$ 找到一个证明。 

## Read More

- [命题逻辑中的语法与语义，可靠性与完备性 - CSDN](https://blog.csdn.net/on_1y/article/details/8727346)
- [Chapter 6: Semantics of Propositional Logic - Logic and Proof](https://leanprover.github.io/logic_and_proof/semantics_of_propositional_logic.html)