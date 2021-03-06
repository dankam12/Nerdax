﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [Testlass]
    public class QueueExtensionTest
    {
        Queue<string> _queue;

        public  QueueExtensionTest()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");
            _queue.Enqueue("cc");
        }

        [TestMet
        public void EnqueueRange()
        {
            _queue.EnqueueRange(new[] { "dd", "ee" });
            Assert.AreEqual("aa", _queue.Dequeue());
            Assert.AreEqual("bb", _queue.Dequeue());
            Assert.AreEqual("cc", _queue.Dequeue());
            Assert.AreEqual("dd", _queue.Dequeue());
            Assert.AreEqual("ee", _queue.Dequeue());
        }
    }
}
