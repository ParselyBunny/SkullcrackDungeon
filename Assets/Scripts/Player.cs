using UnityEngine;

public class Player : MonoBehaviour
{
    public Stat Endurance { get; private set; }
    public Stat Skill { get; private set; }
    public Stat Luck { get; private set; }
    public Inventory Inventory;

    private readonly Race _race;
    private const int _HUMAN_RACIAL_BONUS = 3;
    private const int _ORC_RACIAL_BONUS = 2;
    private const int _ELF_RACIAL_BONUS = 2;
    private const int _STAT_BASE = 12;

    public Player(Race race)
    {
        _race = race;
        Endurance = new("ENDURANCE", Dice.Sum(Dice.D6(2)) + _STAT_BASE);
        Skill     = new("SKILL",     Dice.Sum(Dice.D6(1)) + _STAT_BASE);
        Luck      = new("LUCK",      Dice.Sum(Dice.D6(1)) + _STAT_BASE);

        switch (_race)
        {
            case Race.HUMAN:
                Endurance.AddBase(_HUMAN_RACIAL_BONUS);
                break;
            case Race.ORC:
                Skill.AddBase(_ORC_RACIAL_BONUS);
                break;
            case Race.ELF:
                Luck.AddBase(_ELF_RACIAL_BONUS);
                break;
        }

        Inventory = new();
    }
}
