import time
import requests
from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager

# Настройки браузера
options = webdriver.ChromeOptions()
options.add_argument("--headless")  # Без графического интерфейса (можно убрать)

# Запускаем Selenium с автоматическим драйвером
driver = webdriver.Chrome(service=Service(ChromeDriverManager().install()), options=options)

# Открываем сайт
driver.get("https://eda.ykt.ru/")
time.sleep(5)  # Даем время на загрузку

# Получаем cookies
cookies = driver.get_cookies()

# Закрываем браузер, он больше не нужен
driver.quit()

# Создаём сессию requests и добавляем cookies
session = requests.Session()
for cookie in cookies:
    session.cookies.set(cookie['name'], cookie['value'])

# Делаем запрос к API
url = "https://eda.ykt.ru/v5/api/basic?cityId=51"
headers = {
    "User-Agent": "Mozilla/5.0 (iPhone; CPU iPhone OS 16_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.6 Mobile/15E148 Safari/604.1",
    "Referer": "https://eda.ykt.ru/",
    "Origin": "https://eda.ykt.ru"
}

response = session.get(url, headers=headers)

# Выводим результат
if response.status_code == 200:
    print("✅ Данные с API получены!")
    print(response.json())  # Выводим JSON-ответ
else:
    print(f"❌ Ошибка: {response.status_code} - {response.text}")
