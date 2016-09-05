using UnityEngine;
using System.Collections;
using Assets.Scripts.Model;

public class GridCellController : MonoBehaviour {

    public CellModel Data = new CellModel();

	public void CellClick()
    {
        Debug.Log(Data.IsAssert);
    }

}
