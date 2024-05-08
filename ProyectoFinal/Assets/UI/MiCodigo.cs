using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class MiCodigo : MonoBehaviour
{
    UIDocument menu;
    // Principal
    Button hangar_button;

    //Arsenal
    VisualElement hangar;
    Button arma1_button;
    Button arma2_button;
    Button arma3_button;
    Button arma4_button;
    Button arma5_button;
    Button arma6_button;
    Label arma_nombre;
    ProgressBar arma_tiempoDeRecarga;
    ProgressBar arma_danioAJugador;
    ProgressBar arma_tamanioDeCargador;
    Button volver_button;

    private void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;

        //Principal
        hangar_button = root.Q<Button>("arsenal");
        
        //Arsenal
        hangar = root.Q<VisualElement>("derecha");
        arma1_button = root.Q<Button>("arma1");
        arma2_button = root.Q<Button>("arma2");
        arma3_button = root.Q<Button>("arma3");
        arma4_button = root.Q<Button>("arma4");
        arma5_button = root.Q<Button>("arma5");
        arma6_button = root.Q<Button>("arma6");
        arma_nombre = root.Q<Label>("arma-nombre");
        arma_tiempoDeRecarga = root.Q<ProgressBar>("tiempo-recarga");
        arma_danioAJugador = root.Q<ProgressBar>("danio-jugador");
        arma_tamanioDeCargador = root.Q<ProgressBar>("tamanio-cargador");
        volver_button = root.Q<Button>("hangar-volver");

        //Callbacks
        hangar_button.RegisterCallback<ClickEvent>(abrirHangar);
        arma1_button.RegisterCallback<ClickEvent, int>(seleccionarArma, 1);
        arma2_button.RegisterCallback<ClickEvent, int>(seleccionarArma, 2);
        arma3_button.RegisterCallback<ClickEvent, int>(seleccionarArma, 3);
        arma4_button.RegisterCallback<ClickEvent, int>(seleccionarArma, 4);
        arma5_button.RegisterCallback<ClickEvent, int>(seleccionarArma, 5);
        arma6_button.RegisterCallback<ClickEvent, int>(seleccionarArma, 6);
        volver_button.RegisterCallback<ClickEvent>(cerrarHangar);

        void abrirHangar(ClickEvent evt)
        {
            hangar.AddToClassList("derecha-activo");
        }

        void seleccionarArma(ClickEvent evt, int modelo)
        {
            switch (modelo)
            {
                case 1:
                    arma_nombre.text = "SVA 545";
                    arma_tiempoDeRecarga.lowValue = 20;
                    arma_tamanioDeCargador.lowValue = 50;
                    arma_danioAJugador.lowValue = 90;
                    break;
                case 2:
                    arma_nombre.text = "KVO Enforcer";
                    arma_tiempoDeRecarga.lowValue = 90;
                    arma_tamanioDeCargador.lowValue = 10;
                    arma_danioAJugador.lowValue = 100;
                    break;
                case 3:
                    arma_nombre.text = "MTZ-556";
                    arma_tiempoDeRecarga.lowValue = 40;
                    arma_tamanioDeCargador.lowValue = 60;
                    arma_danioAJugador.lowValue = 40;
                    break;
                case 4:
                    arma_nombre.text = "KATT-ARM";
                    arma_tiempoDeRecarga.lowValue = 80;
                    arma_tamanioDeCargador.lowValue = 10;
                    arma_danioAJugador.lowValue = 100;
                    break;
                case 5:
                    arma_nombre.text = "DG-58 LSW";
                    arma_tiempoDeRecarga.lowValue = 10;
                    arma_tamanioDeCargador.lowValue = 90;
                    arma_danioAJugador.lowValue = 20;
                    break;
                case 6:
                    arma_nombre.text = "KVO Enforcer";
                    arma_tiempoDeRecarga.lowValue = 50;
                    arma_tamanioDeCargador.lowValue = 70;
                    arma_danioAJugador.lowValue = 40;
                    break;
            }
        }

        void cerrarHangar(ClickEvent evt)
        {
            hangar.RemoveFromClassList("derecha-activo");
        }


    }



}
