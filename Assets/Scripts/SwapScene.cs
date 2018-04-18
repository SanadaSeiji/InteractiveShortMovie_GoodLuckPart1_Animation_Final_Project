using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour {

    public int SceneIndex;
    // the correct index:
    // 0: the chase and lost
    // 1: Starnger in Snow
    // 2: Magician appears
    // 3: flowers in winter and stars in darkness
    // 4: the magician dance
    // 5: a hat of candy
    // 6: world laghter in another project GL2

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneIndex); 
        }
		
	}
}
