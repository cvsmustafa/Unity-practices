using UnityEngine;
public class BossNPC : EnemyNPC
{
    public void SpecialAttack(NPC target)
    {
        if (CurrentState != State.Dead && target.CurrentState != State.Dead)
        {
            Debug.Log($"{Name} uses a devastating special attack on {target.Name}!");
            target.TakeDamage(50);
        }
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log($"The mighty boss {Name} has fallen!");
    }
}