System.Globalization.CultureInfo customCulture =
(System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = System.Text.Encoding.Default;

double[] mas = new double[3];
double xm = 0, xp = 0, sp, hp = 1, sm, hm = -1, dp, dm;
int max = 0;
bool t = true;

//xm - від'ємне x
//xp - додатнє x
//hm - від'ємний крок
//hp - додатній крок
//sm - від'ємне число x, до кроку
//sp - додатнє число x, до кроку
//dm - від'ємне x, до розширеного кроку
//dp - додатнє x, до розширеного кроку
//max - кількість відомих коренів


if (Math.Round(Math.Sin(xp) - 0.2 * xp, 4) == 0)
{
    mas[max] = xp;
    max++;
}

for(; ; )
{
    //start+
    sp = xp;
    hp = 1;
    xp = xp + hp;

    if(Math.Sin(xp) - 0.2 * xp <= 0)
    {

        if (Math.Round(Math.Sin(xp) - 0.2 * xp, 4) == 0)
        {
            mas[max] = xp;
            max++;
        }

        t = true;
        hp = hp / 2;
        dp = sp;
        xp = sp;
        do
        {

            sp = xp;
            xp = xp + hp;


            if (Math.Round(Math.Sin(xp) - 0.2 * xp, 4) == 0)
            {
                mas[max] = xp;
                max++;
                t = false;
            }


            if (Math.Sin(xp) - 0.2 * xp <= 0)
            {
                hp = hp / 2;
                xp = sp;

            }



        } while (t);

        xp = dp+1;
    }
    //end+

    //start-
    sm = xm;
    hp = -1;
    xm = xm + hm;

    if (Math.Sin(xm) - 0.2 * xm >= 0)
    {

        if (Math.Round(Math.Sin(xm) - 0.2 * xm, 4) == 0)
        {
            mas[max] = xm;
            max++;
        }

        t = true;
        hm = hm / 2;
        dm = sm;
        xm = sm;
        do
        {

            sm = xm;
            xm = xm + hm;


            if (Math.Round(Math.Sin(xm) - 0.2 * xm, 4) == 0)
            {
                mas[max] = xm;
                max++;
                t = false;
            }

            if (Math.Sin(xm) - 0.2 * xm >= 0)
            {
                hm = hm / 2;
                xm = sm;
            }
        } while (t);
        xm = dm - 1;
    }
    if (max == 3)
        break;
}

Array.Sort(mas);
Console.WriteLine($"sin(x) - 0.2x = 0 тоді, коли:");
Console.Write("x = ");
for (int i = 0; i < max; i++)
    Console.Write($"{mas[i]}\t");
Console.WriteLine("");