import os

os.chdir(os.path.dirname(os.path.abspath(__file__)))


def read_settings(file_name):
    if not os.path.exists(file_name):
        return None
    settings = dict()
    with open(file_name, 'r') as file:
        for row in file:
            key, value = row.split(' ')
            settings[key] = value.strip()
    return settings


print(read_settings('text.txt'))
