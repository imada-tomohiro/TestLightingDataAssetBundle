using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Test : MonoBehaviour {
  private Object[] publicObjects;
  
  public void OnClickAssetBundleLoad(bool isAdditive)
  {
    Debug.Log("LoadScene");
    if(isAdditive){
      SceneManager.LoadSceneAsync("LightingScene", LoadSceneMode.Additive);
    }else{
      SceneManager.LoadSceneAsync("LightingScene");
    }
  }
}
