
using UnityEngine;

public class Target : MonoBehaviour
{
   //object har ett visst hp och n�r den f�rlorar det s� f�rsvinner den
     public float Health = 100f;


    public void TakeDamage (float amount)
    {
        Health -= amount;
        if(Health <= 0f)
        {
            Die();
        }
    
        
        void Die()
        {
            Destroy(gameObject);
        }
    
    }
 





}
