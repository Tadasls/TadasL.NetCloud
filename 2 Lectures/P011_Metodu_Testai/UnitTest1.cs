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



    }
}