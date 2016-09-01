using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Procedural2DGrid : MonoBehaviour {
    [SerializeField]
    private int rowSize, columnSize;

    public RectTransform panelRow;
    public GameObject gridCell;

    public Transform Grid;

    public void Init(int rSize, int cSize)
    {
        rowSize = rSize;
        columnSize = cSize;
    }

    void ClearGrid()
    {
        for (int i = 0; i < Grid.childCount; i++)
        {
            Destroy(Grid.GetChild(i).gameObject);
        }
    }

    public void GenerateGrid()
    {
        ClearGrid();
        Init(4,4);
        GameObject cellInputField;
        RectTransform rowParent;
        for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
        {
            rowParent = (RectTransform)Instantiate(panelRow);
            rowParent.transform.SetParent(Grid);
            rowParent.transform.localScale = Vector3.one;
            for (int colIndex = 0; colIndex < columnSize; colIndex++)
            {
                cellInputField = (GameObject)Instantiate(gridCell);
                cellInputField.transform.SetParent(rowParent);
                cellInputField.GetComponent<Transform>().localScale = Vector3.one;
            }
        }
    }

	// Use this for initialization
	void Start () {
        GenerateGrid();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
