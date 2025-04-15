using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Laba1.Libraries
{
    public static class StudentsProcessor // ← Название класса должно совпадать с вызовом!
    {
        public static List<string> ReadStudentsFromFile(string filePath)
        {
            var students = new List<string>();

            if (File.Exists(filePath))
            {
                students = File.ReadAllLines(filePath)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line => line.Trim())
                    .ToList();
            }

            return students;
        }

        public static (int maxCount, List<string> mostCommonNames) FindMaxTeski(List<string> students)
        {
            var nameCounts = new Dictionary<string, int>();

            foreach (var student in students)
            {
                var parts = student.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 3)
                {
                    var firstName = parts[1];
                    var middleName = parts[2];

                    if (nameCounts.ContainsKey(firstName))
                        nameCounts[firstName]++;
                    else
                        nameCounts[firstName] = 1;

                    if (nameCounts.ContainsKey(middleName))
                        nameCounts[middleName]++;
                    else
                        nameCounts[middleName] = 1;
                }
            }

            if (nameCounts.Count == 0)
                return (0, new List<string>());

            int maxCount = nameCounts.Values.Max();
            var mostCommonNames = nameCounts
                .Where(x => x.Value == maxCount)
                .Select(x => x.Key)
                .ToList();

            return (maxCount, mostCommonNames);
        }

        public static void OpenFileAndShowResult()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                Title = "Выберите файл студентов"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var students = ReadStudentsFromFile(openFileDialog.FileName);
                var (maxCount, mostCommonNames) = FindMaxTeski(students);

                string studentsList = string.Join(Environment.NewLine, students);

                string resultMessage = studentsList + Environment.NewLine + Environment.NewLine;

                if (maxCount <= 1)
                {
                    resultMessage += "Тёзок нет";
                }
                else
                {
                    resultMessage += $"Максимальное число тёзок: {maxCount}\n" +
                                     $"Наиболее распространённые имена/отчества: {string.Join(", ", mostCommonNames)}";
                }

                MessageBox.Show(resultMessage, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Файл не выбран.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
