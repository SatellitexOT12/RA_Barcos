using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject startPanel;     // Panel de inicio
    public GameObject arView;         // Vista AR completa (ARCamera + barras)

    private void Start()
    {
        // Al iniciar la app, se muestra la pantalla inicial
        ShowStartPanel();
    }

    // ----------------------------
    //  BOTÓN ESCANEAR
    // ----------------------------
    public void OnScanButton()
    {
        startPanel.SetActive(false);  // Oculta pantalla inicial
        arView.SetActive(true);       // Activa la vista AR
    }

    // ----------------------------
    //  BOTÓN ATRÁS
    // ----------------------------
    public void OnBackButton()
    {
        arView.SetActive(false);      // Oculta AR
        startPanel.SetActive(true);   // Vuelve a la pantalla inicial
    }

    // ----------------------------
    //  MOSTRAR/OCULTAR PANELES
    // ----------------------------

    public void ShowStartPanel()
    {
        startPanel.SetActive(true);
        arView.SetActive(false);
    }

    public void ShowARPanel()
    {
        startPanel.SetActive(false);
        arView.SetActive(true);
    }
}
