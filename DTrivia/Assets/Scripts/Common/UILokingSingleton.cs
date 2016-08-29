using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILokingSingleton : MonoBehaviour {

    public GameObject _PanelActivity;

    private AsyncOperation asyncOp = null;
    private static volatile UILokingSingleton instance;
    private static object _locker = new Object();

    public static UILokingSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (_locker)
                {
                    if (instance == null) instance = SingletonInit();
                }
            }
            return instance;
        }
    }

    void Awake()
    {
        _PanelActivity.SetActive(false);
    }

    private static UILokingSingleton SingletonInit()
    {
        GameObject SingletonObject = new GameObject("UISingleton");
        DontDestroyOnLoad(SingletonObject);
        return SingletonObject.AddComponent<UILokingSingleton>();
    }
	
    public void OpenLevel(int Level)
    {
        ShowProgress();
        asyncOp = SceneManager.LoadSceneAsync(Level);
        Load();

    }

    void OnLevelWasLoaded(int Level)
    {
        HideProgress();
    }

    IEnumerator Load()
    {
        // Funcion asincrona de cargado del nivel
        yield return asyncOp;
    }

    public void ShowProgress()
    {
        _PanelActivity.gameObject.SetActive(true);
    }

    public void HideProgress()
    {
        _PanelActivity.gameObject.SetActive(false);
    }

}
