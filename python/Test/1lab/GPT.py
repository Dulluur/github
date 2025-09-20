import math

def f(b, c, x):
    return math.sqrt(c - 20) / (b**2 - 13*b + 12) * (math.sin(x)**2)

# EP
try:
    f(2, 19.0, 1.0); assert False  # c<20 -> должна быть ошибка
except ValueError:
    pass

try:
    f(1, 25.0, 0.7); assert False  # b=1 -> ошибка деления на ноль
except ZeroDivisionError:
    pass

assert f(2, 20.0, 1.23) == 0.0                 # c=20 -> 0
K = math.sqrt(5) / ((2-1)*(2-12))              # ≈ -0.2236068
assert abs(f(2, 25.0, math.pi/2) - K) < 1e-12  # sin^2=1
assert abs(f(2, 25.0, 0.0) - 0.0) < 1e-12      # sin^2=0

# BVA по c
for c in (19.9999,):
    try:
        f(2, c, 0.7); assert False
    except ValueError:
        pass
assert f(2, 20.0, 0.7) == 0.0
assert math.isfinite(f(2, 20.0001, 0.7))

# BVA по b
for b in (0.9999, 1.0001, 11.9999, 12.0001):
    assert math.isfinite(f(b, 25.0, 0.7))
for b in (1.0, 12.0):
    try:
        f(b, 25.0, 0.7); assert False
    except ZeroDivisionError:
        pass
