using Xunit;
using System.Collections.Generic;

namespace Parejas
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.AdmitenDescendencia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {       
            new object[] { new Persona("Pepega", 35, 'F') , new Persona("Pepeg", 32, 'M'), true},
            new object[] { new Persona("Pepega", 70, 'M') , new Persona("Pepeg", 35, 'F'), false},
            new object[] { new Persona("Pepega", 31, 'F') , new Persona("Pepeg", 44, 'M'), false},
            new object[] { new Persona("Pepega", 31, 'F') , new Persona("Pepeg", 34, 'F'), false},
            new object[] { new Persona("Pepega", 43, 'M') , new Persona("Pepeg", 38, 'M'), false},
     
        };

    }
}