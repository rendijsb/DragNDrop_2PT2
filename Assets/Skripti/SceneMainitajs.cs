using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMainitajs : MonoBehaviour {

    // Use this for initialization
    public void Sakums(){
        SceneManager.LoadScene (0, LoadSceneMode.Single);
    }
    public void Spele(){

            SceneManager.LoadScene (1, LoadSceneMode.Single);

    }
    

    //Metode , kura aizver programmu, ja tā ir izveidota kā .exe
    public void Apturet(){
        Application.Quit();
    }
}