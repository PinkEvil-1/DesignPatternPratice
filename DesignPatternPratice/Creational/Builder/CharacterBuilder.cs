namespace DesignPatternPratice.Creational.Builder;

public class CharacterBuilder
{
    private Character _character = new Character();

    public CharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder SetHp(int hp)
    {
        _character.Hp = hp;
        return this;
    }

    public CharacterBuilder SetAttack(int attack)
    {
        _character.Attack = attack;
        return this;
    }

    public CharacterBuilder SetWeapon(string weapon)
    {
        _character.Weapon = weapon;
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}
