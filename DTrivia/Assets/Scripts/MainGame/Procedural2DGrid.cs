using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using Utils;

public class Procedural2DGrid : MonoBehaviour {
    [SerializeField]
    private int rowSize, columnSize;
    private bool _lock;
    private float baseProb, probAdd;      
    private List<int> registeredComponents = new List<int>();
    private List<int> registeredComponentsGoodChoice = new List<int>();

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
                imgRender.sprite = Resources.Load<Sprite>(Constants.ResourcesPath + ComponentRegister.GeneralRegister[i][registeredComponentsGoodChoice[i]].Name);                
            }
            
            
        }
        else
        {
            for (int i = 0; i < registeredComponents.Count; i++)
            {
                Image imgRender = _controller.Components[i].AddComponent<Image>();
                imgRender.preserveAspect = true;
                imgRender.sprite = Resources.Load<Sprite>(Constants.ResourcesPath + ComponentRegister.GeneralRegister[i][registeredComponents[i]].Name);
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
                
                if (ComponentRegister.GeneralRegister[i][0].Type == eClothType.Cabello)
                {
                    registeredComponents.Add(registeredComponents[0]);
                }
                else if(ComponentRegister.GeneralRegister[i][0].Type == eClothType.Orejas)
                {
                    float randomNumber = Random.Range(0,1);
                    if(randomNumber < 0.33f) registeredComponents.Add(registeredComponents[1]);
                    else if(randomNumber < 0.66f) registeredComponents.Add(registeredComponents[1]+ ComponentRegister.GeneralRegister[i].Count);
                    else registeredComponents.Add(registeredComponents[1] + (ComponentRegister.GeneralRegister[i].Count*2));
                }
                else
                {
                    int selectedIndex = (int)Random.Range(0, ComponentRegister.GeneralRegister[i].Count - 1);
                    registeredComponents.Add(selectedIndex);
                }
            }
        }
        else
        {
            float baseProbChange = 0.05f;
            for (int i = 0; i < registeredComponents.Count; i++) registeredComponentsGoodChoice.Add(registeredComponents[i]);
            bool _hasDecidePart = false;
            int ctxCounter = 0;
            do
            {
                if (ctxCounter >= registeredComponents.Count-1)
                {
                    // Se recorrio todo el array sin escojer un componente a cambiar
                    registeredComponentsGoodChoice[ctxCounter] = GetNewComponentIndex(ctxCounter);
                    _hasDecidePart = true;
                }
                else
                {
                    //TODO: Aplicar Reglas de dificultad
                    float rand = Random.Range(0f, 1f);
                    if (rand < baseProbChange)
                    {
                        registeredComponentsGoodChoice[ctxCounter] = GetNewComponentIndex(ctxCounter);
                        _hasDecidePart = true;
                    }
                    else
                    {
                        baseProbChange += 0.025f;
                        ctxCounter++;
                    }
                }
            } while (!_hasDecidePart);
            
        }        
    }

    private int GetNewComponentIndex(int ctxCounter)
    {
        int newComponent;
        do
        {
            newComponent = (int)Random.Range(0, ComponentRegister.GeneralRegister[ctxCounter].Count - 1);
        } while (newComponent == registeredComponentsGoodChoice[ctxCounter]);
        return newComponent;
    }

    
}
