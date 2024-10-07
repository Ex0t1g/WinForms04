namespace WinForms04
{
    public partial class Form1 : Form
    {
        IReadOnlyList<Country> countries;
        public Form1()
        {
            InitializeComponent();
            countries = new List<Country>()
            {
               new Country("Нигерия", new List<City>()
               {
                   new City("Нигер", new List<Street>()
                   {
                       new Street("Ижевск", new List<Building>()
                       {
                           new Building("1"),
                           new Building("2"),
                           new Building("3")
                       }),
                       new Street("Мухосранск", new List<Building>()
                       {
                           new Building("4"),
                           new Building("5"),
                           new Building("6")
                       }),
                       new Street("Запородье", new List<Building>()
                       {
                           new Building("7"),
                           new Building("8"),
                           new Building("9")
                       })
                   }),
                   new City("Академия TOP", new List<Street>()
                   {
                       new Street("Кутузовский", new List<Building>()
                       {
                           new Building("2"),
                           new Building("2"),
                           new Building("2")
                       }),
                       new Street("Кутузовский 2", new List<Building>()
                       {
                           new Building("2"),
                           new Building("2"),
                           new Building("2")
                       }),
                       new Street("Кутузовский 3", new List<Building>()
                       {
                           new Building("2"),
                           new Building("2"),
                           new Building("2")
                       })
                   }),
                   new City("Авито", new List<Street>()
                   {
                       new Street("Луганск", new List<Building>()
                       {
                           new Building("1"),
                           new Building("1"),
                           new Building("1")
                       }),
                       new Street("Днепр", new List<Building>()
                       {
                           new Building("1"),
                           new Building("1"),
                           new Building("1")
                       }),
                       new Street("Одесса", new List<Building>()
                       {
                           new Building("1"),
                           new Building("1"),
                           new Building("1")
                       })
                   }),
               }),
               new Country("Финлядния", new List<City>()
               {
                   new City("Нью Йорк", new List<Street>()
                   {
                       new Street("Армения", new List<Building>()
                       {
                           new Building("1"),
                           new Building("3"),
                           new Building("2")
                       }),
                       new Street("Дагестан", new List<Building>()
                       {
                           new Building("9"),
                           new Building("9"),
                           new Building("9")
                       }),
                       new Street("Кавказ", new List<Building>()
                       {
                           new Building("0"),
                           new Building("0"),
                           new Building("0")
                       })
                   }),
                   new City("Египет", new List<Street>()
                   {
                       new Street("Анапа 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("Крым 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("Турция 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
                   new City("Смоленск", new List<Street>()
                   {
                       new Street("Анапа 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("Крым 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("Турция 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
               }),
               new Country("Баумская", new List<City>()
               {
                   new City("CofePrice", new List<Street>()
                   {
                       new Street("Анапа 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("Крым 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("Турция 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
                   new City("АлкоМаркет", new List<Street>()
                   {
                       new Street("Анапа 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("Крым 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("Турция 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
                   new City("Красное Белое", new List<Street>()
                   {
                       new Street("Анапа 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("Крым 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("Турция 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
               }),

            };
            foreach (Country country in countries)
            {
                comboBoxCountry.Items.Add(country);
            }

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.SelectedItem is null)
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                return;
            }
            Country currentCountry = (Country)comboBoxCountry.SelectedItem;
            currentCountry.FillCombo(comboBoxCity);
            panel2.Visible = true;
            if (comboBoxCity.SelectedItem == null)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                return;
            }
            City currentCity = (City)comboBoxCity.SelectedItem;
            currentCity.FillCombo(comboBoxStreet);
            panel3.Visible = true;

        }


        private void RefreshElements()
        {
            if (comboBoxStreet.SelectedItem == null)
            {
                panel4.Visible = false;
                return;
            }
            Street currentStreet = (Street)comboBoxStreet.SelectedItem;
            currentStreet.FillCombo(comboBoxBuilding);
            panel4.Visible = true;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCity.SelectedItem == null)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                return;
            }
            City currentCity = (City)comboBoxCity.SelectedItem;
            currentCity.FillCombo(comboBoxStreet);
            panel3.Visible = true;
        }

        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshElements();
        }
    }
}
