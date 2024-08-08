# a = 13
# b = 13,23
# c = 1 + 2j
# d = 'alpha' + 'b'
# e = True
# f = a
# print(d)

# # int
# a = 10
# print(type(a))  # <class 'int'>

# # float
# b = 20.5
# print(type(b))  # <class 'float'>

# # complex
# c = 1 + 2j
# print(type(c))  # <class 'complex'>

# # bool
# d = True
# print(type(d))  # <class 'bool'>

# # str (строка): Представляет последовательность символов (текст).
# e = "Hello, World!"
# print(type(e))  # <class 'str'>

# # list (список): Представляет изменяемую последовательность элементов.
# f = [1, 2, 3, 4, 5]
# print(type(f))  # <class 'list'>

# # tuple (кортеж): Представляет неизменяемую последовательность элементов.
# g = (1, 2, 3, 4, 5)
# print(type(g))  # <class 'tuple'>

# # set (множество): Представляет неупорядоченную коллекцию уникальных элементов.
# h = {1, 2, 3, 4, 5}
# print(type(h))  # <class 'set'>

# #range (диапазон): Представляет неизменяемую последовательность чисел, обычно используется в циклах.
# o = range(1, 10)
# print(type(o))

# # dict
# j = {"name": "Alice", "age": 30}
# print(type(j))  # <class 'dict'>


# pomo = range(10, 20, 3)

# for n in pomo:
#     print(n)

# my_pomo = range(5)
# print(my_pomo[4])

# a = "hello world!"
# print(a[0])

# list1 = [1,2,3]
# list2 = [100, 200, 300]
# list3 = ["apple", "banana", "strawberry"]

# total_list_zip = zip(list1, list3)
# print(total_list_zip)

# total_list = dict(total_list_zip)
# print(total_list)


# def my_fn(a, b):
#     a = a + 1
#     c = a + b
#     return c

# a = int(input())
# b = int(input())

# print(my_fn(a,b))

# person = {
#     'name':'Liza',
#     'age': 42
# }

# def incre_person_age(person):
#     person['age'] += 1
#     return person

# person_one = {
#     'name': 'Bob',
#     'age': 21
# }

# incre_person_age(person_one)
# print(person_one['age'])
# print(person)

# def increasd_person_age(person):
#     person_copy = person.copy()
#     person_copy['age'] += 1
#     return person_copy

# person_one = {
#     'name': 'Bob',
#     'age': 21
# }

# new_person = increasd_person_age(person_one)
# print(new_person['age'])
# print(person_one['age'])


# def merge_lists_to_dict(a,b):
#     new_list_zip = zip(a,b)
#     new_list = dict(new_list_zip)
#     return new_list

# a = {1,2,3}
# b = {'banana', 'apple', 'strawberry'}

# print(merge_lists_to_dict(a,b))


# def other_fn():
#     pass

# def fn_with_callback(callback_fn):
#     callback_fn()

# fn_with_callback(other_fn)


# def print_number_info(num):
#     if (num % 2) == 0:
#         print("Entered number is even")
#     else:
#         print("Entered number is odd")


# def process_number(num, callback_fn):
#     callback_fn(num)


# entered_num = int(input("Enter any number: "))
# process_number(entered_num, print_number_info)


# def mult_by_factor(value, mult = 1):
#     return value * mult

# mult_by_factor(5)

# def my_fn():
#     global a
#     a = True
#     b = 15
#     print(a)
#     print(b)

# my_fn()
# print(a)

# c = 5
# def my_fn(a,b):
#     d = 123
#     print(c)
#     print(a,b)
#     print(dir())
# my_fn(3,5)

# set1 = {1,2,3,4}
# set2 = {1,2,3,4}

# print(set1 == set2)
# print(set1 is set2)
# print(1 in set1)

# my_list = [1,2]
# if len(my_list) > 3:
#     print('1')
# if my_list:
#     print(2)

# my_list = [1,2]
# other_list = ['a', 'b']
# print(my_list and other_list)


# button_info = {
#     'text': 'Buy'
# }

# button_style = {
#     'color': 'Yellow',
#     'width': 200,
#     'height': 300
# }

# button = button_info | button_style
# print(button)

# my_list = [1, 2]
# del my_list[0]
# print(my_list[0])

# hello = "hello"
# world = "world"

# greeting = f"{hello} {world}"
# print(greeting)

# my_name = 'Bogdan'
# my_hobby = 'running'
# time = 8

# info = my_name + ' likes ' + my_hobby + ' at ' + str(time) + ' o\'clock '
# info = f"{my_name} likes {my_hobby} at {str(time)} o\'clock"
# print(info)

# try:
#     print(10 / 2)
# except ZeroDivisionError:
#     print("Error now")
# except TypeError:
#     print("Type error")
# else:
#     print("there was no error")
# finally:
#     print("WHAT?")

# try:
#     print(10 / 0)
# except Exception as e:
#     print(e)


# my_fruits = ['apple', 'banana', 'lime']

# my_apple = my_fruits[0]
# my_banana = my_fruits[1]
# my_lime = my_fruits[2]

# my_apple, my_banana, my_lime = my_fruits

# print(my_apple)
# print(my_banana)
# print(my_lime)

# user_profile = {
#     'name': 'Du',
#     'comments_qty': 23,
# }

# def user_info(name, comments_qty = 0):
#     if not comments_qty:
#         return f"{name} has no comments"
    
#     return f"{name} has {comments_qty} comments"

# name, comments_qty = user_profile
# print(name)
# print(comments_qty)

# person_info = {
#     'age': 20
# }
# if not person_info.get("name"):
#     print("No name")

# num_one = 1
# num_two = 5

# if(num_one > 0 and 
#    num_two > 0 and 
#    isinstance(num_one, int) and 
#        isinstance(num_two, int)): 
#    print("YES")

# my_number = 2.5

# if type(my_number) is int:
#     print(my_number, 'is integer')
# else:
#     print(my_number, 'is not an integer')

# my_phone = {
#     'price': 200,
#     'brand': "samsung"
# }

# if my_phone.get('brand'):
#     print("Phone's brand is", my_phone['brand'])
# else:
#     print("There is no phone brand")

# my_number = -10
# my_number = 20

# if my_number > 0:
#     print(my_number, "1")
# elif my_number < 0:
#     print(my_number, "2")
# elif my_number == 0:
#     print(my_number, "3")
# else:
#     print("what?")

# def nums_info(a,b):
#     if(type(a) is not int) or (type(b) is not int):
#         return "Один из аргументов не целое число"
    
#     if a>=b:
#         return f"{a} больше или равно {b}"
#     return f"{a} меньше {b}"

# a = int(input())
# b = int(input())

# result = nums_info(a,b)
# print(result)

# def route_info(route):
#     if "distance" in route and isinstance(route['distance'], int):
#         return f"Distance to your destination is {route['distance']}"
#     elif 'speed' in route and 'time' in route:
#         distance = route['speed'] * route['time']
#         return f"Distance to your destination is {distance}"
#     else:
#         return "No distance info is available"
    
# route1 = {'distance': 120}
# print(route_info(route1))  

# route2 = {'speed': 60, 'time': 2}
# print(route_info(route2)) 

# route3 = {'speed': 60}
# print(route_info(route3))  

# route4 = {'distance': 'far'}
# print(route_info(route4)) 

# route5 = {}
# print(route_info(route5))  

# my_number = 21.5

# print('is int') if type(my_number) is int else print("is not int")

# my_dick = "soo big"
# print('is not draw') if type(my_dick) is int else print('it is')

# product_qty = 10
# print("in stock" if product_qty > 0 else "out of stock")


# my_img = ('1920', '1080', False)
# info = (f"{my_img[0]}x{my_img[1]}") if len(my_img) == 2 else print("Incorrect image formatting")
# print(info)

