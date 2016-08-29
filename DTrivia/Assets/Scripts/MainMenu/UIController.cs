using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Utils;

public class UIController : MonoBehaviour {

    public void GoMainGame()
    {
        UILokingSingleton.Instance.OpenLevel((int)PublicEnum.eLevel.MainMenu);
    }
	
}
