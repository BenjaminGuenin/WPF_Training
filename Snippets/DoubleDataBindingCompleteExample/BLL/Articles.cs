using System.Collections.Generic;

namespace DoubleDataBindingCompleteExample.BLL
{
    public class Articles
    {
        public List<Article> ListeArticles { get; private set; }
        
        public Article Australie;

        public Articles()
        {
            var a1 = new Article { CodeVoyage = "AUS", Destination = "Australie", Description = "L'Australie fascinante", Duree = 15, Prix = 3365, Promotion = true };
            var a2 = new Article { CodeVoyage = "NEW", Destination = "New York", Description = "Découverte d'une ville unique et trépidante", Duree = 7, Prix = 1460 };
            var a3 = new Article { CodeVoyage = "TNS", Destination = "Tunisie", Description = "Mer, soleil, sable et oasis", Duree = 8, Prix = 745 };

            ListeArticles = new List<Article> {a1, a2, a3};

            Australie = a1;
        }
    }
}
