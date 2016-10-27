using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Test : MonoBehaviour {
  private Object[] publicObjects;
  
  public void OnClickAssetBundleLoad(bool isAdditive)
  {
    StartCoroutine(LoadAssetBundle(isAdditive));
  }


  IEnumerator LoadAssetBundle(bool isAdditive)
  {
    
    Debug.Log("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/light");
    
    WWW lightwww = new WWW("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/light");
    
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

    Debug.Log("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/scene");

    WWW scenewww = new WWW("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/scene");

    yield return scenewww;

    AssetBundle scenebundle = scenewww.assetBundle;

    Debug.Log("LoadScene");
    if(isAdditive){
      SceneManager.LoadSceneAsync("LightingScene", LoadSceneMode.Additive);
    }else{
      SceneManager.LoadSceneAsync("LightingScene");
    }
  }
}
