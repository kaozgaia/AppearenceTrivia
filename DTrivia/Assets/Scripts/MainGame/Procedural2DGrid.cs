using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Model;

public class Procedural2DGrid : MonoBehaviour {
    [SerializeField]
    private int rowSize, columnSize;
    private bool _lock;
    private float baseProb, probAdd;
    Sprite[] imgArray;

    public RectTransform panelRow;
    public GameObject gridCell;
    
    public Transform Grid;

    public void Init(int rSize, int cSize)
    {
        rowSize = rSize;
        columnSize = cSize;
        GenerateGrid();
    }

    void ClearGrid()
    {
        for (int i = 0; i < Grid.childCount; i++)
        {
            Destroy(Grid.GetChild(i).gameObject);
        }
    }

    void GenerateGrid()
    {
        _lock = false;
        ClearGrid();        
        GameObject cellInputField;
        RectTransform rowParent;
        imgArray = Resources.LoadAll<Sprite>("sdvSpriteSheet");
        baseProb = 0.08f;
        probAdd = Random.Range(0f, 0.1f);
        for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
        {
            rowParent = (RectTransform)Instantiate(panelRow);
            rowParent.transform.SetParent(Grid);
            rowParent.transform.localScale = Vector3.one;

            for (int colIndex = 0; colIndex < columnSize; colIndex++)
            {
                cellInputField = GenerateGameCell(gridCell, colIndex, rowIndex);
                cellInputField.transform.SetParent(rowParent);
                cellInputField.GetComponent<Transform>().localScale = Vector3.one;
            }
        }
    }

    GameObject GenerateGameCell(GameObject prefab, int colIndex, int rowIndex)
    {
        
        GameObject newCell = (GameObject)Instantiate(prefab);
        GridCellController _controller = newCell.GetComponent<GridCellController>();        
        if(!_lock)
        {
            float rand = Random.Range(0f, 1f);
            if (rand < baseProb)
            {
                _controller.Data.IsAssert = true;
                _lock = true;                
            }
            else
            {
                _controller.Data.IsAssert = false;
                probAdd = Random.Range(0f, 0.08f);
                baseProb += probAdd;
            }            
        }
        else
        {
            _controller.Data.IsAssert = false;
        }
        if (colIndex == (columnSize-1) && rowIndex == (rowSize-1) && !_lock)
        {
            _controller.Data.IsAssert = true;
        }


        if (_controller.Data.IsAssert)
        {
            Image imgRender = newCell.AddComponent<Image>();
            imgRender.preserveAspect = true;
            imgRender.sprite = imgArray[0];
            
        }
        else
        {
            Image imgRender = newCell.AddComponent<Image>();
            imgRender.preserveAspect = true;
            imgRender.sprite = imgArray[1];
            
        }
        
        return newCell;
    }

    
}
