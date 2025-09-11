import numpy as np
import matplotlib.pyplot as plt

# Данные
x = np.linspace(-10, 10, 400)

y1 = np.sin(x)
y2 = np.cos(x)
y3 = np.exp(-x**2 / 20)
y4 = np.tan(x)

# Построение
# plt.figure(figsize=(10, 8))

# Первый график
plt.subplot(2, 2, 1)
plt.plot(x, y1, color='blue', linestyle='-', label='sin(x)')
plt.title('График sin(x)')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)

# Второй график
plt.subplot(2, 2, 2)
plt.plot(x, y2, color='red', linestyle='--', label='cos(x)')
plt.title('График cos(x)')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)

# Третий график
plt.subplot(2, 2, 3)
plt.plot(x, y3, color='green', linestyle='-.', label='exp(-x²/20)')
plt.title('График exp(-x²/20)')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)

# Четвёртый график
plt.subplot(2, 2, 4)
plt.plot(x, y4, color='purple', linestyle=':', label='tan(x)')
plt.ylim(-5, 5)  # ограничим по y, чтобы было видно
plt.title('График tan(x)')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)

plt.tight_layout()
plt.show()
