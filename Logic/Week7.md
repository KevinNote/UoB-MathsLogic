# Predicate Logic - Syntax/谓词逻辑 - 语法

<center>
<span>14/11/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Basic/基础

Propositional logic does not allow stating **properties of** and **relations between** "objects"

Predicate logic
- Contains propositional logic
- aka first-order logic（一阶逻辑）
- allows to reason about members of a  non-empty domain

## Key Ingredients/核心构成

谓词逻辑由以下部分核心构成：
- Predicate/谓词
- Quantifiers/量词/量化
- Variables/变量
- Functions/函数
- Constants/常量

**Example:**
> All men are mortal  
> Socrates is a man  
> Therefore, Socrates is mortal

可以被写成：

$$
\forall x. (p(x)\to q(x)), p(s)\vdash q(s) 
$$

- Predicates:
  - $p(x)$ 表示 $x$ 是 a man
  - $q(x)$ 表示 $x$ 是 mortal
- Quantifier: "对于全部"符号 $\forall$
- Variable: $x$ 表示域的一个元素
- Constant: $s$ 表示Socrates


### Domain(aka. universe)/域

- 要推理的非空对象/实体（个体）集  
  Non-empty set of objects/entities (individuals) to reason about

### Variable/变量

- 表示在域中的对象（未知的）
- 通常表示为 $x, y, z, ...$
- 与其他编程语言的变量类似

### Quantifiers/量词/量化

- universal quantifier/全称量化  
  $\forall x. \cdots$ 对于所有属于域中的 $x$
- existential quantifier/存在量化  
  $\exists x. \cdots$ 对于域，存在 $x$
- 量化域的元素  
  quantify over elements of the domain
- precedence/优先级：低于其他连接词

### Functions/函数

- 从域的元素构建一个域的元素
- 通常表示为 $f, g, h, ...$
- 不同函数有不同数量的参数
- 函数参数的数量叫 arity
- 一个 arity 1的函数作用于一个参数，arity 2的作用于两个参数，以此类推。
- **Notation:** 我们通常使用 $f^k$ 表示一个 arity $k$ 的函数 $f$

### Constants/常量

- 域中的特定函数
- 是一个arity 0的函数
- 通常表示为 $a, b, c, ...$

### Predicates/谓词

- 谓词是事实/声明，可以为真或假
- 其的真假取决于其参数
- 其可以看作从域元素到命题的函数

### Connections between $\exist$ & $\forall$ / $\exist$ 和 $\forall$ 的连接

$$
\neg (\forall x.p(x)) \Longleftrightarrow \exist x.\neg p(x)
$$

$$
\neg(\exist x.p(x)) \Longleftrightarrow \forall x.\neg p(x)
$$

### Arity of Predicates/谓词的 arity

-  Unary: arity 1
   -  表示个体的事实
-  Binary: arity 2
   -  表示两个个体之间的关系
   -  无需对称（symmetric）
-  Nullary: arity 0
   -  原子命题

**Notation:** 我们通常使用 $p^k$ 表示 arity $k$ 的谓词 $p$。

## Syntax/语法

$$
t ::= x \mid f(t, ..., t)
$$

$$
P ::= p(t, ..., t) \mid \neg P \mid P \wedge P  \mid P \vee P \mid P \to P \mid \forall x.P \mid \exists x.P
$$

- $x$ ranges over variables
- $f$ ranges over function symbols
- $f(t_1, ... , t_n)$ is a well-formed term only if $f$ has arity $n$
- $p$ ranges over predicate symbols
- $p(t_1, ... , t_n)$ is a well-formed formula only if $p$ has arity $n$

The pair of a collection of function symbols, and a collection of predicate symbols, along with their arities, is called a **signature**.


## Read More

- [Chapter 7: First order logic - Logic and Proof](https://leanprover.github.io/logic_and_proof/first_order_logic.html)