using DosarulMeu.Forms;
using DosarulMeu.Models;
using Firebase.Database;
using System.Linq;

namespace DosarulMeu
{
    public class DocumentCheck
    {
        public DocumentModel checkdocument(string nrreg)
        {
            DocumentModel model = new DocumentModel();
            FirebaseClient firebaseClient = new FirebaseClient("https://dosarul-meu-f665c-default-rtdb.europe-west1.firebasedatabase.app/");
            var res = firebaseClient.Child("Documente").OnceAsync<DocumentModel>().Result;
            for(int i = 0; i < res.Count; i++)
            {
                if(nrreg == res.ToList()[i].Object.NrReg)
                {
                    model = new DocumentModel
                    {
                        CNP = res.ToList()[i].Object.CNP,
                        InfoAdd = res.ToList()[i].Object.InfoAdd,
                        NrReg = res.ToList()[i].Object.NrReg,
                        NumeFisier = res.ToList()[i].Object.NumeFisier,
                        Status = res.ToList()[i].Object.Status,
                        TipDocument = res.ToList()[i].Object.TipDocument,
                    };
                }
            }

            return model;
        }
    }
}