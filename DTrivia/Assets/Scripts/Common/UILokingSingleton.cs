using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILokingSingleton : MonoBehaviour {

    public GameObject _PanelActivity;

    public int rSize = 0, cSize = 0;

    private AsyncOperation asyncOp = null;
    private static volatile UILokingSingleton instance;    

    public static UILokingSingleton Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance)
        {
            DestroyImmediate(gameObject);
            return;
        }
        ComponentRegister.Init();
        instance = this;
        DontDestroyOnLoad(gameObject);
        _PanelActivity.SetActive(false);
    }
	
    public void OpenLevel(int Level)
    {
        ShowProgress();
        asyncOp = SceneManager.LoadSceneAsync(Level);
        Load();

    }

    public void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
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
