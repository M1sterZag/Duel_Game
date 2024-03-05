using UnityEngine;
 
public class GridManager : MonoBehaviour {
    [SerializeField] private GameObject _cellPrefab; // Префаб клетки

    [SerializeField] private int _numRows; // Количество строк
    [SerializeField] private int _numColumns; // Количество столбцов

    public float cellWidth = 1f; // Ширина клетки
    public float cellHeight = 1f; // Высота клетки

    void Start()
    {
        BuildGameBoard();
    }

    void BuildGameBoard()
    {
        // Определение начальной позиции для размещения клеток
        Vector3 startPos = transform.position - new Vector3((_numColumns - 1) * cellWidth / 2, 0, (_numRows - 1) * cellHeight / 2);

        // Цикл по всем строкам и столбцам для размещения клеток
        for (int row = 0; row < _numRows; row++)
        {
            for (int col = 0; col < _numColumns; col++)
            {
                // Создание новой клетки из префаба
                GameObject newCell = Instantiate(_cellPrefab, transform);

                // Вычисление позиции новой клетки
                float x = startPos.x + col * cellWidth;
                float z = startPos.z + row * cellHeight;
                Vector3 newPos = new Vector3(x, 0, z);

                // Установка позиции для клетки
                newCell.transform.position = newPos;
            }
        }
    }

    // [SerializeField] private int _width, _height;
 
    // [SerializeField] private Tile _tilePrefab;
 
    // [SerializeField] private Transform _cam;
 
    // private Dictionary<Vector2, Tile> _tiles;
 
    // void Start() {
    //     GenerateGrid();
    // }
 
    // void GenerateGrid() {
    //     _tiles = new Dictionary<Vector2, Tile>();
    //     for (int x = 0; x < _width; x++) {
    //         for (int y = 0; y < _height; y++) {
    //             var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
    //             spawnedTile.name = $"Tile {x} {y}";
 
    //             var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
    //             spawnedTile.Init(isOffset);
 
 
    //             _tiles[new Vector2(x, y)] = spawnedTile;
    //         }
    //     }
 
    //     _cam.transform.position = new Vector3((float)_width/2 -0.5f, (float)_height / 2 - 0.5f,-10);
    // }
 
    // public Tile GetTileAtPosition(Vector2 pos) {
    //     if (_tiles.TryGetValue(pos, out var tile)) return tile;
    //     return null;
    // }
}
