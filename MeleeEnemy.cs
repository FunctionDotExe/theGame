using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    public float stopDistance;

    private float attackTime;

    public float attackSpeed;   

    private void Update()
    {

        if (player != null)
        {

            if (Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            }

            player.GetComponent<PlayerMovement>().TakeDamage(damage);

            Vector2 originalPosition = transform.position;
            Vector2 targetPosition = player.position;

        }






    }


   


}
