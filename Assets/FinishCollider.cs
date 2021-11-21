using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishCollider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public static int counter = 0;
    public static GameObject counterObject;
    public static TextMesh counterElement;

    public AudioSource source;
    public AudioClip brekSource;

    void Start()
    {
        counterObject = GameObject.FindGameObjectWithTag("Counter");

    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Finish")
        {
            source.PlayOneShot(brekSource);
            counter++;
            if(counterObject != null) {
                counterElement = counterObject.GetComponent<TextMesh>();
                counterElement.text = counter.ToString() + "/9";
            }
            if (counter == 9) {
                // Application.Quit();
                Application.LoadLevel(Application.loadedLevel);
                counter = 0;
            }
            Destroy(collision.gameObject);

        }
    }
    
}
