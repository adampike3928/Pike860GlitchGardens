using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown() 
    
    {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawworldPos)
    {
        float newX = Mathf.RoundToInt(rawworldPos.x);
        float newY = Mathf.RoundToInt(rawworldPos.y);
        return new Vector2(newX, newY);

    }
    private void SpawnDefender(Vector2 roundedPos)
    {
        GameObject newDefender = Instantiate(defender ,roundedPos, Quaternion.identity) as GameObject;
        Debug.Log(roundedPos);
    }


}

    
