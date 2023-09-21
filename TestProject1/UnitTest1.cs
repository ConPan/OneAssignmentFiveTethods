namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string nameFirst = "gerTrude";
            string nameLast = "Stein";
            string expected = "STEIN, Gertrude";
            string actual = OneAssignmentFiveTethods.Trial.MyFifthMethod(nameFirst, nameLast);

            Assert.Equal(expected, actual);
        }
    }
}