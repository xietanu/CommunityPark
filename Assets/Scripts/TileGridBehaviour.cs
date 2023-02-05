using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGridBehaviour : MonoBehaviour
{
    public GameObject BaseTilePrefab;
    public int GridWidth = 10;
    public int GridHeight = 10;

    private GameObject[,] _grid;
    // Start is called before the first frame update
    void Start()
    {
        _grid = new GameObject[GridWidth, GridHeight];
        for (int x = 0; x < GridWidth; x++)
        {
            for (int y = 0; y < GridHeight; y++)
            {
                var tile = Instantiate(BaseTilePrefab, transform);
                tile.transform.position = GetIsoPosition(x, y);
                tile.transform.SetParent(transform);
                _grid[x, y] = tile;
            }
        }
    }

    Vector3 GetIsoPosition(int x, int y)
    {
        return new Vector3(x - y, (float)(x + y) / 2, (x + y));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
