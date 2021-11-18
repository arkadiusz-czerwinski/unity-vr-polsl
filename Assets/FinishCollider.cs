using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public static int counter = 0;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Finish")
        {
            Destroy(collision.gameObject);
            counter++;
            if (counter == 9) {
                // Application.Quit();
                Application.LoadLevel(Application.loadedLevel);
                counter = 0;
            }
        }
    }
    
}
