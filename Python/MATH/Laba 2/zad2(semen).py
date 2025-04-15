import math
import matplotlib.pyplot as plt
#import pyplotlib as plt

def okr(pi, n):
    s_exact = 0
    for i in range (n, 0, -1):
        s_exact += math.pi / pow(i,2)
    s = 0
    for i in range (n, 0, -1):
        s += pi / pow(i,2)
    abs_error = abs(s - s_exact)
    rel_error = abs((s - s_exact) / s)

    return s, s_exact, abs_error, rel_error

def metod_okr(pi, n):
    s_exact = 0
    for i in range(n, 0, -1):
        s_exact += math.pi / pow(i, 2)
    s = 0
    for i in range (1, n+1, +1):
        s += pi / pow(i,2)
    abs_error = abs(s - s_exact)
    rel_error = abs((s - s_exact) / s)

    return s, s_exact, abs_error, rel_error

pis = [
    3.14159265358979, #1
    3.141592653589,   #2
    3.1415926535,     #3
    3.14159265,       #4
    3.141592,         #5
    3.1415,           #6
    3.14,             #7
    3                 #8
]

n = 10**6

abs_errors = [] # абсолютные погрешности
rel_errors = [] # относительные погрешности
s_values = []
s_exacts = []

# print(math.pi)

print("===ОШИБКА ОКРУГЛЕНИЯ===")
for pi in pis:
    s, s_exact, abs_error, rel_error = okr(pi, n)
    abs_errors.append(abs_error)
    rel_errors.append(rel_error)
    s_values.append(s)
    s_exacts.append(s_exact)
    print(f"pi = {pi}")
    print('Приближенное значение:', s)
    print('Точное значение:', s_exact)
    print('Абсолютная погрешность:', abs_error)
    print('Относительная погрешность:', rel_error)
    print('===================')

plt.figure(figsize=(10,8))
plt.plot(range(1, 9), abs_errors, marker='o', linestyle='-', color = 'green', label='Абсолютная погрешность')
plt.plot(range(1, 9), rel_errors, marker='o', linestyle='-', color = 'red', label='Относительная погрешность')
plt.yscale('log')  # Логарифмическая шкала для оси Y
plt.title('Ошибка округления (логарифмическая шкала)')
plt.grid(True)  # добавляем сетку
plt.xticks(rotation=45, ha='right') # поворачиваем подписи оси X для читабельности
plt.tight_layout()  # автоматически меняет параметры расположения, чтобы график помещался на экране
plt.legend()
plt.show(block = False)



#2 ГРАФИК
abs_errors2 = []
rel_errors2 = []
s_values2 = []
s_exacts2 = []

print("===МЕТОДОЛОГИЧЕСКАЯ ОШИБКА + ОКРУГЛЕНИЯ===")
for pi in pis:
    s, s_exact, abs_error, rel_error = metod_okr(pi, n)
    abs_errors2.append(abs_error)
    rel_errors2.append(rel_error)
    s_values2.append(s)
    s_exacts2.append(s_exact)

    print(f"pi = {pi}")
    print('Приближенное значение:', s)
    print('Точное значение:', s_exact)
    print('Абсолютная погрешность:', abs_error)
    print('Относительная погрешность:', rel_error)
    print('===================')

plt.figure(figsize=(10,8))
plt.plot(range(1, 9), abs_errors2, marker='o', linestyle='-', color = 'green', label='Абсолютная погрешность')
plt.plot(range(1, 9), rel_errors2, marker='o', linestyle='-', color = 'red', label='Относительная погрешность')
plt.yscale('log')  # Логарифмическая шкала для оси Y
plt.title('Методологическая ошибка + округления (логарифмическая шкала)')
plt.grid(True)  # добавляем сетку
plt.xticks(rotation=45, ha='right') # поворачиваем подписи оси X для читабельности
plt.tight_layout()  # автоматически меняет параметры расположения, чтобы график помещался на экране
plt.legend()
plt.show(block = False)



#3 ГРАФИК
abs_errors3 = []
rel_errors3 = []
s_values3 = []
s_exacts3 = []
for i in range (0, 8):
    abs_errors3.append(abs_errors2[i] - abs_errors[i])
    rel_errors3.append(rel_errors2[i] - rel_errors[i])
    s_values3.append(s_values2[i] - s_values[i])
    s_exacts3.append(s_exacts2[i] - s_exacts[i])

plt.figure(figsize=(10,8))
plt.plot(range(1, 9), abs_errors3, marker='o', label='Абсолютная погрешность')
plt.plot(range(1, 9), rel_errors3, marker='s', label='Относительная погрешность')
plt.title('Методологическая ошибка + разница округления в зависимости от метода')
plt.grid(True)  # добавляем сетку
plt.xticks(rotation=45, ha='right') # поворачиваем подписи оси X для читабельности
plt.tight_layout()  # автоматически меняет параметры расположения, чтобы график помещался на экране
plt.legend()
plt.show()