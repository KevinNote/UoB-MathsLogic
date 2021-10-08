# 代数基础：运算法则与Peano公理

<center>
<span>09/10/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## 运算法则/Laws of Arithmetic

| +                         | ×                         | Law             |
| ------------------------- | ------------------------- | --------------- |
| a + 0 = a                 | a × 1 = a                 | Neutral Element |
| a + b = b + a             | a × b = b × a             | Commutativity   |
| a + (b + c) = (a + b) + c | a × (b × c) = (a × b) × c | Associativity   |

| Formula (+ & ×)                 | Law            |
| ------------------------------- | -------------- |
| a × (b + c) = (a × b) + (a × c) | Distributivity |
| a × 0 = 0                       | Annihilation   |

## Cancellation Laws/消去法则

a + c = b + c ⇒ a = b
a × c = b × c ⇒ a = b (c ≠ 0)

### Cancellation ⇒ Annihilation

```
    a × 0 = a × (0 + 0)    (neutral el.)
          = a × 0 + a × 0  (dist.)
0 + a × 0 = a × 0 + a × 0  (neutral el.)
        0 = a × 0          (cancellation)
```

## Peano's Axioms/Peano公理

1. 0 is natural number
2. If a is a nature number, then so is S(a)[= a + 1]
3. S(a) ≠ 0 for any nature number a
4. S(a) = S(b) ⇒ a = b
5. Axiom of Induction  
   If P(x) is **ANY** property of naturel number, then P(x) is true for all natural numbers.