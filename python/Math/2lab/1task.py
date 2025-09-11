import numpy as np

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


matrixA = np.zeros((3,4), dtype=int)
matrixB = np.eye(3, dtype=int)
matrixC = np.ones((4,4), dtype=int)
matrixD = np.full((3,3), 10, dtype=int)
print("matrixA = \n", matrixA)
print("matrixB = \n", matrixB)
print("matrixC = \n", matrixC)
print("matrixD = \n", matrixD)