using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Utils;

public class GridCellController : MonoBehaviour {

    // Properties
    public List<GameObject> Components = new List<GameObject>();
    public GameObject AssertPanel;
    
    // Model
    public CellModel Data = new CellModel();

    private bool didSelect = false;

    void Awake()
    {
        
    }

    void Start()
    {
        didSelect = false;
    }

	public void CellClick()
    {
        if (didSelect) return;
        EndlessController.Instance.isReloadingGrid = true;
        if (Data.IsAssert) {
            // Ok Flow
            //EndlessController.Instance.ReloadGrid();
            AssertPanel.SetActive(true);
            AssertPanel.GetComponent<Image>().color = new Color32(13, 221, 14, 109);
            EndlessController.Instance.IncreaseScore();
        }
        else
        {
            // Bad Flow
            EndlessController.Instance.GRBox.GetComponent<GridCellController>().AssertPanel.SetActive(true);
            EndlessController.Instance.GRBox.GetComponent<GridCellController>().AssertPanel.GetComponent<Image>().color = new Color32(236, 69, 69, 109);
            EndlessController.Instance.DecreaseTime();
        }
        didSelect = true;
        StartCoroutine(WaitAndReloadGrid());

    }

    IEnumerator WaitAndReloadGrid()
    {
        yield return new WaitForSeconds(0.55f);
        EndlessController.Instance.ReloadGrid();
        didSelect = false;
    }

}
