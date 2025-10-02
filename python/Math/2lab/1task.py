import numpy as np
from numpy import random as ran
from scipy import linalg

# matrixA = np.array([
#     [0,0,0,0], 
#     [0,0,0,0], 
#     [0,0,0,0]
#     ])
# print(matrixA)

# print()

# matrixB = np.array([
#     [1,0,0],
#     [0,1,0],
#     [0,0,1]
# ])
# print(matrixB)

# print()

# matrixC = np.array([
#     [1,1,1,1],
#     [1,1,1,1],
#     [1,1,1,1],
#     [1,1,1,1]
# ])
# print(matrixC)

# print()

# matrixD = np.array([
#     [10,10,10],
#     [10,10,10],
#     [10,10,10]
# ])
# print(matrixD)

# 1
matrixA = np.zeros((3,4), dtype=int)
matrixB = np.eye(3, dtype=int)
matrixC = np.ones((4,4), dtype=int)
matrixD = np.full((3,3), 10, dtype=int)
# print("matrixA = \n", matrixA)
# print("matrixB = \n", matrixB)
# print("matrixC = \n", matrixC)
# print("matrixD = \n", matrixD)

# 2

def isSum(A,B):
    try:
        C = A + B
    except:
        print("Невозможное A + B\n")
        return
    return print("A + B = \n", C)

def isMult_AB(A,B):
    try:
        C = np.dot(A,B)
    except:
        print("Невозможное A * B\n")
        return
    return print("A * B = \n", C)

def isMult_BA(B, A):
    try:
        C = np.dot(B,A)
    except:
        print("Невозможное B * A \n")
        return
    return print("B * A = \n", C)

# A = np.eye(3)
# A = np.fliplr(A)
# B = np.array([[0, 2, -3],
#               [-2, 0, 6],
#               [3, -6, 0]])

# isSum(A, B), isMult_AB(A, B), isMult_BA(B, A)

A2 = np.array([[1, 3+2j], [3-2j, 5]], dtype=complex )
B2 = np.array([[3, 2, 1], [7, 1, 4]], dtype=int )

# isSum(A2, B2), isMult_AB(A2, B2), isMult_BA(B2, A2)

A3 = np.array([[0, 1, 3], [1, 5, 6]], dtype=int)
B3 = np.array([[1, 4, 9,], [0, 1, 6]], dtype=int)

# isSum(A3, B3), isMult_AB(A3, B3), isMult_BA(A3, B3)

D = np.array([[1+1j,3,2],[8,-5j,7-1j]])
F = np.array([[2+1j,1,0,0],[1,2-1j,0,0],[0,0,1+1j,1],[0,0,1,1-1j]])
# print("D = ", D.T.conj())
# print( "D = \n", np.conjugate(np.transpose(D)))
# print( "F = \n", np.conjugate(np.transpose(F)))

def EigenFind(arr):
    la, v = linalg.eig(arr)
    print("Eigenvalues: ",la,"\nEigenvectors: ", v)

A = np.array([[9,2,3,5],[3,1,3,5],[1,1,4,2],[1,2,4,3]])
B = np.array([[4,1,0,0,0],[3,4,1,0,0],[0,3,4,1,0],[0,0,3,4,1],[0,0,0,3,4]])
# print("A:")
# EigenFind(A)
# print("B:")
# EigenFind(B)

# 5
m = int(input())
A5 = np.random.rand(m, m)
b = np.ones(m)
Aa = np.linalg.inv(A5)

print(f"Матрица A\n {A5}")
print(f"Определитель \n {np.linalg.det(A5)}")
print(f"Обратная матрица \n {Aa}")

try:
    print(f"у через обратная матрицу \n {np.dot(Aa,b)}")
except:
    print("Невозможно")

try:
    print(f"у Через solve \n {np.linalg.solve(A5,b)}")
except:
    print("Невозможно")