import numpy as np
# import scipy as sp

def isSum(A,B):
    try:
        C = A + B
    except:
        print("impossible A+B\n")
        return
    return print("A+B\n",C)

def isMult_AB(A,B):
    try:
        C = np.dot(A,B)
    except:
        print("impossible AB\n")
        return
    return print("A*B\n",C)
    
def isMult_BA(A,B):
    try:
        C = np.dot(B,A)
    except:
        print("impossible BA\n")
        return
    return print("B*A\n",C)

# A = np.eye(3)
# A = np.fliplr(A)
# B = np.array([[0,2,-3],
#               [-2,0,6],
#               [3,-6,0]
#               ])
# isSum(A,B), isMult_AB(A,B), isMult_BA(B,A)

A = np.array([[1, 3+2j],[3-2j,5]])
B = np.array([[3,2,1],[7,1,4]])

isSum(A,B), isMult_AB(A,B), isMult_BA(B,A)

A = np.array([[0,1,3],[1,5,6]])
B = np.array([[1,4,9],[0,1,6]])
isSum(A,B), isMult_AB(A,B), isMult_BA(B,A)