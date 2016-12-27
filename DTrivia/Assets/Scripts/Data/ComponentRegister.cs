using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ComponentRegister
{
    public static List<List<string>> GeneralRegister = new List<List<string>>();

    public static List<string> BocaComponents = new List<string>();
    public static List<string> BocaAComponents = new List<string>();
    public static List<string> CabelloComponents = new List<string>();
    public static List<string> CejasComponents = new List<string>();
    public static List<string> CejasAComponents = new List<string>();
    public static List<string> ChamarrasComponents = new List<string>();
    public static List<string> CollarComponents = new List<string>();
    public static List<string> CuerpoComponents = new List<string>();
    public static List<string> FlecoComponents = new List<string>();
    public static List<string> IrisComponents = new List<string>();
    public static List<string> LentesComponents = new List<string>();
    public static List<string> NarizComponents = new List<string>();
    public static List<string> NarizAComponents = new List<string>();
    public static List<string> OjosComponents = new List<string>();
    public static List<string> OjosAComponents = new List<string>();
    public static List<string> OrejasComponents = new List<string>();
    public static List<string> OrejasAComponents = new List<string>();
    public static List<string> RopaComponents = new List<string>();
    public static List<string> RopaAComponents = new List<string>();
    public static List<string> SombreroComponents = new List<string>();
    public static List<string> SombreroAComponents = new List<string>();

    public ComponentRegister()
    {
        GeneralRegister = new List<List<string>>();
        // Boca
        BocaComponents.Add("Boca001");
        BocaComponents.Add("Boca002");
        BocaComponents.Add("Boca003");

        

        //BocaComponents Adorno
        BocaAComponents.Add("BocaA001");
        BocaAComponents.Add("BocaA002");
        BocaAComponents.Add("BocaA003");

        

        //Cabello
        CabelloComponents.Add("Cabello001");
        CabelloComponents.Add("Cabello002");
        CabelloComponents.Add("Cabello003");

        

        //Caejas
        CejasComponents.Add("Cejas001");
        CejasComponents.Add("Cejas002");
        CejasComponents.Add("Cejas003");

        

        //Cejas Adorno
        CejasAComponents.Add("CejasA001");
        CejasAComponents.Add("CejasA002");
        CejasAComponents.Add("CejasA003");

        

        //Chamarra
        ChamarrasComponents.Add("Chamarra001");
        ChamarrasComponents.Add("Chamarra002");
        ChamarrasComponents.Add("Chamarra003");

        

        //Collar
        CollarComponents.Add("Collar001");
        CollarComponents.Add("Collar002");
        CollarComponents.Add("Collar003");

        

        //Cuerpo
        CuerpoComponents.Add("Cuerpo001");
        CuerpoComponents.Add("Cuerpo002");
        CuerpoComponents.Add("Cuerpo003");

        

        //Fleco
        FlecoComponents.Add("Fleco001");
        FlecoComponents.Add("Fleco002");
        FlecoComponents.Add("Fleco003");

        

        //Iris
        IrisComponents.Add("Iris001");
        IrisComponents.Add("Iris002");
        IrisComponents.Add("Iris003");

        

        //Lentes
        LentesComponents.Add("Lentes001");
        LentesComponents.Add("Lentes002");
        LentesComponents.Add("Lentes003");

        

        //Nariz
        NarizComponents.Add("Nariz001");
        NarizComponents.Add("Nariz002");
        NarizComponents.Add("Nariz003");

        

        //Nariz Adorno
        NarizAComponents.Add("NarizA001");
        NarizAComponents.Add("NarizA002");
        NarizAComponents.Add("NarizA003");

        

        //Ojos 
        OjosComponents.Add("Ojos001");
        OjosComponents.Add("Ojos002");
        OjosComponents.Add("Ojos003");

        
        //Ojos Adorno
        OjosAComponents.Add("OjosA001");
        OjosAComponents.Add("OjosA002");
        OjosAComponents.Add("OjosA003");
        
        //Orejas
        OrejasComponents.Add("Orejas001");
        OrejasComponents.Add("Orejas002");
        OrejasComponents.Add("Orejas003");
        
        //Orejas Adorno
        OrejasAComponents.Add("OrejasA001");
        OrejasAComponents.Add("OrejasA002");
        OrejasAComponents.Add("OrejasA003");
        
        //Ropa
        RopaComponents.Add("Ropa001");
        RopaComponents.Add("Ropa002");
        RopaComponents.Add("Ropa003");
        
        //Ropa Adorno
        RopaAComponents.Add("RopaA001");
        RopaAComponents.Add("RopaA002");
        RopaAComponents.Add("RopaA003");
        
        //Sombrero
        SombreroComponents.Add("Sombrero001");
        SombreroComponents.Add("Sombrero002");
        SombreroComponents.Add("Sombrero003");
        
        //Sombrero Adorno
        SombreroAComponents.Add("SombreroA001");
        SombreroAComponents.Add("SombreroA002");
        SombreroAComponents.Add("SombreroA003");

        // Add Componets
        
        GeneralRegister.Add(CuerpoComponents);
        GeneralRegister.Add(RopaComponents);
        GeneralRegister.Add(ChamarrasComponents);
        GeneralRegister.Add(RopaAComponents);
        GeneralRegister.Add(CollarComponents);
        GeneralRegister.Add(CabelloComponents);
        GeneralRegister.Add(CejasComponents);
        GeneralRegister.Add(CejasAComponents);
        GeneralRegister.Add(OjosComponents);
        GeneralRegister.Add(IrisComponents);
        GeneralRegister.Add(OjosAComponents);
        GeneralRegister.Add(BocaAComponents);
        GeneralRegister.Add(BocaComponents);
        GeneralRegister.Add(NarizComponents);
        GeneralRegister.Add(NarizAComponents);
        GeneralRegister.Add(SombreroComponents);
        GeneralRegister.Add(SombreroAComponents);
        GeneralRegister.Add(OrejasComponents);
        GeneralRegister.Add(OrejasAComponents);
        GeneralRegister.Add(LentesComponents);
        GeneralRegister.Add(FlecoComponents);
    }
    
}
