using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RESALTADOBOTON : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Outline outline;

    void Start()
    {
        // Obtener el componente Outline
        outline = GetComponent<Outline>();
        // Desactivar el contorno al inicio
        outline.enabled = false;
    }

    // Cuando el cursor entra en el botón
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Activar el contorno
        outline.enabled = true;
    }

    // Cuando el cursor sale del botón
    public void OnPointerExit(PointerEventData eventData)
    {
        // Desactivar el contorno
        outline.enabled = false;
    }
}