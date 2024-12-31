using UnityEngine;
public class FriendlyNPC : NPC
{
    public override void Speak()
    {
        Debug.Log($"{Name} greets you warmly and offers help.");
    }

    public void Trade()
    {
        if (CurrentState != State.Dead)
            Debug.Log($"{Name} is trading items with you.");
    }
}

public class EnemyNPC : NPC
{
    public override void Speak()
    {
        Debug.Log($"{Name} growls menacingly and prepares to attack!");
    }

    public void Attack(NPC target)
    {
        if (CurrentState != State.Dead && target.CurrentState != State.Dead)
        {
            CurrentState = State.Attacking;
            Debug.Log($"{Name} attacks {target.Name}!");
            target.TakeDamage(20);
        }
    }
}
