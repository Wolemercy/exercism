abstract class Character
{
    protected string _characterType = String.Empty;
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base(nameof(Warrior))
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool _hasPreparedSpell = false;
    public Wizard() : base(nameof(Wizard))
    {
    }

    public override int DamagePoints(Character target) => _hasPreparedSpell ? 12 : 3;

    public override bool Vulnerable() => !_hasPreparedSpell;

    public void PrepareSpell()
    {
        _hasPreparedSpell = true;
    }
}
