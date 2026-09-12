using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskWFA_2_4 {
  public partial class Form1 : Form {
    private string fileName = "people.xml";

    public Form1() {
      InitializeComponent();
    }

    private void buttonGenerate_Click_1(object sender, EventArgs e) {
      GeneratePeopleFile();
    }

    private void buttonFind_Click_1(object sender, EventArgs e) {
      FindPeopleByCity();
    }

    private void GeneratePeopleFile() {
      Random random = new Random();

      string[] surnames =
      {
                "Иванов",
                "Петров",
                "Сидоров",
                "Смирнов",
                "Кузнецов",
                "Попов",
                "Васильев",
                "Морозов",
                "Новиков",
                "Федоров"
            };

      string[] cities =
      {
                "Москва",
                "Санкт-Петербург",
                "Казань",
                "Самара",
                "Новосибирск",
                "Кемерово"
            };

      XElement people = new XElement("people");

      for (int i = 0; i < 20; i++) {
        string surname = surnames[random.Next(surnames.Length)];
        string city = cities[random.Next(cities.Length)];
        int age = random.Next(18, 71);

        XElement person = new XElement(
            "person",
            new XElement("surname", surname),
            new XElement("city", city),
            new XElement("age", age)
        );

        people.Add(person);
      }

      people.Save(fileName);

      MessageBox.Show(
          "Данные успешно сгенерированы и сохранены в файл people.xml.",
          "Готово",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
    }

     private void FindPeopleByCity()
        {
            string cityToFind = textCity.Text.Trim();

            if (cityToFind == "")
            {
                MessageBox.Show("Введите город.");
                return;
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show(
                    "Файл people.xml не найден. Сначала сгенерируйте данные.");
                return;
            }

            XDocument document = XDocument.Load(fileName);

            StringBuilder result = new StringBuilder();

            int count = 0;
            int totalAge = 0;

            foreach (XElement person in document.Root.Elements("person"))
            {
                string surname = person.Element("surname").Value;
                string city = person.Element("city").Value;
                int age = int.Parse(person.Element("age").Value);

                if (city.Equals(cityToFind, StringComparison.OrdinalIgnoreCase))
                {
                    result.AppendLine(
                        $"Фамилия: {surname}, Возраст: {age}");

                    count++;
                    totalAge += age;
                }
            }

            if (count == 0)
            {
                textResult.Text = "Люди указанного города не найдены.";
                textAverageAge.Text = "";
                return;
            }

            double averageAge = (double)totalAge / count;

            textResult.Text = result.ToString();
            textAverageAge.Text = averageAge.ToString("F2");
        }

    
  }
}
