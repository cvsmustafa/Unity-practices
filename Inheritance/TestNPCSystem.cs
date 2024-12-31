using UnityEngine;

public class TestNPCSystem : MonoBehaviour
{
    void Start()
    {
        FriendlyNPC ally = new FriendlyNPC { Name = "Ally" };
        EnemyNPC enemy = new EnemyNPC { Name = "Foe" };
        BossNPC boss = new BossNPC { Name = "Doomlord" };

        ally.Speak();
        ally.Trade();

        enemy.Speak();
        enemy.Attack(ally);

        boss.Speak();
        boss.Attack(ally);
        boss.SpecialAttack(ally);
    }
}
