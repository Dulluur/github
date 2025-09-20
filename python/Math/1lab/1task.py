import numpy as np
import matplotlib.pyplot as plt

# x = [1, 2, 3, 4, 5]
# y = [25, 32, 34, 20, 51]

# plt.plot(x, y, color='green', marker='o', markersize=7)
# # plt.plot(x, y)
# plt.xlabel('Ось х') #Подпись для оси х
# plt.ylabel('Ось y') #Подпись для оси y
# plt.title('Первый график') #Название
# plt.show()

x = np.linspace(-10, 10, 400)

y1 = np.sin(x)
y2 = np.cos(x)
y3 = np.tan(x)
y4 = np.cos(x)/np.sin(x)

# Первый график
plt.subplot(2, 2, 1)
plt.plot(x, y1, color="blue", linestyle="-", label="sin(x)")
plt.title('График sin(x)')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)


# Второй график
plt.subplot(2,2,2)
plt.plot(x, y2, color="red", linestyle="--", label="cos(x)")
plt.title("График cos(x)")
plt.xlabel("x")
plt.ylabel("y")
plt.legend()
plt.grid(True)

# Третий график
plt.subplot(2, 2, 3)
plt.plot(x, y3, color="green", linestyle="-.", label ="tan(x)")
plt.title("График tan(x)")
plt.xlabel("x")
plt.ylabel("y")
plt.legend()
plt.grid(True)

# Третий график
plt.subplot(2, 2, 4)
plt.plot(x, y3, color="yellow", linestyle="-.", label ="cotan(x)")
plt.title("График cot(x)")
plt.xlabel("x")
plt.ylabel("y")
plt.legend()
plt.grid(True)

plt.show()