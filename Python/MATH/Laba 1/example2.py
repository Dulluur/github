import math

pi = math.pi
N = 1_000_000

S_direct = sum(pi / (n**2) for n in range(1, N + 1))

S_recursive_backward = 0
for n in range(N, 0, -1):
    S_recursive_backward += pi / (n**2)

abs_error_backward = abs(S_direct - S_recursive_backward)
rel_error_backward = abs_error_backward / abs(S_direct)

print("Результаты вычислений:")
print(f"Прямое суммирование: {S_direct:.15f}")
print(f"Рекуррентное (назад): {S_recursive_backward:.15f}")

print("\nПогрешности:")
print(f"Абсолютная погрешность (назад): {abs_error_backward:.15e}")
print(f"Относительная погрешность (назад): {rel_error_backward:.15e}")