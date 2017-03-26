using UnityEngine;
using System.Collections;
using System;

namespace Utils
{
    public enum eGameState
    {
        onMenus,
        playing,
        pause
    }  

    public enum eLevel
    {
        MainMenu = 1,
        Puzzle = 2
    }

    public enum eClothType
    {
            Fleco,
            Aretes,
            Orejas,
            AdornoSombrero,
            Sombrero,
            Rostro,
            Nariz,
            Boca,
            Ojos,
            Maquillaje,
            Cabello,
            AdornoRopa,
            Collar,
            Chamarra,
            Ropa,
            Cuerpo,
            CabelloTrasero

    }

    public enum eComponentType
    {
        required,
        notRequired
    }

    public enum eColor
    {
        None,
        //Piel
        pielMorenoClara,
        pielRosada,
        pielBlanca,
        pielMorena,
        pielMorenoOscura,
        pielNegra,
        pielAmarillenta,
        pielAnaranjada,
        //Cabello
        peloCafe,
        peloNaranja,
        peloCafeOscuro,
        peloRojo,
        peloAzul,
        peloVerde,
        peloNegro,
        peloRubio
    }    


}


