using System;

public class Esaldia
{

    //Propietateak
    public string EsaldiaBatuta { get; set; }
 
    //Eraikitzaileak
    public Esaldia()
	{

	}

    public void jasotakoEsaldia(string jasotakoa)
    {
        EsaldiaBatuta = EsaldiaBatuta + " " + jasotakoa;
    }
}
