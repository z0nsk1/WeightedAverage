using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author z0nsk1
/// @version ..2020
/// <summary>
/// 
/// </summary>
public class painotettuKA
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Anna kurssin opintopisteet ja arvosana, pilkulla erotettuna, lopeta kirjoittamalla '.'>");
        int[] opintopisteet = new int[30];
        int[] arvosanat = new int[30];

        int i = 0;
        int arvosanaSumma = 0;
        while (true) 
        {
            String syote = Console.ReadLine();
            if (syote.Equals("."))
            {
                break;
            }
            String[] jaettu = syote.Split(',');
            opintopisteet[i] = int.Parse(jaettu[0]);
            arvosanat[i] = int.Parse(jaettu[1]);
            arvosanaSumma += arvosanat[i];
            i++;
        }

        int summa = 0;
        int opsumma = 0;
        for (int j = 0; j < opintopisteet.Length; j++)
        {
            opsumma += opintopisteet[j];
            int kurssi = opintopisteet[j] * arvosanat[j];
            summa += kurssi;
        }
        double dsumma = summa;
        double dopsumma = opsumma;
        double kaPainotettu = dsumma / dopsumma;

        double aSumma = arvosanaSumma;
        double kurssiLkm = i;
        double perusKa = aSumma / kurssiLkm;
        Console.WriteLine("Normaali keskiarvo on: " + String.Format("{0:0.##}", perusKa));
        Console.WriteLine("Painotettu keskiarvo on: " + String.Format("{0:0.##}",kaPainotettu));
        Console.ReadLine();
    }

}
