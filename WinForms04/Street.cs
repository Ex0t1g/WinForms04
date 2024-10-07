

namespace WinForms04;
public class Street : Elemnts_
{
    public IReadOnlyList<Building> Buildings { get; }

    public Street(string name, IReadOnlyList<Building> buildings) : base(name)
    {
        Buildings = buildings;
    }

    public override void FillCombo(ComboBox comboBox)
    {
        comboBox.Items.Clear();
        foreach (Building building in Buildings)
        {
            comboBox.Items.Add(building);
        }
    }
}
