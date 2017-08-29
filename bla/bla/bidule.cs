/******************************************************************************
 * Classe:  Bidule
 * 
 * Auteur:  Le Prof
 * 
 * But:     Créer une classe bidon à ajouter à un projet distribué à l'aide de
 *          Git.
 *****************************************************************************/
 
 namespace Machin
{
    public class Bidule
    {
        /// <summary>
        /// Attribut servant à stoker quelque chose d'insignifiant.
        /// </summary>
        private int m_iKekChose;

        /// <summary>
        /// Constructeur servant à initialiser l'attribut lors de la création
        /// d'un objet de la classe. L'attribut est initialisé arbitrairement
        /// à la valeur 25.
        /// </summary>
        public Bidule ()
        {
            m_iKekChose = 25;
        }
    }
}