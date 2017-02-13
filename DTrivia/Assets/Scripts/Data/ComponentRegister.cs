using System.Collections;
using System.Collections.Generic;
using Utils;

public class ComponentRegister
{
    public static List<List<ComponentModel>> GeneralRegister;
    

    public static List<ComponentModel> CabelloTrasero = new List<ComponentModel>();
    public static List<ComponentModel> Cuerpo = new List<ComponentModel>();
    public static List<ComponentModel> Ropa = new List<ComponentModel>();
    public static List<ComponentModel> Chamarra = new List<ComponentModel>();
    public static List<ComponentModel> Collar = new List<ComponentModel>();
    public static List<ComponentModel> AdornoRopa = new List<ComponentModel>();
    public static List<ComponentModel> Cabello = new List<ComponentModel>();
    public static List<ComponentModel> Maquillaje = new List<ComponentModel>();
    public static List<ComponentModel> Ojos = new List<ComponentModel>();
    public static List<ComponentModel> Boca = new List<ComponentModel>();
    public static List<ComponentModel> Nariz = new List<ComponentModel>();
    public static List<ComponentModel> Rostro = new List<ComponentModel>();
    public static List<ComponentModel> Sombrero = new List<ComponentModel>();
    public static List<ComponentModel> AdornoSombrero = new List<ComponentModel>();
    public static List<ComponentModel> Orejas = new List<ComponentModel>();
    public static List<ComponentModel> Aretes = new List<ComponentModel>();
    public static List<ComponentModel> Fleco = new List<ComponentModel>();
    

    public static void Init()
    {
        GeneralRegister = new List<List<ComponentModel>>();
        CabelloTrasero.Add(new ComponentModel("cabelloTrasero01", eColor.peloCafe, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel("cabelloTrasero02", eColor.peloNaranja, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel(Constants.EmptyComponent, eColor.None, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel(Constants.EmptyComponent, eColor.None, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel("cabelloTrasero05", eColor.peloAzul, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel("cabelloTrasero06", eColor.peloVerde, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel("cabelloTrasero07", eColor.peloNegro, eClothType.CabelloTrasero, eComponentType.required));
        CabelloTrasero.Add(new ComponentModel("cabelloTrasero08", eColor.peloRubio, eClothType.CabelloTrasero, eComponentType.required));
        GeneralRegister.Add(CabelloTrasero);

        Cuerpo.Add(new ComponentModel("Cuerpo01", eColor.pielMorenoClara, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo02", eColor.pielRosada, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo03", eColor.pielBlanca, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo04", eColor.pielMorena, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo05", eColor.pielMorenoOscura, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo06", eColor.pielNegra, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo07", eColor.pielAmarillenta, eClothType.Cuerpo, eComponentType.required));
        Cuerpo.Add(new ComponentModel("Cuerpo08", eColor.pielAnaranjada, eClothType.Cuerpo, eComponentType.required));
        GeneralRegister.Add(Cuerpo);

        Ropa.Add(new ComponentModel("Ropa01", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa02", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa03", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa04", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa05", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa06", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa07", eColor.None, eClothType.Ropa, eComponentType.required));
        Ropa.Add(new ComponentModel("Ropa08", eColor.None, eClothType.Ropa, eComponentType.required));
        GeneralRegister.Add(Ropa);

        Chamarra.Add(new ComponentModel("Chamarra01", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra02", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra03", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra04", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra05", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra06", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra07", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        Chamarra.Add(new ComponentModel("Chamarra08", eColor.None, eClothType.Chamarra, eComponentType.notRequired));
        GeneralRegister.Add(Chamarra);

        Collar.Add(new ComponentModel("Collar01", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar02", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar03", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar04", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar05", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar06", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar07", eColor.None, eClothType.Collar, eComponentType.notRequired));
        Collar.Add(new ComponentModel("Collar08", eColor.None, eClothType.Collar, eComponentType.notRequired));
        GeneralRegister.Add(Collar);

        AdornoRopa.Add(new ComponentModel("AdornoRopa01", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa02", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa03", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa04", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa05", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa06", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa07", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        AdornoRopa.Add(new ComponentModel("AdornoRopa08", eColor.None, eClothType.AdornoRopa, eComponentType.notRequired));
        GeneralRegister.Add(AdornoRopa);

        Cabello.Add(new ComponentModel("Cabello01", eColor.peloCafe, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello02", eColor.peloNaranja, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello03", eColor.None, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello04", eColor.None, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello05", eColor.peloAzul, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello06", eColor.peloVerde, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello07", eColor.peloNegro, eClothType.Cabello, eComponentType.required));
        Cabello.Add(new ComponentModel("Cabello08", eColor.peloRubio, eClothType.Cabello, eComponentType.required));
        GeneralRegister.Add(Cabello);

        Maquillaje.Add(new ComponentModel("Maquillaje01", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje02", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje03", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje04", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje05", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje06", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje07", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        Maquillaje.Add(new ComponentModel("Maquillaje08", eColor.None, eClothType.Maquillaje, eComponentType.notRequired));
        GeneralRegister.Add(Maquillaje);

        Ojos.Add(new ComponentModel("Ojos01", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos02", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos03", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos04", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos05", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos06", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos07", eColor.None, eClothType.Ojos, eComponentType.required));
        Ojos.Add(new ComponentModel("Ojos08", eColor.None, eClothType.Ojos, eComponentType.required));
        GeneralRegister.Add(Ojos);

        Boca.Add(new ComponentModel("Boca01", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca02", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca03", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca04", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca05", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca06", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca07", eColor.None, eClothType.Boca, eComponentType.required));
        Boca.Add(new ComponentModel("Boca08", eColor.None, eClothType.Boca, eComponentType.required));
        GeneralRegister.Add(Boca);

        Nariz.Add(new ComponentModel("Nariz01", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz02", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz03", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz04", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz05", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz06", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz07", eColor.None, eClothType.Nariz, eComponentType.required));
        Nariz.Add(new ComponentModel("Nariz08", eColor.None, eClothType.Nariz, eComponentType.required));
        GeneralRegister.Add(Nariz);    

        Rostro.Add(new ComponentModel("Rostro01", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro02", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro03", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro04", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro05", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro06", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro07", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        Rostro.Add(new ComponentModel("Rostro08", eColor.None, eClothType.Rostro, eComponentType.notRequired));
        GeneralRegister.Add(Rostro);

        Sombrero.Add(new ComponentModel("Sombrero01", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero02", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero03", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero04", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero05", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero06", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero07", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        Sombrero.Add(new ComponentModel("Sombrero08", eColor.None, eClothType.Sombrero, eComponentType.notRequired));
        GeneralRegister.Add(Sombrero);

        AdornoSombrero.Add(new ComponentModel("AdornoSombrero01", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero02", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero03", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero04", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero05", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero06", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero07", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        AdornoSombrero.Add(new ComponentModel("AdornoSombrero08", eColor.None, eClothType.AdornoSombrero, eComponentType.notRequired));
        GeneralRegister.Add(AdornoSombrero);

        Orejas.Add(new ComponentModel("Oreja01", eColor.pielMorenoClara,    eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja02", eColor.pielRosada,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja03", eColor.pielBlanca,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja04", eColor.pielMorena,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja05", eColor.pielMorenoOscura,   eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja06", eColor.pielNegra,          eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja07", eColor.pielAmarillenta,    eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja08", eColor.pielAnaranjada,     eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja09", eColor.pielMorenoClara,    eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja10", eColor.pielRosada,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja11", eColor.pielBlanca,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja12", eColor.pielMorena,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja13", eColor.pielMorenoOscura,   eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja14", eColor.pielNegra,          eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja15", eColor.pielAmarillenta,    eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja16", eColor.pielAnaranjada,     eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja17", eColor.pielMorenoClara,    eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja18", eColor.pielRosada,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja19", eColor.pielBlanca,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja20", eColor.pielMorena,         eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja21", eColor.pielMorenoOscura,   eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja22", eColor.pielNegra,          eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja23", eColor.pielAmarillenta,    eClothType.Orejas, eComponentType.required));
        Orejas.Add(new ComponentModel("Oreja24", eColor.pielAnaranjada,     eClothType.Orejas, eComponentType.required));
        GeneralRegister.Add(Orejas);

        Aretes.Add(new ComponentModel("Aretes01", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes02", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes03", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes04", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes05", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes06", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes07", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        Aretes.Add(new ComponentModel("Aretes08", eColor.None, eClothType.Aretes, eComponentType.notRequired));
        GeneralRegister.Add(Aretes);

        Fleco.Add(new ComponentModel("Fleco01", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco02", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco03", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco04", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco05", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco06", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco07", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        Fleco.Add(new ComponentModel("Fleco08", eColor.None, eClothType.Fleco, eComponentType.notRequired));
        GeneralRegister.Add(Fleco);
    }
    
}
