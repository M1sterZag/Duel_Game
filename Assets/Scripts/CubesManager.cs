using UnityEngine;

public class CubesManager : MonoBehaviour
{
    [SerializeField] private GameObject _whiteCube;
    [SerializeField] private GameObject _whiteCubeKing;
    [SerializeField] private GameObject _blackCube;
    [SerializeField] private GameObject _blackCubeKing;

    private int _numRows = 8; // Количество строк
    private int _numColumns = 9; // Количество столбцов
    public float cubeWidth = 1f; // Ширина куба
    public float cubeHeight = 1f; // Высота куба


    // Start is called before the first frame update
    void Start()
    {
        PlaceCubes();
    }

    void PlaceCubes()
    {
        // Определение начальной позиции для размещения кубов
        Vector3 startPos = transform.position - new Vector3((_numColumns - 1) * cubeWidth / 2, 1.1f, (_numRows - 1) * cubeHeight / 2);

        // Цикл по всем строкам и столбцам для размещения кубов
        for (int row = 0; row < _numRows; row++)
        {
            for (int col = 0; col < _numColumns; col++)
            {
                // Создание новой клетки из префаба
                GameObject newCell = Instantiate(_whiteCubeKing, transform);

                // Вычисление позиции нового куба
                float x = startPos.x + col * cubeWidth;
                float z = startPos.z + row * cubeHeight;
                Vector3 newPos = new Vector3(x, 1.1f, z);

                // Установка позиции для куба
                newCell.transform.position = newPos;
            }
        }
    }
}
