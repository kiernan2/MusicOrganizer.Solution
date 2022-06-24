using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizer.TestTools
{
  [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Disk.ClearAll();
    }
    [TestMethod]
    public void DiskConstructor_CreatesInstanceOfDisk_Disk()
    {
      Disk newDisk = new Disk("test disk");
      Assert.AreEqual(typeof(Disk), newDisk.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Disk";
      Disk newDisk = new Disk(name);

      int result = newDisk.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllDiskObjects_DiskList()
    {
      string name01 = "Work";
      string name02 = "School";
      Disk newDisk1 = new Disk(name01);
      Disk newDisk2 = new Disk(name02);
      List<Disk> newList = new List<Disk> { newDisk1, newDisk2 };

      List<Disk> result = Disk.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectDisk_Disk()
    {
      string name01 = "Work";
      string name02 = "School";
      Disk newDisk1 = new Disk(name01);
      Disk newDisk2 = new Disk(name02);

      Disk result = Disk.Find(2);

      Assert.AreEqual(newDisk2, result);
    }
  }
}