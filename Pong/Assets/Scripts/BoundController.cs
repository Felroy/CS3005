using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroys gameobject if its tag is Ball
        if (other.gameObject.tag == "Ball")
        {
            if (this.transform.position.x >= 7) {
            ScoreScript.EnemyScore++;
            
            }
            if (this.transform.position.x <= -7) {
            ScoreScript.PlayerScore++;
            
            }
            Destroy(other.gameObject);
        

        
        }
        
            
        
    }
}
