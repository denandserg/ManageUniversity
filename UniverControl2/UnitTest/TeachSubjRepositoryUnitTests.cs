using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniverControl;

namespace UnitTestProject
{
    /// <summary>
    /// Test TeachSubj Repository
    /// </summary>
    [TestClass]
    public class TeachSubjepositoryUnitTest
    {
        UniverControlDbContext _context = new UniverControlDbContext("UniverControlTest");
        [TestMethod]
        public void AddItemTest()
        {
            var repo = new TeachSubjRepository(_context);
            var item = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x=>x.Id==1),
                Subject = _context.Subjects.FirstOrDefault(x=>x.Id==1)
            };
            repo.AddItem(item);
            var newitem = _context.TeachSubjs.FirstOrDefault(x => x.Teacher.Id == item.Teacher.Id 
                                                    && x.Subject.Id == item.Subject.Id);
            Assert.AreEqual(item.Teacher.Id, newitem.Teacher.Id);
            Assert.AreEqual(item.Subject, newitem.Subject.Id);
            _context.TeachSubjs.Remove(item);
        }

        [TestMethod]
        public void AllItemsTest()
        {
            var repo = new TeachSubjRepository(_context);
            Assert.AreEqual(_context.TeachSubjs.Count(), repo.AllItems.Count());
            var item1 = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x => x.Id == 2),
                Subject = _context.Subjects.FirstOrDefault(x => x.Id == 2)
            };
            repo.AddItem(item1);
            Assert.AreEqual(_context.TeachSubjs.Count(), repo.AllItems.Count());
            _context.TeachSubjs.Remove(item1);
        }
        [TestMethod]
        public void GetItemTest()
        {
            var repo = new TeachSubjRepository(_context);
            var item = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x => x.Id == 1),
                Subject = _context.Subjects.FirstOrDefault(x => x.Id == 1)
            };
            repo.AddItem(item);
            int Id = _context.TeachSubjs.FirstOrDefault(x => x.Teacher.Id == item.Teacher.Id
                                                    && x.Subject.Id == item.Subject.Id).Id;
            var newitem = repo.GetItem(Id);
            Assert.AreEqual(item.Teacher.Id, newitem.Teacher.Id);
            Assert.AreEqual(item.Subject, newitem.Subject.Id);
            _context.TeachSubjs.Remove(item);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetItemExceptionTest()
        {
            var repo = new TeachSubjRepository(_context);
            var item1 = repo.GetItem(-1).Subject.Id;
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteItemTest()
        {
            var repo = new TeachSubjRepository(_context);
            var item = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x => x.Id == 1),
                Subject = _context.Subjects.FirstOrDefault(x => x.Id == 1)
            };
            repo.AddItem(item);
            int Id = _context.TeachSubjs.FirstOrDefault(x => x.Teacher.Id == item.Teacher.Id
                                                    && x.Subject.Id == item.Subject.Id).Id;
            var newitem = repo.GetItem(Id);
            Assert.AreEqual(item.Teacher.Id, newitem.Teacher.Id);
            Assert.AreEqual(item.Subject, newitem.Subject.Id);
            repo.DeleteItem(Id);
            Assert.AreEqual(item.Teacher.Id, repo.GetItem(Id).Teacher.Id);
        }

        [TestMethod]
        public void AddItemsTest()
        {
            var repo = new TeachSubjRepository(_context);
            var item1 = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x => x.Id == 2),
                Subject = _context.Subjects.FirstOrDefault(x => x.Id == 2)
            };
            var item2 = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x => x.Id == 1),
                Subject = _context.Subjects.FirstOrDefault(x => x.Id == 1)
            };
            TeachSubj[] items = new TeachSubj[] { item1, item2 };

            repo.AddItems(items);
            var newitem1 = _context.TeachSubjs.FirstOrDefault(x => x.Teacher.Id == item1.Teacher.Id
                                                    && x.Subject.Id == item1.Subject.Id);
            var newitem2 = _context.TeachSubjs.FirstOrDefault(x => x.Teacher.Id == item2.Teacher.Id
                                                    && x.Subject.Id == item2.Subject.Id);

            Assert.AreEqual(items[0].Teacher.Id, newitem1.Teacher.Id);
            Assert.AreEqual(items[0].Subject.Id, newitem1.Subject.Id);
            Assert.AreEqual(items[1].Teacher.Id, newitem2.Teacher.Id);
            Assert.AreEqual(items[1].Subject.Id, newitem2.Subject.Id);
            _context.TeachSubjs.Remove(item1);
            _context.TeachSubjs.Remove(item2);
        }
        [TestMethod]
        public void ChangeItemTest()
        {
            var repo = new TeachSubjRepository(_context);
            var item = new TeachSubj
            {
                Teacher = _context.Teachers.FirstOrDefault(x => x.Id == 1),
                Subject = _context.Subjects.FirstOrDefault(x => x.Id == 1)
            };
            repo.AddItem(item);
            int Id = _context.TeachSubjs.FirstOrDefault(x => x.Teacher.Id == item.Teacher.Id
                                                    && x.Subject.Id == item.Subject.Id).Id;
            var newitem = repo.GetItem(Id);
            newitem.Subject.Id = 4;
            repo.ChangeItem(newitem);
            var gotitem = repo.GetItem(Id);
            Assert.AreEqual(newitem.Teacher.Id, gotitem.Teacher.Id);
            Assert.AreEqual(newitem.Subject.Id, gotitem.Subject.Id);
            _context.TeachSubjs.Remove(newitem);
        }
    }
}
