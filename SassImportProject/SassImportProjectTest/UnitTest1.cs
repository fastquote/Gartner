namespace SassImportProjectTest
{

    using System;
    using Xunit;
    using SassImportProject.BusinessLayer;
    using Moq;
    using SassImportProject.Contracts;
    using System.Threading.Tasks;
   

    namespace SassProductImportTest
    {
        public class UnitTest1
        {
            private readonly ReadTextFile _sut;
            private readonly Mock<IReadTextFile> _mock = new Mock<IReadTextFile>();

            public UnitTest1()
            {
                _sut = new ReadTextFile();
            }


            [Fact]
            public async Task readTextFilesTest()
            {
                var filePath = @"D:\Users\ritika.ranjan\Desktop\file.txt";
                _mock.Setup(x => x.readTextFiles(filePath));
                bool result = await _sut.readTextFiles(filePath);
                Assert.True(result);
            }
        }
    }

}