namespace application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Saisir le nom du client");
            string ch = Console.ReadLine();
            Client cl = new Client(ch);


            Console.WriteLine("Voulez-vous ajouter une cargaison ? (O/N)");
            string g = Console.ReadLine();

            int indice = 0;
            while (g.ToUpper() == "O")
                {

                
                Console.WriteLine("Saisir la distance");
                int d = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Voulez-vous ajouter une cargaison aerienne ou routiere ? (A/R)");
                    ch = Console.ReadLine();

                } while (ch.ToUpper() != "A" && ch.ToUpper() != "R");

                if (ch.ToUpper() == "A")
                {
                    cl.AddCargaison(new CargaisonAerienne(d));

                    do
                    {
                        Console.WriteLine("Voulez-vous ajouter une marchandise ? (O/N)");
                        ch = Console.ReadLine();

                        if (ch.ToUpper() == "O")
                        {
                            Console.WriteLine("Saisir le numero de la marchandise ");
                            int nm = int.Parse(Console.ReadLine());

                            Console.WriteLine("Saisir le poids de la marchandise");
                            double pm = double.Parse(Console.ReadLine());

                            Console.WriteLine("Saisir le volume de la marchandise");
                            double vm = double.Parse(Console.ReadLine());

                            cl.AddMarchandise(new Marchandise(nm, pm, vm), indice);
                        }

                    } while (ch.ToUpper() != "N");

                    indice++;
                }

                else
                {
                    cl.AddCargaison(new CargaisonRoutiere(d));

                    do
                    {
                        Console.WriteLine("Voulez-vous ajouter une marchandise ? (O/N)");
                        ch = Console.ReadLine();

                        if (ch.ToUpper() == "O")
                        {
                            Console.WriteLine("Saisir le numero de la marchandise ");
                            int nm = int.Parse(Console.ReadLine());

                            Console.WriteLine("Saisir le poids de la marchandise");
                            double pm = double.Parse(Console.ReadLine());

                            Console.WriteLine("Saisir le volume de la marchandise");
                            double vm = double.Parse(Console.ReadLine());

                            cl.AddMarchandise(new Marchandise(nm, pm, vm), indice);
                        }

                    } while ( ch.ToUpper() != "N");

                    indice++;
                }

                Console.WriteLine("Voulez-vous ajouter une autre cargaison ? (O/N)");
                g = Console.ReadLine();

            }

            Console.WriteLine("Le cout total est = " + cl.GetCoutTotal());



        }
    }
}
