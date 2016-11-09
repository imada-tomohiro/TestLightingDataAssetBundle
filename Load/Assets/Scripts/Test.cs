using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour {
  private Object[] publicObjects;
  
  public void OnClickAssetBundleLoad(bool isAdditive)
  {
    StartCoroutine(LoadAssetBundle(isAdditive));
  }


  IEnumerator LoadAssetBundle(bool isAdditive)
  {
    
    /*    Debug.Log("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/light");
    
    WWW lightwww = new WWW("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/light");
    
    yield return lightwww;
    
    AssetBundle bundle = lightwww.assetBundle;
    
    Object[] objects = bundle.LoadAllAssets();
    

    objs.AddRange(objects);*/
    List<Object> objs = new List<Object>();
    
    Debug.Log("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/skybox");
    
    WWW skyboxwww = new WWW("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/skybox");
    
    yield return skyboxwww;
    
    AssetBundle skyboxbundle = skyboxwww.assetBundle;
    
    Object[] skyboxes = skyboxbundle.LoadAllAssets();
    
    objs.AddRange(skyboxes);
    publicObjects = objs.ToArray();

    Debug.Log(skyboxes.Length);
    foreach (Object obj in publicObjects)
    {
      Debug.Log("obj=" + obj.name);
      Debug.Log("objtype=" + obj.GetType().ToString());
    }


    Debug.Log("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/scene");

    WWW scenewww = new WWW("file://" + Application.streamingAssetsPath.Replace("/Load/", "/Lighting/") + "/Android/test/scene");

    yield return scenewww;

    AssetBundle scenebundle = scenewww.assetBundle;

    Debug.Log("LoadScene");
    if(isAdditive){
      yield return SceneManager.LoadSceneAsync("LightingScene", LoadSceneMode.Additive);

    }else{
      SceneManager.LoadSceneAsync("LightingScene");
    }
  }

  public void hoge(){
    SceneManager.SetActiveScene (SceneManager.GetSceneByName ("LightingScene"));
  }
}

