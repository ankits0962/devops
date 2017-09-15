using Ploeh.AutoFixture.Xunit2;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace CakeDemo.Tests
{
    public class ProgramTests
    {
        [Theory, AutoData]
        public void Should_return_Hello_Name(string name)
        {
            var result = Program.SayHello(name);
            result.ShouldBe($"Hello {name}");
        }

        [Theory, AutoData]
        public void Should_return_Bye_Name(string name)
        {
            var result = Program.SayGoodBye(name);
            result.ShouldBe($"GoodBye {name}");
        }
        [Theory, AutoData]
        public void Should_return_List(List<string> names)
        {
            names.Add("X");
            names.Add("Y");
            names.Add("Z");

            var result = Program.GetNames();
            result.ShouldBe(names);
        }
    }
}
