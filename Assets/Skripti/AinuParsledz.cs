using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledz : MonoBehaviour {

	
	void Start () {
		
	}

    public void ReloadGame()
    {

        SceneManager.LoadScene("PilsetasAina");
    }

    public void Sakums()
    {

        SceneManager.LoadScene("Sakums");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Spelet()
    {
        SceneManager.LoadScene("PilsetasAina");

    }
}
