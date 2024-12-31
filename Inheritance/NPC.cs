using UnityEngine;

public abstract class NPC
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;

    public enum State
    {
        Idle,
        Walking,
        Attacking,
        Dead
    }

    public State CurrentState { get; protected set; } = State.Idle;

    public virtual void Speak()
    {
        Debug.Log($"{Name} says something generic.");
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            CurrentState = State.Dead;
            Die();
        }
        else
        {
            Debug.Log($"{Name} took {damage} damage. Health remaining: {Health}");
        }
    }

    protected virtual void Die()
    {
        Debug.Log($"{Name} has died.");
    }
}
