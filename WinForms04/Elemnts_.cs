

namespace WinForms04;

public abstract class Elemnts_
{
    public string Name { get; }


    protected Elemnts_ (string name)
    {
        Name = name;
    }

    public override string ToString() => Name;

    public abstract void FillCombo(ComboBox comboBox);
}
