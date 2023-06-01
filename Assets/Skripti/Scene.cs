using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour {

    public void Uzaskums()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    //Metode,kura aizver programmu, ja ta ir izveidota ka .exe

    public void Apturet()
    {
        Application.Quit();
    }

    //Pasiem jauztaisa metode,kas parsledzno sakuma uz UI ainu
    public void Game()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Additive);

    }
}
