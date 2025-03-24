import math

pi = math.pi
N = 1_000_000

S_direct = sum(pi / (n**2) for n in range(1, N + 1))

S_recursive_forward = 0
for n in range(1, N + 1):
    S_recursive_forward += pi / (n**2)

S_recursive_backward = 0
for n in range(N, 0, -1):
    S_recursive_backward += pi / (n**2)

# Абсолютная и относительная погрешности для каждого метода
abs_error_forward = abs(S_direct - S_recursive_forward)
rel_error_forward = abs_error_forward / abs(S_direct)

abs_error_backward = abs(S_direct - S_recursive_backward)
rel_error_backward = abs_error_backward / abs(S_direct)

# === Вывод результатов ===
print("Результаты вычислений:")
print(f"Прямое суммирование:         {S_direct:.15f}")
print(f"Рекуррентное (вперёд):        {S_recursive_forward:.15f}")
print(f"Рекуррентное (назад):         {S_recursive_backward:.15f}")

print("\nПогрешности:")
print(f"Абсолютная погрешность (вперёд):  {abs_error_forward:.15e}")
print(f"Относительная погрешность (вперёд): {rel_error_forward:.15e}")

print(f"Абсолютная погрешность (назад):   {abs_error_backward:.15e}")
print(f"Относительная погрешность (назад):  {rel_error_backward:.15e}")
