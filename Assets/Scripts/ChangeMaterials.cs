using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeMaterials : MonoBehaviour, IPointerClickHandler
{
    public Material material1; // Первый материал
    public Material material2; // Второй материал

    Renderer meshRenderer;

    private void Awake() {
        meshRenderer = GetComponent<Renderer>();
    }


    public void OnPointerClick(PointerEventData pointerEventData) {
        ChangeMaterial();
    }

    public void ChangeMaterial()
    {
        // Если компонент Renderer существует и у нас есть два материала
        if (material1 != null && material2 != null)
        {
            // Если текущий материал равен первому материалу, меняем его на второй, и наоборот
            if (meshRenderer.material == material1)
            {
                meshRenderer.material = material2;
            }
            else
            {
                meshRenderer.material = material1;
            }
        }
    }
}
