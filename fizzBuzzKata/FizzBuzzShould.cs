using System.Collections.Generic;
using NUnit.Framework;

namespace fizzBuzzKata
{
    [TestFixture]
    public class FizzBuzzShould
    {
        private Fizz _fizz;
        private Buzz _buzz;
        private FizzBuzzKata _fizzBuzzKata;

        [SetUp]
        public void SetUp()
        {
            _fizz = new Fizz();
            _buzz= new Buzz();
            _fizzBuzzKata = new FizzBuzzKata();
        }
        
        [Test]
        public void ReturnOneIfReceiveOne()
        {
            CollectionAssert.AreEqual(new List<string>(new[] {"1"}),_fizzBuzzKata.Calculate(new List<string>(new[] {"1"})));
        }
        
        [Test]
        public void ReturnFizzIfReceiveThree()
        {
            CollectionAssert.AreEqual(new[]{_fizz.getName()},_fizzBuzzKata.Calculate(new List<string>(new[] {"3"})));
        }
        
        [Test]
        public void ReturnBuzzIfReceiveFive()
        {
            CollectionAssert.AreEqual(new[]{_buzz.getName()},_fizzBuzzKata.Calculate(new List<string>(new[] {"5"})));
        }
        
        [Test]
        public void ReturnFizzBuzzIfReceiveMultiplyOfThreeAndFive()
        {
            CollectionAssert.AreEqual(new[]{"FizzBuzz"},_fizzBuzzKata.Calculate(new List<string>(new[] {"15"})));
        }

        [Test]
        public void ReturnArrayConvertedWithFizzBuzz()
        {
            CollectionAssert.AreEqual(new[]{"FizzBuzz", _fizz.getName(), _buzz.getName(), "7"},
                _fizzBuzzKata.Calculate(new List<string>(new[] {"15","3","5","7"})));
        }
    }
}