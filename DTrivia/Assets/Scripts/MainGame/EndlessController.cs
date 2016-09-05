using UnityEngine;
using System.Collections;

public class EndlessController : MonoBehaviour {
    [SerializeField]
    private GameObject CanvasController;
    private Procedural2DGrid ProceduralGrid;

	// Use this for initialization
	void Start () {
        ProceduralGrid = CanvasController.GetComponent<Procedural2DGrid>();
        InitGame();
	}

    private void InitGame()
    {
        ProceduralGrid.Init(UILokingSingleton.Instance.rSize, UILokingSingleton.Instance.cSize);
    }
}
