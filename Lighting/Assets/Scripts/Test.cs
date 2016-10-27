using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Test : MonoBehaviour {
  private Object[] publicObjects;
  
  public void OnClickAssetBundleLoad()
  {
    StartCoroutine(LoadAssetBundle());
  }


  IEnumerator LoadAssetBundle()
  {
    
    Debug.Log("file://" + Application.streamingAssetsPath + "/Android/test/light");
    
    WWW lightwww = new WWW("file://" + Application.streamingAssetsPath + "/Android/test/light");
    
    yield return lightwww;
    
    AssetBundle bundle = lightwww.assetBundle;
    
    Object[] objects = bundle.LoadAllAssets();
    
    foreach (Object obj in objects)
    {
      Debug.Log("obj=" + obj.name);
      Debug.Log("objtype=" + obj.GetType().ToString());
    }

    publicObjects = objects;
    Debug.Log("Light");

    Debug.Log("file://" + Application.streamingAssetsPath + "/Android/test/scene");

    WWW scenewww = new WWW(Application.streamingAssetsPath +  "/Android/test/scene");

    yield return scenewww;

    AssetBundle scenebundle = scenewww.assetBundle;

    Debug.Log("LoadScene");
    SceneManager.LoadSceneAsync("LightingScene", LoadSceneMode.Additive);
  }
}
