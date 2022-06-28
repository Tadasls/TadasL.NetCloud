namespace P011_Metodu_Testai
{
    [TestClass]
    public class P11_Metodu_Testas
    {
        [TestMethod]
        public void KiekYraZodziu()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P10_Metodai.Program.KiekYraZodziu(fake);
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



    }
}