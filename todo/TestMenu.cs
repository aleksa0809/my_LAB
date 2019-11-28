using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace todo {
[TestFixture]
public class TestMenu{
    [TestCase("abc", -1)]
    [TestCase("0", -1)]
    [TestCase("1",0)]
    [TestCase("2",1)]
    [TestCase("999", -1)]

     public void Should_Return_Correct_Position(string answer, int pos)
        {
            List <Task> list = new List <Task> ();
            list.Add(new Task());
             list.Add(new Task());
              list.Add(new Task());
            var result = new Menu("Z").GetPosition(answer,list);
            Assert.AreEqual(pos, result);
        }
    
/*
        [TestCase(2, 4, 6)]
        [TestCase(1, 0, 1)]
        [TestCase(10, -2, 8)]
        public void Should_Return_Sum_Given_Ints(int x, int y, int z)
        {
            var result = Program.AddInts(x, y);
            Assert.AreEqual(z, result);
        }
    }*/
}
}