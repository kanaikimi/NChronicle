using Microsoft.VisualStudio.TestTools.UnitTesting;
using KSharp.NChronicle.Core.Model;
using System.Collections.Generic;
using KSharp.NChronicle.Core.Tests.ForChronicle;

namespace KSharp.NChronicle.Core.Tests.ForChronicle
{
    public partial class WhenUsingAChronicle
    {

        [TestClass]
        public class AndRecordingAMessage : WhenUsingAChronicleTestBase
        {

            private new static IEnumerable<object[]> _chronicleLevel => WhenUsingAChronicleTestBase._chronicleLevel;

            [TestMethod]
            [DynamicData(nameof(_chronicleLevel))]
            public void ThenAChronicleRecordIsReceived(ChronicleLevel level)
            {
                // Act
                CallAction(level, _message);

                // Assert
                Assert.IsNotNull(_lastReceivedRecord, "No ChronicleRecord was received.");
            }

            [TestMethod]
            [DynamicData(nameof(_chronicleLevel))]
            public void ThenTheChronicleLevelIsAsRecorded(ChronicleLevel level)
            {
                // Act
                CallAction(level, _message);

                // Assert
                Assert.IsNotNull(_lastReceivedRecord, "No ChronicleRecord was received.");
                Assert.AreEqual(level, _lastReceivedRecord.Level, "Incorrect ChronicleLevel on received ChronicleRecord.");
            }

            [TestMethod]
            [DynamicData(nameof(_chronicleLevel))]
            public void ThenTheMessageIsAsRecorded(ChronicleLevel level)
            {
                // Act
                CallAction(level, _message);

                // Assert
                Assert.IsNotNull(_lastReceivedRecord, "No ChronicleRecord was received.");
                Assert.AreEqual(_message, _lastReceivedRecord.Message, "Message in received ChronicleRecord is not as recorded.");
            }

            [TestMethod]
            [DynamicData(nameof(_chronicleLevel))]
            public void ThenThereIsNoException(ChronicleLevel level)
            {
                // Act
                CallAction(level, _message);

                // Assert
                Assert.IsNotNull(_lastReceivedRecord, "No ChronicleRecord was received.");
                Assert.IsNull(_lastReceivedRecord.Exception, "An Exception is unexpectedly attached to the received ChronicleRecord.");
            }

            [TestMethod]
            [DynamicData(nameof(_chronicleLevel))]
            public void ThenThereAreNoTags(ChronicleLevel level)
            {
                // Act
                CallAction(level, _message);

                // Assert
                Assert.IsNotNull(_lastReceivedRecord, "No ChronicleRecord was received.");
                Assert.IsFalse(this._lastReceivedRecord.Tags.GetEnumerator().MoveNext(), "Unexpected tags in received ChronicleRecord");
            }

        }
    }
}