using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LAP.Services.Test
{
    public class CreditScoreServiceTests
    {
        [Fact]
        public void GetAllCreditScoreProvidersTest()
        {
            var service = new CreditScore.CreditScoreService();
            var providers = service.GetAllCreditScoreProviders();

            Assert.Equal(2, providers.Count); // We have two providers at the moment

            var experian = providers.FirstOrDefault(p => p.Name.Equals("Experian", StringComparison.OrdinalIgnoreCase));
            Assert.Equal(typeof(CreditScore.ExperianCreditScoreProvider), experian.GetType());

            var equifax = providers.FirstOrDefault(p => p.Name.Equals("Equifax", StringComparison.OrdinalIgnoreCase));
            Assert.Equal(typeof(CreditScore.EquifaxCreditScoreProvider), equifax.GetType());
        }

        [Fact]
        public void CreditScoreService_GetCreditScore_NullArgumentExceptionTest()
        {
            var service = new CreditScore.CreditScoreService();
            Exception ex = Assert.Throws<ArgumentNullException>(() => service.GetCreditScore(null, null, new DateTime(), null, null));
            Assert.Equal("firstName", (ex as ArgumentException).ParamName);

            Exception ex2 = Assert.Throws<ArgumentNullException>(() => service.GetCreditScore("first", null, new DateTime(), null, null));
            Assert.Equal("lastName", (ex2 as ArgumentException).ParamName);

            Exception ex3 = Assert.Throws<ArgumentNullException>(() => service.GetCreditScore("first", "second", new DateTime(), null, null));
            Assert.Equal("dateOfBirth", (ex3 as ArgumentException).ParamName);

            Exception ex4 = Assert.Throws<ArgumentNullException>(() => service.GetCreditScore("first", "second", DateTime.Now, null, null));
            Assert.Equal("postCode", (ex4 as ArgumentException).ParamName);

            Exception ex5 = Assert.Throws<ArgumentNullException>(() => service.GetCreditScore("first", "second", DateTime.Now, "RG1 9YZ", null));
            Assert.Equal("creditScoreProviders", (ex5 as ArgumentException).ParamName);
        }

        [Theory]
        [InlineData(300, 2000, 1, 1)]
        [InlineData(450, 1990, 1, 1)]
        [InlineData(800, 1980, 1, 1)]
        [InlineData(650, 1970, 1, 1)]
        [InlineData(650, 1960, 1, 1)]
        public void CreditScoreService_GetCreditScore_ReturnValueTest(int expectedCreditScrore, int year, int month, int day)
        {
            var service = new CreditScore.CreditScoreService();
            var creditScore = service.GetCreditScore("Ethen", "Hunt", new DateTime(year, month, day), "RG1 9YZ", new List<string> { "Experian", "Equifax" });
            Assert.Equal(expectedCreditScrore, creditScore);
        }

    }
}
