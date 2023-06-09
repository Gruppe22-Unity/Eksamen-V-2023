using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100; // Helseverdien til fienden
    public float speed = 5f; // Hastigheten til fienden

    private void Update()
    {
        MoveDownward();
    }

    protected virtual void MoveDownward()
    {
        Vector3 newPosition = transform.position + Vector3.down * speed * Time.deltaTime;
        transform.position = newPosition;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        // Implementer logikk for fiendens død
        // F.eks. animasjon, lydeffekter, poeng etc.
        Destroy(gameObject);
    }
}

