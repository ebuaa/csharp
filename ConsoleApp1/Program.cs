using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Principal;
/*using ConsoleApp1;*//**/


class Program
{
    /*static void Square(int a, int b)
    {
        a = a + 1;
        b++;
        a = a * a;
        b *= b;
        Console.WriteLine(a + " " + b);
    }*/

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            Console.WriteLine("Entrez 1 pour avoir votre salaire\nEntrez 2 pour avoir un aperçu de vos interêts");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            


            string[] mois = new string[] { "Janvier", "Février", "Mars", "Avril",
            "Mai", "Juin", "Juillet", "Aout", "Septembre",
            "Octobre", "Novembre", "Décembre" };
            if (userchoice == 1)
            {

                Console.WriteLine("Entrez votre salaire annuel :");
                int salaireannuel = Convert.ToInt32(Console.ReadLine());
                double salairemensuel = salaireannuel / 12;
                Console.WriteLine("Entez le montant de votre prime de noel :");
                int montantprime = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < mois.Length; i++)
                {


                    if (i == 7)
                    {
                        continue;
                    }

                    if (i == 11)
                    {
                        salairemensuel = salairemensuel * montantprime;
                    }

                    if (salairemensuel > 10000)
                    {
                        Console.WriteLine($"{mois[i],-10} || {salairemensuel,10:N2}");

                    }


                    Console.WriteLine($"{mois[i],-10} || {salairemensuel,10:N2}");
                }
            }
            if (userchoice == 2)
            {
                Console.WriteLine("Entrez votre capital investi :");
                int capitalinvesti = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entez le nombre d'années debuis le début d'investisssement");
                int anneesinvestissement = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entez le taux d'intêrets");
                int tauxinterets = Convert.ToInt32(Console.ReadLine());

                double tauxDecimal = tauxinterets / 100.0;

                Console.WriteLine("\nDétail de l'investissement par année :");
                for (int i = 1; i <= anneesinvestissement; i++)
                {
                    double capital = capitalinvesti * Math.Pow(1 + tauxDecimal, i);
                    Console.WriteLine($"Année {i} : {capital:N2} €");
                }
            }
        }


        catch (FormatException e)
        {
            Console.WriteLine(e.Source);
            Environment.Exit(-1);
        }
    }
}


/*
        User.DisplayUserInfo();*/
        









/*int annualsalary = 30000;
int taxrate = 30;*/

/* Console.OutputEncoding = System.Text.Encoding.UTF8;

 Console.WriteLine("Enter votre salaire annuel :");
 string num1 = Console.ReadLine();
 int annualsalary = 0;
 bool canConvert = int.TryParse(num1, out annualsalary);
 if (canConvert == true)
     Console.WriteLine("Votre salaire annuel est de : " + num1 + " €");
 else
     Console.WriteLine("Veuillez entrer un nombre entier");

 Console.WriteLine("Entrez votre taux d'imposition :");
 string num2 = Console.ReadLine();
 int taxrate = 0;
 bool canConverttaxrate = int.TryParse(num2, out taxrate);
 if (canConverttaxrate == true)
     Console.WriteLine("Votre taux d'imposition est de : " + taxrate + " %");
 else
     Console.WriteLine("Veuillez entrer un nombre entier");

 int monthlysalary = (annualsalary - (annualsalary * (taxrate / 100))) / 12;
 Console.WriteLine("Votre salaire mensuel est de : " + monthlysalary + " €");

 if (annualsalary > 50000)
 {
     Console.WriteLine("Donne aux oeuvres de charité");
 }
 else if (monthlysalary < 1500)
 {
     Console.WriteLine("Pas grave t'es alternant");
 }
 else if ( annualsalary >= 30000 && annualsalary <= 40000)
 {
     Console.WriteLine("Viens faire un bac+5");
 }*/


/*Console.WriteLine("Enter you annual salary :");
int annualsalary = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your tax rate :");
int taxrate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your monthly salary :");
int monthlysalary = Convert.ToInt32(Console.ReadLine());*/



/*Console.WriteLine("Monthly salary : " + annualsalary / 12);
Console.WriteLine("Monthly salary after taxes : " + (annualsalary - (annualsalary * (taxrate / 100.0))) / 12);
Console.WriteLine("Annual salary : " + monthlysalary * 12);*/




/*Console.WriteLine("Enter number 1 :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2 :");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + " " + num2);
Square(num1, num2);
Console.WriteLine(num1 + " " + num2);
Console.WriteLine("Press enter key to Exit..");
Console.ReadLine();*/


