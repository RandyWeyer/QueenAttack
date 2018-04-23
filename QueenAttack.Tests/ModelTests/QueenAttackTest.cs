using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void CanQueenAttack_Horizontal_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.CanQueenAttack(0,0,1,0));
    }
    [TestMethod]
    public void CanQueenAttack_Vertical_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.CanQueenAttack(0,0,0,1));
    }
    [TestMethod]
    public void CanQueenAttack_Diagonal_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.CanQueenAttack(4,4,2,2));
    }
    [TestMethod]
    public void CanQueenAttack_Diagonal_X_False()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(false, testQueenAttack.CanQueenAttack(0,0,1,2));
    }
    [TestMethod]
    public void CanQueenAttack_Diagonal_Y_False()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(false, testQueenAttack.CanQueenAttack(0,0,2,1));
    }
    [TestMethod]
    public void CanQueenAttack_Diagonal_EdgeOfBoard_True()
    {
      QueenAttack testQueenAttack = new QueenAttack();
      Assert.AreEqual(true, testQueenAttack.CanQueenAttack(0,0,7,7));
    }
  }
}
