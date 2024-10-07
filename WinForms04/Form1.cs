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
               new Country("�������", new List<City>()
               {
                   new City("�����", new List<Street>()
                   {
                       new Street("������", new List<Building>()
                       {
                           new Building("1"),
                           new Building("2"),
                           new Building("3")
                       }),
                       new Street("����������", new List<Building>()
                       {
                           new Building("4"),
                           new Building("5"),
                           new Building("6")
                       }),
                       new Street("���������", new List<Building>()
                       {
                           new Building("7"),
                           new Building("8"),
                           new Building("9")
                       })
                   }),
                   new City("�������� TOP", new List<Street>()
                   {
                       new Street("�����������", new List<Building>()
                       {
                           new Building("2"),
                           new Building("2"),
                           new Building("2")
                       }),
                       new Street("����������� 2", new List<Building>()
                       {
                           new Building("2"),
                           new Building("2"),
                           new Building("2")
                       }),
                       new Street("����������� 3", new List<Building>()
                       {
                           new Building("2"),
                           new Building("2"),
                           new Building("2")
                       })
                   }),
                   new City("�����", new List<Street>()
                   {
                       new Street("�������", new List<Building>()
                       {
                           new Building("1"),
                           new Building("1"),
                           new Building("1")
                       }),
                       new Street("�����", new List<Building>()
                       {
                           new Building("1"),
                           new Building("1"),
                           new Building("1")
                       }),
                       new Street("������", new List<Building>()
                       {
                           new Building("1"),
                           new Building("1"),
                           new Building("1")
                       })
                   }),
               }),
               new Country("���������", new List<City>()
               {
                   new City("��� ����", new List<Street>()
                   {
                       new Street("�������", new List<Building>()
                       {
                           new Building("1"),
                           new Building("3"),
                           new Building("2")
                       }),
                       new Street("��������", new List<Building>()
                       {
                           new Building("9"),
                           new Building("9"),
                           new Building("9")
                       }),
                       new Street("������", new List<Building>()
                       {
                           new Building("0"),
                           new Building("0"),
                           new Building("0")
                       })
                   }),
                   new City("������", new List<Street>()
                   {
                       new Street("����� 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("���� 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("������ 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
                   new City("��������", new List<Street>()
                   {
                       new Street("����� 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("���� 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("������ 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
               }),
               new Country("��������", new List<City>()
               {
                   new City("CofePrice", new List<Street>()
                   {
                       new Street("����� 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("���� 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("������ 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
                   new City("����������", new List<Street>()
                   {
                       new Street("����� 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("���� 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("������ 2010", new List<Building>()
                       {
                           new Building("1"),
                           new Building("11"),
                           new Building("111")
                       })
                   }),
                   new City("������� �����", new List<Street>()
                   {
                       new Street("����� 2007", new List<Building>()
                       {
                           new Building("777"),
                           new Building("7"),
                           new Building("77")
                       }),
                       new Street("���� 2006", new List<Building>()
                       {
                           new Building("6"),
                           new Building("66"),
                           new Building("666")
                       }),
                       new Street("������ 2010", new List<Building>()
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
