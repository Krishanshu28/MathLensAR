using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCont : MonoBehaviour
{
  
  public void Mainmenu()
  {
    SceneManager.LoadScene("MainMenu");
  }

  public void ARScene()
  {
    SceneManager.LoadScene("ARScene");
  }

    public void TrigoAR()
  {
    SceneManager.LoadScene(2);
  }

  public void QuitApp()
  {
    Application.Quit();
  }
}
