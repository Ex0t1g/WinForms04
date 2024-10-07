


namespace WinForms04;

public class City : Elemnts_
{
    public IReadOnlyList<Street> streets { get; }

    public City(string name, IReadOnlyList<Street> streets) : base(name)
    {
        this.streets = streets;
    }

    public override void FillCombo(ComboBox comboBox)
    {
        comboBox.Items.Clear();
        foreach (Street street in streets)
        {
            comboBox.Items.Add(street);
        }
    }
}
