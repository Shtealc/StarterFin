using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backhome : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadSceneAsync("start");
    }
}
