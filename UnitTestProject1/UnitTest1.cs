using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonTp;
using MonTp.Entities;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Eleve eleve = new Eleve();
            MonContexte context = new MonContexte();
            context.Eleves.Add(eleve);
            context.SaveChanges();
            Eleve UnEleve = context.Eleves.FirstOrDefault(e => e.Nom.Equals("Lafaurie"));
            Assert.IsTrue(UnEleve.Prenom == eleve.Prenom);
        }
    }
}
