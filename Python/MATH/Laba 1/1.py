import math


s = 0;
pi = math.pi;

for i in range(1, 10 ** 6 + 1, +1):
    s += pi/pow(i,2)
    if (i == 1 or i==2 or i == 10 ** 6-1):
        print(i, s)

print('Приближенное: ', s)


print('===================')
s2 = 0;

for i in range(10 ** 6, 0, -1):
    ##print(i)
    s2 += pi/pow(i,2)
    if (i == 1 or i==10 ** 5 or i == 10 ** 6-1):
        print(i, s2)
print('Точное: ')
print(s2)

print('Абсолютная погрешность: ')
print(abs(s - s2))

print('Относительная погрешность: ')
print(abs((s - s2)/s))