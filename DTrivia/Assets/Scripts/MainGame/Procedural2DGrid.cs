using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Procedural2DGrid : MonoBehaviour {
    [SerializeField]
    private int rowSize, columnSize;
    private bool _lock;
    private float baseProb, probAdd;
    private ComponentRegister Components;    
    //private int referenceType = 0;
    //private bool referenceChange = false;
    private List<int> registeredComponents = new List<int>();
    private List<int> registeredComponentsGoodChoice = new List<int>();
    //Sprite[] imgArray;

    public RectTransform panelRow;
    public GameObject gridCell;
    
    public Transform Grid;

    public void Init(int rSize, int cSize)
    {
        rowSize = rSize;
        columnSize = cSize;
        Components = new ComponentRegister();         
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
        registeredComponents = new List<int>();
        registeredComponentsGoodChoice = new List<int>();
        //Arreglo con datos de opciones equivicadas
        GenerateMultiImageObject(true);
        //Arreglo con datos de la unica opcion valida
        GenerateMultiImageObject(false);


        _lock = false;
        ClearGrid();        
        GameObject cellInputField;
        RectTransform rowParent;
        //imgArray = Resources.LoadAll<Sprite>("sdvSpriteSheet");
        if(rowSize == 2 && columnSize == 2)
        {
            baseProb = 0.3f;
            probAdd = Random.Range(0.1f, 0.15f);
        }
        else if (rowSize == 3 && columnSize == 3)
        {
            baseProb = 0.08f;
            probAdd = Random.Range(0.06f, 0.09f);
        }
        else
        {
            baseProb = 0.15f;
            probAdd = Random.Range(0f, 0.1f);
        }        
        
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
                baseProb += Random.Range(0f, probAdd);
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
            for(int i = 0; i < registeredComponentsGoodChoice.Count; i++)
            {
                Image imgRender = _controller.Components[i].AddComponent<Image>();
                imgRender.preserveAspect = true;
                imgRender.sprite = Resources.Load<Sprite>(ComponentRegister.GeneralRegister[i][registeredComponentsGoodChoice[i]]);                
            }
            
            
        }
        else
        {
            for (int i = 0; i < registeredComponents.Count; i++)
            {
                Image imgRender = _controller.Components[i].AddComponent<Image>();
                imgRender.preserveAspect = true;
                imgRender.sprite = Resources.Load<Sprite>(ComponentRegister.GeneralRegister[i][registeredComponents[i]]);
            }

        }        
        return newCell;
    }

    private void GenerateMultiImageObject(bool isWrong)
    {
        if (isWrong)
        {
            for (int i = 0; i < ComponentRegister.GeneralRegister.Count; i++)
            {
                registeredComponents.Add((int)Random.Range(0, ComponentRegister.GeneralRegister[i].Count-1));                
            }
        }
        else
        {
            //registeredComponentsGoodChoice = registeredComponents;
            for (int i = 0; i < registeredComponents.Count; i++) registeredComponentsGoodChoice.Add(registeredComponents[i]);
            bool _hasDecidePart = false;
            int ctxCounter = 0;
            do
            {
                if (ctxCounter >= registeredComponents.Count-1)
                {
                    // Se recorrio todo el array sin escojer un componente a cambiar
                    int newComponent;
                    do
                    {
                        newComponent = (int)Random.Range(0, ComponentRegister.GeneralRegister[ctxCounter].Count-1);
                    } while (newComponent == registeredComponentsGoodChoice[ctxCounter]);
                    registeredComponentsGoodChoice[ctxCounter] = newComponent;
                    _hasDecidePart = true;
                }
                else
                {
                    //TODO: Aplicar Reglas de dificultad
                    float rand = Random.Range(0f, 1f);
                    if (rand < 0.05f)
                    {
                        int newComponent;
                        do
                        {
                            newComponent = (int)Random.Range(0, ComponentRegister.GeneralRegister[ctxCounter].Count-1);
                        } while (newComponent == registeredComponentsGoodChoice[ctxCounter]);
                        registeredComponentsGoodChoice[ctxCounter] = newComponent;
                        
                        _hasDecidePart = true;
                    }
                    else
                    {
                        ctxCounter++;
                    }
                }
            } while (!_hasDecidePart);
            
        }        
    }

    
}
