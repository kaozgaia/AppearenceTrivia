using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Utils;

public class GridCellController : MonoBehaviour {

    // Properties
    public List<GameObject> Components = new List<GameObject>();


    // Model
    public CellModel Data = new CellModel();

	public void CellClick()
    {
        Debug.Log(Data.IsAssert);
        if (Data.IsAssert)
            UILokingSingleton.Instance.ReloadCurrentLevel();
        
    }

}
