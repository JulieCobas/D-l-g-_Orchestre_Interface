namespace Orchestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Création d'une instanciation de la classe ChefOrchestre
            ChefOrchestre co = new ChefOrchestre();

            // Appel de la méthode PréparerOrchestration sur l'instance co.
            co.PréparerOrchestration();

            // Appel de la méthode Orchestrer sur l'instance co.
            co.Orchestrer();
        }
    }
}
