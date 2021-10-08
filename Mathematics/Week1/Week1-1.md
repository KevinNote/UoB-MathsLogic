# 抽象代数基础：群，环与域

<center>
<span>07/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## 基础/Foundation

### 封闭性/Closure

定义一个二元运算符，接受两个参数，返回一个数字，即

A ∘ B = C

对于上述式得出的元素 C ，应如果与 A, B属于同一集合那么便是封闭性。

Def. <G, ∘>  
∀ a, b ∈ G, a ∘ b ∈ G

### 单位元/Identity Element

对于运算 a ∘ e = a 且 e ∘ a = a 则称 e 为单位元。

并不是所有集合都存在单位元。

**Example:**

- 对于实数的 + 运算，0为单位元。  
  x + 0 = x, 0 + x = x
- 对于实数的 × 运算，1为单位元。  
  x × 1 = x, 1 × x = x

### 逆元/Inverse Element

∀ a ∈ G, ∃a' ∈ G, a' ∘ a = a ∘ a' = e

### 结合律/Associative

∀ a, b, c ∈ G, a ∘ (b ∘ c) = (a ∘ b) ∘ c

### 交换律/Commutative

∀ a, b ∈ G, a ∘ b = b ∘ a

### 零化子/Annihilator

a ∘ 0 = 0 && 0 ∘ a = 0 

## 群类/Group-like

```
<G, ∘>          +封闭性 → 原群/Magma
原群/Magma      +结合律 → 半群/Semigroup
半群/Semigroup  +单位元 → 幺半群/Monoid
幺半群/Monoid   +逆元   → 群/Group
群/Group        +交换律 → 阿贝尔群/Abelian Group
```

| Type\Ax | 封闭性 | 结合律 | 单位元 | 逆元 | 交换律 |
| --- | --- | --- | --- | --- | --- |
| 原群/Magma | o | | | | |
| 半群/Semigroup | o | o | | | |
| 幺半群/Monoid | o | o | o | | |
| 交换幺半群/Exchange Monoid | o | o | o | | o |
| 群/Group | o | o | o | o | |
| 阿贝尔群/Abelian Group | o | o | o | o | o | o |

## 环类/Ring-like

### 半环/Semiring

<G, +, ∙>

```
  <G, +> 为交换幺半群
+ <G, ∙> 为幺半群
+ ∙ 对 + 满足分配律
+ 0 · a = a · 0 = 0
= 半环/Semiring
```

### 环/Ring

<G, +, ∙>

```
  <G, +> 为阿贝尔群
+ <G, ∙> 为幺半群
+ ∙ 对 + 满足分配律
= 环/Ring
```

### 交换环/Commutative Ring

<G, +, ∙>

```
  <G, +> 为阿贝尔群
+ <G, ∙> 为幺半群 + [交换律]
+ ∙ 对 + 满足分配律
= 交换环/Exchange Ring
```

### 域/Field

<G, +, ∙>

```
  <G, +> 为阿贝尔群
+ <G, ∙> 为阿贝尔群
+ ∙ 对 + 满足分配律
= 域/Field
```