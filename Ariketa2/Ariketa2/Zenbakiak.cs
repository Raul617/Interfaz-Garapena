using System;

public class Zenbakiak

{
    public float zenbaki1 { get; set; }
    public float zenbaki2 { get; set; }
    public float zenbaki3 { get; set; }
    public float zenbaki4 { get; set; }

    public string formula()
    {   
        float erantzuna = ((zenbaki1 + (2*zenbaki2) +(3*zenbaki3)+(4*zenbaki4))/4);
        return "(" +zenbaki1 + " ( 2 x " + zenbaki2 + ") + ( 3 x " + zenbaki3 + " ) + ( 4 x " + zenbaki4 + " ) ) / 4 "  + " = " + erantzuna;
    }
}
