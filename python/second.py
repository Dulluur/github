import os

def find_ldraw(start_paths):
    results = []
    for start_path in start_paths:
        for root, dirs, files in os.walk(start_path):
            # Проверяем, есть ли в папке нужные подпапки
            if "parts" in dirs and "p" in dirs:
                results.append(root)
    return results

if __name__ == "__main__":
    # Пути, где будем искать
    search_paths = [
        "C:\\LDraw",
        "C:\\Program Files",
        "C:\\Program Files (x86)",
        "C:\\Users",
        "C:\\ProgramData",
        "D:\\",  # если есть второй диск
        "E:\\"
    ]

    found = find_ldraw(search_paths)

    if found:
        print("Найдены папки LDraw:")
        for path in found:
            print(path)
    else:
        print("Папка LDraw не найдена. Попробуй распаковать библиотеку вручную в C:\\LDraw.")
