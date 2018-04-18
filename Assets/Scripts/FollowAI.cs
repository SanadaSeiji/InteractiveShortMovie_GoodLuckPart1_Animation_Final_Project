using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour {

    public Transform Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(Target);
        if (Vector3.Distance (transform.position, Target.position) >= 25)
        {
            transform.Translate(Vector3.forward * 100 * Time.deltaTime);
        }
        

		
	}
}
