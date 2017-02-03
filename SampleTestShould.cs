using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using System.Globalization;

namespace OhceKata
{
    public class SampleTestShould
    {
        [Fact]
        public void TestOhceMorning()
        {
            Ohce _ohce = new Ohce();
            DateTime time = DateTime.ParseExact("20170201100000", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string message = _ohce.AnalizeInput("ohce Paco", time);
            
            Assert.Equal("¡Buenos días Paco!", message);
        }

        [Fact]
        public void TestOhceAfternoon()
        {
            Ohce _ohce = new Ohce();
            DateTime time = DateTime.ParseExact("20170201140000", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string message = _ohce.AnalizeInput("ohce Paco", time);
            
            Assert.Equal("¡Buenas tardes Paco!", message);
        }

        [Fact]
        public void TestOhceNight()
        {
            Ohce _ohce = new Ohce();
            DateTime time = DateTime.ParseExact("20170201220000", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string message = _ohce.AnalizeInput("ohce Paco", time);
            
            Assert.Equal("¡Buenas noches Paco!", message);
        }

        [Fact]
        public void TestOhceReverse()
        {
            Ohce _ohce = new Ohce();
            DateTime time = DateTime.ParseExact("20170201220000", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string message = _ohce.AnalizeInput("hola", time);

            Assert.Equal("aloh", message);
        }

        [Fact]
        public void TestOhcePalindrome()
        {
            Ohce _ohce = new Ohce();
            DateTime time = DateTime.ParseExact("20170201220000", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string message = _ohce.AnalizeInput("ana", time);

            Assert.Equal("¡Bonita palabra!", message);
        }

        [Fact]
        public void TestOhceBye()
        {
            Ohce _ohce = new Ohce();
            DateTime time = DateTime.ParseExact("20170201220000", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            string aux = _ohce.AnalizeInput("ohce Paco", time);
            string message = _ohce.AnalizeInput("Stop!", time);

            Assert.Equal("Adios Paco", message);
        }
    }
}
