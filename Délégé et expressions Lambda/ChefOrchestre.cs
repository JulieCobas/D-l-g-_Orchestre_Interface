using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestre
{
    internal class ChefOrchestre
    {
        // Déclaration d'un délégué. Un délégué est un type qui représente des références à des méthodes avec une liste de paramètres et un type de retour spécifique.
        delegate void DelegueJouerInstrument();

        // Déclaration d'une variable de type DelegueJouerInstrument, qui peut contenir des références à des méthodes.
        private DelegueJouerInstrument JouerInstrument; //Type de retour = Inféré car même si on mets un paramètre on

        // Création d'instances de Violoniste et Guitariste.
        private Violoniste violoniste = new Violoniste();
        private Guitariste guitariste = new Guitariste();

        // Méthode pour préparer l'orchestration
        public void PréparerOrchestration()
        {
            // Ajout de références aux méthodes JouerDuViolon et JouerDeLaGuitare au délégué JouerInstrument.
            this.JouerInstrument += violoniste.JouerDuViolon; //L'utilisation de l'opérateur += signifique que les références de ces méthodes sont ajoutées à la liste
            this.JouerInstrument += violoniste.JouerDuViolon; //des méthodes que le délégué peut appeler.
            this.JouerInstrument += guitariste.JouerDeLaGuitare; 

        }

        // Méthode pour orchestrer, c'est-à-dire exécuter les méthodes référencées par le délégué.
        public void Orchestrer()
        {
            //this.JouerInstrument -= violoniste.JouerDuViolon;
            // Invocation du délégué, ce qui entraîne l'appel des méthodes référencées.
            JouerInstrument();
        }

    }
}
//Dans ce code, les délégués sont utilisés pour référencer des méthodes (ici, 
//JouerDuViolon et JouerDeLaGuitare) qui peuvent ensuite être appelées via le délégué. 
//C'est une façon de déléguer l'exécution de méthodes à un autre objet ou méthode, d'où 
//e nom "délégué". Les expressions lambda ne sont pas utilisées dans cet exemple, mais 
//elles peuvent également être assignées à des délégués pour exécuter de petits 
//fragments de code de manière succincte.