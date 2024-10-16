from os import path

with open('text.txt') as test_file:
    print(test_file.read)

with open('text.txt', 'a') as new_file:
    new_file.write("First")

with open('text.txt') as new_file:
    print(new_file.read())

