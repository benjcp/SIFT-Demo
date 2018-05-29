using Emgu.CV;
using Emgu.CV.CvEnum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIFTDemo.Tests
{
    [TestClass()]
    public class FeatureMatchTests
    {
        [TestMethod()]
        public void FindMatchTest()
        {
            long matchTime;
            using (Mat modelImage = CvInvoke.Imread(@"C:\\imgs\Model.jpeg", ImreadModes.Color))
            using (Mat observedImage = CvInvoke.Imread(@"C:\\imgs\Test.jpg", ImreadModes.Color))
            {
                Mat result = FeatureMatch.Draw(modelImage, observedImage, out matchTime);
            }
        }
    }
}