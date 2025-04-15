def lu_decomposition(A):
    n = len(A)
    L = [[0] * n for _ in range(n)]
    U = [[0] * n for _ in range(n)]

    for i in range(n):
        # Верхняя треугольная матрица U
        for j in range(i, n):
            U[i][j] = A[i][j] - sum(L[i][k] * U[k][j] for k in range(i))

        # Нижняя треугольная матрица L
        for j in range(i, n):
            if i == j:
                L[i][i] = 1  # Диагональ нижней матрицы – единицы
            else:
                if U[i][i] == 0:
                    raise ValueError("Невозможно выполнить LU-разложение: деление на ноль.")
                L[j][i] = (A[j][i] - sum(L[j][k] * U[k][i] for k in range(i))) / U[i][i]

    return L, U

# Пример:
A = [[2, -1, -2],
     [-4, 6, 3],
     [-4, -2, 8]]

L, U = lu_decomposition(A)

print("L:", L)
print("U:", U)
