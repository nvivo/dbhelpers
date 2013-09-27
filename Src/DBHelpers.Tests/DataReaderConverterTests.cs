using NUnit.Framework;
using System.Data.Common;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DataReaderConverterTests
    {
        [Test]
        public void ConvertByName()
        {
            var reader = CreateReader();
            reader.Read();

            var converter = new DataReaderConverter<MockProviderFactory.DataReaderModel>();

            var model = converter.Convert(reader);

            Assert.IsNotNull(model);
            Assert.AreEqual(reader["IntCol"], model.IntCol);
            Assert.AreEqual(reader["StringCol"], model.StringCol);
            Assert.AreEqual(reader["DateCol"], model.DateCol);
            Assert.IsNull(model.UnmappedCol);
        }

        private DbDataReader CreateReader()
        {
            var factory = new MockProviderFactory();
            var reader = factory.CreateReader();
            return reader;
        }
    }
}
