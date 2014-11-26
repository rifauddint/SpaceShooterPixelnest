using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {


    public float speed;
    public float direction;

    

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {

        float movement = speed * Time.deltaTime * direction;
        for(int i = 0 ; i < transform.childCount ; i++)
        {
            Transform child = transform.GetChild(i);
            child.Translate(movement, 0, 0);

            if (child.position.x <= -20) { 
                child.position = new Vector3(20,0,0);
            }
        }

	}
}
