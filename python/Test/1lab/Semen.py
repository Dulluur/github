import math as m

def f(a, b, x):
    return (m.sqrt(m.pow(a, 3) + 1000) / (m.pow(b, 2) - 3*b - 4)) * (m.sin(x) + m.cos(x))

arr = [
    [-9, 2, 0],
    [-11, 2, 0],
    [-9, -1, 0],
    [-9, 4, 0],
    [-10.01, 2, 0],
    [-9.99, 2, 0],
    [-9, 4.01, 0],
    [-9, -1.01, 0],
    [-9, 3.99, 0],
    [-9, -0.99, 0],
    [-9, 2, 1],
    [-9, 2, -1],
    [-9, 2, m.pi/2],
    [-9, 2, m.pi],
    [-9, 2, -m.pi/2]
]

for i in arr:
    try:
        print(f(i[0], i[1], i[2]))
    except ZeroDivisionError:
        print("#DIV/0!")
    except ValueError:
        print("#NUM!")
