using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnStartGame(string SceneName){
        //Application.LoadLevel(SceneName);
        SceneManager.LoadScene(SceneName);
    }
 
}
