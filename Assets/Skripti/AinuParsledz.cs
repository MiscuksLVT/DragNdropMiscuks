using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void Spelet()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Additive);

    }
}
