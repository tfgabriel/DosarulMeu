using DosarulMeu.Models;
using System;

namespace DosarulMeu
{
    public class DocumentCreate
    {
        public DocumentModel newdoc(int CNP, string tipdocument)
        {
            Random rnd = new Random();
            int nrdoc = rnd.Next(0, 1000);
            string nrreg = nrdoc.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() ;
            string numefisier = nrdoc.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            DocumentModel model = new DocumentModel
            {
                CNP = CNP,
                NrReg = nrreg,
                TipDocument = tipdocument,
                Status = "Se procesează",
                InfoAdd = "-",
                NumeFisier = numefisier
            };

            return model;
        }


    }
}