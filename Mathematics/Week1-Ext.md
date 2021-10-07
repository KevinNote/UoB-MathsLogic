# Mathematics in Computer Science

<center>
<span>07/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## 负数

对于 32 bit 有符号整数：

```
[-][     0]
[-][     1]
...
[-][2^31-2]
[-][2^31-1]

[+][     0]

[+][     1]
[+][     2]
...
[+][2^31-1]
```

| MIN         | MAX        |
| ----------- | ---------- |
| -2147483648 | 2147483647 |
| -2^31       | 2^31-1     |

## 有限域/Finite Field

Aka 伽罗瓦域/Galois field

对于 Z<sub>N</sub>，其元素为 E ∈ [0, N)。

对于与 Z 的换算可以使用取模运算（Modular）。

**Example:** 在 Z 中的数 x = 17，在 Z<sub>5</sub> 中等效为 2 （x mod 5 = 2）。

对于乘法等运算同样适用。

<strong>Example: </strong>291^28 在 Z<sub>5</sub> 中运算方式为：

291 = 1 (Z<sub>5</sub>)  
291^28 = 1^28 = 1 (Z<sub>5</sub>)
