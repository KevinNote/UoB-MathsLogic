# Linear Algebra: Gaussian elimination/线性代数：高斯消元法

<center>
<span>21/11/2021</span>
<a style="text-decoration:none; color: black;" href="https://github.com/KevinZonda">KevinZonda</a>
</center>

## Proof

**Base Case:**  
$ax = b \qquad x = b / a$

**General Case:**  
$n$ equations in $n$ unknown variables: $x_1, x_2, x_3, \cdots, x_n$
Use one equation to eliminate one unknown variable in the remaining $n-1$ equations.

Solve the system of $n-1$ equations in $n-1$ unknown variables.

Substitute the solution into the first equation, and solve by the base case.

## Example

$$
\left[
    \begin{array}{cccc|c}
      0.02 & 0.01 &   0 &   0 & 0.02 \\
         1 &    2 &   1 &   0 &    1 \\
         0 &    1 &   2 &   1 &    4 \\
         0 &    0 & 100 & 200 &  800 \\
    \end{array}
\right] 
$$

### Step 1: 上升主元
交换第一列最高项目到最高

$$ 
\left[
    \begin{array}{cccc|c}
         1 &    2 &   1 &   0 &    1 \\
      0.02 & 0.01 &   0 &   0 & 0.02 \\
         0 &    1 &   2 &   1 &    4 \\
         0 &    0 & 100 & 200 &  800 \\
    \end{array}
\right] 
$$

### Step 2: 高斯消除

对第一列进行高斯消除

$$ 
\left[
    \begin{array}{cccc|c}
        1 &     2 &     1 &   0 &   1 \\
        0 & -0.03 & -0.02 &   0 &   0 \\
        0 &     1 &     2 &   1 &   4 \\
        0 &     0 &   100 & 200 & 800 \\
    \end{array}
\right] 
$$

### Step 3: 上升主元

对第二列进行上升主元，需要注意，这时候不需要操作第一行，换句话说就是需要操作 N 列的主元只需要操作 $[N, \text{last}]$ 列即可。


$$ 
\left[
    \begin{array}{cccc|c}
        1 &     2 &     1 &   0 &   1 \\
        0 &     1 &     2 &   1 &   4 \\
        0 & -0.03 & -0.02 &   0 &   0 \\
        0 &     0 &   100 & 200 & 800 \\
    \end{array}
\right] 
$$

### Step 4: 高斯消除

对第二列进行高斯消去

$$ 
\left[
    \begin{array}{cccc|c}
        1 & 2 &    1 &    0 &    1 \\
        0 & 1 &    2 &    1 &    4 \\
        0 & 0 & 0.04 & 0.03 & 0.12 \\
        0 & 0 &  100 &  200 &  800 \\
    \end{array}
\right] 
$$

### Step 5: 上升主元

对第二列进行上升主元

$$ 
\left[
    \begin{array}{cccc|c}
        1 & 2 &    1 &    0 &    1 \\
        0 & 1 &    2 &    1 &    4 \\
        0 & 0 &  100 &  200 &  800 \\
        0 & 0 & 0.04 & 0.03 & 0.12 \\
    \end{array}
\right] 
$$


### Step 6: 高斯消除

消去

$$ 
\left[
    \begin{array}{cccc|c}
        1 & 2 &   1 &     0 &    1 \\
        0 & 1 &   2 &     1 &    4 \\
        0 & 0 & 100 &   200 &  800 \\
        0 & 0 &   0 & -0.05 & -0.2 \\
    \end{array}
\right] 
$$

形成如下三角矩阵

$$ 
\left[
    \begin{array}{cccc|c}
        * & * & * & * & * \\
        0 & * & * & * & * \\
        0 & 0 & * & * & * \\
        0 & 0 & 0 & * & * \\
    \end{array}
\right] 
$$

## Step 7: 替换算法

代入形成方程组

$$
\begin{cases}
    1x_1 + 2x_2 +   1x_3 +     0x_4 =    1 \\
    0x_1 + 1x_2 +   2x_3 +     1x_4 =    4 \\
    0x_1 + 0x_2 + 100x_3 +   200x_4 =  800 \\
    0x_1 + 0x_2 +   0x_3 + -0.05x_4 = -0.2 \\
\end{cases}
$$

也就是

$$
\begin{cases}
                           -0.05x_4 = -0.2 & x_4=4 \\
                  100x_3 +   200x_4 =  800 & x_3=0 \\
           1x_2 +   2x_3 +     1x_4 =    4 & x_2=0 \\
    1x_1 + 2x_2 +   1x_3 +     0x_4 =    1 & x_1=1 \\
\end{cases}
$$

## 特殊情况

### 特殊情况1

$
a x = b \text{, but } a = 0\\
0=b \text{, if } b \ne 0 \text{ then this is contradictory, hence no solution}
$

### 特殊情况2

$
ax=b \qquad a = 0, b = 0\\
0=0, x \text{ can be freely chosen.}
$

Base case 1: 1 unknown and one or more equations.  
Solve each equation:
- if the answers agree, great
- if the answers do not agree, no solution

Base case 2: One or more unknowns and one equation

Example: $x-2y+z=0$

$
x = 3+2y-z\\
y: \text{chosen freely}\\
z: \text{chosen freely}
$

总的来说，、解包含以下几种情况
- 只有一种解
- 无解
- 无限数量解
