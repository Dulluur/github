def lu_decomposition(A):
    n = len(A)
    L = [[0.0] * n for _ in range(n)]
    U = [[0.0] * n for _ in range(n)]

    for i in range(n):
        L[i][i] = 1.0

        for j in range(i, n):
            U[i][j] = A[i][j] - sum(L[i][k] * U[k][j] for k in range(i))

        for j in range(i + 1, n):
            if U[i][i] == 0:
                raise ZeroDivisionError("Division by zero during LU decomposition.")
            L[j][i] = (A[j][i] - sum(L[j][k] * U[k][i] for k in range(i))) / U[i][i]

    return L, U


def forward_substitution(L, b):
    n = len(L)
    y = [0.0 for _ in range(n)]

    for i in range(n):
        y[i] = b[i] - sum(L[i][j] * y[j] for j in range(i))

    return y


def backward_substitution(U, y):
    n = len(U)
    x = [0.0 for _ in range(n)]

    for i in range(n - 1, -1, -1):
        if U[i][i] == 0:
            raise ZeroDivisionError("Division by zero during back substitution.")
        x[i] = (y[i] - sum(U[i][j] * x[j] for j in range(i + 1, n))) / U[i][i]

    return x


def solve_lu(A, b):
    L, U = lu_decomposition(A)
    y = forward_substitution(L, b)
    x = backward_substitution(U, y)
    return x


# Пример использования
A = [
    [2, -1, -2],
    [-4, 6, 3],
    [-4, -2, 8]
]
b = [-2, 9, -5]

solution = solve_lu(A, b)
print("Решение системы:", solution)
