namespace P011_Metodu_Testai
{
    [TestClass]
    public class P11_Metodu_Testas
    {
        [TestMethod]
        public void TekstoIlgisBeTarpu()
        {
            var fake = " as mokausi      ";
            var expected = 7;
            var actual = P10_Metodai.Program.TekstoIlgisBeTarpu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraZodziu2()
        {
            var fake = "as mokausi programuoti       ";
            var expected = 3;
            var actual = P10_Metodai.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekYraZodziu3()
        {
            var fake = "as mokausi       programuoti";
            var expected = 3;
            var actual = P10_Metodai.Program.KiekYraZodziu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KiekYraTarpuPriekyjeIrGale()
        {
            var fake = " as mokausi      ";
            var expectedPriekyje = 1;
            var expectedGale = 6;

            P10_Metodai.Program.KiekYraTarpuPriekyjeIrGale(
                fake,
                out int actualPriekyje,
                out int actualGale);

            Assert.AreEqual(expectedPriekyje, actualPriekyje);
            Assert.AreEqual(expectedGale, actualGale);

        }
        [TestMethod]
        public void TarpaiGale_Test()
        {
            var fake = " rtwt  ";
            var expected = 2;
            var actual = P10_Metodai.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TarpaiPradzioje_Test()
        {
            var fake = " rtwt  ";
            var expected = 1;
            var actual = P10_Metodai.Program.TarpaiPradzioje(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekYraTarpuPriekyjeIrGale_test()
        {
            var fake = " rtwt  ";
            var expected = 1;
            var actual = P10_Metodai.Program.KiekYraTarpuPriekyjeIrGale(fake, out int tarpaiGale);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KiekYraTarpuPriekyjeIrGale_test2()
        {
            var fake = " rtwt  ";
            var expected1 = 1;
            var expected2 = 2;
            var actual1 = P10_Metodai.Program.KiekYraTarpuPriekyjeIrGale(fake, out int actual2);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void KiekYraARaidziuTekste()
        {
            var fake = " as mokausi programuoti ";
            var expected = 3;
            var actual1 = P10_Metodai.Program.KiekYraARaidziuTekste(fake);
            Assert.AreEqual(expected, actual1);
            
        }



        [TestMethod]
        public void ArYraZodisMokausi11a_Test()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiTekste(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi11a_Test1()
        {
            var fake = " as_labai_mokausi_programuoti     ";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiTekste(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraZodisMokausi11a_Test2()
        {
            var fake = " as_labai_MOKAUSI_programuoti     ";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiTekste(fake);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_Test0()
        {
            var fake = " as_labai_mokausi_programuoti     ";
            var expected = "Ne";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_Test1()
        {
            var fake = "mokausi programuoti labai         ";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_Test2()
        {
            var fake = "";
            var expected = "Ne";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_1Test()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_2Test()  // praina nes turi nepraeiti 
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "Ne";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_3Test()
        {
            var fake = "mokausi programuoti labai    ";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_4Test()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_5Test()
        {
            var fake = "as mokausi!";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_6Test()
        {
            var fake = "as mokausi?";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_7Test()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "Taip";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ArYraNesulipesZodisMokausi11b_8Test()
        {
            var fake = "as studijuojumokausi)";
            var expected = "Ne";
            var actual = P10_Metodai.Program.IeskomeZodzioMokausiEkstraTekste(fake);
            Assert.AreEqual(expected, actual);
        }






    }
}