//Cédric JAWORSKI Brief Simplon Calculatrice
//Utilisée l'ensemble de vos connaissance pour développer une calculatrice fonctionnel en C#

#region En-tête
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
// Génération des variables
List<double> resultats = new List<double>(1); //Liste contenant le résultat de l'opération éffectuée
bool isSaisieValid = false; //Variable permettant de verifier l'integrité de l'entrée utilisateur
int saisieU = 0; //Initilisation de l'entrée utilisateur

//Affichage de l'IU permettant à l'utilisateur de se diriger dans l'appli
Console.WriteLine("Bienvenue sur votre calculatrice ! \n");
Console.WriteLine("----------------------");
Console.WriteLine("|--- Calculatrice ---|");
Console.WriteLine("----------------------");
Console.WriteLine("1 ---- Addition ----");
Console.WriteLine("|--------------------|");
Console.WriteLine("2 -- Soustraction --");
Console.WriteLine("|--------------------|");
Console.WriteLine("3 - Multiplication -");
Console.WriteLine("|--------------------|");
Console.WriteLine("4 ---  Division ----");
Console.WriteLine("|--------------------|");
Console.WriteLine("0 ----  Quitter ----");
Console.WriteLine("|--------------------|");
#endregion

#region Fonction Addition
double Addition()
{
    //Initialisation des variables
    bool isSaisieValidU = false;
    List<double> valeurs = new List<double>(); //Liste des valeurs rentrées par l'utilisateur
    string valeurU; //chaîne de caractère rentré par l'utilisateur
    double valAdd; //valeur ajoutée à la liste
    double somme; //variable correspondant à la somme de l'opération
    Console.WriteLine("Veuillez entrer vos valeurs");
    do
    {
        valeurU = Console.ReadLine();
        isSaisieValidU = double.TryParse(valeurU, out valAdd); //On vérifie ce que rentre l'utilisateur
        if (isSaisieValidU) //Si valide
        {
            valeurs.Add(valAdd); //On ajoute à la lsite
        }
        Console.WriteLine(" + ");
    } while (valeurU != "=");
    {
        somme = valeurs.Sum(); //On effectue la somme des valeurs comprises dans la liste
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n = " + somme); //On affiche le résultat
        Console.ForegroundColor = ConsoleColor.White;
    }
    resultats.Add(somme); //On ajoute le résultat de l'opération à la liste de résultat
    return somme; //On retourne la somme obtenue
}
#endregion

#region Fonction Soustraction
double Soustraction()
{
    //Initialisation des variables
    bool isSaisieValidU = false;
    List<double> valeurs = new List<double>();
    string valeurU;
    double diff = 0;
    double valAdd;
    double start;
    Console.WriteLine("Veuillez entrer vos valeurs");
    do
    {
        valeurU = Console.ReadLine();
        isSaisieValidU = double.TryParse(valeurU, out valAdd); //On verifie que la valeur est utilisable
        if (isSaisieValidU)
        {
            valeurs.Add(valAdd);
        }
        Console.Write(" - ");
    } while (valeurU != "=");
     foreach (double item in valeurs)
        {
            diff = diff - item;
        }
    start = valeurs[1];
    diff += start;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n = " + diff);
    Console.ForegroundColor = ConsoleColor.White;
    resultats.Add(diff);
    return diff;

}
#endregion

#region Fonction Multiplication
double Multiplication()
{
    bool isSaisieValidU = false;
    List<double> valeurs = new List<double>();
    string valeurU;
    double mult = 1;
    double valAdd;
    Console.WriteLine("Veuillez entrer vos valeurs");
    do
    {
        valeurU = Console.ReadLine();
        isSaisieValidU = double.TryParse(valeurU, out valAdd);
        if (isSaisieValidU)
        {
            valeurs.Add(valAdd);
        }
        Console.Write(" x ");
    } while (valeurU != "=");
    {
        foreach (double item in valeurs)
        {
            mult = item * mult;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n = " + mult);
    Console.ForegroundColor = ConsoleColor.White;
    resultats.Add(mult);
    return mult;

}
#endregion

#region Fonction Division
double Division()
{
    bool isSaisieValidU = false;
    List<double> valeurs = new List<double>();
    string valeurU;
    double div = 1;
    double valAdd;
    Console.WriteLine("Veuillez entrer vos valeurs");
    do
    {
        valeurU = Console.ReadLine();
        isSaisieValidU = double.TryParse(valeurU, out valAdd);
        if (isSaisieValidU)
        {
            valeurs.Add(valAdd);
        }
        Console.Write(" / ");
    } while (valeurU != "=" || valeurU == "0");
    {
        foreach (double item in valeurs)
        {
            div = div / item;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n = " + div);
    Console.ForegroundColor = ConsoleColor.White;
    resultats.Add(div);
    return div;
}
#endregion

/*Propose à l'utilisateur ses choix de calculs via un Switch/Case grâce à une aide visuelle
 *Cas 1 : Addition
 *Cas 2 : Soustraction
 *Cas 3 : Multiplication
 *Cas 4 : Division
 *Cas 0 : On quitte l'appli
 *Autre : Message d'erreur
On affiche et permet la navigation tant que l'utilisateur ne rentre pas 0 dans le menu */

#region Reste du code
do
{
    Console.WriteLine("\n Faites votre choix :");
    isSaisieValid = int.TryParse(Console.ReadLine(), out saisieU);
    switch (saisieU)
    {
        case 1:
            Addition();
            Console.WriteLine("\n1 ~ + ~");
            Console.WriteLine("2 ~ - ~");
            Console.WriteLine("3 ~ x ~");
            Console.WriteLine("4 ~ / ~");
            Console.WriteLine("0 ~ C");
            break;

        case 2:
            Soustraction();
            Console.WriteLine("\n1 ~ + ~");
            Console.WriteLine("2 ~ - ~");
            Console.WriteLine("3 ~ x ~");
            Console.WriteLine("4 ~ / ~");
            Console.WriteLine("0 ~ C");
            break;

        case 3:

            Multiplication();
            Console.WriteLine("\n1 ~ + ~");
            Console.WriteLine("2 ~ - ~");
            Console.WriteLine("3 ~ x ~");
            Console.WriteLine("4 ~ / ~");
            Console.WriteLine("0 ~ C");
            break;

        case 4:

            Division();
            Console.WriteLine("\n1 ~ + ~");
            Console.WriteLine("2 ~ - ~");
            Console.WriteLine("3 ~ x ~");
            Console.WriteLine("4 ~ / ~");
            Console.WriteLine("0 ~ C");
            break;

        case 0:
            Environment.Exit(0);
            break;

        default:
            Console.Clear();
            Console.WriteLine("Erreur - veuillez recommancer votre saisie");
            break;

    }
} while (saisieU != 0);
#endregion

