using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filavirtual : MonoBehaviour
{
    public string CodigoLetra;
    public int CantidadEntradas;
    int PrecioTotal;
    // Start is called before the first frame update
    void Start()
    {
        if ((CodigoLetra == "b" && CantidadEntradas > 4)
            || (CodigoLetra == "n" && CantidadEntradas > 6) || (CodigoLetra != "b") || (CodigoLetra != "n") || (CodigoLetra != "p"))
        {
            Debug.Log(" Error");
            return;
        }
        if (CodigoLetra == "b")
        {
            PrecioTotal = CantidadEntradas * 800;
        } else if (CodigoLetra == "n")
        {
            PrecioTotal = CantidadEntradas * 1200;
        } else if (CodigoLetra == "p")
        {
            PrecioTotal = CantidadEntradas * 2000;
        }

        Debug.Log("Tipo de entrada: " + CodigoLetra + "- Cantidad: " + CantidadEntradas + " - Precio total: " + PrecioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
