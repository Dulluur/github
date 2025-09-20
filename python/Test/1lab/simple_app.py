# simple_app.py
import math

def f(b, c, x):
    # f(x) = sqrt(c - 20) / (b^2 - 13b + 12) * sin^2(x)
    return math.sqrt(c - 20) / (b**2 - 13*b + 12) * (math.sin(x)**2)

def generate_values(b, c, x1, x2, n):
    if n < 1:
        raise ValueError("n >= 1")
    if x1 > x2:
        raise ValueError("x1 <= x2")
    step = 0 if n == 1 else (x2 - x1) / (n - 1)
    rows = []
    for i in range(n):
        x = x1 + i * step
        rows.append((i + 1, x, f(b, c, x)))
    return rows

def save_to_file(path, rows):
    with open(path, "w", encoding="utf-8") as out:
        for N, x, y in rows:
            out.write(f"{N} {x} {y}\n")

if __name__ == "__main__":
    # пример запуска
    rows = generate_values(b=2.0, c=25.0, x1=0.0, x2=math.pi, n=11)
    save_to_file("output.txt", rows)
