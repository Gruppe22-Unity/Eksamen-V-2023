using UnityEngine;

public class EnemyBoss : Enemy
{

    public int damage = 20; // Skade som fiendebossen p�f�rer

    private void Start()
    {
    }

    protected override void MoveDownward()
    {
        base.MoveDownward(); // Kaller baseklassens MoveDownward-metode
    }
}

