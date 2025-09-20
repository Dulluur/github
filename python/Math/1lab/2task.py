import numpy as np
import matplotlib.pyplot as plt


x = np.linspace(5, -5, 100)
y = np.linspace(5, -5, 100)
x,y = np.meshgrid(x,y)
z = np.sqrt(x**2 + y**2)


fig = plt.figure()
ax = fig.add_subplot(111, projection="3d")

# ax.plot_surface(x, y, z, cmap="inferno", label = "Бездна")
img = ax.plot_surface(x, y, z, cmap = "inferno")
fig.colorbar(img, label="Data Value")

plt.title('трехмерный вулкан')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.grid(True)

plt.show()