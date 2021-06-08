using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSBcr.modele;
using GSBCR.BLL;
using System.Collections.Generic;

namespace UnitTestGSBCR.BLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChargerVisiteur()
        {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "visiteur a131 avec mot de passe 30BFD069 non chargé");
            VISITEUR v1 = VisiteurManager.ChargerVisiteur("a131", "aaa");
            Assert.IsNull(v1, "visiteur a131 à été chargé avec un mot de passe faux");
        }
        public void TestChargerVisiteurEnCours()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours("a131");
            foreach(RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "rapport visite n'appartient pas au matricule a131");
                Assert.AreEqual("1", r.RAP_ETAT, "état différent de 1");
                ok = (r.RAP_NUM >= 59 && r.RAP_NUM <= 62);
                Assert.IsTrue(ok, "pb dans les n° de rapport");
            }
        }
    }
}
