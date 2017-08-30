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
        /// Constructeur permettant d'initialiser l'attribut.
        /// </summary>
        /// <param name="iKekChose">
        /// Valeur passée pour initialiser l'attribut (25 par défaut).
        /// </param>
        public Bidule (int iKekChose = 25)
        {
            m_iKekChose = iKekChose;
        }
    }
}