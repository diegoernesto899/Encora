using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestEncora;
namespace TestProjectEncora
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestingSortWordsEncora()
        {
            testCaseInput1();
            testCaseInput2();
            testCaseInput3();
            testCaseInput4();
            testCaseInput5();
        }

        public static void testCaseInput1()
        {

            string[] wordsArray = new string[2];
            wordsArray[0] = "abaccadcc";
            wordsArray[1] = "xyzxy";
            string[] result = TestEncora.Program.sortingOperations(wordsArray);
            Assert.AreEqual("ccccaaabd", result[0]);
            Assert.AreEqual("xxyyz", result[1]);
        }
        public static void testCaseInput2()
        {

            string[] wordsArray = new string[10];
            wordsArray[0] = "dulgvgzwqg";
            wordsArray[1] = "gxtjtmtywr";
            wordsArray[2] = "hnlnxiupgt";
            wordsArray[3] = "gzjotckivp";
            wordsArray[4] = "dpwwsdptae";
            wordsArray[5] = "pcscpilknb";
            wordsArray[6] = "btvyhhmflf";
            wordsArray[7] = "artrtnqxcr";
            wordsArray[8] = "nrtcmcoadn";
            wordsArray[9] = "fkdsgnekft";

            string[] result = TestEncora.Program.sortingOperations(wordsArray);
            Assert.AreEqual("gggdlquvwz", result[0]);
            Assert.AreEqual("tttgjmrwxy", result[1]);
            Assert.AreEqual("nnghilptux", result[2]);
            Assert.AreEqual("cgijkoptvz", result[3]);
            Assert.AreEqual("ddppwwaest", result[4]);
            Assert.AreEqual("ccppbiklns", result[5]);
            Assert.AreEqual("ffhhblmtvy", result[6]);
            Assert.AreEqual("rrrttacnqx", result[7]);
            Assert.AreEqual("ccnnadmort", result[8]);
            Assert.AreEqual("ffkkdegnst", result[9]);
        }

        public static void testCaseInput3()
        {
            string[] wordsArray = new string[10];
            wordsArray[0] = "wzenwebuau";
            wordsArray[1] = "vokfxzynwl";
            wordsArray[2] = "neldfeyrxk";
            wordsArray[3] = "wqadfiodgs";
            wordsArray[4] = "ykiuvzfcbc";

            string[] result = TestEncora.Program.sortingOperations(wordsArray);
            Assert.AreEqual("eeuuwwabnz", result[0]);
            Assert.AreEqual("fklnovwxyz", result[1]);
            Assert.AreEqual("eedfklnrxy", result[2]);
            Assert.AreEqual("ddafgioqsw", result[3]);
            Assert.AreEqual("ccbfikuvyz", result[4]);
        }

        public static void testCaseInput4()
        {

            string[] wordsArray = new string[10];
            wordsArray[0] = "qakmc";
            wordsArray[1] = "rrtbk";
            wordsArray[2] = "vaixn";
            wordsArray[3] = "wmpnj";
            wordsArray[4] = "uproi";
            wordsArray[5] = "btska";
            wordsArray[6] = "ejqwr";
            wordsArray[7] = "elwlg";
            wordsArray[8] = "oaoiy";
            wordsArray[9] = "hrqkn";

            string[] result = TestEncora.Program.sortingOperations(wordsArray);
            Assert.AreEqual("ackmq", result[0]);
            Assert.AreEqual("rrbkt", result[1]);
            Assert.AreEqual("ainvx", result[2]);
            Assert.AreEqual("jmnpw", result[3]);
            Assert.AreEqual("iopru", result[4]);
            Assert.AreEqual("abkst", result[5]);
            Assert.AreEqual("ejqrw", result[6]);
            Assert.AreEqual("llegw", result[7]);
            Assert.AreEqual("ooaiy", result[8]);
            Assert.AreEqual("hknqr", result[9]);
        }

        public static void testCaseInput5()
        {
            string[] wordsArray = new string[10];
            wordsArray[0] = "pzjim";
            wordsArray[1] = "njnfq";
            wordsArray[2] = "xyohs";

            string[] result = TestEncora.Program.sortingOperations(wordsArray);
            Assert.AreEqual("ijmpz", result[0]);
            Assert.AreEqual("nnfjq", result[1]);
            Assert.AreEqual("hosxy", result[2]);

        }
    }
}