import numpy as np
import matplotlib.pyplot as plt
import ace_tools as tools
import pandas as pd

N = 1_000_000
pi_approximations = [
    3.14159265358979,
    3.141592653589,
    3.1415926535,
    3.14159265,
    3.141592,
    3.1415,
    3.14,
    3
]

# Точное значение суммы
S_exact = np.sum(np.pi / np.arange(1, N + 1) ** 2)
print(S_exact)

# Вычисление погрешностей для каждого приближения π
results = {
    "Вариант ввода π": [],
    "Абсолютная погрешность (ΔS)": [],
    "Относительная погрешность (δS)": []
}

for pi_approx in pi_approximations:
    S_approx = np.sum(pi_approx / np.arange(1, N + 1) ** 2)
    absolute_error = abs(S_approx - S_exact)
    relative_error = absolute_error / abs(S_exact)

    results["Вариант ввода π"].append(pi_approx)
    results["Абсолютная погрешность (ΔS)"].append(absolute_error)
    results["Относительная погрешность (δS)"].append(relative_error)

# Создание таблицы результатов
df_results = pd.DataFrame(results)

# Отображение таблицы
tools.display_dataframe_to_user("Результаты вычислений", df_results)

# Построение графика
plt.figure(figsize=(10, 6))
plt.plot(results["Вариант ввода π"], results["Абсолютная погрешность (ΔS)"], marker='o', label='Абсолютная погрешность (ΔS)')
plt.plot(results["Вариант ввода π"], results["Относительная погрешность (δS)"], marker='s', label='Относительная погрешность (δS)')
plt.xlabel("Приближение числа π")
plt.ylabel("Погрешность")
plt.title("Зависимость погрешности от точности числа π")
plt.grid(True)
plt.legend()
plt.show()
