using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStage1 : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Stage1");
    }
    public void StartGame2(){
        SceneManager.LoadScene("Stage2");
    }
}
