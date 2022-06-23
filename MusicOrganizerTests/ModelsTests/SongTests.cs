using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.TestTools
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Song.ClearAll();
    }
    [TestMethod]
    public void SongConstructor_CreatesInstanceOfSong_Song()
    {
      Song newSong = new Song("test");
      Assert.AreEqual(typeof(Song), newSong.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescrption_String()
    {
      string description = "Walk the dog.";
      Song newSong = new Song(description);
      string result = newSong.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_SongList()
    {
      List<Song> newList = new List<Song>();
      List<Song> result = Song.GetAll();
      foreach (Song thisSong in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisSong.Description);
      }
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "Walk the dog.";
      Song newSong = new Song(description);
      int result = newSong.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Song newSong = new Song(description);
      string updatedDescription = "Do the dishes";
      newSong.Description = updatedDescription;
      string result = newSong.Description;
      Assert.AreEqual(updatedDescription,result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectSong_Song()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Song newSong1 = new Song(description01);
      Song newSong2 = new Song(description02);
      Song result = Song.Find(2);
      Assert.AreEqual(newSong2, result);
    }
    [TestMethod]
    public void GetAll_Returns_SongList()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Song newSong1 = new Song(description01);
      Song newSong2 = new Song(description02);
      List<Song> newList = new List<Song> { newSong1, newSong2};
      List<Song> result = Song.GetAll();
      foreach (Song thisSong in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisSong.Description);
      }
      CollectionAssert.AreEqual(newList, result);
    }
  }
}