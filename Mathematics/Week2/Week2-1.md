# 计算机数学基础：实数与浮点数

<center>
<span>09/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Scientific Notation/科学计数法

N ⊂ Z ⊂ Q ⊂ R  
自然数 ⊂ 整数 ⊂ 有理数 ⊂ 实数

b ≥ 2  
实数可表示为  

<center>
d<sub>n</sub>d<sub>n-1</sub>...d<sub>1</sub>d<sub>0</sub> . d<sub>-1</sub>d<sub>-2</sub>...  
</center>

其值为  
<center>
d<sub>n</sub>×b<sup>n</sup> + d<sub>n-1</sub>×b<sup>n-1</sup> + ... + d<sub>1</sub>×b<sup>1</sup> + d<sub>0</sub>×b<sup>0</sup> <strong>+ d<sub>-1</sub>×b<sup>-1</sup> + d<sub>-2</sub>×b<sup>-2</sup></strong>
</center>

```
123.145 = 1.23145 × 10^2
        = 1.23145E2
          ┕--┬--┙ ┕ exponent
          mantissa
```

## Floating Point Numbers/浮点数

b = 2, mantissa of 24 digits, exponent of 8 digits, sign of 1 digit.

**Attention:** mantissa cannot start with 0, if it is 0, the number is not normalised.

Therefore, in binary, the mantissa can only be 1, so we can ignore it. So we just need 23 bits to store mantissa.

We only need to store:

d<sub>0</sub> . d<sub>-1</sub>d<sub>-2</sub> ... d<sub>-23</sub>

d<sub>0</sub> must be 1, so no need be stored.

### Register

```
[31][23-30][0-22]
 S     E     M
```

| Bit No | Size    | Field Name   |
| ------ | ------- | ------------ |
| 31     | 1 bit   | Sign (S)     |
| 23-30  | 8 bits  | Exponent (E) |
| 0-22   | 23 bits | Mantissa (M) |

### Examples/样例

1/5<sub>10</sub> = 0.001100110011...<sub>2</sub> = 1.1001100E-3


## Another View/换个角度

### Range/范围

In a fixed exponent `n`, we have:

- Min: 1.000 ... 00 E n
- Max: 1.111 ... 11 E n

So we have 2<sup>23</sup> floats number with a fixed exponent.

对于当 n = 0，浮点数范围其实为 [1, 2)

n = -1, [0.5, 1)

范围为 [2<sup>n</sup>, 2<sup>n+1</sup>)

![](img/E.png)

### Numeral System/记数系统

| 数集 | 样例                 | 运算       | 代数系统 |
| ---- | -------------------- | ---------- | -------- |
| N    | 0, 1, 2, ...         | +, ×       |          |
| Z    | -2, -1, 0, 1, 2, ... | +, ×, -    | Ring     |
| Q    | a/b                  | +, ×, -, ÷ | Field    |
| R    | 3.14159...           | +, ×, -, ÷ | Field    |

- Computer integers behave like Z<sub>2<sup>32</sup></sub> is not a field.
- There are other field, Z<sub>m</sub>, m is prime.
- Floating point numbers do not form a field.

## Reference

- "Floating Point Numbers": <https://www.doc.ic.ac.uk/~eedwards/compsys/float/>