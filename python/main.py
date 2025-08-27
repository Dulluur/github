import os
from PIL import Image
import pillow_heif

def convert_heic_to_jpeg(input_folder, output_folder=None):
    if output_folder is None:
        output_folder = input_folder

    if not os.path.exists(output_folder):
        os.makedirs(output_folder)

    for filename in os.listdir(input_folder):
        if filename.lower().endswith(".heic"):
            heic_path = os.path.join(input_folder, filename)
            jpeg_filename = os.path.splitext(filename)[0] + ".jpg"
            jpeg_path = os.path.join(output_folder, jpeg_filename)

            try:
                heif_file = pillow_heif.read_heif(heic_path)
                image = Image.frombytes(
                    heif_file.mode,
                    heif_file.size,
                    heif_file.data
                )
                image.save(jpeg_path, "JPEG")
                print(f"[✓] Конвертировано: {filename} → {jpeg_filename}")
            except Exception as e:
                print(f"[!] Ошибка при конвертации {filename}: {e}")

if __name__ == "__main__":
    input_dir = "C:\\Users\\Du\\Downloads\\Telegram Desktop\\фото\\фото\\Новые (добавили)\\3 торс"
    convert_heic_to_jpeg(input_dir)
