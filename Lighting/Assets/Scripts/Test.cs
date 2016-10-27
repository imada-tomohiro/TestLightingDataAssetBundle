using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Test : MonoBehaviour {
  private Object[] publicObjects;
  
  public void OnClickAssetBundleLoad()
  {
    Debug.Log("LoadScene");
    SceneManager.LoadSceneAsync("LightingScene", LoadSceneMode.Additive);
  }
}
