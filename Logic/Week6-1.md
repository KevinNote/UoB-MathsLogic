# Propositional Logic - SAT/命题逻辑 - 布尔可满足性问题

<center>
<span>14/11/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Basic Definitions/基础定义

$\mathcal{P}$: 问题可以在多项式时间（polynomial time）内解决

$\mathcal{NP}$: 问题的解决方案或答案可以在多项式时间（polynomial time）内验证。

通常来说，$\mathcal{P} \subseteq \mathcal{NP}$。（解决是一个（困难的）验证）

大多数人认为 $\mathcal{P} \neq \mathcal{NP}$

### $\mathcal{NP}$ 问题的难度

**Definition:** A problem is $\mathcal{NP}$-hard if it is at least as hard as any problem in $\mathcal{NP}$.

**定义：** 如果一个问题的难度至少与 $\mathcal{NP}$ 中的一个问题一样，那么这个问题就是 $\mathcal{NP}$ 难的。

没太看懂老师在说什么，反正就很难解决就是了。

## Solution of SAT/SAT 的解决方案

### Significance/意义

很多问题可以变换为 SAT。

- 一个有效解可以被“高效地”验证  
  A possible solution (valuation) can be verified “efficiently”
- 没有已知可作用于所有情况“高效”的算法  
  No known algorithm to solve the problem “efficiently” in all cases
- 实践来说，SAT解决器非常高效（$\mathcal{NP}$是最差情况）

### Special Cases/特殊案例

对于一个 $n$-SAT 是对于一个被限制为 $n$-CNF 的式子（子句是 $n$ 个文字的析取（$\vee$））。

- $1$-SAT 是 $\mathcal{P}$
- $2$-SAT 是 $\mathcal{P}$
- $3$-SAT 是 $\mathcal{NP}$

### 一些方法

#### 为什么不把 CNF 转换为 DNF？

通常来说来说将一个 CNF 转换成 DNF 会导致子句数量指数爆炸（exponential blowup）。

#### 暴力算法

Brute force：对有 $N$ 个变量以及 $M$ 个子句的 SAT 需要 $2^N \cdot N \cdot M$ 次。

- 有 $2^N$ 个真值分配
- 每一个需要验证 $N$ 次

**Conjecture (Strong Exponential Time Hypothesis (SETH)):** SAT cannot be solved inp $(2-\alpha)^N\cdot poly(N+M)$ time for any constant $\alpha > 0$.

#### DPLL Algorithm/DPLL算法

Davis-Putman-Logemann-Loveland algorithms.

- 简单场景
  - 原子命题 $p$ 只出现为 $p$ 或者 $\neg p$ （不同时出现）：相对应地分配真值
- 选择一个变量 $p$ 并为其设置一个真值的分支
  - 如果 $p=T$：移除全部包含 $p$ 的子句以及子句中所有 $\neg p$的文字
    - 对于包含 $p$ 的子句，例如 $\cdots \wedge (\cdots\vee p \vee\cdots)\wedge\cdots$，考虑到子句已包含一个 $T$，固整个子句是 $T$，所以可以移除
    - 对于子句中所有 $\neg p$的文字，考虑 $\cdots \wedge (\cdots\vee\neg p \vee\cdots)\wedge\cdots$，考虑到子句中的 $\neg p = F$，固整个子句是依旧不确定，所以可以移除 $\neg p$ 变成 $\cdots \wedge (\cdots\vee\cdots)\wedge\cdots$
  - 如果 $p=F$：移除全部包含 $\neg p$ 的子句以及子句中所有 $p$的文字
    - 对于包含 $p$ 的子句，例如 $\cdots \wedge (\cdots\vee\neg p \vee\cdots)\wedge\cdots$，考虑到子句已包含一个 $T$，固整个子句是 $T$，所以可以移除
    - 对于子句中所有 $p$的文字，考虑 $\cdots \wedge (\cdots\vee p \vee\cdots)\wedge\cdots$，考虑到子句中的 $p = F$，固整个子句是依旧不确定，所以可以移除 $p$ 变成 $\cdots \wedge (\cdots\vee\cdots)\wedge\cdots$
- 保持执行直到
  - 所有子句被移除（全真）：则为 *SAT*
  - 有一个子句是空的（一个是假的）：回溯到步骤二，给 $p$ 选择一个不同的值，如果无法回溯，则返回 *UNSAT*

**Example:** to $(\neg p \vee q \vee r) \wedge (p \vee q \vee r) \wedge (p \vee q \vee \neg r) \wedge (\neg p \vee \neg q \vee r)$

$(\neg p \vee q \vee r) \wedge (p \vee q \vee r) \wedge (p \vee q \vee \neg r) \wedge (\neg p \vee \neg q \vee r)$
1. $p=T$  
   $(q\vee r) \wedge (\neg q \vee r)$
2. $q=F$  
   $(r)$
3. $r=T$  
   SAT

## Read More

- [Z3 Prover/z3 - GitHub](https://github.com/Z3Prover/z3)
- [Examples - SMT-LIB](https://smtlib.cs.uiowa.edu/examples.shtml)