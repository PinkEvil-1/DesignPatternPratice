namespace DesignPatternPratice.Creational.Builder;

// Director: 固定建造流程
public class CharacterDirector
{
    public Character CreateKnight()
    {
        return new CharacterBuilder()
            .SetName("Knight")
            .SetHp(150)
            .SetAttack(30)
            .SetWeapon("Sword")
            .Build();
    }

    public Character CreateMage()
    {
        return new CharacterBuilder()
            .SetName("Mage")
            .SetHp(70)
            .SetAttack(50)
            .SetWeapon("Staff")
            .Build();
    }
}
