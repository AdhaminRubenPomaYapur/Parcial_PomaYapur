using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialAdhaminPomaYapur.Controllers;
using ParcialAdhaminPomaYapur.Models;

namespace UnitTestPomaYapur
{
    [TestClass]
    public class UnitTestPoma
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arange
            CountriesController countriesController = new CountriesController();
            Country country_expected = new Country()
            {
                alpha3Code = "Col",
                region = "Americas",
                name = "Colombia",
                area = 1258639,
                CallingCodes = 57,
                languages = "Castellano",
                flag = "https://upload.wikimedia.org/wikipedia/commons/4/48/Flag_of_Bolivia.svg"

            };
            //Act
            var listado = countriesController.GetCountries();
            var respuesta = countriesController.GetCountry(country_expected.alpha3Code);
            var actual = respuesta as OkNegotiatedContentResult<Country>;
            //Assert
            Assert.IsNotNull(listado);
            Assert.IsNull(actual);
            
        }
    }
}
