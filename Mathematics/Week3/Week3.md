# 集合论基础：集合

<center>
<span>14/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Operation/运算

### Cartesian Product/笛卡尔积

N = {0, 1, 2, 3, 4, 5, ...} = {0, s(0), s(s(0)), s(s(s(0))), ...}

Z = N U {-1, -2, -3, -4, -5, ...}

A × B = {(a, b) | a in A, b in B}

**Example:**  
A = {a, b}  
B = {0, 1, 2}  
A × B = {(a, 0), (a, 1), (a, 2), (b, 0), (b, 1)}

### Remove/移除

F = Z × P (P is nat. without 0)

P = N \ {0}

\ means taking away

ε means empty string

## Cardinality of Sets/集合基数

|A|, card(A) Cardinality (size, number of elements of set)

Infinite Sets: N ⊊ N ⋃ {-1}

### Infinity + One

满足单射。

```
N        = { 0, 1, 2, 3, ...}
             |  |  |  |
N ⋃ {-1} = {-1, 0, 1, 2, ...}
```

### Infinity + Infinity

```
N = { 0,  1,  2,  3,  4, ...}
      |   |   |   |   |
Z = { 0, -1,  1, -2,  2, ...}
```

|N| = |Z|

### Infinity × Infinity

N<sup>2</sup> = N × N

N = {0, 1, 2, 3, 4, ...}

```
N = {     0,       1,      2,      3   , ...}
          |        |       |       |
N × N = {(0, 0), (0, 1), (1, 0), (0, 2), ...}
```

|N| = |N × N|

If a set has the same size as N, then it is called **"countable"** or **"countably infinite"**

**Theorem:** The set of Java programme is countable (Unicode<sup>*</sup>)

## Uncountability/不可数

|R| ≩ |N|

**Proof:** Cantor's diagonal argument
[中文](https://zh.wikipedia.org/zh-hans/%E5%B0%8D%E8%A7%92%E8%AB%96%E8%AD%89%E6%B3%95)
[ENG](https://en.wikipedia.org/wiki/Cantor%27s_diagonal_argument)  
**Conclusion:** the listing is incomplete: it misses a
Any listing will miss some real numbers

**Theorem:** the set R of real number is uncountable

Java is countable  
R is not countable  
**Theorem:** There must exist real numbers which cannot be computed
