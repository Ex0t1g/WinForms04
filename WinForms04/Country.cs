


namespace WinForms04;

public class Country : Elemnts_
{
    public Country(string name, IReadOnlyList<City> cities) : base(name)
    {
        Cities = cities;
    }

    public IReadOnlyList<City> Cities { get; }

    public override void FillCombo(ComboBox comboBox)
    {
        comboBox.Items.Clear();
        foreach (City city in Cities)
        {
            comboBox.Items.Add(city);
        }
    }
}
