
using UnityEngine;

public class Target : MonoBehaviour
{
   
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
