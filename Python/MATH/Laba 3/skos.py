import numpy as np
import matplotlib.pyplot as plt

# Исходные базисные векторы
i = np.array([1, 0])  # Вектор i (1,0)
j = np.array([0, 1])  # Вектор j (0,1)

# Коэффициенты скоса
k_x = 1  # Скос по x (j двигается вправо)
k_y = 0.5  # Скос по y (i двигается вверх)

# Матрицы скоса
S_x = np.array([[1, k_x], [0, 1]])  # Скос по x
S_y = np.array([[1, 0], [k_y, 1]])  # Скос по y

# Преобразованные векторы
i_sx, j_sx = S_x @ i, S_x @ j  # Скос по x
i_sy, j_sy = S_y @ i, S_y @ j  # Скос по y

# Создание графика
fig, ax = plt.subplots(figsize=(6, 6))

# Исходные векторы
ax.quiver(0, 0, i[0], i[1], angles='xy', scale_units='xy', scale=1, color='blue', label="i (начальный)")
ax.quiver(0, 0, j[0], j[1], angles='xy', scale_units='xy', scale=1, color='red', label="j (начальный)")

# Векторы после скоса по x (наклон вбок)
ax.quiver(0, 0, i_sx[0], i_sx[1], angles='xy', scale_units='xy', scale=1, color='cyan', label="i (скос x)")
ax.quiver(0, 0, j_sx[0], j_sx[1], angles='xy', scale_units='xy', scale=1, color='magenta', label="j (скос x)")

# Векторы после скоса по y (наклон вверх)
ax.quiver(0, 0, i_sy[0], i_sy[1], angles='xy', scale_units='xy', scale=1, color='green', label="i (скос y)")
ax.quiver(0, 0, j_sy[0], j_sy[1], angles='xy', scale_units='xy', scale=1, color='orange', label="j (скос y)")

# Настройки осей
ax.set_xlim(-1, 3)
ax.set_ylim(-1, 3)
ax.axhline(0, color='black', linewidth=0.5)
ax.axvline(0, color='black', linewidth=0.5)
ax.grid(True, linestyle='--', linewidth=0.5)
ax.set_aspect('equal')
ax.set_title("Матрица скоса: изменение базисных векторов")
ax.legend()

plt.show()
