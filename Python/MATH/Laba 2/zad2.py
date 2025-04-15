import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# Входные параметры π с разной точностью
pi_values = [
    3.14159265358979,
    3.141592653589,
    3.1415926535,
    3.14159265,
    3.141592,
    3.1415,
    3.14,
    3
]

# Количество членов ряда
N = 1_000_000

# Вычисление точной суммы с точным π
pi_true = np.pi
S_true = sum(pi_true / (n**2) for n in range(1, N + 1))

# Вычисление суммы для различных значений π и ошибок
absolute_errors = []
relative_errors = []
methodological_errors = []

for pi_approx in pi_values:
    S_approx = sum(pi_approx / (n**2) for n in range(1, N + 1))
    abs_error = abs(S_true - S_approx)
    rel_error = abs_error / abs(S_true)
    absolute_errors.append(abs_error)
    relative_errors.append(rel_error)

# Методологическая ошибка (разница между ошибкой округления и полной ошибкой)
methodological_errors = np.array(absolute_errors) - np.array(relative_errors)

# Создание таблицы результатов
data = {
    "Вариант параметра π": pi_values,
    "Абсолютная ошибка Δ(S)": absolute_errors,
    "Относительная ошибка δ(S)": relative_errors,
    "Методологическая ошибка": methodological_errors
}

df = pd.DataFrame(data)

# Визуализация ошибок

# График 1: Ошибка округления (абсолютная и относительная)
plt.figure(figsize=(8, 5))
plt.plot(range(1, 9), absolute_errors, marker='o', label='Абсолютная ошибка Δ(S)')
plt.plot(range(1, 9), relative_errors, marker='s', label='Относительная ошибка δ(S)')
plt.yscale('log')
plt.xlabel("Вариант ввода π")
plt.ylabel("Ошибка")
plt.title("Ошибка округления (абсолютная и относительная)")
plt.legend()
plt.grid()
plt.show(block=False)  # Открывает график, но код не блокируется

# График 2: Ошибка округления + методологическая ошибка
plt.figure(figsize=(8, 5))
plt.plot(range(1, 9), absolute_errors, marker='o', label='Абсолютная ошибка Δ(S)')
plt.plot(range(1, 9), methodological_errors, marker='s', label='Методологическая ошибка')
plt.yscale('log')
plt.xlabel("Вариант ввода π")
plt.ylabel("Ошибка")
plt.title("Ошибка округления + Методологическая ошибка")
plt.legend()
plt.grid()
plt.show(block=False)

# График 3: Сравнение первых двух графиков
plt.figure(figsize=(8, 5))
plt.plot(range(1, 9), absolute_errors, marker='o', label='Абсолютная ошибка Δ(S)')
plt.plot(range(1, 9), relative_errors, marker='s', label='Относительная ошибка δ(S)')
plt.plot(range(1, 9), methodological_errors, marker='^', label='Методологическая ошибка')
plt.yscale('log')
plt.xlabel("Вариант ввода π")
plt.ylabel("Ошибка")
plt.title("Сравнение ошибок")
plt.legend()
plt.grid()
plt.show()

print(df)
