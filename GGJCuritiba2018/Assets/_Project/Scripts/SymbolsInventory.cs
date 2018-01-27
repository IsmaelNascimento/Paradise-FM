using UnityEngine;

public class SymbolsInventory : MonoBehaviour
{
    [ContextMenu("OpenSymbolsInvetory")]
    public void OpenSymbolsInvetory()
    {
        GetComponent<Animator>().Play("SymbolsInvetoryInput");
    }

    [ContextMenu("CloseSymbolsInvetory")]
    public void CloseSymbolsInvetory()
    {
        GetComponent<Animator>().Play("SymbolsInvetoryOutput");
    }
}
